
namespace UsedVehicleApp
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txt_ad = new System.Windows.Forms.TextBox();
            this.txt_soyad = new System.Windows.Forms.TextBox();
            this.btn_giris_musteri = new System.Windows.Forms.Button();
            this.btn_db = new System.Windows.Forms.Button();
            this.lbl_ad = new System.Windows.Forms.Label();
            this.lbl_soyad = new System.Windows.Forms.Label();
            this.btn_yönetici_girisi = new System.Windows.Forms.Button();
            this.btn_sahip_giris = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_ad
            // 
            this.txt_ad.Location = new System.Drawing.Point(86, 30);
            this.txt_ad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new System.Drawing.Size(132, 22);
            this.txt_ad.TabIndex = 0;
            // 
            // txt_soyad
            // 
            this.txt_soyad.Location = new System.Drawing.Point(86, 96);
            this.txt_soyad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_soyad.Name = "txt_soyad";
            this.txt_soyad.Size = new System.Drawing.Size(132, 22);
            this.txt_soyad.TabIndex = 1;
            // 
            // btn_giris_musteri
            // 
            this.btn_giris_musteri.Location = new System.Drawing.Point(271, 30);
            this.btn_giris_musteri.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_giris_musteri.Name = "btn_giris_musteri";
            this.btn_giris_musteri.Size = new System.Drawing.Size(159, 39);
            this.btn_giris_musteri.TabIndex = 2;
            this.btn_giris_musteri.Text = "Müşteri Girişi";
            this.btn_giris_musteri.UseVisualStyleBackColor = true;
            this.btn_giris_musteri.Click += new System.EventHandler(this.btn_giris_musteri_Click);
            // 
            // btn_db
            // 
            this.btn_db.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_db.Location = new System.Drawing.Point(278, 534);
            this.btn_db.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_db.Name = "btn_db";
            this.btn_db.Size = new System.Drawing.Size(195, 109);
            this.btn_db.TabIndex = 3;
            this.btn_db.Text = "Bağlantı Kontrol";
            this.btn_db.UseVisualStyleBackColor = false;
            this.btn_db.Click += new System.EventHandler(this.btn_db_Click);
            // 
            // lbl_ad
            // 
            this.lbl_ad.AutoSize = true;
            this.lbl_ad.Location = new System.Drawing.Point(25, 30);
            this.lbl_ad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ad.Name = "lbl_ad";
            this.lbl_ad.Size = new System.Drawing.Size(31, 17);
            this.lbl_ad.TabIndex = 4;
            this.lbl_ad.Text = "AD:";
            // 
            // lbl_soyad
            // 
            this.lbl_soyad.AutoSize = true;
            this.lbl_soyad.Location = new System.Drawing.Point(5, 101);
            this.lbl_soyad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_soyad.Name = "lbl_soyad";
            this.lbl_soyad.Size = new System.Drawing.Size(60, 17);
            this.lbl_soyad.TabIndex = 5;
            this.lbl_soyad.Text = "SOYAD:";
            // 
            // btn_yönetici_girisi
            // 
            this.btn_yönetici_girisi.Location = new System.Drawing.Point(271, 153);
            this.btn_yönetici_girisi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_yönetici_girisi.Name = "btn_yönetici_girisi";
            this.btn_yönetici_girisi.Size = new System.Drawing.Size(159, 39);
            this.btn_yönetici_girisi.TabIndex = 6;
            this.btn_yönetici_girisi.Text = "Yönetici Girişi";
            this.btn_yönetici_girisi.UseVisualStyleBackColor = true;
            this.btn_yönetici_girisi.Click += new System.EventHandler(this.btn_yönetici_girisi_Click);
            // 
            // btn_sahip_giris
            // 
            this.btn_sahip_giris.Location = new System.Drawing.Point(271, 90);
            this.btn_sahip_giris.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_sahip_giris.Name = "btn_sahip_giris";
            this.btn_sahip_giris.Size = new System.Drawing.Size(159, 39);
            this.btn_sahip_giris.TabIndex = 7;
            this.btn_sahip_giris.Text = "Arac Sahibi Girişi";
            this.btn_sahip_giris.UseVisualStyleBackColor = true;
            this.btn_sahip_giris.Click += new System.EventHandler(this.btn_sahip_giris_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.btn_giris_musteri);
            this.panel1.Controls.Add(this.btn_sahip_giris);
            this.panel1.Controls.Add(this.txt_ad);
            this.panel1.Controls.Add(this.btn_yönetici_girisi);
            this.panel1.Controls.Add(this.txt_soyad);
            this.panel1.Controls.Add(this.lbl_soyad);
            this.panel1.Controls.Add(this.lbl_ad);
            this.panel1.Location = new System.Drawing.Point(22, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(466, 297);
            this.panel1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(519, 684);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_db);
            this.Cursor = System.Windows.Forms.Cursors.No;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_ad;
        private System.Windows.Forms.TextBox txt_soyad;
        private System.Windows.Forms.Button btn_giris_musteri;
        private System.Windows.Forms.Button btn_db;
        private System.Windows.Forms.Label lbl_ad;
        private System.Windows.Forms.Label lbl_soyad;
        private System.Windows.Forms.Button btn_yönetici_girisi;
        private System.Windows.Forms.Button btn_sahip_giris;
        private System.Windows.Forms.Panel panel1;
    }
}

