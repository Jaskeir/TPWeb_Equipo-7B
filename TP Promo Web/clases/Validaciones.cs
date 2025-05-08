using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Promo_Web.clases
{
    public class Validaciones
    {
        public bool soloNumeros(string txt)
        {
            foreach (char caracter in txt)
            {
                if (!(char.IsNumber(caracter)))
                    return false;
            }
            return true;
        }

        public bool link(string txt)
        {
            if (txt == "")
                return false;
            else if (txt.Length < 5)
                return false;

            string URL = "HTTP";
            string aux = txt.ToUpper();
           
            for (int i = 0; i <= 3; i++)
            {
                if (URL[i] != aux[i])
                    return false;
            }
            
            return true;
        }

    }
}
