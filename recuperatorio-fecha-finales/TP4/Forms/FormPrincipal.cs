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
    public delegate void DelegadoActualizarListado();
    public delegate void DelegadoFechaDeEntregaExcedida();
    public partial class FormPrincipal : Form
    {
        event DelegadoFechaDeEntregaExcedida eventoFechaDeEntregaExcedida;
        private ListadoGenerico<Cliente> listaDeClientes;
        private ListadoGenerico<Servicio> listaDeServicios;
        private BindingSource sourceServicios;
        private int ultimoIdServicio = 0;
        private GestorTxt txt;
        private DelegadoActualizarListado delegadoActualizarListado;

        public FormPrincipal()
        {
            InitializeComponent();
            this.txt = new GestorTxt();
            this.listaDeClientes = new ListadoGenerico<Cliente>(0);
            this.listaDeServicios = new ListadoGenerico<Servicio>(ultimoIdServicio);
            sourceServicios = new BindingSource();
            delegadoActualizarListado = OrdenarListadoPorFechaAscendente;
            delegadoActualizarListado += CargarListaDeServicios;
            delegadoActualizarListado += VerificarFechasEntrega;
            eventoFechaDeEntregaExcedida = MensajeFechaExcedida;
        }
        private async void FormPrincipal_Load(object sender, EventArgs e)
        {
            await Task.Run(() => { 
            if (txt.Leer(AppDomain.CurrentDomain.BaseDirectory, "ultimoIdServicio.txt", out string strUltimoIdServicio))
            {
                ultimoIdServicio = int.Parse(strUltimoIdServicio);
            }
            ListadoGenerico<Cliente> listadoAux;
            if (GestorBaseDeDatos.LeerBaseDeDatos(out listadoAux))
            {
                this.listaDeClientes = listadoAux;
            }
            });
            if (this.listaDeServicios.LeerListado(AppDomain.CurrentDomain.BaseDirectory, "listaServicios.xml"))
            {
                delegadoActualizarListado.Invoke();
            }
        }

        private void btnGestionarClientes_Click(object sender, EventArgs e)
        {
            FormGestionarClientes formGestionarClientes = new FormGestionarClientes(this.listaDeServicios);
            formGestionarClientes.ShowDialog();
            this.listaDeClientes = formGestionarClientes.listaDeClientes;
            this.listaDeServicios = formGestionarClientes.listaDeServicios;
            formGestionarClientes.Dispose();
            delegadoActualizarListado.Invoke();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAtender_Click(object sender, EventArgs e)
        {
            FormGestionarClientes formGestionarClientes = new FormGestionarClientes(this.listaDeServicios);
            formGestionarClientes.btnEliminarCliente.Hide();
            formGestionarClientes.btnModificarCliente.Hide();
            formGestionarClientes.btnSeleccionar.Show();
            formGestionarClientes.ShowDialog();
            this.listaDeClientes = formGestionarClientes.listaDeClientes;

            if(formGestionarClientes.clienteSeleccionado is not null)
            {
                FormAtender formAtender = new FormAtender(formGestionarClientes.clienteSeleccionado, this.listaDeServicios.ultimoId);
                formGestionarClientes.Dispose();
                formAtender.ShowDialog();
                try
                {
                    this.listaDeServicios.AgregarElemento(formAtender.servicio);
                    this.listaDeServicios.ultimoId++;
                    delegadoActualizarListado.Invoke();
                }
                catch (Exception)
                {
                    MessageBox.Show("No se ha cargado ningun servicio!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void CargarListaDeServicios()
        {
            sourceServicios.DataSource = this.listaDeServicios.listado;
            this.dgvListaServicios.DataSource = sourceServicios;
            this.dgvListaServicios.RowHeadersVisible = false;
            this.dgvListaServicios.Columns["Fecha"].Visible = false;
            this.dgvListaServicios.Columns["Costo"].Visible = false;
            this.dgvListaServicios.Columns["Completado"].Visible = false;
            this.dgvListaServicios.Columns["DniCliente"].Visible = false;
            this.dgvListaServicios.Columns["Dispositivo"].Visible = false;
            this.dgvListaServicios.Columns["Id"].Width = 50;
            this.dgvListaServicios.Columns["FechaEntrega"].Width = 113;
            this.dgvListaServicios.Columns["Detalle"].Width = 410;
            this.dgvListaServicios.Columns["FechaEntrega"].DefaultCellStyle.Format = "dd/MM/yyyy";
            sourceServicios.ResetBindings(false);
            lblFechaEntregaExcedida.Visible = false;
        }

        public void OrdenarListadoPorFechaAscendente()
        {
            if(this.listaDeServicios.listado is not null)
            {
                IEnumerable<Servicio> query = this.listaDeServicios.listado.OrderBy(listado => listado.FechaEntrega);
                List<Servicio> listadoAux = new List<Servicio>();
                foreach (Servicio cliente in query)
                {
                    listadoAux.Add(cliente);
                }
                this.listaDeServicios.listado = listadoAux;
            }
        }

        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Desea guardar todos los cambios realizados?", "Salir", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (resultado != DialogResult.Cancel)
            {
                if(resultado == DialogResult.Yes)
                {
                    this.listaDeClientes.GuardarListado(AppDomain.CurrentDomain.BaseDirectory, "listaClientes.xml");
                    this.listaDeServicios.GuardarListado(AppDomain.CurrentDomain.BaseDirectory, "listaServicios.xml");
                    GestorTxt txt = new GestorTxt();
                    txt.Guardar(AppDomain.CurrentDomain.BaseDirectory, "ultimoIdCliente.txt", this.listaDeClientes.ultimoId.ToString());
                    txt.Guardar(AppDomain.CurrentDomain.BaseDirectory, "ultimoIdServicio.txt", this.listaDeClientes.ultimoId.ToString());
                }
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void btnGestionarServicios_Click(object sender, EventArgs e)
        {
            FormGestionarServicios formGestionarServicios = new FormGestionarServicios(this.listaDeServicios,this.listaDeClientes, 0);
            formGestionarServicios.lblCliente.Text = "LISTA DE SERVICIOS";
            formGestionarServicios.ShowDialog();
            this.listaDeServicios = formGestionarServicios.listaDeServicios;
            this.listaDeClientes = formGestionarServicios.listaDeClientes;
            delegadoActualizarListado.Invoke();
        }

        private void btnGestionarArchivos_Click(object sender, EventArgs e)
        {
            FormGestionarArchivos formGestionarArchivos = new FormGestionarArchivos(this.listaDeClientes, this.listaDeServicios);
            formGestionarArchivos.ShowDialog();
            this.listaDeClientes = formGestionarArchivos.listaDeClientes;
            this.listaDeServicios = formGestionarArchivos.listaDeServicios;
            delegadoActualizarListado.Invoke();
        }

       
        private void MensajeFechaExcedida()
        {
            lblFechaEntregaExcedida.Visible = true;
        }
        private void VerificarFechasEntrega()
        {
            foreach (Servicio servicio in this.listaDeServicios.listado)
            {
                if (servicio.FechaEntrega < DateTime.Now)
                {
                    eventoFechaDeEntregaExcedida.Invoke();
                    break;
                }
            }
        }
    }
}
