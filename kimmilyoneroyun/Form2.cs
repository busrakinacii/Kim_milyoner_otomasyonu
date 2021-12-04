using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Drawing2D;

namespace oyun
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        int renk = 0;
        int süre = 30;
        int odultutari = 0;
        int odulu = 0;
        int cevap_hak = 1;
        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-PSSN67O\\BUSRA_KINACI;Initial Catalog=milyoner;Integrated Security=True;");

        private void Btn_tmm_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 1000;
            label21.Text = süre.ToString();
       
            toplar();
            yukle();
            renk++;
        }
        private void yukle()
        {

            baglan.Open();
            SqlCommand komut = new SqlCommand("select * from milyonersite order by NEWID()", baglan);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                button2.Text = (oku["a"].ToString());
                button3.Text = (oku["b"].ToString());
                button4.Text = (oku["c"].ToString());
                button5.Text = (oku["d"].ToString());
                button1.Text = (oku["soru"].ToString());
                label22.Text = (oku["cevap"].ToString());
            }
            baglan.Close();


            if (odulbirmilyon.BackColor == Color.Red)
            {
                MessageBox.Show("1.000.000TL KAZANDINIZ..Oyun Kapatılıyor--", "Tebrikler");
                this.Close();
            }
        }
            private void deger()
        {
            switch (renk)
            {
                case 1: odulbesyuz.BackColor = Color.Red; break;
                case 2: odulbin.BackColor = Color.Red; break;
                case 3: odulbinbesyuz.BackColor = Color.Red; break;
                case 4: odulucbin.BackColor = Color.Red; break;
                case 5: odulbesbin.BackColor = Color.Red; break;
                case 6: odulyetmisbes.BackColor = Color.Red; break;
                case 7: odulonbesbin.BackColor = Color.Red; MessageBox.Show("2x jokeri kazandınız."); pictureBox2.Visible = true; break;
                case 8: odulotuzbin.BackColor = Color.Red; break;
                case 9: odulaltmısbin.BackColor = Color.Red; break;
                case 10: odulyuzyirmibes.BackColor = Color.Red; break;
                case 11: odulikiyuzelli.BackColor = Color.Red; break;
                case 12: odulbesyuzbin.BackColor = Color.Red; break;
                case 13: odulbirmilyon.BackColor = Color.Red; break;

            }
        }
        private void odul()
        {
            switch (odultutari)
            {
                case 1: odulu = 500; break;
                case 2: odulu = 0; odulu = 500; break;
                case 3: odulu = 0; odulu = 1000; break;
                case 4: odulu = 0; odulu = 1500; break;
                case 5: odulu = 0; odulu = 3000; break;
                case 6: odulu = 0; odulu = 5000; break;
                case 7: odulu = 0; odulu = 7500; break;
                case 8: odulu = 0; odulu = 15000; break;
                case 9: odulu = 0; odulu = 30000; break;
                case 10: odulu = 0; odulu = 60000; break;
                case 11: odulu = 0; odulu = 125000; break;
                case 12: odulu = 0; odulu = 250000; break;
                case 13: odulu = 0; odulu = 500000; break;
                case 14: odulu = 0; odulu = 1000000; break;
            }
        }
        private void toplar()
        {
            switch (süre)
            {
                case 1: pictureBox37.BackColor = Color.Transparent; break;
                case 2: pictureBox36.BackColor = Color.Transparent; break;
                case 3: pictureBox35.BackColor = Color.Transparent; break;
                case 4: pictureBox34.BackColor = Color.Transparent; break;
                case 5: pictureBox33.BackColor = Color.Transparent; break;
                case 6: pictureBox32.BackColor = Color.Transparent; break;
                case 7: pictureBox31.BackColor = Color.Transparent; break;
                case 8: pictureBox30.BackColor = Color.Transparent; break;
                case 9: pictureBox29.BackColor = Color.Transparent; break;
                case 10: pictureBox28.BackColor = Color.Transparent; break;
                case 11: pictureBox27.BackColor = Color.Transparent; break;
                case 12: pictureBox26.BackColor = Color.Transparent; break;
                case 13: pictureBox25.BackColor = Color.Transparent; break;
                case 14: pictureBox24.BackColor = Color.Transparent; break;
                case 15: pictureBox23.BackColor = Color.Transparent; break;
                case 16: pictureBox22.BackColor = Color.Transparent; break;
                case 17: pictureBox21.BackColor = Color.Transparent; break;
                case 18: pictureBox20.BackColor = Color.Transparent; break;
                case 19: pictureBox19.BackColor = Color.Transparent; break;
                case 20: pictureBox18.BackColor = Color.Transparent; break;
                case 21: pictureBox17.BackColor = Color.Transparent; break;
                case 22: pictureBox16.BackColor = Color.Transparent; break;
                case 23: pictureBox15.BackColor = Color.Transparent; break;
                case 24: pictureBox14.BackColor = Color.Transparent; break;
                case 25: pictureBox13.BackColor = Color.Transparent; break;
                case 26: pictureBox12.BackColor = Color.Transparent; break;
                case 27: pictureBox11.BackColor = Color.Transparent; break;
                case 28: pictureBox10.BackColor = Color.Transparent; break;
                case 29: pictureBox9.BackColor = Color.Transparent; break;
                case 30: pictureBox8.BackColor = Color.Transparent; break;


            }
        }
        private GraphicsPath sekli_ciz(Size size)
        {
            GraphicsPath gp = new GraphicsPath();
            gp.AddRectangle(new Rectangle(size.Width / 8, 0, size.Width / 8 * 6, size.Height));
            Point[] noktalar = new Point[3];
            noktalar[0] = new Point(0, size.Height / 2);
            noktalar[1] = new Point(size.Width / 8, 0);
            noktalar[2] = new Point(size.Width / 8, size.Height);
            Point[] noktalar2 = new Point[3];
            noktalar2[0] = new Point(size.Width / 8 * 7, 0);
            noktalar2[1] = new Point(size.Width, size.Height / 2);
            noktalar2[2] = new Point(size.Width / 8 * 7, size.Height);
            gp.AddPolygon(noktalar);
            gp.AddPolygon(noktalar2);
            return gp;
        }
        private GraphicsPath yuvarla()
        {
            GraphicsPath gp = new GraphicsPath();
            gp.AddEllipse(new Rectangle(Point.Empty, pictureBox8.Size));
            return gp;
        }
        private void gerigetir()
        {
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            pictureBox37.Visible = true;
            pictureBox37.BackColor = Color.Red;
            pictureBox36.Visible = true;
            pictureBox36.BackColor = Color.Red;
            pictureBox35.Visible = true;
            pictureBox35.BackColor = Color.Red;
            pictureBox34.Visible = true;
            pictureBox34.BackColor = Color.Red;
            pictureBox33.Visible = true;
            pictureBox33.BackColor = Color.Red;
            pictureBox32.Visible = true;
            pictureBox32.BackColor = Color.Red;
            pictureBox31.Visible = true;
            pictureBox31.BackColor = Color.Red;
            pictureBox30.Visible = true;
            pictureBox30.BackColor = Color.Red;
            pictureBox29.Visible = true;
            pictureBox29.BackColor = Color.Red;
            pictureBox28.Visible = true;
            pictureBox28.BackColor = Color.Red;
            pictureBox27.Visible = true;
            pictureBox27.BackColor = Color.Yellow;
            pictureBox26.Visible = true;
            pictureBox26.BackColor = Color.Yellow;
            pictureBox25.Visible = true;
            pictureBox25.BackColor = Color.Yellow;
            pictureBox24.Visible = true;
            pictureBox24.BackColor = Color.Yellow;
            pictureBox23.Visible = true;
            pictureBox23.BackColor = Color.Yellow;
            pictureBox22.Visible = true;
            pictureBox22.BackColor = Color.Yellow;
            pictureBox21.Visible = true;
            pictureBox21.BackColor = Color.Yellow;
            pictureBox20.Visible = true;
            pictureBox20.BackColor = Color.Yellow;
            pictureBox19.Visible = true;
            pictureBox19.BackColor = Color.Yellow;
            pictureBox18.Visible = true;
            pictureBox18.BackColor = Color.Yellow;
            pictureBox17.Visible = true;
            pictureBox17.BackColor = Color.Lime;
            pictureBox16.Visible = true;
            pictureBox16.BackColor = Color.Lime;
            pictureBox15.Visible = true;
            pictureBox15.BackColor = Color.Lime;
            pictureBox14.Visible = true;
            pictureBox14.BackColor = Color.Lime;
            pictureBox13.Visible = true;
            pictureBox13.BackColor = Color.Lime;
            pictureBox12.Visible = true;
            pictureBox12.BackColor = Color.Lime;
            pictureBox11.Visible = true;
            pictureBox11.BackColor = Color.Lime;
            pictureBox10.Visible = true;
            pictureBox10.BackColor = Color.Lime;
            pictureBox9.Visible = true;
            pictureBox9.BackColor = Color.Lime;
            pictureBox8.Visible = true;
            pictureBox8.BackColor = Color.Lime;

        }

        private void button2_Paint(object sender, PaintEventArgs e)
        {
            button2.Region = new Region(sekli_ciz(button2.Size));
            button3.Region = new Region(sekli_ciz(button3.Size));
            button4.Region = new Region(sekli_ciz(button4.Size));
            button5.Region = new Region(sekli_ciz(button5.Size));
            button1.Region = new Region(sekli_ciz(button1.Size));
            pictureBox8.Region = new Region(yuvarla());
            pictureBox9.Region = new Region(yuvarla());
            pictureBox10.Region = new Region(yuvarla());
            pictureBox11.Region = new Region(yuvarla());
            pictureBox12.Region = new Region(yuvarla());
            pictureBox13.Region = new Region(yuvarla());
            pictureBox14.Region = new Region(yuvarla());
            pictureBox15.Region = new Region(yuvarla());
            pictureBox16.Region = new Region(yuvarla());
            pictureBox17.Region = new Region(yuvarla());
            pictureBox18.Region = new Region(yuvarla());
            pictureBox19.Region = new Region(yuvarla());
            pictureBox20.Region = new Region(yuvarla());
            pictureBox21.Region = new Region(yuvarla());
            pictureBox22.Region = new Region(yuvarla());
            pictureBox23.Region = new Region(yuvarla());
            pictureBox24.Region = new Region(yuvarla());
            pictureBox25.Region = new Region(yuvarla());
            pictureBox26.Region = new Region(yuvarla());
            pictureBox27.Region = new Region(yuvarla());
            pictureBox28.Region = new Region(yuvarla());
            pictureBox29.Region = new Region(yuvarla());
            pictureBox30.Region = new Region(yuvarla());
            pictureBox31.Region = new Region(yuvarla());
            pictureBox32.Region = new Region(yuvarla());
            pictureBox33.Region = new Region(yuvarla());
            pictureBox34.Region = new Region(yuvarla());
            pictureBox35.Region = new Region(yuvarla());
            pictureBox36.Region = new Region(yuvarla());
            pictureBox37.Region = new Region(yuvarla());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            süre--;
            toplar();
            label21.Text = süre.ToString();
            if (süre == 0)
            {
                timer1.Stop();
                MessageBox.Show("süreniz doldu,elendiniz.");
                MessageBox.Show("Kazandığınız ödül=" + odulu);
                this.Close();

            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int rastgele;
            string tel = "";

            rastgele = r .Next(1, 5);
            if (rastgele == 1) tel = button2.Text; 

           if (rastgele == 2) tel = button3.Text;

           if (rastgele == 3) tel = button4.Text;

           if (rastgele == 4) tel = button5.Text;

            MessageBox.Show("Kişinin vermiş olduğu cevap -->> "+ tel +" <<-- seçeneğidir.", "Telefon Cevabı", MessageBoxButtons.OK, MessageBoxIcon.Information);

            pictureBox3.Visible = false;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
           if(button2.Text==label22.Text)
            {
                button3.Visible = false;
                button5.Visible = false;
            }
           if(button3.Text==label22.Text)
            {
                button4.Visible = false;
                button2.Visible = false;
            }
           if(button4.Text==label22.Text)
            {
                button2.Visible = false;
                button5.Visible = false;
            }
           if(button5.Text==label22.Text)
            {
                button4.Visible = false;
                button3.Visible = false;
            }
            pictureBox4.Visible = false;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            Random rnd = new Random();
            if (label22.Text == button2.Text)
            {
                pictureBox40.Width = rnd.Next(35, 80);
                pictureBox41.Width = rnd.Next(10, 40);
                pictureBox42.Width = rnd.Next(10, 50);
                pictureBox43.Width = rnd.Next(5, 40);

            }
            if (label22.Text == button3.Text)
            {
                pictureBox40.Width = rnd.Next(10, 40);
                pictureBox41.Width = rnd.Next(35, 80);
                pictureBox42.Width = rnd.Next(10, 50);
                pictureBox43.Width = rnd.Next(5, 40);

            }
            if (label22.Text == button4.Text)
            {
                pictureBox40.Width = rnd.Next(10, 40);
                pictureBox41.Width = rnd.Next(10, 30);
                pictureBox42.Width = rnd.Next(35, 80);
                pictureBox43.Width = rnd.Next(5, 40);

            }
            if (label22.Text == button5.Text)
            {
                pictureBox40.Width = rnd.Next(10, 40);
                pictureBox41.Width = rnd.Next(10, 30);
                pictureBox42.Width = rnd.Next(15, 30);
                pictureBox43.Width = rnd.Next(35, 80);

            }
            pictureBox5.Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            cevap_hak = 2;

            pictureBox2.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult kontrol = MessageBox.Show("Son kararınız mı?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (kontrol == DialogResult.Yes)
            {
                if (label22.Text == button2.Text)
                {
                    süre = 30;
                    toplar();
                    gerigetir();
                    odultutari++;
                    deger();
                    yukle();
                    renk++;
                    MessageBox.Show("Doğru cevap");

                }
                else
                {
                    cevap_hak--;
                    if (cevap_hak == 0)
                    {
                        odul();
                        MessageBox.Show("Yanlış cevap elendiniz oyun kapanıyor dogru cevap=" + label22.Text + "Ödülünüz=" + odulu);
                        this.Close();

                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult kontrol = MessageBox.Show("Son kararınız mı?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (kontrol == DialogResult.Yes)
            {
                if (label22.Text == button3.Text)
                {
                    süre = 30;
                    toplar();
                    gerigetir();
                    odultutari++;
                    deger();
                    yukle();
                    renk++;
                    MessageBox.Show("Doğru cevap");


                }
                else
                {
                    cevap_hak--;
                    if (cevap_hak == 0)
                    {
                        odul();
                        MessageBox.Show("Yanlış cevap elendiniz oyun kapanıyor dogru cevap=" + label22.Text + "Ödülünüz=" + odulu);
                        this.Close();


                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult kontrol = MessageBox.Show("Son kararınız mı?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (kontrol == DialogResult.Yes)
            {
                if (label22.Text == button4.Text)
                {
                    süre = 30;
                    toplar();
                    gerigetir();
                    odultutari++;
                    deger();
                    yukle();
                    renk++;
                    MessageBox.Show("Doğru cevap");


                }
                else
                {
                    cevap_hak--;
                    if (cevap_hak == 0)
                    {
                        odul();
                        MessageBox.Show("Yanlış cevap elendiniz oyun kapanıyor dogru cevap=" + label22.Text + "Ödülünüz=" + odulu);
                        this.Close();



                    }
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult kontrol = MessageBox.Show("Son kararınız mı?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (kontrol == DialogResult.Yes)
            {
                if (label22.Text == button5.Text)
                {
                    süre = 30;
                    toplar();
                    gerigetir();
                    odultutari++;
                    deger();
                    yukle();
                    renk++;
                    MessageBox.Show("Doğru cevap");


                }
                else
                {
                    cevap_hak--;
                    if (cevap_hak == 0)
                    {
                        odul();
                        MessageBox.Show("Yanlış cevap elendiniz oyun kapanıyor dogru cevap=" + label22.Text + "Ödülünüz=" + odulu);
                        this.Close();



                    }
                }
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            DialogResult kontrol = MessageBox.Show("Tekrar başlatmak ister misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (kontrol == DialogResult.Yes)
            {
                Application.Restart();

            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            DialogResult kontrol = MessageBox.Show("Emin misiniz?", "uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (kontrol == DialogResult.Yes)
            {
                MessageBox.Show("Kazandığınız Ödül=" + odulu);
                Application.Exit();
            }
        }
    }
}
