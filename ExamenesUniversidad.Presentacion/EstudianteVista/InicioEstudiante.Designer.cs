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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExamenes)).BeginInit();
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
            this.dataGridViewExamenes.Location = new System.Drawing.Point(12, 42);
            this.dataGridViewExamenes.Name = "dataGridViewExamenes";
            this.dataGridViewExamenes.Size = new System.Drawing.Size(671, 150);
            this.dataGridViewExamenes.TabIndex = 1;
            // 
            // buttonRealizarExamen
            // 
            this.buttonRealizarExamen.Location = new System.Drawing.Point(12, 13);
            this.buttonRealizarExamen.Name = "buttonRealizarExamen";
            this.buttonRealizarExamen.Size = new System.Drawing.Size(75, 23);
            this.buttonRealizarExamen.TabIndex = 2;
            this.buttonRealizarExamen.Text = "Realizar examen";
            this.buttonRealizarExamen.UseVisualStyleBackColor = true;
            // 
            // buttonRefrescar
            // 
            this.buttonRefrescar.Location = new System.Drawing.Point(93, 12);
            this.buttonRefrescar.Name = "buttonRefrescar";
            this.buttonRefrescar.Size = new System.Drawing.Size(75, 23);
            this.buttonRefrescar.TabIndex = 3;
            this.buttonRefrescar.Text = "Refrescar";
            this.buttonRefrescar.UseVisualStyleBackColor = true;
            this.buttonRefrescar.Click += new System.EventHandler(this.ButtonRefrescar_Click);
            // 
            // InicioEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 450);
            this.Controls.Add(this.buttonRefrescar);
            this.Controls.Add(this.buttonRealizarExamen);
            this.Controls.Add(this.dataGridViewExamenes);
            this.Controls.Add(this.buttonCerrarSesion);
            this.Name = "InicioEstudiante";
            this.Text = "Estudiante inicio";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExamenes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCerrarSesion;
        private System.Windows.Forms.DataGridView dataGridViewExamenes;
        private System.Windows.Forms.Button buttonRealizarExamen;
        private System.Windows.Forms.Button buttonRefrescar;
    }
}