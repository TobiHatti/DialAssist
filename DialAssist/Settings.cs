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
    public partial class Settings : MetroSetForm
    {
        public bool strictNames = false;
        public bool strictDW = false;
        public bool strictNotes = false;

        public Settings()
        {
            this.AllowResize = false;

            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            chbSearchNames.Switched = strictNames;
            chbSearchDW.Switched = strictDW;
            chbSearchNotes.Switched = strictNotes;
        }

        private void chbSearchNames_SwitchedChanged(object sender)
        {
            strictNames = chbSearchNames.Switched;
        }

        private void chbSearchDW_SwitchedChanged(object sender)
        {
            strictDW = chbSearchDW.Switched;
        }

        private void chbSearchNotes_SwitchedChanged(object sender)
        {
            strictNotes = chbSearchNotes.Switched;
        }

        private void metroSetButton1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
