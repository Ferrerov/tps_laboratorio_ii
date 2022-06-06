
namespace Forms
{
    partial class FormSeleccionarCliente
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
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtDniCliente = new System.Windows.Forms.TextBox();
            this.lblDniDelCliente = new System.Windows.Forms.Label();
            this.dgvListaClientes = new System.Windows.Forms.DataGridView();
            this.btnContinuar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(278, 43);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(78, 31);
            this.btnBuscar.TabIndex = 15;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // txtDniCliente
            // 
            this.txtDniCliente.Location = new System.Drawing.Point(141, 48);
            this.txtDniCliente.Name = "txtDniCliente";
            this.txtDniCliente.Size = new System.Drawing.Size(131, 23);
            this.txtDniCliente.TabIndex = 12;
            // 
            // lblDniDelCliente
            // 
            this.lblDniDelCliente.AutoSize = true;
            this.lblDniDelCliente.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDniDelCliente.Location = new System.Drawing.Point(12, 48);
            this.lblDniDelCliente.Name = "lblDniDelCliente";
            this.lblDniDelCliente.Size = new System.Drawing.Size(123, 21);
            this.lblDniDelCliente.TabIndex = 14;
            this.lblDniDelCliente.Text = "Dni del cliente:";
            // 
            // dgvListaClientes
            // 
            this.dgvListaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaClientes.Location = new System.Drawing.Point(12, 98);
            this.dgvListaClientes.Name = "dgvListaClientes";
            this.dgvListaClientes.RowTemplate.Height = 25;
            this.dgvListaClientes.Size = new System.Drawing.Size(343, 340);
            this.dgvListaClientes.TabIndex = 13;
            // 
            // btnContinuar
            // 
            this.btnContinuar.Location = new System.Drawing.Point(202, 459);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(126, 31);
            this.btnContinuar.TabIndex = 16;
            this.btnContinuar.Text = "CONTINUAR";
            this.btnContinuar.UseVisualStyleBackColor = true;
            this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(36, 459);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(126, 31);
            this.btnCancelar.TabIndex = 17;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FormSeleccionarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 502);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnContinuar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtDniCliente);
            this.Controls.Add(this.lblDniDelCliente);
            this.Controls.Add(this.dgvListaClientes);
            this.Name = "FormSeleccionarCliente";
            this.Text = "FormSeleccionarCliente";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtDniCliente;
        private System.Windows.Forms.Label lblDniDelCliente;
        private System.Windows.Forms.DataGridView dgvListaClientes;
        private System.Windows.Forms.Button btnContinuar;
        private System.Windows.Forms.Button btnCancelar;
    }
}