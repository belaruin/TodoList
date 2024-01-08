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
    public partial class kayitliste : Form
    {
        todoService todoService;
        public kayitliste()
        {
            InitializeComponent();
            todoService = new todoService();
        }

        private void kayitliste_Load(object sender, EventArgs e)
        {
        }
        private  List<todo> TumListe()
        {
            return todoService.kayitListe();
        }

        private void grdListe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnTumListe_Click(object sender, EventArgs e)
        {
            grdListe.DataSource = TumListe();
            grdListe.Columns["ID"].Visible = false;
        }

        private void btnTamamlandi_Click(object sender, EventArgs e)
        {
            grdListe.DataSource = TumListe().Where(x => x.durumAciklama == "Tamamlandı").ToList();
            grdListe.Columns["ID"].Visible = false;
        }

        private void btnTamamlanamadi_Click(object sender, EventArgs e)
        {
            grdListe.DataSource = TumListe().Where(x => x.durumAciklama == "Tamamlanamadı").ToList();
            grdListe.Columns["ID"].Visible = false;
        }

        private void btnIptalEdildi_Click(object sender, EventArgs e)
        {
            grdListe.DataSource = TumListe().Where(x => x.durumAciklama == "İptal Edildi").ToList();
            grdListe.Columns["ID"].Visible = false;
        }
    }
}
