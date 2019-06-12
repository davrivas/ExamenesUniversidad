namespace ExamenesUniversidad.Presentacion.ProfesorVista
{
    partial class GenerarExamen
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
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.textBoxCodigoCurso = new System.Windows.Forms.TextBox();
            this.labelCodigoCurso = new System.Windows.Forms.Label();
            this.maskedTextBoxCantidad = new System.Windows.Forms.MaskedTextBox();
            this.buttonGenerar = new System.Windows.Forms.Button();
            this.labelCantidadPreguntas = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerFin = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerInicio = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(226, 12);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscar.TabIndex = 5;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.ButtonBuscar_Click);
            // 
            // textBoxCodigoCurso
            // 
            this.textBoxCodigoCurso.Location = new System.Drawing.Point(90, 12);
            this.textBoxCodigoCurso.Name = "textBoxCodigoCurso";
            this.textBoxCodigoCurso.Size = new System.Drawing.Size(130, 20);
            this.textBoxCodigoCurso.TabIndex = 4;
            // 
            // labelCodigoCurso
            // 
            this.labelCodigoCurso.AutoSize = true;
            this.labelCodigoCurso.Location = new System.Drawing.Point(14, 12);
            this.labelCodigoCurso.Name = "labelCodigoCurso";
            this.labelCodigoCurso.Size = new System.Drawing.Size(69, 13);
            this.labelCodigoCurso.TabIndex = 3;
            this.labelCodigoCurso.Text = "Código curso";
            // 
            // maskedTextBoxCantidad
            // 
            this.maskedTextBoxCantidad.Enabled = false;
            this.maskedTextBoxCantidad.Location = new System.Drawing.Point(17, 76);
            this.maskedTextBoxCantidad.Mask = "9999";
            this.maskedTextBoxCantidad.Name = "maskedTextBoxCantidad";
            this.maskedTextBoxCantidad.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxCantidad.TabIndex = 8;
            this.maskedTextBoxCantidad.ValidatingType = typeof(int);
            // 
            // buttonGenerar
            // 
            this.buttonGenerar.Enabled = false;
            this.buttonGenerar.Location = new System.Drawing.Point(30, 120);
            this.buttonGenerar.Name = "buttonGenerar";
            this.buttonGenerar.Size = new System.Drawing.Size(75, 23);
            this.buttonGenerar.TabIndex = 7;
            this.buttonGenerar.Text = "Generar";
            this.buttonGenerar.UseVisualStyleBackColor = true;
            this.buttonGenerar.Click += new System.EventHandler(this.ButtonGenerar_Click);
            // 
            // labelCantidadPreguntas
            // 
            this.labelCantidadPreguntas.AutoSize = true;
            this.labelCantidadPreguntas.Location = new System.Drawing.Point(14, 50);
            this.labelCantidadPreguntas.Name = "labelCantidadPreguntas";
            this.labelCantidadPreguntas.Size = new System.Drawing.Size(0, 13);
            this.labelCantidadPreguntas.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Fecha fin";
            // 
            // dateTimePickerFin
            // 
            this.dateTimePickerFin.Enabled = false;
            this.dateTimePickerFin.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerFin.Location = new System.Drawing.Point(184, 123);
            this.dateTimePickerFin.Name = "dateTimePickerFin";
            this.dateTimePickerFin.Size = new System.Drawing.Size(147, 20);
            this.dateTimePickerFin.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(181, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Fecha inicio";
            // 
            // dateTimePickerInicio
            // 
            this.dateTimePickerInicio.Enabled = false;
            this.dateTimePickerInicio.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerInicio.Location = new System.Drawing.Point(184, 76);
            this.dateTimePickerInicio.Name = "dateTimePickerInicio";
            this.dateTimePickerInicio.Size = new System.Drawing.Size(147, 20);
            this.dateTimePickerInicio.TabIndex = 9;
            // 
            // GenerarExamen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 154);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePickerFin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePickerInicio);
            this.Controls.Add(this.maskedTextBoxCantidad);
            this.Controls.Add(this.buttonGenerar);
            this.Controls.Add(this.labelCantidadPreguntas);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.textBoxCodigoCurso);
            this.Controls.Add(this.labelCodigoCurso);
            this.Name = "GenerarExamen";
            this.Text = "Generar examen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.TextBox textBoxCodigoCurso;
        private System.Windows.Forms.Label labelCodigoCurso;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCantidad;
        private System.Windows.Forms.Button buttonGenerar;
        private System.Windows.Forms.Label labelCantidadPreguntas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerFin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerInicio;
    }
}