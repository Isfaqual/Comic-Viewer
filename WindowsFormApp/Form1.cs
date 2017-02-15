using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormApp
{
    public partial class Form1 : Form
    {

        Image myImage;

        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void openImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                myImage = Image.FromFile(ofd.FileName);
                System.Diagnostics.Debug.WriteLine("Size of image: "+myImage.Width + ", " + myImage.Height);
                pictureBoxLeft.Image = myImage;
            }
        }

        private void pictureBoxLeft_Click(object sender, EventArgs e)
        {

        }

    }
}
