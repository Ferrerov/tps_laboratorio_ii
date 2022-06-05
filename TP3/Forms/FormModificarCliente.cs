using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Forms
{
    public partial class FormModificarCliente : Form
    {
        public List<Cliente> clientes;
        public FormModificarCliente(List<Cliente> clientes)
        {
            InitializeComponent();
            this.clientes = clientes;
            CargarListaDeClientes();
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Cliente clienteAux = (Cliente)this.dgvClientes.CurrentRow.DataBoundItem;
            txtNombredelCliente.Text = clienteAux.Nombre;
            txtDniDelCliente.Text = clienteAux.DniCliente.ToString();
            txtSaldoDelCliente.Text = clienteAux.Saldo.ToString();
        }

        public void CargarListaDeClientes()
        {
            this.dgvClientes.DataSource = null;
            this.dgvClientes.DataSource = this.clientes;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            /*foreach(Cliente cliente in clientes)
            {
                if(cliente == (Cliente)this.dgvClientes.CurrentRow.DataBoundItem)
                {
                    txtNombredelCliente.Text = cliente.Nombre;
                    txtDniDelCliente.Text = int.Parse(cliente.DniCliente);
                    txtSaldoDelCliente.Text = cliente;
                }
            }*/
        }
    }
}
