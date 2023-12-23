
namespace Dershane_Etut_Proje
{
    partial class Ders_Islemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ders_Islemleri));
            this.SinifEkle = new System.Windows.Forms.Button();
            this.SubeEkle = new System.Windows.Forms.Button();
            this.DersEkle = new System.Windows.Forms.Button();
            this.DenemeEkle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // SinifEkle
            // 
            this.SinifEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SinifEkle.Location = new System.Drawing.Point(105, 199);
            this.SinifEkle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SinifEkle.Name = "SinifEkle";
            this.SinifEkle.Size = new System.Drawing.Size(139, 42);
            this.SinifEkle.TabIndex = 11;
            this.SinifEkle.Text = "EKLE";
            this.SinifEkle.UseVisualStyleBackColor = true;
            this.SinifEkle.Visible = false;
            this.SinifEkle.Click += new System.EventHandler(this.SinifEkle_Click);
            // 
            // SubeEkle
            // 
            this.SubeEkle.Location = new System.Drawing.Point(105, 199);
            this.SubeEkle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SubeEkle.Name = "SubeEkle";
            this.SubeEkle.Size = new System.Drawing.Size(139, 42);
            this.SubeEkle.TabIndex = 10;
            this.SubeEkle.Text = "EKLE";
            this.SubeEkle.UseVisualStyleBackColor = true;
            this.SubeEkle.Visible = false;
            this.SubeEkle.Click += new System.EventHandler(this.SubeEkle_Click);
            // 
            // DersEkle
            // 
            this.DersEkle.Location = new System.Drawing.Point(105, 199);
            this.DersEkle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DersEkle.Name = "DersEkle";
            this.DersEkle.Size = new System.Drawing.Size(139, 42);
            this.DersEkle.TabIndex = 9;
            this.DersEkle.Text = "EKLE";
            this.DersEkle.UseVisualStyleBackColor = true;
            this.DersEkle.Visible = false;
            this.DersEkle.Click += new System.EventHandler(this.DersEkle_Click);
            // 
            // DenemeEkle
            // 
            this.DenemeEkle.Location = new System.Drawing.Point(105, 199);
            this.DenemeEkle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DenemeEkle.Name = "DenemeEkle";
            this.DenemeEkle.Size = new System.Drawing.Size(139, 42);
            this.DenemeEkle.TabIndex = 8;
            this.DenemeEkle.Text = "EKLE";
            this.DenemeEkle.UseVisualStyleBackColor = true;
            this.DenemeEkle.Visible = false;
            this.DenemeEkle.Click += new System.EventHandler(this.DenemeEkle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ad Giriniz";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(123, 101);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 22);
            this.textBox1.TabIndex = 6;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(434, 84);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(196, 172);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 86;
            this.pictureBox3.TabStop = false;
            // 
            // Ders_Islemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.SinifEkle);
            this.Controls.Add(this.SubeEkle);
            this.Controls.Add(this.DersEkle);
            this.Controls.Add(this.DenemeEkle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Ders_Islemleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ders_Islemleri";
            this.Load += new System.EventHandler(this.Ders_Islemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SinifEkle;
        private System.Windows.Forms.Button SubeEkle;
        private System.Windows.Forms.Button DersEkle;
        private System.Windows.Forms.Button DenemeEkle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}