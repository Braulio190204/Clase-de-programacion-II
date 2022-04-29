
namespace libros
{
    partial class BusgarPrestamo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BusgarPrestamo));
            this.label = new System.Windows.Forms.Label();
            this.txtmatricula = new System.Windows.Forms.TextBox();
            this.dgvprestamo = new System.Windows.Forms.DataGridView();
            this.btnbusgar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvprestamo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(291, 59);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(76, 17);
            this.label.TabIndex = 0;
            this.label.Text = "Matricula:";
            // 
            // txtmatricula
            // 
            this.txtmatricula.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmatricula.Location = new System.Drawing.Point(373, 58);
            this.txtmatricula.Multiline = true;
            this.txtmatricula.Name = "txtmatricula";
            this.txtmatricula.Size = new System.Drawing.Size(121, 20);
            this.txtmatricula.TabIndex = 1;
            // 
            // dgvprestamo
            // 
            this.dgvprestamo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvprestamo.Location = new System.Drawing.Point(12, 124);
            this.dgvprestamo.Name = "dgvprestamo";
            this.dgvprestamo.Size = new System.Drawing.Size(914, 357);
            this.dgvprestamo.TabIndex = 3;
            // 
            // btnbusgar
            // 
            this.btnbusgar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnbusgar.BackgroundImage")));
            this.btnbusgar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnbusgar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbusgar.ForeColor = System.Drawing.Color.White;
            this.btnbusgar.Location = new System.Drawing.Point(547, 50);
            this.btnbusgar.Name = "btnbusgar";
            this.btnbusgar.Size = new System.Drawing.Size(92, 34);
            this.btnbusgar.TabIndex = 2;
            this.btnbusgar.Text = "Busgar";
            this.btnbusgar.UseVisualStyleBackColor = true;
            this.btnbusgar.Click += new System.EventHandler(this.btnbusgar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btneliminar.BackgroundImage")));
            this.btneliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btneliminar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneliminar.ForeColor = System.Drawing.Color.White;
            this.btneliminar.Location = new System.Drawing.Point(759, 86);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(75, 32);
            this.btneliminar.TabIndex = 4;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 28);
            this.button1.TabIndex = 5;
            this.button1.Text = "Inicio";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // BusgarPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(938, 493);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.dgvprestamo);
            this.Controls.Add(this.btnbusgar);
            this.Controls.Add(this.txtmatricula);
            this.Controls.Add(this.label);
            this.Name = "BusgarPrestamo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BusgarPrestamo";
            ((System.ComponentModel.ISupportInitialize)(this.dgvprestamo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox txtmatricula;
        private System.Windows.Forms.Button btnbusgar;
        private System.Windows.Forms.DataGridView dgvprestamo;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}