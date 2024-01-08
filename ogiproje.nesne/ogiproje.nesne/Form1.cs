using ogiproje.nesne.businessService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ogiproje.nesne
{
    public partial class Form1 : Form
    {
        Form T;
        public Form1()
        {
            InitializeComponent();
        }

        private void ButonAcKapa(bool Kontrol)
        {
            foreach (Control item in grpboxIslemListe.Controls)
            {
                if (item is Button)
                {
                    ((Button)item).Enabled = Kontrol;
                }
            }
        }

        private void pnlIslemListesi_Paint(object sender, PaintEventArgs e)
        {

        }   

        private void Form1_Load(object sender, EventArgs e)
        {
            tm_zamanla.Interval = 15000;
            tm_zamanla.Tick += tm_zamanla_Tick;
            tm_zamanla.Start();

            ButonAcKapa(false);

            kullanicigiris kullaniciKontrol = new kullanicigiris();
            kullaniciKontrol.MdiParent = this;
            kullaniciKontrol.StartPosition = FormStartPosition.CenterScreen;
            kullaniciKontrol.Show();
        }

        private void tm_zamanla_Tick(object sender, EventArgs e)
        {
            lblZaman.Text = DateTime.Now.ToString("dd.MM.yyyy hh:mm");
        }

        private void btnUygulamaKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnYeniKayit_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["yeniKayit"] != null)
            {
                T = Application.OpenForms["yeniKayit"];
                T.Focus();
            }
            else
            {
                T = new yenikayit();
                T.MdiParent = this;
                T.Show();
            }
        }

        private void btnKayitListesi_Click(object sender, EventArgs e)
        {
            todoService todoService = new todoService();
            if (todoService.kayitKontrol() > 0)
            {
                kayitliste kayitliste = new kayitliste();
                kayitliste.MdiParent = this;
                kayitliste.Show();
            }
            else
            {
                MessageBox.Show("Listelenecek Kayıt Bulunamadı", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
