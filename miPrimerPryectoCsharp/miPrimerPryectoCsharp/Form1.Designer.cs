namespace miPrimerPryectoCsharp
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
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblResultadoImpuesto = new System.Windows.Forms.Label();
            this.btnCalcularImpuesto = new System.Windows.Forms.Button();
            this.txtMontoActividad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblResultadoConversion = new System.Windows.Forms.Label();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.cmbUnidadDestino = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbUnidadOrigen = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtValorConvertir = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(-243, 28);
            this.lblResultado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(79, 17);
            this.lblResultado.TabIndex = 23;
            this.lblResultado.Text = "Resultado:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(-170, 1);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(2);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(107, 20);
            this.txtCantidad.TabIndex = 22;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(-243, 0);
            this.lblCantidad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(71, 17);
            this.lblCantidad.TabIndex = 21;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(485, 248);
            this.tabControl1.TabIndex = 24;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblResultadoImpuesto);
            this.tabPage1.Controls.Add(this.btnCalcularImpuesto);
            this.tabPage1.Controls.Add(this.txtMontoActividad);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(477, 222);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Impuesto a actividad economica";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblResultadoImpuesto
            // 
            this.lblResultadoImpuesto.AutoSize = true;
            this.lblResultadoImpuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoImpuesto.Location = new System.Drawing.Point(15, 90);
            this.lblResultadoImpuesto.Name = "lblResultadoImpuesto";
            this.lblResultadoImpuesto.Size = new System.Drawing.Size(144, 16);
            this.lblResultadoImpuesto.TabIndex = 3;
            this.lblResultadoImpuesto.Text = "Impuesto a pagar: $";
            // 
            // btnCalcularImpuesto
            // 
            this.btnCalcularImpuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularImpuesto.Location = new System.Drawing.Point(210, 70);
            this.btnCalcularImpuesto.Name = "btnCalcularImpuesto";
            this.btnCalcularImpuesto.Size = new System.Drawing.Size(94, 57);
            this.btnCalcularImpuesto.TabIndex = 2;
            this.btnCalcularImpuesto.Text = "Calcular impuesto";
            this.btnCalcularImpuesto.UseVisualStyleBackColor = true;
            this.btnCalcularImpuesto.Click += new System.EventHandler(this.btnCalcularImpuesto_Click);
            // 
            // txtMontoActividad
            // 
            this.txtMontoActividad.Location = new System.Drawing.Point(34, 35);
            this.txtMontoActividad.Name = "txtMontoActividad";
            this.txtMontoActividad.Size = new System.Drawing.Size(113, 20);
            this.txtMontoActividad.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Monto de actividad";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblResultadoConversion);
            this.tabPage2.Controls.Add(this.btnConvertir);
            this.tabPage2.Controls.Add(this.cmbUnidadDestino);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.cmbUnidadOrigen);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.txtValorConvertir);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(477, 222);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Conversor de Area";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblResultadoConversion
            // 
            this.lblResultadoConversion.AutoSize = true;
            this.lblResultadoConversion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoConversion.Location = new System.Drawing.Point(65, 186);
            this.lblResultadoConversion.Name = "lblResultadoConversion";
            this.lblResultadoConversion.Size = new System.Drawing.Size(71, 13);
            this.lblResultadoConversion.TabIndex = 7;
            this.lblResultadoConversion.Text = "Respuesta:";
            // 
            // btnConvertir
            // 
            this.btnConvertir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvertir.Location = new System.Drawing.Point(326, 91);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(93, 60);
            this.btnConvertir.TabIndex = 6;
            this.btnConvertir.Text = "Convertir";
            this.btnConvertir.UseVisualStyleBackColor = true;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // cmbUnidadDestino
            // 
            this.cmbUnidadDestino.FormattingEnabled = true;
            this.cmbUnidadDestino.Location = new System.Drawing.Point(127, 138);
            this.cmbUnidadDestino.Name = "cmbUnidadDestino";
            this.cmbUnidadDestino.Size = new System.Drawing.Size(121, 21);
            this.cmbUnidadDestino.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(65, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Convertir";
            // 
            // cmbUnidadOrigen
            // 
            this.cmbUnidadOrigen.FormattingEnabled = true;
            this.cmbUnidadOrigen.Location = new System.Drawing.Point(127, 91);
            this.cmbUnidadOrigen.Name = "cmbUnidadOrigen";
            this.cmbUnidadOrigen.Size = new System.Drawing.Size(121, 21);
            this.cmbUnidadOrigen.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(65, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Desde";
            // 
            // txtValorConvertir
            // 
            this.txtValorConvertir.Location = new System.Drawing.Point(127, 33);
            this.txtValorConvertir.Name = "txtValorConvertir";
            this.txtValorConvertir.Size = new System.Drawing.Size(121, 20);
            this.txtValorConvertir.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(65, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Valor";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 441);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.lblCantidad);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lblResultadoImpuesto;
        private System.Windows.Forms.Button btnCalcularImpuesto;
        private System.Windows.Forms.TextBox txtMontoActividad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblResultadoConversion;
        private System.Windows.Forms.Button btnConvertir;
        private System.Windows.Forms.ComboBox cmbUnidadDestino;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbUnidadOrigen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtValorConvertir;
        private System.Windows.Forms.Label label2;
    }
}

