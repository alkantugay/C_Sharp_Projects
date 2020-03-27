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

namespace NotKayitSistemi
{
    public partial class FormOgretmenDetay : Form
    {
        public FormOgretmenDetay()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-6R64793\SQLEXPRESS;Initial Catalog=dbNotKayit;Integrated Security=True");
      
        private void FormOgretmenDetay_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'dbNotKayitDataSet.TBLDERS' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz. Otomatik doldurma komutu kısaca
            this.tBLDERSTableAdapter.Fill(this.dbNotKayitDataSet.TBLDERS);

        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komut = new SqlCommand("insert into TBLDERS(OGRNUMARA,OGRAD,OGRSOYAD) values(@p1,@p2,@p3)",baglanti);
            komut.Parameters.AddWithValue("@p1", txtNumara.Text);
            komut.Parameters.AddWithValue("@p2", txtAd.Text);
            komut.Parameters.AddWithValue("@p3", txtSoyad.Text);
            komut.ExecuteNonQuery();

            baglanti.Close();

            MessageBox.Show("Öğrenci Sisteme Eklendi");
           
            this.tBLDERSTableAdapter.Fill(this.dbNotKayitDataSet.TBLDERS);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double ortalama, s1, s2, s3;
            string durum;
            

            s1 = Convert.ToDouble(txtS1.Text);
            s2 = Convert.ToDouble(txtS2.Text);
            s3 = Convert.ToDouble(txtS3.Text);

            ortalama = (s1 + s2 + s3) / 3;
            lblOrtalama.Text = ortalama.ToString();

            if(ortalama >= 50 )
            {
                durum = "true";
               
            }
            else
            {
                durum = "false";
               
            }

           // lblGecen.Text = gecen.ToString();
           // lblKalan.Text = kalan.ToString();

            baglanti.Open();

            SqlCommand komut = new SqlCommand("update TBLDERS set OGRS1=@p1,OGRS2=@p2,OGRS3=@p3,ORTALAMA=@p4,DURUM=@p5 where OGRNUMARA=@p6", baglanti);

            komut.Parameters.AddWithValue("@p1",txtS1.Text);
            komut.Parameters.AddWithValue("@p2", txtS2.Text);
            komut.Parameters.AddWithValue("@p3", txtS3.Text);
            komut.Parameters.AddWithValue("@p4", decimal.Parse(lblOrtalama.Text));
            komut.Parameters.AddWithValue("@p5", durum);   //lblDurum 
            komut.Parameters.AddWithValue("@p6", txtNumara.Text);

            komut.ExecuteNonQuery();

            baglanti.Close();
            MessageBox.Show("Öğrenci Notları Güncellendi!");
            this.tBLDERSTableAdapter.Fill(this.dbNotKayitDataSet.TBLDERS);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            txtNumara.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtAd.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txtSoyad.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txtS1.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();  // datagridin satırları içerisinde seçilen satırın. hücreleri içerisinde(4. hücreye denk geliyor Sınav1), bu değeri string olarak yazdır.
            txtS2.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            txtS3.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
        }
    }
}
