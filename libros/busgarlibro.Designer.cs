
namespace libros
{
    partial class formbusgarlibro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formbusgarlibro));
            this.txttitulo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbcategoria = new System.Windows.Forms.ComboBox();
            this.txtautor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvlibro = new System.Windows.Forms.DataGridView();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnbusgar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvlibro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txttitulo
            // 
            this.txttitulo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttitulo.Location = new System.Drawing.Point(97, 53);
            this.txttitulo.Multiline = true;
            this.txttitulo.Name = "txttitulo";
            this.txttitulo.Size = new System.Drawing.Size(195, 22);
            this.txttitulo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Titulo:";
            // 
            // cbcategoria
            // 
            this.cbcategoria.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbcategoria.FormattingEnabled = true;
            this.cbcategoria.Location = new System.Drawing.Point(668, 54);
            this.cbcategoria.Name = "cbcategoria";
            this.cbcategoria.Size = new System.Drawing.Size(185, 27);
            this.cbcategoria.TabIndex = 2;
            this.cbcategoria.Text = "Categoria";
            // 
            // txtautor
            // 
            this.txtautor.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtautor.Location = new System.Drawing.Point(387, 53);
            this.txtautor.Multiline = true;
            this.txtautor.Name = "txtautor";
            this.txtautor.Size = new System.Drawing.Size(176, 22);
            this.txtautor.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(313, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Autor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(582, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Categoria:";
            // 
            // dgvlibro
            // 
            this.dgvlibro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvlibro.Location = new System.Drawing.Point(7, 156);
            this.dgvlibro.Name = "dgvlibro";
            this.dgvlibro.Size = new System.Drawing.Size(862, 307);
            this.dgvlibro.TabIndex = 7;
            // 
            // btneliminar
            // 
            this.btneliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btneliminar.BackgroundImage")));
            this.btneliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btneliminar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneliminar.ForeColor = System.Drawing.Color.White;
            this.btneliminar.Location = new System.Drawing.Point(668, 124);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(75, 28);
            this.btneliminar.TabIndex = 8;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Visible = false;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnbusgar
            // 
            this.btnbusgar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnbusgar.BackgroundImage")));
            this.btnbusgar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnbusgar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbusgar.ForeColor = System.Drawing.Color.White;
            this.btnbusgar.Location = new System.Drawing.Point(778, 87);
            this.btnbusgar.Name = "btnbusgar";
            this.btnbusgar.Size = new System.Drawing.Size(75, 28);
            this.btnbusgar.TabIndex = 3;
            this.btnbusgar.Text = "Buscar";
            this.btnbusgar.UseVisualStyleBackColor = true;
            this.btnbusgar.Click += new System.EventHandler(this.btnbusgar_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(8, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 28);
            this.button1.TabIndex = 9;
            this.button1.Text = "Inicio";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // formbusgarlibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(877, 473);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.dgvlibro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtautor);
            this.Controls.Add(this.btnbusgar);
            this.Controls.Add(this.cbcategoria);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txttitulo);
            this.Name = "formbusgarlibro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "busgarlibro";
            ((System.ComponentModel.ISupportInitialize)(this.dgvlibro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txttitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbcategoria;
        private System.Windows.Forms.Button btnbusgar;
        private System.Windows.Forms.TextBox txtautor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvlibro;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}