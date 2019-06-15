namespace ExamenesUniversidad.Presentacion.EstudianteVista
{
    partial class InicioEstudiante
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
            this.buttonCerrarSesion = new System.Windows.Forms.Button();
            this.dataGridViewExamenes = new System.Windows.Forms.DataGridView();
            this.buttonRealizarExamen = new System.Windows.Forms.Button();
            this.buttonRefrescar = new System.Windows.Forms.Button();
            this.labelCodigoExamen = new System.Windows.Forms.Label();
            this.textBoxCodigoExamen = new System.Windows.Forms.TextBox();
            this.tabControlEstudiante = new System.Windows.Forms.TabControl();
            this.tabPageExamenes = new System.Windows.Forms.TabPage();
            this.tabPageCalificaciones = new System.Windows.Forms.TabPage();
            this.buttonRefrescarCalificaciones = new System.Windows.Forms.Button();
            this.dataGridViewCalificaciones = new System.Windows.Forms.DataGridView();
            this.buttonPDF = new System.Windows.Forms.Button();
            this.buttonExcel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExamenes)).BeginInit();
            this.tabControlEstudiante.SuspendLayout();
            this.tabPageExamenes.SuspendLayout();
            this.tabPageCalificaciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCalificaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCerrarSesion
            // 
            this.buttonCerrarSesion.Location = new System.Drawing.Point(602, 12);
            this.buttonCerrarSesion.Name = "buttonCerrarSesion";
            this.buttonCerrarSesion.Size = new System.Drawing.Size(81, 23);
            this.buttonCerrarSesion.TabIndex = 0;
            this.buttonCerrarSesion.Text = "Cerrar sesión";
            this.buttonCerrarSesion.UseVisualStyleBackColor = true;
            this.buttonCerrarSesion.Click += new System.EventHandler(this.ButtonCerrarSesion_Click);
            // 
            // dataGridViewExamenes
            // 
            this.dataGridViewExamenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewExamenes.Location = new System.Drawing.Point(0, 45);
            this.dataGridViewExamenes.Name = "dataGridViewExamenes";
            this.dataGridViewExamenes.Size = new System.Drawing.Size(663, 300);
            this.dataGridViewExamenes.TabIndex = 1;
            // 
            // buttonRealizarExamen
            // 
            this.buttonRealizarExamen.Location = new System.Drawing.Point(201, 6);
            this.buttonRealizarExamen.Name = "buttonRealizarExamen";
            this.buttonRealizarExamen.Size = new System.Drawing.Size(104, 23);
            this.buttonRealizarExamen.TabIndex = 2;
            this.buttonRealizarExamen.Text = "Realizar examen";
            this.buttonRealizarExamen.UseVisualStyleBackColor = true;
            this.buttonRealizarExamen.Click += new System.EventHandler(this.ButtonRealizarExamen_Click);
            // 
            // buttonRefrescar
            // 
            this.buttonRefrescar.Location = new System.Drawing.Point(311, 6);
            this.buttonRefrescar.Name = "buttonRefrescar";
            this.buttonRefrescar.Size = new System.Drawing.Size(98, 23);
            this.buttonRefrescar.TabIndex = 3;
            this.buttonRefrescar.Text = "Refrescar lista";
            this.buttonRefrescar.UseVisualStyleBackColor = true;
            this.buttonRefrescar.Click += new System.EventHandler(this.ButtonRefrescar_Click);
            // 
            // labelCodigoExamen
            // 
            this.labelCodigoExamen.AutoSize = true;
            this.labelCodigoExamen.Location = new System.Drawing.Point(9, 12);
            this.labelCodigoExamen.Name = "labelCodigoExamen";
            this.labelCodigoExamen.Size = new System.Drawing.Size(80, 13);
            this.labelCodigoExamen.TabIndex = 4;
            this.labelCodigoExamen.Text = "Código examen";
            // 
            // textBoxCodigoExamen
            // 
            this.textBoxCodigoExamen.Location = new System.Drawing.Point(95, 9);
            this.textBoxCodigoExamen.Name = "textBoxCodigoExamen";
            this.textBoxCodigoExamen.Size = new System.Drawing.Size(100, 20);
            this.textBoxCodigoExamen.TabIndex = 5;
            // 
            // tabControlEstudiante
            // 
            this.tabControlEstudiante.Controls.Add(this.tabPageExamenes);
            this.tabControlEstudiante.Controls.Add(this.tabPageCalificaciones);
            this.tabControlEstudiante.Location = new System.Drawing.Point(12, 49);
            this.tabControlEstudiante.Name = "tabControlEstudiante";
            this.tabControlEstudiante.SelectedIndex = 0;
            this.tabControlEstudiante.Size = new System.Drawing.Size(671, 371);
            this.tabControlEstudiante.TabIndex = 6;
            // 
            // tabPageExamenes
            // 
            this.tabPageExamenes.Controls.Add(this.labelCodigoExamen);
            this.tabPageExamenes.Controls.Add(this.dataGridViewExamenes);
            this.tabPageExamenes.Controls.Add(this.textBoxCodigoExamen);
            this.tabPageExamenes.Controls.Add(this.buttonRealizarExamen);
            this.tabPageExamenes.Controls.Add(this.buttonRefrescar);
            this.tabPageExamenes.Location = new System.Drawing.Point(4, 22);
            this.tabPageExamenes.Name = "tabPageExamenes";
            this.tabPageExamenes.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageExamenes.Size = new System.Drawing.Size(663, 345);
            this.tabPageExamenes.TabIndex = 0;
            this.tabPageExamenes.Text = "Examenes";
            this.tabPageExamenes.UseVisualStyleBackColor = true;
            // 
            // tabPageCalificaciones
            // 
            this.tabPageCalificaciones.Controls.Add(this.buttonExcel);
            this.tabPageCalificaciones.Controls.Add(this.buttonPDF);
            this.tabPageCalificaciones.Controls.Add(this.buttonRefrescarCalificaciones);
            this.tabPageCalificaciones.Controls.Add(this.dataGridViewCalificaciones);
            this.tabPageCalificaciones.Location = new System.Drawing.Point(4, 22);
            this.tabPageCalificaciones.Name = "tabPageCalificaciones";
            this.tabPageCalificaciones.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCalificaciones.Size = new System.Drawing.Size(663, 345);
            this.tabPageCalificaciones.TabIndex = 1;
            this.tabPageCalificaciones.Text = "Calificaciones";
            this.tabPageCalificaciones.UseVisualStyleBackColor = true;
            // 
            // buttonRefrescarCalificaciones
            // 
            this.buttonRefrescarCalificaciones.Location = new System.Drawing.Point(559, 6);
            this.buttonRefrescarCalificaciones.Name = "buttonRefrescarCalificaciones";
            this.buttonRefrescarCalificaciones.Size = new System.Drawing.Size(98, 23);
            this.buttonRefrescarCalificaciones.TabIndex = 4;
            this.buttonRefrescarCalificaciones.Text = "Refrescar lista";
            this.buttonRefrescarCalificaciones.UseVisualStyleBackColor = true;
            this.buttonRefrescarCalificaciones.Click += new System.EventHandler(this.ButtonRefrescarCalificaciones_Click);
            // 
            // dataGridViewCalificaciones
            // 
            this.dataGridViewCalificaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCalificaciones.Location = new System.Drawing.Point(0, 35);
            this.dataGridViewCalificaciones.Name = "dataGridViewCalificaciones";
            this.dataGridViewCalificaciones.Size = new System.Drawing.Size(663, 310);
            this.dataGridViewCalificaciones.TabIndex = 0;
            // 
            // buttonPDF
            // 
            this.buttonPDF.Location = new System.Drawing.Point(7, 7);
            this.buttonPDF.Name = "buttonPDF";
            this.buttonPDF.Size = new System.Drawing.Size(75, 23);
            this.buttonPDF.TabIndex = 5;
            this.buttonPDF.Text = "PDF";
            this.buttonPDF.UseVisualStyleBackColor = true;
            this.buttonPDF.Click += new System.EventHandler(this.ButtonPDF_Click);
            // 
            // buttonExcel
            // 
            this.buttonExcel.Location = new System.Drawing.Point(88, 7);
            this.buttonExcel.Name = "buttonExcel";
            this.buttonExcel.Size = new System.Drawing.Size(75, 23);
            this.buttonExcel.TabIndex = 6;
            this.buttonExcel.Text = "Excel";
            this.buttonExcel.UseVisualStyleBackColor = true;
            this.buttonExcel.Click += new System.EventHandler(this.ButtonExcel_Click);
            // 
            // InicioEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 432);
            this.Controls.Add(this.tabControlEstudiante);
            this.Controls.Add(this.buttonCerrarSesion);
            this.Name = "InicioEstudiante";
            this.Text = "Estudiante inicio";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExamenes)).EndInit();
            this.tabControlEstudiante.ResumeLayout(false);
            this.tabPageExamenes.ResumeLayout(false);
            this.tabPageExamenes.PerformLayout();
            this.tabPageCalificaciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCalificaciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCerrarSesion;
        private System.Windows.Forms.DataGridView dataGridViewExamenes;
        private System.Windows.Forms.Button buttonRealizarExamen;
        private System.Windows.Forms.Button buttonRefrescar;
        private System.Windows.Forms.Label labelCodigoExamen;
        private System.Windows.Forms.TextBox textBoxCodigoExamen;
        private System.Windows.Forms.TabControl tabControlEstudiante;
        private System.Windows.Forms.TabPage tabPageExamenes;
        private System.Windows.Forms.TabPage tabPageCalificaciones;
        private System.Windows.Forms.DataGridView dataGridViewCalificaciones;
        private System.Windows.Forms.Button buttonRefrescarCalificaciones;
        private System.Windows.Forms.Button buttonExcel;
        private System.Windows.Forms.Button buttonPDF;
    }
}