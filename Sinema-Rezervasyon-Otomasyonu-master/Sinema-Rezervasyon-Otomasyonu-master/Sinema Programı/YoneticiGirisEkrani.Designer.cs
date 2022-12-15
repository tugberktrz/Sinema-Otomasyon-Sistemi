namespace Sinema_Programı
{
    partial class YoneticiGirisEkrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YoneticiGirisEkrani));
            this.btnprev = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnyoneticigiris = new System.Windows.Forms.Button();
            this.txtparola = new System.Windows.Forms.TextBox();
            this.txtkullaniciadi = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnprev
            // 
            this.btnprev.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnprev.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnprev.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnprev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnprev.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnprev.Image = ((System.Drawing.Image)(resources.GetObject("btnprev.Image")));
            this.btnprev.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnprev.Location = new System.Drawing.Point(842, 498);
            this.btnprev.Margin = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.btnprev.Name = "btnprev";
            this.btnprev.Size = new System.Drawing.Size(230, 48);
            this.btnprev.TabIndex = 3;
            this.btnprev.Text = "Anasayfaya Dön";
            this.btnprev.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnprev.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnprev.UseVisualStyleBackColor = false;
            this.btnprev.Click += new System.EventHandler(this.btnprev_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(709, 122);
            this.label3.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(251, 42);
            this.label3.TabIndex = 34;
            this.label3.Text = "Kasiyer Girişi";
            // 
            // btnyoneticigiris
            // 
            this.btnyoneticigiris.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnyoneticigiris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnyoneticigiris.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnyoneticigiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnyoneticigiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnyoneticigiris.Image = ((System.Drawing.Image)(resources.GetObject("btnyoneticigiris.Image")));
            this.btnyoneticigiris.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnyoneticigiris.Location = new System.Drawing.Point(680, 357);
            this.btnyoneticigiris.Margin = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.btnyoneticigiris.Name = "btnyoneticigiris";
            this.btnyoneticigiris.Size = new System.Drawing.Size(161, 46);
            this.btnyoneticigiris.TabIndex = 2;
            this.btnyoneticigiris.Text = "  GİRİŞ";
            this.btnyoneticigiris.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnyoneticigiris.UseVisualStyleBackColor = false;
            this.btnyoneticigiris.Click += new System.EventHandler(this.btnyoneticigiris_Click);
            // 
            // txtparola
            // 
            this.txtparola.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtparola.Location = new System.Drawing.Point(680, 264);
            this.txtparola.Margin = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.txtparola.Multiline = true;
            this.txtparola.Name = "txtparola";
            this.txtparola.PasswordChar = '*';
            this.txtparola.Size = new System.Drawing.Size(383, 61);
            this.txtparola.TabIndex = 1;
            this.txtparola.Enter += new System.EventHandler(this.txtparola_Enter);
            this.txtparola.Leave += new System.EventHandler(this.txtparola_Leave);
            // 
            // txtkullaniciadi
            // 
            this.txtkullaniciadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtkullaniciadi.Location = new System.Drawing.Point(680, 187);
            this.txtkullaniciadi.Margin = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.txtkullaniciadi.Multiline = true;
            this.txtkullaniciadi.Name = "txtkullaniciadi";
            this.txtkullaniciadi.Size = new System.Drawing.Size(383, 61);
            this.txtkullaniciadi.TabIndex = 0;
            this.txtkullaniciadi.Enter += new System.EventHandler(this.txtkullaniciadi_Enter);
            this.txtkullaniciadi.Leave += new System.EventHandler(this.txtkullaniciadi_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(631, 206);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 29);
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(631, 282);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(29, 30);
            this.pictureBox2.TabIndex = 37;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(91, 122);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(242, 203);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 38;
            this.pictureBox3.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(139, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 67);
            this.button1.TabIndex = 39;
            this.button1.Text = "Parmak İzi Oku";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(150, 380);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 63);
            this.button2.TabIndex = 40;
            this.button2.Text = "Parmak izi tara";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // YoneticiGirisEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 39F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1219, 711);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnprev);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnyoneticigiris);
            this.Controls.Add(this.txtparola);
            this.Controls.Add(this.txtkullaniciadi);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.Name = "YoneticiGirisEkrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yönetici Giriş Ekranı";
            this.Load += new System.EventHandler(this.YoneticiGirisEkrani_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnprev;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnyoneticigiris;
        private System.Windows.Forms.TextBox txtparola;
        private System.Windows.Forms.TextBox txtkullaniciadi;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}