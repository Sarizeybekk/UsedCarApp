
namespace UsedVehicleApp
{
    partial class Ilan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ilan));
            this.btn_ekle = new System.Windows.Forms.Button();
            this.txt_marka = new System.Windows.Forms.TextBox();
            this.txt_fiyat = new System.Windows.Forms.TextBox();
            this.txt_aracTürü = new System.Windows.Forms.TextBox();
            this.lbl_marka = new System.Windows.Forms.Label();
            this.lbl_model = new System.Windows.Forms.Label();
            this.lbl_türü = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_ekle
            // 
            this.btn_ekle.Location = new System.Drawing.Point(365, 19);
            this.btn_ekle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(100, 28);
            this.btn_ekle.TabIndex = 0;
            this.btn_ekle.Text = "Ekle";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // txt_marka
            // 
            this.txt_marka.Location = new System.Drawing.Point(154, 22);
            this.txt_marka.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_marka.Name = "txt_marka";
            this.txt_marka.Size = new System.Drawing.Size(132, 22);
            this.txt_marka.TabIndex = 2;
            this.txt_marka.Text = "Mercedes";
            // 
            // txt_fiyat
            // 
            this.txt_fiyat.Location = new System.Drawing.Point(154, 87);
            this.txt_fiyat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_fiyat.Name = "txt_fiyat";
            this.txt_fiyat.Size = new System.Drawing.Size(132, 22);
            this.txt_fiyat.TabIndex = 3;
            this.txt_fiyat.Text = "1M";
            // 
            // txt_aracTürü
            // 
            this.txt_aracTürü.Location = new System.Drawing.Point(154, 148);
            this.txt_aracTürü.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_aracTürü.Name = "txt_aracTürü";
            this.txt_aracTürü.Size = new System.Drawing.Size(132, 22);
            this.txt_aracTürü.TabIndex = 4;
            this.txt_aracTürü.Text = "Araba";
            // 
            // lbl_marka
            // 
            this.lbl_marka.AutoSize = true;
            this.lbl_marka.Location = new System.Drawing.Point(41, 30);
            this.lbl_marka.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_marka.Name = "lbl_marka";
            this.lbl_marka.Size = new System.Drawing.Size(47, 17);
            this.lbl_marka.TabIndex = 5;
            this.lbl_marka.Text = "Marka";
            // 
            // lbl_model
            // 
            this.lbl_model.AutoSize = true;
            this.lbl_model.Location = new System.Drawing.Point(41, 87);
            this.lbl_model.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_model.Name = "lbl_model";
            this.lbl_model.Size = new System.Drawing.Size(42, 17);
            this.lbl_model.TabIndex = 6;
            this.lbl_model.Text = "Fiyat:";
            // 
            // lbl_türü
            // 
            this.lbl_türü.AutoSize = true;
            this.lbl_türü.Location = new System.Drawing.Point(42, 151);
            this.lbl_türü.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_türü.Name = "lbl_türü";
            this.lbl_türü.Size = new System.Drawing.Size(79, 17);
            this.lbl_türü.TabIndex = 7;
            this.lbl_türü.Text = "Arac Türü: ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(365, 76);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 8;
            this.button1.Text = "Görüntüle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.Location = new System.Drawing.Point(365, 140);
            this.btn_sil.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(100, 28);
            this.btn_sil.TabIndex = 9;
            this.btn_sil.Text = "Sil";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_ekle);
            this.panel1.Controls.Add(this.lbl_türü);
            this.panel1.Controls.Add(this.btn_sil);
            this.panel1.Controls.Add(this.lbl_model);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.lbl_marka);
            this.panel1.Controls.Add(this.txt_fiyat);
            this.panel1.Controls.Add(this.txt_aracTürü);
            this.panel1.Controls.Add(this.txt_marka);
            this.panel1.Location = new System.Drawing.Point(12, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(506, 199);
            this.panel1.TabIndex = 10;
            // 
            // Ilan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1209, 423);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.No;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Ilan";
            this.Text = "Ilan";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.TextBox txt_marka;
        private System.Windows.Forms.TextBox txt_fiyat;
        private System.Windows.Forms.TextBox txt_aracTürü;
        private System.Windows.Forms.Label lbl_marka;
        private System.Windows.Forms.Label lbl_model;
        private System.Windows.Forms.Label lbl_türü;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Panel panel1;
    }
}