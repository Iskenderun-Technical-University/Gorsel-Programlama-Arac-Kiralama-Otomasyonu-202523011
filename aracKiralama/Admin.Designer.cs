using System;
using System.Windows.Forms;

namespace aracKiralama
{
    partial class Admin
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
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnSil = new MaterialSkin.Controls.MaterialButton();
            this.btnGuncelle = new MaterialSkin.Controls.MaterialButton();
            this.btnKaydet = new MaterialSkin.Controls.MaterialButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtResimYolu = new System.Windows.Forms.TextBox();
            this.btnResimSec = new MaterialSkin.Controls.MaterialButton();
            this.txtAciklama = new MaterialSkin.Controls.MaterialTextBox();
            this.pbResim = new System.Windows.Forms.PictureBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tarihLbl = new MaterialSkin.Controls.MaterialLabel();
            this.gonderenLbl = new MaterialSkin.Controls.MaterialLabel();
            this.mesajLbl = new MaterialSkin.Controls.MaterialLabel();
            this.mesajDataGridView = new System.Windows.Forms.DataGridView();
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbResim)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mesajDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Controls.Add(this.tabPage3);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.Location = new System.Drawing.Point(3, 64);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1270, 690);
            this.materialTabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1262, 664);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Sipariş Kontrol";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(1256, 658);
            this.dataGridView2.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnSil);
            this.tabPage2.Controls.Add(this.btnGuncelle);
            this.tabPage2.Controls.Add(this.btnKaydet);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1262, 664);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Katalog Güncelle";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnSil
            // 
            this.btnSil.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSil.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSil.Depth = 0;
            this.btnSil.HighEmphasis = true;
            this.btnSil.Icon = null;
            this.btnSil.Location = new System.Drawing.Point(998, 171);
            this.btnSil.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSil.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSil.Name = "btnSil";
            this.btnSil.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSil.Size = new System.Drawing.Size(64, 36);
            this.btnSil.TabIndex = 4;
            this.btnSil.Text = "SİL";
            this.btnSil.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSil.UseAccentColor = false;
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGuncelle.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnGuncelle.Depth = 0;
            this.btnGuncelle.HighEmphasis = true;
            this.btnGuncelle.Icon = null;
            this.btnGuncelle.Location = new System.Drawing.Point(998, 123);
            this.btnGuncelle.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGuncelle.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnGuncelle.Size = new System.Drawing.Size(94, 36);
            this.btnGuncelle.TabIndex = 3;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnGuncelle.UseAccentColor = false;
            this.btnGuncelle.UseVisualStyleBackColor = true;
            // 
            // btnKaydet
            // 
            this.btnKaydet.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnKaydet.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnKaydet.Depth = 0;
            this.btnKaydet.HighEmphasis = true;
            this.btnKaydet.Icon = null;
            this.btnKaydet.Location = new System.Drawing.Point(998, 75);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnKaydet.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnKaydet.Size = new System.Drawing.Size(76, 36);
            this.btnKaydet.TabIndex = 2;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnKaydet.UseAccentColor = false;
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(3, 336);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1256, 325);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick_1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtResimYolu);
            this.panel1.Controls.Add(this.btnResimSec);
            this.panel1.Controls.Add(this.txtAciklama);
            this.panel1.Controls.Add(this.pbResim);
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(877, 324);
            this.panel1.TabIndex = 0;
            // 
            // txtResimYolu
            // 
            this.txtResimYolu.Location = new System.Drawing.Point(570, 132);
            this.txtResimYolu.Name = "txtResimYolu";
            this.txtResimYolu.Size = new System.Drawing.Size(100, 20);
            this.txtResimYolu.TabIndex = 3;
            this.txtResimYolu.Visible = false;
            // 
            // btnResimSec
            // 
            this.btnResimSec.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnResimSec.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnResimSec.Depth = 0;
            this.btnResimSec.HighEmphasis = true;
            this.btnResimSec.Icon = null;
            this.btnResimSec.Location = new System.Drawing.Point(570, 60);
            this.btnResimSec.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnResimSec.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnResimSec.Name = "btnResimSec";
            this.btnResimSec.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnResimSec.Size = new System.Drawing.Size(110, 36);
            this.btnResimSec.TabIndex = 2;
            this.btnResimSec.Text = "RESİM SEÇİN";
            this.btnResimSec.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnResimSec.UseAccentColor = false;
            this.btnResimSec.UseVisualStyleBackColor = true;
            this.btnResimSec.Click += new System.EventHandler(this.btnResimSec_Click);
            // 
            // txtAciklama
            // 
            this.txtAciklama.AnimateReadOnly = false;
            this.txtAciklama.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAciklama.Depth = 0;
            this.txtAciklama.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtAciklama.LeadingIcon = null;
            this.txtAciklama.Location = new System.Drawing.Point(4, 267);
            this.txtAciklama.MaxLength = 50;
            this.txtAciklama.MouseState = MaterialSkin.MouseState.OUT;
            this.txtAciklama.Multiline = false;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(811, 50);
            this.txtAciklama.TabIndex = 1;
            this.txtAciklama.Text = "";
            this.txtAciklama.TrailingIcon = null;
            // 
            // pbResim
            // 
            this.pbResim.Location = new System.Drawing.Point(4, 4);
            this.pbResim.Name = "pbResim";
            this.pbResim.Size = new System.Drawing.Size(559, 257);
            this.pbResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbResim.TabIndex = 0;
            this.pbResim.TabStop = false;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tarihLbl);
            this.tabPage3.Controls.Add(this.gonderenLbl);
            this.tabPage3.Controls.Add(this.mesajLbl);
            this.tabPage3.Controls.Add(this.mesajDataGridView);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1262, 664);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Gelen Kutusu";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tarihLbl
            // 
            this.tarihLbl.AutoSize = true;
            this.tarihLbl.Depth = 0;
            this.tarihLbl.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tarihLbl.Location = new System.Drawing.Point(988, 32);
            this.tarihLbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.tarihLbl.Name = "tarihLbl";
            this.tarihLbl.Size = new System.Drawing.Size(107, 19);
            this.tarihLbl.TabIndex = 3;
            this.tarihLbl.Text = "materialLabel3";
            // 
            // gonderenLbl
            // 
            this.gonderenLbl.AutoSize = true;
            this.gonderenLbl.Depth = 0;
            this.gonderenLbl.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gonderenLbl.Location = new System.Drawing.Point(686, 32);
            this.gonderenLbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.gonderenLbl.Name = "gonderenLbl";
            this.gonderenLbl.Size = new System.Drawing.Size(107, 19);
            this.gonderenLbl.TabIndex = 2;
            this.gonderenLbl.Text = "materialLabel2";
            // 
            // mesajLbl
            // 
            this.mesajLbl.AutoSize = true;
            this.mesajLbl.Depth = 0;
            this.mesajLbl.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mesajLbl.Location = new System.Drawing.Point(3, 32);
            this.mesajLbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.mesajLbl.Name = "mesajLbl";
            this.mesajLbl.Size = new System.Drawing.Size(107, 19);
            this.mesajLbl.TabIndex = 1;
            this.mesajLbl.Text = "materialLabel1";
            // 
            // mesajDataGridView
            // 
            this.mesajDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mesajDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mesajDataGridView.Location = new System.Drawing.Point(0, 333);
            this.mesajDataGridView.Name = "mesajDataGridView";
            this.mesajDataGridView.Size = new System.Drawing.Size(1262, 331);
            this.mesajDataGridView.TabIndex = 0;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 757);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerTabControl = this.materialTabControl1;
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Paneli";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbResim)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mesajDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private MaterialSkin.Controls.MaterialButton btnSil;
        private MaterialSkin.Controls.MaterialButton btnGuncelle;
        private MaterialSkin.Controls.MaterialButton btnKaydet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbResim;
        private MaterialSkin.Controls.MaterialTextBox txtAciklama;
        private MaterialSkin.Controls.MaterialButton btnResimSec;
        private System.Windows.Forms.TextBox txtResimYolu;
        private DataGridView dataGridView2;
        private MaterialSkin.Controls.MaterialLabel tarihLbl;
        private MaterialSkin.Controls.MaterialLabel gonderenLbl;
        private MaterialSkin.Controls.MaterialLabel mesajLbl;
        private DataGridView mesajDataGridView;
    }
}