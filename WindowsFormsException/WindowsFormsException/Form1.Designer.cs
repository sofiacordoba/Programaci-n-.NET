
namespace WindowsFormsException
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
            this.btnPrueba1 = new System.Windows.Forms.Button();
            this.btnPruebaSQLServer = new System.Windows.Forms.Button();
            this.btnExceptionSQLServer2 = new System.Windows.Forms.Button();
            this.btnCrearEvento = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPrueba1
            // 
            this.btnPrueba1.Location = new System.Drawing.Point(175, 75);
            this.btnPrueba1.Name = "btnPrueba1";
            this.btnPrueba1.Size = new System.Drawing.Size(162, 23);
            this.btnPrueba1.TabIndex = 0;
            this.btnPrueba1.Text = "Prueba exception";
            this.btnPrueba1.UseVisualStyleBackColor = true;
            this.btnPrueba1.Click += new System.EventHandler(this.btnPrueba1_Click);
            // 
            // btnPruebaSQLServer
            // 
            this.btnPruebaSQLServer.Location = new System.Drawing.Point(175, 144);
            this.btnPruebaSQLServer.Name = "btnPruebaSQLServer";
            this.btnPruebaSQLServer.Size = new System.Drawing.Size(174, 23);
            this.btnPruebaSQLServer.TabIndex = 1;
            this.btnPruebaSQLServer.Text = "Prueba Exception SQL";
            this.btnPruebaSQLServer.UseVisualStyleBackColor = true;
            this.btnPruebaSQLServer.Click += new System.EventHandler(this.btnPruebaSQLServer_Click);
            // 
            // btnExceptionSQLServer2
            // 
            this.btnExceptionSQLServer2.Location = new System.Drawing.Point(175, 194);
            this.btnExceptionSQLServer2.Name = "btnExceptionSQLServer2";
            this.btnExceptionSQLServer2.Size = new System.Drawing.Size(170, 28);
            this.btnExceptionSQLServer2.TabIndex = 2;
            this.btnExceptionSQLServer2.Text = "Prueba Exception SQL Server 2";
            this.btnExceptionSQLServer2.UseVisualStyleBackColor = true;
            this.btnExceptionSQLServer2.Click += new System.EventHandler(this.btnExceptionSQLServer2_Click);
            // 
            // btnCrearEvento
            // 
            this.btnCrearEvento.Location = new System.Drawing.Point(157, 268);
            this.btnCrearEvento.Name = "btnCrearEvento";
            this.btnCrearEvento.Size = new System.Drawing.Size(173, 23);
            this.btnCrearEvento.TabIndex = 3;
            this.btnCrearEvento.Text = "Crear Evento";
            this.btnCrearEvento.UseVisualStyleBackColor = true;
            this.btnCrearEvento.Click += new System.EventHandler(this.btnCrearEvento_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCrearEvento);
            this.Controls.Add(this.btnExceptionSQLServer2);
            this.Controls.Add(this.btnPruebaSQLServer);
            this.Controls.Add(this.btnPrueba1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPrueba1;
        private System.Windows.Forms.Button btnPruebaSQLServer;
        private System.Windows.Forms.Button btnExceptionSQLServer2;
        private System.Windows.Forms.Button btnCrearEvento;
    }
}

