
namespace Forms
{
    partial class FormMenuPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnListadoClientes = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnNuevaCompra = new System.Windows.Forms.Button();
            this.btnModificarCliente = new System.Windows.Forms.Button();
            this.btnEliminarCliente = new System.Windows.Forms.Button();
            this.btnNuevoCliente = new System.Windows.Forms.Button();
            this.lstBoxClientes = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnListadoClientes
            // 
            this.btnListadoClientes.Location = new System.Drawing.Point(12, 361);
            this.btnListadoClientes.Name = "btnListadoClientes";
            this.btnListadoClientes.Size = new System.Drawing.Size(282, 57);
            this.btnListadoClientes.TabIndex = 3;
            this.btnListadoClientes.Text = "VER LISTADO DE CLIENTES";
            this.btnListadoClientes.UseVisualStyleBackColor = true;
            this.btnListadoClientes.Click += new System.EventHandler(this.btnListadoClientes_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 277);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(282, 57);
            this.button4.TabIndex = 5;
            this.button4.Text = "VER LISTADO DE COMPRAS";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btnNuevaCompra
            // 
            this.btnNuevaCompra.BackColor = System.Drawing.Color.Turquoise;
            this.btnNuevaCompra.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNuevaCompra.Location = new System.Drawing.Point(12, 183);
            this.btnNuevaCompra.Name = "btnNuevaCompra";
            this.btnNuevaCompra.Size = new System.Drawing.Size(282, 72);
            this.btnNuevaCompra.TabIndex = 6;
            this.btnNuevaCompra.Text = "NUEVA COMPRA";
            this.btnNuevaCompra.UseVisualStyleBackColor = false;
            this.btnNuevaCompra.Click += new System.EventHandler(this.btnNuevaCompra_Click);
            // 
            // btnModificarCliente
            // 
            this.btnModificarCliente.Location = new System.Drawing.Point(12, 546);
            this.btnModificarCliente.Name = "btnModificarCliente";
            this.btnModificarCliente.Size = new System.Drawing.Size(282, 31);
            this.btnModificarCliente.TabIndex = 8;
            this.btnModificarCliente.Text = "MODIFICAR CLIENTE";
            this.btnModificarCliente.UseVisualStyleBackColor = true;
            this.btnModificarCliente.Click += new System.EventHandler(this.btnModificarCliente_Click);
            // 
            // btnEliminarCliente
            // 
            this.btnEliminarCliente.Location = new System.Drawing.Point(12, 493);
            this.btnEliminarCliente.Name = "btnEliminarCliente";
            this.btnEliminarCliente.Size = new System.Drawing.Size(282, 31);
            this.btnEliminarCliente.TabIndex = 9;
            this.btnEliminarCliente.Text = "ELIMINAR CLIENTE";
            this.btnEliminarCliente.UseVisualStyleBackColor = true;
            this.btnEliminarCliente.Click += new System.EventHandler(this.btnEliminarCliente_Click);
            // 
            // btnNuevoCliente
            // 
            this.btnNuevoCliente.Location = new System.Drawing.Point(12, 440);
            this.btnNuevoCliente.Name = "btnNuevoCliente";
            this.btnNuevoCliente.Size = new System.Drawing.Size(282, 31);
            this.btnNuevoCliente.TabIndex = 10;
            this.btnNuevoCliente.Text = "NUEVO CLIENTE";
            this.btnNuevoCliente.UseVisualStyleBackColor = true;
            this.btnNuevoCliente.Click += new System.EventHandler(this.btnNuevoCliente_Click);
            // 
            // lstBoxClientes
            // 
            this.lstBoxClientes.FormattingEnabled = true;
            this.lstBoxClientes.ItemHeight = 15;
            this.lstBoxClientes.Location = new System.Drawing.Point(300, 183);
            this.lstBoxClientes.Name = "lstBoxClientes";
            this.lstBoxClientes.Size = new System.Drawing.Size(678, 394);
            this.lstBoxClientes.TabIndex = 11;
            // 
            // FormMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 595);
            this.Controls.Add(this.lstBoxClientes);
            this.Controls.Add(this.btnNuevoCliente);
            this.Controls.Add(this.btnEliminarCliente);
            this.Controls.Add(this.btnModificarCliente);
            this.Controls.Add(this.btnNuevaCompra);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnListadoClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tebas - Venta de Vinos";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnListadoClientes;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnNuevaCompra;
        private System.Windows.Forms.Button btnModificarCliente;
        private System.Windows.Forms.Button btnEliminarCliente;
        private System.Windows.Forms.Button btnNuevoCliente;
        private System.Windows.Forms.ListBox lstBoxClientes;
    }
}

