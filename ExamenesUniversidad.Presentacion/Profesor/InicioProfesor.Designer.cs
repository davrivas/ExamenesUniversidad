namespace ExamenesUniversidad.Presentacion.Profesor
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
            this.tabControlProfesor = new System.Windows.Forms.TabControl();
            this.tabPageCursos = new System.Windows.Forms.TabPage();
            this.tabPageExamenes = new System.Windows.Forms.TabPage();
            this.tabControlProfesor.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlProfesor
            // 
            this.tabControlProfesor.Controls.Add(this.tabPageCursos);
            this.tabControlProfesor.Controls.Add(this.tabPageExamenes);
            this.tabControlProfesor.Location = new System.Drawing.Point(13, 13);
            this.tabControlProfesor.Name = "tabControlProfesor";
            this.tabControlProfesor.SelectedIndex = 0;
            this.tabControlProfesor.Size = new System.Drawing.Size(561, 100);
            this.tabControlProfesor.TabIndex = 0;
            // 
            // tabPageCursos
            // 
            this.tabPageCursos.Location = new System.Drawing.Point(4, 22);
            this.tabPageCursos.Name = "tabPageCursos";
            this.tabPageCursos.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCursos.Size = new System.Drawing.Size(553, 74);
            this.tabPageCursos.TabIndex = 0;
            this.tabPageCursos.Text = "Cursos";
            this.tabPageCursos.UseVisualStyleBackColor = true;
            // 
            // tabPageExamenes
            // 
            this.tabPageExamenes.Location = new System.Drawing.Point(4, 22);
            this.tabPageExamenes.Name = "tabPageExamenes";
            this.tabPageExamenes.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageExamenes.Size = new System.Drawing.Size(553, 74);
            this.tabPageExamenes.TabIndex = 1;
            this.tabPageExamenes.Text = "Examenes";
            this.tabPageExamenes.UseVisualStyleBackColor = true;
            // 
            // InicioProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControlProfesor);
            this.Name = "InicioProfesor";
            this.Text = "Profesor inicio";
            this.tabControlProfesor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlProfesor;
        private System.Windows.Forms.TabPage tabPageCursos;
        private System.Windows.Forms.TabPage tabPageExamenes;
    }
}