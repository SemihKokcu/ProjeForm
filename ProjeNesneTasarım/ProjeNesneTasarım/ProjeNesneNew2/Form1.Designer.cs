namespace ProjeNesneNew2
{
    partial class frMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frMain));
            this.btnUcgen = new System.Windows.Forms.Button();
            this.btnKare = new System.Windows.Forms.Button();
            this.btnTasKagıtMakas = new System.Windows.Forms.Button();
            this.btnAltDizgi = new System.Windows.Forms.Button();
            this.btnOnArtEk = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDers = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnUcgen
            // 
            this.btnUcgen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnUcgen.Image = ((System.Drawing.Image)(resources.GetObject("btnUcgen.Image")));
            this.btnUcgen.Location = new System.Drawing.Point(12, 234);
            this.btnUcgen.Name = "btnUcgen";
            this.btnUcgen.Size = new System.Drawing.Size(150, 50);
            this.btnUcgen.TabIndex = 0;
            this.btnUcgen.Text = "Üçgen mi?";
            this.btnUcgen.UseVisualStyleBackColor = false;
            this.btnUcgen.Click += new System.EventHandler(this.btnUcgen_Click);
            // 
            // btnKare
            // 
            this.btnKare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnKare.Image = ((System.Drawing.Image)(resources.GetObject("btnKare.Image")));
            this.btnKare.Location = new System.Drawing.Point(315, 234);
            this.btnKare.Name = "btnKare";
            this.btnKare.Size = new System.Drawing.Size(150, 50);
            this.btnKare.TabIndex = 1;
            this.btnKare.Text = "Kare mi ?";
            this.btnKare.UseVisualStyleBackColor = false;
            this.btnKare.Click += new System.EventHandler(this.btnKare_Click);
            // 
            // btnTasKagıtMakas
            // 
            this.btnTasKagıtMakas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnTasKagıtMakas.Image = ((System.Drawing.Image)(resources.GetObject("btnTasKagıtMakas.Image")));
            this.btnTasKagıtMakas.Location = new System.Drawing.Point(639, 235);
            this.btnTasKagıtMakas.Name = "btnTasKagıtMakas";
            this.btnTasKagıtMakas.Size = new System.Drawing.Size(150, 50);
            this.btnTasKagıtMakas.TabIndex = 2;
            this.btnTasKagıtMakas.Text = "Taş Kağıt Makas";
            this.btnTasKagıtMakas.UseVisualStyleBackColor = false;
            this.btnTasKagıtMakas.Click += new System.EventHandler(this.btnTasKagıtMakas_Click);
            // 
            // btnAltDizgi
            // 
            this.btnAltDizgi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAltDizgi.Image = ((System.Drawing.Image)(resources.GetObject("btnAltDizgi.Image")));
            this.btnAltDizgi.Location = new System.Drawing.Point(13, 334);
            this.btnAltDizgi.Name = "btnAltDizgi";
            this.btnAltDizgi.Size = new System.Drawing.Size(150, 50);
            this.btnAltDizgi.TabIndex = 3;
            this.btnAltDizgi.Text = "Altdizgi mi ?";
            this.btnAltDizgi.UseVisualStyleBackColor = false;
            this.btnAltDizgi.Click += new System.EventHandler(this.btnAltDizgi_Click);
            // 
            // btnOnArtEk
            // 
            this.btnOnArtEk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnOnArtEk.Image = ((System.Drawing.Image)(resources.GetObject("btnOnArtEk.Image")));
            this.btnOnArtEk.Location = new System.Drawing.Point(638, 333);
            this.btnOnArtEk.Name = "btnOnArtEk";
            this.btnOnArtEk.Size = new System.Drawing.Size(150, 50);
            this.btnOnArtEk.TabIndex = 4;
            this.btnOnArtEk.Text = "Ön ek veya art ek mi? ";
            this.btnOnArtEk.UseVisualStyleBackColor = false;
            this.btnOnArtEk.Click += new System.EventHandler(this.btnOnArtEk_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnKapat.ForeColor = System.Drawing.Color.Transparent;
            this.btnKapat.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnKapat.Location = new System.Drawing.Point(315, 333);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(150, 50);
            this.btnKapat.TabIndex = 5;
            this.btnKapat.Text = "Uygulamayı Kapat";
            this.btnKapat.UseVisualStyleBackColor = false;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Stencil", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblName.ForeColor = System.Drawing.Color.Black;
            this.lblName.Location = new System.Drawing.Point(12, 21);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(776, 50);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "İsim Soyisim Numara";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDers
            // 
            this.lblDers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblDers.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblDers.Location = new System.Drawing.Point(12, 94);
            this.lblDers.Name = "lblDers";
            this.lblDers.Size = new System.Drawing.Size(776, 25);
            this.lblDers.TabIndex = 8;
            this.lblDers.Text = "BLM309 : NESNEYE DAYALI ANALİZ VE TASARIM";
            this.lblDers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDers);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.btnOnArtEk);
            this.Controls.Add(this.btnAltDizgi);
            this.Controls.Add(this.btnTasKagıtMakas);
            this.Controls.Add(this.btnKare);
            this.Controls.Add(this.btnUcgen);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.MaximizeBox = false;
            this.Name = "frMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Sayfa";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnUcgen;
        private Button btnKare;
        private Button btnTasKagıtMakas;
        private Button btnAltDizgi;
        private Button btnOnArtEk;
        private Button btnKapat;
        private Label lblName;
        private Label lblDers;



    }
}