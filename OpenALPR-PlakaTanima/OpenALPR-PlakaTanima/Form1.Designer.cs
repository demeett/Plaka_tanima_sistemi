namespace PlakaTanima
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
            this.picOriginResim = new System.Windows.Forms.PictureBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.txtPlaka = new System.Windows.Forms.TextBox();
            this.picPlakaResmi = new System.Windows.Forms.PictureBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.KontrolClick = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picOriginResim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlakaResmi)).BeginInit();
            this.SuspendLayout();
            // 
            // picOriginResim
            // 
            this.picOriginResim.Location = new System.Drawing.Point(19, 41);
            this.picOriginResim.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.picOriginResim.Name = "picOriginResim";
            this.picOriginResim.Size = new System.Drawing.Size(343, 345);
            this.picOriginResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picOriginResim.TabIndex = 0;
            this.picOriginResim.TabStop = false;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(442, 41);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(73, 21);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Avrupa";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(581, 41);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(84, 21);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Amerika";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.button1.Location = new System.Drawing.Point(442, 77);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(236, 37);
            this.button1.TabIndex = 3;
            this.button1.Text = "Resim Seç";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPlaka
            // 
            this.txtPlaka.Location = new System.Drawing.Point(442, 160);
            this.txtPlaka.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtPlaka.Name = "txtPlaka";
            this.txtPlaka.Size = new System.Drawing.Size(236, 22);
            this.txtPlaka.TabIndex = 4;
            this.txtPlaka.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // picPlakaResmi
            // 
            this.picPlakaResmi.Location = new System.Drawing.Point(445, 246);
            this.picPlakaResmi.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.picPlakaResmi.Name = "picPlakaResmi";
            this.picPlakaResmi.Size = new System.Drawing.Size(233, 141);
            this.picPlakaResmi.TabIndex = 5;
            this.picPlakaResmi.TabStop = false;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Resim";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(442, 129);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Bulunan Plaka";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(442, 217);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Plaka Resmi";
            // 
            // KontrolClick
            // 
            this.KontrolClick.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.KontrolClick.Location = new System.Drawing.Point(753, 153);
            this.KontrolClick.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.KontrolClick.Name = "KontrolClick";
            this.KontrolClick.Size = new System.Drawing.Size(152, 37);
            this.KontrolClick.TabIndex = 9;
            this.KontrolClick.Text = "Kontrol Et";
            this.KontrolClick.UseVisualStyleBackColor = false;
            this.KontrolClick.Click += new System.EventHandler(this.KontrolClick_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.button3.Location = new System.Drawing.Point(753, 77);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(152, 35);
            this.button3.TabIndex = 10;
            this.button3.Text = "Plaka Kaydet";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(919, 548);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.KontrolClick);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picPlakaResmi);
            this.Controls.Add(this.txtPlaka);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.picOriginResim);
            this.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.MenuText;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form1";
            this.Text = "Plaka Tanıma";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picOriginResim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlakaResmi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picOriginResim;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtPlaka;
        private System.Windows.Forms.PictureBox picPlakaResmi;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button KontrolClick;
        private System.Windows.Forms.Button button3;
    }
}

