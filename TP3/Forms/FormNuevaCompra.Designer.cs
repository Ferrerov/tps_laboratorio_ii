
namespace Forms
{
    partial class FormNuevaCompra
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvListaVinos = new System.Windows.Forms.DataGridView();
            this.lblSeleccionarVino = new System.Windows.Forms.Label();
            this.lblCarrito = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaVinos)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cantidad,
            this.Marca,
            this.Tipo,
            this.Precio});
            this.dataGridView1.Location = new System.Drawing.Point(188, 328);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(600, 250);
            this.dataGridView1.TabIndex = 1;
            // 
            // Cantidad
            // 
            this.Cantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Cantidad.HeaderText = "Cant.";
            this.Cantidad.Name = "Cantidad";
            // 
            // Marca
            // 
            this.Marca.HeaderText = "Marca";
            this.Marca.Name = "Marca";
            this.Marca.Width = 300;
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            // 
            // dgvListaVinos
            // 
            this.dgvListaVinos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaVinos.Location = new System.Drawing.Point(188, 79);
            this.dgvListaVinos.Name = "dgvListaVinos";
            this.dgvListaVinos.RowTemplate.Height = 25;
            this.dgvListaVinos.Size = new System.Drawing.Size(600, 195);
            this.dgvListaVinos.TabIndex = 2;
            // 
            // lblSeleccionarVino
            // 
            this.lblSeleccionarVino.AutoSize = true;
            this.lblSeleccionarVino.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSeleccionarVino.Location = new System.Drawing.Point(188, 42);
            this.lblSeleccionarVino.Name = "lblSeleccionarVino";
            this.lblSeleccionarVino.Size = new System.Drawing.Size(142, 25);
            this.lblSeleccionarVino.TabIndex = 3;
            this.lblSeleccionarVino.Text = "Lista de vinos:";
            // 
            // lblCarrito
            // 
            this.lblCarrito.AutoSize = true;
            this.lblCarrito.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCarrito.Location = new System.Drawing.Point(188, 288);
            this.lblCarrito.Name = "lblCarrito";
            this.lblCarrito.Size = new System.Drawing.Size(79, 25);
            this.lblCarrito.TabIndex = 4;
            this.lblCarrito.Text = "Carrito:";
            // 
            // FormNuevaCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 590);
            this.Controls.Add(this.lblCarrito);
            this.Controls.Add(this.lblSeleccionarVino);
            this.Controls.Add(this.dgvListaVinos);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormNuevaCompra";
            this.Text = "FormNuevaCompra";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaVinos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridView dgvListaVinos;
        private System.Windows.Forms.Label lblSeleccionarVino;
        private System.Windows.Forms.Label lblCarrito;
    }
}