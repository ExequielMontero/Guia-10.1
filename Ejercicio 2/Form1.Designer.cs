namespace Ejercicio_2_Guia_10
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
            this.gbreocorrido = new System.Windows.Forms.GroupBox();
            this.lbfueraderangominutosohoras = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.brecorrido = new System.Windows.Forms.Button();
            this.tbminutos = new System.Windows.Forms.TextBox();
            this.tbhora = new System.Windows.Forms.TextBox();
            this.tbasientos = new System.Windows.Forms.TextBox();
            this.lbhorapartida = new System.Windows.Forms.Label();
            this.lbasientos = new System.Windows.Forms.Label();
            this.gbparada = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbparada = new System.Windows.Forms.ListBox();
            this.btRegistrarparada = new System.Windows.Forms.Button();
            this.tbLlegadahora = new System.Windows.Forms.TextBox();
            this.tbSalidamin = new System.Windows.Forms.TextBox();
            this.tbLlegadamin = new System.Windows.Forms.TextBox();
            this.tbDesc = new System.Windows.Forms.TextBox();
            this.tbSalidahora = new System.Windows.Forms.TextBox();
            this.tbAscien = new System.Windows.Forms.TextBox();
            this.tbllegada = new System.Windows.Forms.Label();
            this.tbascienden = new System.Windows.Forms.Label();
            this.tbdescienden = new System.Windows.Forms.Label();
            this.tbsalida = new System.Windows.Forms.Label();
            this.gbfinrecorrido = new System.Windows.Forms.GroupBox();
            this.lbfin = new System.Windows.Forms.ListBox();
            this.btnfin = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbfinhora = new System.Windows.Forms.TextBox();
            this.tbfinmin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.gbreocorrido.SuspendLayout();
            this.gbparada.SuspendLayout();
            this.gbfinrecorrido.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbreocorrido
            // 
            this.gbreocorrido.Controls.Add(this.label6);
            this.gbreocorrido.Controls.Add(this.lbfueraderangominutosohoras);
            this.gbreocorrido.Controls.Add(this.label3);
            this.gbreocorrido.Controls.Add(this.brecorrido);
            this.gbreocorrido.Controls.Add(this.tbminutos);
            this.gbreocorrido.Controls.Add(this.tbhora);
            this.gbreocorrido.Controls.Add(this.tbasientos);
            this.gbreocorrido.Controls.Add(this.lbhorapartida);
            this.gbreocorrido.Controls.Add(this.lbasientos);
            this.gbreocorrido.Location = new System.Drawing.Point(12, 28);
            this.gbreocorrido.Name = "gbreocorrido";
            this.gbreocorrido.Size = new System.Drawing.Size(298, 410);
            this.gbreocorrido.TabIndex = 0;
            this.gbreocorrido.TabStop = false;
            this.gbreocorrido.Text = "Iniciar Recorrido";
            this.gbreocorrido.Enter += new System.EventHandler(this.gbreocorrido_Enter);
            // 
            // lbfueraderangominutosohoras
            // 
            this.lbfueraderangominutosohoras.FormattingEnabled = true;
            this.lbfueraderangominutosohoras.Location = new System.Drawing.Point(0, 284);
            this.lbfueraderangominutosohoras.Name = "lbfueraderangominutosohoras";
            this.lbfueraderangominutosohoras.Size = new System.Drawing.Size(284, 95);
            this.lbfueraderangominutosohoras.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(192, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = ":";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // brecorrido
            // 
            this.brecorrido.Location = new System.Drawing.Point(92, 164);
            this.brecorrido.Name = "brecorrido";
            this.brecorrido.Size = new System.Drawing.Size(110, 65);
            this.brecorrido.TabIndex = 6;
            this.brecorrido.Text = "Iniciar Recorrido";
            this.brecorrido.UseVisualStyleBackColor = true;
            this.brecorrido.Click += new System.EventHandler(this.brecorrido_Click);
            // 
            // tbminutos
            // 
            this.tbminutos.Location = new System.Drawing.Point(208, 59);
            this.tbminutos.Name = "tbminutos";
            this.tbminutos.Size = new System.Drawing.Size(49, 20);
            this.tbminutos.TabIndex = 5;
            // 
            // tbhora
            // 
            this.tbhora.Location = new System.Drawing.Point(141, 59);
            this.tbhora.Name = "tbhora";
            this.tbhora.Size = new System.Drawing.Size(45, 20);
            this.tbhora.TabIndex = 4;
            // 
            // tbasientos
            // 
            this.tbasientos.Location = new System.Drawing.Point(157, 104);
            this.tbasientos.Name = "tbasientos";
            this.tbasientos.Size = new System.Drawing.Size(100, 20);
            this.tbasientos.TabIndex = 3;
            this.tbasientos.TextChanged += new System.EventHandler(this.tbasientos_TextChanged);
            // 
            // lbhorapartida
            // 
            this.lbhorapartida.AutoSize = true;
            this.lbhorapartida.Location = new System.Drawing.Point(0, 62);
            this.lbhorapartida.Name = "lbhorapartida";
            this.lbhorapartida.Size = new System.Drawing.Size(127, 13);
            this.lbhorapartida.TabIndex = 1;
            this.lbhorapartida.Text = "Hora de Partida (HH:MM)";
            // 
            // lbasientos
            // 
            this.lbasientos.AutoSize = true;
            this.lbasientos.Location = new System.Drawing.Point(34, 104);
            this.lbasientos.Name = "lbasientos";
            this.lbasientos.Size = new System.Drawing.Size(107, 13);
            this.lbasientos.TabIndex = 2;
            this.lbasientos.Text = "Cantidad de Asientos";
            // 
            // gbparada
            // 
            this.gbparada.Controls.Add(this.label8);
            this.gbparada.Controls.Add(this.label7);
            this.gbparada.Controls.Add(this.label4);
            this.gbparada.Controls.Add(this.label5);
            this.gbparada.Controls.Add(this.lbparada);
            this.gbparada.Controls.Add(this.btRegistrarparada);
            this.gbparada.Controls.Add(this.tbLlegadahora);
            this.gbparada.Controls.Add(this.tbSalidamin);
            this.gbparada.Controls.Add(this.tbLlegadamin);
            this.gbparada.Controls.Add(this.tbDesc);
            this.gbparada.Controls.Add(this.tbSalidahora);
            this.gbparada.Controls.Add(this.tbAscien);
            this.gbparada.Controls.Add(this.tbllegada);
            this.gbparada.Controls.Add(this.tbascienden);
            this.gbparada.Controls.Add(this.tbdescienden);
            this.gbparada.Controls.Add(this.tbsalida);
            this.gbparada.Enabled = false;
            this.gbparada.Location = new System.Drawing.Point(316, 28);
            this.gbparada.Name = "gbparada";
            this.gbparada.Size = new System.Drawing.Size(256, 410);
            this.gbparada.TabIndex = 0;
            this.gbparada.TabStop = false;
            this.gbparada.Text = "Parada";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(162, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(10, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = ":";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(162, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(10, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = ":";
            // 
            // lbparada
            // 
            this.lbparada.FormattingEnabled = true;
            this.lbparada.Location = new System.Drawing.Point(0, 309);
            this.lbparada.Name = "lbparada";
            this.lbparada.Size = new System.Drawing.Size(250, 95);
            this.lbparada.TabIndex = 18;
            // 
            // btRegistrarparada
            // 
            this.btRegistrarparada.Location = new System.Drawing.Point(78, 223);
            this.btRegistrarparada.Name = "btRegistrarparada";
            this.btRegistrarparada.Size = new System.Drawing.Size(109, 65);
            this.btRegistrarparada.TabIndex = 17;
            this.btRegistrarparada.Text = "Registrar Parada";
            this.btRegistrarparada.UseVisualStyleBackColor = true;
            this.btRegistrarparada.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbLlegadahora
            // 
            this.tbLlegadahora.Location = new System.Drawing.Point(107, 42);
            this.tbLlegadahora.Name = "tbLlegadahora";
            this.tbLlegadahora.Size = new System.Drawing.Size(49, 20);
            this.tbLlegadahora.TabIndex = 16;
            // 
            // tbSalidamin
            // 
            this.tbSalidamin.Location = new System.Drawing.Point(178, 129);
            this.tbSalidamin.Name = "tbSalidamin";
            this.tbSalidamin.Size = new System.Drawing.Size(57, 20);
            this.tbSalidamin.TabIndex = 11;
            this.tbSalidamin.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tbLlegadamin
            // 
            this.tbLlegadamin.Location = new System.Drawing.Point(178, 42);
            this.tbLlegadamin.Name = "tbLlegadamin";
            this.tbLlegadamin.Size = new System.Drawing.Size(57, 20);
            this.tbLlegadamin.TabIndex = 15;
            // 
            // tbDesc
            // 
            this.tbDesc.Location = new System.Drawing.Point(107, 81);
            this.tbDesc.Name = "tbDesc";
            this.tbDesc.Size = new System.Drawing.Size(49, 20);
            this.tbDesc.TabIndex = 14;
            // 
            // tbSalidahora
            // 
            this.tbSalidahora.Location = new System.Drawing.Point(107, 129);
            this.tbSalidahora.Name = "tbSalidahora";
            this.tbSalidahora.Size = new System.Drawing.Size(49, 20);
            this.tbSalidahora.TabIndex = 13;
            // 
            // tbAscien
            // 
            this.tbAscien.Location = new System.Drawing.Point(105, 177);
            this.tbAscien.Name = "tbAscien";
            this.tbAscien.Size = new System.Drawing.Size(61, 20);
            this.tbAscien.TabIndex = 12;
            // 
            // tbllegada
            // 
            this.tbllegada.AutoSize = true;
            this.tbllegada.Location = new System.Drawing.Point(6, 45);
            this.tbllegada.Name = "tbllegada";
            this.tbllegada.Size = new System.Drawing.Size(95, 13);
            this.tbllegada.TabIndex = 7;
            this.tbllegada.Text = "LLegada (HH:MM)";
            this.tbllegada.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbascienden
            // 
            this.tbascienden.AutoSize = true;
            this.tbascienden.Location = new System.Drawing.Point(37, 177);
            this.tbascienden.Name = "tbascienden";
            this.tbascienden.Size = new System.Drawing.Size(57, 13);
            this.tbascienden.TabIndex = 8;
            this.tbascienden.Text = "Ascienden";
            // 
            // tbdescienden
            // 
            this.tbdescienden.AutoSize = true;
            this.tbdescienden.Location = new System.Drawing.Point(37, 84);
            this.tbdescienden.Name = "tbdescienden";
            this.tbdescienden.Size = new System.Drawing.Size(64, 13);
            this.tbdescienden.TabIndex = 9;
            this.tbdescienden.Text = "Descienden";
            // 
            // tbsalida
            // 
            this.tbsalida.AutoSize = true;
            this.tbsalida.Location = new System.Drawing.Point(16, 129);
            this.tbsalida.Name = "tbsalida";
            this.tbsalida.Size = new System.Drawing.Size(85, 13);
            this.tbsalida.TabIndex = 10;
            this.tbsalida.Text = "Salida: (HH:MM)";
            // 
            // gbfinrecorrido
            // 
            this.gbfinrecorrido.Controls.Add(this.label9);
            this.gbfinrecorrido.Controls.Add(this.lbfin);
            this.gbfinrecorrido.Controls.Add(this.btnfin);
            this.gbfinrecorrido.Controls.Add(this.label2);
            this.gbfinrecorrido.Controls.Add(this.tbfinhora);
            this.gbfinrecorrido.Controls.Add(this.tbfinmin);
            this.gbfinrecorrido.Controls.Add(this.label1);
            this.gbfinrecorrido.Enabled = false;
            this.gbfinrecorrido.Location = new System.Drawing.Point(578, 28);
            this.gbfinrecorrido.Name = "gbfinrecorrido";
            this.gbfinrecorrido.Size = new System.Drawing.Size(302, 410);
            this.gbfinrecorrido.TabIndex = 0;
            this.gbfinrecorrido.TabStop = false;
            this.gbfinrecorrido.Text = "Finalizar Recorrido";
            // 
            // lbfin
            // 
            this.lbfin.FormattingEnabled = true;
            this.lbfin.Location = new System.Drawing.Point(6, 177);
            this.lbfin.Name = "lbfin";
            this.lbfin.Size = new System.Drawing.Size(290, 225);
            this.lbfin.TabIndex = 26;
            // 
            // btnfin
            // 
            this.btnfin.Location = new System.Drawing.Point(108, 86);
            this.btnfin.Name = "btnfin";
            this.btnfin.Size = new System.Drawing.Size(87, 63);
            this.btnfin.TabIndex = 25;
            this.btnfin.Text = "Finalizar Recorrido";
            this.btnfin.UseVisualStyleBackColor = true;
            this.btnfin.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(224, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = ":";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tbfinhora
            // 
            this.tbfinhora.Location = new System.Drawing.Point(173, 42);
            this.tbfinhora.Name = "tbfinhora";
            this.tbfinhora.Size = new System.Drawing.Size(45, 20);
            this.tbfinhora.TabIndex = 21;
            // 
            // tbfinmin
            // 
            this.tbfinmin.Location = new System.Drawing.Point(240, 42);
            this.tbfinmin.Name = "tbfinmin";
            this.tbfinmin.Size = new System.Drawing.Size(43, 20);
            this.tbfinmin.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Hora de Finalización (HH:MM):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(166, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Formato 12hs";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(134, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Formato 12hs";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(134, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Formato 12hs";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(193, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "Formato 12hs";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 450);
            this.Controls.Add(this.gbfinrecorrido);
            this.Controls.Add(this.gbparada);
            this.Controls.Add(this.gbreocorrido);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Empresa de colectivos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbreocorrido.ResumeLayout(false);
            this.gbreocorrido.PerformLayout();
            this.gbparada.ResumeLayout(false);
            this.gbparada.PerformLayout();
            this.gbfinrecorrido.ResumeLayout(false);
            this.gbfinrecorrido.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbreocorrido;
        private System.Windows.Forms.GroupBox gbparada;
        private System.Windows.Forms.GroupBox gbfinrecorrido;
        private System.Windows.Forms.Button brecorrido;
        private System.Windows.Forms.TextBox tbminutos;
        private System.Windows.Forms.TextBox tbhora;
        private System.Windows.Forms.TextBox tbasientos;
        private System.Windows.Forms.Label lbhorapartida;
        private System.Windows.Forms.Label lbasientos;
        private System.Windows.Forms.Label tbllegada;
        private System.Windows.Forms.Label tbascienden;
        private System.Windows.Forms.Label tbdescienden;
        private System.Windows.Forms.Label tbsalida;
        private System.Windows.Forms.TextBox tbLlegadahora;
        private System.Windows.Forms.TextBox tbLlegadamin;
        private System.Windows.Forms.TextBox tbDesc;
        private System.Windows.Forms.TextBox tbSalidahora;
        private System.Windows.Forms.TextBox tbAscien;
        private System.Windows.Forms.TextBox tbSalidamin;
        private System.Windows.Forms.Button btRegistrarparada;
        private System.Windows.Forms.ListBox lbparada;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbfinhora;
        private System.Windows.Forms.TextBox tbfinmin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lbfin;
        private System.Windows.Forms.Button btnfin;
        private System.Windows.Forms.ListBox lbfueraderangominutosohoras;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
    }
}

