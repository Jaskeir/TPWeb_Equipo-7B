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
           //La consulta funciona solo esta comentado hasta terminar de definir el voucher
            database datos= new database();
            
            try
            {
                 datos.setQuery("update Vouchers set IdCliente=@Idcliente, FechaCanje=GETDATE() , IdArticulo=@idArticulo Where CodigoVoucher=@codigo");
                 datos.setParameter("@codigo", voucher.CodigoVoucher);
                 datos.setParameter("@Idcliente", voucher.Cliente.Id);
                 //datos.setParameter("@Fecha", voucher.FechaCanje);
                 datos.setParameter("@idArticulo", voucher.Articulo.Id);

                datos.execQuery();  
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.closeConnection();
            }


        }
    }
}
