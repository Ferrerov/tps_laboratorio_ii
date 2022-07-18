
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
            this.btnGestionarClientes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGestionarClientes
            // 
            this.btnGestionarClientes.BackColor = System.Drawing.Color.DimGray;
            this.btnGestionarClientes.FlatAppearance.BorderSize = 0;
            this.btnGestionarClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionarClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGestionarClientes.ForeColor = System.Drawing.Color.White;
            this.btnGestionarClientes.Location = new System.Drawing.Point(12, 166);
            this.btnGestionarClientes.Name = "btnGestionarClientes";
            this.btnGestionarClientes.Size = new System.Drawing.Size(287, 35);
            this.btnGestionarClientes.TabIndex = 13;
            this.btnGestionarClientes.Text = "GESTIONAR CLIENTES";
            this.btnGestionarClientes.UseVisualStyleBackColor = false;
            this.btnGestionarClientes.Click += new System.EventHandler(this.btnGestionarClientes_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGestionarClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MundoPc";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGestionarClientes;
    }
}

