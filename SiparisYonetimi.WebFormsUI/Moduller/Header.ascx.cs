using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SiparisYonetimi.WebFormsUI.Moduller
{
    public partial class Header : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void lbCikis_Click(object sender, EventArgs e)
        {
            Session.Remove("Admin"); // admin isimli session ı sil
            FormsAuthentication.SignOut(); // oturumu kapat
            Response.Redirect("/Admin/Login.aspx"); // logine yönlendir
        }
    }
}