namespace ProjeNesneNew2
{
    partial class FormTasKagitMakas
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
            this.comBoxSecim1 = new System.Windows.Forms.ComboBox();
            this.lblName = new System.Windows.Forms.Label();
            this.comBoxSecim2 = new System.Windows.Forms.ComboBox();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.lblSecim1 = new System.Windows.Forms.Label();
            this.lblSecim2 = new System.Windows.Forms.Label();
            this.btnKazanan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comBoxSecim1
            // 
            this.comBoxSecim1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxSecim1.FormattingEnabled = true;
            this.comBoxSecim1.Items.AddRange(new object[] {
            "Bir işlem seçiniz",
            "Taş ",
            "Kağıt",
            "Makas"});
            this.comBoxSecim1.Location = new System.Drawing.Point(109, 159);
            this.comBoxSecim1.Name = "comBoxSecim1";
            this.comBoxSecim1.Size = new System.Drawing.Size(200, 28);
            this.comBoxSecim1.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(12, 44);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(308, 85);
            this.lblName.TabIndex = 13;
            this.lblName.Text = "Taş Kağıt Makas\r\n";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comBoxSecim2
            // 
            this.comBoxSecim2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxSecim2.FormattingEnabled = true;
            this.comBoxSecim2.Items.AddRange(new object[] {
            "Bir işlem seçiniz",
            "Taş ",
            "Kağıt",
            "Makas"});
            this.comBoxSecim2.Location = new System.Drawing.Point(109, 227);
            this.comBoxSecim2.Name = "comBoxSecim2";
            this.comBoxSecim2.Size = new System.Drawing.Size(200, 28);
            this.comBoxSecim2.TabIndex = 14;
            // 
            // lblSonuc
            // 
            this.lblSonuc.Location = new System.Drawing.Point(3, 357);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(308, 51);
            this.lblSonuc.TabIndex = 15;
            this.lblSonuc.Text = "SONUÇ";
            this.lblSonuc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSecim1
            // 
            this.lblSecim1.AutoSize = true;
            this.lblSecim1.Location = new System.Drawing.Point(3, 167);
            this.lblSecim1.Name = "lblSecim1";
            this.lblSecim1.Size = new System.Drawing.Size(64, 20);
            this.lblSecim1.TabIndex = 16;
            this.lblSecim1.Text = "1. Seçim";
            // 
            // lblSecim2
            // 
            this.lblSecim2.AutoSize = true;
            this.lblSecim2.Location = new System.Drawing.Point(3, 227);
            this.lblSecim2.Name = "lblSecim2";
            this.lblSecim2.Size = new System.Drawing.Size(64, 20);
            this.lblSecim2.TabIndex = 17;
            this.lblSecim2.Text = "2. Seçim";
            // 
            // btnKazanan
            // 
            this.btnKazanan.Location = new System.Drawing.Point(12, 291);
            this.btnKazanan.Name = "btnKazanan";
            this.btnKazanan.Size = new System.Drawing.Size(308, 29);
            this.btnKazanan.TabIndex = 18;
            this.btnKazanan.Text = "KAZANAN";
            this.btnKazanan.UseVisualStyleBackColor = true;
            this.btnKazanan.Click += new System.EventHandler(this.btnKazanan_Click);
            // 
            // FormTasKagitMakas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 453);
            this.Controls.Add(this.btnKazanan);
            this.Controls.Add(this.lblSecim2);
            this.Controls.Add(this.lblSecim1);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.comBoxSecim2);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.comBoxSecim1);
            this.MaximizeBox = false;
            this.Name = "FormTasKagitMakas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Taş-Kağıt-Makas";
            this.Load += new System.EventHandler(this.FormTasKagitMakas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox comBoxSecim1;
        private Label lblName;
        private ComboBox comBoxSecim2;
        private Label lblSonuc;
        private Label lblSecim1;
        private Label lblSecim2;
        private Button btnKazanan;
    }
}