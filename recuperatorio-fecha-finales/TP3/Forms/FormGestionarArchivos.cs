using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Archivos;
using Biblioteca;
using Excepciones;

namespace Forms
{
    public partial class FormGestionarArchivos : Form
    {
        public ListadoGenerico<Servicio> listaDeServicios;
        public ListadoGenerico<Cliente> listaDeClientes;
        public FormGestionarArchivos(ListadoGenerico<Cliente> listaDeClientes ,ListadoGenerico<Servicio> listaDeServicios)
        {
            InitializeComponent();
            this.listaDeClientes = listaDeClientes;
            this.listaDeServicios = listaDeServicios;
        }

        private void btnCargarListadoServicios_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string path = openFileDialog.InitialDirectory;
                    string archivo = openFileDialog.FileName;
                    listaDeServicios.LeerListado(path, archivo);
                }
            }
            catch(ErrorArchivoException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCargarListadoClientes_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string path = openFileDialog.InitialDirectory;
                    string archivo = openFileDialog.FileName;
                    listaDeClientes.LeerListado(path, archivo);
                }
            }
            catch (ErrorArchivoException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnGuardarListados_Click(object sender, EventArgs e)
        {
            try
            {
                this.listaDeClientes.GuardarListado(AppDomain.CurrentDomain.BaseDirectory, "listaClientes.xml");
                this.listaDeServicios.GuardarListado(AppDomain.CurrentDomain.BaseDirectory, "listaServicios.xml");
                GestorTxt txt = new GestorTxt();
                txt.Guardar(AppDomain.CurrentDomain.BaseDirectory, "ultimoIdCliente.txt", this.listaDeClientes.ultimoId.ToString());
                txt.Guardar(AppDomain.CurrentDomain.BaseDirectory, "ultimoIdServicio.txt", this.listaDeClientes.ultimoId.ToString());
            }
            catch (ErrorArchivoException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnBorrarDatos_Click(object sender, EventArgs e)
        {
            this.listaDeClientes = new ListadoGenerico<Cliente>(0);
            this.listaDeServicios = new ListadoGenerico<Servicio>(0);
        }
    }
}
