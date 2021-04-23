
namespace SistemaFacturación
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnMostrarClientes = new System.Windows.Forms.Button();
            this.lstCliente = new System.Windows.Forms.ListBox();
            this.gridCliente = new System.Windows.Forms.DataGridView();
            this.btnTraerTodosClientes = new System.Windows.Forms.Button();
            this.btnInsertarCliente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMostrarClientes
            // 
            this.btnMostrarClientes.Location = new System.Drawing.Point(131, 76);
            this.btnMostrarClientes.Name = "btnMostrarClientes";
            this.btnMostrarClientes.Size = new System.Drawing.Size(192, 23);
            this.btnMostrarClientes.TabIndex = 0;
            this.btnMostrarClientes.Text = "Mostrar Clientes";
            this.btnMostrarClientes.UseVisualStyleBackColor = true;
            this.btnMostrarClientes.Click += new System.EventHandler(this.btnMostrarClientes_Click);
            // 
            // lstCliente
            // 
            this.lstCliente.FormattingEnabled = true;
            this.lstCliente.Location = new System.Drawing.Point(357, 65);
            this.lstCliente.Name = "lstCliente";
            this.lstCliente.Size = new System.Drawing.Size(173, 82);
            this.lstCliente.TabIndex = 1;
            // 
            // gridCliente
            // 
            this.gridCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCliente.Location = new System.Drawing.Point(211, 265);
            this.gridCliente.Name = "gridCliente";
            this.gridCliente.Size = new System.Drawing.Size(334, 150);
            this.gridCliente.TabIndex = 2;
            // 
            // btnTraerTodosClientes
            // 
            this.btnTraerTodosClientes.Location = new System.Drawing.Point(192, 233);
            this.btnTraerTodosClientes.Name = "btnTraerTodosClientes";
            this.btnTraerTodosClientes.Size = new System.Drawing.Size(168, 23);
            this.btnTraerTodosClientes.TabIndex = 3;
            this.btnTraerTodosClientes.Text = "traer todos los clientes";
            this.btnTraerTodosClientes.UseVisualStyleBackColor = true;
            this.btnTraerTodosClientes.Click += new System.EventHandler(this.btnTraerTodosClientes_Click);
            // 
            // btnInsertarCliente
            // 
            this.btnInsertarCliente.Location = new System.Drawing.Point(557, 232);
            this.btnInsertarCliente.Name = "btnInsertarCliente";
            this.btnInsertarCliente.Size = new System.Drawing.Size(117, 23);
            this.btnInsertarCliente.TabIndex = 4;
            this.btnInsertarCliente.Text = "insertarCliente";
            this.btnInsertarCliente.UseVisualStyleBackColor = true;
            this.btnInsertarCliente.Click += new System.EventHandler(this.btnInsertarCliente_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnInsertarCliente);
            this.Controls.Add(this.btnTraerTodosClientes);
            this.Controls.Add(this.gridCliente);
            this.Controls.Add(this.lstCliente);
            this.Controls.Add(this.btnMostrarClientes);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gridCliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMostrarClientes;
        private System.Windows.Forms.ListBox lstCliente;
        private System.Windows.Forms.DataGridView gridCliente;
        private System.Windows.Forms.Button btnTraerTodosClientes;
        private System.Windows.Forms.Button btnInsertarCliente;
    }
}

