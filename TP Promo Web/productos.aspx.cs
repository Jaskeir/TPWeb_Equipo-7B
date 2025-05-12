using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using dominio;
using negocio;

namespace TP_Promo_Web
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Code"] == null)
            {
                Response.Redirect("default.aspx", true);
                return;
            }
            if (IsPostBack)
            {
                return;
            }
            articuloDatos articuloDatos = new articuloDatos();
            rptArticulos.DataSource = articuloDatos.getArticles();
            rptArticulos.DataBind();
        }

        protected void btnCanjear_Click(object sender, EventArgs e)
        {
            string productoID = ((Button)sender).CommandArgument;
            Session["productoSeleccionado"] = productoID;
            Response.Redirect("datosClientes.aspx", false);
        }
    }
}

