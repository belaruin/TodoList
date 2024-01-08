using ogiproje.nesne.businessService;
using ogiproje.nesne.entitites;
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
    public partial class yenikayit : Form
    {
        public yenikayit()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBaslik_Enter(object sender, EventArgs e)
        {
            ((TextBox)sender).BackColor = Color.Yellow;
        }

        private void txtBaslik_Leave(object sender, EventArgs e)
        {
            ((TextBox)sender).BackColor = Color.White;
        }

        private void btnYeniKayit_Click(object sender, EventArgs e)
        {
            todoService todoService = new todoService();
             int sonuc = todoService.kayitYeni(new entitites.todo()
            {
              id = Guid.NewGuid(),
              baslik = txtBaslik.Text,
              kisaAciklama = txtAciklama.Text,
              aciklama = txtAciklama.Text,
              durumAciklama = cmbDurum.SelectedItem.ToString(),
              onemDerece = int.Parse(txtDerece.Text),
              olusturmaTarihi = DateTime.Now,
            });
            if(sonuc > 0 )
            {
                MessageBox.Show("Kayıt ekleme işlemi başarılı ", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult  result = MessageBox.Show("Yeni kayıt ekleme işlemine devam etmek ister misiniz", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(result == DialogResult.Yes)
                {
                    foreach (Control item in this.Controls)
                    {
                        if (item is TextBox)
                        {
                            ((TextBox)item).Text = string.Empty;
                        }
                    }
                }
                else
                {
                    Form kayitliste = Application.OpenForms["kayitliste"];
                    if( kayitliste == null )
                    {
                        kayitliste = new kayitliste();
                        kayitliste.MdiParent = Application.OpenForms["Form1"];
                        kayitliste.StartPosition = FormStartPosition.CenterScreen;
                        kayitliste.Show();
                        this.Close();
                    }
                    else
                    {
                        GroupBox Liste = (GroupBox)kayitliste.Controls["grpBoxListe"];
                        DataGridView grdListe = (DataGridView)Liste.Controls["grdListe"];
                        List<todo> GuncelListe = todoService.kayitListe();
                        grdListe.DataSource = null;
                        grdListe.DataSource = GuncelListe;

                    }
                }
            }
            else
            {
                MessageBox.Show("Kayıt ekleme işleminde hata ", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
