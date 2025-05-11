using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using dominio;
using Microsoft.SqlServer.Server;
using negocio;

namespace TP_Promo_Web
{
    public partial class WebForm2 : System.Web.UI.Page
    {

        private string codigo;  // pare setear codigo de voucherguardado en ssion
        private Articulo articulo { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Code"] == null)
            {
                Response.Redirect("default.aspx", true);
                return;
            }

            txtname.ReadOnly = true;
            txtApel.ReadOnly = true;
            txtEmail.ReadOnly = true;
            txtDirec.ReadOnly = true;
            txtciud.ReadOnly = true;
            txtCP.ReadOnly = true;

            int idSelected = int.Parse(Session["productoSeleccionado"].ToString());

            articulo = getSelectedArticle(idSelected);

            productName.Text = articulo.Nombre;

            /*codigo = Session["Code"].ToString();*/ //recupera el codigo del voucher                                  
                                                     //agregar recuperacion del articulo elegido
        }

        private Articulo getSelectedArticle(int id)
        {
            articuloDatos articuloDatos = new articuloDatos();
            Articulo articulo = articuloDatos.getArticle(id);
            return articulo;
        }

        protected void txtDNI_TextChanged(object sender, EventArgs e)
        {
            Validaciones validaciones = new Validaciones();
            string dni = txtDNI.Text;
            if (dni.Length >= 7 && dni.Length < 9)
            {
                if (validaciones.soloNumeros(dni))
                {

                    ClienteNegocio clienteNegocio = new ClienteNegocio();
                    Cliente item = new Cliente();

                    item = clienteNegocio.FindCliente(dni);
                    if (item.Id != -1)
                    {
                        txtDNI.Text = item.Documento;
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


        protected void btnParticipar_Click(object sender, EventArgs e)
        {
            /*hay que crear un nuevo cliente si no está en la base de datos*/
            string dni = txtDNI.Text;
            Validaciones validaciones = new Validaciones();

            errorNombre.Text = "";
            errorApel.Text = "";
            errorEmail.Text = "";
            errorDirec.Text = "";
            errorCiud.Text = "";
            errorCp.Text = "";

            bool error = false;

            if (dni.Length >= 7 && dni.Length < 9)
            {
                if (validaciones.soloNumeros(dni))
                {
                    Cliente nuevo = new Cliente();
                    ClienteNegocio clineg = new ClienteNegocio();
                    nuevo = clineg.FindCliente(dni);
                    if (nuevo.Id == -1)
                    {
                        nuevo.Documento = txtDNI.Text;

                        if (validaciones.soloLetras(txtname.Text))
                        {
                            nuevo.Nombre = txtname.Text;
                        }
                        else
                        {
                            txtname.ReadOnly = false;
                            errorNombre.Text = "Solo letras";
                            error = true;
                            //agregar indicacion de que esta mal el formato del nombre
                        }

                        if (validaciones.soloLetras(txtApel.Text))
                        {
                            nuevo.Apellido = txtApel.Text;
                        }
                        else
                        {
                            txtApel.ReadOnly = false;
                            errorApel.Text = "Solo letras";
                            error = true;
                        }

                        if (validaciones.Validaremail(txtEmail.Text))
                        {
                            nuevo.Email = txtEmail.Text;
                        }
                        else
                        {
                            txtEmail.ReadOnly = false;
                            errorEmail.Text = "Formato incorrecto";

                            error = true;
                            //agregar indicacion de que esta mal el formato del email
                        }

                        if (!validaciones.soloNumeros(txtDirec.Text) && !validaciones.soloLetras(txtDirec.Text))
                        {
                            nuevo.Direccion = txtDirec.Text;
                        }
                        else
                        {
                            txtDirec.ReadOnly = false;
                            errorDirec.Text = "No se puede ingresar solo letras o solo numeros";
                            error = true;
                        }

                        if (!validaciones.soloNumeros(txtciud.Text))
                        {
                            nuevo.Ciudad = txtciud.Text;
                        }
                        else
                        {
                            txtciud.ReadOnly = false;
                            errorCiud.Text = "No se pueden ingresar solo numeros";
                            error = true;
                        }

                        if (validaciones.soloNumeros(txtCP.Text))
                        {
                            nuevo.CP = int.Parse(txtCP.Text);
                        }
                        else
                        {
                            txtCP.ReadOnly = false;
                            errorCp.Text = "Solo numeros";
                            error = true;
                        }

                        if (error == true)
                        {
                            return;
                        }

                        clineg.addCliente(nuevo);

                        //completos los atributos del voucher

                        /*Voucher voucher = new Voucher();
                        VoucherNegocio vouneg = new VoucherNegocio();
                        try
                        {
                            voucher.Articulo= 99;              //deberia tomar el id del articulo de la "sesion"
                            voucher.FechaCanje = "gatdate()";          // deveria devolver el dia de hoy cuando pasa a la base de datos (comando de sql server)
                            voucher.CodigoVoucher = codigo;                      // toma el codigo del voucher de la "sesion"
                            voucher.Cliente= clineg.FindCliente(dni);                        //toma el cliente obtenido en la busqeda

                            vouneg.cargar(voucher);                //carga las demas columnas de la tabla de vaucher

                        }
                        catch (Exception ex)
                        {
                            // MessageBox.Show(ex.ToString());
                        }*/

                        Response.Redirect("CanjeCorrecto.aspx", false);
                    }
                }
            }

        }

    }
}




