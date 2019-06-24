using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ImageToASCII.ImageActions;

namespace ImageToASCII
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnImportImg_Click(object sender, EventArgs e)
        {
            btnToASCII.Enabled = false;

            imgBox.Image = ImgActions.OpenImage();
            lblPath.Text = ImgActions.GetImagePath;

            btnToASCII.Enabled = ImgActions.hasOpenedImage == true ? true : false;
        }

        private void btnFolder_Click(object sender, EventArgs e)
        {
            TextActions.TxtActions.OpenFolder();
        }

        private void btnToASCII_Click(object sender, EventArgs e)
        {
            string fileName = System.IO.Path.GetFileNameWithoutExtension(lblPath.Text);
            TextActions.TxtActions.GetFileName(fileName);
            ImgActions.ToASCII(lblPath.Text, TextActions.TxtActions.GetFileName(fileName));
            MessageBox.Show("Command completed.");
        }
    }
}
