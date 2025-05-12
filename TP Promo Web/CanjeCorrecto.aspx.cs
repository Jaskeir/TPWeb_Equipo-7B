using dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using negocio;

namespace TP_Promo_Web
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                return;
            }
            if (Session["Code"] == null)
            {
                Response.Redirect("default.aspx", true);
                return;
            }
            EmailService emailService = new EmailService();
            int idSelected = int.Parse(Session["productoSeleccionado"].ToString());
            articuloDatos articuloDatos = new articuloDatos();
            Articulo articulo = articuloDatos.getArticle(idSelected);

            try
            {
                emailService.sendMail(Session["email"].ToString(), "Promo WEB: Canje exitoso", "Felicidades, canjeaste de manera exitosa tu " + articulo.Nombre + ".\n\nGrupo 7B - UTN FRGP");
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}