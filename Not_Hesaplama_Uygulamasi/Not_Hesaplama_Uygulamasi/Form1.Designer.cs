namespace Not_Hesaplama_Uygulamasi
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_BirinciNot = new System.Windows.Forms.TextBox();
            this.txt_IkinciNot = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_hesaplama = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_OrtSonuc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(61, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "1.Sınav Notunuz :";
            // 
            // txt_BirinciNot
            // 
            this.txt_BirinciNot.Location = new System.Drawing.Point(208, 88);
            this.txt_BirinciNot.Multiline = true;
            this.txt_BirinciNot.Name = "txt_BirinciNot";
            this.txt_BirinciNot.Size = new System.Drawing.Size(179, 21);
            this.txt_BirinciNot.TabIndex = 1;
            // 
            // txt_IkinciNot
            // 
            this.txt_IkinciNot.Location = new System.Drawing.Point(208, 115);
            this.txt_IkinciNot.Multiline = true;
            this.txt_IkinciNot.Name = "txt_IkinciNot";
            this.txt_IkinciNot.Size = new System.Drawing.Size(179, 21);
            this.txt_IkinciNot.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(61, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "2..Sınav Notunuz :";
            // 
            // btn_hesaplama
            // 
            this.btn_hesaplama.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_hesaplama.Location = new System.Drawing.Point(64, 150);
            this.btn_hesaplama.Name = "btn_hesaplama";
            this.btn_hesaplama.Size = new System.Drawing.Size(143, 41);
            this.btn_hesaplama.TabIndex = 4;
            this.btn_hesaplama.Text = "Hesaplama";
            this.btn_hesaplama.UseVisualStyleBackColor = true;
            this.btn_hesaplama.Click += new System.EventHandler(this.btn_hesaplama_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(222, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ortalama:";
            // 
            // lbl_OrtSonuc
            // 
            this.lbl_OrtSonuc.AutoSize = true;
            this.lbl_OrtSonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_OrtSonuc.Location = new System.Drawing.Point(310, 160);
            this.lbl_OrtSonuc.Name = "lbl_OrtSonuc";
            this.lbl_OrtSonuc.Size = new System.Drawing.Size(17, 18);
            this.lbl_OrtSonuc.TabIndex = 6;
            this.lbl_OrtSonuc.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 277);
            this.Controls.Add(this.lbl_OrtSonuc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_hesaplama);
            this.Controls.Add(this.txt_IkinciNot);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_BirinciNot);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_BirinciNot;
        private System.Windows.Forms.TextBox txt_IkinciNot;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_hesaplama;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_OrtSonuc;
    }
}

