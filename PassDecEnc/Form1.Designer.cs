namespace PassDecEnc
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
            this.btn_Enc = new System.Windows.Forms.Button();
            this.btn_Dec = new System.Windows.Forms.Button();
            this.txt_EncText = new System.Windows.Forms.TextBox();
            this.lbl_crypted = new System.Windows.Forms.Label();
            this.lbl_cipher = new System.Windows.Forms.Label();
            this.lbl_dcr = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Enc
            // 
            this.btn_Enc.Location = new System.Drawing.Point(125, 38);
            this.btn_Enc.Name = "btn_Enc";
            this.btn_Enc.Size = new System.Drawing.Size(75, 23);
            this.btn_Enc.TabIndex = 0;
            this.btn_Enc.Text = "Enc";
            this.btn_Enc.UseVisualStyleBackColor = true;
            this.btn_Enc.Click += new System.EventHandler(this.btn_Enc_Click);
            // 
            // btn_Dec
            // 
            this.btn_Dec.Location = new System.Drawing.Point(125, 122);
            this.btn_Dec.Name = "btn_Dec";
            this.btn_Dec.Size = new System.Drawing.Size(75, 23);
            this.btn_Dec.TabIndex = 1;
            this.btn_Dec.Text = "Dec";
            this.btn_Dec.UseVisualStyleBackColor = true;
            this.btn_Dec.Click += new System.EventHandler(this.btn_Dec_Click);
            // 
            // txt_EncText
            // 
            this.txt_EncText.Location = new System.Drawing.Point(12, 12);
            this.txt_EncText.Name = "txt_EncText";
            this.txt_EncText.Size = new System.Drawing.Size(188, 20);
            this.txt_EncText.TabIndex = 2;
            // 
            // lbl_crypted
            // 
            this.lbl_crypted.AutoSize = true;
            this.lbl_crypted.Location = new System.Drawing.Point(9, 70);
            this.lbl_crypted.Name = "lbl_crypted";
            this.lbl_crypted.Size = new System.Drawing.Size(67, 13);
            this.lbl_crypted.TabIndex = 3;
            this.lbl_crypted.Text = "Crypted Text";
            // 
            // lbl_cipher
            // 
            this.lbl_cipher.AutoSize = true;
            this.lbl_cipher.Location = new System.Drawing.Point(9, 93);
            this.lbl_cipher.Name = "lbl_cipher";
            this.lbl_cipher.Size = new System.Drawing.Size(61, 13);
            this.lbl_cipher.TabIndex = 4;
            this.lbl_cipher.Text = "Cipher Text";
            // 
            // lbl_dcr
            // 
            this.lbl_dcr.AutoSize = true;
            this.lbl_dcr.Location = new System.Drawing.Point(9, 122);
            this.lbl_dcr.Name = "lbl_dcr";
            this.lbl_dcr.Size = new System.Drawing.Size(80, 13);
            this.lbl_dcr.TabIndex = 5;
            this.lbl_dcr.Text = "Decrypted Text";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(212, 191);
            this.Controls.Add(this.lbl_dcr);
            this.Controls.Add(this.lbl_cipher);
            this.Controls.Add(this.lbl_crypted);
            this.Controls.Add(this.txt_EncText);
            this.Controls.Add(this.btn_Dec);
            this.Controls.Add(this.btn_Enc);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Enc;
        private System.Windows.Forms.Button btn_Dec;
        private System.Windows.Forms.TextBox txt_EncText;
        private System.Windows.Forms.Label lbl_crypted;
        private System.Windows.Forms.Label lbl_cipher;
        private System.Windows.Forms.Label lbl_dcr;
    }
}

