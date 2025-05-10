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
      public string codigo {  get; set; }  //pare setear codigo de voucherguardado en ssion
      public Articulo articulo { get; set; } //para setear el articulo, en secion secion al elegir el producto
        protected void Page_Load(object sender, EventArgs e)
        {
            txtname.ReadOnly = true;
            txtApel.ReadOnly = true;
            txtEmail.ReadOnly = true;
            txtDirec.ReadOnly = true;
            txtciud.ReadOnly = true;
            txtCP.ReadOnly = true;

            //codigo = Session["Code"].ToString(); //recupera el codigo del voucher
            //agregar recuperacion del articulo elegido
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

                while (datos.Lector.Read()) //se puede hacer con un IF? ya que solo va a haber un cliente co el DNI ingresado
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

            foreach (Cliente item in lista)//no bastaria con asignarlo, ya que la consulta va a devolver u unico cliente que consida con el DNI ingresado?
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

        protected void btnCanjear_Click(object sender, EventArgs e)
        {
            /*hay que crear un nuevo cliente si no esta en la base de datos*/
             /*Voucher voucher = new Voucher();
            VoucherNegocio vouneg = new VoucherNegocio();
             
             database datos = new database(); //aca busco el id del cliente que acaba de ingresar los

            try
            {
               
                datos.setQuery("Select Id,Documento,Nombre,Apellido,Email,Direccion,Ciudad,CP from Clientes where Documento = @dni");
                datos.setParameter("@dni", dni);
                datos.execQuery();

                if(datos.Lector.Read()) 
                {
                    Cliente aux = new Cliente();
                    aux.Id = (int)datos.Lector["Id"];
                    
                
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
             


             try
             {
                voucher.Articulo.Codigo= Art,              //toma el id del articulo de la "sesion"
                voucher.FechaCanje = "gatdate()";          // deveria devolver el dia de hoy cuando pasa a la base de datos (comando de sql server)
                 voucher.CodigoVoucher = code;                      // toma el codigo del voucher de la "sesion"
                 voucher.Cliente.Id=aux.Id ;                        //toma el id del cliente obtenido en la busqeda

                vouneg.cargar(voucher);                //carga las demasc columnas de la tabla de vaucher

                 Close();

             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.ToString());
             }*/
        }


    }
 }
  





