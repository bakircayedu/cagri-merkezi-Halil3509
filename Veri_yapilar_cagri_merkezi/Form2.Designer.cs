
namespace Veri_yapilar_cagri_merkezi
{
    partial class Form2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.txtarama = new System.Windows.Forms.TextBox();
            this.lboxAlinanNotlar = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lboxGunlukRapor = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnAra);
            this.groupBox1.Controls.Add(this.txtarama);
            this.groupBox1.Controls.Add(this.lboxAlinanNotlar);
            this.groupBox1.Location = new System.Drawing.Point(43, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(387, 490);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alınan Notlar";
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(204, 55);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(75, 23);
            this.btnAra.TabIndex = 2;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // txtarama
            // 
            this.txtarama.Location = new System.Drawing.Point(20, 55);
            this.txtarama.Name = "txtarama";
            this.txtarama.Size = new System.Drawing.Size(145, 20);
            this.txtarama.TabIndex = 1;
            // 
            // lboxAlinanNotlar
            // 
            this.lboxAlinanNotlar.FormattingEnabled = true;
            this.lboxAlinanNotlar.Location = new System.Drawing.Point(20, 115);
            this.lboxAlinanNotlar.Name = "lboxAlinanNotlar";
            this.lboxAlinanNotlar.Size = new System.Drawing.Size(341, 355);
            this.lboxAlinanNotlar.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lboxGunlukRapor);
            this.groupBox2.Location = new System.Drawing.Point(579, 41);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(389, 470);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Günlük Bilgiler";
            // 
            // lboxGunlukRapor
            // 
            this.lboxGunlukRapor.FormattingEnabled = true;
            this.lboxGunlukRapor.Location = new System.Drawing.Point(24, 44);
            this.lboxGunlukRapor.Name = "lboxGunlukRapor";
            this.lboxGunlukRapor.Size = new System.Drawing.Size(341, 394);
            this.lboxGunlukRapor.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tek karakter için(-) birden fazla karakter (*) başına giriniz\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 582);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "Notlar";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.TextBox txtarama;
        private System.Windows.Forms.ListBox lboxAlinanNotlar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lboxGunlukRapor;
        private System.Windows.Forms.Label label1;
    }
}