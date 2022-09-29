using SiparisYonetimi.Business.Managers;
using SiparisYonetimi.Entities;
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
    public partial class UrunYonetimi : Form
    {
        public UrunYonetimi()
        {
            InitializeComponent();
        }
        ProductManager manager = new ProductManager();
        CategoryManager categoryManager = new CategoryManager();
        BrandManager brandManager = new BrandManager();
        void Yukle()
        {
            dgvUrunler.DataSource = manager.GetAll();
            cbKategoriler.DataSource =categoryManager.GetAll();  
            cbMarkalar.DataSource = brandManager.GetAll();
        }
        private void UrunYonetimi_Load(object sender, EventArgs e)
        {
            Yukle();
        }
        void Temizle()
        {
            var nesneler = groupBox1.Controls.OfType<TextBox>();
            foreach (var item in nesneler)
            {
                item.Clear();
            }
            chbDurum.Checked = false;
            btnGuncelle.Enabled = false;
            btnSil.Enabled = false;
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            void Kontrol()
            {
                if (string.IsNullOrWhiteSpace(txtUrunAdi.Text))
                {
                    MessageBox.Show("Ürün Adı Boş Geçilemez!");
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtFiyat.Text))
                {
                    MessageBox.Show("Ürün Adı Boş Geçilemez!");
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtStok.Text))
                {
                    MessageBox.Show("Ürün Adı Boş Geçilemez!");
                    return;
                }
            }

           
           
            try
            {
                Product urun = new Product(); // önce boş bir ürün oluşturduk ve özelliklerini aşağıda  datadan çekiyoruz
                urun.Name = txtUrunAdi.Text;
                urun.Description = txtAciklama.Text;
                urun.Price =Convert.ToDecimal(txtFiyat.Text);
                urun.BrandId = (int)cbMarkalar.SelectedValue;
                urun.CategoryId = (int)cbKategoriler.SelectedValue;
                urun.Image = txtResim.Text;
                urun.Stock = int.Parse(txtStok.Text); // parese yöntemiyle de text i int e dönüştürebiliriz
                urun.IsActive = chbDurum.Checked;
                manager.Add(urun);
                int sonuc = manager.SaveChanges();
                if (sonuc > 0)
                {
                    Temizle();
                    Yukle();
                    MessageBox.Show("Kayıt Başarılı!");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Hata Oluştu!");
            }



        }

        private void dgvUrunler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            void Kontrol()
            {
                if (string.IsNullOrWhiteSpace(txtUrunAdi.Text))
                {
                    MessageBox.Show("Ürün Adı Boş Geçilemez!");
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtFiyat.Text))
                {
                    MessageBox.Show("Ürün Adı Boş Geçilemez!");
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtStok.Text))
                {
                    MessageBox.Show("Ürün Adı Boş Geçilemez!");
                    return;
                }
            }
            try
            {
                int id = (int)dgvUrunler.CurrentRow.Cells[0].Value;
                var urun = manager.Find(id);
                txtUrunAdi.Text = urun.Name;
                txtStok.Text = urun.Stock.ToString();
                txtResim.Text = urun.Image;
                txtFiyat.Text =urun.Price.ToString();
                txtAciklama.Text= urun.Description;
                chbDurum.Checked= urun.IsActive;
                cbKategoriler.SelectedValue = urun.CategoryId;
                cbMarkalar.SelectedValue = urun.BrandId;
                btnGuncelle.Enabled = true;
                btnSil.Enabled = true;

            }
            catch (Exception)
            {

                MessageBox.Show("Hata Oluştu!");
            }
        }
        void Kontrol()
        {
            if (string.IsNullOrWhiteSpace(txtUrunAdi.Text))
            {
                MessageBox.Show("Ürün Adı Boş Geçilemez!");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtFiyat.Text))
            {
                MessageBox.Show("Ürün Adı Boş Geçilemez!");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtStok.Text))
            {
                MessageBox.Show("Ürün Adı Boş Geçilemez!");
                return;
            }
        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
           
            Kontrol();
            try
            {
                int id = (int)dgvUrunler.CurrentRow.Cells[0].Value;
                var urun = manager.Find(id);

                urun.Name = txtUrunAdi.Text;
                urun.Description = txtAciklama.Text;
                urun.Price = Convert.ToDecimal(txtFiyat.Text);
                urun.BrandId = (int)cbMarkalar.SelectedValue;
                urun.CategoryId = (int)cbKategoriler.SelectedValue;
                urun.Image = txtResim.Text;
                urun.Stock = int.Parse(txtStok.Text); // parese yöntemiyle de text i int e dönüştürebiliriz
                urun.IsActive = chbDurum.Checked;
                manager.Update(urun);
                int sonuc = manager.SaveChanges();
                if (sonuc > 0)
                {
                    Temizle();
                    Yukle();
                    MessageBox.Show("Kayıt Başarılı!");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Hata Oluştu!");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dgvUrunler.CurrentRow.Cells[0].Value);
                var kayit = manager.Find(id);

                manager.Delete(kayit);
                var sonuc = manager.SaveChanges();
                if (sonuc > 0)
                {
                    Temizle();
                    Yukle();
                    dgvUrunler.DataSource = manager.GetAll();
                    MessageBox.Show("Silme İşlemi Başarılı");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Hata Oluştu!");
            }
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            dgvUrunler.DataSource = manager.GetAll(m => m.Name.Contains(txtAra.Text) || m.Description.Contains(txtAra.Text));
        }
    }
    
}
