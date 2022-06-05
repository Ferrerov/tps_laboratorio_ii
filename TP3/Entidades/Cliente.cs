using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente
    {
        private string nombre;
        private int dniCliente;
        private double saldo;
        private List<Cliente> clientes;
        private List<Compra> compras;

        #region Propiedades
        public string Nombre { get => nombre; set => nombre = value; }
        public double Saldo
        {
            get
            {
                return ObtenerSaldo(this);
            }
            set
            {
                this.saldo = value;
            }
        }

        public List<Cliente> Clientes { get => clientes; set => clientes = value; }
        public int DniCliente { get => dniCliente; set => dniCliente = value; }

        #endregion

        public Cliente()
        {
            this.clientes = new List<Cliente>();
            this.compras = new List<Compra>();
    }
        public Cliente(string nombre, int dniCliente, double saldo)
            : this()
        {
            this.nombre = nombre;
            this.dniCliente = dniCliente;
            this.saldo = saldo;
        }

        private double ObtenerSaldo(Cliente cliente)
        {
            double saldoActual = this.saldo;

            foreach (Compra compra in compras)
            {
                if(compra.DniCliente == cliente.dniCliente)
                saldoActual += compra.Total;
            }

            return saldoActual;
        }

        public string ObtenerNombreClientePorDni(int dniCliente)
        {
            foreach (Cliente cliente in this.clientes)
            {
                if(cliente is not null && cliente.dniCliente == dniCliente)
                {
                    return cliente.Nombre;
                }
            }
            return null;
        }

        public Cliente ObtenerClientePorDni(int dniCliente)
        {
            foreach (Cliente cliente in this.clientes)
            {
                if (cliente is not null && cliente.dniCliente == dniCliente)
                {
                    return cliente;
                }
            }
            return null;
        }

        public void AgregarCompra(Compra compra)
        {
            this.compras.Add(compra);
        }

        public void BorrarCompra(Compra compra)
        {
            this.compras.Remove(compra);
        }
         
        public bool CargarNuevoCliente(Cliente cliente)
        {
            if(cliente is not null)
            {
                clientes.Add(cliente);
                return true;
            }
            return false;
        }

        public bool EliminarCliente(Cliente cliente)
        {
            if(cliente is not null)
            {
                foreach (Cliente clienteAux in clientes)
                {
                    if(clienteAux == cliente)
                    {
                        clientes.Remove(clienteAux);
                        return true;
                    }
                }
            }
            return false;
        }

        public bool ModificarCliente(Cliente cliente, int dniCliente, string nombre)
        {
            if(cliente is not null)
            {
                cliente.dniCliente = dniCliente;
                cliente.nombre = nombre;
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre : {this.nombre}");
            sb.AppendLine($"Dni : {this.dniCliente}");
            sb.AppendLine($"Saldo: {this.Saldo}");

            return sb.ToString();
        }

        public static bool operator ==(Cliente clienteA, Cliente clienteB)
        {
            if(clienteA is not null && clienteB is not null)
            {
                return clienteA.dniCliente == clienteB.dniCliente;
            }
            return false;
        }
        public static bool operator !=(Cliente clienteA, Cliente clienteB)
        {
            return clienteA == clienteB;
        }
    }
}
