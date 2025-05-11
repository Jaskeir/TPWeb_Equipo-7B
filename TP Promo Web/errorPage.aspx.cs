using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP_Promo_Web
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                return;
            }
            if (Request.UrlReferrer == null)
            {
                ViewState["PaginaAnterior"] = "Default.aspx";
                return;
            }
            mensajeError.InnerText = Session["msgError"] != null ? Session["msgError"].ToString() : "Error Inesperado";
            ViewState["PaginaAnterior"] = Request.UrlReferrer.ToString(); // UrlReferrer devuelve la página anterior a llegar a la actual.
        }

        protected void btnVolverAtras_Click(object sender, EventArgs e)
        {
            if (ViewState["PaginaAnterior"] != null)
            {
                Response.Redirect(ViewState["PaginaAnterior"].ToString());
            }

        }
    }
}