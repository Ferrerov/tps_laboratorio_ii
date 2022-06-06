
namespace Forms
{
    partial class FormListaClientes
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
            this.dgvListaClientes = new System.Windows.Forms.DataGridView();
            this.txtDniCliente = new System.Windows.Forms.TextBox();
            this.lblDniDelCliente = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListaClientes
            // 
            this.dgvListaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaClientes.Location = new System.Drawing.Point(12, 98);
            this.dgvListaClientes.Name = "dgvListaClientes";
            this.dgvListaClientes.RowTemplate.Height = 25;
            this.dgvListaClientes.Size = new System.Drawing.Size(343, 340);
            this.dgvListaClientes.TabIndex = 0;
            // 
            // txtDniCliente
            // 
            this.txtDniCliente.Location = new System.Drawing.Point(141, 48);
            this.txtDniCliente.Name = "txtDniCliente";
            this.txtDniCliente.Size = new System.Drawing.Size(131, 23);
            this.txtDniCliente.TabIndex = 0;
            // 
            // lblDniDelCliente
            // 
            this.lblDniDelCliente.AutoSize = true;
            this.lblDniDelCliente.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDniDelCliente.Location = new System.Drawing.Point(12, 48);
            this.lblDniDelCliente.Name = "lblDniDelCliente";
            this.lblDniDelCliente.Size = new System.Drawing.Size(123, 21);
            this.lblDniDelCliente.TabIndex = 9;
            this.lblDniDelCliente.Text = "Dni del cliente:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(278, 43);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(78, 31);
            this.btnBuscar.TabIndex = 11;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // FormListaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 450);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtDniCliente);
            this.Controls.Add(this.lblDniDelCliente);
            this.Controls.Add(this.dgvListaClientes);
            this.Name = "FormListaClientes";
            this.Text = "FormListaClientes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListaClientes;
        private System.Windows.Forms.TextBox txtDniCliente;
        private System.Windows.Forms.Label lblDniDelCliente;
        private System.Windows.Forms.Button btnBuscar;
    }
}