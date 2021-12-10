namespace ProjeNesneNew2
{
    partial class FormKareMi
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
            this.lblSonuc = new System.Windows.Forms.Label();
            this.btnUcgenMi = new System.Windows.Forms.Button();
            this.tBoxAlan = new System.Windows.Forms.TextBox();
            this.tboxKenar = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAlan = new System.Windows.Forms.Label();
            this.lblKenar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSonuc
            // 
            this.lblSonuc.Location = new System.Drawing.Point(12, 343);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(308, 51);
            this.lblSonuc.TabIndex = 17;
            this.lblSonuc.Text = "SONUÇ";
            this.lblSonuc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnUcgenMi
            // 
            this.btnUcgenMi.Location = new System.Drawing.Point(12, 272);
            this.btnUcgenMi.Name = "btnUcgenMi";
            this.btnUcgenMi.Size = new System.Drawing.Size(308, 29);
            this.btnUcgenMi.TabIndex = 16;
            this.btnUcgenMi.Text = "Kare mi ?";
            this.btnUcgenMi.UseVisualStyleBackColor = true;
            this.btnUcgenMi.Click += new System.EventHandler(this.btnUcgenMi_Click);
            // 
            // tBoxAlan
            // 
            this.tBoxAlan.Location = new System.Drawing.Point(106, 205);
            this.tBoxAlan.Name = "tBoxAlan";
            this.tBoxAlan.Size = new System.Drawing.Size(200, 27);
            this.tBoxAlan.TabIndex = 14;
            this.tBoxAlan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBoxAlan_KeyPress);
            // 
            // tboxKenar
            // 
            this.tboxKenar.Location = new System.Drawing.Point(106, 144);
            this.tboxKenar.Name = "tboxKenar";
            this.tboxKenar.Size = new System.Drawing.Size(200, 27);
            this.tboxKenar.TabIndex = 13;
            this.tboxKenar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tboxKenar_KeyPress);
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(64, 30);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(208, 85);
            this.lblName.TabIndex = 12;
            this.lblName.Text = "Dikdörtgene ait tam sayı bir kenar uzunluğu ve diktörtgenin tam sayı olacak şekil" +
    "de alanını giriniz.";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAlan
            // 
            this.lblAlan.AutoSize = true;
            this.lblAlan.Location = new System.Drawing.Point(12, 208);
            this.lblAlan.Name = "lblAlan";
            this.lblAlan.Size = new System.Drawing.Size(46, 20);
            this.lblAlan.TabIndex = 10;
            this.lblAlan.Text = "Alan :";
            // 
            // lblKenar
            // 
            this.lblKenar.AutoSize = true;
            this.lblKenar.Location = new System.Drawing.Point(12, 151);
            this.lblKenar.Name = "lblKenar";
            this.lblKenar.Size = new System.Drawing.Size(54, 20);
            this.lblKenar.TabIndex = 9;
            this.lblKenar.Text = "Kenar :";
            // 
            // FormKareMi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 453);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.btnUcgenMi);
            this.Controls.Add(this.tBoxAlan);
            this.Controls.Add(this.tboxKenar);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblAlan);
            this.Controls.Add(this.lblKenar);
            this.MaximizeBox = false;
            this.Name = "FormKareMi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kare olduğunu bulma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblSonuc;
        private Button btnUcgenMi;
        private TextBox tBoxAlan;
        private TextBox tboxKenar;
        private Label lblName;
        private Label lblAlan;
        private Label lblKenar;
    }
}