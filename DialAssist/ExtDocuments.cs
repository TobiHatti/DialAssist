using MetroSet_UI.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DialAssist
{
    public partial class ExtDocuments : MetroSetForm
    {
        public string DocumentName { get; set; } = "";
        public string DocumentPath { get; set; } = "";

        public ExtDocuments()
        {
            InitializeComponent();
            this.AllowResize = false;
        }

        private void ExtDocuments_Load(object sender, EventArgs e)
        {
            txbDocumentName.Text = DocumentName;
            txbDocumentPath.Text = DocumentPath;
        }

        private void btnSubmitDocument_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txbDocumentName.Text))
            {
                MetroSetMessageBox.Show(this, "Bitte vergeben Sie eine Dokumentenbezeichnung", "Fehler");
                return;
            }

            if (string.IsNullOrEmpty(txbDocumentPath.Text))
            {
                MetroSetMessageBox.Show(this, "Bitte wählen Sie ein Dokument aus", "Fehler");
                return;
            }

            DocumentName = txbDocumentName.Text;
            DocumentPath = txbDocumentPath.Text;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void metroSetButton1_Click(object sender, EventArgs e)
        {
            if(ofdSelectFile.ShowDialog() == DialogResult.OK)
            {
                txbDocumentPath.Text = ofdSelectFile.FileName;
            }
        }

        
    }
}
