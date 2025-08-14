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
            this.btnCalcularopciones = new System.Windows.Forms.Button();
            this.cboOpciones = new System.Windows.Forms.ComboBox();
            this.gbOpciones = new System.Windows.Forms.GroupBox();
            this.optPorcentaje = new System.Windows.Forms.RadioButton();
            this.optExponente = new System.Windows.Forms.RadioButton();
            this.optDivision = new System.Windows.Forms.RadioButton();
            this.optMultiplicacion = new System.Windows.Forms.RadioButton();
            this.optResta = new System.Windows.Forms.RadioButton();
            this.optSuma = new System.Windows.Forms.RadioButton();
            this.lblrespuesta = new System.Windows.Forms.Label();
            this.txtnum2 = new System.Windows.Forms.TextBox();
            this.lblnum2 = new System.Windows.Forms.Label();
            this.btncantidad = new System.Windows.Forms.Button();
            this.txtnum1 = new System.Windows.Forms.TextBox();
            this.lblnum1 = new System.Windows.Forms.Label();
            this.gbOpciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCalcularopciones
            // 
            this.btnCalcularopciones.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularopciones.Location = new System.Drawing.Point(430, 127);
            this.btnCalcularopciones.Margin = new System.Windows.Forms.Padding(2);
            this.btnCalcularopciones.Name = "btnCalcularopciones";
            this.btnCalcularopciones.Size = new System.Drawing.Size(80, 29);
            this.btnCalcularopciones.TabIndex = 17;
            this.btnCalcularopciones.Text = "Calcular";
            this.btnCalcularopciones.UseVisualStyleBackColor = true;
            this.btnCalcularopciones.Click += new System.EventHandler(this.btnCalcularopciones_Click);
            // 
            // cboOpciones
            // 
            this.cboOpciones.FormattingEnabled = true;
            this.cboOpciones.Items.AddRange(new object[] {
            "Suma",
            "Resta",
            "Multiplicacion",
            "Divicion",
            "Exponente",
            "Porcentaje"});
            this.cboOpciones.Location = new System.Drawing.Point(429, 86);
            this.cboOpciones.Margin = new System.Windows.Forms.Padding(2);
            this.cboOpciones.Name = "cboOpciones";
            this.cboOpciones.Size = new System.Drawing.Size(82, 21);
            this.cboOpciones.TabIndex = 16;
            // 
            // gbOpciones
            // 
            this.gbOpciones.Controls.Add(this.optPorcentaje);
            this.gbOpciones.Controls.Add(this.optExponente);
            this.gbOpciones.Controls.Add(this.optDivision);
            this.gbOpciones.Controls.Add(this.optMultiplicacion);
            this.gbOpciones.Controls.Add(this.optResta);
            this.gbOpciones.Controls.Add(this.optSuma);
            this.gbOpciones.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOpciones.Location = new System.Drawing.Point(266, 77);
            this.gbOpciones.Margin = new System.Windows.Forms.Padding(2);
            this.gbOpciones.Name = "gbOpciones";
            this.gbOpciones.Padding = new System.Windows.Forms.Padding(2);
            this.gbOpciones.Size = new System.Drawing.Size(131, 160);
            this.gbOpciones.TabIndex = 15;
            this.gbOpciones.TabStop = false;
            this.gbOpciones.Text = "Opciones";
            // 
            // optPorcentaje
            // 
            this.optPorcentaje.AutoSize = true;
            this.optPorcentaje.Location = new System.Drawing.Point(12, 126);
            this.optPorcentaje.Margin = new System.Windows.Forms.Padding(2);
            this.optPorcentaje.Name = "optPorcentaje";
            this.optPorcentaje.Size = new System.Drawing.Size(91, 21);
            this.optPorcentaje.TabIndex = 5;
            this.optPorcentaje.TabStop = true;
            this.optPorcentaje.Text = "Porcentaje";
            this.optPorcentaje.UseVisualStyleBackColor = true;
            // 
            // optExponente
            // 
            this.optExponente.AutoSize = true;
            this.optExponente.Location = new System.Drawing.Point(12, 104);
            this.optExponente.Margin = new System.Windows.Forms.Padding(2);
            this.optExponente.Name = "optExponente";
            this.optExponente.Size = new System.Drawing.Size(90, 21);
            this.optExponente.TabIndex = 4;
            this.optExponente.TabStop = true;
            this.optExponente.Text = "Exponente";
            this.optExponente.UseVisualStyleBackColor = true;
            // 
            // optDivision
            // 
            this.optDivision.AutoSize = true;
            this.optDivision.Location = new System.Drawing.Point(12, 82);
            this.optDivision.Margin = new System.Windows.Forms.Padding(2);
            this.optDivision.Name = "optDivision";
            this.optDivision.Size = new System.Drawing.Size(76, 21);
            this.optDivision.TabIndex = 3;
            this.optDivision.Text = "Division";
            this.optDivision.UseVisualStyleBackColor = true;
            // 
            // optMultiplicacion
            // 
            this.optMultiplicacion.AutoSize = true;
            this.optMultiplicacion.Location = new System.Drawing.Point(12, 62);
            this.optMultiplicacion.Margin = new System.Windows.Forms.Padding(2);
            this.optMultiplicacion.Name = "optMultiplicacion";
            this.optMultiplicacion.Size = new System.Drawing.Size(112, 21);
            this.optMultiplicacion.TabIndex = 2;
            this.optMultiplicacion.Text = "Multiplicacion";
            this.optMultiplicacion.UseVisualStyleBackColor = true;
            // 
            // optResta
            // 
            this.optResta.AutoSize = true;
            this.optResta.Location = new System.Drawing.Point(12, 37);
            this.optResta.Margin = new System.Windows.Forms.Padding(2);
            this.optResta.Name = "optResta";
            this.optResta.Size = new System.Drawing.Size(61, 21);
            this.optResta.TabIndex = 1;
            this.optResta.Text = "Resta";
            this.optResta.UseVisualStyleBackColor = true;
            // 
            // optSuma
            // 
            this.optSuma.AutoSize = true;
            this.optSuma.Checked = true;
            this.optSuma.Location = new System.Drawing.Point(12, 17);
            this.optSuma.Margin = new System.Windows.Forms.Padding(2);
            this.optSuma.Name = "optSuma";
            this.optSuma.Size = new System.Drawing.Size(61, 21);
            this.optSuma.TabIndex = 0;
            this.optSuma.TabStop = true;
            this.optSuma.Text = "Suma";
            this.optSuma.UseVisualStyleBackColor = true;
            // 
            // lblrespuesta
            // 
            this.lblrespuesta.AutoSize = true;
            this.lblrespuesta.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrespuesta.Location = new System.Drawing.Point(48, 121);
            this.lblrespuesta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblrespuesta.Name = "lblrespuesta";
            this.lblrespuesta.Size = new System.Drawing.Size(87, 17);
            this.lblrespuesta.TabIndex = 14;
            this.lblrespuesta.Text = "Respuesta: ?";
            // 
            // txtnum2
            // 
            this.txtnum2.Location = new System.Drawing.Point(96, 94);
            this.txtnum2.Margin = new System.Windows.Forms.Padding(2);
            this.txtnum2.Name = "txtnum2";
            this.txtnum2.Size = new System.Drawing.Size(109, 20);
            this.txtnum2.TabIndex = 13;
            // 
            // lblnum2
            // 
            this.lblnum2.AutoSize = true;
            this.lblnum2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnum2.Location = new System.Drawing.Point(48, 96);
            this.lblnum2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblnum2.Name = "lblnum2";
            this.lblnum2.Size = new System.Drawing.Size(49, 17);
            this.lblnum2.TabIndex = 12;
            this.lblnum2.Text = "Num2:";
            // 
            // btncantidad
            // 
            this.btncantidad.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncantidad.Location = new System.Drawing.Point(78, 151);
            this.btncantidad.Margin = new System.Windows.Forms.Padding(2);
            this.btncantidad.Name = "btncantidad";
            this.btncantidad.Size = new System.Drawing.Size(80, 29);
            this.btncantidad.TabIndex = 11;
            this.btncantidad.Text = "Calcular";
            this.btncantidad.UseVisualStyleBackColor = true;
            this.btncantidad.Click += new System.EventHandler(this.btncantidad_Click);
            // 
            // txtnum1
            // 
            this.txtnum1.Location = new System.Drawing.Point(96, 60);
            this.txtnum1.Margin = new System.Windows.Forms.Padding(2);
            this.txtnum1.Name = "txtnum1";
            this.txtnum1.Size = new System.Drawing.Size(109, 20);
            this.txtnum1.TabIndex = 10;
            // 
            // lblnum1
            // 
            this.lblnum1.AutoSize = true;
            this.lblnum1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnum1.Location = new System.Drawing.Point(48, 60);
            this.lblnum1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblnum1.Name = "lblnum1";
            this.lblnum1.Size = new System.Drawing.Size(49, 17);
            this.lblnum1.TabIndex = 9;
            this.lblnum1.Text = "Num1:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 314);
            this.Controls.Add(this.btnCalcularopciones);
            this.Controls.Add(this.cboOpciones);
            this.Controls.Add(this.gbOpciones);
            this.Controls.Add(this.lblrespuesta);
            this.Controls.Add(this.txtnum2);
            this.Controls.Add(this.lblnum2);
            this.Controls.Add(this.btncantidad);
            this.Controls.Add(this.txtnum1);
            this.Controls.Add(this.lblnum1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbOpciones.ResumeLayout(false);
            this.gbOpciones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcularopciones;
        private System.Windows.Forms.ComboBox cboOpciones;
        private System.Windows.Forms.GroupBox gbOpciones;
        private System.Windows.Forms.RadioButton optPorcentaje;
        private System.Windows.Forms.RadioButton optExponente;
        private System.Windows.Forms.RadioButton optDivision;
        private System.Windows.Forms.RadioButton optMultiplicacion;
        private System.Windows.Forms.RadioButton optResta;
        private System.Windows.Forms.RadioButton optSuma;
        private System.Windows.Forms.Label lblrespuesta;
        private System.Windows.Forms.TextBox txtnum2;
        private System.Windows.Forms.Label lblnum2;
        private System.Windows.Forms.Button btncantidad;
        private System.Windows.Forms.TextBox txtnum1;
        private System.Windows.Forms.Label lblnum1;
    }
}

