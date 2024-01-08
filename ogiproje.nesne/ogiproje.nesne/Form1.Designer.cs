namespace ogiproje.nesne
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnlIslemListesi = new System.Windows.Forms.Panel();
            this.grpboxIslemListe = new System.Windows.Forms.GroupBox();
            this.btnUygulamaKapat = new System.Windows.Forms.Button();
            this.btnKayitListesi = new System.Windows.Forms.Button();
            this.btnYeniKayit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblZaman = new System.Windows.Forms.Label();
            this.tm_zamanla = new System.Windows.Forms.Timer(this.components);
            this.pnlIslemListesi.SuspendLayout();
            this.grpboxIslemListe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlIslemListesi
            // 
            this.pnlIslemListesi.Controls.Add(this.grpboxIslemListe);
            this.pnlIslemListesi.Controls.Add(this.pictureBox1);
            this.pnlIslemListesi.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlIslemListesi.Location = new System.Drawing.Point(0, 0);
            this.pnlIslemListesi.Name = "pnlIslemListesi";
            this.pnlIslemListesi.Size = new System.Drawing.Size(261, 689);
            this.pnlIslemListesi.TabIndex = 1;
            this.pnlIslemListesi.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlIslemListesi_Paint);
            // 
            // grpboxIslemListe
            // 
            this.grpboxIslemListe.Controls.Add(this.btnUygulamaKapat);
            this.grpboxIslemListe.Controls.Add(this.btnKayitListesi);
            this.grpboxIslemListe.Controls.Add(this.btnYeniKayit);
            this.grpboxIslemListe.Location = new System.Drawing.Point(21, 265);
            this.grpboxIslemListe.Name = "grpboxIslemListe";
            this.grpboxIslemListe.Size = new System.Drawing.Size(213, 195);
            this.grpboxIslemListe.TabIndex = 1;
            this.grpboxIslemListe.TabStop = false;
            this.grpboxIslemListe.Text = "İşlem Listesi";
            // 
            // btnUygulamaKapat
            // 
            this.btnUygulamaKapat.Location = new System.Drawing.Point(15, 105);
            this.btnUygulamaKapat.Name = "btnUygulamaKapat";
            this.btnUygulamaKapat.Size = new System.Drawing.Size(181, 36);
            this.btnUygulamaKapat.TabIndex = 2;
            this.btnUygulamaKapat.Text = "Uygulama Kapat";
            this.btnUygulamaKapat.UseVisualStyleBackColor = true;
            this.btnUygulamaKapat.Click += new System.EventHandler(this.btnUygulamaKapat_Click);
            // 
            // btnKayitListesi
            // 
            this.btnKayitListesi.Location = new System.Drawing.Point(15, 63);
            this.btnKayitListesi.Name = "btnKayitListesi";
            this.btnKayitListesi.Size = new System.Drawing.Size(181, 36);
            this.btnKayitListesi.TabIndex = 1;
            this.btnKayitListesi.Text = "Kayıt Listesi";
            this.btnKayitListesi.UseVisualStyleBackColor = true;
            this.btnKayitListesi.Click += new System.EventHandler(this.btnKayitListesi_Click);
            // 
            // btnYeniKayit
            // 
            this.btnYeniKayit.Location = new System.Drawing.Point(15, 21);
            this.btnYeniKayit.Name = "btnYeniKayit";
            this.btnYeniKayit.Size = new System.Drawing.Size(181, 36);
            this.btnYeniKayit.TabIndex = 0;
            this.btnYeniKayit.Text = "Yeni Kayıt";
            this.btnYeniKayit.UseVisualStyleBackColor = true;
            this.btnYeniKayit.Click += new System.EventHandler(this.btnYeniKayit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(21, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 256);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblZaman);
            this.panel1.Location = new System.Drawing.Point(898, 613);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(304, 64);
            this.panel1.TabIndex = 2;
            // 
            // lblZaman
            // 
            this.lblZaman.AutoSize = true;
            this.lblZaman.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblZaman.Location = new System.Drawing.Point(30, 17);
            this.lblZaman.Name = "lblZaman";
            this.lblZaman.Size = new System.Drawing.Size(221, 32);
            this.lblZaman.TabIndex = 0;
            this.lblZaman.Text = "7.01.2024 17:00";
            // 
            // tm_zamanla
            // 
            this.tm_zamanla.Tick += new System.EventHandler(this.tm_zamanla_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1214, 689);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlIslemListesi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "Todo List Uygulaması";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlIslemListesi.ResumeLayout(false);
            this.pnlIslemListesi.PerformLayout();
            this.grpboxIslemListe.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlIslemListesi;
        private System.Windows.Forms.GroupBox grpboxIslemListe;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnUygulamaKapat;
        private System.Windows.Forms.Button btnKayitListesi;
        private System.Windows.Forms.Button btnYeniKayit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblZaman;
        private System.Windows.Forms.Timer tm_zamanla;
    }
}

