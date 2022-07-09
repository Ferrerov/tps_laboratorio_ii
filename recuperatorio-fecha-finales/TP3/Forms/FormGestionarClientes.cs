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
        public FormGestionarClientes(List<Cliente> listaDeClientes)
        {
            InitializeComponent();
            this.listaDeClientes = listaDeClientes;
        }

        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            FormDatosCliente formDatoCliente = new FormDatosCliente("NUEVO CLIENTE");
            if(formDatoCliente.ShowDialog() == DialogResult.OK)
            {
                listaDeClientes.Add(formDatoCliente.cliente);
                CargarListaDeClientes();
            }
        }
        private void CargarListaDeClientes()
        {
            this.dgvListaClientes.DataSource = null;
            this.dgvListaClientes.DataSource = this.listaDeClientes;
            dgvListaClientes.Columns[0].Width = 180;
            dgvListaClientes.Columns[1].Width = 57;
            dgvListaClientes.Columns[2].Width = 90;
            dgvListaClientes.Columns[3].Width = 200;
            dgvListaClientes.Columns[4].Width = 189;
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
            FormDatosCliente formDatoCliente = new FormDatosCliente("MODIFICAR CLIENTE");
            //Cliente clienteAux = ((Cliente)this.dgvListaClientes.CurrentRow.DataBoundItem);
            if (formDatoCliente.ShowDialog() == DialogResult.OK)
            {
                listaDeClientes.Add(formDatoCliente.cliente);
                CargarListaDeClientes();
            }
        }
    }
}
