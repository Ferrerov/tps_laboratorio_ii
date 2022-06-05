using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Compra
    {
        private int dniCliente;
        private int idCompra;
        private DateTime fecha;
        private string detalle;
        private double total;
        private List<Vino> vinos;
        private Cliente cliente;

        public int IdCompra { get => idCompra; set => idCompra = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public string Detalle { get => detalle; set => detalle = value; }
        public double Total { 
            get
            {
                return ObtenerTotal();
            }
            set => total = value; }
        public List<Vino> Vinos { get => vinos; set => vinos = value; }
        public int DniCliente { get => dniCliente; set => dniCliente = value; }

        public Compra()
        {
            this.vinos = new List<Vino>();
        }
        public Compra(int dniCliente, int idCompra, DateTime fecha, string detalle, double total, List<Vino> vinos)
            :this()
        {
            this.dniCliente = dniCliente;
            this.idCompra = idCompra;
            this.fecha = fecha;
            this.detalle = detalle;
            this.total = total;
            this.vinos = vinos;
        }

        public string ConfeccionDetalle()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre del cliente :{cliente.ObtenerNombreClientePorDni(this.dniCliente)}");
            sb.AppendLine($"Dni del cliente: {this.dniCliente}");
            sb.AppendLine($"Id de la compra: {this.idCompra}");
            sb.AppendLine($"Fecha: {this.fecha}");
            sb.AppendLine($"Total: {this.Total}");

            return sb.ToString();
        }

        public double ObtenerTotal()
        {
            double total = 0;

            foreach (Vino vino in vinos)
            {
                total += vino.Precio;
            }

            return total;
        }

    }
}
