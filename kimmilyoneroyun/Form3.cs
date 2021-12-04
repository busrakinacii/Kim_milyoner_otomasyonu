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

namespace oyun
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-PSSN67O\\BUSRA_KINACI;Initial Catalog=milyoner;Integrated Security=True");
        private void verilerigöster(string veriler)
        {
            SqlDataAdapter da = new SqlDataAdapter(veriler, baglan);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilialan = dataGridView1.SelectedCells[0].RowIndex;
            string id = dataGridView1.Rows[secilialan].Cells[0].Value.ToString();
            string soru = dataGridView1.Rows[secilialan].Cells[1].Value.ToString();
            string a = dataGridView1.Rows[secilialan].Cells[2].Value.ToString();
            string b = dataGridView1.Rows[secilialan].Cells[3].Value.ToString();
            string c = dataGridView1.Rows[secilialan].Cells[4].Value.ToString();
            string d = dataGridView1.Rows[secilialan].Cells[5].Value.ToString();
            string cevap = dataGridView1.Rows[secilialan].Cells[6].Value.ToString();

            Txt_id.Text = id;
            Txt_soru.Text = soru;
            Txt_a.Text = a;
            Txt_b.Text = b;
            Txt_c.Text = c;
            Txt_d.Text = d;
            Txt_cevap.Text = cevap;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("Select * from milyonersite where soru like'%" + Txt_ara.Text + "%'", baglan);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglan.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("Delete from milyonersite where id=@idi", baglan);
            komut.Parameters.AddWithValue("@idi", Txt_sil.Text);
            komut.ExecuteNonQuery();
            verilerigöster("select * from milyonersite");
            baglan.Close();
            Txt_soru.Clear();
            Txt_a.Clear();
            Txt_b.Clear();
            Txt_c.Clear();
            Txt_d.Clear();
            Txt_cevap.Clear();
            Txt_sil.Clear();
        }

        private void Btn_göster_Click(object sender, EventArgs e)
        {
            verilerigöster("Select * from milyonersite");
        }

        private void Btn_ekle_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("insert into milyonersite(id,soru,a,b,c,d,cevap) values (@idi,@soruu,@ass,@bss,@css,@dss,@cevapi)", baglan);
            komut.Parameters.AddWithValue("@idi", Txt_id.Text);
            komut.Parameters.AddWithValue("@soruu", Txt_soru.Text);
            komut.Parameters.AddWithValue("@ass", Txt_a.Text);
            komut.Parameters.AddWithValue("@bss", Txt_b.Text);
            komut.Parameters.AddWithValue("@css", Txt_c.Text);
            komut.Parameters.AddWithValue("@dss", Txt_d.Text);
            komut.Parameters.AddWithValue("@cevapi", Txt_cevap.Text);
            komut.ExecuteNonQuery();
            verilerigöster("select * from milyonersite");
            baglan.Close();


            Txt_id.Clear();
            Txt_soru.Clear();
            Txt_a.Clear();
            Txt_b.Clear();
            Txt_c.Clear();
            Txt_d.Clear();
            Txt_cevap.Clear();
            Txt_id.Focus();
        }

        private void Btn_güncelle_Click(object sender, EventArgs e)
        {
            
            baglan.Open();
            SqlCommand komut = new SqlCommand("update milyonersite set id='" + Txt_id.Text + "',a='" + Txt_a.Text + "',b='" + Txt_b.Text + "',c='" + Txt_c.Text + "',d='" + Txt_d.Text + "',cevap='" + Txt_cevap.Text + "'where soru='" + Txt_soru.Text + " '", baglan);
            komut.ExecuteNonQuery();
            verilerigöster("select * from milyonersite");
            baglan.Close();

        }

        private void Btn_dön_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }

    }
}
