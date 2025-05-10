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

        public string Codigo
        
        {
            get;set;
        }
        
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["Code"]!=null)
            {
                Codigo = Session["Code"].ToString();
                
                lblUser.Text = Codigo;
            }
                //code.InnerText = Session["Code"].ToString();
                articuloDatos articuloDatos = new articuloDatos();

            rptArticulos.DataSource = articuloDatos.getArticles();
            rptArticulos.DataBind();


        }

       /*protected void btnCanjear_Click(object sender, EventArgs e)
        {
           guardar en secion el articulo elegido
        }*/
    }
}

