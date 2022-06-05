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
    public partial class FormEliminarCliente : Form
    {
        public List<Cliente> clientes;
        public FormEliminarCliente(List<Cliente> clientes)
        {
            InitializeComponent();
            this.clientes = clientes;
            CargarListaDeClientes();
        }

        public void CargarListaDeClientes()
        {
            this.dgvClientes.DataSource = null;
            this.dgvClientes.DataSource = this.clientes;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(this.dgvClientes.CurrentRow.DataBoundItem is not null)
            {
                clientes.Remove((Cliente)this.dgvClientes.CurrentRow.DataBoundItem);
                MessageBox.Show("Cliente eliminado correctamente", "Eliminacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Seleccione un cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
