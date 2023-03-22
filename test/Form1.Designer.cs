namespace test
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxtDkdrtgnUk = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtDkdrtgnKk = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtCmbrCap = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtDkdtgnA = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtDkdrtgnC = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtCmbrA = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtCmbrC = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(60, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dikdörtgen";
            // 
            // TxtDkdrtgnUk
            // 
            this.TxtDkdrtgnUk.Location = new System.Drawing.Point(131, 103);
            this.TxtDkdrtgnUk.Name = "TxtDkdrtgnUk";
            this.TxtDkdrtgnUk.Size = new System.Drawing.Size(100, 31);
            this.TxtDkdrtgnUk.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Uzun Kenar:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(20, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kısa Kenar:";
            // 
            // TxtDkdrtgnKk
            // 
            this.TxtDkdrtgnKk.Location = new System.Drawing.Point(131, 154);
            this.TxtDkdrtgnKk.Name = "TxtDkdrtgnKk";
            this.TxtDkdrtgnKk.Size = new System.Drawing.Size(100, 31);
            this.TxtDkdrtgnKk.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Corbel", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(542, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 33);
            this.label4.TabIndex = 5;
            this.label4.Text = "Çember";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(487, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 23);
            this.label5.TabIndex = 7;
            this.label5.Text = "Yarı Çapı:";
            // 
            // TxtCmbrCap
            // 
            this.TxtCmbrCap.Location = new System.Drawing.Point(600, 98);
            this.TxtCmbrCap.Name = "TxtCmbrCap";
            this.TxtCmbrCap.Size = new System.Drawing.Size(100, 31);
            this.TxtCmbrCap.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(131, 226);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 31);
            this.button2.TabIndex = 9;
            this.button2.Text = "Hesapla";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(71, 311);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 23);
            this.label6.TabIndex = 11;
            this.label6.Text = "Alan:";
            // 
            // TxtDkdtgnA
            // 
            this.TxtDkdtgnA.Location = new System.Drawing.Point(131, 308);
            this.TxtDkdtgnA.Name = "TxtDkdtgnA";
            this.TxtDkdtgnA.Size = new System.Drawing.Size(100, 31);
            this.TxtDkdtgnA.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(62, 369);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 23);
            this.label7.TabIndex = 13;
            this.label7.Text = "Çevre:";
            // 
            // TxtDkdrtgnC
            // 
            this.TxtDkdrtgnC.Location = new System.Drawing.Point(131, 366);
            this.TxtDkdrtgnC.Name = "TxtDkdrtgnC";
            this.TxtDkdrtgnC.Size = new System.Drawing.Size(100, 31);
            this.TxtDkdrtgnC.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(540, 311);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 23);
            this.label8.TabIndex = 15;
            this.label8.Text = "Alan:";
            // 
            // TxtCmbrA
            // 
            this.TxtCmbrA.Location = new System.Drawing.Point(600, 308);
            this.TxtCmbrA.Name = "TxtCmbrA";
            this.TxtCmbrA.Size = new System.Drawing.Size(100, 31);
            this.TxtCmbrA.TabIndex = 14;
            this.TxtCmbrA.TextChanged += new System.EventHandler(this.TxtCmbrA_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(531, 364);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 23);
            this.label9.TabIndex = 17;
            this.label9.Text = "Çevre:";
            // 
            // TxtCmbrC
            // 
            this.TxtCmbrC.Location = new System.Drawing.Point(600, 361);
            this.TxtCmbrC.Name = "TxtCmbrC";
            this.TxtCmbrC.Size = new System.Drawing.Size(100, 31);
            this.TxtCmbrC.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(600, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 31);
            this.button1.TabIndex = 18;
            this.button1.Text = "Hesapla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 458);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TxtCmbrC);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TxtCmbrA);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxtDkdrtgnC);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtDkdtgnA);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtCmbrCap);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtDkdrtgnKk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtDkdrtgnUk);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.Text = "alan ve çevre hesaplama";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtDkdrtgnUk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtDkdrtgnKk;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtCmbrCap;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtDkdtgnA;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtDkdrtgnC;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtCmbrA;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtCmbrC;
        private System.Windows.Forms.Button button1;
    }
}

