using SiparisYonetimi.Business.Managers;
using System;

namespace SiparisYonetimi.WebFormsUI
{
    public partial class Kategori : System.Web.UI.Page
    {
        CategoryManager manager = new CategoryManager();
        ProductManager productManager = new ProductManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["id"] != null)
            {
                try
                {
                    int id = Convert.ToInt32(Request.QueryString["id"]);

                    var kategori = manager.Find(id);

                    ltKategoriAdi.Text = kategori.Name;

                    ltAciklama.Text = kategori.Description;

                    var urunler = productManager.GetAll(p => p.CategoryId == id && p.IsActive == true);

                    rptUrunler.DataSource = urunler;
                    rptUrunler.DataBind();
                }
                catch (Exception)
                {

                    Response.Write("<script>alert('Hata Oluştu!')</script>");
                }
            }
        }
    }
}