
namespace checkbox
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
            this.salidaLabel = new System.Windows.Forms.Label();
            this.negritaCheackbox = new System.Windows.Forms.CheckBox();
            this.cursivaCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // salidaLabel
            // 
            this.salidaLabel.AutoSize = true;
            this.salidaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salidaLabel.Location = new System.Drawing.Point(126, 62);
            this.salidaLabel.Name = "salidaLabel";
            this.salidaLabel.Size = new System.Drawing.Size(425, 25);
            this.salidaLabel.TabIndex = 0;
            this.salidaLabel.Text = "Observe como cambia el estilo de la fuente";
            // 
            // negritaCheackbox
            // 
            this.negritaCheackbox.AutoSize = true;
            this.negritaCheackbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.negritaCheackbox.Location = new System.Drawing.Point(131, 148);
            this.negritaCheackbox.Name = "negritaCheackbox";
            this.negritaCheackbox.Size = new System.Drawing.Size(89, 28);
            this.negritaCheackbox.TabIndex = 1;
            this.negritaCheackbox.Text = "Negrita";
            this.negritaCheackbox.UseVisualStyleBackColor = true;
            this.negritaCheackbox.CheckedChanged += new System.EventHandler(this.negritaCheackbox_CheckedChanged);
            // 
            // cursivaCheckBox
            // 
            this.cursivaCheckBox.AutoSize = true;
            this.cursivaCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cursivaCheckBox.Location = new System.Drawing.Point(353, 148);
            this.cursivaCheckBox.Name = "cursivaCheckBox";
            this.cursivaCheckBox.Size = new System.Drawing.Size(91, 28);
            this.cursivaCheckBox.TabIndex = 2;
            this.cursivaCheckBox.Text = "Cursiva";
            this.cursivaCheckBox.UseVisualStyleBackColor = true;
            this.cursivaCheckBox.CheckedChanged += new System.EventHandler(this.cursivaCheckBox_CheckedChanged_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cursivaCheckBox);
            this.Controls.Add(this.negritaCheackbox);
            this.Controls.Add(this.salidaLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label salidaLabel;
        private System.Windows.Forms.CheckBox negritaCheackbox;
        private System.Windows.Forms.CheckBox cursivaCheckBox;
    }
}

