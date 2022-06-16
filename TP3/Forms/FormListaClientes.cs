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
        public Cliente clienteSeleccionado;
        public FormListaClientes(List<Cliente> clientes, string txtTerminar, string txtSeleccion)
        {
            InitializeComponent();
            this.clientes = clientes;
            CargarListaClientes();
            this.btnTerminar.Text = txtTerminar;
            this.btnSeleccionar.Text = txtSeleccion;

        }

        public void CargarListaClientes()
        {
            dgvListaClientes.DataSource = null;
            dgvListaClientes.DataSource = this.clientes;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                int indiceFila = -1;

                foreach (DataGridViewRow fila in dgvListaClientes.Rows)
                {
                    if (fila.Cells["DniCliente"].Value.ToString().Equals(txtDniCliente.Text))
                    {
                        indiceFila = fila.Index;
                        break;
                    }
                }
                dgvListaClientes.ClearSelection();
                dgvListaClientes.Rows[indiceFila].Selected = true;
            }
            catch (Exception)
            {
                MessageBox.Show("No se ha encontrado el cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnTerminar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            this.clienteSeleccionado = ((Cliente)this.dgvListaClientes.CurrentRow.DataBoundItem);
        }
    }
}
