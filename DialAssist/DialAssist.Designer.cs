namespace DialAssist
{
    partial class DialAssist
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DialAssist));
            this.metroSetControlBox1 = new MetroSet_UI.Controls.MetroSetControlBox();
            this.lbxResultView = new System.Windows.Forms.ListBox();
            this.metroSetLabel1 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel2 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel3 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel4 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel5 = new MetroSet_UI.Controls.MetroSetLabel();
            this.txbResultName = new MetroSet_UI.Controls.MetroSetTextBox();
            this.txbResultDW = new MetroSet_UI.Controls.MetroSetTextBox();
            this.txbResultExtern = new MetroSet_UI.Controls.MetroSetTextBox();
            this.txbResultMobile = new MetroSet_UI.Controls.MetroSetTextBox();
            this.txbResultEmail1 = new MetroSet_UI.Controls.MetroSetTextBox();
            this.txbResultEmail2 = new MetroSet_UI.Controls.MetroSetTextBox();
            this.txbResultEmail3 = new MetroSet_UI.Controls.MetroSetTextBox();
            this.txbResultNote = new MetroSet_UI.Controls.MetroSetTextBox();
            this.metroSetLabel6 = new MetroSet_UI.Controls.MetroSetLabel();
            this.btnEditEntry = new MetroSet_UI.Controls.MetroSetButton();
            this.btnDeleteEntry = new MetroSet_UI.Controls.MetroSetButton();
            this.btnAddEntry = new MetroSet_UI.Controls.MetroSetButton();
            this.btnSearch = new MetroSet_UI.Controls.MetroSetButton();
            this.btnSaveEntry = new MetroSet_UI.Controls.MetroSetButton();
            this.cbxAllMembers = new MetroSet_UI.Controls.MetroSetComboBox();
            this.txbSearch = new System.Windows.Forms.TextBox();
            this.metroSetLabel7 = new MetroSet_UI.Controls.MetroSetLabel();
            this.lblResultCount = new MetroSet_UI.Controls.MetroSetLabel();
            this.btnAbort = new MetroSet_UI.Controls.MetroSetButton();
            this.btnAlphabetEmail1 = new MetroSet_UI.Controls.MetroSetButton();
            this.btnAlphabetemail2 = new MetroSet_UI.Controls.MetroSetButton();
            this.btnAlphabetEmail3 = new MetroSet_UI.Controls.MetroSetButton();
            this.btnOptions = new MetroSet_UI.Controls.MetroDefaultSetButton();
            this.chbSearchDW = new MetroSet_UI.Controls.MetroSetSwitch();
            this.chbSearchNames = new MetroSet_UI.Controls.MetroSetSwitch();
            this.chbSearchNotes = new MetroSet_UI.Controls.MetroSetSwitch();
            this.metroSetLabel8 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel9 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel10 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel11 = new MetroSet_UI.Controls.MetroSetLabel();
            this.btnOpenDocuments = new MetroSet_UI.Controls.MetroSetButton();
            this.cmsDocuments = new MetroSet_UI.Controls.MetroSetContextMenuStrip();
            this.tssSeperator = new System.Windows.Forms.ToolStripSeparator();
            this.tsmAddDocumentEntry = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSelectImage = new MetroSet_UI.Controls.MetroSetButton();
            this.ofdSelectImage = new System.Windows.Forms.OpenFileDialog();
            this.tmrLoadImage = new System.Windows.Forms.Timer(this.components);
            this.metroSetLabel12 = new MetroSet_UI.Controls.MetroSetLabel();
            this.pbxMemberImage = new System.Windows.Forms.PictureBox();
            this.cmsDocuments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMemberImage)).BeginInit();
            this.SuspendLayout();
            // 
            // metroSetControlBox1
            // 
            this.metroSetControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroSetControlBox1.CloseHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.metroSetControlBox1.CloseHoverForeColor = System.Drawing.Color.White;
            this.metroSetControlBox1.CloseNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.DisabledForeColor = System.Drawing.Color.DimGray;
            this.metroSetControlBox1.Location = new System.Drawing.Point(815, 8);
            this.metroSetControlBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.metroSetControlBox1.MaximizeBox = false;
            this.metroSetControlBox1.MaximizeHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroSetControlBox1.MaximizeHoverForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MaximizeNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MinimizeBox = true;
            this.metroSetControlBox1.MinimizeHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroSetControlBox1.MinimizeHoverForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MinimizeNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.Name = "metroSetControlBox1";
            this.metroSetControlBox1.Size = new System.Drawing.Size(100, 25);
            this.metroSetControlBox1.Style = MetroSet_UI.Design.Style.Light;
            this.metroSetControlBox1.StyleManager = null;
            this.metroSetControlBox1.TabIndex = 4;
            this.metroSetControlBox1.Text = "metroSetControlBox1";
            this.metroSetControlBox1.ThemeAuthor = "Narwin";
            this.metroSetControlBox1.ThemeName = "MetroLite";
            // 
            // lbxResultView
            // 
            this.lbxResultView.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxResultView.FormattingEnabled = true;
            this.lbxResultView.ItemHeight = 23;
            this.lbxResultView.Location = new System.Drawing.Point(15, 153);
            this.lbxResultView.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.lbxResultView.Name = "lbxResultView";
            this.lbxResultView.Size = new System.Drawing.Size(618, 142);
            this.lbxResultView.TabIndex = 6;
            this.lbxResultView.DoubleClick += new System.EventHandler(this.lbxResultView_DoubleClick);
            this.lbxResultView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lbxResultView_KeyDown);
            // 
            // metroSetLabel1
            // 
            this.metroSetLabel1.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetLabel1.Location = new System.Drawing.Point(15, 323);
            this.metroSetLabel1.Name = "metroSetLabel1";
            this.metroSetLabel1.Size = new System.Drawing.Size(111, 20);
            this.metroSetLabel1.Style = MetroSet_UI.Design.Style.Light;
            this.metroSetLabel1.StyleManager = null;
            this.metroSetLabel1.TabIndex = 7;
            this.metroSetLabel1.Text = "Name:";
            this.metroSetLabel1.ThemeAuthor = "Narwin";
            this.metroSetLabel1.ThemeName = "MetroLite";
            // 
            // metroSetLabel2
            // 
            this.metroSetLabel2.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetLabel2.Location = new System.Drawing.Point(653, 323);
            this.metroSetLabel2.Name = "metroSetLabel2";
            this.metroSetLabel2.Size = new System.Drawing.Size(214, 20);
            this.metroSetLabel2.Style = MetroSet_UI.Design.Style.Light;
            this.metroSetLabel2.StyleManager = null;
            this.metroSetLabel2.TabIndex = 7;
            this.metroSetLabel2.Text = "Durchwahl / Kurzwahl:";
            this.metroSetLabel2.ThemeAuthor = "Narwin";
            this.metroSetLabel2.ThemeName = "MetroLite";
            // 
            // metroSetLabel3
            // 
            this.metroSetLabel3.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetLabel3.Location = new System.Drawing.Point(13, 408);
            this.metroSetLabel3.Name = "metroSetLabel3";
            this.metroSetLabel3.Size = new System.Drawing.Size(253, 20);
            this.metroSetLabel3.Style = MetroSet_UI.Design.Style.Light;
            this.metroSetLabel3.StyleManager = null;
            this.metroSetLabel3.TabIndex = 7;
            this.metroSetLabel3.Text = "Telefon - Extern direkte DW:";
            this.metroSetLabel3.ThemeAuthor = "Narwin";
            this.metroSetLabel3.ThemeName = "MetroLite";
            // 
            // metroSetLabel4
            // 
            this.metroSetLabel4.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetLabel4.Location = new System.Drawing.Point(12, 469);
            this.metroSetLabel4.Name = "metroSetLabel4";
            this.metroSetLabel4.Size = new System.Drawing.Size(221, 20);
            this.metroSetLabel4.Style = MetroSet_UI.Design.Style.Light;
            this.metroSetLabel4.StyleManager = null;
            this.metroSetLabel4.TabIndex = 7;
            this.metroSetLabel4.Text = "Telefon - Mobil:";
            this.metroSetLabel4.ThemeAuthor = "Narwin";
            this.metroSetLabel4.ThemeName = "MetroLite";
            // 
            // metroSetLabel5
            // 
            this.metroSetLabel5.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetLabel5.Location = new System.Drawing.Point(15, 535);
            this.metroSetLabel5.Name = "metroSetLabel5";
            this.metroSetLabel5.Size = new System.Drawing.Size(221, 20);
            this.metroSetLabel5.Style = MetroSet_UI.Design.Style.Light;
            this.metroSetLabel5.StyleManager = null;
            this.metroSetLabel5.TabIndex = 7;
            this.metroSetLabel5.Text = "E-Mail:";
            this.metroSetLabel5.ThemeAuthor = "Narwin";
            this.metroSetLabel5.ThemeName = "MetroLite";
            // 
            // txbResultName
            // 
            this.txbResultName.AutoCompleteCustomSource = null;
            this.txbResultName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txbResultName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txbResultName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txbResultName.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txbResultName.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txbResultName.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txbResultName.Font = new System.Drawing.Font("Calibri Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbResultName.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txbResultName.Image = null;
            this.txbResultName.Lines = null;
            this.txbResultName.Location = new System.Drawing.Point(15, 345);
            this.txbResultName.MaxLength = 32767;
            this.txbResultName.Multiline = false;
            this.txbResultName.Name = "txbResultName";
            this.txbResultName.ReadOnly = true;
            this.txbResultName.Size = new System.Drawing.Size(632, 51);
            this.txbResultName.Style = MetroSet_UI.Design.Style.Light;
            this.txbResultName.StyleManager = null;
            this.txbResultName.TabIndex = 1;
            this.txbResultName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txbResultName.ThemeAuthor = "Narwin";
            this.txbResultName.ThemeName = "MetroLite";
            this.txbResultName.UseSystemPasswordChar = false;
            this.txbResultName.WatermarkText = "Name";
            // 
            // txbResultDW
            // 
            this.txbResultDW.AutoCompleteCustomSource = null;
            this.txbResultDW.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txbResultDW.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txbResultDW.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txbResultDW.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txbResultDW.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txbResultDW.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txbResultDW.Font = new System.Drawing.Font("Calibri Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbResultDW.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txbResultDW.Image = null;
            this.txbResultDW.Lines = null;
            this.txbResultDW.Location = new System.Drawing.Point(653, 345);
            this.txbResultDW.MaxLength = 32767;
            this.txbResultDW.Multiline = false;
            this.txbResultDW.Name = "txbResultDW";
            this.txbResultDW.ReadOnly = true;
            this.txbResultDW.Size = new System.Drawing.Size(260, 51);
            this.txbResultDW.Style = MetroSet_UI.Design.Style.Light;
            this.txbResultDW.StyleManager = null;
            this.txbResultDW.TabIndex = 2;
            this.txbResultDW.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txbResultDW.ThemeAuthor = "Narwin";
            this.txbResultDW.ThemeName = "MetroLite";
            this.txbResultDW.UseSystemPasswordChar = false;
            this.txbResultDW.WatermarkText = "DW";
            // 
            // txbResultExtern
            // 
            this.txbResultExtern.AutoCompleteCustomSource = null;
            this.txbResultExtern.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txbResultExtern.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txbResultExtern.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txbResultExtern.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txbResultExtern.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txbResultExtern.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txbResultExtern.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbResultExtern.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txbResultExtern.Image = null;
            this.txbResultExtern.Lines = null;
            this.txbResultExtern.Location = new System.Drawing.Point(15, 431);
            this.txbResultExtern.MaxLength = 32767;
            this.txbResultExtern.Multiline = false;
            this.txbResultExtern.Name = "txbResultExtern";
            this.txbResultExtern.ReadOnly = true;
            this.txbResultExtern.Size = new System.Drawing.Size(458, 30);
            this.txbResultExtern.Style = MetroSet_UI.Design.Style.Light;
            this.txbResultExtern.StyleManager = null;
            this.txbResultExtern.TabIndex = 10;
            this.txbResultExtern.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txbResultExtern.ThemeAuthor = "Narwin";
            this.txbResultExtern.ThemeName = "MetroLite";
            this.txbResultExtern.UseSystemPasswordChar = false;
            this.txbResultExtern.WatermarkText = "+43 7672 / 27550 XXXXX";
            // 
            // txbResultMobile
            // 
            this.txbResultMobile.AutoCompleteCustomSource = null;
            this.txbResultMobile.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txbResultMobile.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txbResultMobile.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txbResultMobile.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txbResultMobile.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txbResultMobile.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txbResultMobile.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbResultMobile.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txbResultMobile.Image = null;
            this.txbResultMobile.Lines = null;
            this.txbResultMobile.Location = new System.Drawing.Point(15, 492);
            this.txbResultMobile.MaxLength = 32767;
            this.txbResultMobile.Multiline = false;
            this.txbResultMobile.Name = "txbResultMobile";
            this.txbResultMobile.ReadOnly = true;
            this.txbResultMobile.Size = new System.Drawing.Size(458, 30);
            this.txbResultMobile.Style = MetroSet_UI.Design.Style.Light;
            this.txbResultMobile.StyleManager = null;
            this.txbResultMobile.TabIndex = 3;
            this.txbResultMobile.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txbResultMobile.ThemeAuthor = "Narwin";
            this.txbResultMobile.ThemeName = "MetroLite";
            this.txbResultMobile.UseSystemPasswordChar = false;
            this.txbResultMobile.WatermarkText = "Mobil";
            // 
            // txbResultEmail1
            // 
            this.txbResultEmail1.AutoCompleteCustomSource = null;
            this.txbResultEmail1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txbResultEmail1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txbResultEmail1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txbResultEmail1.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txbResultEmail1.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txbResultEmail1.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txbResultEmail1.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbResultEmail1.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txbResultEmail1.Image = null;
            this.txbResultEmail1.Lines = null;
            this.txbResultEmail1.Location = new System.Drawing.Point(15, 558);
            this.txbResultEmail1.MaxLength = 32767;
            this.txbResultEmail1.Multiline = false;
            this.txbResultEmail1.Name = "txbResultEmail1";
            this.txbResultEmail1.ReadOnly = true;
            this.txbResultEmail1.Size = new System.Drawing.Size(423, 30);
            this.txbResultEmail1.Style = MetroSet_UI.Design.Style.Light;
            this.txbResultEmail1.StyleManager = null;
            this.txbResultEmail1.TabIndex = 4;
            this.txbResultEmail1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txbResultEmail1.ThemeAuthor = "Narwin";
            this.txbResultEmail1.ThemeName = "MetroLite";
            this.txbResultEmail1.UseSystemPasswordChar = false;
            this.txbResultEmail1.WatermarkText = "E-Mail [Option 1]";
            // 
            // txbResultEmail2
            // 
            this.txbResultEmail2.AutoCompleteCustomSource = null;
            this.txbResultEmail2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txbResultEmail2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txbResultEmail2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txbResultEmail2.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txbResultEmail2.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txbResultEmail2.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txbResultEmail2.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbResultEmail2.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txbResultEmail2.Image = null;
            this.txbResultEmail2.Lines = null;
            this.txbResultEmail2.Location = new System.Drawing.Point(15, 594);
            this.txbResultEmail2.MaxLength = 32767;
            this.txbResultEmail2.Multiline = false;
            this.txbResultEmail2.Name = "txbResultEmail2";
            this.txbResultEmail2.ReadOnly = true;
            this.txbResultEmail2.Size = new System.Drawing.Size(423, 30);
            this.txbResultEmail2.Style = MetroSet_UI.Design.Style.Light;
            this.txbResultEmail2.StyleManager = null;
            this.txbResultEmail2.TabIndex = 5;
            this.txbResultEmail2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txbResultEmail2.ThemeAuthor = "Narwin";
            this.txbResultEmail2.ThemeName = "MetroLite";
            this.txbResultEmail2.UseSystemPasswordChar = false;
            this.txbResultEmail2.WatermarkText = "E-Mail [Option 2]";
            // 
            // txbResultEmail3
            // 
            this.txbResultEmail3.AutoCompleteCustomSource = null;
            this.txbResultEmail3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txbResultEmail3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txbResultEmail3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txbResultEmail3.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txbResultEmail3.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txbResultEmail3.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txbResultEmail3.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbResultEmail3.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txbResultEmail3.Image = null;
            this.txbResultEmail3.Lines = null;
            this.txbResultEmail3.Location = new System.Drawing.Point(15, 630);
            this.txbResultEmail3.MaxLength = 32767;
            this.txbResultEmail3.Multiline = false;
            this.txbResultEmail3.Name = "txbResultEmail3";
            this.txbResultEmail3.ReadOnly = true;
            this.txbResultEmail3.Size = new System.Drawing.Size(423, 30);
            this.txbResultEmail3.Style = MetroSet_UI.Design.Style.Light;
            this.txbResultEmail3.StyleManager = null;
            this.txbResultEmail3.TabIndex = 6;
            this.txbResultEmail3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txbResultEmail3.ThemeAuthor = "Narwin";
            this.txbResultEmail3.ThemeName = "MetroLite";
            this.txbResultEmail3.UseSystemPasswordChar = false;
            this.txbResultEmail3.WatermarkText = "E-Mail [Option 3]";
            // 
            // txbResultNote
            // 
            this.txbResultNote.AutoCompleteCustomSource = null;
            this.txbResultNote.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txbResultNote.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txbResultNote.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txbResultNote.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txbResultNote.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txbResultNote.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txbResultNote.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbResultNote.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txbResultNote.Image = null;
            this.txbResultNote.Lines = null;
            this.txbResultNote.Location = new System.Drawing.Point(481, 431);
            this.txbResultNote.MaxLength = 32767;
            this.txbResultNote.Multiline = true;
            this.txbResultNote.Name = "txbResultNote";
            this.txbResultNote.ReadOnly = true;
            this.txbResultNote.Size = new System.Drawing.Size(434, 229);
            this.txbResultNote.Style = MetroSet_UI.Design.Style.Light;
            this.txbResultNote.StyleManager = null;
            this.txbResultNote.TabIndex = 7;
            this.txbResultNote.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txbResultNote.ThemeAuthor = "Narwin";
            this.txbResultNote.ThemeName = "MetroLite";
            this.txbResultNote.UseSystemPasswordChar = false;
            this.txbResultNote.WatermarkText = "";
            // 
            // metroSetLabel6
            // 
            this.metroSetLabel6.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetLabel6.Location = new System.Drawing.Point(481, 406);
            this.metroSetLabel6.Name = "metroSetLabel6";
            this.metroSetLabel6.Size = new System.Drawing.Size(221, 22);
            this.metroSetLabel6.Style = MetroSet_UI.Design.Style.Light;
            this.metroSetLabel6.StyleManager = null;
            this.metroSetLabel6.TabIndex = 7;
            this.metroSetLabel6.Text = "Anmerkungen:";
            this.metroSetLabel6.ThemeAuthor = "Narwin";
            this.metroSetLabel6.ThemeName = "MetroLite";
            // 
            // btnEditEntry
            // 
            this.btnEditEntry.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnEditEntry.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnEditEntry.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnEditEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnEditEntry.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnEditEntry.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnEditEntry.HoverTextColor = System.Drawing.Color.White;
            this.btnEditEntry.Location = new System.Drawing.Point(128, 694);
            this.btnEditEntry.Name = "btnEditEntry";
            this.btnEditEntry.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnEditEntry.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnEditEntry.NormalTextColor = System.Drawing.Color.White;
            this.btnEditEntry.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnEditEntry.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnEditEntry.PressTextColor = System.Drawing.Color.White;
            this.btnEditEntry.Size = new System.Drawing.Size(107, 40);
            this.btnEditEntry.Style = MetroSet_UI.Design.Style.Light;
            this.btnEditEntry.StyleManager = null;
            this.btnEditEntry.TabIndex = 11;
            this.btnEditEntry.Text = "Bearbeiten";
            this.btnEditEntry.ThemeAuthor = "Narwin";
            this.btnEditEntry.ThemeName = "MetroLite";
            this.btnEditEntry.Click += new System.EventHandler(this.btnEditEntry_Click);
            // 
            // btnDeleteEntry
            // 
            this.btnDeleteEntry.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnDeleteEntry.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnDeleteEntry.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnDeleteEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnDeleteEntry.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnDeleteEntry.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnDeleteEntry.HoverTextColor = System.Drawing.Color.White;
            this.btnDeleteEntry.Location = new System.Drawing.Point(241, 694);
            this.btnDeleteEntry.Name = "btnDeleteEntry";
            this.btnDeleteEntry.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnDeleteEntry.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnDeleteEntry.NormalTextColor = System.Drawing.Color.White;
            this.btnDeleteEntry.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnDeleteEntry.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnDeleteEntry.PressTextColor = System.Drawing.Color.White;
            this.btnDeleteEntry.Size = new System.Drawing.Size(107, 40);
            this.btnDeleteEntry.Style = MetroSet_UI.Design.Style.Light;
            this.btnDeleteEntry.StyleManager = null;
            this.btnDeleteEntry.TabIndex = 11;
            this.btnDeleteEntry.Text = "Löschen";
            this.btnDeleteEntry.ThemeAuthor = "Narwin";
            this.btnDeleteEntry.ThemeName = "MetroLite";
            this.btnDeleteEntry.Click += new System.EventHandler(this.btnDeleteEntry_Click);
            // 
            // btnAddEntry
            // 
            this.btnAddEntry.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnAddEntry.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnAddEntry.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnAddEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAddEntry.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnAddEntry.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnAddEntry.HoverTextColor = System.Drawing.Color.White;
            this.btnAddEntry.Location = new System.Drawing.Point(15, 694);
            this.btnAddEntry.Name = "btnAddEntry";
            this.btnAddEntry.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnAddEntry.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnAddEntry.NormalTextColor = System.Drawing.Color.White;
            this.btnAddEntry.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnAddEntry.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnAddEntry.PressTextColor = System.Drawing.Color.White;
            this.btnAddEntry.Size = new System.Drawing.Size(107, 40);
            this.btnAddEntry.Style = MetroSet_UI.Design.Style.Light;
            this.btnAddEntry.StyleManager = null;
            this.btnAddEntry.TabIndex = 11;
            this.btnAddEntry.Text = "Neu";
            this.btnAddEntry.ThemeAuthor = "Narwin";
            this.btnAddEntry.ThemeName = "MetroLite";
            this.btnAddEntry.Click += new System.EventHandler(this.btnAddEntry_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnSearch.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnSearch.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSearch.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnSearch.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnSearch.HoverTextColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(540, 110);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnSearch.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnSearch.NormalTextColor = System.Drawing.Color.White;
            this.btnSearch.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnSearch.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnSearch.PressTextColor = System.Drawing.Color.White;
            this.btnSearch.Size = new System.Drawing.Size(92, 37);
            this.btnSearch.Style = MetroSet_UI.Design.Style.Light;
            this.btnSearch.StyleManager = null;
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "Suchen";
            this.btnSearch.ThemeAuthor = "Narwin";
            this.btnSearch.ThemeName = "MetroLite";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnSaveEntry
            // 
            this.btnSaveEntry.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnSaveEntry.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnSaveEntry.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnSaveEntry.Enabled = false;
            this.btnSaveEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSaveEntry.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnSaveEntry.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnSaveEntry.HoverTextColor = System.Drawing.Color.White;
            this.btnSaveEntry.Location = new System.Drawing.Point(694, 694);
            this.btnSaveEntry.Name = "btnSaveEntry";
            this.btnSaveEntry.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnSaveEntry.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnSaveEntry.NormalTextColor = System.Drawing.Color.White;
            this.btnSaveEntry.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnSaveEntry.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnSaveEntry.PressTextColor = System.Drawing.Color.White;
            this.btnSaveEntry.Size = new System.Drawing.Size(107, 40);
            this.btnSaveEntry.Style = MetroSet_UI.Design.Style.Light;
            this.btnSaveEntry.StyleManager = null;
            this.btnSaveEntry.TabIndex = 8;
            this.btnSaveEntry.Text = "Speichern";
            this.btnSaveEntry.ThemeAuthor = "Narwin";
            this.btnSaveEntry.ThemeName = "MetroLite";
            this.btnSaveEntry.Click += new System.EventHandler(this.btnSaveEntry_Click);
            // 
            // cbxAllMembers
            // 
            this.cbxAllMembers.AllowDrop = true;
            this.cbxAllMembers.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.cbxAllMembers.BackColor = System.Drawing.Color.Transparent;
            this.cbxAllMembers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.cbxAllMembers.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.cbxAllMembers.CausesValidation = false;
            this.cbxAllMembers.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.cbxAllMembers.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.cbxAllMembers.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.cbxAllMembers.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxAllMembers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAllMembers.Font = new System.Drawing.Font("Calibri Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxAllMembers.FormattingEnabled = true;
            this.cbxAllMembers.ItemHeight = 20;
            this.cbxAllMembers.Location = new System.Drawing.Point(638, 81);
            this.cbxAllMembers.Name = "cbxAllMembers";
            this.cbxAllMembers.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.cbxAllMembers.SelectedItemForeColor = System.Drawing.Color.White;
            this.cbxAllMembers.Size = new System.Drawing.Size(278, 26);
            this.cbxAllMembers.Style = MetroSet_UI.Design.Style.Light;
            this.cbxAllMembers.StyleManager = null;
            this.cbxAllMembers.TabIndex = 12;
            this.cbxAllMembers.ThemeAuthor = "Narwin";
            this.cbxAllMembers.ThemeName = "MetroLite";
            this.cbxAllMembers.SelectedIndexChanged += new System.EventHandler(this.cbxAllMembers_SelectedIndexChanged);
            // 
            // txbSearch
            // 
            this.txbSearch.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSearch.Location = new System.Drawing.Point(15, 110);
            this.txbSearch.Name = "txbSearch";
            this.txbSearch.Size = new System.Drawing.Size(519, 37);
            this.txbSearch.TabIndex = 13;
            this.txbSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbSearch_KeyDown_1);
            this.txbSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txbSearch_KeyDown);
            this.txbSearch.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txbSearch_MouseDown);
            // 
            // metroSetLabel7
            // 
            this.metroSetLabel7.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetLabel7.Location = new System.Drawing.Point(15, 81);
            this.metroSetLabel7.Name = "metroSetLabel7";
            this.metroSetLabel7.Size = new System.Drawing.Size(404, 22);
            this.metroSetLabel7.Style = MetroSet_UI.Design.Style.Light;
            this.metroSetLabel7.StyleManager = null;
            this.metroSetLabel7.TabIndex = 7;
            this.metroSetLabel7.Text = "Suche nach Name, Durchwahl, Einrichtung, ...";
            this.metroSetLabel7.ThemeAuthor = "Narwin";
            this.metroSetLabel7.ThemeName = "MetroLite";
            // 
            // lblResultCount
            // 
            this.lblResultCount.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultCount.Location = new System.Drawing.Point(13, 303);
            this.lblResultCount.Name = "lblResultCount";
            this.lblResultCount.Size = new System.Drawing.Size(901, 20);
            this.lblResultCount.Style = MetroSet_UI.Design.Style.Light;
            this.lblResultCount.StyleManager = null;
            this.lblResultCount.TabIndex = 7;
            this.lblResultCount.ThemeAuthor = "Narwin";
            this.lblResultCount.ThemeName = "MetroLite";
            // 
            // btnAbort
            // 
            this.btnAbort.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnAbort.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnAbort.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnAbort.Enabled = false;
            this.btnAbort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAbort.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnAbort.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnAbort.HoverTextColor = System.Drawing.Color.White;
            this.btnAbort.Location = new System.Drawing.Point(807, 694);
            this.btnAbort.Name = "btnAbort";
            this.btnAbort.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnAbort.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnAbort.NormalTextColor = System.Drawing.Color.White;
            this.btnAbort.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnAbort.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnAbort.PressTextColor = System.Drawing.Color.White;
            this.btnAbort.Size = new System.Drawing.Size(107, 40);
            this.btnAbort.Style = MetroSet_UI.Design.Style.Light;
            this.btnAbort.StyleManager = null;
            this.btnAbort.TabIndex = 8;
            this.btnAbort.Text = "Abbrechen";
            this.btnAbort.ThemeAuthor = "Narwin";
            this.btnAbort.ThemeName = "MetroLite";
            this.btnAbort.Click += new System.EventHandler(this.btnAbort_Click);
            // 
            // btnAlphabetEmail1
            // 
            this.btnAlphabetEmail1.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnAlphabetEmail1.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnAlphabetEmail1.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnAlphabetEmail1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlphabetEmail1.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnAlphabetEmail1.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnAlphabetEmail1.HoverTextColor = System.Drawing.Color.White;
            this.btnAlphabetEmail1.Location = new System.Drawing.Point(443, 558);
            this.btnAlphabetEmail1.Name = "btnAlphabetEmail1";
            this.btnAlphabetEmail1.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnAlphabetEmail1.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnAlphabetEmail1.NormalTextColor = System.Drawing.Color.White;
            this.btnAlphabetEmail1.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnAlphabetEmail1.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnAlphabetEmail1.PressTextColor = System.Drawing.Color.White;
            this.btnAlphabetEmail1.Size = new System.Drawing.Size(30, 30);
            this.btnAlphabetEmail1.Style = MetroSet_UI.Design.Style.Light;
            this.btnAlphabetEmail1.StyleManager = null;
            this.btnAlphabetEmail1.TabIndex = 11;
            this.btnAlphabetEmail1.Text = "✆";
            this.btnAlphabetEmail1.ThemeAuthor = "Narwin";
            this.btnAlphabetEmail1.ThemeName = "MetroLite";
            this.btnAlphabetEmail1.Click += new System.EventHandler(this.btnAlphabetEmail1_Click);
            // 
            // btnAlphabetemail2
            // 
            this.btnAlphabetemail2.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnAlphabetemail2.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnAlphabetemail2.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnAlphabetemail2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlphabetemail2.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnAlphabetemail2.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnAlphabetemail2.HoverTextColor = System.Drawing.Color.White;
            this.btnAlphabetemail2.Location = new System.Drawing.Point(443, 594);
            this.btnAlphabetemail2.Name = "btnAlphabetemail2";
            this.btnAlphabetemail2.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnAlphabetemail2.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnAlphabetemail2.NormalTextColor = System.Drawing.Color.White;
            this.btnAlphabetemail2.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnAlphabetemail2.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnAlphabetemail2.PressTextColor = System.Drawing.Color.White;
            this.btnAlphabetemail2.Size = new System.Drawing.Size(30, 30);
            this.btnAlphabetemail2.Style = MetroSet_UI.Design.Style.Light;
            this.btnAlphabetemail2.StyleManager = null;
            this.btnAlphabetemail2.TabIndex = 11;
            this.btnAlphabetemail2.Text = "✆";
            this.btnAlphabetemail2.ThemeAuthor = "Narwin";
            this.btnAlphabetemail2.ThemeName = "MetroLite";
            this.btnAlphabetemail2.Click += new System.EventHandler(this.btnAlphabetemail2_Click);
            // 
            // btnAlphabetEmail3
            // 
            this.btnAlphabetEmail3.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnAlphabetEmail3.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnAlphabetEmail3.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnAlphabetEmail3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlphabetEmail3.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnAlphabetEmail3.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnAlphabetEmail3.HoverTextColor = System.Drawing.Color.White;
            this.btnAlphabetEmail3.Location = new System.Drawing.Point(443, 630);
            this.btnAlphabetEmail3.Name = "btnAlphabetEmail3";
            this.btnAlphabetEmail3.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnAlphabetEmail3.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnAlphabetEmail3.NormalTextColor = System.Drawing.Color.White;
            this.btnAlphabetEmail3.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnAlphabetEmail3.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnAlphabetEmail3.PressTextColor = System.Drawing.Color.White;
            this.btnAlphabetEmail3.Size = new System.Drawing.Size(30, 30);
            this.btnAlphabetEmail3.Style = MetroSet_UI.Design.Style.Light;
            this.btnAlphabetEmail3.StyleManager = null;
            this.btnAlphabetEmail3.TabIndex = 11;
            this.btnAlphabetEmail3.Text = "✆";
            this.btnAlphabetEmail3.ThemeAuthor = "Narwin";
            this.btnAlphabetEmail3.ThemeName = "MetroLite";
            this.btnAlphabetEmail3.Click += new System.EventHandler(this.btnAlphabetEmail3_Click);
            // 
            // btnOptions
            // 
            this.btnOptions.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnOptions.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.btnOptions.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.btnOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnOptions.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnOptions.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnOptions.HoverTextColor = System.Drawing.Color.White;
            this.btnOptions.Location = new System.Drawing.Point(771, 275);
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnOptions.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btnOptions.NormalTextColor = System.Drawing.Color.Black;
            this.btnOptions.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnOptions.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnOptions.PressTextColor = System.Drawing.Color.White;
            this.btnOptions.Size = new System.Drawing.Size(145, 20);
            this.btnOptions.Style = MetroSet_UI.Design.Style.Light;
            this.btnOptions.StyleManager = null;
            this.btnOptions.TabIndex = 14;
            this.btnOptions.Text = "Programm Optionen";
            this.btnOptions.ThemeAuthor = "Narwin";
            this.btnOptions.ThemeName = "MetroLite";
            this.btnOptions.Click += new System.EventHandler(this.btnOptions_Click);
            // 
            // chbSearchDW
            // 
            this.chbSearchDW.BackColor = System.Drawing.Color.Transparent;
            this.chbSearchDW.BackgroundColor = System.Drawing.Color.Empty;
            this.chbSearchDW.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(159)))), ((int)(((byte)(147)))));
            this.chbSearchDW.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.chbSearchDW.CheckState = MetroSet_UI.Enums.CheckState.Checked;
            this.chbSearchDW.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chbSearchDW.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.chbSearchDW.DisabledCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.chbSearchDW.DisabledUnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.chbSearchDW.Location = new System.Drawing.Point(860, 187);
            this.chbSearchDW.Name = "chbSearchDW";
            this.chbSearchDW.Size = new System.Drawing.Size(58, 22);
            this.chbSearchDW.Style = MetroSet_UI.Design.Style.Light;
            this.chbSearchDW.StyleManager = null;
            this.chbSearchDW.Switched = true;
            this.chbSearchDW.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.chbSearchDW.TabIndex = 15;
            this.chbSearchDW.Text = "metroSetSwitch1";
            this.chbSearchDW.ThemeAuthor = "Narwin";
            this.chbSearchDW.ThemeName = "MetroLite";
            this.chbSearchDW.UnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.chbSearchDW.SwitchedChanged += new MetroSet_UI.Controls.MetroSetSwitch.SwitchedChangedEventHandler(this.chbSearchDW_SwitchedChanged);
            // 
            // chbSearchNames
            // 
            this.chbSearchNames.BackColor = System.Drawing.Color.Transparent;
            this.chbSearchNames.BackgroundColor = System.Drawing.Color.Empty;
            this.chbSearchNames.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(159)))), ((int)(((byte)(147)))));
            this.chbSearchNames.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.chbSearchNames.CheckState = MetroSet_UI.Enums.CheckState.Checked;
            this.chbSearchNames.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chbSearchNames.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.chbSearchNames.DisabledCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.chbSearchNames.DisabledUnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.chbSearchNames.Location = new System.Drawing.Point(860, 153);
            this.chbSearchNames.Name = "chbSearchNames";
            this.chbSearchNames.Size = new System.Drawing.Size(58, 22);
            this.chbSearchNames.Style = MetroSet_UI.Design.Style.Light;
            this.chbSearchNames.StyleManager = null;
            this.chbSearchNames.Switched = true;
            this.chbSearchNames.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.chbSearchNames.TabIndex = 16;
            this.chbSearchNames.Text = "metroSetSwitch2";
            this.chbSearchNames.ThemeAuthor = "Narwin";
            this.chbSearchNames.ThemeName = "MetroLite";
            this.chbSearchNames.UnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.chbSearchNames.SwitchedChanged += new MetroSet_UI.Controls.MetroSetSwitch.SwitchedChangedEventHandler(this.chbSearchNames_SwitchedChanged);
            // 
            // chbSearchNotes
            // 
            this.chbSearchNotes.BackColor = System.Drawing.Color.Transparent;
            this.chbSearchNotes.BackgroundColor = System.Drawing.Color.Empty;
            this.chbSearchNotes.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(159)))), ((int)(((byte)(147)))));
            this.chbSearchNotes.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.chbSearchNotes.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
            this.chbSearchNotes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chbSearchNotes.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.chbSearchNotes.DisabledCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.chbSearchNotes.DisabledUnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.chbSearchNotes.Location = new System.Drawing.Point(860, 221);
            this.chbSearchNotes.Name = "chbSearchNotes";
            this.chbSearchNotes.Size = new System.Drawing.Size(58, 22);
            this.chbSearchNotes.Style = MetroSet_UI.Design.Style.Light;
            this.chbSearchNotes.StyleManager = null;
            this.chbSearchNotes.Switched = false;
            this.chbSearchNotes.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.chbSearchNotes.TabIndex = 17;
            this.chbSearchNotes.Text = "metroSetSwitch3";
            this.chbSearchNotes.ThemeAuthor = "Narwin";
            this.chbSearchNotes.ThemeName = "MetroLite";
            this.chbSearchNotes.UnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.chbSearchNotes.SwitchedChanged += new MetroSet_UI.Controls.MetroSetSwitch.SwitchedChangedEventHandler(this.chbSearchNotes_SwitchedChanged);
            // 
            // metroSetLabel8
            // 
            this.metroSetLabel8.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetLabel8.Location = new System.Drawing.Point(773, 155);
            this.metroSetLabel8.Name = "metroSetLabel8";
            this.metroSetLabel8.Size = new System.Drawing.Size(81, 20);
            this.metroSetLabel8.Style = MetroSet_UI.Design.Style.Light;
            this.metroSetLabel8.StyleManager = null;
            this.metroSetLabel8.TabIndex = 7;
            this.metroSetLabel8.Text = "Namen:";
            this.metroSetLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroSetLabel8.ThemeAuthor = "Narwin";
            this.metroSetLabel8.ThemeName = "MetroLite";
            // 
            // metroSetLabel9
            // 
            this.metroSetLabel9.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetLabel9.Location = new System.Drawing.Point(773, 189);
            this.metroSetLabel9.Name = "metroSetLabel9";
            this.metroSetLabel9.Size = new System.Drawing.Size(81, 20);
            this.metroSetLabel9.Style = MetroSet_UI.Design.Style.Light;
            this.metroSetLabel9.StyleManager = null;
            this.metroSetLabel9.TabIndex = 7;
            this.metroSetLabel9.Text = "DW:";
            this.metroSetLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroSetLabel9.ThemeAuthor = "Narwin";
            this.metroSetLabel9.ThemeName = "MetroLite";
            // 
            // metroSetLabel10
            // 
            this.metroSetLabel10.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetLabel10.Location = new System.Drawing.Point(773, 223);
            this.metroSetLabel10.Name = "metroSetLabel10";
            this.metroSetLabel10.Size = new System.Drawing.Size(81, 20);
            this.metroSetLabel10.Style = MetroSet_UI.Design.Style.Light;
            this.metroSetLabel10.StyleManager = null;
            this.metroSetLabel10.TabIndex = 7;
            this.metroSetLabel10.Text = "Anmerk.:";
            this.metroSetLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroSetLabel10.ThemeAuthor = "Narwin";
            this.metroSetLabel10.ThemeName = "MetroLite";
            // 
            // metroSetLabel11
            // 
            this.metroSetLabel11.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetLabel11.Location = new System.Drawing.Point(798, 121);
            this.metroSetLabel11.Name = "metroSetLabel11";
            this.metroSetLabel11.Size = new System.Drawing.Size(92, 20);
            this.metroSetLabel11.Style = MetroSet_UI.Design.Style.Light;
            this.metroSetLabel11.StyleManager = null;
            this.metroSetLabel11.TabIndex = 7;
            this.metroSetLabel11.Text = "Suche in";
            this.metroSetLabel11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroSetLabel11.ThemeAuthor = "Narwin";
            this.metroSetLabel11.ThemeName = "MetroLite";
            // 
            // btnOpenDocuments
            // 
            this.btnOpenDocuments.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnOpenDocuments.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnOpenDocuments.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnOpenDocuments.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnOpenDocuments.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnOpenDocuments.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnOpenDocuments.HoverTextColor = System.Drawing.Color.White;
            this.btnOpenDocuments.Location = new System.Drawing.Point(455, 694);
            this.btnOpenDocuments.Name = "btnOpenDocuments";
            this.btnOpenDocuments.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnOpenDocuments.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnOpenDocuments.NormalTextColor = System.Drawing.Color.White;
            this.btnOpenDocuments.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnOpenDocuments.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnOpenDocuments.PressTextColor = System.Drawing.Color.White;
            this.btnOpenDocuments.Size = new System.Drawing.Size(107, 40);
            this.btnOpenDocuments.Style = MetroSet_UI.Design.Style.Light;
            this.btnOpenDocuments.StyleManager = null;
            this.btnOpenDocuments.TabIndex = 11;
            this.btnOpenDocuments.Text = "Dokumente";
            this.btnOpenDocuments.ThemeAuthor = "Narwin";
            this.btnOpenDocuments.ThemeName = "MetroLite";
            this.btnOpenDocuments.Click += new System.EventHandler(this.metroSetButton1_Click);
            // 
            // cmsDocuments
            // 
            this.cmsDocuments.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssSeperator,
            this.tsmAddDocumentEntry});
            this.cmsDocuments.Name = "cmsDocuments";
            this.cmsDocuments.Size = new System.Drawing.Size(232, 32);
            this.cmsDocuments.Style = MetroSet_UI.Design.Style.Light;
            this.cmsDocuments.StyleManager = null;
            this.cmsDocuments.ThemeAuthor = "Narwin";
            this.cmsDocuments.ThemeName = "MetroLite";
            // 
            // tssSeperator
            // 
            this.tssSeperator.Name = "tssSeperator";
            this.tssSeperator.Size = new System.Drawing.Size(228, 6);
            // 
            // tsmAddDocumentEntry
            // 
            this.tsmAddDocumentEntry.Name = "tsmAddDocumentEntry";
            this.tsmAddDocumentEntry.Size = new System.Drawing.Size(231, 22);
            this.tsmAddDocumentEntry.Text = "Neues Dokument Hinzufügen";
            this.tsmAddDocumentEntry.Click += new System.EventHandler(this.tsmAddDocumentEntry_Click);
            // 
            // btnSelectImage
            // 
            this.btnSelectImage.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnSelectImage.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnSelectImage.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnSelectImage.Enabled = false;
            this.btnSelectImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSelectImage.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnSelectImage.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnSelectImage.HoverTextColor = System.Drawing.Color.White;
            this.btnSelectImage.Location = new System.Drawing.Point(638, 280);
            this.btnSelectImage.Name = "btnSelectImage";
            this.btnSelectImage.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnSelectImage.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnSelectImage.NormalTextColor = System.Drawing.Color.White;
            this.btnSelectImage.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnSelectImage.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnSelectImage.PressTextColor = System.Drawing.Color.White;
            this.btnSelectImage.Size = new System.Drawing.Size(127, 15);
            this.btnSelectImage.Style = MetroSet_UI.Design.Style.Light;
            this.btnSelectImage.StyleManager = null;
            this.btnSelectImage.TabIndex = 19;
            this.btnSelectImage.Text = "...";
            this.btnSelectImage.ThemeAuthor = "Narwin";
            this.btnSelectImage.ThemeName = "MetroLite";
            this.btnSelectImage.Click += new System.EventHandler(this.btnSelectImage_Click);
            // 
            // ofdSelectImage
            // 
            this.ofdSelectImage.FileName = "openFileDialog1";
            // 
            // tmrLoadImage
            // 
            this.tmrLoadImage.Interval = 400;
            this.tmrLoadImage.Tick += new System.EventHandler(this.tmrLoadImage_Tick);
            // 
            // metroSetLabel12
            // 
            this.metroSetLabel12.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetLabel12.Location = new System.Drawing.Point(515, 81);
            this.metroSetLabel12.Name = "metroSetLabel12";
            this.metroSetLabel12.Size = new System.Drawing.Size(118, 22);
            this.metroSetLabel12.Style = MetroSet_UI.Design.Style.Light;
            this.metroSetLabel12.StyleManager = null;
            this.metroSetLabel12.TabIndex = 7;
            this.metroSetLabel12.Text = "Schnellwahl:";
            this.metroSetLabel12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroSetLabel12.ThemeAuthor = "Narwin";
            this.metroSetLabel12.ThemeName = "MetroLite";
            // 
            // pbxMemberImage
            // 
            this.pbxMemberImage.BackColor = System.Drawing.Color.White;
            this.pbxMemberImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxMemberImage.Location = new System.Drawing.Point(638, 110);
            this.pbxMemberImage.Name = "pbxMemberImage";
            this.pbxMemberImage.Size = new System.Drawing.Size(127, 171);
            this.pbxMemberImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxMemberImage.TabIndex = 18;
            this.pbxMemberImage.TabStop = false;
            this.pbxMemberImage.Click += new System.EventHandler(this.pbxMemberImage_Click);
            // 
            // DialAssist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 747);
            this.Controls.Add(this.btnSelectImage);
            this.Controls.Add(this.pbxMemberImage);
            this.Controls.Add(this.chbSearchNotes);
            this.Controls.Add(this.chbSearchNames);
            this.Controls.Add(this.chbSearchDW);
            this.Controls.Add(this.btnOptions);
            this.Controls.Add(this.txbSearch);
            this.Controls.Add(this.cbxAllMembers);
            this.Controls.Add(this.btnOpenDocuments);
            this.Controls.Add(this.btnDeleteEntry);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnAbort);
            this.Controls.Add(this.btnSaveEntry);
            this.Controls.Add(this.btnAlphabetEmail3);
            this.Controls.Add(this.btnAlphabetemail2);
            this.Controls.Add(this.btnAlphabetEmail1);
            this.Controls.Add(this.btnAddEntry);
            this.Controls.Add(this.btnEditEntry);
            this.Controls.Add(this.txbResultNote);
            this.Controls.Add(this.txbResultEmail3);
            this.Controls.Add(this.txbResultEmail2);
            this.Controls.Add(this.txbResultEmail1);
            this.Controls.Add(this.txbResultMobile);
            this.Controls.Add(this.txbResultExtern);
            this.Controls.Add(this.txbResultDW);
            this.Controls.Add(this.txbResultName);
            this.Controls.Add(this.metroSetLabel5);
            this.Controls.Add(this.metroSetLabel4);
            this.Controls.Add(this.metroSetLabel6);
            this.Controls.Add(this.metroSetLabel3);
            this.Controls.Add(this.metroSetLabel2);
            this.Controls.Add(this.lblResultCount);
            this.Controls.Add(this.metroSetLabel12);
            this.Controls.Add(this.metroSetLabel7);
            this.Controls.Add(this.metroSetLabel10);
            this.Controls.Add(this.metroSetLabel9);
            this.Controls.Add(this.metroSetLabel11);
            this.Controls.Add(this.metroSetLabel8);
            this.Controls.Add(this.metroSetLabel1);
            this.Controls.Add(this.lbxResultView);
            this.Controls.Add(this.metroSetControlBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "DialAssist";
            this.Padding = new System.Windows.Forms.Padding(11, 58, 11, 10);
            this.Text = "Lebenshilfe OÖ - Dial Assist";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DialAssist_FormClosing);
            this.cmsDocuments.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxMemberImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroSet_UI.Controls.MetroSetControlBox metroSetControlBox1;
        private System.Windows.Forms.ListBox lbxResultView;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel1;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel2;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel3;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel4;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel5;
        private MetroSet_UI.Controls.MetroSetTextBox txbResultName;
        private MetroSet_UI.Controls.MetroSetTextBox txbResultDW;
        private MetroSet_UI.Controls.MetroSetTextBox txbResultExtern;
        private MetroSet_UI.Controls.MetroSetTextBox txbResultMobile;
        private MetroSet_UI.Controls.MetroSetTextBox txbResultEmail1;
        private MetroSet_UI.Controls.MetroSetTextBox txbResultEmail2;
        private MetroSet_UI.Controls.MetroSetTextBox txbResultEmail3;
        private MetroSet_UI.Controls.MetroSetTextBox txbResultNote;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel6;
        private MetroSet_UI.Controls.MetroSetButton btnEditEntry;
        private MetroSet_UI.Controls.MetroSetButton btnDeleteEntry;
        private MetroSet_UI.Controls.MetroSetButton btnAddEntry;
        private MetroSet_UI.Controls.MetroSetButton btnSearch;
        private MetroSet_UI.Controls.MetroSetButton btnSaveEntry;
        private MetroSet_UI.Controls.MetroSetComboBox cbxAllMembers;
        private System.Windows.Forms.TextBox txbSearch;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel7;
        private MetroSet_UI.Controls.MetroSetLabel lblResultCount;
        private MetroSet_UI.Controls.MetroSetButton btnAbort;
        private MetroSet_UI.Controls.MetroSetButton btnAlphabetEmail1;
        private MetroSet_UI.Controls.MetroSetButton btnAlphabetemail2;
        private MetroSet_UI.Controls.MetroSetButton btnAlphabetEmail3;
        private MetroSet_UI.Controls.MetroDefaultSetButton btnOptions;
        private MetroSet_UI.Controls.MetroSetSwitch chbSearchDW;
        private MetroSet_UI.Controls.MetroSetSwitch chbSearchNames;
        private MetroSet_UI.Controls.MetroSetSwitch chbSearchNotes;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel8;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel9;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel10;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel11;
        private MetroSet_UI.Controls.MetroSetButton btnOpenDocuments;
        private MetroSet_UI.Controls.MetroSetContextMenuStrip cmsDocuments;
        private System.Windows.Forms.ToolStripSeparator tssSeperator;
        private System.Windows.Forms.ToolStripMenuItem tsmAddDocumentEntry;
        private System.Windows.Forms.PictureBox pbxMemberImage;
        private MetroSet_UI.Controls.MetroSetButton btnSelectImage;
        private System.Windows.Forms.OpenFileDialog ofdSelectImage;
        private System.Windows.Forms.Timer tmrLoadImage;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel12;
    }
}

