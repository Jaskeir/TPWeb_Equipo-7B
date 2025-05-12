using dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace negocio
{
    public class ClienteNegocio
    {
        public Cliente FindCliente(string dni)
        {
            database datos = new database();
            Cliente aux = new Cliente();

            try
            {
                datos.setQuery("Select Id,Documento,Nombre,Apellido,Email,Direccion,Ciudad,CP from Clientes where Documento = @dni");
                datos.setParameter("@dni", dni);
                datos.execQuery();

                if (datos.Lector.Read())
                {

                    aux.Id = (int)datos.Lector["Id"];
                    aux.Documento = (string)datos.Lector["Documento"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Apellido = (string)datos.Lector["Apellido"];
                    aux.Email = (string)datos.Lector["Email"];
                    aux.Direccion = (string)datos.Lector["Direccion"];
                    aux.Ciudad = (string)datos.Lector["Ciudad"];
                    aux.CP = (int)datos.Lector["CP"];
                }
                else
                {
                    aux.Id = -1;
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
            return aux;
        }
        public bool addCliente(Cliente cliente)
        {
            database databaseCliente = new database();
            try
            {
                databaseCliente.setQuery("INSERT INTO Clientes (Documento,Nombre,Apellido,Email,Direccion,Ciudad,CP) VALUES (@Documento,@nombre,@Apellido,@mail,@Direccion,@Ciudad,@CP)");
                databaseCliente.setParameter("@Documento", cliente.Documento);
                databaseCliente.setParameter("@nombre", cliente.Nombre);
                databaseCliente.setParameter("@Apellido", cliente.Apellido);
                databaseCliente.setParameter("@mail", cliente.Email);
                databaseCliente.setParameter("@Direccion", cliente.Direccion);
                databaseCliente.setParameter("@Ciudad", cliente.Ciudad);
                databaseCliente.setParameter("@CP", cliente.CP);

                databaseCliente.execQuery();
                return true;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                databaseCliente.closeConnection();
            }
        }
    }
}
