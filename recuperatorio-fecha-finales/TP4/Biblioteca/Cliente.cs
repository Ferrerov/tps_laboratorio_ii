using System;

namespace Biblioteca
{
    public class Cliente
    {
        #region Atributos
        private string nombre;
        private long dni;
        private long telefono;
        private string direccion;
        private string email;
        #endregion

        #region Constructores
        public Cliente(string nombre, long dni, long telefono, string direccion, string email)
        {
            this.nombre = nombre;
            this.dni = dni;
            this.telefono = telefono;
            this.direccion = direccion;
            this.email = email;
        }
        #endregion

        #region Propiedades
        public string Nombre { get => nombre; set => nombre = value; }
        public long Dni { get => dni; set => dni = value; }
        public long Telefono { get => telefono; set => telefono = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Email { get => email; set => email = value; }
        #endregion

        #region Metodos

        #endregion

        #region Sobrecargas

        #endregion
    }
}
