namespace ProjeNesneNew2
{
    partial class FormUcgenMi
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
            this.lblTamsayi1 = new System.Windows.Forms.Label();
            this.lblTamSayi2 = new System.Windows.Forms.Label();
            this.lblTamSayi3 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.tboxTamSayi1 = new System.Windows.Forms.TextBox();
            this.tBoxTamsayi2 = new System.Windows.Forms.TextBox();
            this.tBoxTamSayi3 = new System.Windows.Forms.TextBox();
            this.btnUcgenMi = new System.Windows.Forms.Button();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTamsayi1
            // 
            this.lblTamsayi1.AutoSize = true;
            this.lblTamsayi1.Location = new System.Drawing.Point(12, 142);
            this.lblTamsayi1.Name = "lblTamsayi1";
            this.lblTamsayi1.Size = new System.Drawing.Size(76, 20);
            this.lblTamsayi1.TabIndex = 0;
            this.lblTamsayi1.Text = "1.Tam sayı";
            // 
            // lblTamSayi2
            // 
            this.lblTamSayi2.AutoSize = true;
            this.lblTamSayi2.Location = new System.Drawing.Point(12, 192);
            this.lblTamSayi2.Name = "lblTamSayi2";
            this.lblTamSayi2.Size = new System.Drawing.Size(76, 20);
            this.lblTamSayi2.TabIndex = 1;
            this.lblTamSayi2.Text = "2.Tam sayı";
            // 
            // lblTamSayi3
            // 
            this.lblTamSayi3.AutoSize = true;
            this.lblTamSayi3.Location = new System.Drawing.Point(12, 242);
            this.lblTamSayi3.Name = "lblTamSayi3";
            this.lblTamSayi3.Size = new System.Drawing.Size(76, 20);
            this.lblTamSayi3.TabIndex = 2;
            this.lblTamSayi3.Text = "3.Tam sayı";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(89, 80);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(164, 20);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Üç adet tam sayı giriniz";
            // 
            // tboxTamSayi1
            // 
            this.tboxTamSayi1.Location = new System.Drawing.Point(106, 135);
            this.tboxTamSayi1.Name = "tboxTamSayi1";
            this.tboxTamSayi1.Size = new System.Drawing.Size(200, 27);
            this.tboxTamSayi1.TabIndex = 4;
            this.tboxTamSayi1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tboxTamSayi1_KeyPress);
            // 
            // tBoxTamsayi2
            // 
            this.tBoxTamsayi2.Location = new System.Drawing.Point(106, 189);
            this.tBoxTamsayi2.Name = "tBoxTamsayi2";
            this.tBoxTamsayi2.Size = new System.Drawing.Size(200, 27);
            this.tBoxTamsayi2.TabIndex = 5;
            this.tBoxTamsayi2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBoxTamsayi2_KeyPress);
            // 
            // tBoxTamSayi3
            // 
            this.tBoxTamSayi3.Location = new System.Drawing.Point(106, 239);
            this.tBoxTamSayi3.Name = "tBoxTamSayi3";
            this.tBoxTamSayi3.Size = new System.Drawing.Size(200, 27);
            this.tBoxTamSayi3.TabIndex = 6;
            this.tBoxTamSayi3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBoxTamSayi3_KeyPress);
            // 
            // btnUcgenMi
            // 
            this.btnUcgenMi.Location = new System.Drawing.Point(12, 303);
            this.btnUcgenMi.Name = "btnUcgenMi";
            this.btnUcgenMi.Size = new System.Drawing.Size(308, 29);
            this.btnUcgenMi.TabIndex = 7;
            this.btnUcgenMi.Text = "Üçgen mi ?";
            this.btnUcgenMi.UseVisualStyleBackColor = true;
            this.btnUcgenMi.Click += new System.EventHandler(this.btnUcgenMi_Click);
            // 
            // lblSonuc
            // 
            this.lblSonuc.Location = new System.Drawing.Point(12, 364);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(308, 51);
            this.lblSonuc.TabIndex = 8;
            this.lblSonuc.Text = "SONUÇ";
            this.lblSonuc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormUcgenMi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 453);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.btnUcgenMi);
            this.Controls.Add(this.tBoxTamSayi3);
            this.Controls.Add(this.tBoxTamsayi2);
            this.Controls.Add(this.tboxTamSayi1);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblTamSayi3);
            this.Controls.Add(this.lblTamSayi2);
            this.Controls.Add(this.lblTamsayi1);
            this.MaximizeBox = false;
            this.Name = "FormUcgenMi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Üçgen Hesaplama";
           
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTamsayi1;
        private Label lblTamSayi2;
        private Label lblTamSayi3;
        private Label lblName;
        private TextBox tboxTamSayi1;
        private TextBox tBoxTamsayi2;
        private TextBox tBoxTamSayi3;
        private Button btnUcgenMi;
        private Label lblSonuc;
    }
}