
namespace AppWindowsVentas
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
            this.btnTraerTodosLosVendedores = new System.Windows.Forms.Button();
            this.gridVendedor = new System.Windows.Forms.DataGridView();
            this.btnAgregarVendedor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridVendedor)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTraerTodosLosVendedores
            // 
            this.btnTraerTodosLosVendedores.Location = new System.Drawing.Point(181, 66);
            this.btnTraerTodosLosVendedores.Name = "btnTraerTodosLosVendedores";
            this.btnTraerTodosLosVendedores.Size = new System.Drawing.Size(167, 23);
            this.btnTraerTodosLosVendedores.TabIndex = 0;
            this.btnTraerTodosLosVendedores.Text = "Traer todos los Vendedores";
            this.btnTraerTodosLosVendedores.UseVisualStyleBackColor = true;
            this.btnTraerTodosLosVendedores.Click += new System.EventHandler(this.btnTraerTodosLosVendedores_Click);
            // 
            // gridVendedor
            // 
            this.gridVendedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridVendedor.Location = new System.Drawing.Point(212, 266);
            this.gridVendedor.Name = "gridVendedor";
            this.gridVendedor.Size = new System.Drawing.Size(398, 150);
            this.gridVendedor.TabIndex = 2;
            this.gridVendedor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridVendedor_CellContentClick);
            // 
            // btnAgregarVendedor
            // 
            this.btnAgregarVendedor.Location = new System.Drawing.Point(181, 149);
            this.btnAgregarVendedor.Name = "btnAgregarVendedor";
            this.btnAgregarVendedor.Size = new System.Drawing.Size(136, 23);
            this.btnAgregarVendedor.TabIndex = 3;
            this.btnAgregarVendedor.Text = "Agregar Vendedor";
            this.btnAgregarVendedor.UseVisualStyleBackColor = true;
            this.btnAgregarVendedor.Click += new System.EventHandler(this.btnAgregarVendedor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAgregarVendedor);
            this.Controls.Add(this.gridVendedor);
            this.Controls.Add(this.btnTraerTodosLosVendedores);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gridVendedor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTraerTodosLosVendedores;
        private System.Windows.Forms.DataGridView gridVendedor;
        private System.Windows.Forms.Button btnAgregarVendedor;
    }
}

