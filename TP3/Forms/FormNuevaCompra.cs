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
    public partial class FormNuevaCompra : Form
    {
        public FormNuevaCompra(Cliente cliente)
        {
            InitializeComponent();
        }

        public void CargarListaVinos()
        {
            this.dgvListaVinos = null;
        }
    }


}
