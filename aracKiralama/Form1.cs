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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace aracKiralama
{
    public partial class Form1 : MaterialForm
    {
        string kullanicimSession = "";

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
            if (Veritabanı.BaglantiDurum())
            {
                MessageBox.Show("Bağlantı kuruldu.");
            }
            aracPanel.Hide();
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
            if (kullanicimSession != "" && mesajTxtBox.Text!="")
            {
               
                string connectionString = Veritabanı.sqlcon;
                string mesaj = mesajTxtBox.Text;
                string gonderen = kullanicimSession;
                DateTime msjTarih = DateTime.Now;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        string query = "INSERT INTO tbl_mesaj (mesaj, gonderen, msjTarih) VALUES (@mesaj, @gonderen, @msjTarih)";
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@mesaj", mesaj);
                            command.Parameters.AddWithValue("@gonderen", gonderen);
                            command.Parameters.AddWithValue("@msjTarih", msjTarih);
                            command.ExecuteNonQuery();
                        }
                        MessageBox.Show("Mesajınız iletildi, değerli fikirleriniz için teşekkürler!");
                        mesajTxtBox.Text = "Mesajınız...";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata oluştu: " + ex.Message);
                    }
                }
            }
            else if(kullanicimSession=="")
            {
                MessageBox.Show("Mesaj gönderebilmek için giriş yapmanız gerekir.");
            }
            else
            {
                MessageBox.Show("Mesaj kutusu boş olmamalı.");
            }
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            if(usernameTxt.Text=="Admin"&& passwordTxtBox.Text == "Password")
            {
                Admin a = new Admin();
                Form1 b = new Form1();
                a.Show();
                b.Close();
            }
            else if (Veritabanı.LoginKontrol(usernameTxt.Text, passwordTxtBox.Text))
            {
                MessageBox.Show("Giriş başarılı.");
                kullanicimSession=usernameTxt.Text;
            }
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

        private void renokiralaBtn_Click(object sender, EventArgs e)
        {
            if (materialComboBox1.DroppedDown == false)
            {
                materialComboBox1.DroppedDown = true;
            }

            foreach (var item in materialComboBox1.Items)
            {
                if (item.ToString() == "Renault")
                {
                    materialComboBox1.SelectedItem = item;
                    break;
                }
            }
            if (materialComboBox2.DroppedDown == false)
            {
                materialComboBox2.DroppedDown = true;
            }

            foreach (var item in materialComboBox2.Items)
            {
                if (item.ToString() == "SYMBOL")
                {
                    materialComboBox2.SelectedItem = item;
                    break;
                }
            }

            if (materialComboBox3.DroppedDown == false)
            {
                materialComboBox3.DroppedDown = true;
            }

            foreach (var item in materialComboBox3.Items)
            {
                if (item.ToString() == "2021")
                {
                    materialComboBox3.SelectedItem = item;
                    break;
                }
            }
            materialTabControl1.SelectedTab = tabPage3;
        }


        private void clioKiralaBtn_Click_1(object sender, EventArgs e)
        {
            if (materialComboBox1.DroppedDown == false)
            {
                materialComboBox1.DroppedDown = true;
            }

            foreach (var item in materialComboBox1.Items)
            {
                if (item.ToString() == "Renault")
                {
                    materialComboBox1.SelectedItem = item;
                    break;
                }
            }
            if (materialComboBox2.DroppedDown == false)
            {
                materialComboBox2.DroppedDown = true;
            }

            foreach (var item in materialComboBox2.Items)
            {
                if (item.ToString() == "CLIO")
                {
                    materialComboBox2.SelectedItem = item;
                    break;
                }
            }

            if (materialComboBox3.DroppedDown == false)
            {
                materialComboBox3.DroppedDown = true;
            }

            foreach (var item in materialComboBox3.Items)
            {
                if (item.ToString() == "2022")
                {
                    materialComboBox3.SelectedItem = item;
                    break;
                }
            }
            materialTabControl1.SelectedTab = tabPage3;
        }

        private void materialButton3_Click(object sender, EventArgs e)
        {
            if (materialComboBox1.DroppedDown == false)
            {
                materialComboBox1.DroppedDown = true;
            }

            foreach (var item in materialComboBox1.Items)
            {
                if (item.ToString() == "BMW")
                {
                    materialComboBox1.SelectedItem = item;
                    break;
                }
            }
            if (materialComboBox2.DroppedDown == false)
            {
                materialComboBox2.DroppedDown = true;
            }

            foreach (var item in materialComboBox2.Items)
            {
                if (item.ToString() == "3.20D")
                {
                    materialComboBox2.SelectedItem = item;
                    break;
                }
            }

            if (materialComboBox3.DroppedDown == false)
            {
                materialComboBox3.DroppedDown = true;
            }

            foreach (var item in materialComboBox3.Items)
            {
                if (item.ToString() == "2012")
                {
                    materialComboBox3.SelectedItem = item;
                    break;
                }
            }
            materialTabControl1.SelectedTab = tabPage3;
        }

        private void materialButton4_Click(object sender, EventArgs e)
        {
            if (materialComboBox1.DroppedDown == false)
            {
                materialComboBox1.DroppedDown = true;
            }

            foreach (var item in materialComboBox1.Items)
            {
                if (item.ToString() == "Maserati")
                {
                    materialComboBox1.SelectedItem = item;
                    break;
                }
            }
            if (materialComboBox2.DroppedDown == false)
            {
                materialComboBox2.DroppedDown = true;
            }

            foreach (var item in materialComboBox2.Items)
            {
                if (item.ToString() == "Granturismo")
                {
                    materialComboBox2.SelectedItem = item;
                    break;
                }
            }

            if (materialComboBox3.DroppedDown == false)
            {
                materialComboBox3.DroppedDown = true;
            }

            foreach (var item in materialComboBox3.Items)
            {
                if (item.ToString() == "2008")
                {
                    materialComboBox3.SelectedItem = item;
                    break;
                }
            }
            materialTabControl1.SelectedTab = tabPage3;
        }

        private void nextPage_Click(object sender, EventArgs e)
        {
            aracPanel.Show();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            aracPanel.Hide();
        }

        private void kayitBtn_Click(object sender, EventArgs e)
        {
            kullaniciEkle a = new kullaniciEkle();
            a.Show();
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {

        }
    }
}
    

