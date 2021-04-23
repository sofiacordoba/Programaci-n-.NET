
namespace Windowsadonet
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
            this.btnAutores = new System.Windows.Forms.Button();
            this.lstAutor = new System.Windows.Forms.ListBox();
            this.btnEditor = new System.Windows.Forms.Button();
            this.lstEditor = new System.Windows.Forms.ListBox();
            this.gridPublisher = new System.Windows.Forms.DataGridView();
            this.btnTraerTodosPublisher = new System.Windows.Forms.Button();
            this.btnInsertarEditor = new System.Windows.Forms.Button();
            this.btnInsertarAutor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridPublisher)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAutores
            // 
            this.btnAutores.Location = new System.Drawing.Point(194, 50);
            this.btnAutores.Name = "btnAutores";
            this.btnAutores.Size = new System.Drawing.Size(249, 23);
            this.btnAutores.TabIndex = 0;
            this.btnAutores.Text = "Mostrar valores";
            this.btnAutores.UseVisualStyleBackColor = true;
            // 
            // lstAutor
            // 
            this.lstAutor.FormattingEnabled = true;
            this.lstAutor.Location = new System.Drawing.Point(491, 32);
            this.lstAutor.Name = "lstAutor";
            this.lstAutor.Size = new System.Drawing.Size(120, 95);
            this.lstAutor.TabIndex = 1;
            // 
            // btnEditor
            // 
            this.btnEditor.Location = new System.Drawing.Point(210, 117);
            this.btnEditor.Name = "btnEditor";
            this.btnEditor.Size = new System.Drawing.Size(171, 23);
            this.btnEditor.TabIndex = 2;
            this.btnEditor.Text = "Mostrar Editores";
            this.btnEditor.UseVisualStyleBackColor = true;
            this.btnEditor.Click += new System.EventHandler(this.btnEditor_Click);
            // 
            // lstEditor
            // 
            this.lstEditor.FormattingEnabled = true;
            this.lstEditor.Location = new System.Drawing.Point(501, 145);
            this.lstEditor.Name = "lstEditor";
            this.lstEditor.Size = new System.Drawing.Size(120, 95);
            this.lstEditor.TabIndex = 3;
            // 
            // gridPublisher
            // 
            this.gridPublisher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPublisher.Location = new System.Drawing.Point(194, 288);
            this.gridPublisher.Name = "gridPublisher";
            this.gridPublisher.Size = new System.Drawing.Size(511, 150);
            this.gridPublisher.TabIndex = 4;
            // 
            // btnTraerTodosPublisher
            // 
            this.btnTraerTodosPublisher.Location = new System.Drawing.Point(210, 250);
            this.btnTraerTodosPublisher.Name = "btnTraerTodosPublisher";
            this.btnTraerTodosPublisher.Size = new System.Drawing.Size(185, 23);
            this.btnTraerTodosPublisher.TabIndex = 5;
            this.btnTraerTodosPublisher.Text = "Traer Todos los Publisher";
            this.btnTraerTodosPublisher.UseVisualStyleBackColor = true;
            this.btnTraerTodosPublisher.Click += new System.EventHandler(this.btnTraerTodosPublisher_Click);
            // 
            // btnInsertarEditor
            // 
            this.btnInsertarEditor.Location = new System.Drawing.Point(501, 259);
            this.btnInsertarEditor.Name = "btnInsertarEditor";
            this.btnInsertarEditor.Size = new System.Drawing.Size(129, 23);
            this.btnInsertarEditor.TabIndex = 6;
            this.btnInsertarEditor.Text = "Insertar Editor";
            this.btnInsertarEditor.UseVisualStyleBackColor = true;
            this.btnInsertarEditor.Click += new System.EventHandler(this.btnInsertarEditor_Click);
            // 
            // btnInsertarAutor
            // 
            this.btnInsertarAutor.Location = new System.Drawing.Point(664, 258);
            this.btnInsertarAutor.Name = "btnInsertarAutor";
            this.btnInsertarAutor.Size = new System.Drawing.Size(119, 23);
            this.btnInsertarAutor.TabIndex = 7;
            this.btnInsertarAutor.Text = "Insertar Autor";
            this.btnInsertarAutor.UseVisualStyleBackColor = true;
            this.btnInsertarAutor.Click += new System.EventHandler(this.btnInsertarAutor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnInsertarAutor);
            this.Controls.Add(this.btnInsertarEditor);
            this.Controls.Add(this.btnTraerTodosPublisher);
            this.Controls.Add(this.gridPublisher);
            this.Controls.Add(this.lstEditor);
            this.Controls.Add(this.btnEditor);
            this.Controls.Add(this.lstAutor);
            this.Controls.Add(this.btnAutores);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gridPublisher)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAutores;
        private System.Windows.Forms.ListBox lstAutor;
        private System.Windows.Forms.Button btnEditor;
        private System.Windows.Forms.ListBox lstEditor;
        private System.Windows.Forms.DataGridView gridPublisher;
        private System.Windows.Forms.Button btnTraerTodosPublisher;
        private System.Windows.Forms.Button btnInsertarEditor;
        private System.Windows.Forms.Button btnInsertarAutor;
    }
}

