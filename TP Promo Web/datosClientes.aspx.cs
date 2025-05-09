using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using dominio;
using negocio;

namespace TP_Promo_Web
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCanjear_Click(object sender, EventArgs e)
        {

        }

        protected void txtDNI_TextChanged(object sender, EventArgs e)
        {
            string dni = txtDNI.Text;
            List<Cliente> lista = new List<Cliente>();
            database datos = new database();

            try
            {
               
                datos.setQuery("Select Id,Documento,Nombre,Apellido,Email,Direccion,Ciudad,CP from Clientes where Documento = @dni");
                datos.setParameter("@dni", dni);
                datos.execQuery();

                while (datos.Lector.Read())
                {
                    Cliente aux = new Cliente();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Documento = (string)datos.Lector["Documento"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Apellido = (string)datos.Lector["Apellido"];
                    aux.Email = (string)datos.Lector["Email"];
                    aux.Direccion = (string)datos.Lector["Direccion"];
                    aux.Ciudad = (string)datos.Lector["Ciudad"];
                    aux.CP = (int)datos.Lector["CP"];

                    lista.Add(aux);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.closeConnection();
            }

            foreach (Cliente item in lista)
            {
                if (item.Documento == dni)
                {
                    txtname.Text = item.Nombre;
                    txtApel.Text = item.Apellido;
                    txtEmail.Text = item.Email;
                    txtDirec.Text = item.Direccion;
                    txtciud.Text = item.Ciudad;
                    txtCP.Text = item.CP.ToString();


                    txtname.ReadOnly = true;
                    txtApel.ReadOnly = true;
                    txtEmail.ReadOnly = true;
                    txtDirec.ReadOnly = true;
                    txtciud.ReadOnly = true;
                    txtCP.ReadOnly = true;
                }
                return;
            }
                    txtname.Text = "";
                    txtApel.Text = "";
                    txtEmail.Text = "";
                    txtDirec.Text = "";
                    txtciud.Text = "";
                    txtCP.Text = "";


                    txtname.ReadOnly = false;
                    txtApel.ReadOnly = false;
                    txtEmail.ReadOnly = false;
                    txtDirec.ReadOnly = false;
                    txtciud.ReadOnly = false;
                    txtCP.ReadOnly = false;
        }

     }
 }
  





