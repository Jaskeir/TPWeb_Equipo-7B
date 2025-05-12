using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace dominio
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

        public bool Validaremail(string txt)
        {
            int i;
            bool arroba = false, com = false, email = false;


            for (i = 0; i < txt.Length; i++)
            {
                if (txt[i] == '@')
                {
                    if (i != 0 && txt[i + 1] != '.')
                    {
                        arroba = true;
                    }

                }

            }

            if (txt[txt.Length - 4] == '.' && txt[txt.Length - 3] == 'c' && txt[txt.Length - 2] == 'o' && txt[txt.Length - 1] == 'm')
            {
                com = true;

            }



            if (arroba && com)
            {
                email = true;
                return email;

            }
            return email;
        }


        public bool soloLetras(string txt)
        {
            foreach (char caracter in txt)
            {
                if (!(char.IsLetter(caracter)))
                    return false;
            }
            return true;
        }

    }
}
