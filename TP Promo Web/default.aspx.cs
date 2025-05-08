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

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            EmailService emailService = new EmailService();
            emailService.sendMail("leandrocg524@gmail.com", "Prueba", "Esta es una prueba de enviar correos desde aspx");
        }
    }
}