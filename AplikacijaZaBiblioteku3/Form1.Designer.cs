namespace AplikacijaZaBiblioteku
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.UpisKorisnikaButton = new System.Windows.Forms.Button();
            this.PVButton = new System.Windows.Forms.Button();
            this.UpisKnjigeButton = new System.Windows.Forms.Button();
            this.DBBrowserButun = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // UpisKorisnikaButton
            // 
            this.UpisKorisnikaButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(176)))), ((int)(((byte)(126)))));
            this.UpisKorisnikaButton.Font = new System.Drawing.Font("Forte", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpisKorisnikaButton.Location = new System.Drawing.Point(12, 12);
            this.UpisKorisnikaButton.Name = "UpisKorisnikaButton";
            this.UpisKorisnikaButton.Size = new System.Drawing.Size(137, 69);
            this.UpisKorisnikaButton.TabIndex = 0;
            this.UpisKorisnikaButton.Text = "Upis Korisnika";
            this.UpisKorisnikaButton.UseVisualStyleBackColor = false;
            this.UpisKorisnikaButton.Click += new System.EventHandler(this.UpisKorisnikaButton_Click);
            // 
            // PVButton
            // 
            this.PVButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PVButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(176)))), ((int)(((byte)(126)))));
            this.PVButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(176)))), ((int)(((byte)(126)))));
            this.PVButton.FlatAppearance.BorderSize = 100;
            this.PVButton.Font = new System.Drawing.Font("Forte", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PVButton.Location = new System.Drawing.Point(363, 12);
            this.PVButton.Name = "PVButton";
            this.PVButton.Size = new System.Drawing.Size(137, 69);
            this.PVButton.TabIndex = 1;
            this.PVButton.Text = "Posudzivanje Vracanje";
            this.PVButton.UseVisualStyleBackColor = false;
            this.PVButton.Click += new System.EventHandler(this.PVButton_Click);
            // 
            // UpisKnjigeButton
            // 
            this.UpisKnjigeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.UpisKnjigeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(176)))), ((int)(((byte)(126)))));
            this.UpisKnjigeButton.Font = new System.Drawing.Font("Forte", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpisKnjigeButton.Location = new System.Drawing.Point(12, 96);
            this.UpisKnjigeButton.Name = "UpisKnjigeButton";
            this.UpisKnjigeButton.Size = new System.Drawing.Size(137, 69);
            this.UpisKnjigeButton.TabIndex = 2;
            this.UpisKnjigeButton.Text = "Upis Knjige";
            this.UpisKnjigeButton.UseVisualStyleBackColor = false;
            this.UpisKnjigeButton.Click += new System.EventHandler(this.UpisKnjigeButton_Click);
            // 
            // DBBrowserButun
            // 
            this.DBBrowserButun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DBBrowserButun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(176)))), ((int)(((byte)(126)))));
            this.DBBrowserButun.Font = new System.Drawing.Font("Forte", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DBBrowserButun.Location = new System.Drawing.Point(363, 96);
            this.DBBrowserButun.Name = "DBBrowserButun";
            this.DBBrowserButun.Size = new System.Drawing.Size(137, 69);
            this.DBBrowserButun.TabIndex = 3;
            this.DBBrowserButun.Text = "Pretraživanje podataka";
            this.DBBrowserButun.UseVisualStyleBackColor = false;
            this.DBBrowserButun.Click += new System.EventHandler(this.DBBrowserButun_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(170, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(170, 87);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(510, 172);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.DBBrowserButun);
            this.Controls.Add(this.UpisKnjigeButton);
            this.Controls.Add(this.PVButton);
            this.Controls.Add(this.UpisKorisnikaButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button UpisKorisnikaButton;
        private System.Windows.Forms.Button PVButton;
        private System.Windows.Forms.Button UpisKnjigeButton;
        private System.Windows.Forms.Button DBBrowserButun;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

