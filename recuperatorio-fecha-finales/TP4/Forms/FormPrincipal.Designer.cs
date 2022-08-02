
namespace Forms
{
    partial class FormPrincipal
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.btnGestionarClientes = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnAtender = new System.Windows.Forms.Button();
            this.dgvListaServicios = new System.Windows.Forms.DataGridView();
            this.btnGestionarServicios = new System.Windows.Forms.Button();
            this.picBoxLogo = new System.Windows.Forms.PictureBox();
            this.lblProximosAEntregar = new System.Windows.Forms.Label();
            this.btnGestionarArchivos = new System.Windows.Forms.Button();
            this.lblFechaEntregaExcedida = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaServicios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGestionarClientes
            // 
            this.btnGestionarClientes.BackColor = System.Drawing.Color.DimGray;
            this.btnGestionarClientes.FlatAppearance.BorderSize = 0;
            this.btnGestionarClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionarClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGestionarClientes.ForeColor = System.Drawing.Color.White;
            this.btnGestionarClientes.Location = new System.Drawing.Point(14, 221);
            this.btnGestionarClientes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGestionarClientes.Name = "btnGestionarClientes";
            this.btnGestionarClientes.Size = new System.Drawing.Size(339, 47);
            this.btnGestionarClientes.TabIndex = 13;
            this.btnGestionarClientes.Text = "GESTIONAR CLIENTES";
            this.btnGestionarClientes.UseVisualStyleBackColor = false;
            this.btnGestionarClientes.Click += new System.EventHandler(this.btnGestionarClientes_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Brown;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(14, 386);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(339, 47);
            this.btnSalir.TabIndex = 14;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnAtender
            // 
            this.btnAtender.BackColor = System.Drawing.Color.Green;
            this.btnAtender.FlatAppearance.BorderSize = 0;
            this.btnAtender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtender.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAtender.ForeColor = System.Drawing.Color.White;
            this.btnAtender.Location = new System.Drawing.Point(12, 166);
            this.btnAtender.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAtender.Name = "btnAtender";
            this.btnAtender.Size = new System.Drawing.Size(341, 47);
            this.btnAtender.TabIndex = 15;
            this.btnAtender.Text = "ATENDER";
            this.btnAtender.UseVisualStyleBackColor = false;
            this.btnAtender.Click += new System.EventHandler(this.btnAtender_Click);
            // 
            // dgvListaServicios
            // 
            this.dgvListaServicios.AllowUserToAddRows = false;
            this.dgvListaServicios.AllowUserToDeleteRows = false;
            this.dgvListaServicios.AllowUserToResizeColumns = false;
            this.dgvListaServicios.AllowUserToResizeRows = false;
            this.dgvListaServicios.BackgroundColor = System.Drawing.Color.Gray;
            this.dgvListaServicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListaServicios.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListaServicios.GridColor = System.Drawing.Color.Gray;
            this.dgvListaServicios.Location = new System.Drawing.Point(359, 48);
            this.dgvListaServicios.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvListaServicios.MultiSelect = false;
            this.dgvListaServicios.Name = "dgvListaServicios";
            this.dgvListaServicios.ReadOnly = true;
            this.dgvListaServicios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvListaServicios.RowHeadersWidth = 51;
            this.dgvListaServicios.RowTemplate.Height = 25;
            this.dgvListaServicios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaServicios.Size = new System.Drawing.Size(702, 363);
            this.dgvListaServicios.TabIndex = 16;
            // 
            // btnGestionarServicios
            // 
            this.btnGestionarServicios.BackColor = System.Drawing.Color.DimGray;
            this.btnGestionarServicios.FlatAppearance.BorderSize = 0;
            this.btnGestionarServicios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionarServicios.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGestionarServicios.ForeColor = System.Drawing.Color.White;
            this.btnGestionarServicios.Location = new System.Drawing.Point(12, 276);
            this.btnGestionarServicios.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGestionarServicios.Name = "btnGestionarServicios";
            this.btnGestionarServicios.Size = new System.Drawing.Size(339, 47);
            this.btnGestionarServicios.TabIndex = 17;
            this.btnGestionarServicios.Text = "GESTIONAR SERVICIOS";
            this.btnGestionarServicios.UseVisualStyleBackColor = false;
            this.btnGestionarServicios.Click += new System.EventHandler(this.btnGestionarServicios_Click);
            // 
            // picBoxLogo
            // 
            this.picBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("picBoxLogo.Image")));
            this.picBoxLogo.Location = new System.Drawing.Point(12, 10);
            this.picBoxLogo.Name = "picBoxLogo";
            this.picBoxLogo.Size = new System.Drawing.Size(341, 149);
            this.picBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBoxLogo.TabIndex = 18;
            this.picBoxLogo.TabStop = false;
            // 
            // lblProximosAEntregar
            // 
            this.lblProximosAEntregar.AutoSize = true;
            this.lblProximosAEntregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblProximosAEntregar.ForeColor = System.Drawing.Color.White;
            this.lblProximosAEntregar.Location = new System.Drawing.Point(359, 10);
            this.lblProximosAEntregar.Name = "lblProximosAEntregar";
            this.lblProximosAEntregar.Size = new System.Drawing.Size(352, 31);
            this.lblProximosAEntregar.TabIndex = 22;
            this.lblProximosAEntregar.Text = "PROXIMOS A ENTREGAR:";
            // 
            // btnGestionarArchivos
            // 
            this.btnGestionarArchivos.BackColor = System.Drawing.Color.DimGray;
            this.btnGestionarArchivos.FlatAppearance.BorderSize = 0;
            this.btnGestionarArchivos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionarArchivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGestionarArchivos.ForeColor = System.Drawing.Color.White;
            this.btnGestionarArchivos.Location = new System.Drawing.Point(14, 331);
            this.btnGestionarArchivos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGestionarArchivos.Name = "btnGestionarArchivos";
            this.btnGestionarArchivos.Size = new System.Drawing.Size(339, 47);
            this.btnGestionarArchivos.TabIndex = 23;
            this.btnGestionarArchivos.Text = "GESTIONAR ARCHIVOS";
            this.btnGestionarArchivos.UseVisualStyleBackColor = false;
            this.btnGestionarArchivos.Click += new System.EventHandler(this.btnGestionarArchivos_Click);
            // 
            // lblFechaEntregaExcedida
            // 
            this.lblFechaEntregaExcedida.AutoSize = true;
            this.lblFechaEntregaExcedida.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFechaEntregaExcedida.ForeColor = System.Drawing.Color.Firebrick;
            this.lblFechaEntregaExcedida.Location = new System.Drawing.Point(558, 415);
            this.lblFechaEntregaExcedida.Name = "lblFechaEntregaExcedida";
            this.lblFechaEntregaExcedida.Size = new System.Drawing.Size(503, 22);
            this.lblFechaEntregaExcedida.TabIndex = 24;
            this.lblFechaEntregaExcedida.Text = "HAY SERVICIOS EXCEDIDOS DE LA FECHA ESTIPULADA!";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1073, 446);
            this.Controls.Add(this.lblFechaEntregaExcedida);
            this.Controls.Add(this.btnGestionarArchivos);
            this.Controls.Add(this.lblProximosAEntregar);
            this.Controls.Add(this.picBoxLogo);
            this.Controls.Add(this.btnGestionarServicios);
            this.Controls.Add(this.dgvListaServicios);
            this.Controls.Add(this.btnAtender);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGestionarClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MundoPc";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaServicios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGestionarClientes;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnAtender;
        private System.Windows.Forms.DataGridView dgvListaServicios;
        private System.Windows.Forms.Button btnGestionarServicios;
        private System.Windows.Forms.PictureBox picBoxLogo;
        private System.Windows.Forms.Label lblProximosAEntregar;
        private System.Windows.Forms.Button btnGestionarArchivos;
        public System.Windows.Forms.Label lblFechaEntregaExcedida;
    }
}

