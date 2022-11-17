using SiparisYonetimi.Business.Managers;
using SiparisYonetimi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SiparisYonetimi.WebFormsUI.Admin
{
    public partial class KategoriYonetimi : System.Web.UI.Page
    {
        CategoryManager manager = new CategoryManager();
        
        protected void Page_Load(object sender, EventArgs e)
        {
        dgvKategoriler.DataSource = manager.GetAll();
            dgvKategoriler.DataBind(); // web form da bu satırı eklemezsek veritabaından çektiğimiz veriler ekranda yüklenmez
        }

        protected void btnEkle_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            category.Name = txtKategoriAdi.Text;
            category.Description = txtAciklama.Text;
            category.IsActive = chbDurum.Checked;

            try
            {
                manager.Add(category);
                var sonuc = manager.SaveChanges();
                if (sonuc > 0)
                {
                    Response.Redirect("KategoriYonetimi.aspx");
                }
            }
            catch (Exception)
            {
                
            }
        }
    }
}