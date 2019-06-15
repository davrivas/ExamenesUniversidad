namespace ExamenesUniversidad.Presentacion.ProfesorVista
{
    partial class CalificacionesExamen
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCodigoExamen = new System.Windows.Forms.TextBox();
            this.dataGridViewCalificaciones = new System.Windows.Forms.DataGridView();
            this.buttonExcel = new System.Windows.Forms.Button();
            this.buttonPDF = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCalificaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(208, 10);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscar.TabIndex = 0;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.ButtonBuscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Código examen";
            // 
            // textBoxCodigoExamen
            // 
            this.textBoxCodigoExamen.Location = new System.Drawing.Point(102, 12);
            this.textBoxCodigoExamen.Name = "textBoxCodigoExamen";
            this.textBoxCodigoExamen.Size = new System.Drawing.Size(100, 20);
            this.textBoxCodigoExamen.TabIndex = 2;
            // 
            // dataGridViewCalificaciones
            // 
            this.dataGridViewCalificaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCalificaciones.Location = new System.Drawing.Point(19, 53);
            this.dataGridViewCalificaciones.Name = "dataGridViewCalificaciones";
            this.dataGridViewCalificaciones.Size = new System.Drawing.Size(679, 271);
            this.dataGridViewCalificaciones.TabIndex = 3;
            // 
            // buttonExcel
            // 
            this.buttonExcel.Location = new System.Drawing.Point(623, 12);
            this.buttonExcel.Name = "buttonExcel";
            this.buttonExcel.Size = new System.Drawing.Size(75, 23);
            this.buttonExcel.TabIndex = 4;
            this.buttonExcel.Text = "Excel";
            this.buttonExcel.UseVisualStyleBackColor = true;
            this.buttonExcel.Click += new System.EventHandler(this.ButtonExcel_Click);
            // 
            // buttonPDF
            // 
            this.buttonPDF.Location = new System.Drawing.Point(542, 12);
            this.buttonPDF.Name = "buttonPDF";
            this.buttonPDF.Size = new System.Drawing.Size(75, 23);
            this.buttonPDF.TabIndex = 5;
            this.buttonPDF.Text = "PDF";
            this.buttonPDF.UseVisualStyleBackColor = true;
            this.buttonPDF.Click += new System.EventHandler(this.ButtonPDF_Click);
            // 
            // CalificacionesExamen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 334);
            this.Controls.Add(this.buttonPDF);
            this.Controls.Add(this.buttonExcel);
            this.Controls.Add(this.dataGridViewCalificaciones);
            this.Controls.Add(this.textBoxCodigoExamen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonBuscar);
            this.Name = "CalificacionesExamen";
            this.Text = "Calificaciones examen";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCalificaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCodigoExamen;
        private System.Windows.Forms.DataGridView dataGridViewCalificaciones;
        private System.Windows.Forms.Button buttonExcel;
        private System.Windows.Forms.Button buttonPDF;
    }
}