using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiparisYonetimi.WinFormsUI
{
    public partial class AnaMenu : Form
    {
        public AnaMenu()
        {
            InitializeComponent();
        }

        private void kullanıcıYönetimiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KullaniciYonetimi kullanici = new KullaniciYonetimi();
            kullanici.ShowDialog();
        }

        private void markaYönetimiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MarkaYonetimi markaYonetimi = new MarkaYonetimi();
            markaYonetimi.ShowDialog();
        }

        private void kategoriYönetimiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KategoriYonetimi kategoriYonetimi = new KategoriYonetimi();
            kategoriYonetimi.ShowDialog();
        }

        private void müşteriYönetimiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MusteriYonetimi musteriYonetimi = new MusteriYonetimi();
            musteriYonetimi.ShowDialog();
        }

        private void ürünYönetimiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UrunYonetimi urunYonetimi = new UrunYonetimi();
            urunYonetimi.ShowDialog();
        }

        private void AnaMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); // Eğer ana ekran kapatılırsa uygulamayı kapat
        }
    }
}
