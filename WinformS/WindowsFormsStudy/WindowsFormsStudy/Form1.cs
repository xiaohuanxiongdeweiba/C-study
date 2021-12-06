using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsStudy
{
    public partial class Form1 : Form
    {
        string[] path = System.IO.Directory.GetFiles(@"C:\Users\Betta\Pictures\pictures");
        int i = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string str = label1.Text;

            label1.Text = str.Substring(1) + str.Substring(0, 1);
            if (i < path.Length-1)
            {
                i++;
            }
            else { i = 0; }
            pictureBox1.Image = Image.FromFile(path[i]);
            pictureBox2.Image = Image.FromFile(path[i]);
            pictureBox3.Image = Image.FromFile(path[i]);
            pictureBox4.Image = Image.FromFile(path[i]);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            //for (int i = 0; i < path.Length; i++)
            //{
              //  MessageBox.Show(path[i]);
            //}
            pictureBox1.Image = Image.FromFile(path[0]);
            pictureBox2.Image = Image.FromFile(path[0]);
            pictureBox3.Image = Image.FromFile(path[0]);
            pictureBox4.Image = Image.FromFile(path[0]);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
