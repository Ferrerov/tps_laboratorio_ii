using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;

namespace Biblioteca
{
    public static class GestorBaseDeDatos
    {
        private static string connectionString;
        private static SqlConnection connection;
        private static SqlCommand command;

        static GestorBaseDeDatos()
        {
            connectionString = "Server=.;Database=MUNDOPC_CLIENTES;Trusted_Connection=True";
            connection = new SqlConnection(connectionString);
            command = new SqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.Connection = connection;
        }

        public static bool LeerBaseDeDatos(out ListadoGenerico<Cliente> listadoDeClientes)
        {
            try
            {
                ListadoGenerico<Cliente> listadoDeClientesAux = new ListadoGenerico<Cliente>(0);
                connection.Open();
                command.CommandText = "SELECT * FROM CLIENTES";
                using (SqlDataReader dataReader = command.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        listadoDeClientesAux.AgregarElemento(new Cliente(Convert.ToInt32(dataReader["ID"]), 
                            dataReader["NOMBRE"].ToString(), 
                            Convert.ToInt64(dataReader["DNI"]),
                            Convert.ToInt64(dataReader["TELEFONO"]),
                            (dataReader["DIRECCION"]).ToString(),
                            (dataReader["EMAIL"]).ToString()));
                    }
                    listadoDeClientes = listadoDeClientesAux;
                    return true;
                }
            }
            catch (Exception)
            {
                throw new ErrorBaseDeDatosException("Error al leer la base de datos.");
            }
            finally
            {
                connection.Close();
            }
        }

        public static void CargarClienteEnBaseDeDatos(Cliente cliente)
        {
            try
            {
                connection.Open();
                command.Parameters.Clear();
                command.CommandText = $"INSERT INTO CLIENTES VALUES (@NOMBRE, @DNI, @TELEFONO, @DIRECCION, @EMAIL)";
                command.Parameters.AddWithValue("@NOMBRE", cliente.Nombre);
                command.Parameters.AddWithValue("@DNI", Convert.ToInt64(cliente.Dni));
                command.Parameters.AddWithValue("@TELEFONO", Convert.ToInt64(cliente.Telefono));
                command.Parameters.AddWithValue("@DIRECCION", cliente.Direccion);
                command.Parameters.AddWithValue("@EMAIL", cliente.Email);
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw new ErrorBaseDeDatosException("Error al escribir en la base de datos.");
            }
            finally
            {
                connection.Close();
            }
        }

        public static void EliminarClienteEnBaseDeDatos(Cliente cliente)
        {
            try
            {
                connection.Open();
                command.Parameters.Clear();
                command.CommandText = $"DELETE FROM CLIENTES WHERE ID = @ID";
                command.Parameters.AddWithValue("@ID", cliente.Id);
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw new ErrorBaseDeDatosException("Error al eliminar en la base de datos.");
            }
            finally
            {
                connection.Close();
            }
        }
        public static void ModificarClienteEnBaseDeDatos(Cliente cliente)
        {
            try
            {
                connection.Open();
                command.Parameters.Clear();
                command.CommandText = $"UPDATE CLIENTES SET NOMBRE=@NOMBRE, DNI=@DNI, TELEFONO=@TELEFONO, DIRECCION=@DIRECCION, EMAIL=@EMAIL WHERE ID={cliente.Id}";
                command.Parameters.AddWithValue("@NOMBRE", cliente.Nombre);
                command.Parameters.AddWithValue("@DNI", Convert.ToInt64(cliente.Dni));
                command.Parameters.AddWithValue("@TELEFONO", Convert.ToInt64(cliente.Telefono));
                command.Parameters.AddWithValue("@DIRECCION", cliente.Direccion);
                command.Parameters.AddWithValue("@EMAIL", cliente.Email);
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw new ErrorBaseDeDatosException("Error al actualizar en la base de datos.");
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
