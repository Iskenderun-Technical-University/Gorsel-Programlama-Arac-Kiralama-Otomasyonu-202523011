namespace aracKiralama
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.materialComboBox4 = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialComboBox3 = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialComboBox2 = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialComboBox1 = new MaterialSkin.Controls.MaterialComboBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.msjGonderBtn = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.mesajTxtBox = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.passwordTxtBox = new MaterialSkin.Controls.MaterialTextBox();
            this.usernameTxt = new MaterialSkin.Controls.MaterialTextBox();
            this.aracPicBox = new System.Windows.Forms.PictureBox();
            this.aracIsimLbl = new MaterialSkin.Controls.MaterialLabel();
            this.aracModelLbl = new MaterialSkin.Controls.MaterialLabel();
            this.aracFiyatLbl = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aracPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Controls.Add(this.tabPage3);
            this.materialTabControl1.Controls.Add(this.tabPage4);
            this.materialTabControl1.Controls.Add(this.tabPage5);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.ImageList = this.ımageList1;
            this.materialTabControl1.Location = new System.Drawing.Point(3, 88);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(817, 802);
            this.materialTabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.ImageKey = "home.png";
            this.tabPage1.Location = new System.Drawing.Point(4, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(809, 759);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ana Sayfa";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::aracKiralama.Properties.Resources.afis;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(803, 753);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.aracFiyatLbl);
            this.tabPage2.Controls.Add(this.aracModelLbl);
            this.tabPage2.Controls.Add(this.aracIsimLbl);
            this.tabPage2.Controls.Add(this.aracPicBox);
            this.tabPage2.ImageKey = "cars.png";
            this.tabPage2.Location = new System.Drawing.Point(4, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(809, 759);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Araçlarımız";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.materialLabel6);
            this.tabPage3.Controls.Add(this.pictureBox3);
            this.tabPage3.Controls.Add(this.materialComboBox4);
            this.tabPage3.Controls.Add(this.materialLabel5);
            this.tabPage3.Controls.Add(this.materialComboBox3);
            this.tabPage3.Controls.Add(this.materialLabel4);
            this.tabPage3.Controls.Add(this.materialComboBox2);
            this.tabPage3.Controls.Add(this.materialLabel3);
            this.tabPage3.Controls.Add(this.materialLabel2);
            this.tabPage3.Controls.Add(this.materialComboBox1);
            this.tabPage3.ImageKey = "pricing.png";
            this.tabPage3.Location = new System.Drawing.Point(4, 39);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(809, 759);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Fiyatlandırma";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.FontType = MaterialSkin.MaterialSkinManager.fontType.SubtleEmphasis;
            this.materialLabel6.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.materialLabel6.Location = new System.Drawing.Point(6, 421);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(391, 14);
            this.materialLabel6.TabIndex = 9;
            this.materialLabel6.Text = "7 günden daha uzun süreli kiralamalar için lütfen bizimle iletişime geçin.";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox3.Image = global::aracKiralama.Properties.Resources.logo;
            this.pictureBox3.Location = new System.Drawing.Point(3, 438);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(803, 318);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // materialComboBox4
            // 
            this.materialComboBox4.AutoResize = false;
            this.materialComboBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBox4.Depth = 0;
            this.materialComboBox4.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBox4.DropDownHeight = 174;
            this.materialComboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBox4.DropDownWidth = 121;
            this.materialComboBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialComboBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBox4.FormattingEnabled = true;
            this.materialComboBox4.IntegralHeight = false;
            this.materialComboBox4.ItemHeight = 43;
            this.materialComboBox4.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.materialComboBox4.Location = new System.Drawing.Point(365, 333);
            this.materialComboBox4.MaxDropDownItems = 4;
            this.materialComboBox4.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBox4.Name = "materialComboBox4";
            this.materialComboBox4.Size = new System.Drawing.Size(121, 49);
            this.materialComboBox4.StartIndex = 0;
            this.materialComboBox4.TabIndex = 8;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(242, 247);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(71, 19);
            this.materialLabel5.TabIndex = 7;
            this.materialLabel5.Text = "Model Yılı";
            // 
            // materialComboBox3
            // 
            this.materialComboBox3.AutoResize = false;
            this.materialComboBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBox3.Depth = 0;
            this.materialComboBox3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBox3.DropDownHeight = 174;
            this.materialComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBox3.DropDownWidth = 121;
            this.materialComboBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialComboBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBox3.FormattingEnabled = true;
            this.materialComboBox3.IntegralHeight = false;
            this.materialComboBox3.ItemHeight = 43;
            this.materialComboBox3.Location = new System.Drawing.Point(365, 243);
            this.materialComboBox3.MaxDropDownItems = 4;
            this.materialComboBox3.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBox3.Name = "materialComboBox3";
            this.materialComboBox3.Size = new System.Drawing.Size(121, 49);
            this.materialComboBox3.StartIndex = 0;
            this.materialComboBox3.TabIndex = 6;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(228, 166);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(85, 19);
            this.materialLabel4.TabIndex = 5;
            this.materialLabel4.Text = "Araç Modeli";
            // 
            // materialComboBox2
            // 
            this.materialComboBox2.AutoResize = false;
            this.materialComboBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBox2.Depth = 0;
            this.materialComboBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBox2.DropDownHeight = 174;
            this.materialComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBox2.DropDownWidth = 121;
            this.materialComboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialComboBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBox2.FormattingEnabled = true;
            this.materialComboBox2.IntegralHeight = false;
            this.materialComboBox2.ItemHeight = 43;
            this.materialComboBox2.Location = new System.Drawing.Point(365, 162);
            this.materialComboBox2.MaxDropDownItems = 4;
            this.materialComboBox2.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBox2.Name = "materialComboBox2";
            this.materialComboBox2.Size = new System.Drawing.Size(121, 49);
            this.materialComboBox2.StartIndex = 0;
            this.materialComboBox2.TabIndex = 4;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(148, 337);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(165, 19);
            this.materialLabel3.TabIndex = 3;
            this.materialLabel3.Text = "Kiralanacak Gün Sayısı";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(219, 81);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(94, 19);
            this.materialLabel2.TabIndex = 2;
            this.materialLabel2.Text = "Araç Markası";
            // 
            // materialComboBox1
            // 
            this.materialComboBox1.AutoResize = false;
            this.materialComboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBox1.Depth = 0;
            this.materialComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBox1.DropDownHeight = 174;
            this.materialComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBox1.DropDownWidth = 121;
            this.materialComboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBox1.FormattingEnabled = true;
            this.materialComboBox1.IntegralHeight = false;
            this.materialComboBox1.ItemHeight = 43;
            this.materialComboBox1.Location = new System.Drawing.Point(365, 78);
            this.materialComboBox1.MaxDropDownItems = 4;
            this.materialComboBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBox1.Name = "materialComboBox1";
            this.materialComboBox1.Size = new System.Drawing.Size(121, 49);
            this.materialComboBox1.StartIndex = 0;
            this.materialComboBox1.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.Transparent;
            this.tabPage4.Controls.Add(this.pictureBox2);
            this.tabPage4.Controls.Add(this.msjGonderBtn);
            this.tabPage4.Controls.Add(this.materialLabel1);
            this.tabPage4.Controls.Add(this.mesajTxtBox);
            this.tabPage4.ImageKey = "contactUs.png";
            this.tabPage4.Location = new System.Drawing.Point(4, 39);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(809, 759);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Bize Ulaşın!";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox2.Image = global::aracKiralama.Properties.Resources.logo;
            this.pictureBox2.Location = new System.Drawing.Point(0, 314);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(809, 445);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // msjGonderBtn
            // 
            this.msjGonderBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.msjGonderBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.msjGonderBtn.Depth = 0;
            this.msjGonderBtn.HighEmphasis = true;
            this.msjGonderBtn.Icon = null;
            this.msjGonderBtn.Location = new System.Drawing.Point(77, 253);
            this.msjGonderBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.msjGonderBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.msjGonderBtn.Name = "msjGonderBtn";
            this.msjGonderBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.msjGonderBtn.Size = new System.Drawing.Size(79, 36);
            this.msjGonderBtn.TabIndex = 2;
            this.msjGonderBtn.Text = "Gönder";
            this.msjGonderBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.msjGonderBtn.UseAccentColor = false;
            this.msjGonderBtn.UseVisualStyleBackColor = true;
            this.msjGonderBtn.Click += new System.EventHandler(this.msjGonderBtn_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(74, 54);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(80, 19);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "Bize yazın ;";
            // 
            // mesajTxtBox
            // 
            this.mesajTxtBox.AnimateReadOnly = false;
            this.mesajTxtBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mesajTxtBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.mesajTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.mesajTxtBox.Depth = 0;
            this.mesajTxtBox.HideSelection = true;
            this.mesajTxtBox.Location = new System.Drawing.Point(77, 86);
            this.mesajTxtBox.MaxLength = 32767;
            this.mesajTxtBox.MouseState = MaterialSkin.MouseState.OUT;
            this.mesajTxtBox.Name = "mesajTxtBox";
            this.mesajTxtBox.PasswordChar = '\0';
            this.mesajTxtBox.ReadOnly = false;
            this.mesajTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mesajTxtBox.SelectedText = "";
            this.mesajTxtBox.SelectionLength = 0;
            this.mesajTxtBox.SelectionStart = 0;
            this.mesajTxtBox.ShortcutsEnabled = true;
            this.mesajTxtBox.Size = new System.Drawing.Size(338, 143);
            this.mesajTxtBox.TabIndex = 0;
            this.mesajTxtBox.TabStop = false;
            this.mesajTxtBox.Text = "Mesajınız...";
            this.mesajTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.mesajTxtBox.UseSystemPasswordChar = false;
            this.mesajTxtBox.Enter += new System.EventHandler(this.materialMultiLineTextBox21_Enter);
            this.mesajTxtBox.Leave += new System.EventHandler(this.materialMultiLineTextBox21_Leave);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.materialLabel7);
            this.tabPage5.Controls.Add(this.materialButton1);
            this.tabPage5.Controls.Add(this.passwordTxtBox);
            this.tabPage5.Controls.Add(this.usernameTxt);
            this.tabPage5.ImageKey = "login2.png";
            this.tabPage5.Location = new System.Drawing.Point(4, 39);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(809, 759);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Giriş Yap";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "home.png");
            this.ımageList1.Images.SetKeyName(1, "cars.png");
            this.ımageList1.Images.SetKeyName(2, "pricing.png");
            this.ımageList1.Images.SetKeyName(3, "contactUs.png");
            this.ımageList1.Images.SetKeyName(4, "login.png");
            this.ımageList1.Images.SetKeyName(5, "login2.png");
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(327, 358);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(89, 36);
            this.materialButton1.TabIndex = 2;
            this.materialButton1.Text = "Giriş Yap";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // passwordTxtBox
            // 
            this.passwordTxtBox.AnimateReadOnly = false;
            this.passwordTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordTxtBox.Depth = 0;
            this.passwordTxtBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.passwordTxtBox.LeadingIcon = null;
            this.passwordTxtBox.Location = new System.Drawing.Point(220, 270);
            this.passwordTxtBox.MaxLength = 50;
            this.passwordTxtBox.MouseState = MaterialSkin.MouseState.OUT;
            this.passwordTxtBox.Multiline = false;
            this.passwordTxtBox.Name = "passwordTxtBox";
            this.passwordTxtBox.Size = new System.Drawing.Size(324, 50);
            this.passwordTxtBox.TabIndex = 1;
            this.passwordTxtBox.TabStop = false;
            this.passwordTxtBox.Text = "";
            this.passwordTxtBox.TrailingIcon = null;
            this.passwordTxtBox.TextChanged += new System.EventHandler(this.passwordTxtBox_TextChanged);
            this.passwordTxtBox.Enter += new System.EventHandler(this.passwordTxtBox_Enter);
            this.passwordTxtBox.Leave += new System.EventHandler(this.passwordTxtBox_Leave);
            // 
            // usernameTxt
            // 
            this.usernameTxt.AnimateReadOnly = false;
            this.usernameTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usernameTxt.Depth = 0;
            this.usernameTxt.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.usernameTxt.LeadingIcon = null;
            this.usernameTxt.Location = new System.Drawing.Point(220, 186);
            this.usernameTxt.MaxLength = 50;
            this.usernameTxt.MouseState = MaterialSkin.MouseState.OUT;
            this.usernameTxt.Multiline = false;
            this.usernameTxt.Name = "usernameTxt";
            this.usernameTxt.Size = new System.Drawing.Size(324, 50);
            this.usernameTxt.TabIndex = 0;
            this.usernameTxt.TabStop = false;
            this.usernameTxt.Text = "";
            this.usernameTxt.TrailingIcon = null;
            this.usernameTxt.TextChanged += new System.EventHandler(this.usernameTxt_TextChanged);
            this.usernameTxt.Enter += new System.EventHandler(this.usernameTxt_Enter);
            this.usernameTxt.Leave += new System.EventHandler(this.usernameTxt_Leave);
            // 
            // aracPicBox
            // 
            this.aracPicBox.Image = ((System.Drawing.Image)(resources.GetObject("aracPicBox.Image")));
            this.aracPicBox.Location = new System.Drawing.Point(6, 6);
            this.aracPicBox.Name = "aracPicBox";
            this.aracPicBox.Size = new System.Drawing.Size(385, 212);
            this.aracPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.aracPicBox.TabIndex = 0;
            this.aracPicBox.TabStop = false;
            // 
            // aracIsimLbl
            // 
            this.aracIsimLbl.AutoSize = true;
            this.aracIsimLbl.Depth = 0;
            this.aracIsimLbl.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.aracIsimLbl.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.aracIsimLbl.Location = new System.Drawing.Point(397, 15);
            this.aracIsimLbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.aracIsimLbl.Name = "aracIsimLbl";
            this.aracIsimLbl.Size = new System.Drawing.Size(236, 41);
            this.aracIsimLbl.TabIndex = 1;
            this.aracIsimLbl.Text = "Renault Symbol";
            // 
            // aracModelLbl
            // 
            this.aracModelLbl.AutoSize = true;
            this.aracModelLbl.Depth = 0;
            this.aracModelLbl.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.aracModelLbl.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.aracModelLbl.Location = new System.Drawing.Point(397, 89);
            this.aracModelLbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.aracModelLbl.Name = "aracModelLbl";
            this.aracModelLbl.Size = new System.Drawing.Size(77, 41);
            this.aracModelLbl.TabIndex = 2;
            this.aracModelLbl.Text = "2021";
            // 
            // aracFiyatLbl
            // 
            this.aracFiyatLbl.AutoSize = true;
            this.aracFiyatLbl.Depth = 0;
            this.aracFiyatLbl.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.aracFiyatLbl.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.aracFiyatLbl.Location = new System.Drawing.Point(397, 169);
            this.aracFiyatLbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.aracFiyatLbl.Name = "aracFiyatLbl";
            this.aracFiyatLbl.Size = new System.Drawing.Size(104, 41);
            this.aracFiyatLbl.TabIndex = 3;
            this.aracFiyatLbl.Text = "550 TL";
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto Light", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.FontType = MaterialSkin.MaterialSkinManager.fontType.H2;
            this.materialLabel7.Location = new System.Drawing.Point(223, 75);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(315, 72);
            this.materialLabel7.TabIndex = 4;
            this.materialLabel7.Text = "Admin Girişi";
            this.materialLabel7.Click += new System.EventHandler(this.materialLabel7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 893);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_64;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(3, 88, 3, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Özkaya Araç Kiralama";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aracPicBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        public System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.TabPage tabPage5;
        private MaterialSkin.Controls.MaterialTextBox usernameTxt;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialTextBox passwordTxtBox;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 mesajTxtBox;
        private MaterialSkin.Controls.MaterialButton msjGonderBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialComboBox materialComboBox4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialComboBox materialComboBox3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialComboBox materialComboBox2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialComboBox materialComboBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private MaterialSkin.Controls.MaterialLabel aracFiyatLbl;
        private MaterialSkin.Controls.MaterialLabel aracModelLbl;
        private MaterialSkin.Controls.MaterialLabel aracIsimLbl;
        private System.Windows.Forms.PictureBox aracPicBox;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
    }
}

