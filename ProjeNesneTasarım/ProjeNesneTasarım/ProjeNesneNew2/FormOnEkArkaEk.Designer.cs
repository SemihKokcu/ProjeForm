namespace ProjeNesneNew2
{
    partial class FormOnEkArkaEk
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
            this.btnOnArkaEk = new System.Windows.Forms.Button();
            this.tBoxDizgi2 = new System.Windows.Forms.TextBox();
            this.tboxDizgi1 = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDizgi2 = new System.Windows.Forms.Label();
            this.lblDizgi1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSonuc
            // 
            this.lblSonuc.Location = new System.Drawing.Point(14, 351);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(308, 51);
            this.lblSonuc.TabIndex = 31;
            this.lblSonuc.Text = "SONUÇ";
            this.lblSonuc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnOnArkaEk
            // 
            this.btnOnArkaEk.Location = new System.Drawing.Point(14, 280);
            this.btnOnArkaEk.Name = "btnOnArkaEk";
            this.btnOnArkaEk.Size = new System.Drawing.Size(308, 29);
            this.btnOnArkaEk.TabIndex = 30;
            this.btnOnArkaEk.Text = "Ön ek ya da arka ek mi ?";
            this.btnOnArkaEk.UseVisualStyleBackColor = true;
            this.btnOnArkaEk.Click += new System.EventHandler(this.btnOnArkaEk_Click);
            // 
            // tBoxDizgi2
            // 
            this.tBoxDizgi2.Location = new System.Drawing.Point(103, 213);
            this.tBoxDizgi2.Name = "tBoxDizgi2";
            this.tBoxDizgi2.Size = new System.Drawing.Size(200, 27);
            this.tBoxDizgi2.TabIndex = 29;
            // 
            // tboxDizgi1
            // 
            this.tboxDizgi1.Location = new System.Drawing.Point(103, 152);
            this.tboxDizgi1.Name = "tboxDizgi1";
            this.tboxDizgi1.Size = new System.Drawing.Size(200, 27);
            this.tboxDizgi1.TabIndex = 28;
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(66, 38);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(208, 85);
            this.lblName.TabIndex = 27;
            this.lblName.Text = "İlk girdi ikinci girdinin ön ya da arka eki mi?";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDizgi2
            // 
            this.lblDizgi2.AutoSize = true;
            this.lblDizgi2.Location = new System.Drawing.Point(10, 216);
            this.lblDizgi2.Name = "lblDizgi2";
            this.lblDizgi2.Size = new System.Drawing.Size(62, 20);
            this.lblDizgi2.TabIndex = 26;
            this.lblDizgi2.Text = "2.Dizgi :";
            // 
            // lblDizgi1
            // 
            this.lblDizgi1.AutoSize = true;
            this.lblDizgi1.Location = new System.Drawing.Point(10, 159);
            this.lblDizgi1.Name = "lblDizgi1";
            this.lblDizgi1.Size = new System.Drawing.Size(62, 20);
            this.lblDizgi1.TabIndex = 25;
            this.lblDizgi1.Text = "1.Dizgi :";
            // 
            // FormOnEkArkaEk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 453);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.btnOnArkaEk);
            this.Controls.Add(this.tBoxDizgi2);
            this.Controls.Add(this.tboxDizgi1);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblDizgi2);
            this.Controls.Add(this.lblDizgi1);
            this.MaximizeBox = false;
            this.Name = "FormOnEkArkaEk";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ön ya da arka ek mi?";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblSonuc;
        private Button btnOnArkaEk;
        private TextBox tBoxDizgi2;
        private TextBox tboxDizgi1;
        private Label lblName;
        private Label lblDizgi2;
        private Label lblDizgi1;
    }
}