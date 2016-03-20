using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Space_İnvaders_v._1._0
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public static string ad;
        public static string resim;

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show();
            this.Hide();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult sonuc;
            sonuc = MessageBox.Show("Çıkmak istediğinizden emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (sonuc == DialogResult.Yes)
                Application.Exit();

            if (sonuc == DialogResult.No)
            {
                Application.Run();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ad = textBox1.Text;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox1.Text = "Oyuncu1";
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            resim = "1";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            resim = "2";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            resim = "3";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            resim = "4";
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            resim = "5";
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            resim = "6";
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            resim = "7";
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            resim = "8";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            radioButton2.Checked = true;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            radioButton3.Checked = true;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            radioButton4.Checked = true;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            radioButton5.Checked = true;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            radioButton6.Checked = true;
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            radioButton7.Checked = true;
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            radioButton8.Checked = true;
        }
    }
}
