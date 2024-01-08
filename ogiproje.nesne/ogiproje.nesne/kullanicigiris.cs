using ogiproje.nesne.businessService;
using ogiproje.nesne.entitites;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ogiproje.nesne
{
    public partial class kullanicigiris : Form
    {
        public kullanicigiris()
        {
            InitializeComponent();
        }

        private void txtKullaniciGiris_Enter(object sender, EventArgs e)
        {
            TextBox T = (TextBox)sender;
            T.BackColor = Color.Yellow;

        }

        private void txtKullaniciGiris_Leave(object sender, EventArgs e)
        {
            TextBox T = (TextBox)sender;
            T.BackColor = Color.White;
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtKullaniciAdi.Text) || !string.IsNullOrEmpty(txtSifre.Text))
            {
                kullaniciService kullaniciService = new kullaniciService();
                kullanici kontrolKullanici = kullaniciService.kullaniciKontrol(txtKullaniciAdi.Text,txtSifre.Text);
                if(kontrolKullanici != null)
                {
                    Form anaForm = Application.OpenForms["Form1"];
                    Panel solPanel = (Panel)anaForm.Controls["pnlIslemListesi"];
                    GroupBox gbIslemListe = (GroupBox)solPanel.Controls["grpboxIslemListe"];
                    foreach (Control item in gbIslemListe.Controls)
                    {
                        if(item is Button)
                        {
                            item.Enabled = true;
                        }
                    }
                    MessageBox.Show("Merhaba " +  kontrolKullanici.kullaniciAdi, "Bilgilendirme",MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Hatalı Kullanıcı Adı veya Şifre ", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Lütfen giriş bilgilerinizi eksiksiz giriniz", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void kullanicigiris_Load(object sender, EventArgs e)
        {

        }
    }
}
