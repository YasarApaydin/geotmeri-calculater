namespace WindowsFormsApp4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxKenar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBoxUzunKenar = new System.Windows.Forms.TextBox();
            this.textBoxKisaKenar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBoxYaricap = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.labelKare = new System.Windows.Forms.Label();
            this.labelDikdortgen = new System.Windows.Forms.Label();
            this.labelCember = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.Location = new System.Drawing.Point(204, 418);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(439, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "ALAN HESAPLA";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(849, 136);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(170, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(405, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "Geometri Calculator";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel2.Controls.Add(this.labelKare);
            this.panel2.Controls.Add(this.textBoxKenar);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(2, 137);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(298, 258);
            this.panel2.TabIndex = 3;
            // 
            // textBoxKenar
            // 
            this.textBoxKenar.Location = new System.Drawing.Point(143, 132);
            this.textBoxKenar.Name = "textBoxKenar";
            this.textBoxKenar.Size = new System.Drawing.Size(100, 22);
            this.textBoxKenar.TabIndex = 2;
            this.textBoxKenar.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kenar (m):";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp4.Properties.Resources.download;
            this.pictureBox1.Location = new System.Drawing.Point(31, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(207, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Controls.Add(this.labelDikdortgen);
            this.panel3.Controls.Add(this.textBoxUzunKenar);
            this.panel3.Controls.Add(this.textBoxKisaKenar);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Location = new System.Drawing.Point(306, 137);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(292, 258);
            this.panel3.TabIndex = 4;
            // 
            // textBoxUzunKenar
            // 
            this.textBoxUzunKenar.Location = new System.Drawing.Point(173, 164);
            this.textBoxUzunKenar.Name = "textBoxUzunKenar";
            this.textBoxUzunKenar.Size = new System.Drawing.Size(100, 22);
            this.textBoxUzunKenar.TabIndex = 9;
            this.textBoxUzunKenar.Text = "0";
            // 
            // textBoxKisaKenar
            // 
            this.textBoxKisaKenar.Location = new System.Drawing.Point(173, 132);
            this.textBoxKisaKenar.Name = "textBoxKisaKenar";
            this.textBoxKisaKenar.Size = new System.Drawing.Size(100, 22);
            this.textBoxKisaKenar.TabIndex = 8;
            this.textBoxKisaKenar.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Uzun Kenar:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Kısa kenar:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(52, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(202, 98);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel4.Controls.Add(this.labelCember);
            this.panel4.Controls.Add(this.textBoxYaricap);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.pictureBox3);
            this.panel4.Location = new System.Drawing.Point(604, 137);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(246, 258);
            this.panel4.TabIndex = 5;
            // 
            // textBoxYaricap
            // 
            this.textBoxYaricap.Location = new System.Drawing.Point(111, 136);
            this.textBoxYaricap.Name = "textBoxYaricap";
            this.textBoxYaricap.Size = new System.Drawing.Size(100, 22);
            this.textBoxYaricap.TabIndex = 2;
            this.textBoxYaricap.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Yarıçap:";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(69, 6);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(104, 98);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // labelKare
            // 
            this.labelKare.AutoSize = true;
            this.labelKare.Location = new System.Drawing.Point(120, 211);
            this.labelKare.Name = "labelKare";
            this.labelKare.Size = new System.Drawing.Size(14, 16);
            this.labelKare.TabIndex = 3;
            this.labelKare.Text = "0";
            // 
            // labelDikdortgen
            // 
            this.labelDikdortgen.AutoSize = true;
            this.labelDikdortgen.Location = new System.Drawing.Point(132, 212);
            this.labelDikdortgen.Name = "labelDikdortgen";
            this.labelDikdortgen.Size = new System.Drawing.Size(14, 16);
            this.labelDikdortgen.TabIndex = 10;
            this.labelDikdortgen.Text = "0";
            // 
            // labelCember
            // 
            this.labelCember.AutoSize = true;
            this.labelCember.Location = new System.Drawing.Point(101, 211);
            this.labelCember.Name = "labelCember";
            this.labelCember.Size = new System.Drawing.Size(14, 16);
            this.labelCember.TabIndex = 3;
            this.labelCember.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 526);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Geometri Hesaplayıcı";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxKenar;
        private System.Windows.Forms.TextBox textBoxUzunKenar;
        private System.Windows.Forms.TextBox textBoxKisaKenar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxYaricap;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelKare;
        private System.Windows.Forms.Label labelDikdortgen;
        private System.Windows.Forms.Label labelCember;
    }
}

