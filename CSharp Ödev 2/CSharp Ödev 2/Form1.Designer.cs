namespace CSharp_Ödev_2
{
    partial class Form11
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form11));
            this.lblBaslangicDegeri = new System.Windows.Forms.Label();
            this.lblBitisDegeri = new System.Windows.Forms.Label();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.btnGeri = new System.Windows.Forms.Button();
            this.btnIleri = new System.Windows.Forms.Button();
            this.grpBoxGirisBilgileri = new System.Windows.Forms.GroupBox();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.txtBoxBitis = new System.Windows.Forms.MaskedTextBox();
            this.txtBoxBaslangic = new System.Windows.Forms.MaskedTextBox();
            this.tabTumTablar = new System.Windows.Forms.TabControl();
            this.tabTekSayilar = new System.Windows.Forms.TabPage();
            this.listViewTek = new System.Windows.Forms.ListView();
            this.tabCiftSayilar = new System.Windows.Forms.TabPage();
            this.listViewCift = new System.Windows.Forms.ListView();
            this.tabAsalSayilar = new System.Windows.Forms.TabPage();
            this.listViewAsal = new System.Windows.Forms.ListView();
            this.tabArmstrongSayilar = new System.Windows.Forms.TabPage();
            this.listViewArmstrong = new System.Windows.Forms.ListView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.lbLogoAlti = new System.Windows.Forms.Label();
            this.grpBoxGirisBilgileri.SuspendLayout();
            this.tabTumTablar.SuspendLayout();
            this.tabTekSayilar.SuspendLayout();
            this.tabCiftSayilar.SuspendLayout();
            this.tabAsalSayilar.SuspendLayout();
            this.tabArmstrongSayilar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBaslangicDegeri
            // 
            this.lblBaslangicDegeri.AutoSize = true;
            this.lblBaslangicDegeri.Location = new System.Drawing.Point(34, 33);
            this.lblBaslangicDegeri.Name = "lblBaslangicDegeri";
            this.lblBaslangicDegeri.Size = new System.Drawing.Size(69, 17);
            this.lblBaslangicDegeri.TabIndex = 2;
            this.lblBaslangicDegeri.Text = "Baslangıç";
            // 
            // lblBitisDegeri
            // 
            this.lblBitisDegeri.AutoSize = true;
            this.lblBitisDegeri.Location = new System.Drawing.Point(69, 61);
            this.lblBitisDegeri.Name = "lblBitisDegeri";
            this.lblBitisDegeri.Size = new System.Drawing.Size(34, 17);
            this.lblBitisDegeri.TabIndex = 3;
            this.lblBitisDegeri.Text = "Bitiş";
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(215, 45);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(75, 23);
            this.btnHesapla.TabIndex = 3;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // btnGeri
            // 
            this.btnGeri.Location = new System.Drawing.Point(330, 45);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(75, 23);
            this.btnGeri.TabIndex = 4;
            this.btnGeri.Text = "<Geri";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // btnIleri
            // 
            this.btnIleri.Location = new System.Drawing.Point(411, 45);
            this.btnIleri.Name = "btnIleri";
            this.btnIleri.Size = new System.Drawing.Size(75, 23);
            this.btnIleri.TabIndex = 5;
            this.btnIleri.Text = "İleri>";
            this.btnIleri.UseVisualStyleBackColor = true;
            this.btnIleri.Click += new System.EventHandler(this.btnIleri_Click);
            // 
            // grpBoxGirisBilgileri
            // 
            this.grpBoxGirisBilgileri.Controls.Add(this.btnTemizle);
            this.grpBoxGirisBilgileri.Controls.Add(this.txtBoxBitis);
            this.grpBoxGirisBilgileri.Controls.Add(this.txtBoxBaslangic);
            this.grpBoxGirisBilgileri.Controls.Add(this.btnIleri);
            this.grpBoxGirisBilgileri.Controls.Add(this.btnGeri);
            this.grpBoxGirisBilgileri.Controls.Add(this.btnHesapla);
            this.grpBoxGirisBilgileri.Controls.Add(this.lblBaslangicDegeri);
            this.grpBoxGirisBilgileri.Controls.Add(this.lblBitisDegeri);
            this.grpBoxGirisBilgileri.Location = new System.Drawing.Point(12, 12);
            this.grpBoxGirisBilgileri.Name = "grpBoxGirisBilgileri";
            this.grpBoxGirisBilgileri.Size = new System.Drawing.Size(534, 95);
            this.grpBoxGirisBilgileri.TabIndex = 7;
            this.grpBoxGirisBilgileri.TabStop = false;
            this.grpBoxGirisBilgileri.Text = "Giriş Bilgileri";
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(330, 16);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(156, 23);
            this.btnTemizle.TabIndex = 16;
            this.btnTemizle.Text = "EKRANI TEMİZLE";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // txtBoxBitis
            // 
            this.txtBoxBitis.Location = new System.Drawing.Point(109, 58);
            this.txtBoxBitis.Name = "txtBoxBitis";
            this.txtBoxBitis.Size = new System.Drawing.Size(100, 22);
            this.txtBoxBitis.TabIndex = 2;
            // 
            // txtBoxBaslangic
            // 
            this.txtBoxBaslangic.Location = new System.Drawing.Point(109, 33);
            this.txtBoxBaslangic.Name = "txtBoxBaslangic";
            this.txtBoxBaslangic.Size = new System.Drawing.Size(100, 22);
            this.txtBoxBaslangic.TabIndex = 1;
            // 
            // tabTumTablar
            // 
            this.tabTumTablar.Controls.Add(this.tabTekSayilar);
            this.tabTumTablar.Controls.Add(this.tabCiftSayilar);
            this.tabTumTablar.Controls.Add(this.tabAsalSayilar);
            this.tabTumTablar.Controls.Add(this.tabArmstrongSayilar);
            this.tabTumTablar.Location = new System.Drawing.Point(12, 132);
            this.tabTumTablar.Name = "tabTumTablar";
            this.tabTumTablar.SelectedIndex = 0;
            this.tabTumTablar.Size = new System.Drawing.Size(776, 306);
            this.tabTumTablar.TabIndex = 15;
            // 
            // tabTekSayilar
            // 
            this.tabTekSayilar.Controls.Add(this.listViewTek);
            this.tabTekSayilar.Location = new System.Drawing.Point(4, 25);
            this.tabTekSayilar.Name = "tabTekSayilar";
            this.tabTekSayilar.Padding = new System.Windows.Forms.Padding(3);
            this.tabTekSayilar.Size = new System.Drawing.Size(768, 277);
            this.tabTekSayilar.TabIndex = 0;
            this.tabTekSayilar.Text = "Tek Sayılar";
            this.tabTekSayilar.UseVisualStyleBackColor = true;
            // 
            // listViewTek
            // 
            this.listViewTek.HideSelection = false;
            this.listViewTek.Location = new System.Drawing.Point(6, 6);
            this.listViewTek.Name = "listViewTek";
            this.listViewTek.Size = new System.Drawing.Size(756, 265);
            this.listViewTek.TabIndex = 7;
            this.listViewTek.UseCompatibleStateImageBehavior = false;
            this.listViewTek.View = System.Windows.Forms.View.List;
            // 
            // tabCiftSayilar
            // 
            this.tabCiftSayilar.Controls.Add(this.listViewCift);
            this.tabCiftSayilar.Location = new System.Drawing.Point(4, 25);
            this.tabCiftSayilar.Name = "tabCiftSayilar";
            this.tabCiftSayilar.Padding = new System.Windows.Forms.Padding(3);
            this.tabCiftSayilar.Size = new System.Drawing.Size(768, 277);
            this.tabCiftSayilar.TabIndex = 1;
            this.tabCiftSayilar.Text = "Çift Sayılar";
            this.tabCiftSayilar.UseVisualStyleBackColor = true;
            // 
            // listViewCift
            // 
            this.listViewCift.HideSelection = false;
            this.listViewCift.Location = new System.Drawing.Point(6, 6);
            this.listViewCift.Name = "listViewCift";
            this.listViewCift.Size = new System.Drawing.Size(756, 265);
            this.listViewCift.TabIndex = 8;
            this.listViewCift.UseCompatibleStateImageBehavior = false;
            this.listViewCift.View = System.Windows.Forms.View.List;
            // 
            // tabAsalSayilar
            // 
            this.tabAsalSayilar.Controls.Add(this.listViewAsal);
            this.tabAsalSayilar.Location = new System.Drawing.Point(4, 25);
            this.tabAsalSayilar.Name = "tabAsalSayilar";
            this.tabAsalSayilar.Padding = new System.Windows.Forms.Padding(3);
            this.tabAsalSayilar.Size = new System.Drawing.Size(768, 277);
            this.tabAsalSayilar.TabIndex = 2;
            this.tabAsalSayilar.Text = "Asal Sayılar";
            this.tabAsalSayilar.UseVisualStyleBackColor = true;
            // 
            // listViewAsal
            // 
            this.listViewAsal.HideSelection = false;
            this.listViewAsal.Location = new System.Drawing.Point(6, 6);
            this.listViewAsal.Name = "listViewAsal";
            this.listViewAsal.Size = new System.Drawing.Size(756, 265);
            this.listViewAsal.TabIndex = 9;
            this.listViewAsal.UseCompatibleStateImageBehavior = false;
            this.listViewAsal.View = System.Windows.Forms.View.List;
            // 
            // tabArmstrongSayilar
            // 
            this.tabArmstrongSayilar.Controls.Add(this.listViewArmstrong);
            this.tabArmstrongSayilar.Location = new System.Drawing.Point(4, 25);
            this.tabArmstrongSayilar.Name = "tabArmstrongSayilar";
            this.tabArmstrongSayilar.Padding = new System.Windows.Forms.Padding(3);
            this.tabArmstrongSayilar.Size = new System.Drawing.Size(768, 277);
            this.tabArmstrongSayilar.TabIndex = 3;
            this.tabArmstrongSayilar.Text = "Armstrong Sayıları";
            this.tabArmstrongSayilar.UseVisualStyleBackColor = true;
            // 
            // listViewArmstrong
            // 
            this.listViewArmstrong.HideSelection = false;
            this.listViewArmstrong.Location = new System.Drawing.Point(6, 6);
            this.listViewArmstrong.Name = "listViewArmstrong";
            this.listViewArmstrong.Size = new System.Drawing.Size(756, 265);
            this.listViewArmstrong.TabIndex = 10;
            this.listViewArmstrong.UseCompatibleStateImageBehavior = false;
            this.listViewArmstrong.View = System.Windows.Forms.View.List;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CSharp_Ödev_2.Properties.Resources.tçaa_logo_png;
            this.pictureBox1.Location = new System.Drawing.Point(561, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(217, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipText = "tek çift asal armstrong (TÇAA) Sayı Bulucu programına hoş geldiniz.";
            this.notifyIcon.BalloonTipTitle = "TÇAA by Emrecan Özkan";
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "TÇAA by Emrecan Özkan";
            this.notifyIcon.Visible = true;
            // 
            // lbLogoAlti
            // 
            this.lbLogoAlti.AutoSize = true;
            this.lbLogoAlti.Location = new System.Drawing.Point(607, 114);
            this.lbLogoAlti.Name = "lbLogoAlti";
            this.lbLogoAlti.Size = new System.Drawing.Size(144, 34);
            this.lbLogoAlti.TabIndex = 17;
            this.lbLogoAlti.Text = "Yukarıya Tıkla\r\nGitHub Hesabıma Git!";
            this.lbLogoAlti.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbLogoAlti);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tabTumTablar);
            this.Controls.Add(this.grpBoxGirisBilgileri);
            this.Name = "Form11";
            this.Text = "TÇAA | EMRECAN ÖZKAN";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form11_FormClosed);
            this.Load += new System.EventHandler(this.Form11_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.grpBoxGirisBilgileri.ResumeLayout(false);
            this.grpBoxGirisBilgileri.PerformLayout();
            this.tabTumTablar.ResumeLayout(false);
            this.tabTekSayilar.ResumeLayout(false);
            this.tabCiftSayilar.ResumeLayout(false);
            this.tabAsalSayilar.ResumeLayout(false);
            this.tabArmstrongSayilar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblBaslangicDegeri;
        private System.Windows.Forms.Label lblBitisDegeri;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Button btnIleri;
        private System.Windows.Forms.GroupBox grpBoxGirisBilgileri;
        private System.Windows.Forms.TabControl tabTumTablar;
        private System.Windows.Forms.TabPage tabTekSayilar;
        private System.Windows.Forms.ListView listViewTek;
        private System.Windows.Forms.TabPage tabCiftSayilar;
        private System.Windows.Forms.ListView listViewCift;
        private System.Windows.Forms.TabPage tabAsalSayilar;
        private System.Windows.Forms.ListView listViewAsal;
        private System.Windows.Forms.TabPage tabArmstrongSayilar;
        private System.Windows.Forms.ListView listViewArmstrong;
        private System.Windows.Forms.MaskedTextBox txtBoxBaslangic;
        private System.Windows.Forms.MaskedTextBox txtBoxBitis;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.Label lbLogoAlti;
    }
}

