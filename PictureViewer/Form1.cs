using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace PictureViewer
{
    public partial class Form1 : Form
    {
        public Image ımage;
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Çıkmak İstediğinden Emin Misin?", "Kapatayım Mı?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog==DialogResult.Yes)
            {
                MessageBox.Show("Kapatıyorum, Kapat!");
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ımage = Image.FromFile(openFileDialog1.FileName);
                pictureBox1.Image = ımage;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = ımage;
                ımage.Save(openFileDialog1.FileName);
            }
        }
    }
}