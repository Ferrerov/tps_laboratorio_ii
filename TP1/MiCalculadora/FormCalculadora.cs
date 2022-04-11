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

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
        }

        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            this.lblResultado.Text = "";
            this.txtNumero1.Text = "";
            this.txtNumero2.Text = "";
            this.cmbOperador.SelectedIndex = 0;
        }

        private static double Operar(string numero1, string numero2, string operador)
        {
            Operando num1 = new Operando(numero1);
            Operando num2 = new Operando(numero2);

            double resultado = Calculadora.Operar(num1, num2, char.Parse(operador));
            return resultado;
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            if(cmbOperador.Text != "")
            {
                double resultado = Operar(txtNumero1.Text, txtNumero2.Text, cmbOperador.Text);
                this.lblResultado.Text = resultado.ToString();

                this.lstOperaciones.Items.Add($"{txtNumero1.Text} {cmbOperador.Text} {txtNumero2.Text} = {lblResultado.Text}");
            } 
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }

        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            Operando numero = new Operando();
            this.lblResultado.Text = numero.DecimalBinario(this.lblResultado.Text);
        }

        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            Operando numero = new Operando();
            this.lblResultado.Text = numero.BinarioDecimal(this.lblResultado.Text);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Está seguro de querer salir?", "Saliendo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(respuesta == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
