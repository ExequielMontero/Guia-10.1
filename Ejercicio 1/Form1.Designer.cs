namespace Ejercicio_1_guia_10
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rbbici = new System.Windows.Forms.RadioButton();
            this.rbmoto = new System.Windows.Forms.RadioButton();
            this.rbauto = new System.Windows.Forms.RadioButton();
            this.rbpublico = new System.Windows.Forms.RadioButton();
            this.bregistrar = new System.Windows.Forms.Button();
            this.tbdistancia = new System.Windows.Forms.TextBox();
            this.bresultados = new System.Windows.Forms.Button();
            this.lbresultados = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bresultados);
            this.groupBox1.Controls.Add(this.bregistrar);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(445, 426);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingresar valores";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbdistancia);
            this.groupBox2.Location = new System.Drawing.Point(29, 214);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(325, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Distancia aproximada segun el vehiculo seleccionado";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbpublico);
            this.groupBox3.Controls.Add(this.rbauto);
            this.groupBox3.Controls.Add(this.rbmoto);
            this.groupBox3.Controls.Add(this.rbbici);
            this.groupBox3.Location = new System.Drawing.Point(29, 30);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(325, 178);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tipo transporte de uso mas frecuente";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lbresultados);
            this.groupBox4.Location = new System.Drawing.Point(6, 320);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(348, 100);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Resultados";
            // 
            // rbbici
            // 
            this.rbbici.AutoSize = true;
            this.rbbici.Location = new System.Drawing.Point(6, 31);
            this.rbbici.Name = "rbbici";
            this.rbbici.Size = new System.Drawing.Size(65, 17);
            this.rbbici.TabIndex = 0;
            this.rbbici.TabStop = true;
            this.rbbici.Text = "Bicicleta";
            this.rbbici.UseVisualStyleBackColor = true;
            // 
            // rbmoto
            // 
            this.rbmoto.AutoSize = true;
            this.rbmoto.Location = new System.Drawing.Point(6, 64);
            this.rbmoto.Name = "rbmoto";
            this.rbmoto.Size = new System.Drawing.Size(80, 17);
            this.rbmoto.TabIndex = 1;
            this.rbmoto.TabStop = true;
            this.rbmoto.Text = "Motocicleta";
            this.rbmoto.UseVisualStyleBackColor = true;
            // 
            // rbauto
            // 
            this.rbauto.AutoSize = true;
            this.rbauto.Location = new System.Drawing.Point(6, 99);
            this.rbauto.Name = "rbauto";
            this.rbauto.Size = new System.Drawing.Size(71, 17);
            this.rbauto.TabIndex = 2;
            this.rbauto.TabStop = true;
            this.rbauto.Text = "Automovil";
            this.rbauto.UseVisualStyleBackColor = true;
            // 
            // rbpublico
            // 
            this.rbpublico.AutoSize = true;
            this.rbpublico.Location = new System.Drawing.Point(6, 137);
            this.rbpublico.Name = "rbpublico";
            this.rbpublico.Size = new System.Drawing.Size(216, 17);
            this.rbpublico.TabIndex = 3;
            this.rbpublico.TabStop = true;
            this.rbpublico.Text = "Transporte público (colectivo, remis, etc)";
            this.rbpublico.UseVisualStyleBackColor = true;
            this.rbpublico.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // bregistrar
            // 
            this.bregistrar.Location = new System.Drawing.Point(360, 73);
            this.bregistrar.Name = "bregistrar";
            this.bregistrar.Size = new System.Drawing.Size(75, 58);
            this.bregistrar.TabIndex = 4;
            this.bregistrar.Text = "Registrar Encuesta";
            this.bregistrar.UseVisualStyleBackColor = true;
            this.bregistrar.Click += new System.EventHandler(this.bregistrar_Click);
            // 
            // tbdistancia
            // 
            this.tbdistancia.Location = new System.Drawing.Point(18, 32);
            this.tbdistancia.Name = "tbdistancia";
            this.tbdistancia.Size = new System.Drawing.Size(100, 20);
            this.tbdistancia.TabIndex = 5;
            // 
            // bresultados
            // 
            this.bresultados.Location = new System.Drawing.Point(360, 346);
            this.bresultados.Name = "bresultados";
            this.bresultados.Size = new System.Drawing.Size(75, 53);
            this.bresultados.TabIndex = 4;
            this.bresultados.Text = "Ver Resultados";
            this.bresultados.UseVisualStyleBackColor = true;
            this.bresultados.Click += new System.EventHandler(this.bresultados_Click);
            // 
            // lbresultados
            // 
            this.lbresultados.FormattingEnabled = true;
            this.lbresultados.Location = new System.Drawing.Point(6, 19);
            this.lbresultados.Name = "lbresultados";
            this.lbresultados.Size = new System.Drawing.Size(336, 69);
            this.lbresultados.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbauto;
        private System.Windows.Forms.RadioButton rbmoto;
        private System.Windows.Forms.RadioButton rbbici;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rbpublico;
        private System.Windows.Forms.Button bregistrar;
        private System.Windows.Forms.Button bresultados;
        private System.Windows.Forms.TextBox tbdistancia;
        private System.Windows.Forms.ListBox lbresultados;
    }
}

