namespace sicaklik
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtGiris = new TextBox();
            label1 = new Label();
            btnCevir = new Button();
            label2 = new Label();
            lblFah = new Label();
            btnTemizle = new Button();
            SuspendLayout();
            // 
            // txtGiris
            // 
            txtGiris.Location = new Point(102, 99);
            txtGiris.Name = "txtGiris";
            txtGiris.Size = new Size(100, 23);
            txtGiris.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 102);
            label1.Name = "label1";
            label1.Size = new Size(74, 15);
            label1.TabIndex = 1;
            label1.Text = "Sıcaklık (C) : ";
            // 
            // btnCevir
            // 
            btnCevir.Location = new Point(42, 128);
            btnCevir.Name = "btnCevir";
            btnCevir.Size = new Size(75, 23);
            btnCevir.TabIndex = 2;
            btnCevir.Text = "Çevir";
            btnCevir.UseVisualStyleBackColor = true;
            btnCevir.Click += btnCevir_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(250, 106);
            label2.Name = "label2";
            label2.Size = new Size(86, 15);
            label2.TabIndex = 3;
            label2.Text = "Fahrenheit (F) :";
            // 
            // lblFah
            // 
            lblFah.AutoSize = true;
            lblFah.Location = new Point(342, 106);
            lblFah.Name = "lblFah";
            lblFah.Size = new Size(17, 15);
            lblFah.TabIndex = 4;
            lblFah.Text = "xx";
            // 
            // btnTemizle
            // 
            btnTemizle.Location = new Point(123, 128);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(75, 23);
            btnTemizle.TabIndex = 5;
            btnTemizle.Text = "Temizle";
            btnTemizle.UseVisualStyleBackColor = true;
            btnTemizle.Click += btnTemizle_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnTemizle);
            Controls.Add(lblFah);
            Controls.Add(label2);
            Controls.Add(btnCevir);
            Controls.Add(label1);
            Controls.Add(txtGiris);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtGiris;
        private Label label1;
        private Button btnCevir;
        private Label label2;
        private Label lblFah;
        private Button btnTemizle;
    }
}
