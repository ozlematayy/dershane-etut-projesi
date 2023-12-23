
namespace Dershane_Etut_Proje
{
    partial class SubeGuncelle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubeGuncelle));
            this.SinifEkle = new System.Windows.Forms.Button();
            this.SubeEkle = new System.Windows.Forms.Button();
            this.DersEkle = new System.Windows.Forms.Button();
            this.DenemeEkle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SinifEkle
            // 
            this.SinifEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SinifEkle.Location = new System.Drawing.Point(117, 191);
            this.SinifEkle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SinifEkle.Name = "SinifEkle";
            this.SinifEkle.Size = new System.Drawing.Size(139, 42);
            this.SinifEkle.TabIndex = 17;
            this.SinifEkle.Text = "Guncelle";
            this.SinifEkle.UseVisualStyleBackColor = true;
            this.SinifEkle.Click += new System.EventHandler(this.SinifEkle_Click);
            // 
            // SubeEkle
            // 
            this.SubeEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubeEkle.Location = new System.Drawing.Point(117, 191);
            this.SubeEkle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SubeEkle.Name = "SubeEkle";
            this.SubeEkle.Size = new System.Drawing.Size(139, 42);
            this.SubeEkle.TabIndex = 16;
            this.SubeEkle.Text = "EKLE";
            this.SubeEkle.UseVisualStyleBackColor = true;
            this.SubeEkle.Visible = false;
            // 
            // DersEkle
            // 
            this.DersEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DersEkle.Location = new System.Drawing.Point(117, 191);
            this.DersEkle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DersEkle.Name = "DersEkle";
            this.DersEkle.Size = new System.Drawing.Size(139, 42);
            this.DersEkle.TabIndex = 15;
            this.DersEkle.Text = "EKLE";
            this.DersEkle.UseVisualStyleBackColor = true;
            this.DersEkle.Visible = false;
            this.DersEkle.Click += new System.EventHandler(this.DersEkle_Click);
            // 
            // DenemeEkle
            // 
            this.DenemeEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DenemeEkle.Location = new System.Drawing.Point(117, 191);
            this.DenemeEkle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DenemeEkle.Name = "DenemeEkle";
            this.DenemeEkle.Size = new System.Drawing.Size(139, 42);
            this.DenemeEkle.TabIndex = 14;
            this.DenemeEkle.Text = "EKLE";
            this.DenemeEkle.UseVisualStyleBackColor = true;
            this.DenemeEkle.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "ŞUBE GÜNCELLEME";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(117, 92);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 22);
            this.textBox1.TabIndex = 12;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(117, 138);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(121, 22);
            this.textBox3.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "Eski Şube:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "Yeni Şube:";
            // 
            // SubeGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(373, 377);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.SinifEkle);
            this.Controls.Add(this.SubeEkle);
            this.Controls.Add(this.DersEkle);
            this.Controls.Add(this.DenemeEkle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SubeGuncelle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sinif_SubeGuncelle";
            this.Load += new System.EventHandler(this.SubeGuncelle_Load);
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
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}