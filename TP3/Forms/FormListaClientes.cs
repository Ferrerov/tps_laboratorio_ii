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
    public partial class FormListaClientes : Form
    {
        public List<Cliente> clientes;
        public FormListaClientes(List<Cliente> clientes)
        {
            InitializeComponent();
            this.clientes = clientes;
            CargarListaClientes();

        }

        public void CargarListaClientes()
        {
            dgvListaClientes.DataSource = null;
            dgvListaClientes.DataSource = this.clientes;
        }

        public void ObtenerIndiceCliente(Cliente cliente)
        {
            foreach (Cliente clienteAux in clientes)
            {
                if(clienteAux == cliente)
                {

                }
            }
        }

    }
}
