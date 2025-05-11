using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace dominio
{
    public class Voucher
    {
        public string CodigoVoucher { get; set; }
        public Cliente Cliente { get; set; } 
        

       // public DateTime FechaCanje { get; set; } 
        public string FechaCanje {  set; get; } //simplemente para setearle directamente "getdate()" y que la fecha la determine "sql server" al pasar como parte de la consulta
        public Articulo Articulo { get; set; }
        //public int Articulo { get; set; }

    }
}