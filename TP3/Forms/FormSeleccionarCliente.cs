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
    public partial class FormSeleccionarCliente : Form
    {
        public List<Cliente> clientes;
        public FormSeleccionarCliente(List<Cliente> clientes)
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            FormNuevaCompra formNuevaCompra = new FormNuevaCompra((Cliente)dgvListaClientes.SelectedRows[0].DataBoundItem);
            formNuevaCompra.ShowDialog();
        }
    }
}
