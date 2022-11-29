﻿using SiparisYonetimi.Business.Managers;
using System;

namespace SiparisYonetimi.WebFormsUI
{
    public partial class OnYuz : System.Web.UI.MasterPage
    {
        CategoryManager manager = new CategoryManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            rptKategoriler.DataSource = manager.GetAll();
            rptKategoriler.DataBind();
        }

        protected void btnAra_Click(object sender, EventArgs e)
        {
            Response.Redirect("Ara.aspx?q=" + txtUrunAra.Text.Trim());
        }
    }
}