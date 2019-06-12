namespace ExamenesUniversidad.Presentacion.ProfesorVista
{
    partial class InicioProfesor
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
            this.tabPageExamenes = new System.Windows.Forms.TabPage();
            this.buttonCalificaciones = new System.Windows.Forms.Button();
            this.buttonRefrescarExamenes = new System.Windows.Forms.Button();
            this.buttonPreguntasExamen = new System.Windows.Forms.Button();
            this.dataGridViewExamenes = new System.Windows.Forms.DataGridView();
            this.buttonAgregarExamen = new System.Windows.Forms.Button();
            this.tabPageCursos = new System.Windows.Forms.TabPage();
            this.buttonPreguntasCurso = new System.Windows.Forms.Button();
            this.buttonRefrescarCursos = new System.Windows.Forms.Button();
            this.buttonAgregarCurso = new System.Windows.Forms.Button();
            this.dataGridViewCursos = new System.Windows.Forms.DataGridView();
            this.tabControlProfesor = new System.Windows.Forms.TabControl();
            this.buttonCerrarSesion = new System.Windows.Forms.Button();
            this.tabPageExamenes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExamenes)).BeginInit();
            this.tabPageCursos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCursos)).BeginInit();
            this.tabControlProfesor.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPageExamenes
            // 
            this.tabPageExamenes.Controls.Add(this.buttonCalificaciones);
            this.tabPageExamenes.Controls.Add(this.buttonRefrescarExamenes);
            this.tabPageExamenes.Controls.Add(this.buttonPreguntasExamen);
            this.tabPageExamenes.Controls.Add(this.dataGridViewExamenes);
            this.tabPageExamenes.Controls.Add(this.buttonAgregarExamen);
            this.tabPageExamenes.Location = new System.Drawing.Point(4, 22);
            this.tabPageExamenes.Name = "tabPageExamenes";
            this.tabPageExamenes.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageExamenes.Size = new System.Drawing.Size(553, 240);
            this.tabPageExamenes.TabIndex = 3;
            this.tabPageExamenes.Text = "Examenes";
            this.tabPageExamenes.UseVisualStyleBackColor = true;
            // 
            // buttonCalificaciones
            // 
            this.buttonCalificaciones.Location = new System.Drawing.Point(181, 6);
            this.buttonCalificaciones.Name = "buttonCalificaciones";
            this.buttonCalificaciones.Size = new System.Drawing.Size(99, 23);
            this.buttonCalificaciones.TabIndex = 6;
            this.buttonCalificaciones.Text = "Ver calificaciones";
            this.buttonCalificaciones.UseVisualStyleBackColor = true;
            // 
            // buttonRefrescarExamenes
            // 
            this.buttonRefrescarExamenes.Location = new System.Drawing.Point(286, 6);
            this.buttonRefrescarExamenes.Name = "buttonRefrescarExamenes";
            this.buttonRefrescarExamenes.Size = new System.Drawing.Size(75, 23);
            this.buttonRefrescarExamenes.TabIndex = 5;
            this.buttonRefrescarExamenes.Text = "Refrescar";
            this.buttonRefrescarExamenes.UseVisualStyleBackColor = true;
            this.buttonRefrescarExamenes.Click += new System.EventHandler(this.ButtonRefrescarExamenes_Click);
            // 
            // buttonPreguntasExamen
            // 
            this.buttonPreguntasExamen.Location = new System.Drawing.Point(87, 6);
            this.buttonPreguntasExamen.Name = "buttonPreguntasExamen";
            this.buttonPreguntasExamen.Size = new System.Drawing.Size(88, 23);
            this.buttonPreguntasExamen.TabIndex = 4;
            this.buttonPreguntasExamen.Text = "Ver preguntas";
            this.buttonPreguntasExamen.UseVisualStyleBackColor = true;
            this.buttonPreguntasExamen.Click += new System.EventHandler(this.ButtonPreguntasExamen_Click);
            // 
            // dataGridViewExamenes
            // 
            this.dataGridViewExamenes.AllowUserToAddRows = false;
            this.dataGridViewExamenes.AllowUserToDeleteRows = false;
            this.dataGridViewExamenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewExamenes.Location = new System.Drawing.Point(0, 35);
            this.dataGridViewExamenes.Name = "dataGridViewExamenes";
            this.dataGridViewExamenes.ReadOnly = true;
            this.dataGridViewExamenes.Size = new System.Drawing.Size(553, 205);
            this.dataGridViewExamenes.TabIndex = 3;
            // 
            // buttonAgregarExamen
            // 
            this.buttonAgregarExamen.Location = new System.Drawing.Point(6, 6);
            this.buttonAgregarExamen.Name = "buttonAgregarExamen";
            this.buttonAgregarExamen.Size = new System.Drawing.Size(75, 23);
            this.buttonAgregarExamen.TabIndex = 2;
            this.buttonAgregarExamen.Text = "Agregar";
            this.buttonAgregarExamen.UseVisualStyleBackColor = true;
            this.buttonAgregarExamen.Click += new System.EventHandler(this.ButtonAgregarExamen_Click);
            // 
            // tabPageCursos
            // 
            this.tabPageCursos.Controls.Add(this.buttonPreguntasCurso);
            this.tabPageCursos.Controls.Add(this.buttonRefrescarCursos);
            this.tabPageCursos.Controls.Add(this.buttonAgregarCurso);
            this.tabPageCursos.Controls.Add(this.dataGridViewCursos);
            this.tabPageCursos.Location = new System.Drawing.Point(4, 22);
            this.tabPageCursos.Name = "tabPageCursos";
            this.tabPageCursos.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCursos.Size = new System.Drawing.Size(553, 240);
            this.tabPageCursos.TabIndex = 0;
            this.tabPageCursos.Text = "Cursos";
            this.tabPageCursos.UseVisualStyleBackColor = true;
            // 
            // buttonPreguntasCurso
            // 
            this.buttonPreguntasCurso.Location = new System.Drawing.Point(86, 8);
            this.buttonPreguntasCurso.Name = "buttonPreguntasCurso";
            this.buttonPreguntasCurso.Size = new System.Drawing.Size(88, 23);
            this.buttonPreguntasCurso.TabIndex = 3;
            this.buttonPreguntasCurso.Text = "Ver preguntas";
            this.buttonPreguntasCurso.UseVisualStyleBackColor = true;
            this.buttonPreguntasCurso.Click += new System.EventHandler(this.ButtonPreguntas_Click);
            // 
            // buttonRefrescarCursos
            // 
            this.buttonRefrescarCursos.Location = new System.Drawing.Point(180, 8);
            this.buttonRefrescarCursos.Name = "buttonRefrescarCursos";
            this.buttonRefrescarCursos.Size = new System.Drawing.Size(75, 23);
            this.buttonRefrescarCursos.TabIndex = 2;
            this.buttonRefrescarCursos.Text = "Refrescar";
            this.buttonRefrescarCursos.UseVisualStyleBackColor = true;
            this.buttonRefrescarCursos.Click += new System.EventHandler(this.ButtonRefrescarCursos_Click);
            // 
            // buttonAgregarCurso
            // 
            this.buttonAgregarCurso.Location = new System.Drawing.Point(7, 7);
            this.buttonAgregarCurso.Name = "buttonAgregarCurso";
            this.buttonAgregarCurso.Size = new System.Drawing.Size(75, 23);
            this.buttonAgregarCurso.TabIndex = 1;
            this.buttonAgregarCurso.Text = "Agregar";
            this.buttonAgregarCurso.UseVisualStyleBackColor = true;
            this.buttonAgregarCurso.Click += new System.EventHandler(this.ButtonAgregarCurso_Click);
            // 
            // dataGridViewCursos
            // 
            this.dataGridViewCursos.AllowUserToAddRows = false;
            this.dataGridViewCursos.AllowUserToDeleteRows = false;
            this.dataGridViewCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCursos.Location = new System.Drawing.Point(0, 37);
            this.dataGridViewCursos.Name = "dataGridViewCursos";
            this.dataGridViewCursos.ReadOnly = true;
            this.dataGridViewCursos.Size = new System.Drawing.Size(553, 203);
            this.dataGridViewCursos.TabIndex = 0;
            // 
            // tabControlProfesor
            // 
            this.tabControlProfesor.Controls.Add(this.tabPageCursos);
            this.tabControlProfesor.Controls.Add(this.tabPageExamenes);
            this.tabControlProfesor.Location = new System.Drawing.Point(12, 41);
            this.tabControlProfesor.Name = "tabControlProfesor";
            this.tabControlProfesor.SelectedIndex = 0;
            this.tabControlProfesor.Size = new System.Drawing.Size(561, 266);
            this.tabControlProfesor.TabIndex = 0;
            // 
            // buttonCerrarSesion
            // 
            this.buttonCerrarSesion.Location = new System.Drawing.Point(465, 12);
            this.buttonCerrarSesion.Name = "buttonCerrarSesion";
            this.buttonCerrarSesion.Size = new System.Drawing.Size(108, 23);
            this.buttonCerrarSesion.TabIndex = 4;
            this.buttonCerrarSesion.Text = "Cerrar sesión";
            this.buttonCerrarSesion.UseVisualStyleBackColor = true;
            this.buttonCerrarSesion.Click += new System.EventHandler(this.ButtonCerrarSesion_Click);
            // 
            // InicioProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 317);
            this.Controls.Add(this.buttonCerrarSesion);
            this.Controls.Add(this.tabControlProfesor);
            this.Name = "InicioProfesor";
            this.Text = "Profesor inicio";
            this.tabPageExamenes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExamenes)).EndInit();
            this.tabPageCursos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCursos)).EndInit();
            this.tabControlProfesor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabPageExamenes;
        private System.Windows.Forms.TabPage tabPageCursos;
        private System.Windows.Forms.Button buttonPreguntasCurso;
        private System.Windows.Forms.Button buttonRefrescarCursos;
        private System.Windows.Forms.Button buttonAgregarCurso;
        private System.Windows.Forms.DataGridView dataGridViewCursos;
        private System.Windows.Forms.TabControl tabControlProfesor;
        private System.Windows.Forms.Button buttonCerrarSesion;
        private System.Windows.Forms.Button buttonAgregarExamen;
        private System.Windows.Forms.DataGridView dataGridViewExamenes;
        private System.Windows.Forms.Button buttonPreguntasExamen;
        private System.Windows.Forms.Button buttonRefrescarExamenes;
        private System.Windows.Forms.Button buttonCalificaciones;
    }
}