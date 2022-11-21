
namespace filtredeneme
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnGri = new System.Windows.Forms.Button();
            this.btnsiyahbeyaz = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::filtredeneme.Properties.Resources.Angelina_Jolie_2_June_2014__cropped_;
            this.pictureBox1.Location = new System.Drawing.Point(1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(838, 1173);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnGri
            // 
            this.btnGri.Location = new System.Drawing.Point(848, 23);
            this.btnGri.Name = "btnGri";
            this.btnGri.Size = new System.Drawing.Size(75, 23);
            this.btnGri.TabIndex = 1;
            this.btnGri.Text = "GrayScale";
            this.btnGri.UseVisualStyleBackColor = true;
            this.btnGri.Click += new System.EventHandler(this.btnGri_Click);
            // 
            // btnsiyahbeyaz
            // 
            this.btnsiyahbeyaz.Location = new System.Drawing.Point(848, 63);
            this.btnsiyahbeyaz.Name = "btnsiyahbeyaz";
            this.btnsiyahbeyaz.Size = new System.Drawing.Size(75, 23);
            this.btnsiyahbeyaz.TabIndex = 2;
            this.btnsiyahbeyaz.Text = "SiyahBeyaz";
            this.btnsiyahbeyaz.UseVisualStyleBackColor = true;
            this.btnsiyahbeyaz.Click += new System.EventHandler(this.btnsiyahbeyaz_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 749);
            this.Controls.Add(this.btnsiyahbeyaz);
            this.Controls.Add(this.btnGri);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnGri;
        private System.Windows.Forms.Button btnsiyahbeyaz;
    }
}

