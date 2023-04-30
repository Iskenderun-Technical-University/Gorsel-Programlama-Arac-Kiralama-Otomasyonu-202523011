using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aracKiralama
{
    public partial class Admin : MaterialForm
    {
        //string connectionString = "Data Source=LAPTOP-NCDFA6OH\\SQLEXPRESS;Initial Catalog=202523011-VTDGP;Integrated Security=True";
        public Admin()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            FillDataGridView();
        }
        private void btnResimSec_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Resim Dosyası | *.jpg;*.jpeg;*.png;*.gif;*.bmp";
            dialog.Title = "Resim Seç";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                txtResimYolu.Text = dialog.FileName;
                pbResim.ImageLocation = txtResimYolu.Text;
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            /*if (txtAciklama.Text == "" || txtResimYolu.Text == "")
            {
                MessageBox.Show("Lütfen bir resim ve açıklama seçin.");
            }
            else
            {
                try
                {
                    string connectionString = "Data Source=LAPTOP-NCDFA6OH\\SQLEXPRESS;Initial Catalog=202523011-VTDGP;Integrated Security=True";
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string query = "INSERT INTO tbl_arac (image, aciklama) VALUES (@image, @aciklama)";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@image", ImageToByteArray(pbResim.Image));
                        command.Parameters.AddWithValue("@aciklama", txtAciklama.Text);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Kayıt başarıyla eklendi.");
                        connection.Close();

                        Yenile();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kayıt eklenirken bir hata oluştu: " + ex.Message);
                }
            }*/
            
                if (txtAciklama.Text == "" || txtResimYolu.Text == "")
                {
                    MessageBox.Show("Lütfen bir resim ve açıklama seçin.");
                }
                else if (pbResim.Image == null) // Check if pbResim.Image is null
                {
                    MessageBox.Show("Lütfen geçerli bir resim seçin.");
                }
                else
                {
                    try
                    {
                        string connectionString = "Data Source=LAPTOP-NCDFA6OH\\SQLEXPRESS;Initial Catalog=202523011-VTDGP;Integrated Security=True";
                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            connection.Open();
                            string query = "INSERT INTO tbl_arac (image, aciklama) VALUES (@image, @aciklama)";
                            SqlCommand command = new SqlCommand(query, connection);
                            command.Parameters.AddWithValue("@image", ImageToByteArray(pbResim.Image));
                            command.Parameters.AddWithValue("@aciklama", txtAciklama.Text);
                            command.ExecuteNonQuery();
                            MessageBox.Show("Kayıt başarıyla eklendi.");
                            connection.Close();

                            Yenile();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Kayıt eklenirken bir hata oluştu: " + ex.Message);
                    }
                }
            }
        

        private void Yenile()
        {
            try
            {
                string connectionString = "Data Source=LAPTOP-NCDFA6OH\\SQLEXPRESS;Initial Catalog=202523011-VTDGP;Integrated Security=True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM tbl_arac";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veriler yüklenirken bir hata oluştu: " + ex.Message);
            }
        }

        private byte[] ImageToByteArray(Image image)
        {
            MemoryStream memoryStream = new MemoryStream();
            image.Save(memoryStream, ImageFormat.Jpeg);
            return memoryStream.ToArray();
        }

        private void dataGridView1_CellContentDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Resim byte array şeklinde veritabanında saklandıysa
                if (row.Cells["image"].Value != DBNull.Value)
                {
                    byte[] bytes = (byte[])row.Cells["image"].Value;
                    MemoryStream ms = new MemoryStream(bytes);
                    pbResim.Image = Image.FromStream(ms);
                }

                // Resim yolunu veritabanında saklandıysa
                else if (File.Exists(row.Cells["image"].Value.ToString()))
                {
                    pbResim.Image = Image.FromFile(row.Cells["image"].Value.ToString());
                }
            }

            // DataGridView'da bir hücreye tıkladığımızda bu işlev çalışır
            if (e.RowIndex >= 0)
            {
                // DataGridView'daki seçili satırdaki verileri TextBox'lara doldurma
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                txtResimYolu.Text = row.Cells["image"].Value.ToString();
                txtAciklama.Text = row.Cells["aciklama"].Value.ToString();


            }
        }
        private void FillDataGridView()
        {
            string connectionString = "Data Source=LAPTOP-NCDFA6OH\\SQLEXPRESS;Initial Catalog=202523011-VTDGP;Integrated Security=True";
            string query = "SELECT * FROM tbl_arac";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        dataGridView1.DataSource = table;
                    }
                }
            }
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            // DataGridView'da seçili olan kaydın silinmesi
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridView1.SelectedRows[0].Index;
                int aracId = Convert.ToInt32(dataGridView1.Rows[selectedIndex].Cells["ID"].Value);

                // Bağlantı açma ve silme sorgusu çalıştırma
                using (SqlConnection con = new SqlConnection("Data Source=LAPTOP-NCDFA6OH\\SQLEXPRESS;Initial Catalog=202523011-VTDGP;Integrated Security=True"))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM tbl_arac WHERE ID=@id", con);
                    cmd.Parameters.AddWithValue("@id", aracId);

                    cmd.ExecuteNonQuery();

                    // Yenileme işlemi
                    dataGridView1.DataSource = null;
                    FillDataGridView();
                }
            }
        }
    }
}

