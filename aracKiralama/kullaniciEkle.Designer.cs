namespace aracKiralama
{
    partial class kullaniciEkle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.userNameTxt = new MaterialSkin.Controls.MaterialTextBox();
            this.parolaTxt = new MaterialSkin.Controls.MaterialTextBox();
            this.parolaYenidenTxt = new MaterialSkin.Controls.MaterialTextBox();
            this.kullaniciKayitBtn = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // userNameTxt
            // 
            this.userNameTxt.AnimateReadOnly = false;
            this.userNameTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userNameTxt.Depth = 0;
            this.userNameTxt.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.userNameTxt.LeadingIcon = null;
            this.userNameTxt.Location = new System.Drawing.Point(168, 44);
            this.userNameTxt.MaxLength = 50;
            this.userNameTxt.MouseState = MaterialSkin.MouseState.OUT;
            this.userNameTxt.Multiline = false;
            this.userNameTxt.Name = "userNameTxt";
            this.userNameTxt.Size = new System.Drawing.Size(174, 50);
            this.userNameTxt.TabIndex = 0;
            this.userNameTxt.Text = "";
            this.userNameTxt.TrailingIcon = null;
            // 
            // parolaTxt
            // 
            this.parolaTxt.AnimateReadOnly = false;
            this.parolaTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.parolaTxt.Depth = 0;
            this.parolaTxt.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.parolaTxt.LeadingIcon = null;
            this.parolaTxt.Location = new System.Drawing.Point(168, 150);
            this.parolaTxt.MaxLength = 50;
            this.parolaTxt.MouseState = MaterialSkin.MouseState.OUT;
            this.parolaTxt.Multiline = false;
            this.parolaTxt.Name = "parolaTxt";
            this.parolaTxt.Password = true;
            this.parolaTxt.Size = new System.Drawing.Size(174, 50);
            this.parolaTxt.TabIndex = 1;
            this.parolaTxt.Text = "";
            this.parolaTxt.TrailingIcon = null;
            // 
            // parolaYenidenTxt
            // 
            this.parolaYenidenTxt.AnimateReadOnly = false;
            this.parolaYenidenTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.parolaYenidenTxt.Depth = 0;
            this.parolaYenidenTxt.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.parolaYenidenTxt.LeadingIcon = null;
            this.parolaYenidenTxt.Location = new System.Drawing.Point(168, 251);
            this.parolaYenidenTxt.MaxLength = 50;
            this.parolaYenidenTxt.MouseState = MaterialSkin.MouseState.OUT;
            this.parolaYenidenTxt.Multiline = false;
            this.parolaYenidenTxt.Name = "parolaYenidenTxt";
            this.parolaYenidenTxt.Password = true;
            this.parolaYenidenTxt.Size = new System.Drawing.Size(174, 50);
            this.parolaYenidenTxt.TabIndex = 2;
            this.parolaYenidenTxt.Text = "";
            this.parolaYenidenTxt.TrailingIcon = null;
            // 
            // kullaniciKayitBtn
            // 
            this.kullaniciKayitBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kullaniciKayitBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.kullaniciKayitBtn.Depth = 0;
            this.kullaniciKayitBtn.HighEmphasis = true;
            this.kullaniciKayitBtn.Icon = null;
            this.kullaniciKayitBtn.Location = new System.Drawing.Point(149, 342);
            this.kullaniciKayitBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.kullaniciKayitBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.kullaniciKayitBtn.Name = "kullaniciKayitBtn";
            this.kullaniciKayitBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.kullaniciKayitBtn.Size = new System.Drawing.Size(76, 36);
            this.kullaniciKayitBtn.TabIndex = 3;
            this.kullaniciKayitBtn.Text = "Kaydet";
            this.kullaniciKayitBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.kullaniciKayitBtn.UseAccentColor = false;
            this.kullaniciKayitBtn.UseVisualStyleBackColor = true;
            this.kullaniciKayitBtn.Click += new System.EventHandler(this.kullaniciKayitBtn_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(55, 60);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(97, 19);
            this.materialLabel1.TabIndex = 4;
            this.materialLabel1.Text = "Kullanıcı Adı :";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(107, 165);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(55, 19);
            this.materialLabel2.TabIndex = 5;
            this.materialLabel2.Text = "Parola :";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(35, 268);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(127, 19);
            this.materialLabel3.TabIndex = 6;
            this.materialLabel3.Text = "Parola (Yeniden) :";
            // 
            // kullaniciEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(395, 450);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.kullaniciKayitBtn);
            this.Controls.Add(this.parolaYenidenTxt);
            this.Controls.Add(this.parolaTxt);
            this.Controls.Add(this.userNameTxt);
            this.Name = "kullaniciEkle";
            this.Text = "kullaniciEkle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox userNameTxt;
        private MaterialSkin.Controls.MaterialTextBox parolaTxt;
        private MaterialSkin.Controls.MaterialTextBox parolaYenidenTxt;
        private MaterialSkin.Controls.MaterialButton kullaniciKayitBtn;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
    }
}