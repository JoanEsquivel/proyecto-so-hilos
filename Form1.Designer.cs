using System;

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
            this.txtNumeros = new System.Windows.Forms.TextBox();
            this.txtHilo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.dgPares = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.btnEjecutar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dgNumeros = new System.Windows.Forms.DataGridView();
            this.dgImpares = new System.Windows.Forms.DataGridView();
            this.dgTablas = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgPares)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgNumeros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgImpares)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgTablas)).BeginInit();
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
            // txtNumeros
            // 
            this.txtNumeros.Location = new System.Drawing.Point(241, 48);
            this.txtNumeros.Name = "txtNumeros";
            this.txtNumeros.ReadOnly = true;
            this.txtNumeros.Size = new System.Drawing.Size(100, 22);
            this.txtNumeros.TabIndex = 2;
            // 
            // txtHilo
            // 
            this.txtHilo.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtHilo.Location = new System.Drawing.Point(241, 88);
            this.txtHilo.Name = "txtHilo";
            this.txtHilo.ReadOnly = true;
            this.txtHilo.Size = new System.Drawing.Size(100, 22);
            this.txtHilo.TabIndex = 3;
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
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(465, 45);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.ReadOnly = true;
            this.txtTipo.Size = new System.Drawing.Size(100, 22);
            this.txtTipo.TabIndex = 5;
            // 
            // dgPares
            // 
            this.dgPares.AllowUserToOrderColumns = true;
            this.dgPares.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPares.Location = new System.Drawing.Point(620, 192);
            this.dgPares.Name = "dgPares";
            this.dgPares.RowHeadersWidth = 51;
            this.dgPares.RowTemplate.Height = 24;
            this.dgPares.Size = new System.Drawing.Size(205, 280);
            this.dgPares.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(617, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Potencia de números pares";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // btnEjecutar
            // 
            this.btnEjecutar.Location = new System.Drawing.Point(807, 537);
            this.btnEjecutar.Name = "btnEjecutar";
            this.btnEjecutar.Size = new System.Drawing.Size(75, 23);
            this.btnEjecutar.TabIndex = 10;
            this.btnEjecutar.Text = "Ejecutar";
            this.btnEjecutar.UseVisualStyleBackColor = true;
            this.btnEjecutar.Click += new System.EventHandler(this.btnEjecutar_Click_1);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(915, 537);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dgNumeros
            // 
            this.dgNumeros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgNumeros.Location = new System.Drawing.Point(58, 201);
            this.dgNumeros.Name = "dgNumeros";
            this.dgNumeros.RowHeadersWidth = 51;
            this.dgNumeros.RowTemplate.Height = 24;
            this.dgNumeros.Size = new System.Drawing.Size(231, 271);
            this.dgNumeros.TabIndex = 12;
            // 
            // dgImpares
            // 
            this.dgImpares.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgImpares.Location = new System.Drawing.Point(341, 192);
            this.dgImpares.Name = "dgImpares";
            this.dgImpares.RowHeadersWidth = 51;
            this.dgImpares.RowTemplate.Height = 24;
            this.dgImpares.Size = new System.Drawing.Size(224, 280);
            this.dgImpares.TabIndex = 13;
            // 
            // dgTablas
            // 
            this.dgTablas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTablas.Location = new System.Drawing.Point(867, 192);
            this.dgTablas.Name = "dgTablas";
            this.dgTablas.RowHeadersWidth = 51;
            this.dgTablas.RowTemplate.Height = 24;
            this.dgTablas.Size = new System.Drawing.Size(231, 280);
            this.dgTablas.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(878, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Tablas de Números";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(353, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Factorial Números Impares";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(64, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "Lista de números enteros";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 613);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgTablas);
            this.Controls.Add(this.dgImpares);
            this.Controls.Add(this.dgNumeros);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEjecutar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgPares);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtHilo);
            this.Controls.Add(this.txtNumeros);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Operaciones con hilos";
            ((System.ComponentModel.ISupportInitialize)(this.dgPares)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgNumeros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgImpares)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgTablas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label5_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumeros;
        private System.Windows.Forms.TextBox txtHilo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.DataGridView dgPares;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnEjecutar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dgNumeros;
        private System.Windows.Forms.DataGridView dgImpares;
        private System.Windows.Forms.DataGridView dgTablas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

