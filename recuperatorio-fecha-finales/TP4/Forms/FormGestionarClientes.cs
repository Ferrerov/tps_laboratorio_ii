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
using Archivos;
using Excepciones;

namespace Forms
{
    public partial class FormGestionarClientes : Form
    {
        public ListadoGenerico<Servicio> listaDeServicios;
        public ListadoGenerico<Cliente> listaDeClientes;
        private BindingSource source;
        public Cliente clienteSeleccionado;
        public FormGestionarClientes(ListadoGenerico<Servicio> listaDeServicios)
        {
            InitializeComponent();
            this.listaDeServicios = listaDeServicios;
            source = new BindingSource();
            CargarListaDeClientes();
            this.dgvListaClientes.RowHeadersVisible = false;
            this.dgvListaClientes.Columns["Id"].Width = 46;
            this.dgvListaClientes.Columns["Id"].DefaultCellStyle.Format = "D3";
            this.dgvListaClientes.Columns["Nombre"].Width = 276;
            this.dgvListaClientes.Columns["Direccion"].Width = 300;
            this.dgvListaClientes.Columns["Dni"].Width = 101;
            this.dgvListaClientes.Columns["Telefono"].Width = 127;
            this.dgvListaClientes.Columns["Email"].Width = 305;
        }

        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            FormDatosCliente formDatoCliente = new FormDatosCliente("NUEVO CLIENTE", null);
            if(formDatoCliente.ShowDialog() == DialogResult.OK)
            {
                GestorBaseDeDatos.CargarClienteEnBaseDeDatos(formDatoCliente.clienteNuevo);
                CargarListaDeClientes();
            }
        }
        private void CargarListaDeClientes()
        {
            ListadoGenerico<Cliente> listadoAux;
            if (GestorBaseDeDatos.LeerBaseDeDatos(out listadoAux))
            {
                this.listaDeClientes = listadoAux;
            }
            OrdenarListadoPorNombreAscendente(this.listaDeClientes.listado, out this.listaDeClientes.listado);
            source.DataSource = this.listaDeClientes.listado;
            this.dgvListaClientes.DataSource = source;
            source.ResetBindings(false);
        }

        private static void OrdenarListadoPorNombreAscendente(List<Cliente> listado, out List<Cliente> listadoOrdenado)
        {
            IEnumerable<Cliente> query = listado.OrderBy(listado => listado.Nombre);
            List<Cliente> listadoAux = new List<Cliente>();
            foreach(Cliente cliente in query)
            {
                listadoAux.Add(cliente);
            }
            listadoOrdenado = listadoAux;
        }

        private void txtBoxBuscar_TextChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvListaClientes.Rows)
            {
                dgvListaClientes.CurrentCell = null;
                if (row.Cells["Id"].Value.ToString().ToLower().StartsWith(txtBoxBuscar.Text.ToLower())
                    || row.Cells["Nombre"].Value.ToString().ToLower().StartsWith(txtBoxBuscar.Text.ToLower())
                    || row.Cells["Dni"].Value.ToString().ToLower().StartsWith(txtBoxBuscar.Text.ToLower())
                    || row.Cells["Telefono"].Value.ToString().ToLower().StartsWith(txtBoxBuscar.Text.ToLower())
                    || row.Cells["Direccion"].Value.ToString().ToLower().StartsWith(txtBoxBuscar.Text.ToLower())
                    || row.Cells["Email"].Value.ToString().ToLower().StartsWith(txtBoxBuscar.Text.ToLower()))
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
                    GestorBaseDeDatos.ModificarClienteEnBaseDeDatos(formDatoCliente.clienteModificar);
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
                GestorBaseDeDatos.EliminarClienteEnBaseDeDatos(clienteEliminar);
                CargarListaDeClientes();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if(this.dgvListaClientes.SelectedRows.Count > 0)
            {
                clienteSeleccionado = (Cliente)this.dgvListaClientes.CurrentRow.DataBoundItem;
            }
            this.Close();
        }

        private void btnGuardarListado_Click(object sender, EventArgs e)
        {
            try
            {
                this.listaDeClientes.GuardarListado(AppDomain.CurrentDomain.BaseDirectory, "listaClientes.xml");
                MessageBox.Show($"Listado guardado en {AppDomain.CurrentDomain.BaseDirectory}listaClientes.xml");
                GestorTxt txt = new GestorTxt();
                txt.Guardar(AppDomain.CurrentDomain.BaseDirectory, "ultimoIdCliente.txt", this.listaDeClientes.ultimoId.ToString());
            }
            catch(ErrorArchivoException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnVerServicios_Click(object sender, EventArgs e)
        {
            if(dgvListaClientes.SelectedRows.Count > 0)
            {
                FormGestionarServicios formGestionarServicios = new FormGestionarServicios(this.listaDeServicios, this.listaDeClientes, ((Cliente)dgvListaClientes.CurrentRow.DataBoundItem).Dni);
                formGestionarServicios.lblCliente.Text += ((Cliente)dgvListaClientes.CurrentRow.DataBoundItem).Nombre;
                formGestionarServicios.ShowDialog();
                this.listaDeServicios = formGestionarServicios.listaDeServicios;
            }

        }
    }
}
