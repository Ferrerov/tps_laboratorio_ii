using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Forms
{
    public partial class FormNuevoCliente : Form
    {
        public Cliente cliente;
        public FormNuevoCliente()
        {
            InitializeComponent();
        }
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if(int.TryParse(this.txtDniDelCliente.Text, out int dniDelCliente) && double.TryParse(this.txtSaldoInicial.Text, out double saldo))
            {
                cliente = new Cliente(this.txtNombredelCliente.Text, dniDelCliente, saldo);
                MessageBox.Show("Cliente cargado correctamente", "Carga exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Ingrese datos correctos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
