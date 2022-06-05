
namespace Forms
{
    partial class FormModificarCliente
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
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.txtNombredelCliente = new System.Windows.Forms.TextBox();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.txtDniDelCliente = new System.Windows.Forms.TextBox();
            this.lblDniDelCliente = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.txtSaldoDelCliente = new System.Windows.Forms.TextBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvClientes
            // 
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(11, 78);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.Size = new System.Drawing.Size(360, 315);
            this.dgvClientes.TabIndex = 1;
            this.dgvClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellContentClick);
            // 
            // txtNombredelCliente
            // 
            this.txtNombredelCliente.Location = new System.Drawing.Point(377, 102);
            this.txtNombredelCliente.Name = "txtNombredelCliente";
            this.txtNombredelCliente.Size = new System.Drawing.Size(195, 23);
            this.txtNombredelCliente.TabIndex = 10;
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNombreCliente.Location = new System.Drawing.Point(377, 78);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(160, 21);
            this.lblNombreCliente.TabIndex = 9;
            this.lblNombreCliente.Text = "Nombre del cliente:";
            // 
            // txtDniDelCliente
            // 
            this.txtDniDelCliente.Location = new System.Drawing.Point(377, 177);
            this.txtDniDelCliente.Name = "txtDniDelCliente";
            this.txtDniDelCliente.Size = new System.Drawing.Size(195, 23);
            this.txtDniDelCliente.TabIndex = 11;
            // 
            // lblDniDelCliente
            // 
            this.lblDniDelCliente.AutoSize = true;
            this.lblDniDelCliente.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDniDelCliente.Location = new System.Drawing.Point(377, 153);
            this.lblDniDelCliente.Name = "lblDniDelCliente";
            this.lblDniDelCliente.Size = new System.Drawing.Size(123, 21);
            this.lblDniDelCliente.TabIndex = 12;
            this.lblDniDelCliente.Text = "Dni del cliente:";
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSaldo.Location = new System.Drawing.Point(377, 228);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(56, 21);
            this.lblSaldo.TabIndex = 13;
            this.lblSaldo.Text = "Saldo:";
            // 
            // txtSaldoDelCliente
            // 
            this.txtSaldoDelCliente.Location = new System.Drawing.Point(377, 252);
            this.txtSaldoDelCliente.Name = "txtSaldoDelCliente";
            this.txtSaldoDelCliente.Size = new System.Drawing.Size(195, 23);
            this.txtSaldoDelCliente.TabIndex = 14;
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnModificar.Location = new System.Drawing.Point(419, 300);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(113, 33);
            this.btnModificar.TabIndex = 16;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.Location = new System.Drawing.Point(419, 360);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(113, 33);
            this.btnCancelar.TabIndex = 17;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // FormModificarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 404);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.txtSaldoDelCliente);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.lblDniDelCliente);
            this.Controls.Add(this.txtDniDelCliente);
            this.Controls.Add(this.txtNombredelCliente);
            this.Controls.Add(this.lblNombreCliente);
            this.Controls.Add(this.dgvClientes);
            this.Name = "FormModificarCliente";
            this.Text = "FormModificarCliente";
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.TextBox txtNombredelCliente;
        private System.Windows.Forms.Label lblNombreCliente;
        private System.Windows.Forms.TextBox txtDniDelCliente;
        private System.Windows.Forms.Label lblDniDelCliente;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.TextBox txtSaldoDelCliente;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnCancelar;
    }
}