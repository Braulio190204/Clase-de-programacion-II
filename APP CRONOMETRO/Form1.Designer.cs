
namespace APP_CRONOMETRO
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.miliseg = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.segundo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.minuto = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.horas = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btniniciar = new System.Windows.Forms.Button();
            this.btndetener = new System.Windows.Forms.Button();
            this.btnreiniciar = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.tiempo = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, -21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 130);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(262, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "CRONOMETRO";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.miliseg);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.segundo);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.minuto);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.horas);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(74, 115);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(577, 119);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TIEMPO";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(223, 64);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 20);
            this.label12.TabIndex = 13;
            this.label12.Text = "MILISEG";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(150, 64);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 20);
            this.label11.TabIndex = 12;
            this.label11.Text = "SEGS";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(77, 64);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 20);
            this.label10.TabIndex = 11;
            this.label10.Text = "MINS";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 20);
            this.label9.TabIndex = 10;
            this.label9.Text = "HRAS";
            // 
            // miliseg
            // 
            this.miliseg.AutoSize = true;
            this.miliseg.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.miliseg.Location = new System.Drawing.Point(220, 27);
            this.miliseg.Name = "miliseg";
            this.miliseg.Size = new System.Drawing.Size(53, 37);
            this.miliseg.TabIndex = 9;
            this.miliseg.Text = "00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(200, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 37);
            this.label7.TabIndex = 8;
            this.label7.Text = ":";
            // 
            // segundo
            // 
            this.segundo.AutoSize = true;
            this.segundo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.segundo.Location = new System.Drawing.Point(152, 27);
            this.segundo.Name = "segundo";
            this.segundo.Size = new System.Drawing.Size(53, 37);
            this.segundo.TabIndex = 7;
            this.segundo.Text = "00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(129, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 37);
            this.label5.TabIndex = 6;
            this.label5.Text = ":";
            // 
            // minuto
            // 
            this.minuto.AutoSize = true;
            this.minuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minuto.Location = new System.Drawing.Point(79, 27);
            this.minuto.Name = "minuto";
            this.minuto.Size = new System.Drawing.Size(53, 37);
            this.minuto.TabIndex = 5;
            this.minuto.Text = "00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 37);
            this.label3.TabIndex = 4;
            this.label3.Text = ":";
            // 
            // horas
            // 
            this.horas.AutoSize = true;
            this.horas.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.horas.Location = new System.Drawing.Point(6, 27);
            this.horas.Name = "horas";
            this.horas.Size = new System.Drawing.Size(53, 37);
            this.horas.TabIndex = 4;
            this.horas.Text = "00";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnreiniciar);
            this.groupBox2.Controls.Add(this.btndetener);
            this.groupBox2.Controls.Add(this.btniniciar);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(74, 269);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(577, 119);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CONTROLES";
            // 
            // btniniciar
            // 
            this.btniniciar.Location = new System.Drawing.Point(13, 30);
            this.btniniciar.Name = "btniniciar";
            this.btniniciar.Size = new System.Drawing.Size(113, 52);
            this.btniniciar.TabIndex = 0;
            this.btniniciar.Text = "INICIAR";
            this.btniniciar.UseVisualStyleBackColor = true;
            this.btniniciar.Click += new System.EventHandler(this.btniniciar_Click);
            // 
            // btndetener
            // 
            this.btndetener.Location = new System.Drawing.Point(139, 30);
            this.btndetener.Name = "btndetener";
            this.btndetener.Size = new System.Drawing.Size(134, 52);
            this.btndetener.TabIndex = 1;
            this.btndetener.Text = "DETENER";
            this.btndetener.UseVisualStyleBackColor = true;
            this.btndetener.Click += new System.EventHandler(this.btndetener_Click);
            // 
            // btnreiniciar
            // 
            this.btnreiniciar.Location = new System.Drawing.Point(288, 30);
            this.btnreiniciar.Name = "btnreiniciar";
            this.btnreiniciar.Size = new System.Drawing.Size(139, 52);
            this.btnreiniciar.TabIndex = 4;
            this.btnreiniciar.Text = "REINICIAR";
            this.btnreiniciar.UseVisualStyleBackColor = true;
            this.btnreiniciar.Click += new System.EventHandler(this.btnreiniciar_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalir.Location = new System.Drawing.Point(550, 394);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(101, 33);
            this.btnsalir.TabIndex = 4;
            this.btnsalir.Text = "SALIR";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // tiempo
            // 
            this.tiempo.Interval = 10;
            this.tiempo.Tick += new System.EventHandler(this.tiempo_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label miliseg;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label segundo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label minuto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label horas;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btniniciar;
        private System.Windows.Forms.Button btnreiniciar;
        private System.Windows.Forms.Button btndetener;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Timer tiempo;
    }
}

