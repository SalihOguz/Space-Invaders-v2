using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Space_İnvaders_v._1._0
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        public Form1 frm1 = new Form1();

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
            this.Hide();
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.skorTableAdapter.Fill(this.uzaylı_AvıDataSet1.skor);
            listele();
        }

        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Uzaylı Avı.accdb");
        
        void baglan()
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
        }
        void listele()
        {
            baglan();
            DataTable dt = new DataTable();
           OleDbDataAdapter ad = new OleDbDataAdapter("SELECT * FROM skor Order by '"+Form1.puan+"' ASC", conn);
            ad.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
