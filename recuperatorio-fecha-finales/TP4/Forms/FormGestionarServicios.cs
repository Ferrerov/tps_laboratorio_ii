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

namespace Forms
{
    public partial class FormGestionarServicios : Form
    {
        event DelegadoFechaDeEntregaExcedida eventoFechaDeEntregaExcedida;
        public ListadoGenerico<Servicio> listaDeServicios;
        public ListadoGenerico<Cliente> listaDeClientes;
        private long dniCliente;
        private BindingSource source1;
        private BindingSource source2;

        public FormGestionarServicios(ListadoGenerico<Servicio> listaDeServicios, ListadoGenerico<Cliente> listaDeClientes, long dniCliente)
        {
            InitializeComponent();
            source1 = new BindingSource();
            source2 = new BindingSource();
            this.listaDeServicios = listaDeServicios;
            this.listaDeClientes = listaDeClientes;
            this.dniCliente = dniCliente;
            eventoFechaDeEntregaExcedida = MensajeFechaExcedida;
        }
        private void CargarListaDeServicios(long dniCliente)
        {

            source1.DataSource = this.listaDeServicios.listado;
            this.dgvListaServiciosPendientes.DataSource = source1;
            source1.ResetBindings(false);
            this.dgvListaServiciosPendientes.CurrentCell = null;
            foreach (DataGridViewRow row in dgvListaServiciosPendientes.Rows)
            {
                if ((bool)row.Cells["Completado"].Value != false)
                {
                    row.Visible = false;
                }
            }

            source2.DataSource = this.listaDeServicios.listado;
            this.dgvListaServiciosCompletados.DataSource = source2;
            source2.ResetBindings(false);
            this.dgvListaServiciosCompletados.CurrentCell = null;
            foreach (DataGridViewRow row in dgvListaServiciosCompletados.Rows)
            {
                if ((bool)row.Cells["Completado"].Value != true)
                {
                    row.Visible = false;
                }
            }

            if (dniCliente != 0)
            {
                foreach (DataGridViewRow row in dgvListaServiciosPendientes.Rows)
                {
                    if ((long)row.Cells["DniCliente"].Value != dniCliente)
                    {
                        row.Visible = false;
                    }
                }
                foreach (DataGridViewRow row in dgvListaServiciosCompletados.Rows)
                {
                    if ((long)row.Cells["DniCliente"].Value != dniCliente)
                    {
                        row.Visible = false;
                    }
                }
            }
        }

        private void FormGestionarServicios_Load(object sender, EventArgs e)
        {
            CargarListaDeServicios(this.dniCliente);
            dgvListaServiciosPendientes.RowHeadersVisible = false;
            dgvListaServiciosCompletados.RowHeadersVisible = false;
            dgvListaServiciosPendientes.Columns["Completado"].Visible = false;
            dgvListaServiciosCompletados.Columns["Completado"].Visible = false;
            dgvListaServiciosPendientes.Columns["Fecha"].Visible = false;
            dgvListaServiciosCompletados.Columns["Fecha"].Visible = false;
            dgvListaServiciosPendientes.Columns["Id"].Width = 50;
            dgvListaServiciosPendientes.Columns["Id"].DefaultCellStyle.Format = "D3";
            dgvListaServiciosCompletados.Columns["Id"].Width = 50;
            dgvListaServiciosCompletados.Columns["Id"].DefaultCellStyle.Format = "D3";
            dgvListaServiciosPendientes.Columns["DniCliente"].Width = 101;
            dgvListaServiciosCompletados.Columns["DniCliente"].Width = 101;
            dgvListaServiciosPendientes.Columns["Costo"].Width = 89;
            dgvListaServiciosCompletados.Columns["Costo"].Width = 89;
            dgvListaServiciosPendientes.Columns["TipoServicio"].Width = 113;
            dgvListaServiciosCompletados.Columns["TipoServicio"].Width = 113;
            dgvListaServiciosPendientes.Columns["Dispositivo"].Width = 133;
            dgvListaServiciosCompletados.Columns["Dispositivo"].Width = 133;
            dgvListaServiciosPendientes.Columns["Detalle"].Width = 662;
            dgvListaServiciosCompletados.Columns["Detalle"].Width = 662;
            dgvListaServiciosPendientes.Columns["FechaEntrega"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvListaServiciosCompletados.Columns["FechaEntrega"].DefaultCellStyle.Format = "dd/MM/yyyy";
            VerificarFechasEntrega();
        }

        private void btnMarcarComoCompletado_Click(object sender, EventArgs e)
        {
            if(this.dgvListaServiciosPendientes.SelectedRows.Count > 0)
            {
                if(MessageBox.Show("Seguro que desea marcar el servicio como 'Completado'? ", "Completar servicio", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ((Servicio)this.dgvListaServiciosPendientes.CurrentRow.DataBoundItem).Completado = true;
                    CargarListaDeServicios(this.dniCliente);
                }
            }
        }

        private void btnMarcarComoPendiente_Click(object sender, EventArgs e)
        {
            if (this.dgvListaServiciosCompletados.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Seguro que desea marcar el servicio como 'Pendiente'? ", "Completar servicio", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ((Servicio)this.dgvListaServiciosCompletados.CurrentRow.DataBoundItem).Completado = false;
                    CargarListaDeServicios(this.dniCliente);
                }
            }
        }

        private void btnNuevoServicio_Click(object sender, EventArgs e)
        {
            FormGestionarClientes formGestionarClientes = new FormGestionarClientes(this.listaDeServicios);
            formGestionarClientes.btnEliminarCliente.Hide();
            formGestionarClientes.btnModificarCliente.Hide();
            formGestionarClientes.btnSeleccionar.Show();
            formGestionarClientes.ShowDialog();
            if(formGestionarClientes.clienteSeleccionado is not null)
            {
                FormAtender formAtender = new FormAtender(formGestionarClientes.clienteSeleccionado, this.listaDeServicios.ultimoId);
                formGestionarClientes.Dispose();
                formAtender.ShowDialog();
                try
                {
                    this.listaDeServicios.AgregarElemento(formAtender.servicio);
                    this.listaDeServicios.ultimoId++;
                    CargarListaDeServicios(0);
                }
                catch (Exception)
                {
                    MessageBox.Show("No se ha cargado ningun servicio!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnGuardarListado_Click(object sender, EventArgs e)
        {
            if (this.listaDeServicios.GuardarListado(AppDomain.CurrentDomain.BaseDirectory, "listaServicios.xml"))
            {
                MessageBox.Show($"Listado guardado en {AppDomain.CurrentDomain.BaseDirectory}listaServicios.xml");
                GestorTxt txt = new GestorTxt();
                txt.Guardar(AppDomain.CurrentDomain.BaseDirectory, "ultimoIdServicio.txt", this.listaDeClientes.ultimoId.ToString());
            }
            else
            {
                MessageBox.Show("No se pudo guardar.");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminarServicio_Click(object sender, EventArgs e)
        {
            if(this.dgvListaServiciosPendientes.SelectedRows.Count > 0)
            {
                Servicio servicioEliminar = (Servicio)this.dgvListaServiciosPendientes.CurrentRow.DataBoundItem;
                if (MessageBox.Show($"Seguro que desea eliminar el servicio?", "Eliminar servicio", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (listaDeServicios.EliminarElemento(servicioEliminar))
                    {
                        MessageBox.Show($"Servicio eliminado.");
                        CargarListaDeServicios(0);
                    }
                    else
                    {
                        MessageBox.Show("error");
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione un servicio de la lista de pendientes!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void MensajeFechaExcedida()
        {
            MessageBox.Show("Hay servicios excedidos de la fecha de entrega estipulada!", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void VerificarFechasEntrega()
        {
            foreach (Servicio servicio in this.listaDeServicios.listado)
            {
                if (servicio.FechaEntrega < DateTime.Now && servicio.Completado == false)
                {
                    eventoFechaDeEntregaExcedida.Invoke();
                    break;
                }
            }
        }
    }
}
