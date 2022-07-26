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
    public partial class FormPrincipal : Form
    {
        private ListadoGenerico<Cliente> listaDeClientes;
        private ListadoGenerico<Servicio> listaDeServicios;
        private BindingSource sourceClientes;
        private int ultimoIdCliente = 0;
        private int ultimoIdServicio = 0;

        public FormPrincipal()
        {
            InitializeComponent();
            GestorTxt txt = new GestorTxt();
            if (txt.Leer(AppDomain.CurrentDomain.BaseDirectory, "ultimoIdCliente.txt", out string strUltimoIdCliente))
            {
                ultimoIdCliente = int.Parse(strUltimoIdCliente);
            }
            if (txt.Leer(AppDomain.CurrentDomain.BaseDirectory, "ultimoIdServicio.txt", out string strUltimoIdServicio))
            {
                ultimoIdServicio = int.Parse(strUltimoIdServicio);
            }
            this.listaDeClientes = new ListadoGenerico<Cliente>(ultimoIdCliente);
            this.listaDeServicios = new ListadoGenerico<Servicio>(ultimoIdServicio);
            sourceClientes = new BindingSource();
            this.listaDeClientes.LeerListado(AppDomain.CurrentDomain.BaseDirectory, "listaClientes.xml");
            if(this.listaDeServicios.LeerListado(AppDomain.CurrentDomain.BaseDirectory, "listaServicios.xml"))
            {
                CargarListaDeServicios();
            }
        }

        private void btnGestionarClientes_Click(object sender, EventArgs e)
        {
            FormGestionarClientes formGestionarClientes = new FormGestionarClientes(this.listaDeClientes,this.listaDeServicios);
            formGestionarClientes.ShowDialog();
            this.listaDeClientes = formGestionarClientes.listaDeClientes;
            this.listaDeServicios = formGestionarClientes.listaDeServicios;
            formGestionarClientes.Dispose();      
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAtender_Click(object sender, EventArgs e)
        {
            FormGestionarClientes formGestionarClientes = new FormGestionarClientes(this.listaDeClientes, this.listaDeServicios);
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
                    CargarListaDeServicios();
                }
                catch (Exception)
                {
                    MessageBox.Show("No se ha cargado ningun servicio!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void CargarListaDeServicios()
        {
            OrdenarListadoPorFechaAscendente(this.listaDeServicios.listado, out this.listaDeServicios.listado);
            sourceClientes.DataSource = this.listaDeServicios.listado;
            this.dgvListaServicios.DataSource = sourceClientes;
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
            sourceClientes.ResetBindings(false);
        }

        private static void OrdenarListadoPorFechaAscendente(List<Servicio> listado, out List<Servicio> listadoOrdenado)
        {
            IEnumerable<Servicio> query = listado.OrderBy(listado => listado.FechaEntrega);
            List<Servicio> listadoAux = new List<Servicio>();
            foreach (Servicio cliente in query)
            {
                listadoAux.Add(cliente);
            }
            listadoOrdenado = listadoAux;
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
            CargarListaDeServicios();
        }

        private void btnGestionarArchivos_Click(object sender, EventArgs e)
        {
            FormGestionarArchivos formGestionarArchivos = new FormGestionarArchivos(this.listaDeClientes, this.listaDeServicios);
            formGestionarArchivos.ShowDialog();
            this.listaDeClientes = formGestionarArchivos.listaDeClientes;
            this.listaDeServicios = formGestionarArchivos.listaDeServicios;
            CargarListaDeServicios();
        }
    }
}
