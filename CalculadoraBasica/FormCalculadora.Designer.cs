namespace CalculadoraBasica
{
    partial class FormCalculadora
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
            this.tbCajaResultado = new System.Windows.Forms.TextBox();
            this.lblHistorial = new System.Windows.Forms.Label();
            this.btnN7 = new System.Windows.Forms.Button();
            this.btnN8 = new System.Windows.Forms.Button();
            this.btnN9 = new System.Windows.Forms.Button();
            this.btnN6 = new System.Windows.Forms.Button();
            this.btnN5 = new System.Windows.Forms.Button();
            this.btnN4 = new System.Windows.Forms.Button();
            this.btnN3 = new System.Windows.Forms.Button();
            this.btnN2 = new System.Windows.Forms.Button();
            this.btnN1 = new System.Windows.Forms.Button();
            this.btnN0 = new System.Windows.Forms.Button();
            this.btnMultiplicacion = new System.Windows.Forms.Button();
            this.btnResta = new System.Windows.Forms.Button();
            this.btnSumar = new System.Windows.Forms.Button();
            this.btnPunto = new System.Windows.Forms.Button();
            this.btnResultado = new System.Windows.Forms.Button();
            this.btnModulo = new System.Windows.Forms.Button();
            this.btnDivision = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnBorrar = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // tbCajaResultado
            // 
            this.tbCajaResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCajaResultado.Location = new System.Drawing.Point(32, 72);
            this.tbCajaResultado.Name = "tbCajaResultado";
            this.tbCajaResultado.ReadOnly = true;
            this.tbCajaResultado.Size = new System.Drawing.Size(410, 38);
            this.tbCajaResultado.TabIndex = 0;
            this.tbCajaResultado.Text = "0";
            this.tbCajaResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblHistorial
            // 
            this.lblHistorial.AutoSize = true;
            this.lblHistorial.Location = new System.Drawing.Point(38, 36);
            this.lblHistorial.Name = "lblHistorial";
            this.lblHistorial.Size = new System.Drawing.Size(11, 16);
            this.lblHistorial.TabIndex = 1;
            this.lblHistorial.Text = "-";
            // 
            // btnN7
            // 
            this.btnN7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnN7.Location = new System.Drawing.Point(32, 227);
            this.btnN7.Name = "btnN7";
            this.btnN7.Size = new System.Drawing.Size(98, 75);
            this.btnN7.TabIndex = 2;
            this.btnN7.Text = "7";
            this.btnN7.UseVisualStyleBackColor = true;
            this.btnN7.Click += new System.EventHandler(this.btnN7_Click);
            // 
            // btnN8
            // 
            this.btnN8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnN8.Location = new System.Drawing.Point(136, 227);
            this.btnN8.Name = "btnN8";
            this.btnN8.Size = new System.Drawing.Size(98, 75);
            this.btnN8.TabIndex = 3;
            this.btnN8.Text = "8";
            this.btnN8.UseVisualStyleBackColor = true;
            this.btnN8.Click += new System.EventHandler(this.btnN8_Click);
            // 
            // btnN9
            // 
            this.btnN9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnN9.Location = new System.Drawing.Point(240, 227);
            this.btnN9.Name = "btnN9";
            this.btnN9.Size = new System.Drawing.Size(98, 75);
            this.btnN9.TabIndex = 4;
            this.btnN9.Text = "9";
            this.btnN9.UseVisualStyleBackColor = true;
            this.btnN9.Click += new System.EventHandler(this.btnN9_Click);
            // 
            // btnN6
            // 
            this.btnN6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnN6.Location = new System.Drawing.Point(240, 319);
            this.btnN6.Name = "btnN6";
            this.btnN6.Size = new System.Drawing.Size(98, 75);
            this.btnN6.TabIndex = 7;
            this.btnN6.Text = "6";
            this.btnN6.UseVisualStyleBackColor = true;
            this.btnN6.Click += new System.EventHandler(this.btnN6_Click);
            // 
            // btnN5
            // 
            this.btnN5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnN5.Location = new System.Drawing.Point(136, 319);
            this.btnN5.Name = "btnN5";
            this.btnN5.Size = new System.Drawing.Size(98, 75);
            this.btnN5.TabIndex = 6;
            this.btnN5.Text = "5";
            this.btnN5.UseVisualStyleBackColor = true;
            this.btnN5.Click += new System.EventHandler(this.btnN5_Click);
            // 
            // btnN4
            // 
            this.btnN4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnN4.Location = new System.Drawing.Point(32, 319);
            this.btnN4.Name = "btnN4";
            this.btnN4.Size = new System.Drawing.Size(98, 75);
            this.btnN4.TabIndex = 5;
            this.btnN4.Text = "4";
            this.btnN4.UseVisualStyleBackColor = true;
            this.btnN4.Click += new System.EventHandler(this.btnN4_Click);
            // 
            // btnN3
            // 
            this.btnN3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnN3.Location = new System.Drawing.Point(240, 409);
            this.btnN3.Name = "btnN3";
            this.btnN3.Size = new System.Drawing.Size(98, 75);
            this.btnN3.TabIndex = 10;
            this.btnN3.Text = "3";
            this.btnN3.UseVisualStyleBackColor = true;
            this.btnN3.Click += new System.EventHandler(this.btnN3_Click);
            // 
            // btnN2
            // 
            this.btnN2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnN2.Location = new System.Drawing.Point(136, 409);
            this.btnN2.Name = "btnN2";
            this.btnN2.Size = new System.Drawing.Size(98, 75);
            this.btnN2.TabIndex = 9;
            this.btnN2.Text = "2";
            this.btnN2.UseVisualStyleBackColor = true;
            this.btnN2.Click += new System.EventHandler(this.btnN2_Click);
            // 
            // btnN1
            // 
            this.btnN1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnN1.Location = new System.Drawing.Point(32, 409);
            this.btnN1.Name = "btnN1";
            this.btnN1.Size = new System.Drawing.Size(98, 75);
            this.btnN1.TabIndex = 8;
            this.btnN1.Text = "1";
            this.btnN1.UseVisualStyleBackColor = true;
            this.btnN1.Click += new System.EventHandler(this.btnN1_Click);
            // 
            // btnN0
            // 
            this.btnN0.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnN0.Location = new System.Drawing.Point(32, 499);
            this.btnN0.Name = "btnN0";
            this.btnN0.Size = new System.Drawing.Size(202, 70);
            this.btnN0.TabIndex = 11;
            this.btnN0.Text = "0";
            this.btnN0.UseVisualStyleBackColor = true;
            this.btnN0.Click += new System.EventHandler(this.btnN0_Click);
            // 
            // btnMultiplicacion
            // 
            this.btnMultiplicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiplicacion.Location = new System.Drawing.Point(344, 227);
            this.btnMultiplicacion.Name = "btnMultiplicacion";
            this.btnMultiplicacion.Size = new System.Drawing.Size(98, 75);
            this.btnMultiplicacion.TabIndex = 12;
            this.btnMultiplicacion.Text = "X";
            this.btnMultiplicacion.UseVisualStyleBackColor = true;
            this.btnMultiplicacion.Click += new System.EventHandler(this.btnMultiplicacion_Click);
            // 
            // btnResta
            // 
            this.btnResta.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResta.Location = new System.Drawing.Point(344, 319);
            this.btnResta.Name = "btnResta";
            this.btnResta.Size = new System.Drawing.Size(98, 75);
            this.btnResta.TabIndex = 13;
            this.btnResta.Text = "-";
            this.btnResta.UseVisualStyleBackColor = true;
            this.btnResta.Click += new System.EventHandler(this.btnResta_Click);
            // 
            // btnSumar
            // 
            this.btnSumar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSumar.Location = new System.Drawing.Point(344, 409);
            this.btnSumar.Name = "btnSumar";
            this.btnSumar.Size = new System.Drawing.Size(98, 75);
            this.btnSumar.TabIndex = 14;
            this.btnSumar.Text = "+";
            this.btnSumar.UseVisualStyleBackColor = true;
            this.btnSumar.Click += new System.EventHandler(this.btnSumar_Click);
            // 
            // btnPunto
            // 
            this.btnPunto.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPunto.Location = new System.Drawing.Point(240, 499);
            this.btnPunto.Name = "btnPunto";
            this.btnPunto.Size = new System.Drawing.Size(98, 70);
            this.btnPunto.TabIndex = 15;
            this.btnPunto.Text = ".";
            this.btnPunto.UseVisualStyleBackColor = true;
            this.btnPunto.Click += new System.EventHandler(this.btnPunto_Click);
            // 
            // btnResultado
            // 
            this.btnResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResultado.Location = new System.Drawing.Point(344, 499);
            this.btnResultado.Name = "btnResultado";
            this.btnResultado.Size = new System.Drawing.Size(98, 70);
            this.btnResultado.TabIndex = 16;
            this.btnResultado.Text = "=";
            this.btnResultado.UseVisualStyleBackColor = true;
            this.btnResultado.Click += new System.EventHandler(this.btnResultado_Click);
            // 
            // btnModulo
            // 
            this.btnModulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModulo.Location = new System.Drawing.Point(32, 136);
            this.btnModulo.Name = "btnModulo";
            this.btnModulo.Size = new System.Drawing.Size(98, 75);
            this.btnModulo.TabIndex = 17;
            this.btnModulo.Text = "%";
            this.btnModulo.UseVisualStyleBackColor = true;
            this.btnModulo.Click += new System.EventHandler(this.btnModulo_Click);
            // 
            // btnDivision
            // 
            this.btnDivision.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivision.Location = new System.Drawing.Point(136, 136);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(98, 75);
            this.btnDivision.TabIndex = 18;
            this.btnDivision.Text = "/";
            this.btnDivision.UseVisualStyleBackColor = true;
            this.btnDivision.Click += new System.EventHandler(this.btnDivision_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(240, 136);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(98, 75);
            this.btnReset.TabIndex = 19;
            this.btnReset.Text = "C";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.IconChar = FontAwesome.Sharp.IconChar.Backspace;
            this.btnBorrar.IconColor = System.Drawing.Color.Black;
            this.btnBorrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBorrar.Location = new System.Drawing.Point(344, 136);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(98, 75);
            this.btnBorrar.TabIndex = 21;
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // FormCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 592);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnDivision);
            this.Controls.Add(this.btnModulo);
            this.Controls.Add(this.btnResultado);
            this.Controls.Add(this.btnPunto);
            this.Controls.Add(this.btnSumar);
            this.Controls.Add(this.btnResta);
            this.Controls.Add(this.btnMultiplicacion);
            this.Controls.Add(this.btnN0);
            this.Controls.Add(this.btnN3);
            this.Controls.Add(this.btnN2);
            this.Controls.Add(this.btnN1);
            this.Controls.Add(this.btnN6);
            this.Controls.Add(this.btnN5);
            this.Controls.Add(this.btnN4);
            this.Controls.Add(this.btnN9);
            this.Controls.Add(this.btnN8);
            this.Controls.Add(this.btnN7);
            this.Controls.Add(this.lblHistorial);
            this.Controls.Add(this.tbCajaResultado);
            this.Name = "FormCalculadora";
            this.Text = "Calculadora 7u7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbCajaResultado;
        private System.Windows.Forms.Label lblHistorial;
        private System.Windows.Forms.Button btnN7;
        private System.Windows.Forms.Button btnN8;
        private System.Windows.Forms.Button btnN9;
        private System.Windows.Forms.Button btnN6;
        private System.Windows.Forms.Button btnN5;
        private System.Windows.Forms.Button btnN4;
        private System.Windows.Forms.Button btnN3;
        private System.Windows.Forms.Button btnN2;
        private System.Windows.Forms.Button btnN1;
        private System.Windows.Forms.Button btnN0;
        private System.Windows.Forms.Button btnMultiplicacion;
        private System.Windows.Forms.Button btnResta;
        private System.Windows.Forms.Button btnSumar;
        private System.Windows.Forms.Button btnPunto;
        private System.Windows.Forms.Button btnResultado;
        private System.Windows.Forms.Button btnModulo;
        private System.Windows.Forms.Button btnDivision;
        private System.Windows.Forms.Button btnReset;
        private FontAwesome.Sharp.IconButton btnBorrar;
    }
}

