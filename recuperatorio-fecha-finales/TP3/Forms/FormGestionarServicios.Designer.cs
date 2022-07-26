
namespace Forms
{
    partial class FormGestionarServicios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvListaServiciosCompletados = new System.Windows.Forms.DataGridView();
            this.dgvListaServiciosPendientes = new System.Windows.Forms.DataGridView();
            this.lblPendientes = new System.Windows.Forms.Label();
            this.lblCompletados = new System.Windows.Forms.Label();
            this.btnMarcarComoCompletado = new System.Windows.Forms.Button();
            this.lblCliente = new System.Windows.Forms.Label();
            this.btnMarcarComoPendiente = new System.Windows.Forms.Button();
            this.btnGuardarListado = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnNuevoServicio = new System.Windows.Forms.Button();
            this.btnEliminarServicio = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaServiciosCompletados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaServiciosPendientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListaServiciosCompletados
            // 
            this.dgvListaServiciosCompletados.AllowUserToAddRows = false;
            this.dgvListaServiciosCompletados.AllowUserToDeleteRows = false;
            this.dgvListaServiciosCompletados.AllowUserToOrderColumns = true;
            this.dgvListaServiciosCompletados.AllowUserToResizeColumns = false;
            this.dgvListaServiciosCompletados.AllowUserToResizeRows = false;
            this.dgvListaServiciosCompletados.BackgroundColor = System.Drawing.Color.Gray;
            this.dgvListaServiciosCompletados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListaServiciosCompletados.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListaServiciosCompletados.GridColor = System.Drawing.Color.Gray;
            this.dgvListaServiciosCompletados.Location = new System.Drawing.Point(12, 382);
            this.dgvListaServiciosCompletados.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvListaServiciosCompletados.MultiSelect = false;
            this.dgvListaServiciosCompletados.Name = "dgvListaServiciosCompletados";
            this.dgvListaServiciosCompletados.ReadOnly = true;
            this.dgvListaServiciosCompletados.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvListaServiciosCompletados.RowHeadersWidth = 51;
            this.dgvListaServiciosCompletados.RowTemplate.Height = 25;
            this.dgvListaServiciosCompletados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaServiciosCompletados.Size = new System.Drawing.Size(1277, 200);
            this.dgvListaServiciosCompletados.TabIndex = 19;
            this.dgvListaServiciosCompletados.VirtualMode = true;
            // 
            // dgvListaServiciosPendientes
            // 
            this.dgvListaServiciosPendientes.AllowUserToAddRows = false;
            this.dgvListaServiciosPendientes.AllowUserToDeleteRows = false;
            this.dgvListaServiciosPendientes.AllowUserToOrderColumns = true;
            this.dgvListaServiciosPendientes.AllowUserToResizeColumns = false;
            this.dgvListaServiciosPendientes.AllowUserToResizeRows = false;
            this.dgvListaServiciosPendientes.BackgroundColor = System.Drawing.Color.Gray;
            this.dgvListaServiciosPendientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListaServiciosPendientes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListaServiciosPendientes.GridColor = System.Drawing.Color.Gray;
            this.dgvListaServiciosPendientes.Location = new System.Drawing.Point(12, 99);
            this.dgvListaServiciosPendientes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvListaServiciosPendientes.MultiSelect = false;
            this.dgvListaServiciosPendientes.Name = "dgvListaServiciosPendientes";
            this.dgvListaServiciosPendientes.ReadOnly = true;
            this.dgvListaServiciosPendientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvListaServiciosPendientes.RowHeadersWidth = 51;
            this.dgvListaServiciosPendientes.RowTemplate.Height = 25;
            this.dgvListaServiciosPendientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaServiciosPendientes.Size = new System.Drawing.Size(1277, 200);
            this.dgvListaServiciosPendientes.TabIndex = 20;
            this.dgvListaServiciosPendientes.VirtualMode = true;
            // 
            // lblPendientes
            // 
            this.lblPendientes.AutoSize = true;
            this.lblPendientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPendientes.ForeColor = System.Drawing.Color.White;
            this.lblPendientes.Location = new System.Drawing.Point(12, 64);
            this.lblPendientes.Name = "lblPendientes";
            this.lblPendientes.Size = new System.Drawing.Size(197, 31);
            this.lblPendientes.TabIndex = 21;
            this.lblPendientes.Text = "PENDIENTES:";
            // 
            // lblCompletados
            // 
            this.lblCompletados.AutoSize = true;
            this.lblCompletados.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCompletados.ForeColor = System.Drawing.Color.White;
            this.lblCompletados.Location = new System.Drawing.Point(12, 347);
            this.lblCompletados.Name = "lblCompletados";
            this.lblCompletados.Size = new System.Drawing.Size(230, 31);
            this.lblCompletados.TabIndex = 22;
            this.lblCompletados.Text = "COMPLETADOS:";
            // 
            // btnMarcarComoCompletado
            // 
            this.btnMarcarComoCompletado.BackColor = System.Drawing.Color.Green;
            this.btnMarcarComoCompletado.FlatAppearance.BorderSize = 0;
            this.btnMarcarComoCompletado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMarcarComoCompletado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMarcarComoCompletado.ForeColor = System.Drawing.Color.White;
            this.btnMarcarComoCompletado.Location = new System.Drawing.Point(847, 307);
            this.btnMarcarComoCompletado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMarcarComoCompletado.Name = "btnMarcarComoCompletado";
            this.btnMarcarComoCompletado.Size = new System.Drawing.Size(442, 47);
            this.btnMarcarComoCompletado.TabIndex = 23;
            this.btnMarcarComoCompletado.Text = "MARCAR COMO COMPLETADO";
            this.btnMarcarComoCompletado.UseVisualStyleBackColor = false;
            this.btnMarcarComoCompletado.Click += new System.EventHandler(this.btnMarcarComoCompletado_Click);
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCliente.ForeColor = System.Drawing.Color.White;
            this.lblCliente.Location = new System.Drawing.Point(12, 9);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(138, 31);
            this.lblCliente.TabIndex = 24;
            this.lblCliente.Text = "CLIENTE:";
            // 
            // btnMarcarComoPendiente
            // 
            this.btnMarcarComoPendiente.BackColor = System.Drawing.Color.Brown;
            this.btnMarcarComoPendiente.FlatAppearance.BorderSize = 0;
            this.btnMarcarComoPendiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMarcarComoPendiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMarcarComoPendiente.ForeColor = System.Drawing.Color.White;
            this.btnMarcarComoPendiente.Location = new System.Drawing.Point(847, 590);
            this.btnMarcarComoPendiente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMarcarComoPendiente.Name = "btnMarcarComoPendiente";
            this.btnMarcarComoPendiente.Size = new System.Drawing.Size(442, 47);
            this.btnMarcarComoPendiente.TabIndex = 25;
            this.btnMarcarComoPendiente.Text = "MARCAR COMO PENDIENTE";
            this.btnMarcarComoPendiente.UseVisualStyleBackColor = false;
            this.btnMarcarComoPendiente.Click += new System.EventHandler(this.btnMarcarComoPendiente_Click);
            // 
            // btnGuardarListado
            // 
            this.btnGuardarListado.BackColor = System.Drawing.Color.DimGray;
            this.btnGuardarListado.FlatAppearance.BorderSize = 0;
            this.btnGuardarListado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarListado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGuardarListado.ForeColor = System.Drawing.Color.White;
            this.btnGuardarListado.Location = new System.Drawing.Point(226, 590);
            this.btnGuardarListado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGuardarListado.Name = "btnGuardarListado";
            this.btnGuardarListado.Size = new System.Drawing.Size(301, 47);
            this.btnGuardarListado.TabIndex = 27;
            this.btnGuardarListado.Text = "GUARDAR LISTADO";
            this.btnGuardarListado.UseVisualStyleBackColor = false;
            this.btnGuardarListado.Click += new System.EventHandler(this.btnGuardarListado_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.DimGray;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(12, 590);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(187, 47);
            this.btnSalir.TabIndex = 28;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnNuevoServicio
            // 
            this.btnNuevoServicio.BackColor = System.Drawing.Color.DimGray;
            this.btnNuevoServicio.FlatAppearance.BorderSize = 0;
            this.btnNuevoServicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNuevoServicio.ForeColor = System.Drawing.Color.White;
            this.btnNuevoServicio.Location = new System.Drawing.Point(681, 9);
            this.btnNuevoServicio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNuevoServicio.Name = "btnNuevoServicio";
            this.btnNuevoServicio.Size = new System.Drawing.Size(301, 47);
            this.btnNuevoServicio.TabIndex = 29;
            this.btnNuevoServicio.Text = "NUEVO SERVICIO";
            this.btnNuevoServicio.UseVisualStyleBackColor = false;
            this.btnNuevoServicio.Click += new System.EventHandler(this.btnNuevoServicio_Click);
            // 
            // btnEliminarServicio
            // 
            this.btnEliminarServicio.BackColor = System.Drawing.Color.DimGray;
            this.btnEliminarServicio.FlatAppearance.BorderSize = 0;
            this.btnEliminarServicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEliminarServicio.ForeColor = System.Drawing.Color.White;
            this.btnEliminarServicio.Location = new System.Drawing.Point(988, 9);
            this.btnEliminarServicio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEliminarServicio.Name = "btnEliminarServicio";
            this.btnEliminarServicio.Size = new System.Drawing.Size(301, 47);
            this.btnEliminarServicio.TabIndex = 30;
            this.btnEliminarServicio.Text = "ELIMINAR SERVICIO";
            this.btnEliminarServicio.UseVisualStyleBackColor = false;
            this.btnEliminarServicio.Click += new System.EventHandler(this.btnEliminarServicio_Click);
            // 
            // FormGestionarServicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1301, 682);
            this.Controls.Add(this.btnEliminarServicio);
            this.Controls.Add(this.btnNuevoServicio);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGuardarListado);
            this.Controls.Add(this.btnMarcarComoPendiente);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.btnMarcarComoCompletado);
            this.Controls.Add(this.lblCompletados);
            this.Controls.Add(this.lblPendientes);
            this.Controls.Add(this.dgvListaServiciosPendientes);
            this.Controls.Add(this.dgvListaServiciosCompletados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormGestionarServicios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestionar Servicios";
            this.Load += new System.EventHandler(this.FormGestionarServicios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaServiciosCompletados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaServiciosPendientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListaServiciosCompletados;
        private System.Windows.Forms.TextBox txtBoxBuscar;
        private System.Windows.Forms.DataGridView dgvListaServiciosPendientes;
        private System.Windows.Forms.Label lblPendientes;
        private System.Windows.Forms.Label lblCompletados;
        public System.Windows.Forms.Button btnMarcarComoCompletado;
        public System.Windows.Forms.Button btnMarcarComoPendiente;
        public System.Windows.Forms.Label lblCliente;
        public System.Windows.Forms.Button btnGuardarListado;
        public System.Windows.Forms.Button btnSalir;
        public System.Windows.Forms.Button btnNuevoServicio;
        public System.Windows.Forms.Button btnEliminarServicio;
    }
}