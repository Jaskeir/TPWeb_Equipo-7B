using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TP_Promo_Web.clases;

namespace TP_Promo_Web
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) // es necesario para manejar el postback (una recarga de página) si es un postback, detener la ejecución
            {
                return;
            }
            
        }

        protected void btnCanjear_Click(object sender, EventArgs e)
        {
            Session.Add("Code", code.Text);

            Response.Redirect("productos.aspx", false);
        }
    }
}