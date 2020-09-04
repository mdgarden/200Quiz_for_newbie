using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A175_imageViewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "ImageViewer";
            pictureBox1.BackColor = Color.White;
        }

        private void imageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image File(.jpg)|*.jpg|all File(*.*)|*.*";
            openFileDialog1.Title = "Open Image";
            openFileDialog1.FileName = "";
            openFileDialog1.ShowDialog();
            if( openFileDialog1.FileName != "")
            {
                pictureBox1.Image = new Bitmap(openFileDialog1.FileName);
            }
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void normalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
        }

        private void stretchImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void autoSizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
        }

        private void centerImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
        }

        private void zoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
