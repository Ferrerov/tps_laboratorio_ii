using System;
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
    public partial class FormAtender : Form
    {
        private Cliente clienteAtendido;
        public Servicio servicio;
        public int ultimoId;
        public FormAtender(Cliente clienteAtender, int ultimoId)
        {
            InitializeComponent();
            clienteAtendido = clienteAtender;
            this.ultimoId = ultimoId;
            if(clienteAtendido.Nombre.Length > 20)
            {
                lblNombreCliente.Text += (this.clienteAtendido.Nombre.Substring(0, 16) + "...");
            }
            else
            {
                lblNombreCliente.Text += $"{this.clienteAtendido.Nombre}";
            }
            lblDniCliente.Text += $"{this.clienteAtendido.Dni}";
            cmbServico.DataSource = Enum.GetValues(typeof(ETipoServicio));
            cmbDispositivo.DataSource = Enum.GetValues(typeof(ETipoDispositivo));
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                CampoVacio(txtPrecio.Text);
                CampoVacio(txtBoxDetalle.Text);
                EsNumerico(txtPrecio.Text);
                if(txtBoxDetalle.TextLength < 41)
                {
                    servicio = new Servicio(int.Parse(txtPrecio.Text), DateTime.Now, dtPickerEntrega.Value, txtBoxDetalle.Text, false, clienteAtendido.Dni, (ETipoServicio)cmbServico.SelectedItem, (ETipoDispositivo)cmbDispositivo.SelectedItem, ultimoId + 1);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("El detalle debe tener como maximo 40 caracteres!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (CampoVacioException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ValidarDniCliente(string strDniCliente)
        {
            if(!((strDniCliente.Length > 8 || strDniCliente.Length < 9) && EsNumerico(strDniCliente)))
            {
                throw new DniInvalidoException("Ingrese un dni válido.");
            }
        }
        public void CampoVacio(string texto)
        {
            if(texto is null || texto == string.Empty)
            {
                throw new CampoVacioException("Complete todos los campos.");
            }
        }
        public bool EsNumerico(string strNumero)
        {
            if(Regex.IsMatch(strNumero, @"^[a-zA-Z]+$"))
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
