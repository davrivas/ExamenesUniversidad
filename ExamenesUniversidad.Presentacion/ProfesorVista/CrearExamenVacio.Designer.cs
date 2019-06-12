namespace ExamenesUniversidad.Presentacion.ProfesorVista
{
    partial class CrearExamenVacio
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
            this.labelCodigoCurso = new System.Windows.Forms.Label();
            this.textBoxCodigoCurso = new System.Windows.Forms.TextBox();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.buttonGenerarEscoger = new System.Windows.Forms.Button();
            this.dateTimePickerInicio = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerFin = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // labelCodigoCurso
            // 
            this.labelCodigoCurso.AutoSize = true;
            this.labelCodigoCurso.Location = new System.Drawing.Point(13, 13);
            this.labelCodigoCurso.Name = "labelCodigoCurso";
            this.labelCodigoCurso.Size = new System.Drawing.Size(69, 13);
            this.labelCodigoCurso.TabIndex = 0;
            this.labelCodigoCurso.Text = "Código curso";
            // 
            // textBoxCodigoCurso
            // 
            this.textBoxCodigoCurso.Location = new System.Drawing.Point(89, 13);
            this.textBoxCodigoCurso.Name = "textBoxCodigoCurso";
            this.textBoxCodigoCurso.Size = new System.Drawing.Size(100, 20);
            this.textBoxCodigoCurso.TabIndex = 1;
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(196, 13);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscar.TabIndex = 2;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.ButtonBuscar_Click);
            // 
            // buttonGenerarEscoger
            // 
            this.buttonGenerarEscoger.Enabled = false;
            this.buttonGenerarEscoger.Location = new System.Drawing.Point(196, 94);
            this.buttonGenerarEscoger.Name = "buttonGenerarEscoger";
            this.buttonGenerarEscoger.Size = new System.Drawing.Size(75, 23);
            this.buttonGenerarEscoger.TabIndex = 2;
            this.buttonGenerarEscoger.Text = "Generar";
            this.buttonGenerarEscoger.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerInicio
            // 
            this.dateTimePickerInicio.Enabled = false;
            this.dateTimePickerInicio.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerInicio.Location = new System.Drawing.Point(89, 42);
            this.dateTimePickerInicio.Name = "dateTimePickerInicio";
            this.dateTimePickerInicio.Size = new System.Drawing.Size(182, 20);
            this.dateTimePickerInicio.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Fecha inicio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Fecha fin";
            // 
            // dateTimePickerFin
            // 
            this.dateTimePickerFin.Enabled = false;
            this.dateTimePickerFin.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerFin.Location = new System.Drawing.Point(89, 68);
            this.dateTimePickerFin.Name = "dateTimePickerFin";
            this.dateTimePickerFin.Size = new System.Drawing.Size(182, 20);
            this.dateTimePickerFin.TabIndex = 7;
            // 
            // CrearExamenVacio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 133);
            this.Controls.Add(this.buttonGenerarEscoger);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePickerFin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePickerInicio);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.textBoxCodigoCurso);
            this.Controls.Add(this.labelCodigoCurso);
            this.Name = "CrearExamenVacio";
            this.Text = "Crear examen vacío";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCodigoCurso;
        private System.Windows.Forms.TextBox textBoxCodigoCurso;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.DateTimePicker dateTimePickerInicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerFin;
        private System.Windows.Forms.Button buttonGenerarEscoger;
    }
}