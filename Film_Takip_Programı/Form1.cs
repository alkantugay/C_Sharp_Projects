/*
 * OleDb Delete işlemine izin vermiyor. Sadece düzenleme ve ekleme yapabilirsin.
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Film_Listem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OleDbConnection connection = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\alkan\Desktop\C#\FilmListem\Film_Listesi.xls;Extended Properties ='Excel 8.0;HDR=YES'");   

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_ShowMovie_Click(object sender, EventArgs e)
        {
            connection.Open();

            OleDbDataAdapter da = new OleDbDataAdapter("select * from [movieList$]", connection);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;

            connection.Close();
        }

        private void btn_AddMovie_Click(object sender, EventArgs e)
        {
            connection.Open();

            OleDbCommand cmd = new OleDbCommand("insert into [movieList$] values (@p1,@p2,@p3,@p4,@p5,@p6)", connection);
            cmd.Parameters.AddWithValue("@p1", textBox1.Text);
            cmd.Parameters.AddWithValue("@p2", textBox2.Text);
            cmd.Parameters.AddWithValue("@p3", textBox3.Text);
            cmd.Parameters.AddWithValue("@p4", textBox4.Text);
            cmd.Parameters.AddWithValue("@p5", textBox5.Text);
            cmd.Parameters.AddWithValue("@p6", richTextBox1.Text);

            cmd.ExecuteNonQuery();
            connection.Close();
                    
            MessageBox.Show("Kaydedildi!", "Tamamlandı", MessageBoxButtons.OK, MessageBoxIcon.Information);

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            richTextBox1.Clear();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Datagridde herhangi bir hücreye tıkladığımızda o hücrenin bulunduğu satırdaki tüm değerleri chosen_area ya eeşitledi
            int chosen_area = dataGridView1.SelectedCells[0].RowIndex; 
            string name = dataGridView1.Rows[chosen_area].Cells[0].Value.ToString();  // seçilen hücrenin 0. indeksini name değişkenine atadı
            string date = dataGridView1.Rows[chosen_area].Cells[1].Value.ToString();
            string type = dataGridView1.Rows[chosen_area].Cells[2].Value.ToString();
            string imdb = dataGridView1.Rows[chosen_area].Cells[3].Value.ToString();
            string my_r = dataGridView1.Rows[chosen_area].Cells[4].Value.ToString();
            string description = dataGridView1.Rows[chosen_area].Cells[5].Value.ToString();

            textBox1.Text = name;
            textBox2.Text = date;
            textBox3.Text = type;
            textBox4.Text = imdb;
            textBox5.Text = my_r;
            richTextBox1.Text = description;

        }

        private void btn_FindMovie_Click(object sender, EventArgs e)
        {
            connection.Open();

            // ismine göre filmi çekip datagride yazdırıyoruz. Kitap ismini de bir değişkene bağlamak yerine direkt olarak Texbox1 yani movie name kısmından alıyoruz
            //Burada data adapter kullanmamızın sebebi da.fill komutu ile datatable doldurup, datagride yazdırabilmek
            //Ek olarak oledbcommand kullanmadan aslında içerideki komutu direkt oledbadapter içine de yazarak işlemimizi gerçekleştirebiliriz
            OleDbCommand cmd = new OleDbCommand("select * from [movieList$] where Movie_Name like '%" + textBox1.Text + "%'", connection);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;

            connection.Close();
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            richTextBox1.Clear();
        }

        private void btn_EditMovie_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                
                OleDbCommand cmd = new OleDbCommand("update [movieList$] set  Type ='" + textBox3.Text + 
                    "', Imdb='" + textBox4.Text + "', my_R='" + textBox5.Text + "',Descriptions='" + richTextBox1.Text +
                    "' where Movie_Name='" + textBox1.Text + "'", connection);
               
                /*
                OleDbCommand cmd = new OleDbCommand("update [movieList$] set Type=@p3, Imdb=@p4, my_R=@p5, Descriptions=@p6 where Movie_Name=@p1",connection);
                cmd.Parameters.AddWithValue("@p1", textBox1.Text);
                //cmd.Parameters.AddWithValue("@p2", textBox2.Text);
                cmd.Parameters.AddWithValue("@p3", textBox3.Text);
                cmd.Parameters.AddWithValue("@p4", textBox4.Text);
                cmd.Parameters.AddWithValue("@p5", textBox5.Text);
                cmd.Parameters.AddWithValue("@p6", richTextBox1.Text);
                */

                cmd.ExecuteNonQuery();
                connection.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

      
    }
}
