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
        private List<Cliente> listaDeClientes;
        private List<Servicio> listaDeServicios;
        private BindingSource source;
        private int ultimoIdCliente = 0;

        public FormPrincipal()
        {
            InitializeComponent();
            this.listaDeClientes = new List<Cliente>();
            this.listaDeServicios = new List<Servicio>();
            GestorTxt txt = new GestorTxt();
            if(txt.Leer(AppDomain.CurrentDomain.BaseDirectory, "ultimoIdCliente.txt", out string strUltimoIdCliente))
            {
                ultimoIdCliente = int.Parse(strUltimoIdCliente);
            }
            source = new BindingSource();
            CargarClientes();
            CargarListaDeServicios();

        }

        private void btnGestionarClientes_Click(object sender, EventArgs e)
        {
            FormGestionarClientes formGestionarClientes = new FormGestionarClientes(this.listaDeClientes);
            formGestionarClientes.ShowDialog();
            this.listaDeClientes = formGestionarClientes.listaDeClientes;
            formGestionarClientes.Dispose();      
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAtender_Click(object sender, EventArgs e)
        {
            FormGestionarClientes formGestionarClientes = new FormGestionarClientes(this.listaDeClientes);
            formGestionarClientes.btnEliminarCliente.Hide();
            formGestionarClientes.btnModificarCliente.Hide();
            formGestionarClientes.btnSeleccionar.Show();
            formGestionarClientes.ShowDialog();
            this.listaDeClientes = formGestionarClientes.listaDeClientes;

            FormAtender formAtender = new FormAtender(formGestionarClientes.clienteSeleccionado);
            formGestionarClientes.Dispose();
            formAtender.ShowDialog();
            try
            {
                this.listaDeServicios.Add(formAtender.servicio);
                CargarListaDeServicios();
            }
            catch(Exception)
            {
                MessageBox.Show("No se ha cargado ningun servicio!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CargarListaDeServicios()
        {
            source.DataSource = this.listaDeServicios;
            this.dgvListaServicios.DataSource = source;
            this.dgvListaServicios.Columns["Costo"].Visible = false;
            source.ResetBindings(false);
        }

        private void CargarClientes()
        {
            try 
            { 
                SerializadorXml<List<Cliente>> deserializador = new SerializadorXml<List<Cliente>>();
                if (deserializador.Leer(AppDomain.CurrentDomain.BaseDirectory, "listaClientes.xml", out this.listaDeClientes))
                {
                    MessageBox.Show("Archivo leido");
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Archivo no leido");
            }
        }

        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Desea guardar todos los cambios realizados?", "Salir", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {

            }
        }
    }
}
