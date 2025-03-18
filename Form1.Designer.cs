namespace proyecto_so_hilos
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbProcesandoNumero = new System.Windows.Forms.TextBox();
            this.tbProcesandoHilo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbTipo = new System.Windows.Forms.TextBox();
            this.Dgv_Pares = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.btnEjecutar = new System.Windows.Forms.Button();
            this.colPotencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Pares)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Procesando número:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Procesando hilo:";
            // 
            // tbProcesandoNumero
            // 
            this.tbProcesandoNumero.Location = new System.Drawing.Point(241, 48);
            this.tbProcesandoNumero.Name = "tbProcesandoNumero";
            this.tbProcesandoNumero.Size = new System.Drawing.Size(100, 22);
            this.tbProcesandoNumero.TabIndex = 2;
            // 
            // tbProcesandoHilo
            // 
            this.tbProcesandoHilo.Location = new System.Drawing.Point(241, 88);
            this.tbProcesandoHilo.Name = "tbProcesandoHilo";
            this.tbProcesandoHilo.Size = new System.Drawing.Size(100, 22);
            this.tbProcesandoHilo.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(411, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tipo:";
            // 
            // tbTipo
            // 
            this.tbTipo.Location = new System.Drawing.Point(465, 45);
            this.tbTipo.Name = "tbTipo";
            this.tbTipo.Size = new System.Drawing.Size(100, 22);
            this.tbTipo.TabIndex = 5;
            // 
            // Dgv_Pares
            // 
            this.Dgv_Pares.AllowUserToOrderColumns = true;
            this.Dgv_Pares.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Pares.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPotencia});
            this.Dgv_Pares.Location = new System.Drawing.Point(560, 252);
            this.Dgv_Pares.Name = "Dgv_Pares";
            this.Dgv_Pares.RowHeadersWidth = 51;
            this.Dgv_Pares.RowTemplate.Height = 24;
            this.Dgv_Pares.Size = new System.Drawing.Size(183, 150);
            this.Dgv_Pares.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(557, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Potencia de números pares";
            // 
            // btnEjecutar
            // 
            this.btnEjecutar.Location = new System.Drawing.Point(560, 459);
            this.btnEjecutar.Name = "btnEjecutar";
            this.btnEjecutar.Size = new System.Drawing.Size(75, 23);
            this.btnEjecutar.TabIndex = 10;
            this.btnEjecutar.Text = "Ejecutar";
            this.btnEjecutar.UseVisualStyleBackColor = true;
            this.btnEjecutar.Click += new System.EventHandler(this.btnEjecutar_Click);
            // 
            // colPotencia
            // 
            this.colPotencia.DataPropertyName = "colPotencia";
            this.colPotencia.HeaderText = "Potencia";
            this.colPotencia.MinimumWidth = 6;
            this.colPotencia.Name = "colPotencia";
            this.colPotencia.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 613);
            this.Controls.Add(this.btnEjecutar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Dgv_Pares);
            this.Controls.Add(this.tbTipo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbProcesandoHilo);
            this.Controls.Add(this.tbProcesandoNumero);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Operaciones con hilos";
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Pares)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbProcesandoNumero;
        private System.Windows.Forms.TextBox tbProcesandoHilo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbTipo;
        private System.Windows.Forms.DataGridView Dgv_Pares;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnEjecutar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPotencia;
    }
}

