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
    public partial class FormPrincipal : Form
    {
        List<Cliente> listaDeClientes;
        public FormPrincipal()
        {
            InitializeComponent();
            this.listaDeClientes = new List<Cliente>();
        }

        private void btnGestionarClientes_Click(object sender, EventArgs e)
        {
            FormGestionarClientes formGestionarClientes = new FormGestionarClientes(this.listaDeClientes);
            formGestionarClientes.ShowDialog();
            this.listaDeClientes = formGestionarClientes.listaDeClientes;
            formGestionarClientes.Dispose();      
        }
    }
}
