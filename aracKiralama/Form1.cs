using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            if(usernameTxt.Text=="Kullanıcı Adı")
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

        private void materialLabel6_Click(object sender, EventArgs e)
        {

        }
    }
}
