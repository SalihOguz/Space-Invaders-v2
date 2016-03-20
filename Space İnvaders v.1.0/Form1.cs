using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SpeechLib;
using System.Data.OleDb;

namespace Space_İnvaders_v._1._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }
        public int deger = 0;
        public int zaman = 60;
        public static int puan = 0;
        public int cubukdeger = 0;
        public int isaret;
        public int kisi;
        public int isareta;
        public int sayi=0;
        public int gx;
        public int gy;
        public int can;

        private void Form1_Load(object sender, EventArgs e)
        {
            //Tanımlamalar
            gx = (gemiresmi.Location.X) + 12;
            gy = (gemiresmi.Location.Y) - 7;
            
            zamansayaci.Start();
            canlarsaga.Start();
            this.Text = "Doğukan Ahuçalar ve Mustafa Salih Oğuz ve ";
            Yazı.Enabled = true;
            Yazı.Interval = 80;
            can = 3;

            puan = 0;

            if (Form2.resim=="1")
                gemiresmi.ImageLocation = (Application.StartupPath + "\\resimler\\1.jpg"); 
            if (Form2.resim == "2")
                gemiresmi.ImageLocation = (Application.StartupPath + "\\resimler\\2.jpg");
            if (Form2.resim == "3")
                gemiresmi.ImageLocation = (Application.StartupPath + "\\resimler\\3.jpg");
            if (Form2.resim == "4")
                gemiresmi.ImageLocation = (Application.StartupPath + "\\resimler\\5.jpg");
            if (Form2.resim == "5")
                gemiresmi.ImageLocation = (Application.StartupPath + "\\resimler\\6.jpg");
            if (Form2.resim == "6")
                gemiresmi.ImageLocation = (Application.StartupPath + "\\resimler\\7.jpg");
            if (Form2.resim == "7")
                gemiresmi.ImageLocation = (Application.StartupPath + "\\resimler\\8.jpg");
            if (Form2.resim == "8")
                gemiresmi.ImageLocation = (Application.StartupPath + "\\resimler\\9.jpg"); 

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)//Gemi sola hareketi
            {
                sola.Start();
                saga.Stop();  
            }

            if (e.KeyCode == Keys.Right)//Gemi sağa hareketi
            {
                saga.Start();
                sola.Stop();
            }
            if (e.KeyCode == Keys.Down)//Gemi durdur
            {
                saga.Stop();
                sola.Stop();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
                if (e.KeyCode == Keys.Space)//Füze atımı
                {
                    if (patlama.Visible == false)//Oyuncu vurulmadıysa
                    {
                        deger = 1;
                        füzeresmi.Visible = true;
                        missileattack.Start();
                    }
                }
        }

        
        private void Yazı_Tick(object sender, EventArgs e)
        {
            this.Text = this.Text.Substring(1) + this.Text.Substring(0, 1);
        }

        void otuzlukvurma()
        {
            füzeresmi.Location = new Point(gx, gy);
            deger = 0;
            füzeresmi.Visible = false;

            //Puan hesaplama
            puan += zaman * 30;
            puanl.Text = puan.ToString();
            missileattack.Stop();
        }

        void yirmilikvurma()
        {
            füzeresmi.Location = new Point(gx, gy);
            deger = 0;
            füzeresmi.Visible = false;

            //Puan hesaplama
            puan += zaman * 20;
            puanl.Text = puan.ToString();
            missileattack.Stop();
        }

        void onlukvurma()
        {
            füzeresmi.Location = new Point(gx, gy);
            deger = 0;
            füzeresmi.Visible = false;

            //Puan hesaplama
            puan += zaman * 10;
            puanl.Text = puan.ToString();
            missileattack.Stop();
        }

        private void missileattack_Tick(object sender, EventArgs e)
        {
            füzeresmi.Top -= 20;
            int fuztop = füzeresmi.Top;
            int fuzsol = füzeresmi.Left;
            int fuzsag = füzeresmi.Right;

            gx = (gemiresmi.Location.X) + 12;//Yerleri sürekli değiştiği için
            gy = (gemiresmi.Location.Y) - 7;

            if (füzeresmi.Top < 0)//Füze geri döndürme
            {
                füzeresmi.Location = new Point(gx, gy);
                deger = 0;
                füzeresmi.Visible = false;
                missileattack.Stop();
            }

            if (can1.Bottom >= fuztop && can1.Left <= fuzsol && can1.Right >= fuzsag)
            {
                can1.Visible = false;
                can1.Left = 1200;
                otuzlukvurma();
                at1.Visible = false;
            }
            else if (can2.Bottom >= fuztop && can2.Left <= fuzsol && can2.Right >= fuzsag)
            {
                can2.Visible = false;
                can2.Left = 1200;
                otuzlukvurma();
                at2.Visible = false;
            }
            else  if (can3.Bottom >= fuztop && can3.Left <= fuzsol && can3.Right >= fuzsag)
            {
                can3.Visible = false;
                can3.Left = 1200;
                otuzlukvurma();
                at3.Visible = false;
            }
            else  if (can4.Bottom >= fuztop && can4.Left <= fuzsol && can4.Right >= fuzsag)
            {
                can4.Visible = false;
                can4.Left = 1200;
                otuzlukvurma();
                at4.Visible = false;
            }
            else  if (can5.Bottom >= fuztop && can5.Left <= fuzsol && can5.Right >= fuzsag)
            {
                can5.Visible = false;
                can5.Left = 1200;
                otuzlukvurma();
                at5.Visible = false;
            }
            else  if (can6.Bottom >= fuztop && can6.Left <= fuzsol && can6.Right >= fuzsag)
            {
                can6.Visible = false;
                can6.Left = 1200;
                otuzlukvurma();
                at6.Visible = false;
            }
            else  if (can7.Bottom >= fuztop && can7.Left <= fuzsol && can7.Right >= fuzsag)
            {
                can7.Visible = false;
                can7.Left = 1200;
                yirmilikvurma();
                at7.Visible = false;
            }
            else  if (can8.Bottom >= fuztop && can8.Left <= fuzsol && can8.Right >= fuzsag)
            {
                can8.Visible = false;
                can8.Left = 1200;
                yirmilikvurma();
                at8.Visible = false;
            }
            else  if (can9.Bottom >= fuztop && can9.Left <= fuzsol && can9.Right >= fuzsag)
            {
                can9.Visible = false;
                can9.Left = 1200;
                yirmilikvurma();
                at9.Visible = false;
            }
            else  if (can10.Bottom >= fuztop && can10.Left <= fuzsol && can10.Right >= fuzsag)
            {
                can10.Visible = false;
                can10.Left = 1200;
                can10.Top = 2;
                yirmilikvurma();
                at10.Visible = false;
            }
            else  if (can11.Bottom >= fuztop && can11.Left <= fuzsol && can11.Right >= fuzsag)
            {
                can11.Visible = false;
                can11.Left = 1200;
                can11.Top = 2;
                yirmilikvurma();
                at11.Visible = false;
            }
            else  if (can12.Bottom >= fuztop && can12.Left <= fuzsol && can12.Right >= fuzsag)
            {
                can12.Visible = false;
                can12.Left = 1200;
                can12.Top = 2;
                yirmilikvurma();
                at12.Visible = false;
            }
            else if (can13.Bottom >= fuztop && can13.Left <= fuzsol && can13.Right >= fuzsag)
            {
                can13.Visible = false;
                can13.Left = 1200;
                can13.Top = 2;
                onlukvurma();
                at13.Visible = false;
            }
            else  if (can14.Bottom >= fuztop && can14.Left <= fuzsol && can14.Right >= fuzsag)
            {
                can14.Visible = false;
                can14.Left = 1200;
                can14.Top = 2;
                onlukvurma();
                at14.Visible = false;
            }
            else  if (can15.Bottom >= fuztop && can15.Left <= fuzsol && can15.Right >= fuzsag)
            {
                can15.Visible = false;
                can15.Left = 1200;
                can15.Top = 2;
                onlukvurma();
                at15.Visible = false;
            }
            else  if (can16.Bottom >= fuztop && can16.Left <= fuzsol && can16.Right >= fuzsag)
            {
                can16.Visible = false;
                can16.Left = 1200;
                can16.Top = 2;
                onlukvurma();
                at16.Visible = false;
            }
            else  if (can17.Bottom >= fuztop && can17.Left <= fuzsol && can17.Right >= fuzsag)
            {
                can17.Visible = false;
                can17.Left = 1200;
                can17.Top = 2;
                onlukvurma();
                at17.Visible = false;
            }
            else  if (can18.Bottom >= fuztop && can18.Left <= fuzsol && can18.Right >= fuzsag)
            {
                can18.Visible = false;
                can18.Left = 1200;
                can18.Top = 2;
                onlukvurma();
                at18.Visible = false;
            }
        }

        private void canlarsola_Tick(object sender, EventArgs e)
        {
            can1.Left -= 4;
            can2.Left -= 4;
            can3.Left -= 4;
            can4.Left -= 4;
            can5.Left -= 4;
            can6.Left -= 4;
            can7.Left -= 4;
            can8.Left -= 4;
            can9.Left -= 4;
            can10.Left -= 4;
            can11.Left -= 4;
            can12.Left -= 4;
            can13.Left -= 4;
            can14.Left -= 4;
            can15.Left -= 4;
            can16.Left -= 4;
            can17.Left -= 4;
            can18.Left -= 4;
            sagduvar.Left -= 4;
            solduvar.Left -= 4;

            if (solduvar.Left <= 6)
            {
                canlarsola.Stop();
                can1.Top += 14;
                can2.Top += 14;
                can3.Top += 14;
                can4.Top += 14;
                can5.Top += 14;
                can6.Top += 14;
                can7.Top += 14;
                can8.Top += 14;
                can9.Top += 14;
                can10.Top += 14;
                can11.Top += 14;
                can12.Top += 14;
                can13.Top += 14;
                can14.Top += 14;
                can15.Top += 14;
                can16.Top += 14;
                can17.Top += 14;
                can18.Top += 14;
                sagduvar.Top += 14;
                solduvar.Top += 14;
                canlarsaga.Start();
            }
        }

        private void zamansayaci_Tick(object sender, EventArgs e)//ZAMANLAMA
        {
            if (zaman == 0)//Zaman bitmesi
            {
                bitme();
            }

            zaman--;
            zamanl.Text = zaman.ToString();

            if (zaman % 3 == 0)//3sn de 1 Ateş Etme
            {
                Random iz = new Random();//İşaret Seçimi, sağa mı sola mı?
                isareta = iz.Next(1, 4);
                Random kisisay = new Random();//Kaç kişi ateş
                    kisi = kisisay.Next(1, 19);

                if (isareta == 1)
                    isaret = 4;
                if (isareta == 2)
                    isaret = -4;
                if (isareta == 3)
                    isaret = 0;

                //Yerleri sürekli değiştiği için tekrar tanımlıyoruz
                int c1x = can1.Location.X;//X eksenleri
                int c2x = can2.Location.X;
                int c3x = can3.Location.X;
                int c4x = can4.Location.X;
                int c5x = can5.Location.X;
                int c6x = can6.Location.X;
                int c7x = can7.Location.X;
                int c8x = can8.Location.X;
                int c9x = can9.Location.X;
                int c10x = can10.Location.X;
                int c11x = can11.Location.X;
                int c12x = can12.Location.X;
                int c13x = can13.Location.X;
                int c14x = can14.Location.X;
                int c15x = can15.Location.X;
                int c16x = can16.Location.X;
                int c17x = can17.Location.X;

                int c1y = can1.Location.Y;//Y eksenleri
                int c2y = can2.Location.Y;
                int c3y = can3.Location.Y;
                int c4y = can4.Location.Y;
                int c5y = can5.Location.Y;
                int c6y = can6.Location.Y;
                int c7y = can7.Location.Y;
                int c8y = can8.Location.Y;
                int c9y = can9.Location.Y;
                int c10y = can10.Location.Y;
                int c11y = can11.Location.Y;
                int c12y = can12.Location.Y;
                int c13y = can13.Location.Y;
                int c14y = can14.Location.Y;
                int c15y = can15.Location.Y;
                int c16y = can16.Location.Y;
                int c17y = can17.Location.Y;
                int c18y = can18.Location.Y;
                int c18x = can18.Location.X;

                    at1.Location = new Point(c1x, c1y);
                    at2.Location = new Point(c2x, c2y);
                    at3.Location = new Point(c3x, c3y);
                    at4.Location = new Point(c4x, c4y);
                    at5.Location = new Point(c5x, c5y);
                    at6.Location = new Point(c6x, c6y);
                    at7.Location = new Point(c7x, c7y);
                    at8.Location = new Point(c8x, c8y);
                    at9.Location = new Point(c9x, c9y);
                    at10.Location = new Point(c10x, c10y);
                    at11.Location = new Point(c11x, c11y);
                    at12.Location = new Point(c12x, c12y);
                    at13.Location = new Point(c13x, c13y);
                    at14.Location = new Point(c14x, c14y);
                    at15.Location = new Point(c15x, c15y);
                    at16.Location = new Point(c16x, c16y);
                    at17.Location = new Point(c17x, c17y);
                    at18.Location = new Point(c18x, c18y);

                    at1.Visible = false;
                    at2.Visible = false;
                    at3.Visible = false;
                    at4.Visible = false;
                    at5.Visible = false;
                    at6.Visible = false;
                    at7.Visible = false;
                    at8.Visible = false;
                    at9.Visible = false;
                    at10.Visible = false;
                    at11.Visible = false;
                    at12.Visible = false;
                    at13.Visible = false;
                    at14.Visible = false;
                    at15.Visible = false;
                    at16.Visible = false;
                    at17.Visible = false;
                    at18.Visible = false;

                    sayi = 0;

                if (patlama.Visible == false)//Gemi vurulmamışsa
                {
                    atlar.Start();
                }

                //Kaybetme
                if (can1.Bottom >= 425 || can2.Bottom >= 425 || can3.Bottom >= 425 || can4.Bottom >= 425 || can5.Bottom >= 425 || can6.Bottom >= 425 || can7.Bottom >= 425 || can8.Bottom >= 425 || can8.Bottom >= 425 ||
                    can10.Bottom >= 425 || can11.Bottom >= 425 || can12.Bottom >= 425 || can13.Bottom >= 425 || can14.Bottom >= 425 || can15.Bottom >= 425 || can16.Bottom >= 425 || can17.Bottom >= 425 || can18.Bottom >= 425)
                {
                    bitme();
                }

                //Kazanma
                if (can1.Visible == false && can2.Visible == false && can3.Visible == false && can4.Visible == false && can5.Visible == false && can6.Visible == false && can7.Visible == false && can8.Visible == false &&
                    can9.Visible == false && can10.Visible == false && can11.Visible == false && can12.Visible == false && can13.Visible == false && can14.Visible == false && can15.Visible == false && can16.Visible == false &&
                    can17.Visible == false && can18.Visible == false)
                {
                    youwon.Visible = true;
                    canlarsaga.Stop();
                    canlarsola.Stop();
                    zamansayaci.Stop();
                    missileattack.Stop();
                    cancubuk.Visible = true;
                    kayitekleme();
                    cubuk.Start();
                }

                //Ateşleri Geri Döndürme
                if (at1.Top >= 560)
                {
                    at1.Visible = false;
                    at1.Location = new Point(c1x, c1y);
                    sayi = 0;
                    atlar.Stop();
                }
                if (at5.Top >= 560)
                {
                    at5.Visible = false;
                    at5.Location = new Point(c1x, c1y);
                    sayi = 0;
                    atlar.Stop();
                }
                if (at3.Top >= 560)
                {
                    at3.Visible = false;
                    at3.Location = new Point(c1x, c1y);
                    sayi = 0;
                    atlar.Stop();
                }
                if (at4.Top >= 560)
                {
                    at4.Visible = false;
                    at4.Location = new Point(c1x, c1y);
                    sayi = 0;
                    atlar.Stop();
                }
                if (at5.Top >= 560)
                {
                    at5.Visible = false;
                    at5.Location = new Point(c1x, c1y);
                    sayi = 0;
                    atlar.Stop();
                }
                if (at6.Top >= 560)
                {
                    at6.Visible = false;
                    at6.Location = new Point(c1x, c1y);
                    sayi = 0;
                    atlar.Stop();
                }
                if (at7.Top >= 560)
                {
                    at7.Visible = false;
                    at7.Location = new Point(c1x, c1y);
                    sayi = 0;
                    atlar.Stop();
                }
                if (at8.Top >= 560)
                {
                    at8.Visible = false;
                    at8.Location = new Point(c1x, c1y);
                    sayi = 0;
                    atlar.Stop();
                }
                if (at9.Top >= 560)
                {
                    at9.Visible = false;
                    at9.Location = new Point(c1x, c1y);
                    sayi = 0;
                    atlar.Stop();
                }
                if (at10.Top >= 560)
                {
                    at10.Visible = false;
                    at10.Location = new Point(c1x, c1y);
                    sayi = 0;
                    atlar.Stop();
                }
                if (at11.Top >= 560)
                {
                    at11.Visible = false;
                    at11.Location = new Point(c1x, c1y);
                    sayi = 0;
                    atlar.Stop();
                }
                if (at12.Top >= 560)
                {
                    at12.Visible = false;
                    at12.Location = new Point(c1x, c1y);
                    sayi = 0;
                    atlar.Stop();
                }
                if (at13.Top >= 560)
                {
                    at13.Visible = false;
                    at13.Location = new Point(c1x, c1y);
                    sayi = 0;
                    atlar.Stop();
                }
                if (at14.Top >= 560)
                {
                    at14.Visible = false;
                    at14.Location = new Point(c1x, c1y);
                    sayi = 0;
                    atlar.Stop();
                }
                if (at15.Top >= 560)
                {
                    at15.Visible = false;
                    at15.Location = new Point(c1x, c1y);
                    sayi = 0;
                    atlar.Stop();
                }
                if (at16.Top >= 560)
                {
                    at16.Visible = false;
                    at16.Location = new Point(c1x, c1y);
                    sayi = 0;
                    atlar.Stop();
                }
                if (at17.Top >= 560)
                {
                    at17.Visible = false;
                    at17.Location = new Point(c1x, c1y);
                    sayi = 0;
                    atlar.Stop();
                }
                if (at18.Top >= 560)
                {
                    at18.Visible = false;
                    at18.Location = new Point(c1x, c1y);
                    sayi = 0;
                    atlar.Stop();
                }
            }
        }

        private void canlarsaga_Tick(object sender, EventArgs e)
        {
            can1.Left += 4;
            can2.Left += 4;
            can3.Left += 4;
            can4.Left += 4;
            can5.Left += 4;
            can6.Left += 4;
            can7.Left += 4;
            can8.Left += 4;
            can9.Left += 4;
            can10.Left += 4;
            can11.Left += 4;
            can12.Left += 4;
            can13.Left += 4;
            can14.Left += 4;
            can15.Left += 4;
            can16.Left += 4;
            can17.Left += 4;
            can18.Left += 4;
            sagduvar.Left += 4;
            solduvar.Left += 4;

            if (sagduvar.Left >= 610)
            {
                canlarsola.Start();
                canlarsaga.Stop();
            }

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void cubuk_Tick(object sender, EventArgs e)
        {
            progressBar1.Visible = true;
            if (cubukdeger == 100)
            {
                Form3 frm3 = new Form3();
                frm3.Show();
                this.Hide();
                cubuk.Stop();
            }
            progressBar1.Value = cubukdeger;
            cubukdeger++;
        }

        private void saga_Tick(object sender, EventArgs e)
        {
            if (patlama.Visible == false)//Oyuncu vurulmadıysa
            {
                if (gemiresmi.Left >= 550)
                {
                    saga.Stop();
                    gemiresmi.Left = 550;
                    patlama.Left = 550;
                }

                gemiresmi.Left += 4;
                patlama.Left += 4;

                while (deger == 0)
                {
                    füzeresmi.Left += 4;
                    deger = 2;
                }
                if (deger == 2)
                    deger = 0;
            }
        }

        private void sola_Tick(object sender, EventArgs e)
        {
            if (patlama.Visible == false)//Oyuncu vurulmadıysa
            {
                if (gemiresmi.Left <= 0)
                {
                    sola.Stop();
                    gemiresmi.Left = 0;
                    patlama.Left = 0;
                }

                gemiresmi.Left -= 4;
                patlama.Left -= 4;

                while (deger == 0)
                {
                    füzeresmi.Left -= 4;
                    deger = 2;
                }
                if (deger == 2)
                    deger = 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SpVoice tekrardene = new SpVoice();
            tekrardene.Speak(textBox1.Text, SpeechVoiceSpeakFlags.SVSFDefault);

            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
            this.Hide();
        }

        private void atlar_Tick(object sender, EventArgs e)
        {
            //Yerleri sürekli değiştiği için tekrar tanımlıyoruz
            int c1x = can1.Location.X;//X eksenleri
            int c2x = can2.Location.X;
            int c3x = can3.Location.X;
            int c4x = can4.Location.X;
            int c5x = can5.Location.X;
            int c6x = can6.Location.X;
            int c7x = can7.Location.X;
            int c8x = can8.Location.X;
            int c9x = can9.Location.X;
            int c10x = can10.Location.X;
            int c11x = can11.Location.X;
            int c12x = can12.Location.X;
            int c13x = can13.Location.X;
            int c14x = can14.Location.X;
            int c15x = can15.Location.X;
            int c16x = can16.Location.X;
            int c17x = can17.Location.X;

            int c1y = can1.Location.Y;//Y eksenleri
            int c2y = can2.Location.Y;
            int c3y = can3.Location.Y;
            int c4y = can4.Location.Y;
            int c5y = can5.Location.Y;
            int c6y = can6.Location.Y;
            int c7y = can7.Location.Y;
            int c8y = can8.Location.Y;
            int c9y = can9.Location.Y;
            int c10y = can10.Location.Y;
            int c11y = can11.Location.Y;
            int c12y = can12.Location.Y;
            int c13y = can13.Location.Y;
            int c14y = can14.Location.Y;
            int c15y = can15.Location.Y;
            int c16y = can16.Location.Y;
            int c17y = can17.Location.Y;
            int c18y = can18.Location.Y;
            int c18x = can18.Location.X;

            //atlar location x
            int a1x = at1.Location.X;
            int a2x = at2.Location.X;
            int a3x = at3.Location.X;
            int a4x = at4.Location.X;
            int a5x = at5.Location.X;
            int a6x = at6.Location.X;
            int a7x = at7.Location.X;
            int a8x = at8.Location.X;
            int a9x = at9.Location.X;
            int a10x = at10.Location.X;
            int a11x = at11.Location.X;
            int a12x = at12.Location.X;
            int a13x = at13.Location.X;
            int a14x = at14.Location.X;
            int a15x = at15.Location.X;
            int a16x = at16.Location.X;
            int a17x = at17.Location.X;
            int a18x = at18.Location.X;

            //atlar location y
            int a1y = at1.Location.Y;
            int a2y = at2.Location.Y;
            int a3y = at3.Location.Y;
            int a4y = at4.Location.Y;
            int a5y = at5.Location.Y;
            int a6y = at6.Location.Y;
            int a7y = at7.Location.Y;
            int a8y = at8.Location.Y;
            int a9y = at9.Location.Y;
            int a10y = at10.Location.Y;
            int a11y = at11.Location.Y;
            int a12y = at12.Location.Y;
            int a13y = at13.Location.Y;
            int a14y = at14.Location.Y;
            int a15y = at15.Location.Y;
            int a16y = at16.Location.Y;
            int a17y = at17.Location.Y;
            int a18y = at18.Location.Y;

            

            //ATESETME
            if (kisi == 1 && can1.Visible == true)
            {
                at1.Visible = true;
                if (a1x <= 0)//Sola çarparsa
                {
                    sayi = 1;
                }
                if (a1x >= 650)//Sağa çarparsa
                {
                    sayi = 2;
                }
                if (sayi == 0)
                    at1.Location = new Point(a1x + isaret, a1y + 10);

                if (sayi == 1)
                    at1.Location = new Point(a1x + 5, a1y + 10);

                if (sayi == 2)
                    at1.Location = new Point(a1x - 5, a1y + 10);

                if (at1.Bottom >= gemiresmi.Top && at1.Left >= gemiresmi.Left && at1.Right <= gemiresmi.Right)//Vurulma
                {
                    if (can == 3 || can == 2 || can == 1)
                    {
                        at1.Visible = false;
                        c1x = can1.Location.X;
                        c1y = can1.Location.Y;
                        at1.Location = new Point(c1x, c1y);
                        cancubuk.Value -= 30;
                        can--;
                        atlar.Stop();
                    }
                    if (can == 0)
                    {
                        gemiresmi.Visible = false;
                        patlama.Visible = true;
                        at1.Location = new Point(c1x, c1y);
                        at1.Visible = false;
                        bitme();
                        atlar.Stop();
                    }
                }
            }
                if (kisi == 2 && can2.Visible == true)
                {
                    at2.Visible = true;

                    if (a2x <= 0)//Sola çarparsa
                    {
                        sayi = 1;
                    }
                    if (a5x >= 650)//Sağa çarparsa
                    {
                        sayi = 2;
                    }

                    if (sayi == 0)
                        at5.Location = new Point(a2x + isaret, a2y + 10);

                    if (sayi == 1)
                        at5.Location = new Point(a2x + 5, a2y + 10);

                    if (sayi == 2)
                        at5.Location = new Point(a2x - 5, a2y + 10);


                    if (at2.Bottom >= gemiresmi.Top && at2.Left >= gemiresmi.Left && at2.Right <= gemiresmi.Right)//Vurulma
                    {
                        if (can == 3 || can == 2 || can == 1)
                        {
                            at2.Visible = false;
                            c2x = can2.Location.X;
                            c2y = can2.Location.Y;
                            at2.Location = new Point(c2x, c2y);
                            cancubuk.Value -= 30;
                            can--;
                            atlar.Stop();
                        }
                        if (can == 0)
                        {
                            gemiresmi.Visible = false;
                            patlama.Visible = true;
                            at2.Location = new Point(c2x, c2y);
                            at2.Visible = false;
                            bitme();
                            atlar.Stop();
                        }
                    }
                }

                if (kisi == 3 && can3.Visible == true)
                {
                    at3.Visible = true;
                    if (a3x <= 0)//Sola çarparsa
                    {
                        sayi =1;
                    }
                    if (a3x >= 650)//Sağa çarparsa
                    {
                        sayi = 2;
                    }
                    if (sayi == 0)
                        at3.Location = new Point(a3x + isaret, a3y + 10);

                    if (sayi == 1)
                        at3.Location = new Point(a3x + 5, a3y + 10);

                    if (sayi == 2)
                        at3.Location = new Point(a3x - 5, a3y + 10);

                    if (at3.Bottom >= gemiresmi.Top && at3.Left >= gemiresmi.Left && at3.Right <= gemiresmi.Right)//Vurulma
                    {
                        if (can == 3 || can == 2 || can == 1)
                        {
                            at3.Visible = false;
                            c3x = can3.Location.X;
                            c3y = can3.Location.Y;
                            at3.Location = new Point(c3x, c3y);
                            cancubuk.Value -= 30;
                            can--;
                            atlar.Stop();
                        }
                        if (can == 0)
                        {
                            gemiresmi.Visible = false;
                            patlama.Visible = true;
                            at3.Location = new Point(c3x, c3y);
                            at3.Visible = false;
                            bitme();
                            atlar.Stop();
                        }
                    }
                }
                if (kisi == 4 && can4.Visible == true)
                {
                    at4.Visible = true;
                    if (a4x <= 0)//Sola çarparsa
                    {
                        sayi = 1;
                    }
                    if (a4x >= 650)//Sağa çarparsa
                    {
                        sayi = 2;
                    }
                    if (sayi == 0)
                        at4.Location = new Point(a4x + isaret, a4y + 10);

                    if (sayi == 1)
                        at4.Location = new Point(a4x + 5, a4y + 10);

                    if (sayi == 2)
                        at4.Location = new Point(a4x - 5, a4y + 10);

                    if (at4.Bottom >= gemiresmi.Top && at4.Left >= gemiresmi.Left && at4.Right <= gemiresmi.Right)//Vurulma
                    {
                        if (can == 3 || can == 2 || can == 1)
                        {
                            at4.Visible = false;
                            c4x = can4.Location.X;
                            c4y = can4.Location.Y;
                            at4.Location = new Point(c4x, c4y);
                            cancubuk.Value -= 30;
                            can--;
                            atlar.Stop();
                        }
                        if (can == 0)
                        {
                            gemiresmi.Visible = false;
                            patlama.Visible = true;
                            at4.Location = new Point(c4x, c4y);
                            at4.Visible = false;
                            bitme();
                            atlar.Stop();
                        }
                    }
                }
                if (kisi == 5 && can5.Visible == true)
                {
                    at5.Visible = true;
                    if (a5x <= 0)//Sola çarparsa
                    {
                        sayi = 1;
                    }
                    if (a5x >= 650)//Sağa çarparsa
                    {
                        sayi = 2;
                    }
                    if (sayi == 0)
                        at5.Location = new Point(a5x + isaret, a5y + 10);

                    if (sayi == 1)
                        at5.Location = new Point(a5x + 5, a5y + 10);

                    if (sayi == 2)
                        at5.Location = new Point(a5x - 5, a5y + 10);

                    if (at5.Bottom >= gemiresmi.Top && at5.Left >= gemiresmi.Left && at5.Right <= gemiresmi.Right)//Vurulma
                    {
                        if (can == 3 || can == 2 || can == 1)
                        {
                            at5.Visible = false;
                            c5x = can5.Location.X;
                            c5y = can5.Location.Y;
                            at5.Location = new Point(c5x, c5y);
                            cancubuk.Value -= 30;
                            can--;
                            atlar.Stop();
                        }
                        if (can == 0)
                        {
                            gemiresmi.Visible = false;
                            patlama.Visible = true;
                            at5.Location = new Point(c5x, c5y);
                            at5.Visible = false;
                            bitme();
                            atlar.Stop();
                        }
                    }
                }
                if (kisi == 6 && can6.Visible == true)
                {
                    at6.Visible = true;
                    if (a6x <= 0)//Sola çarparsa
                    {
                        sayi = 1;
                    }
                    if (a6x >= 620)//Sağa çarparsa
                    {
                        sayi = 2;
                    }
                    if (sayi == 0)
                        at6.Location = new Point(a6x + isaret, a6y + 10);

                    if (sayi == 1)
                        at6.Location = new Point(a6x + 2, a6y + 10);

                    if (sayi == 2)
                        at6.Location = new Point(a6x - 2, a6y + 10);

                    if (at6.Bottom >= gemiresmi.Top && at6.Left >= gemiresmi.Left && at6.Right <= gemiresmi.Right)//Vurulma
                    {
                        if (can == 3 || can == 2 || can == 1)
                        {
                            at6.Visible = false;
                            c6x = can6.Location.X;
                            c6y = can6.Location.Y;
                            at6.Location = new Point(c6x, c6y);
                            cancubuk.Value -= 30;
                            can--;
                            atlar.Stop();
                        }
                        if (can == 0)
                        {
                            gemiresmi.Visible = false;
                            patlama.Visible = true;
                            at6.Location = new Point(c6x, c6y);
                            at6.Visible = false;
                            bitme();
                            atlar.Stop();
                        }
                    }
                }
                if (kisi == 7 && can7.Visible == true)
                {
                    at7.Visible = true;
                    if (a7x <= 0)//Sola çarparsa
                    {
                        sayi = 1;
                    }
                    if (a7x >= 620)//Sağa çarparsa
                    {
                        sayi = 2;
                    }
                    if (sayi == 0)
                        at7.Location = new Point(a7x + isaret, a7y + 10);

                    if (sayi == 1)
                        at7.Location = new Point(a7x + 2, a7y + 10);

                    if (sayi == 2)
                        at7.Location = new Point(a7x - 2, a7y + 10);

                    if (at7.Bottom >= gemiresmi.Top && at7.Left >= gemiresmi.Left && at7.Right <= gemiresmi.Right)//Vurulma
                    {
                        if (can == 3 || can == 2 || can == 1)
                        {
                            at7.Visible = false;
                            c7x = can7.Location.X;
                            c7y = can7.Location.Y;
                            at7.Location = new Point(c7x, c7y);
                            cancubuk.Value -= 30;
                            can--;
                            atlar.Stop();
                        }
                        if (can == 0)
                        {
                            gemiresmi.Visible = false;
                            patlama.Visible = true;
                            at7.Location = new Point(c7x, c7y);
                            at7.Visible = false;
                            bitme();
                            atlar.Stop();
                        }
                    }
                }
                if (kisi == 8 && can8.Visible == true)
                {
                    at8.Visible = true;
                    if (a8x <= 0)//Sola çarparsa
                    {
                        sayi = 1;
                    }
                    if (a8x >= 620)//Sağa çarparsa
                    {
                        sayi = 2;
                    }
                    if (sayi == 0)
                        at8.Location = new Point(a8x + isaret, a8y + 10);

                    if (sayi == 1)
                        at8.Location = new Point(a8x + 2, a8y + 10);

                    if (sayi == 2)
                        at8.Location = new Point(a8x - 2, a8y + 10);

                    if (at8.Bottom >= gemiresmi.Top && at8.Left >= gemiresmi.Left && at8.Right <= gemiresmi.Right)//Vurulma
                    {
                        if (can == 3 || can == 2 || can == 1)
                        {
                            at8.Visible = false;
                            c8x = can8.Location.X;
                            c8y = can8.Location.Y;
                            at8.Location = new Point(c8x, c8y);
                            cancubuk.Value -= 30;
                            can--;
                            atlar.Stop();
                        }
                        if (can == 0)
                        {
                            gemiresmi.Visible = false;
                            patlama.Visible = true;
                            at8.Location = new Point(c8x, c8y);
                            at8.Visible = false;
                            bitme();
                            atlar.Stop();
                        }
                    }
                }
                if (kisi == 9 && can9.Visible == true)
                {
                    at9.Visible = true;
                    if (a9x <= 0)//Sola çarparsa
                    {
                        sayi = 1;
                    }
                    if (a9x >= 620)//Sağa çarparsa
                    {
                        sayi = 2;
                    }
                    if (sayi == 0)
                        at9.Location = new Point(a9x + isaret, a9y + 10);

                    if (sayi == 1)
                        at9.Location = new Point(a9x + 2, a9y + 10);

                    if (sayi == 2)
                        at9.Location = new Point(a9x - 2, a9y + 10);

                    if (at9.Bottom >= gemiresmi.Top && at9.Left >= gemiresmi.Left && at9.Right <= gemiresmi.Right)//Vurulma
                    {
                        if (can == 3 || can == 2 || can == 1)
                        {
                            at9.Visible = false;
                            c9x = can9.Location.X;
                            c9y = can9.Location.Y;
                            at9.Location = new Point(c9x, c9y);
                            cancubuk.Value -= 30;
                            can--;
                            atlar.Stop();
                        }
                        if (can == 0)
                        {
                            gemiresmi.Visible = false;
                            patlama.Visible = true;
                            at9.Location = new Point(c9x, c9y);
                            at9.Visible = false;
                            bitme();
                            atlar.Stop();
                        }
                    }
                }
                if (kisi == 10 && can10.Visible == true)
                {
                    at10.Visible = true;
                    if (a10x <= 0)//Sola çarparsa
                    {
                        sayi = 1;
                    }
                    if (a10x >= 620)//Sağa çarparsa
                    {
                        sayi = 2;
                    }
                    if (sayi == 0)
                        at10.Location = new Point(a10x + isaret, a10y + 10);

                    if (sayi == 1)
                        at10.Location = new Point(a10x + 2, a10y + 10);

                    if (sayi == 2)
                        at10.Location = new Point(a10x - 2, a10y + 10);

                    if (at10.Bottom >= gemiresmi.Top && at10.Left >= gemiresmi.Left && at10.Right <= gemiresmi.Right)//Vurulma
                    {
                        if (can == 3 || can == 2 || can == 1)
                        {
                            at10.Visible = false;
                            c10x = can10.Location.X;
                            c10y = can10.Location.Y;
                            at10.Location = new Point(c10x, c10y);
                            cancubuk.Value -= 30;
                            can--;
                            atlar.Stop();
                        }
                        if (can == 0)
                        {
                            gemiresmi.Visible = false;
                            patlama.Visible = true;
                            at10.Location = new Point(c10x, c10y);
                            at10.Visible = false;
                            bitme();
                            atlar.Stop();
                        }
                    }
                }
                if (kisi == 11 && can11.Visible == true)
                {
                    at11.Visible = true;
                    if (a11x <= 0)//Sola çarparsa
                    {
                        sayi = 1;
                    }
                    if (a11x >= 620)//Sağa çarparsa
                    {
                        sayi = 2;
                    }
                    if (sayi == 0)
                        at11.Location = new Point(a11x + isaret, a11y + 10);

                    if (sayi == 1)
                        at11.Location = new Point(a11x + 2, a11y + 10);

                    if (sayi == 2)
                        at11.Location = new Point(a11x - 2, a11y + 10);

                    if (at11.Bottom >= gemiresmi.Top && at11.Left >= gemiresmi.Left && at11.Right <= gemiresmi.Right)//Vurulma
                    {
                        if (can == 3 || can == 2 || can == 1)
                        {
                            at11.Visible = false;
                            c11x = can11.Location.X;
                            c11y = can11.Location.Y;
                            at11.Location = new Point(c11x, c11y);
                            cancubuk.Value -= 30;
                            can--;
                            atlar.Stop();
                        }
                        if (can == 0)
                        {
                            gemiresmi.Visible = false;
                            patlama.Visible = true;
                            at11.Location = new Point(c11x, c11y);
                            at11.Visible = false;
                            bitme();
                            atlar.Stop();
                        }
                    }
                }
                if (kisi == 12 && can12.Visible == true)
                {
                    at12.Visible = true;
                    if (a12x <= 0)//Sola çarparsa
                    {
                        sayi = 1;
                    }
                    if (a12x >= 620)//Sağa çarparsa
                    {
                        sayi = 2;
                    }
                    if (sayi == 0)
                        at12.Location = new Point(a12x + isaret, a12y + 10);

                    if (sayi == 1)
                        at12.Location = new Point(a12x + 2, a12y + 10);

                    if (sayi == 2)
                        at12.Location = new Point(a12x - 2, a12y + 10);

                    if (at12.Bottom >= gemiresmi.Top && at12.Left >= gemiresmi.Left && at12.Right <= gemiresmi.Right)//Vurulma
                    {
                        if (can == 3 || can == 2 || can == 1)
                        {
                            at12.Visible = false;
                            c12x = can12.Location.X;
                            c12y = can12.Location.Y;
                            at12.Location = new Point(c12x, c12y);
                            cancubuk.Value -= 30;
                            can--;
                            atlar.Stop();
                        }
                        if (can == 0)
                        {
                            gemiresmi.Visible = false;
                            patlama.Visible = true;
                            at12.Location = new Point(c12x, c12y);
                            at12.Visible = false;
                            bitme();
                            atlar.Stop();
                        }
                    }
                }
                if (kisi == 13 && can13.Visible == true)
                {
                    at13.Visible = true;
                    if (a13x <= 0)//Sola çarparsa
                    {
                        sayi = 1;
                    }
                    if (a13x >= 620)//Sağa çarparsa
                    {
                        sayi = 2;
                    }
                    if (sayi == 0)
                        at13.Location = new Point(a13x + isaret, a13y + 10);

                    if (sayi == 1)
                        at13.Location = new Point(a13x + 2, a13y + 10);

                    if (sayi == 2)
                        at13.Location = new Point(a13x - 2, a13y + 10);

                    if (at13.Bottom >= gemiresmi.Top && at13.Left >= gemiresmi.Left && at13.Right <= gemiresmi.Right)//Vurulma
                    {
                        if (can == 3 || can == 2 || can == 1)
                        {
                            at13.Visible = false;
                            c13x = can13.Location.X;
                            c13y = can13.Location.Y;
                            at13.Location = new Point(c13x, c13y);
                            cancubuk.Value -= 30;
                            can--;
                            atlar.Stop();
                        }
                        if (can == 0)
                        {
                            gemiresmi.Visible = false;
                            patlama.Visible = true;
                            at13.Location = new Point(c13x, c13y);
                            at13.Visible = false;
                            bitme();
                            atlar.Stop();
                        }
                    }
                }
                if (kisi == 14 && can14.Visible == true)
                {
                    at14.Visible = true;
                    if (a14x <= 0)//Sola çarparsa
                    {
                        sayi = 1;
                    }
                    if (a14x >= 620)//Sağa çarparsa
                    {
                        sayi = 2;
                    }
                    if (sayi == 0)
                        at14.Location = new Point(a14x + isaret, a14y + 10);

                    if (sayi == 1)
                        at14.Location = new Point(a14x + 2, a14y + 10);

                    if (sayi == 2)
                        at14.Location = new Point(a14x - 2, a14y + 10);

                    if (at14.Bottom >= gemiresmi.Top && at14.Left >= gemiresmi.Left && at14.Right <= gemiresmi.Right)//Vurulma
                    {
                        if (can == 3 || can == 2 || can == 1)
                        {
                            at14.Visible = false;
                            c14x = can14.Location.X;
                            c14y = can14.Location.Y;
                            at14.Location = new Point(c14x, c14y);
                            cancubuk.Value -= 30;
                            can--;
                            atlar.Stop();
                        }
                        if (can == 0)
                        {
                            gemiresmi.Visible = false;
                            patlama.Visible = true;
                            at14.Location = new Point(c14x, c14y);
                            at14.Visible = false;
                            bitme();
                            atlar.Stop();
                        }
                    }
                }
                if (kisi == 15 && can15.Visible == true)
                {
                    at15.Visible = true;
                    if (a15x <= 0)//Sola çarparsa
                    {
                        sayi = 1;
                    }
                    if (a15x >= 620)//Sağa çarparsa
                    {
                        sayi = 5;
                    }
                    if (sayi == 0)
                        at15.Location = new Point(a15x + isaret, a15y + 10);

                    if (sayi == 1)
                        at15.Location = new Point(a15x + 5, a15y + 10);

                    if (sayi == 2)
                        at15.Location = new Point(a15x - 5, a15y + 10);

                    if (at15.Bottom >= gemiresmi.Top && at15.Left >= gemiresmi.Left && at15.Right <= gemiresmi.Right)//Vurulma
                    {
                        if (can == 3 || can == 2 || can == 1)
                        {
                            at15.Visible = false;
                            c15x = can15.Location.X;
                            c15y = can15.Location.Y;
                            at15.Location = new Point(c15x, c15y);
                            cancubuk.Value -= 30;
                            can--;
                            atlar.Stop();
                        }
                        if (can == 0)
                        {
                            gemiresmi.Visible = false;
                            patlama.Visible = true;
                            at15.Location = new Point(c15x, c15y);
                            at15.Visible = false;
                            bitme();
                            atlar.Stop();
                        }
                    }
                }
                if (kisi == 16 && can16.Visible == true)
                {
                    at16.Visible = true;
                    if (a16x <= 0)//Sola çarparsa
                    {
                        sayi = 1;
                    }
                    if (a16x >= 620)//Sağa çarparsa
                    {
                        sayi = 2;
                    }
                    if (sayi == 0)
                        at16.Location = new Point(a16x + isaret, a16y + 10);

                    if (sayi == 1)
                        at16.Location = new Point(a16x + 2, a16y + 10);

                    if (sayi == 2)
                        at16.Location = new Point(a16x - 2, a16y + 10);

                    if (at16.Bottom >= gemiresmi.Top && at16.Left >= gemiresmi.Left && at16.Right <= gemiresmi.Right)//Vurulma
                    {
                        if (can == 3 || can == 2 || can == 1)
                        {
                            at16.Visible = false;
                            c16x = can16.Location.X;
                            c16y = can16.Location.Y;
                            at16.Location = new Point(c16x, c16y);
                            cancubuk.Value -= 30;
                            can--;
                            atlar.Stop();
                        }
                        if (can == 0)
                        {
                            gemiresmi.Visible = false;
                            patlama.Visible = true;
                            at16.Location = new Point(c16x, c16y);
                            at16.Visible = false;
                            bitme();
                            atlar.Stop();
                        }
                    }
                }
                if (kisi == 17 && can17.Visible == true)
                {
                    at17.Visible = true;
                    if (a17x <= 0)//Sola çarparsa
                    {
                        sayi = 1;
                    }
                    if (a17x >= 620)//Sağa çarparsa
                    {
                        sayi = 2;
                    }
                    if (sayi == 0)
                        at17.Location = new Point(a17x + isaret, a17y + 10);

                    if (sayi == 1)
                        at17.Location = new Point(a17x + 2, a17y + 10);

                    if (sayi == 2)
                        at17.Location = new Point(a17x - 2, a17y + 10);

                    if (at17.Bottom >= gemiresmi.Top && at17.Left >= gemiresmi.Left && at17.Right <= gemiresmi.Right)//Vurulma
                    {
                        if (can == 3 || can == 2 || can == 1)
                        {
                            at17.Visible = false;
                            c17x = can17.Location.X;
                            c17y = can17.Location.Y;
                            at17.Location = new Point(c17x, c17y);
                            cancubuk.Value -= 30;
                            can--;
                            atlar.Stop();
                        }
                        if (can == 0)
                        {
                            gemiresmi.Visible = false;
                            patlama.Visible = true;
                            at17.Location = new Point(c17x, c17y);
                            at17.Visible = false;
                            bitme();
                            atlar.Stop();
                        }
                    }
                }
                if (kisi == 18 && can18.Visible == true)
                {
                    at18.Visible = true;
                    if (a18x <= 0)//Sola çarparsa
                    {
                        sayi = 1;
                    }
                    if (a18x >= 620)//Sağa çarparsa
                    {
                        sayi = 2;
                    }
                    if (sayi == 0)
                        at18.Location = new Point(a18x + isaret, a18y + 10);

                    if (sayi == 1)
                        at18.Location = new Point(a18x + 2, a18y + 10);

                    if (sayi == 2)
                        at18.Location = new Point(a18x - 2, a18y + 10);

                    if (at18.Bottom >= gemiresmi.Top && at18.Left >= gemiresmi.Left && at18.Right <= gemiresmi.Right)//Vurulma
                    {
                        if (can == 3 || can == 2 || can == 1)
                        {
                            at18.Visible = false;
                            c18x = can18.Location.X;
                            c18y = can18.Location.Y;
                            at18.Location = new Point(c18x, c18y);
                            cancubuk.Value -= 30;
                            can--;
                            atlar.Stop();
                        }
                        if (can == 0)
                        {
                            gemiresmi.Visible = false;
                            patlama.Visible = true;
                            at18.Location = new Point(c18x, c18y);
                            at18.Visible = false;
                            bitme();
                            atlar.Stop();
                        }
                    }
                }
            }
        

        
        void bitme()//Yenildiğinde olacaklar
        {
            can1.Visible = false;
            can2.Visible = false;
            can3.Visible = false;
            can4.Visible = false;
            can5.Visible = false;
            can6.Visible = false;
            can7.Visible = false;
            can8.Visible = false;
            can9.Visible = false;
            can10.Visible = false;
            can11.Visible = false;
            can12.Visible = false;
            can13.Visible = false;
            can14.Visible = false;
            can15.Visible = false;
            can16.Visible = false;
            can17.Visible = false;
            can18.Visible = false;
            gameover.Visible = true;
            canlarsaga.Stop();
            canlarsola.Stop();
            zamansayaci.Stop();
            missileattack.Stop();
            saga.Stop();
            sola.Stop();
            button1.Visible = true;
            button2.Visible = true;
            atlar.Stop();
            saga.Enabled = false;
            sola.Enabled = false;
            missileattack.Enabled = false;
        }

        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Uzaylı Avı.accdb");

        void baglan()
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
        }

        void kayitekleme()
        {
            baglan();

            /*if(textBox1.Text==" ")
                textBox1.Text="Oyuncu";

            OleDbDataReader okuad = new OleDbDataReader();
            OleDbDataReader okuskor = new OleDbDataReader();
            OleDbCommand com = new OleDbCommand("SELECT Oyuncu_Adı FROM skor", conn);
             OleDbCommand coms = new OleDbCommand("SELECT OYüksek_Skor FROM skor", conn);
            okuad = com.ExecuteReader();
            okuskor=coms.ExecuteReader();
            string eskiskor = okuskor[0];

            if (textBox1.Text != oku[0])*/
            {
                OleDbCommand kom = new OleDbCommand("INSERT INTO skor (Oyuncu_Adı,Yüksek_Skor) VALUES ('" + Form2.ad + "','" + puanl.Text + "')", conn);
                kom.ExecuteNonQuery();
                conn.Close();
            }
            /* else if(frm1.puan > okuskor[0])
             {
                 DataTable dt = new DataTable();
                 OleDbDataAdapter ad = new OleDbDataAdapter("UPDATE skor SET Yüksek_Skor='" + frm1.puan + "' Where Oyuncu_Adı='" + textBox1.Text + "'", conn);
                
             }*/
        }
    }
}

    

