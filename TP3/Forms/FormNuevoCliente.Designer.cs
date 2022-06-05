
namespace Forms
{
    partial class FormNuevoCliente
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
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.lblDniCliente = new System.Windows.Forms.Label();
            this.lblCabecera = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.txtNombredelCliente = new System.Windows.Forms.TextBox();
            this.txtDniDelCliente = new System.Windows.Forms.TextBox();
            this.lblSaldoInicial = new System.Windows.Forms.Label();
            this.txtSaldoInicial = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNombreCliente.Location = new System.Drawing.Point(12, 58);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(160, 21);
            this.lblNombreCliente.TabIndex = 0;
            this.lblNombreCliente.Text = "Nombre del cliente:";
            // 
            // lblDniCliente
            // 
            this.lblDniCliente.AutoSize = true;
            this.lblDniCliente.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDniCliente.Location = new System.Drawing.Point(12, 108);
            this.lblDniCliente.Name = "lblDniCliente";
            this.lblDniCliente.Size = new System.Drawing.Size(127, 21);
            this.lblDniCliente.TabIndex = 1;
            this.lblDniCliente.Text = "DNI del cliente:";
            // 
            // lblCabecera
            // 
            this.lblCabecera.AutoSize = true;
            this.lblCabecera.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCabecera.Location = new System.Drawing.Point(54, 18);
            this.lblCabecera.Name = "lblCabecera";
            this.lblCabecera.Size = new System.Drawing.Size(274, 21);
            this.lblCabecera.TabIndex = 4;
            this.lblCabecera.Text = "Ingrese los datos del nuevo cliente";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.Location = new System.Drawing.Point(68, 216);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(113, 33);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnConfirmar.Location = new System.Drawing.Point(203, 216);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(113, 33);
            this.btnConfirmar.TabIndex = 7;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // txtNombredelCliente
            // 
            this.txtNombredelCliente.Location = new System.Drawing.Point(177, 60);
            this.txtNombredelCliente.Name = "txtNombredelCliente";
            this.txtNombredelCliente.Size = new System.Drawing.Size(195, 23);
            this.txtNombredelCliente.TabIndex = 8;
            // 
            // txtDniDelCliente
            // 
            this.txtDniDelCliente.Location = new System.Drawing.Point(177, 106);
            this.txtDniDelCliente.Name = "txtDniDelCliente";
            this.txtDniDelCliente.Size = new System.Drawing.Size(195, 23);
            this.txtDniDelCliente.TabIndex = 9;
            // 
            // lblSaldoInicial
            // 
            this.lblSaldoInicial.AutoSize = true;
            this.lblSaldoInicial.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSaldoInicial.Location = new System.Drawing.Point(12, 158);
            this.lblSaldoInicial.Name = "lblSaldoInicial";
            this.lblSaldoInicial.Size = new System.Drawing.Size(105, 21);
            this.lblSaldoInicial.TabIndex = 10;
            this.lblSaldoInicial.Text = "Saldo Inicial:";
            // 
            // txtSaldoInicial
            // 
            this.txtSaldoInicial.Location = new System.Drawing.Point(177, 160);
            this.txtSaldoInicial.Name = "txtSaldoInicial";
            this.txtSaldoInicial.Size = new System.Drawing.Size(195, 23);
            this.txtSaldoInicial.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(322, 216);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 33);
            this.button1.TabIndex = 12;
            this.button1.Text = "Confirmar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(12, 216);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 33);
            this.button2.TabIndex = 13;
            this.button2.Text = "Confirmar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // FormNuevoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtSaldoInicial);
            this.Controls.Add(this.lblSaldoInicial);
            this.Controls.Add(this.txtDniDelCliente);
            this.Controls.Add(this.txtNombredelCliente);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblCabecera);
            this.Controls.Add(this.lblDniCliente);
            this.Controls.Add(this.lblNombreCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormNuevoCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombreCliente;
        private System.Windows.Forms.Label lblDniCliente;
        private System.Windows.Forms.Label lblCabecera;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.TextBox txtNombredelCliente;
        private System.Windows.Forms.TextBox txtDniDelCliente;
        private System.Windows.Forms.Label lblSaldoInicial;
        private System.Windows.Forms.TextBox txtSaldoInicial;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}