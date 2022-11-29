using SiparisYonetimi.Business.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SiparisYonetimi.WebFormsUI.Moduller
{
    public partial class Slider : System.Web.UI.UserControl
    {
        SliderManager manager = new SliderManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            rptSlider.DataSource = manager.GetAll();
            rptSlider.DataBind();
        }
    }
}