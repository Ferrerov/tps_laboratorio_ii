﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca;
using Excepciones;

namespace Forms
{
    public partial class FormDatosCliente : Form
    {
        Cliente clienteModificar;
        public Cliente clienteNuevo;
        private int ultimoId;
        public FormDatosCliente(string titulo, Cliente cliente, int ultimoId)
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
            else
            {
                this.ultimoId = ultimoId;
            }
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            try
            {
                CampoVacio(txtNombre.Text);
                CampoVacio(txtDni.Text);
                CampoVacio(txtTelefono.Text);
                CampoVacio(txtDireccion.Text);
                CampoVacio(txtEmail.Text);
                ValidarDniCliente(txtDni.Text);
                EsNumerico(txtTelefono.Text);
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
                    this.ultimoId++;
                    clienteNuevo = new Cliente(ultimoId, txtNombre.Text, long.Parse(txtDni.Text), long.Parse(txtTelefono.Text), txtDireccion.Text, txtEmail.Text);
                    MessageBox.Show("Cliente cargado correctamente", "Carga exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                } 
            }
            catch(CampoVacioException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch(DniInvalidoException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch(NoEsNumericoException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
        public void ValidarDniCliente(string strDniCliente)
        {
            if (!((strDniCliente.Length > 6  && strDniCliente.Length < 9) && EsNumerico(strDniCliente)))
            {
                throw new DniInvalidoException("Ingrese un dni válido.");
            }
        }
        public void CampoVacio(string texto)
        {
            if (texto is null || texto == string.Empty)
            {
                throw new CampoVacioException("Complete todos los campos.");
            }
        }
        public bool EsNumerico(string strNumero)
        {
            if (Regex.IsMatch(strNumero, @"^[a-zA-Z]+$"))
            {
                throw new NoEsNumericoException("Ingrese un valor numerico.");
            }
            else
            {
                return true;
            }
        }
    }
}
