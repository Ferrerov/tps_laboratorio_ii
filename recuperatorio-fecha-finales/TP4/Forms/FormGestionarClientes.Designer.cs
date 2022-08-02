
namespace Forms
{
    partial class FormGestionarClientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnNuevoCliente = new System.Windows.Forms.Button();
            this.txtBoxBuscar = new System.Windows.Forms.TextBox();
            this.dgvListaClientes = new System.Windows.Forms.DataGridView();
            this.btnModificarCliente = new System.Windows.Forms.Button();
            this.btnEliminarCliente = new System.Windows.Forms.Button();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGuardarListado = new System.Windows.Forms.Button();
            this.btnVerServicios = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNuevoCliente
            // 
            this.btnNuevoCliente.BackColor = System.Drawing.Color.Green;
            this.btnNuevoCliente.FlatAppearance.BorderSize = 0;
            this.btnNuevoCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNuevoCliente.ForeColor = System.Drawing.Color.White;
            this.btnNuevoCliente.Location = new System.Drawing.Point(883, 43);
            this.btnNuevoCliente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNuevoCliente.Name = "btnNuevoCliente";
            this.btnNuevoCliente.Size = new System.Drawing.Size(289, 47);
            this.btnNuevoCliente.TabIndex = 12;
            this.btnNuevoCliente.Text = "NUEVO CLIENTE";
            this.btnNuevoCliente.UseVisualStyleBackColor = false;
            this.btnNuevoCliente.Click += new System.EventHandler(this.btnNuevoCliente_Click);
            // 
            // txtBoxBuscar
            // 
            this.txtBoxBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxBuscar.Location = new System.Drawing.Point(151, 47);
            this.txtBoxBuscar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxBuscar.Name = "txtBoxBuscar";
            this.txtBoxBuscar.Size = new System.Drawing.Size(411, 37);
            this.txtBoxBuscar.TabIndex = 14;
            this.txtBoxBuscar.TextChanged += new System.EventHandler(this.txtBoxBuscar_TextChanged);
            // 
            // dgvListaClientes
            // 
            this.dgvListaClientes.AllowUserToAddRows = false;
            this.dgvListaClientes.AllowUserToDeleteRows = false;
            this.dgvListaClientes.AllowUserToOrderColumns = true;
            this.dgvListaClientes.AllowUserToResizeColumns = false;
            this.dgvListaClientes.AllowUserToResizeRows = false;
            this.dgvListaClientes.BackgroundColor = System.Drawing.Color.Gray;
            this.dgvListaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListaClientes.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListaClientes.GridColor = System.Drawing.Color.Gray;
            this.dgvListaClientes.Location = new System.Drawing.Point(14, 99);
            this.dgvListaClientes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvListaClientes.MultiSelect = false;
            this.dgvListaClientes.Name = "dgvListaClientes";
            this.dgvListaClientes.ReadOnly = true;
            this.dgvListaClientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvListaClientes.RowHeadersWidth = 51;
            this.dgvListaClientes.RowTemplate.Height = 25;
            this.dgvListaClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaClientes.Size = new System.Drawing.Size(1158, 629);
            this.dgvListaClientes.TabIndex = 15;
            // 
            // btnModificarCliente
            // 
            this.btnModificarCliente.BackColor = System.Drawing.Color.DimGray;
            this.btnModificarCliente.FlatAppearance.BorderSize = 0;
            this.btnModificarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnModificarCliente.ForeColor = System.Drawing.Color.White;
            this.btnModificarCliente.Location = new System.Drawing.Point(568, 752);
            this.btnModificarCliente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnModificarCliente.Name = "btnModificarCliente";
            this.btnModificarCliente.Size = new System.Drawing.Size(301, 47);
            this.btnModificarCliente.TabIndex = 17;
            this.btnModificarCliente.Text = "MODIFICAR CLIENTE";
            this.btnModificarCliente.UseVisualStyleBackColor = false;
            this.btnModificarCliente.Click += new System.EventHandler(this.btnModificarCliente_Click);
            // 
            // btnEliminarCliente
            // 
            this.btnEliminarCliente.BackColor = System.Drawing.Color.Brown;
            this.btnEliminarCliente.FlatAppearance.BorderSize = 0;
            this.btnEliminarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEliminarCliente.ForeColor = System.Drawing.Color.White;
            this.btnEliminarCliente.Location = new System.Drawing.Point(883, 752);
            this.btnEliminarCliente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEliminarCliente.Name = "btnEliminarCliente";
            this.btnEliminarCliente.Size = new System.Drawing.Size(289, 47);
            this.btnEliminarCliente.TabIndex = 18;
            this.btnEliminarCliente.Text = "ELIMINAR CLIENTE";
            this.btnEliminarCliente.UseVisualStyleBackColor = false;
            this.btnEliminarCliente.Click += new System.EventHandler(this.btnEliminarCliente_Click);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBuscar.ForeColor = System.Drawing.Color.White;
            this.lblBuscar.Location = new System.Drawing.Point(14, 51);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(136, 31);
            this.lblBuscar.TabIndex = 19;
            this.lblBuscar.Text = "BUSCAR:";
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.BackColor = System.Drawing.Color.DimGray;
            this.btnSeleccionar.FlatAppearance.BorderSize = 0;
            this.btnSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSeleccionar.ForeColor = System.Drawing.Color.White;
            this.btnSeleccionar.Location = new System.Drawing.Point(883, 752);
            this.btnSeleccionar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(289, 47);
            this.btnSeleccionar.TabIndex = 20;
            this.btnSeleccionar.Text = "SELECCIONAR";
            this.btnSeleccionar.UseVisualStyleBackColor = false;
            this.btnSeleccionar.Visible = false;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.DimGray;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(14, 752);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(227, 47);
            this.btnSalir.TabIndex = 21;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnGuardarListado
            // 
            this.btnGuardarListado.BackColor = System.Drawing.Color.DimGray;
            this.btnGuardarListado.FlatAppearance.BorderSize = 0;
            this.btnGuardarListado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarListado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGuardarListado.ForeColor = System.Drawing.Color.White;
            this.btnGuardarListado.Location = new System.Drawing.Point(568, 43);
            this.btnGuardarListado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGuardarListado.Name = "btnGuardarListado";
            this.btnGuardarListado.Size = new System.Drawing.Size(301, 47);
            this.btnGuardarListado.TabIndex = 22;
            this.btnGuardarListado.Text = "GUARDAR LISTADO";
            this.btnGuardarListado.UseVisualStyleBackColor = false;
            this.btnGuardarListado.Click += new System.EventHandler(this.btnGuardarListado_Click);
            // 
            // btnVerServicios
            // 
            this.btnVerServicios.BackColor = System.Drawing.Color.DimGray;
            this.btnVerServicios.FlatAppearance.BorderSize = 0;
            this.btnVerServicios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerServicios.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVerServicios.ForeColor = System.Drawing.Color.White;
            this.btnVerServicios.Location = new System.Drawing.Point(254, 752);
            this.btnVerServicios.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnVerServicios.Name = "btnVerServicios";
            this.btnVerServicios.Size = new System.Drawing.Size(301, 47);
            this.btnVerServicios.TabIndex = 23;
            this.btnVerServicios.Text = "VER SERVICIOS";
            this.btnVerServicios.UseVisualStyleBackColor = false;
            this.btnVerServicios.Click += new System.EventHandler(this.btnVerServicios_Click);
            // 
            // FormGestionarClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1187, 815);
            this.Controls.Add(this.btnVerServicios);
            this.Controls.Add(this.btnGuardarListado);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.btnModificarCliente);
            this.Controls.Add(this.dgvListaClientes);
            this.Controls.Add(this.txtBoxBuscar);
            this.Controls.Add(this.btnNuevoCliente);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.btnEliminarCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormGestionarClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dgvListaClientes;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txtBoxBuscar;
        private System.Windows.Forms.Button btnNuevoCliente;
        public System.Windows.Forms.Button btnModificarCliente;
        public System.Windows.Forms.Button btnEliminarCliente;
        public System.Windows.Forms.Button btnSeleccionar;
        public System.Windows.Forms.Button btnSalir;
        public System.Windows.Forms.Button btnGuardarListado;
        public System.Windows.Forms.Button btnVerServicios;
    }
}