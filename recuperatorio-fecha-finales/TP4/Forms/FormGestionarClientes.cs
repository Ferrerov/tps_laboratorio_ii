using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca;

namespace Forms
{
    public partial class FormGestionarClientes : Form
    {
        public List<Cliente> listaDeClientes;
        private BindingSource source;
        public FormGestionarClientes(List<Cliente> listaDeClientes)
        {
            InitializeComponent();
            this.listaDeClientes = listaDeClientes;
            source = new BindingSource();
            CargarListaDeClientes();

        }

        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            FormDatosCliente formDatoCliente = new FormDatosCliente("NUEVO CLIENTE 88", null);
            if(formDatoCliente.ShowDialog() == DialogResult.OK)
            {
                listaDeClientes.Add(formDatoCliente.clienteNuevo);
                CargarListaDeClientes();
            }
        }
        private void CargarListaDeClientes()
        {
            //this.dgvListaClientes.DataSource = null;
            source.DataSource = this.listaDeClientes;
            this.dgvListaClientes.DataSource = source;
            source.ResetBindings(false);
        }

        private void txtBoxBuscar_TextChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvListaClientes.Rows)
            {
                dgvListaClientes.CurrentCell = null;
                if (row.Cells[0].Value.ToString().ToLower().StartsWith(txtBoxBuscar.Text.ToLower()))
                {
                    row.Visible = true;
                }
                else
                {
                    row.Visible = false;
                }
            }
        }

        private void btnModificarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                FormDatosCliente formDatoCliente = new FormDatosCliente("MODIFICAR CLIENTE", (Cliente)this.dgvListaClientes.CurrentRow.DataBoundItem);
                if (formDatoCliente.ShowDialog() == DialogResult.OK)
                {
                    CargarListaDeClientes();
                }
            }
            catch(Exception)
            {
                MessageBox.Show("No hay ningun cliente seleccionado!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            Cliente clienteEliminar = (Cliente)this.dgvListaClientes.CurrentRow.DataBoundItem;
            if (MessageBox.Show($"Seguro que desea eliminar el cliente {clienteEliminar.Nombre}?", "Eliminar cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                listaDeClientes.Remove(clienteEliminar);
                CargarListaDeClientes();
            }
        }
    }
}
