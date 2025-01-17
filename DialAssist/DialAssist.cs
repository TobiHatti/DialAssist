﻿using MetroSet_UI.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DialAssist
{
    public partial class DialAssist : MetroSetForm
    {
        private readonly string DataFile = $@"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}\LH-DialAssist\phonebook.db";
        private readonly string ConString = $@"URI=file:{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}\LH-DialAssist\phonebook.db";
        private readonly string ConfigFile = $@"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}\LH-DialAssist\config.db";
        private readonly string ConStringConf = $@"URI=file:{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}\LH-DialAssist\config.db";
        private SQLiteConnection connection = null;
        private SQLiteCommand cmd = null;
        private SQLiteConnection confConnection = null;
        private SQLiteCommand confCmd = null;

        private int selectedMember = 0;
        private string MemberImgB64 = "";

        public DialAssist()
        {
            this.AllowResize = false;

            InitializeComponent();
            CreateDBCon();
            CreateConfDBCon();
            LoadAllMembers();
            ReloadDocuments();

            chbSearchNames.Switched = Convert.ToBoolean(SettingsPeek("SearchNames", true));
            chbSearchDW.Switched = Convert.ToBoolean(SettingsPeek("SearchDW", true));
            chbSearchNotes.Switched = Convert.ToBoolean(SettingsPeek("SearchNotes", false));
        }

        private void LoadAllMembers(bool keepIndex = false)
        {
            int prevSelect = 0;
            if (keepIndex) prevSelect = cbxAllMembers.SelectedIndex;

            cbxAllMembers.DataSource = null;
            cbxAllMembers.Items.Clear();

            connection.Open();

            cmd.CommandText = $@"SELECT * FROM Members";

            DataTable dt = new DataTable();
            dt.Columns.Add("DWName", typeof(string));
            dt.Columns.Add("ID", typeof(int));

            using (SQLiteDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    dt.Rows.Add(new object[] { $"{reader["DW"]} - {reader["Name"]}", Convert.ToInt32(reader["ID"]) });
                }
            }
            connection.Close();

            cbxAllMembers.DataSource = dt;
            cbxAllMembers.DisplayMember = "DWName";
            cbxAllMembers.ValueMember = "ID";

            if (keepIndex) cbxAllMembers.SelectedIndex = prevSelect;
        }

        private void CreateDBCon()
        {
            bool fileExitst = true;

            // Check if the db-file already exists, Create and set up the DB if it doesn't exist yet

            if (!File.Exists(DataFile))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(DataFile));
                fileExitst = false;
            }

            if(!fileExitst && File.Exists("phb.db"))
            {
                File.Copy("phb.db", DataFile);
                fileExitst = true;
            }

            // Open the connection to the DB
            connection = new SQLiteConnection(ConString);
            connection.Open();

            // Set up db (only on first execution)
            cmd = new SQLiteCommand(connection);
            if (!fileExitst)
            {
                cmd.CommandText = @"CREATE TABLE 'Members' ('ID' INTEGER PRIMARY KEY AUTOINCREMENT, 'Name' TEXT, 'DW' TEXT, 'Mobile' TEXT, 'Email1' TEXT, 'Email2' TEXT, 'Email3' TEXT, 'Note' TEXT, 'Image' TEXT);";
                cmd.ExecuteNonQuery();
            }

            connection.Close();
        }

        private void CreateConfDBCon()
        {
            bool fileExitst = true;

            // Check if the db-file already exists, Create and set up the DB if it doesn't exist yet

            if (!File.Exists(ConfigFile))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(ConfigFile));
                fileExitst = false;
            }

            // Open the connection to the DB
            confConnection = new SQLiteConnection(ConStringConf);
            confConnection.Open();

            // Set up db (only on first execution)
            confCmd = new SQLiteCommand(confConnection);
            if (!fileExitst)
            {
                confCmd.CommandText = @"CREATE TABLE 'Settings' ('ID' INTEGER PRIMARY KEY AUTOINCREMENT, 'Key' TEXT UNIQUE, 'Value' TEXT);";
                confCmd.ExecuteNonQuery();
            }

            confConnection.Close();
        }

        private void SettingsPoke(string pKey, object pValue)
        {
            confConnection.Open();
            confCmd.CommandText = $@"SELECT COUNT(*) FROM Settings WHERE Key = '{pKey}'"; ;
            if (Convert.ToInt32(confCmd.ExecuteScalar()) == 0)
            {
                // New entry
                confCmd.CommandText = $@"INSERT INTO Settings (Key, Value) VALUES ('{pKey}', '{pValue}')";
                confCmd.ExecuteNonQuery();
            }
            else
            {
                // Update entry
                confCmd.CommandText = $@"UPDATE Settings SET Value = '{pValue}' WHERE Key = '{pKey}'";
                confCmd.ExecuteNonQuery();
            }
            confConnection.Close();
        }

        private object SettingsPeek(string pKey, object pDefaultValue = null)
        {
            confConnection.Open();
            confCmd.CommandText = $@"SELECT Value FROM Settings WHERE Key = '{pKey}'";
            object result = confCmd.ExecuteScalar();
            confConnection.Close();
            if (result == null && pDefaultValue != null) return pDefaultValue;
            else return result;
        }

        private void SearchEntries()
        {
            List<string> searchParams = new List<string>();

            if (chbSearchNames.Switched)
            {
                if(Convert.ToBoolean(SettingsPeek("StrictSearchNames",false))) searchParams.Add($"Name LIKE '{txbSearch.Text}%'");
                else searchParams.Add($"Name LIKE '%{txbSearch.Text}%'");
            }

            if (chbSearchDW.Switched)
            {
                if (Convert.ToBoolean(SettingsPeek("StrictSearchDW", true))) searchParams.Add($"DW LIKE '{txbSearch.Text}%'");
                else searchParams.Add($"DW LIKE '&{txbSearch.Text}%'");
            }
            if (chbSearchNotes.Switched)
            {
                if (Convert.ToBoolean(SettingsPeek("StrictSearchNotes", false))) searchParams.Add($"Note LIKE '{txbSearch.Text}%'");
                else searchParams.Add($"Note LIKE '%{txbSearch.Text}%'");
            }

            bool firstRun = true;
            StringBuilder sb = new StringBuilder();
            foreach(string param in searchParams)
            {
                if (!firstRun) sb.Append(" OR ");

                sb.Append(param);

                firstRun = false;
            }

            connection.Open();
            cmd.CommandText = $@"SELECT COUNT(*) FROM Members WHERE {sb.ToString()}";

            int resCount = Convert.ToInt32(cmd.ExecuteScalar());
            int resID = 0;
            cmd.CommandText = $@"SELECT * FROM Members WHERE {sb.ToString()}";

            lbxResultView.DataSource = null;
            lbxResultView.Items.Clear();

            DataTable dt = new DataTable();
            dt.Columns.Add("DWName", typeof(string));
            dt.Columns.Add("ID", typeof(int));

            using (SQLiteDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    if (resCount == 1)
                    {
                        resID = Convert.ToInt32(reader["ID"]);
                    }

                    dt.Rows.Add(new object[] { $"{reader["DW"]} - {reader["Name"]}", Convert.ToInt32(reader["ID"]) });
                }
            }
            connection.Close();

            lbxResultView.DataSource = dt;
            lbxResultView.DisplayMember = "DWName";
            lbxResultView.ValueMember = "ID";

            if (resID != 0) SelectMember(resID);

            lblResultCount.Text = $"{resCount} übereinstimmungen gefunden.";
        }

        private bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }

        private void SelectMember(int pID)
        {
            tmrLoadImage.Start();
            selectedMember = pID;

            pbxMemberImage.Image = null;
            MemberImgB64 = "";

            connection.Open();

            cmd.CommandText = $@"SELECT * FROM Members WHERE ID = {pID}";

            using (SQLiteDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    txbResultName.Text = Convert.ToString(reader["Name"]);
                    txbResultDW.Text = Convert.ToString(reader["DW"]);

                    if (IsDigitsOnly(reader["DW"].ToString())) txbResultExtern.Text = "+43 (0) 7672 / 27550 " + Convert.ToString(reader["DW"]);
                    else txbResultExtern.Text = "";

                    txbResultMobile.Text = Convert.ToString(reader["Mobile"]);
                    txbResultEmail1.Text = Convert.ToString(reader["EMail1"]);
                    txbResultEmail2.Text = Convert.ToString(reader["EMail2"]);
                    txbResultEmail3.Text = Convert.ToString(reader["EMail3"]);
                    txbResultNote.Text = Convert.ToString(reader["Note"]);
                }
            }
            connection.Close();
        }

        private void ReloadDocuments()
        {
            for (int i = cmsDocuments.Items.Count - 1; i >= 0; i--)
            {
                if (cmsDocuments.Items[i].Name == "tsmAddDocumentEntry" || cmsDocuments.Items[i].Name == "tssSeperator") continue;
                else cmsDocuments.Items.RemoveAt(i);
            }
                

            confConnection.Open();
            confCmd.CommandText = "SELECT * FROM Settings WHERE Key LIKE 'DocEntry%'";
            using(SQLiteDataReader reader = confCmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    string value = Convert.ToString(reader["Value"]);
                    string key = Convert.ToString(reader["Key"]);

                    string[] docInfo = Convert.ToString(reader["Value"]).Split('|');

                    string docName = Encoding.UTF8.GetString(Convert.FromBase64String(docInfo[0]));
                    string docPath = Encoding.UTF8.GetString(Convert.FromBase64String(docInfo[1]));

                    ToolStripMenuItem tmsMain = new ToolStripMenuItem(docName);
                    ToolStripMenuItem tmsOpen = new ToolStripMenuItem("Öffnen");
                    ToolStripMenuItem tmsEdit = new ToolStripMenuItem("Bearbeiten");
                    ToolStripMenuItem tmsDelete = new ToolStripMenuItem("Entfernen");

                    tmsMain.DropDownItems.Add(tmsOpen);
                    tmsMain.DropDownItems.Add(tmsEdit);
                    tmsMain.DropDownItems.Add(tmsDelete);

                    tmsMain.Click += delegate { OpenDocuments(docPath); };
                    tmsOpen.Click += delegate { OpenDocuments(docPath); };
                    tmsEdit.Click += delegate { EditDocument(Convert.ToString(key)); };
                    tmsDelete.Click += delegate { DeleteDocument(Convert.ToString(key)); };

                    cmsDocuments.Items.Insert(0, tmsMain);
                }
            }
            confConnection.Close();
        }

        private void OpenDocuments(string pDocPath)
        {
            if(Directory.Exists(Path.GetDirectoryName(pDocPath)) && File.Exists(pDocPath))
            {
                Process.Start(pDocPath);
            }
            else MessageBox.Show("Die Datei konnte nicht geöffnet werden. Möglicherweise wurde sie verschoben oder gelöscht.", "Datei konnte nicht geöffnet werden", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void EditDocument(string pDocID)
        {
            confConnection.Open();
            confCmd.CommandText = $"SELECT * FROM Settings WHERE Key = '{pDocID}'";

            string docName = "";
            string docPath = "";

            using (SQLiteDataReader reader = confCmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    string[] docInfo = Convert.ToString(reader["Value"]).Split('|');

                    docName = Encoding.UTF8.GetString(Convert.FromBase64String(docInfo[0]));
                    docPath = Encoding.UTF8.GetString(Convert.FromBase64String(docInfo[1]));
                } 
            }

            confConnection.Close();

            ExtDocuments editDoc = new ExtDocuments();

            editDoc.DocumentName = docName;
            editDoc.DocumentPath = docPath;
           
            if(editDoc.ShowDialog() == DialogResult.OK)
            {
                confConnection.Open();
                confCmd.CommandText = $"UPDATE Settings SET Value = '{Convert.ToBase64String(Encoding.UTF8.GetBytes(editDoc.DocumentName)) + "|" + Convert.ToBase64String(Encoding.UTF8.GetBytes(editDoc.DocumentPath))}' WHERE Key = '{pDocID}'";
                confCmd.ExecuteNonQuery();
                confConnection.Close();
            }

            ReloadDocuments();
        }

        private void DeleteDocument(string pDocID)
        {
            confConnection.Open();

            confCmd.CommandText = $"DELETE FROM Settings WHERE Key = '{pDocID}'";
            confCmd.ExecuteNonQuery();

            confConnection.Close();

            ReloadDocuments();
        }

        private void btnSearch_Click(object sender, EventArgs e)
            => SearchEntries();

        private void btnAddEntry_Click(object sender, EventArgs e)
        {
            btnSaveEntry.Enabled = true;
            btnAbort.Enabled = true;
            btnSelectImage.Enabled = true;
            txbResultName.Text = "";
            txbResultDW.Text = "";
            txbResultExtern.Text = "";
            txbResultMobile.Text = "";
            txbResultEmail1.Text = "";
            txbResultEmail2.Text = "";
            txbResultEmail3.Text = "";
            txbResultNote.Text = "";

            MemberImgB64 = "";
            pbxMemberImage.Image = null;

            txbResultName.ReadOnly = false;
            txbResultDW.ReadOnly = false;
            txbResultMobile.ReadOnly = false;
            txbResultEmail1.ReadOnly = false;
            txbResultEmail2.ReadOnly = false;
            txbResultEmail3.ReadOnly = false;
            txbResultNote.ReadOnly = false;

            selectedMember = 0;


        }

        private void btnSaveEntry_Click(object sender, EventArgs e)
        {
            btnSaveEntry.Enabled = false;
            btnAbort.Enabled = false;
            btnSelectImage.Enabled = false;

            txbResultName.ReadOnly = true;
            txbResultDW.ReadOnly = true;
            txbResultMobile.ReadOnly = true;
            txbResultEmail1.ReadOnly = true;
            txbResultEmail2.ReadOnly = true;
            txbResultEmail3.ReadOnly = true;
            txbResultNote.ReadOnly = true;

            connection.Open();

            if (selectedMember == 0)
            {
                cmd.CommandText = $@"INSERT INTO Members (Name, DW, Mobile, Email1, Email2, Email3, Note, Image) VALUES ('{txbResultName.Text}','{txbResultDW.Text}','{txbResultMobile.Text}','{txbResultEmail1.Text}','{txbResultEmail2.Text}','{txbResultEmail3.Text}','{txbResultNote.Text}','{MemberImgB64}')";
            }
            else
            {
                cmd.CommandText = $@"UPDATE Members SET Name = '{txbResultName.Text}', DW = '{txbResultDW.Text}', Mobile = '{txbResultMobile.Text}', Email1 = '{txbResultEmail1.Text}', Email2 = '{txbResultEmail2.Text}', Email3 = '{txbResultEmail3.Text}', Note = '{txbResultNote.Text}', Image = '{MemberImgB64}' WHERE ID = '{selectedMember}'";
            }

            cmd.ExecuteNonQuery();
            connection.Close();

            MetroSetMessageBox.Show(this, "Eintrag gespeichert!", "Erfolg", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LoadAllMembers(true);
        }

        private void cbxAllMembers_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SelectMember(Convert.ToInt32(cbxAllMembers.SelectedValue.ToString()));
            }
            catch { }
        }

        private void btnEditEntry_Click(object sender, EventArgs e)
        {
            btnSaveEntry.Enabled = true;
            btnAbort.Enabled = true;
            btnSelectImage.Enabled = true;

            txbResultName.ReadOnly = false;
            txbResultDW.ReadOnly = false;
            txbResultMobile.ReadOnly = false;
            txbResultEmail1.ReadOnly = false;
            txbResultEmail2.ReadOnly = false;
            txbResultEmail3.ReadOnly = false;
            txbResultNote.ReadOnly = false;
        }

        private void txbSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter && e.KeyCode != Keys.Down && e.KeyCode != Keys.Up)
                SearchEntries();

            if (e.KeyCode == Keys.Up)
                txbSearch.Select(txbSearch.Text.Length, 0);
        }

        private void btnDeleteEntry_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Soll der merkierte Eintrag wirklich gelöscht werden?", "Löschen bestätigen", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                connection.Open();
                cmd.CommandText = $@"DELETE FROM Members WHERE ID = '{selectedMember}'";
                cmd.ExecuteNonQuery();
                connection.Close();

                txbResultName.Text = "";
                txbResultDW.Text = "";
                txbResultExtern.Text = "";
                txbResultMobile.Text = "";
                txbResultEmail1.Text = "";
                txbResultEmail2.Text = "";
                txbResultEmail3.Text = "";
                txbResultNote.Text = "";

                MemberImgB64 = "";
                pbxMemberImage.Image = null;

                MetroSetMessageBox.Show(this, "Eintrag gelöscht!", "Erfolg", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadAllMembers();
            }
        }

        private void lbxResultView_DoubleClick(object sender, EventArgs e)
        {
            SelectMember(Convert.ToInt32(lbxResultView.SelectedValue));
        }

        private void txbSearch_MouseDown(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Right)
            {
                txbSearch.ShortcutsEnabled = false;
                txbSearch.Text = "";
                txbSearch.Focus();
            }
        }

        private void txbSearch_KeyDown_1(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    try
                    {
                        int selectedID = Convert.ToInt32(lbxResultView.SelectedValue);
                        SelectMember(selectedID);
                    }
                    catch { }
                    break;
                case Keys.Up:
                    if (lbxResultView.SelectedIndex > 0) lbxResultView.SelectedIndex--;
                    break;
                case Keys.Down:
                    if (lbxResultView.SelectedIndex < lbxResultView.Items.Count - 1) lbxResultView.SelectedIndex++;
                    break;
            }
        }

        private void btnAbort_Click(object sender, EventArgs e)
        {
            btnSaveEntry.Enabled = false;
            btnAbort.Enabled = false;
            btnSelectImage.Enabled = false;

            txbResultName.ReadOnly = true;
            txbResultDW.ReadOnly = true;
            txbResultMobile.ReadOnly = true;
            txbResultEmail1.ReadOnly = true;
            txbResultEmail2.ReadOnly = true;
            txbResultEmail3.ReadOnly = true;
            txbResultNote.ReadOnly = true;
        }

        private void btnAlphabetEmail1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txbResultEmail1.Text)) PhoneAlphabet(txbResultEmail1.Text);
        }

        private void btnAlphabetemail2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txbResultEmail2.Text)) PhoneAlphabet(txbResultEmail2.Text);
        }

        private void btnAlphabetEmail3_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txbResultEmail3.Text)) PhoneAlphabet(txbResultEmail3.Text);
        }

        private void PhoneAlphabet(string pPhrase)
        {
            Dictionary<char, string> telAlpha = new Dictionary<char, string>
            {
                { 'A', "Anton" },
                { 'Ä', "Ärger" },
                { 'B', "Berta" },
                { 'C', "Cäsar" },
                { 'D', "Dora" },
                { 'E', "Emil" },
                { 'F', "Friedrich" },
                { 'G', "Gustav" },
                { 'H', "Heinrich" },
                { 'I', "Ida" },
                { 'J', "Julius" },
                { 'K', "Konrad" },
                { 'L', "Ludwig" },
                { 'M', "Martha" },
                { 'N', "Nordpol" },
                { 'O', "Otto" },
                { 'Ö', "Österreich" },
                { 'P', "Paula" },
                { 'Q', "Ku" },
                { 'R', "Richard" },
                { 'S', "Siegfried" },
                { 'ß', "Scharfes S" },
                { 'T', "Theodor" },
                { 'U', "Udo" },
                { 'Ü', "Übel" },
                { 'V', "Viktor" },
                { 'W', "Willhelm" },
                { 'X', "Xaver" },
                { 'Y', "Ypsilon" },
                { 'Z', "Zeppelin" },
                { '@', "Et (@)" },
                { '.', "Punkt" },
                { '-', "Minus" },
                { '0', "Null (0)" },
                { '1', "Eins (1)" },
                { '2', "Zwo (2)" },
                { '3', "Drei (3)" },
                { '4', "Vier (4)" },
                { '5', "Fünf (5)" },
                { '6', "Sechs (6)" },
                { '7', "Sieben (7)" },
                { '8', "Acht (8)" },
                { '9', "Neun (9)" }
            };

            StringBuilder sb = new StringBuilder();

            foreach(char letter in pPhrase.ToUpper())
            {
                try
                {
                    sb.AppendLine($"{letter}\t{telAlpha[letter]}");
                }
                catch { }
            }

            MessageBox.Show(sb.ToString(), "Telefon-Alphabet");
        }

        private void lbxResultView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && lbxResultView.SelectedIndex != -1)
                SelectMember(Convert.ToInt32(lbxResultView.SelectedValue));
        }

        private void DialAssist_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (connection.State == ConnectionState.Open) connection.Close();
            if (confConnection.State == ConnectionState.Open) confConnection.Close();
        }

        private void chbSearchNames_SwitchedChanged(object sender)
        {
            SettingsPoke("SearchNames", chbSearchNames.Switched);
        }

        private void chbSearchDW_SwitchedChanged(object sender)
        {
            SettingsPoke("SearchDW", chbSearchDW.Switched);
        }

        private void chbSearchNotes_SwitchedChanged(object sender)
        {
            SettingsPoke("SearchNotes", chbSearchNotes.Switched);
        }

        private void btnOptions_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings
            {
                strictNames = Convert.ToBoolean(SettingsPeek("StrictSearchNames", false)),
                strictDW = Convert.ToBoolean(SettingsPeek("StrictSearchDW", true)),
                strictNotes = Convert.ToBoolean(SettingsPeek("StrictSearchNotes", false))
            };

            if (settings.ShowDialog() == DialogResult.OK) 
            {
                SettingsPoke("StrictSearchNames", settings.strictNames);
                SettingsPoke("StrictSearchDW", settings.strictDW);
                SettingsPoke("StrictSearchNotes", settings.strictNotes);
            }
        }

        private void metroSetButton1_Click(object sender, EventArgs e)
        {
            cmsDocuments.Show(btnOpenDocuments, 10, 10);
        }

        private void tsmAddDocumentEntry_Click(object sender, EventArgs e)
        {
            ExtDocuments addDocForm = new ExtDocuments();
            
            if(addDocForm.ShowDialog() == DialogResult.OK)
            {
                SettingsPoke("DocEntry" + Guid.NewGuid(), Convert.ToBase64String(Encoding.UTF8.GetBytes(addDocForm.DocumentName)) + "|" + Convert.ToBase64String(Encoding.UTF8.GetBytes(addDocForm.DocumentPath)));
                ReloadDocuments();
            }
        }

        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            if (ofdSelectImage.ShowDialog() == DialogResult.OK)
            {
                using (Image image = Image.FromFile(ofdSelectImage.FileName))
                {
                    using (MemoryStream m = new MemoryStream())
                    {
                        image.Save(m, image.RawFormat);
                        byte[] imageBytes = m.ToArray();

                        MemberImgB64 = Convert.ToBase64String(imageBytes);
                    }
                }

                pbxMemberImage.Image = Image.FromFile(ofdSelectImage.FileName);
            }
        }

        private void tmrLoadImage_Tick(object sender, EventArgs e)
        {
            tmrLoadImage.Stop();
            pbxMemberImage.Image = null;
            MemberImgB64 = "";

            connection.Open();

            cmd.CommandText = $@"SELECT * FROM Members WHERE ID = {selectedMember}";

            using (SQLiteDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    MemberImgB64 = Convert.ToString(reader["Image"]);
                    if (!string.IsNullOrEmpty(MemberImgB64))
                        pbxMemberImage.Image = Image.FromStream(new MemoryStream(Convert.FromBase64String(MemberImgB64)));
                    else
                        pbxMemberImage.Image = Properties.Resources.user;
                }
            }
            connection.Close();
        }

        private void pbxMemberImage_Click(object sender, EventArgs e)
        {
            ImageViewer iv = new ImageViewer();
            iv.ImageB64 = MemberImgB64;
            iv.ShowDialog();
        }
    }
}
