
namespace agrergar_y_quitar_elemento
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
            this.mostrarListBox = new System.Windows.Forms.ListBox();
            this.agrergarButton = new System.Windows.Forms.Button();
            this.quitarButton = new System.Windows.Forms.Button();
            this.borrarButton = new System.Windows.Forms.Button();
            this.salirButton = new System.Windows.Forms.Button();
            this.entradaTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // mostrarListBox
            // 
            this.mostrarListBox.FormattingEnabled = true;
            this.mostrarListBox.Location = new System.Drawing.Point(12, 43);
            this.mostrarListBox.Name = "mostrarListBox";
            this.mostrarListBox.Size = new System.Drawing.Size(174, 212);
            this.mostrarListBox.TabIndex = 0;
            // 
            // agrergarButton
            // 
            this.agrergarButton.Location = new System.Drawing.Point(222, 53);
            this.agrergarButton.Name = "agrergarButton";
            this.agrergarButton.Size = new System.Drawing.Size(75, 23);
            this.agrergarButton.TabIndex = 1;
            this.agrergarButton.Text = "Agregar";
            this.agrergarButton.UseVisualStyleBackColor = true;
            this.agrergarButton.Click += new System.EventHandler(this.agrergarButton_Click);
            // 
            // quitarButton
            // 
            this.quitarButton.Location = new System.Drawing.Point(222, 99);
            this.quitarButton.Name = "quitarButton";
            this.quitarButton.Size = new System.Drawing.Size(75, 23);
            this.quitarButton.TabIndex = 2;
            this.quitarButton.Text = "Quitar";
            this.quitarButton.UseVisualStyleBackColor = true;
            this.quitarButton.Click += new System.EventHandler(this.quitarButton_Click);
            // 
            // borrarButton
            // 
            this.borrarButton.Location = new System.Drawing.Point(222, 144);
            this.borrarButton.Name = "borrarButton";
            this.borrarButton.Size = new System.Drawing.Size(75, 23);
            this.borrarButton.TabIndex = 3;
            this.borrarButton.Text = "Borrar";
            this.borrarButton.UseVisualStyleBackColor = true;
            this.borrarButton.Click += new System.EventHandler(this.borrarButton_Click);
            // 
            // salirButton
            // 
            this.salirButton.Location = new System.Drawing.Point(222, 193);
            this.salirButton.Name = "salirButton";
            this.salirButton.Size = new System.Drawing.Size(75, 23);
            this.salirButton.TabIndex = 4;
            this.salirButton.Text = "Salir";
            this.salirButton.UseVisualStyleBackColor = true;
            this.salirButton.Click += new System.EventHandler(this.salirButton_Click);
            // 
            // entradaTextBox
            // 
            this.entradaTextBox.Location = new System.Drawing.Point(12, 12);
            this.entradaTextBox.Multiline = true;
            this.entradaTextBox.Name = "entradaTextBox";
            this.entradaTextBox.Size = new System.Drawing.Size(174, 25);
            this.entradaTextBox.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 332);
            this.Controls.Add(this.entradaTextBox);
            this.Controls.Add(this.salirButton);
            this.Controls.Add(this.borrarButton);
            this.Controls.Add(this.quitarButton);
            this.Controls.Add(this.agrergarButton);
            this.Controls.Add(this.mostrarListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox mostrarListBox;
        private System.Windows.Forms.Button agrergarButton;
        private System.Windows.Forms.Button quitarButton;
        private System.Windows.Forms.Button borrarButton;
        private System.Windows.Forms.Button salirButton;
        private System.Windows.Forms.TextBox entradaTextBox;
    }
}

