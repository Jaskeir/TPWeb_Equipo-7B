using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TP_Promo_Web.clases
{
    public class Voucher
    {
        public string CodigoVoucher { get; set; }
        public Cliente Cliente { get; set; }
        public DateTime FechaCanje { get; set; }
        public Articulo Articulo { get; set; }
    }
}