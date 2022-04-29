
namespace Clases_asignada
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
            this.btnagegar = new System.Windows.Forms.Button();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.txtclasificacion = new System.Windows.Forms.TextBox();
            this.txtcolor = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Tipo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Descripcion = new System.Windows.Forms.Label();
            this.listmostrar = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnagegar
            // 
            this.btnagegar.Location = new System.Drawing.Point(666, 265);
            this.btnagegar.Name = "btnagegar";
            this.btnagegar.Size = new System.Drawing.Size(104, 52);
            this.btnagegar.TabIndex = 1;
            this.btnagegar.Text = "Agregar";
            this.btnagegar.UseVisualStyleBackColor = true;
            this.btnagegar.Click += new System.EventHandler(this.btnagegar_Click);
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.Location = new System.Drawing.Point(11, 133);
            this.txtdescripcion.Multiline = true;
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(165, 31);
            this.txtdescripcion.TabIndex = 3;
            // 
            // txtclasificacion
            // 
            this.txtclasificacion.Location = new System.Drawing.Point(211, 47);
            this.txtclasificacion.Multiline = true;
            this.txtclasificacion.Name = "txtclasificacion";
            this.txtclasificacion.Size = new System.Drawing.Size(136, 31);
            this.txtclasificacion.TabIndex = 6;
            // 
            // txtcolor
            // 
            this.txtcolor.Location = new System.Drawing.Point(224, 133);
            this.txtcolor.Multiline = true;
            this.txtcolor.Name = "txtcolor";
            this.txtcolor.Size = new System.Drawing.Size(136, 31);
            this.txtcolor.TabIndex = 7;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(11, 47);
            this.txtnombre.Multiline = true;
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(136, 31);
            this.txtnombre.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nombre";
            // 
            // Tipo
            // 
            this.Tipo.AutoSize = true;
            this.Tipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tipo.Location = new System.Drawing.Point(224, 24);
            this.Tipo.Name = "Tipo";
            this.Tipo.Size = new System.Drawing.Size(110, 20);
            this.Tipo.TabIndex = 10;
            this.Tipo.Text = "Clasificacion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(268, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Color";
            // 
            // Descripcion
            // 
            this.Descripcion.AutoSize = true;
            this.Descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Descripcion.Location = new System.Drawing.Point(44, 110);
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Size = new System.Drawing.Size(103, 20);
            this.Descripcion.TabIndex = 11;
            this.Descripcion.Text = "Descripcion";
            // 
            // listmostrar
            // 
            this.listmostrar.FormattingEnabled = true;
            this.listmostrar.Location = new System.Drawing.Point(59, 199);
            this.listmostrar.Name = "listmostrar";
            this.listmostrar.Size = new System.Drawing.Size(466, 186);
            this.listmostrar.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 462);
            this.Controls.Add(this.listmostrar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Descripcion);
            this.Controls.Add(this.Tipo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.txtcolor);
            this.Controls.Add(this.txtclasificacion);
            this.Controls.Add(this.txtdescripcion);
            this.Controls.Add(this.btnagegar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnagegar;
        private System.Windows.Forms.TextBox txtdescripcion;
        private System.Windows.Forms.TextBox txtclasificacion;
        private System.Windows.Forms.TextBox txtcolor;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Tipo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Descripcion;
        private System.Windows.Forms.ListBox listmostrar;
    }
}

