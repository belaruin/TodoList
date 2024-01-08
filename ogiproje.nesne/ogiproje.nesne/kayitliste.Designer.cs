namespace ogiproje.nesne
{
    partial class kayitliste
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grpboxListe = new System.Windows.Forms.GroupBox();
            this.grdListe = new System.Windows.Forms.DataGridView();
            this.btnTumListe = new System.Windows.Forms.Button();
            this.btnTamamlandi = new System.Windows.Forms.Button();
            this.btnTamamlanamadi = new System.Windows.Forms.Button();
            this.btnIptalEdildi = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.grpboxListe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdListe)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnIptalEdildi);
            this.groupBox1.Controls.Add(this.btnTamamlanamadi);
            this.groupBox1.Controls.Add(this.btnTamamlandi);
            this.groupBox1.Controls.Add(this.btnTumListe);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(155, 329);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İşlem Listesi";
            // 
            // grpboxListe
            // 
            this.grpboxListe.Controls.Add(this.grdListe);
            this.grpboxListe.Location = new System.Drawing.Point(173, 12);
            this.grpboxListe.Name = "grpboxListe";
            this.grpboxListe.Size = new System.Drawing.Size(637, 338);
            this.grpboxListe.TabIndex = 0;
            this.grpboxListe.TabStop = false;
            this.grpboxListe.Text = "Liste";
            // 
            // grdListe
            // 
            this.grdListe.AllowUserToAddRows = false;
            this.grdListe.AllowUserToDeleteRows = false;
            this.grdListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdListe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdListe.Location = new System.Drawing.Point(3, 18);
            this.grdListe.Name = "grdListe";
            this.grdListe.ReadOnly = true;
            this.grdListe.RowHeadersWidth = 51;
            this.grdListe.RowTemplate.Height = 24;
            this.grdListe.Size = new System.Drawing.Size(631, 317);
            this.grdListe.TabIndex = 0;
            this.grdListe.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdListe_CellContentClick);
            // 
            // btnTumListe
            // 
            this.btnTumListe.Location = new System.Drawing.Point(6, 33);
            this.btnTumListe.Name = "btnTumListe";
            this.btnTumListe.Size = new System.Drawing.Size(143, 36);
            this.btnTumListe.TabIndex = 1;
            this.btnTumListe.Text = "Tüm Liste";
            this.btnTumListe.UseVisualStyleBackColor = true;
            this.btnTumListe.Click += new System.EventHandler(this.btnTumListe_Click);
            // 
            // btnTamamlandi
            // 
            this.btnTamamlandi.Location = new System.Drawing.Point(6, 75);
            this.btnTamamlandi.Name = "btnTamamlandi";
            this.btnTamamlandi.Size = new System.Drawing.Size(143, 36);
            this.btnTamamlandi.TabIndex = 2;
            this.btnTamamlandi.Text = "Tamamlandı";
            this.btnTamamlandi.UseVisualStyleBackColor = true;
            this.btnTamamlandi.Click += new System.EventHandler(this.btnTamamlandi_Click);
            // 
            // btnTamamlanamadi
            // 
            this.btnTamamlanamadi.Location = new System.Drawing.Point(6, 117);
            this.btnTamamlanamadi.Name = "btnTamamlanamadi";
            this.btnTamamlanamadi.Size = new System.Drawing.Size(143, 36);
            this.btnTamamlanamadi.TabIndex = 3;
            this.btnTamamlanamadi.Text = "Tamamlanamadı";
            this.btnTamamlanamadi.UseVisualStyleBackColor = true;
            this.btnTamamlanamadi.Click += new System.EventHandler(this.btnTamamlanamadi_Click);
            // 
            // btnIptalEdildi
            // 
            this.btnIptalEdildi.Location = new System.Drawing.Point(6, 159);
            this.btnIptalEdildi.Name = "btnIptalEdildi";
            this.btnIptalEdildi.Size = new System.Drawing.Size(143, 36);
            this.btnIptalEdildi.TabIndex = 4;
            this.btnIptalEdildi.Text = "İptal Edildi";
            this.btnIptalEdildi.UseVisualStyleBackColor = true;
            this.btnIptalEdildi.Click += new System.EventHandler(this.btnIptalEdildi_Click);
            // 
            // kayitliste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 353);
            this.Controls.Add(this.grpboxListe);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "kayitliste";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Todo - Kayıt Liste";
            this.Load += new System.EventHandler(this.kayitliste_Load);
            this.groupBox1.ResumeLayout(false);
            this.grpboxListe.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdListe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTumListe;
        private System.Windows.Forms.GroupBox grpboxListe;
        private System.Windows.Forms.DataGridView grdListe;
        private System.Windows.Forms.Button btnIptalEdildi;
        private System.Windows.Forms.Button btnTamamlanamadi;
        private System.Windows.Forms.Button btnTamamlandi;
    }
}