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
    public partial class FormDatosCliente : Form
    {
        Cliente clienteModificar;
        public Cliente clienteNuevo;
        public FormDatosCliente(string titulo, Cliente cliente)
        {
            InitializeComponent();
            if(cliente is not null)
            {
                lblTitulo.Text = titulo;
                txtNombre.Text = cliente.Nombre;
                txtDni.Text = cliente.Dni.ToString();
                txtTelefono.Text = cliente.Telefono.ToString();
                txtDireccion.Text = cliente.Direccion;
                txtEmail.Text = cliente.Email;
                clienteModificar = cliente;
            }
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(string.IsNullOrEmpty(txtNombre.Text) ||
                    string.IsNullOrEmpty(txtDni.Text) ||
                    string.IsNullOrEmpty(txtTelefono.Text) ||
                    string.IsNullOrEmpty(txtDireccion.Text) ||
                    string.IsNullOrEmpty(txtEmail.Text)))
                {
                    if(clienteModificar is not null)
                    {
                        clienteModificar.Nombre = txtNombre.Text;
                        clienteModificar.Dni = long.Parse(txtDni.Text);
                        clienteModificar.Telefono = long.Parse(txtTelefono.Text);
                        clienteModificar.Direccion = txtDireccion.Text;
                        clienteModificar.Email = txtEmail.Text;
                        MessageBox.Show("Cliente modificado correctamente", "Modificacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        clienteNuevo = new Cliente(txtNombre.Text, long.Parse(txtDni.Text), long.Parse(txtTelefono.Text), txtDireccion.Text, txtEmail.Text);
                        MessageBox.Show("Cliente cargado correctamente", "Carga exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                    } 
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Ingrese datos correctos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}
