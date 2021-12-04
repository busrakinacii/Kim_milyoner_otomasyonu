using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oyun
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 admin = new Form2();
            admin.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "siteadmin" && textBox2.Text == "site12345")
            {
                Form3 admin = new Form3();
                panel1.Visible = false;
                admin.Show();
                this.Hide();
                MessageBox.Show("Giriş Başarılı.");
            }
            else { MessageBox.Show("GİRİŞ YAPINIZ"); }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("C# ve sql veri tabanı ile hazırlanmıştır.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }
    }
}
