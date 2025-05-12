using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
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
            codigo = Session["Code"].ToString();

            productName.Text = articulo.Nombre;
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

        private void registrarCanjeoVoucher(Cliente cliente)
        {
            Voucher voucher = new Voucher();
            VoucherNegocio voucherNegocio = new VoucherNegocio();

            try
            {
                voucher.Articulo = articulo;
                voucher.CodigoVoucher = codigo;
                voucher.Cliente = cliente;

                voucherNegocio.cargar(voucher);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
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

            if (dni.Length < 7 || dni.Length >= 9)
            {
                return;
            }
            if (!validaciones.soloNumeros(dni))
            {
                return;
            }
            Cliente nuevo = new Cliente();
            ClienteNegocio clineg = new ClienteNegocio();
            nuevo = clineg.FindCliente(dni);

            if (nuevo.Id != -1) // Cliente existente (Porque ID es distinto a -1)
            {
                registrarCanjeoVoucher(nuevo);
                Session.Add("email", txtEmail.Text);
                Response.Redirect("CanjeCorrecto.aspx", false);
                return;
            }

            nuevo.Documento = txtDNI.Text;

            if (string.IsNullOrWhiteSpace(txtname.Text))
            {
                txtname.ReadOnly = false;
                errorNombre.Text = "no puede estar vacío";
                error = true;
            }
            else if (!validaciones.soloLetras(txtname.Text))
            {
                txtname.ReadOnly = false;
                errorNombre.Text = "Solo letras";
                error = true;
            }
            else
            {
                nuevo.Nombre = txtname.Text;
            }

            // Validacion del apellido
            if (string.IsNullOrWhiteSpace(txtApel.Text))
            {
                txtApel.ReadOnly = false;
                errorApel.Text = "no puede estar vacio";
                error = true;
            }
            else if (!validaciones.soloLetras(txtApel.Text))
            {
                txtApel.ReadOnly = false;
                errorApel.Text = "Solo letras";
                error = true;
            }
            else
            {
                nuevo.Apellido = txtApel.Text;
            }

            // Validacion del email
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                txtEmail.ReadOnly = false;
                errorEmail.Text = "no puede estar vacio";
                error = true;
            }
            else if (!validaciones.Validaremail(txtEmail.Text))
            {
                txtEmail.ReadOnly = false;
                errorEmail.Text = "Formato incorrecto";
                error = true;
            }
            else
            {
                nuevo.Email = txtEmail.Text;
            }

            // Validacion de la direccion
            if (string.IsNullOrWhiteSpace(txtDirec.Text))
            {
                txtDirec.ReadOnly = false;
                errorDirec.Text = "no puede estar vacio";
                error = true;
            }
            else if (validaciones.soloNumeros(txtDirec.Text) || validaciones.soloLetras(txtDirec.Text))
            {
                txtDirec.ReadOnly = false;
                errorDirec.Text = "No se puede ingresar solo letras o solo numeros";
                error = true;
            }
            else
            {
                nuevo.Direccion = txtDirec.Text;
            }

            // Validacion de la ciudad
            if (string.IsNullOrWhiteSpace(txtciud.Text))
            {
                txtciud.ReadOnly = false;
                errorCiud.Text = "El campo ciudad no puede estar vacio";
                error = true;
            }
            else if (validaciones.soloNumeros(txtciud.Text))
            {
                txtciud.ReadOnly = false;
                errorCiud.Text = "No se pueden ingresar solo numeros";
                error = true;
            }
            else
            {
                nuevo.Ciudad = txtciud.Text;
            }

            // Validacion del codigo postal
            if (string.IsNullOrWhiteSpace(txtCP.Text))
            {
                txtCP.ReadOnly = false;
                errorCp.Text = "No puede estar vacio";
                error = true;
            }
            else if (!validaciones.soloNumeros(txtCP.Text))
            {
                txtCP.ReadOnly = false;
                errorCp.Text = "Solo numeros";
                error = true;
            }
            else
            {
                nuevo.CP = int.Parse(txtCP.Text);
            }

            if (error == true)
            {
                return;
            }
            clineg.addCliente(nuevo);
            registrarCanjeoVoucher(clineg.FindCliente(dni));
            Session.Add("email", txtEmail.Text);
            Response.Redirect("CanjeCorrecto.aspx", false);
        }
    }
}




