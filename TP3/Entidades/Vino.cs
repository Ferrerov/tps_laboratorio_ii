using System;
using System.Text;

namespace Entidades
{
    public class Vino
    {
        private string marca;
        private ETipoVino tipo;
        private float precio;

        #region Propiedades
        public float Precio
        {
            get
            {
                return this.precio;
            }
            set
            {
                this.precio = value;
            }
        }
        public string Marca
        {
            get
            {
                return this.marca;
            }
            set
            {
                this.marca = value;
            }
        }
        public ETipoVino Tipo
        {
            get
            {
                return this.tipo;
            }
            set
            {
                this.tipo = value;
            }
        }
        #endregion

        public Vino(float precio, string marca, ETipoVino tipo)
        {
            this.marca = marca;
            this.tipo = tipo;
            this.precio = precio;
        }       

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Marca :{this.marca}");
            sb.AppendLine($"Tipo: {this.tipo}");
            sb.AppendLine($"Precio: {this.precio}");

            return sb.ToString();
        }
    }
}
