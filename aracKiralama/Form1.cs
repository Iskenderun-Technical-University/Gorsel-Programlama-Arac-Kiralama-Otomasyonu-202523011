using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Animations;
using MaterialSkin.Controls;

namespace aracKiralama
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            usernameTxt.Text = "Kullanıcı Adı";
            passwordTxtBox.Text = "Parola";
            this.Select();
        }
        private void usernameTxt_Enter(object sender, EventArgs e)
        {
            if (usernameTxt.Text == "Kullanıcı Adı")
            {
                usernameTxt.Text = "";
            }
        }
        private void usernameTxt_Leave(object sender, EventArgs e)
        {
            if (usernameTxt.Text == "")
            {
                usernameTxt.Text = "Kullanıcı Adı";
            }
        }
        private void passwordTxtBox_Enter(object sender, EventArgs e)
        {
            if (passwordTxtBox.Text == "Parola")
            {
                passwordTxtBox.Text = "";
            }
        }
        private void passwordTxtBox_Leave(object sender, EventArgs e)
        {
            if (passwordTxtBox.Text == "")
            {
                passwordTxtBox.Text = "Parola";
            }
        }

        private void materialMultiLineTextBox21_Enter(object sender, EventArgs e)
        {
            if (mesajTxtBox.Text == "Mesajınız...")
            {
                mesajTxtBox.Text = "";
            }
        }
        private void materialMultiLineTextBox21_Leave(object sender, EventArgs e)
        {
            if (mesajTxtBox.Text == "")
            {
                mesajTxtBox.Text = "Mesajınız...";
            }
        }

        private void msjGonderBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mesajınız iletildi, değerli fikirleriniz için teşekkürler!");
            mesajTxtBox.Text = "Mesajınız...";
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            Admin a = new Admin();
            Form1 b = new Form1();
            a.Show();
            b.Close();
        }

        private void materialLabel7_Click(object sender, EventArgs e)
        {

        }

        private void passwordTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void usernameTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            LoadImages();
        }
        private void LoadImages()
        {
            // Öncelikle, paneli temizleyelim
            flowLayoutPanel1.Controls.Clear();

            string conn = "Data Source=LAPTOP-NCDFA6OH\\SQLEXPRESS;Initial Catalog=202523011-VTDGP;Integrated Security=True";
            ;
            using (SqlConnection connection = new SqlConnection(conn))
            {
                connection.Open();

                string query = "SELECT * FROM tbl_arac";
                SqlCommand command = new SqlCommand(query, connection);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // Resim ve açıklamayı çekiyoruz
                        byte[] imageBytes = (byte[])reader["image"];
                        string description = reader["aciklama"].ToString();

                        // Resmi MemoryStream nesnesine yüklüyoruz
                        MemoryStream stream = new MemoryStream(imageBytes);
                        PictureBox pictureBox = new PictureBox();
                        using (Image img = Image.FromStream(stream))
                        {
                            // Resmi küçültüyoruz ve boyutlarını ayarlıyoruz
                            int width = 400;
                            int height = 400;
                            if (img.Width > img.Height)
                            {
                                height = (int)(((float)img.Height / (float)img.Width) * width);
                            }
                            else
                            {
                                width = (int)(((float)img.Width / (float)img.Height) * height);
                            }

                            Image thumbnail = img.GetThumbnailImage(width, height, null, IntPtr.Zero);
                            pictureBox.Image = thumbnail;
                        }
                        pictureBox.SizeMode = PictureBoxSizeMode.Zoom;

                        // PictureBox oluşturuyoruz
                        /*PictureBox pictureBox = new PictureBox();
                        pictureBox.Image = Image.FromStream(stream);
                        pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                        pictureBox.Width = 200;
                        pictureBox.Height = 200;*/

                        // Açıklama için Label oluşturuyoruz
                        Label label = new Label();
                        label.Text = description;

                        // Yeni bir FlowLayoutPanel oluşturuyoruz
                        FlowLayoutPanel panel = new FlowLayoutPanel();
                        panel.FlowDirection = FlowDirection.TopDown;
                        panel.Controls.Add(pictureBox);
                        panel.Controls.Add(label);
                        panel.Padding = new Padding(10);

                        // Ana panelimize yeni oluşturduğumuz paneli ekliyoruz
                        flowLayoutPanel1.Controls.Add(panel);
                    }
                }
            }
        }
    }
}
