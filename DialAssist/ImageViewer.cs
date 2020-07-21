using MetroSet_UI.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DialAssist
{
    public partial class ImageViewer : MetroSetForm
    {
        public string ImageB64 { get; set; } = "";
        public ImageViewer()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ImageViewer_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ImageB64))
                pbxViewPort.Image = Image.FromStream(new MemoryStream(Convert.FromBase64String(ImageB64)));
            else
                pbxViewPort.Image = Properties.Resources.user;
        }
    }
}
