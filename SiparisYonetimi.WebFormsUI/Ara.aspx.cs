using SiparisYonetimi.Business.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SiparisYonetimi.WebFormsUI
{
  
    public partial class Ara : System.Web.UI.Page
    { 
        ProductManager productManager = new ProductManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["q"] != null)
            {
                try
                {
                    string kelime = Request.QueryString["q"];

                    var urunler = productManager.GetAll(p => p.Name.Contains(kelime) && p.IsActive == true);

                    if (urunler != null)
                    {
                        rptUrunler.DataSource = urunler;
                        rptUrunler.DataBind();

                    }
                    else rptUrunler.Visible = false; // eğer ürün bulunamazsa repeater ı gizle
                }
                catch (Exception)
                {

                    Response.Write("<script>alert('Hata Oluştu!')</script>");
                }

            }
        }
    }
}