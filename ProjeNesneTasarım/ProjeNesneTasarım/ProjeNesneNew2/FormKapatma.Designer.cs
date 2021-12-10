namespace ProjeNesneNew2
{
    partial class FormKapatma
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
            this.lblKapat = new System.Windows.Forms.Label();
            this.btnEvet = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblKapat
            // 
            this.lblKapat.Location = new System.Drawing.Point(12, 38);
            this.lblKapat.Name = "lblKapat";
            this.lblKapat.Size = new System.Drawing.Size(276, 70);
            this.lblKapat.TabIndex = 0;
            this.lblKapat.Text = "Uygulamayı kapatmak istiyor musunuz ?";
            this.lblKapat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEvet
            // 
            this.btnEvet.Location = new System.Drawing.Point(12, 139);
            this.btnEvet.Name = "btnEvet";
            this.btnEvet.Size = new System.Drawing.Size(119, 50);
            this.btnEvet.TabIndex = 1;
            this.btnEvet.Text = "Evet";
            this.btnEvet.UseVisualStyleBackColor = true;
            this.btnEvet.Click += new System.EventHandler(this.btnEvet_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(169, 139);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 50);
            this.button2.TabIndex = 2;
            this.button2.Text = "Hayır";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormKapatma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(300, 256);
            this.ControlBox = false;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnEvet);
            this.Controls.Add(this.lblKapat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormKapatma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Kapat";
            this.ResumeLayout(false);

        }

        #endregion

        private Label lblKapat;
        private Button btnEvet;
        private Button button2;
    }
}