
namespace Forms
{
    partial class FormAtender
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.cmbServico = new System.Windows.Forms.ComboBox();
            this.txtBoxDetalle = new System.Windows.Forms.TextBox();
            this.cmbDispositivo = new System.Windows.Forms.ComboBox();
            this.lblServicio = new System.Windows.Forms.Label();
            this.lblDispositivo = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.lblDniCliente = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblEntrega = new System.Windows.Forms.Label();
            this.dtPickerEntrega = new System.Windows.Forms.DateTimePicker();
            this.lblDetalle = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.DimGray;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(12, 415);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(113, 47);
            this.btnSalir.TabIndex = 14;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNombreCliente.ForeColor = System.Drawing.Color.White;
            this.lblNombreCliente.Location = new System.Drawing.Point(12, 24);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(145, 31);
            this.lblNombreCliente.TabIndex = 15;
            this.lblNombreCliente.Text = "CLIENTE: ";
            // 
            // cmbServico
            // 
            this.cmbServico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbServico.FormattingEnabled = true;
            this.cmbServico.Location = new System.Drawing.Point(218, 125);
            this.cmbServico.Name = "cmbServico";
            this.cmbServico.Size = new System.Drawing.Size(169, 26);
            this.cmbServico.TabIndex = 16;
            // 
            // txtBoxDetalle
            // 
            this.txtBoxDetalle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxDetalle.Location = new System.Drawing.Point(158, 218);
            this.txtBoxDetalle.Multiline = true;
            this.txtBoxDetalle.Name = "txtBoxDetalle";
            this.txtBoxDetalle.Size = new System.Drawing.Size(229, 84);
            this.txtBoxDetalle.TabIndex = 17;
            // 
            // cmbDispositivo
            // 
            this.cmbDispositivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbDispositivo.FormattingEnabled = true;
            this.cmbDispositivo.Location = new System.Drawing.Point(218, 173);
            this.cmbDispositivo.Name = "cmbDispositivo";
            this.cmbDispositivo.Size = new System.Drawing.Size(169, 26);
            this.cmbDispositivo.TabIndex = 18;
            // 
            // lblServicio
            // 
            this.lblServicio.AutoSize = true;
            this.lblServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblServicio.ForeColor = System.Drawing.Color.White;
            this.lblServicio.Location = new System.Drawing.Point(12, 120);
            this.lblServicio.Name = "lblServicio";
            this.lblServicio.Size = new System.Drawing.Size(153, 31);
            this.lblServicio.TabIndex = 19;
            this.lblServicio.Text = "SERVICIO:";
            // 
            // lblDispositivo
            // 
            this.lblDispositivo.AutoSize = true;
            this.lblDispositivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDispositivo.ForeColor = System.Drawing.Color.White;
            this.lblDispositivo.Location = new System.Drawing.Point(12, 168);
            this.lblDispositivo.Name = "lblDispositivo";
            this.lblDispositivo.Size = new System.Drawing.Size(197, 31);
            this.lblDispositivo.TabIndex = 20;
            this.lblDispositivo.Text = "DISPOSITIVO:";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.Green;
            this.btnConfirmar.FlatAppearance.BorderSize = 0;
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnConfirmar.ForeColor = System.Drawing.Color.White;
            this.btnConfirmar.Location = new System.Drawing.Point(131, 415);
            this.btnConfirmar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(256, 47);
            this.btnConfirmar.TabIndex = 21;
            this.btnConfirmar.Text = "CONFIRMAR";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // lblDniCliente
            // 
            this.lblDniCliente.AutoSize = true;
            this.lblDniCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDniCliente.ForeColor = System.Drawing.Color.White;
            this.lblDniCliente.Location = new System.Drawing.Point(12, 72);
            this.lblDniCliente.Name = "lblDniCliente";
            this.lblDniCliente.Size = new System.Drawing.Size(77, 31);
            this.lblDniCliente.TabIndex = 22;
            this.lblDniCliente.Text = "DNI: ";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPrecio.ForeColor = System.Drawing.Color.White;
            this.lblPrecio.Location = new System.Drawing.Point(12, 322);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(127, 31);
            this.lblPrecio.TabIndex = 23;
            this.lblPrecio.Text = "PRECIO:";
            // 
            // lblEntrega
            // 
            this.lblEntrega.AutoSize = true;
            this.lblEntrega.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEntrega.ForeColor = System.Drawing.Color.White;
            this.lblEntrega.Location = new System.Drawing.Point(12, 370);
            this.lblEntrega.Name = "lblEntrega";
            this.lblEntrega.Size = new System.Drawing.Size(256, 31);
            this.lblEntrega.TabIndex = 24;
            this.lblEntrega.Text = "ENTREGA APROX:";
            // 
            // dtPickerEntrega
            // 
            this.dtPickerEntrega.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtPickerEntrega.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtPickerEntrega.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPickerEntrega.Location = new System.Drawing.Point(268, 375);
            this.dtPickerEntrega.Name = "dtPickerEntrega";
            this.dtPickerEntrega.Size = new System.Drawing.Size(119, 24);
            this.dtPickerEntrega.TabIndex = 26;
            // 
            // lblDetalle
            // 
            this.lblDetalle.AutoSize = true;
            this.lblDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDetalle.ForeColor = System.Drawing.Color.White;
            this.lblDetalle.Location = new System.Drawing.Point(12, 218);
            this.lblDetalle.Name = "lblDetalle";
            this.lblDetalle.Size = new System.Drawing.Size(143, 31);
            this.lblDetalle.TabIndex = 27;
            this.lblDetalle.Text = "DETALLE:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPrecio.Location = new System.Drawing.Point(218, 326);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(169, 24);
            this.txtPrecio.TabIndex = 28;
            // 
            // FormAtender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(400, 476);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.lblDetalle);
            this.Controls.Add(this.dtPickerEntrega);
            this.Controls.Add(this.lblEntrega);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblDniCliente);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.lblDispositivo);
            this.Controls.Add(this.lblServicio);
            this.Controls.Add(this.cmbDispositivo);
            this.Controls.Add(this.txtBoxDetalle);
            this.Controls.Add(this.cmbServico);
            this.Controls.Add(this.lblNombreCliente);
            this.Controls.Add(this.btnSalir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormAtender";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Atender Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        public System.Windows.Forms.Label lblNombreCliente;
        private System.Windows.Forms.ComboBox cmbServico;
        //private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cmbDispositivo;
        public System.Windows.Forms.Label lblServicio;
        public System.Windows.Forms.Label lblDispositivo;
        private System.Windows.Forms.Button btnConfirmar;
        public System.Windows.Forms.Label lblDniCliente;
        private System.Windows.Forms.TextBox txtBoxDetalle;
        public System.Windows.Forms.Label lblPrecio;
        public System.Windows.Forms.Label lblEntrega;
        private System.Windows.Forms.DateTimePicker dtPickerEntrega;
        public System.Windows.Forms.Label lblDetalle;
        private System.Windows.Forms.TextBox txtPrecio;
    }
}