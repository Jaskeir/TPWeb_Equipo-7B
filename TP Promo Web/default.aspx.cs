using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using negocio;

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
            string codigo = code.Text;
            
            database datos = new database();
            try
            {

                datos.setQuery("SELECT CodigoVoucher FROM Vouchers WHERE CodigoVoucher COLLATE Latin1_General_CS_AS = @codigo AND [IdCliente] IS NULL"); 
                datos.setParameter("@codigo", codigo);
                datos.execQuery();

                if (datos.Lector.Read())
                {
                    Session.Add("Code", code.Text); // Este es el código a canjear
                } else
                {
                    Session["msgError"] = "El código ya fue canjeado o no existe";
                    Response.Redirect("errorPage.aspx", false);
                    return;
                }
                Response.Redirect("productos.aspx", false);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                datos.closeConnection();
            }



        }
    }
}