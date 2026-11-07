namespace WinFormsApp1
{
    partial class sa
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
            btnEvet = new Button();
            btnHayir = new Button();
            label1 = new Label();
            txtYas = new TextBox();
            SuspendLayout();
            // 
            // btnEvet
            // 
            btnEvet.BackColor = Color.FromArgb(255, 255, 128);
            btnEvet.ForeColor = SystemColors.ActiveCaption;
            btnEvet.Location = new Point(435, 181);
            btnEvet.Name = "btnEvet";
            btnEvet.Size = new Size(75, 23);
            btnEvet.TabIndex = 0;
            btnEvet.Text = "evet";
            btnEvet.UseVisualStyleBackColor = false;
            btnEvet.Click += btnEvet_Click;
            // 
            // btnHayir
            // 
            btnHayir.BackColor = Color.FromArgb(255, 255, 128);
            btnHayir.ForeColor = SystemColors.ActiveCaption;
            btnHayir.Location = new Point(421, 318);
            btnHayir.Name = "btnHayir";
            btnHayir.Size = new Size(75, 23);
            btnHayir.TabIndex = 0;
            btnHayir.Text = "Hayır";
            btnHayir.UseVisualStyleBackColor = false;
            btnHayir.Click += btnHayir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(502, 134);
            label1.Name = "label1";
            label1.Size = new Size(45, 25);
            label1.TabIndex = 1;
            label1.Text = "XXX";
            // 
            // txtYas
            // 
            txtYas.Location = new Point(340, 139);
            txtYas.Name = "txtYas";
            txtYas.Size = new Size(138, 23);
            txtYas.TabIndex = 2;
            txtYas.TextChanged += txtYas_TextChanged;
            // 
            // sa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 255);
            ClientSize = new Size(981, 527);
            Controls.Add(txtYas);
            Controls.Add(label1);
            Controls.Add(btnHayir);
            Controls.Add(btnEvet);
            Name = "sa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "sa";
            Load += sa_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEvet;
        private Button btnHayir;
        private Label label1;
        private TextBox txtYas;
    }
}
