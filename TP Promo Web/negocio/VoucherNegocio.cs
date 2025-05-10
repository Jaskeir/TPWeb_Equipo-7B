using dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace negocio
{
    public class VoucherNegocio
    {
        public void cargar(Voucher voucher)
        {
            database datos= new database();
            //lo dejo comentado porque en realidad hay que modificar la baseno agregar nuevos voucher
            /*try
            {
                
                 datos.setQuery("INSERT INTO Vouchers VALUES (@articulo, @Idcliente, @Fecha, @idArticulo)");
                 datos.setParameter("@codigo", voucher.CodigoVoucher);
                 datos.setParameter("@Idcliente", voucher.Cliente.Id);
                 datos.setParameter("@Fecha", voucher.FechaCanje);
                 datos.setParameter("@idArticulo", voucher.Articulo.Id);



                datos.execQuery();  

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.closeConnection();
            }*/


        }
    }
}
