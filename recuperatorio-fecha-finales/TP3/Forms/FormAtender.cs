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
    public partial class FormAtender : Form
    {
        private Cliente clienteAtendido;
        public Servicio servicio;
        public FormAtender(Cliente clienteAtender)
        {
            InitializeComponent();
            clienteAtendido = clienteAtender;
            lblNombreCliente.Text += $"{this.clienteAtendido.Nombre}";
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
                servicio = new Servicio(int.Parse(txtPrecio.Text), DateTime.Now, dtPickerEntrega.Value, txtBoxDetalle.Text, false, clienteAtendido.Dni, (ETipoServicio)cmbServico.SelectedItem, (ETipoDispositivo)cmbDispositivo.SelectedItem);
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
