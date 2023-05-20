using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aracKiralama
{
    public partial class kullaniciEkle : Form
    {
        public kullaniciEkle()
        {
            InitializeComponent();
        }

        private void kullaniciKayitBtn_Click(object sender, EventArgs e)
        {
            if(parolaTxt.Text==parolaYenidenTxt.Text&&userNameTxt.Text!="") 
            {
                Veritabanı.kullaniciEkle(userNameTxt.Text, parolaTxt.Text);
                MessageBox.Show("Yeni Kullanıcı başarıyla eklendi.");
                this.Close();
            }
        }
    }
}
