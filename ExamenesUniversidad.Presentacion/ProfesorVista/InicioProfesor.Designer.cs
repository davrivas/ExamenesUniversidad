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
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.tabPageExamenes = new System.Windows.Forms.TabPage();
            this.tabPageCursos = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonAgregarCurso = new System.Windows.Forms.Button();
            this.buttonRefrescar = new System.Windows.Forms.Button();
            this.tabControlProfesor = new System.Windows.Forms.TabControl();
            this.buttonPreguntas = new System.Windows.Forms.Button();
            this.buttonCerrarSesion = new System.Windows.Forms.Button();
            this.fillByToolStrip.SuspendLayout();
            this.tabPageCursos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControlProfesor.SuspendLayout();
            this.SuspendLayout();
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(800, 25);
            this.fillByToolStrip.TabIndex = 1;
            this.fillByToolStrip.Text = "fillByToolStrip";
            this.fillByToolStrip.Visible = false;
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(39, 22);
            this.fillByToolStripButton.Text = "FillBy";
            // 
            // tabPageExamenes
            // 
            this.tabPageExamenes.Location = new System.Drawing.Point(4, 22);
            this.tabPageExamenes.Name = "tabPageExamenes";
            this.tabPageExamenes.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageExamenes.Size = new System.Drawing.Size(553, 240);
            this.tabPageExamenes.TabIndex = 3;
            this.tabPageExamenes.Text = "Examenes";
            this.tabPageExamenes.UseVisualStyleBackColor = true;
            // 
            // tabPageCursos
            // 
            this.tabPageCursos.Controls.Add(this.buttonPreguntas);
            this.tabPageCursos.Controls.Add(this.buttonRefrescar);
            this.tabPageCursos.Controls.Add(this.buttonAgregarCurso);
            this.tabPageCursos.Controls.Add(this.dataGridView1);
            this.tabPageCursos.Location = new System.Drawing.Point(4, 22);
            this.tabPageCursos.Name = "tabPageCursos";
            this.tabPageCursos.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCursos.Size = new System.Drawing.Size(553, 240);
            this.tabPageCursos.TabIndex = 0;
            this.tabPageCursos.Text = "Cursos";
            this.tabPageCursos.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(553, 203);
            this.dataGridView1.TabIndex = 0;
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
            // buttonRefrescar
            // 
            this.buttonRefrescar.Location = new System.Drawing.Point(180, 8);
            this.buttonRefrescar.Name = "buttonRefrescar";
            this.buttonRefrescar.Size = new System.Drawing.Size(75, 23);
            this.buttonRefrescar.TabIndex = 2;
            this.buttonRefrescar.Text = "Refrescar";
            this.buttonRefrescar.UseVisualStyleBackColor = true;
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
            // buttonPreguntas
            // 
            this.buttonPreguntas.Location = new System.Drawing.Point(86, 8);
            this.buttonPreguntas.Name = "buttonPreguntas";
            this.buttonPreguntas.Size = new System.Drawing.Size(88, 23);
            this.buttonPreguntas.TabIndex = 3;
            this.buttonPreguntas.Text = "Ver preguntas";
            this.buttonPreguntas.UseVisualStyleBackColor = true;
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
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCerrarSesion);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.tabControlProfesor);
            this.Name = "InicioProfesor";
            this.Text = "Profesor inicio";
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            this.tabPageCursos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControlProfesor.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
        private System.Windows.Forms.TabPage tabPageExamenes;
        private System.Windows.Forms.TabPage tabPageCursos;
        private System.Windows.Forms.Button buttonPreguntas;
        private System.Windows.Forms.Button buttonRefrescar;
        private System.Windows.Forms.Button buttonAgregarCurso;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabControl tabControlProfesor;
        private System.Windows.Forms.Button buttonCerrarSesion;
    }
}