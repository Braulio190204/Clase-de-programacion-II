
namespace capturar_errores
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
            this.button1 = new System.Windows.Forms.Button();
            this.Numerador = new System.Windows.Forms.TextBox();
            this.Denominador = new System.Windows.Forms.TextBox();
            this.Salida = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Escriba el numerodor";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Escriba el denominador";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 116);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 33);
            this.button1.TabIndex = 2;
            this.button1.Text = "Haga clic para dividir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Numerador
            // 
            this.Numerador.Location = new System.Drawing.Point(155, 20);
            this.Numerador.Name = "Numerador";
            this.Numerador.Size = new System.Drawing.Size(91, 20);
            this.Numerador.TabIndex = 3;
            this.Numerador.TextChanged += new System.EventHandler(this.Numerador_TextChanged);
            // 
            // Denominador
            // 
            this.Denominador.Location = new System.Drawing.Point(155, 74);
            this.Denominador.Name = "Denominador";
            this.Denominador.Size = new System.Drawing.Size(91, 20);
            this.Denominador.TabIndex = 4;
            this.Denominador.TextChanged += new System.EventHandler(this.Denominador_TextChanged);
            // 
            // Salida
            // 
            this.Salida.Location = new System.Drawing.Point(155, 123);
            this.Salida.Name = "Salida";
            this.Salida.Size = new System.Drawing.Size(91, 20);
            this.Salida.TabIndex = 5;
            this.Salida.TextChanged += new System.EventHandler(this.Salida_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 173);
            this.Controls.Add(this.Salida);
            this.Controls.Add(this.Denominador);
            this.Controls.Add(this.Numerador);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Numerador;
        private System.Windows.Forms.TextBox Denominador;
        private System.Windows.Forms.TextBox Salida;
    }
}

