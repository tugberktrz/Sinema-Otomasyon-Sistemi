namespace Sinema_Programı
{
    partial class KullaniciGirisEkrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KullaniciGirisEkrani));
            this.btnprev = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnkullanicigiris = new System.Windows.Forms.Button();
            this.txtparola = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtUyelikAd = new System.Windows.Forms.TextBox();
            this.txtUyelikSoyad = new System.Windows.Forms.TextBox();
            this.txtUyelikSifre = new System.Windows.Forms.TextBox();
            this.txtUyelikTelefon = new System.Windows.Forms.TextBox();
            this.btnUyeOl = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnprev
            // 
            this.btnprev.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnprev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnprev.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnprev.Image = ((System.Drawing.Image)(resources.GetObject("btnprev.Image")));
            this.btnprev.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnprev.Location = new System.Drawing.Point(256, 719);
            this.btnprev.Margin = new System.Windows.Forms.Padding(14, 11, 14, 11);
            this.btnprev.Name = "btnprev";
            this.btnprev.Size = new System.Drawing.Size(680, 115);
            this.btnprev.TabIndex = 3;
            this.btnprev.Text = "Anasayfaya Dön";
            this.btnprev.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnprev.UseVisualStyleBackColor = false;
            this.btnprev.Click += new System.EventHandler(this.btnprev_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlText;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Honeydew;
            this.label3.Location = new System.Drawing.Point(34, 60);
            this.label3.Margin = new System.Windows.Forms.Padding(14, 0, 14, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(336, 42);
            this.label3.TabIndex = 34;
            this.label3.Text = "Kullanıcı Giriş Alanı";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnkullanicigiris
            // 
            this.btnkullanicigiris.BackColor = System.Drawing.Color.Bisque;
            this.btnkullanicigiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnkullanicigiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnkullanicigiris.Image = ((System.Drawing.Image)(resources.GetObject("btnkullanicigiris.Image")));
            this.btnkullanicigiris.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnkullanicigiris.Location = new System.Drawing.Point(171, 333);
            this.btnkullanicigiris.Margin = new System.Windows.Forms.Padding(14, 11, 14, 11);
            this.btnkullanicigiris.Name = "btnkullanicigiris";
            this.btnkullanicigiris.Size = new System.Drawing.Size(128, 61);
            this.btnkullanicigiris.TabIndex = 2;
            this.btnkullanicigiris.Text = "   GİRİŞ";
            this.btnkullanicigiris.UseVisualStyleBackColor = false;
            this.btnkullanicigiris.Click += new System.EventHandler(this.btnkullanicigiris_Click);
            // 
            // txtparola
            // 
            this.txtparola.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtparola.Location = new System.Drawing.Point(80, 236);
            this.txtparola.Margin = new System.Windows.Forms.Padding(14, 11, 14, 11);
            this.txtparola.Multiline = true;
            this.txtparola.Name = "txtparola";
            this.txtparola.PasswordChar = '*';
            this.txtparola.Size = new System.Drawing.Size(349, 61);
            this.txtparola.TabIndex = 1;
            this.txtparola.Enter += new System.EventHandler(this.txtparola_Enter);
            this.txtparola.Leave += new System.EventHandler(this.txtparola_Leave);
            // 
            // txtTelefon
            // 
            this.txtTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTelefon.Location = new System.Drawing.Point(80, 124);
            this.txtTelefon.Margin = new System.Windows.Forms.Padding(14, 11, 14, 11);
            this.txtTelefon.Multiline = true;
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(349, 54);
            this.txtTelefon.TabIndex = 0;
            this.txtTelefon.Enter += new System.EventHandler(this.txtkullaniciadi_Enter);
            this.txtTelefon.Leave += new System.EventHandler(this.txtkullaniciadi_Leave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(41, 249);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(14, 11, 14, 11);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 31);
            this.pictureBox2.TabIndex = 39;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(41, 138);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(14, 11, 14, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 28);
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // txtUyelikAd
            // 
            this.txtUyelikAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUyelikAd.Location = new System.Drawing.Point(653, 124);
            this.txtUyelikAd.Margin = new System.Windows.Forms.Padding(14, 11, 14, 11);
            this.txtUyelikAd.Multiline = true;
            this.txtUyelikAd.Name = "txtUyelikAd";
            this.txtUyelikAd.Size = new System.Drawing.Size(349, 54);
            this.txtUyelikAd.TabIndex = 40;
            // 
            // txtUyelikSoyad
            // 
            this.txtUyelikSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUyelikSoyad.Location = new System.Drawing.Point(653, 236);
            this.txtUyelikSoyad.Margin = new System.Windows.Forms.Padding(14, 11, 14, 11);
            this.txtUyelikSoyad.Multiline = true;
            this.txtUyelikSoyad.Name = "txtUyelikSoyad";
            this.txtUyelikSoyad.Size = new System.Drawing.Size(349, 54);
            this.txtUyelikSoyad.TabIndex = 41;
            // 
            // txtUyelikSifre
            // 
            this.txtUyelikSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUyelikSifre.Location = new System.Drawing.Point(653, 445);
            this.txtUyelikSifre.Margin = new System.Windows.Forms.Padding(14, 11, 14, 11);
            this.txtUyelikSifre.Multiline = true;
            this.txtUyelikSifre.Name = "txtUyelikSifre";
            this.txtUyelikSifre.Size = new System.Drawing.Size(349, 54);
            this.txtUyelikSifre.TabIndex = 43;
            // 
            // txtUyelikTelefon
            // 
            this.txtUyelikTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUyelikTelefon.Location = new System.Drawing.Point(653, 333);
            this.txtUyelikTelefon.Margin = new System.Windows.Forms.Padding(14, 11, 14, 11);
            this.txtUyelikTelefon.Multiline = true;
            this.txtUyelikTelefon.Name = "txtUyelikTelefon";
            this.txtUyelikTelefon.Size = new System.Drawing.Size(349, 54);
            this.txtUyelikTelefon.TabIndex = 42;
            // 
            // btnUyeOl
            // 
            this.btnUyeOl.BackColor = System.Drawing.Color.Bisque;
            this.btnUyeOl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUyeOl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUyeOl.Image = ((System.Drawing.Image)(resources.GetObject("btnUyeOl.Image")));
            this.btnUyeOl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUyeOl.Location = new System.Drawing.Point(772, 544);
            this.btnUyeOl.Margin = new System.Windows.Forms.Padding(14, 11, 14, 11);
            this.btnUyeOl.Name = "btnUyeOl";
            this.btnUyeOl.Size = new System.Drawing.Size(128, 61);
            this.btnUyeOl.TabIndex = 44;
            this.btnUyeOl.Text = "     ÜYE OL";
            this.btnUyeOl.UseVisualStyleBackColor = false;
            this.btnUyeOl.Click += new System.EventHandler(this.btnUyeOl_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Honeydew;
            this.label1.Location = new System.Drawing.Point(572, 124);
            this.label1.Margin = new System.Windows.Forms.Padding(14, 0, 14, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 42);
            this.label1.TabIndex = 45;
            this.label1.Text = "Ad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlText;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Honeydew;
            this.label2.Location = new System.Drawing.Point(523, 248);
            this.label2.Margin = new System.Windows.Forms.Padding(14, 0, 14, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 42);
            this.label2.TabIndex = 46;
            this.label2.Text = "Soyad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlText;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Honeydew;
            this.label4.Location = new System.Drawing.Point(482, 335);
            this.label4.Margin = new System.Windows.Forms.Padding(14, 0, 14, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 42);
            this.label4.TabIndex = 47;
            this.label4.Text = "Telefon";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlText;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Honeydew;
            this.label5.Location = new System.Drawing.Point(554, 445);
            this.label5.Margin = new System.Windows.Forms.Padding(14, 0, 14, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 42);
            this.label5.TabIndex = 48;
            this.label5.Text = "Şifre";
            // 
            // KullaniciGirisEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(28F, 55F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1220, 975);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUyeOl);
            this.Controls.Add(this.txtUyelikSifre);
            this.Controls.Add(this.txtUyelikTelefon);
            this.Controls.Add(this.txtUyelikSoyad);
            this.Controls.Add(this.txtUyelikAd);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnprev);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnkullanicigiris);
            this.Controls.Add(this.txtparola);
            this.Controls.Add(this.txtTelefon);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(14, 11, 14, 11);
            this.Name = "KullaniciGirisEkrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcı Giriş Ekranı";
            this.Load += new System.EventHandler(this.KullaniciGirisEkrani_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnprev;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnkullanicigiris;
        private System.Windows.Forms.TextBox txtparola;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtUyelikAd;
        private System.Windows.Forms.TextBox txtUyelikSoyad;
        private System.Windows.Forms.TextBox txtUyelikSifre;
        private System.Windows.Forms.TextBox txtUyelikTelefon;
        private System.Windows.Forms.Button btnUyeOl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}