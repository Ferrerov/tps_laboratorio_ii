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
    public partial class FormMenuPrincipal : Form
    {
        public List<Cliente> listaDeClientes;
        public FormMenuPrincipal()
        {
            InitializeComponent();
            this.listaDeClientes = new List<Cliente>();
        }

        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            FormNuevoCliente formNuevoCliente = new FormNuevoCliente();
            if(formNuevoCliente.ShowDialog() == DialogResult.OK)
            {
                this.listaDeClientes.Add(formNuevoCliente.cliente);
                CargarListaDeClientes();
            }
        }

        private void CargarListaDeClientes()
        {
            this.lstBoxClientes.DataSource = null;
            this.lstBoxClientes.DataSource = this.listaDeClientes;
            
        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            FormEliminarCliente formEliminarCliente = new FormEliminarCliente(this.listaDeClientes);
            if (formEliminarCliente.ShowDialog() == DialogResult.OK)
            {
                this.listaDeClientes = formEliminarCliente.clientes;
                CargarListaDeClientes();
            }
        }

        private void btnModificarCliente_Click(object sender, EventArgs e)
        {
            FormModificarCliente formModificarCliente = new FormModificarCliente(this.listaDeClientes);
            if (formModificarCliente.ShowDialog() == DialogResult.OK)
            {
                this.listaDeClientes = formModificarCliente.clientes;
                CargarListaDeClientes();
            }
        }

        private void btnListadoClientes_Click(object sender, EventArgs e)
        {
            if(this.listaDeClientes.Count > 0)
            {
                FormListaClientes formListaClientes = new FormListaClientes(this.listaDeClientes);
                formListaClientes.ShowDialog();
            }
            else
            {
                MessageBox.Show("No hay clientes en el sistema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnNuevaCompra_Click(object sender, EventArgs e)
        {
            FormNuevaCompra formNuevaCompra = new FormNuevaCompra();
            formNuevaCompra.ShowDialog();
        }
    }
}
