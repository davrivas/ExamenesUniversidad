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
            this.buttonRealizarExamen.Location = new System.Drawing.Point(204, 11);
            this.buttonRealizarExamen.Name = "buttonRealizarExamen";
            this.buttonRealizarExamen.Size = new System.Drawing.Size(104, 23);
            this.buttonRealizarExamen.TabIndex = 2;
            this.buttonRealizarExamen.Text = "Realizar examen";
            this.buttonRealizarExamen.UseVisualStyleBackColor = true;
            this.buttonRealizarExamen.Click += new System.EventHandler(this.ButtonRealizarExamen_Click);
            // 
            // buttonRefrescar
            // 
            this.buttonRefrescar.Location = new System.Drawing.Point(314, 11);
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
            this.labelCodigoExamen.Location = new System.Drawing.Point(12, 17);
            this.labelCodigoExamen.Name = "labelCodigoExamen";
            this.labelCodigoExamen.Size = new System.Drawing.Size(80, 13);
            this.labelCodigoExamen.TabIndex = 4;
            this.labelCodigoExamen.Text = "Código examen";
            // 
            // textBoxCodigoExamen
            // 
            this.textBoxCodigoExamen.Location = new System.Drawing.Point(98, 14);
            this.textBoxCodigoExamen.Name = "textBoxCodigoExamen";
            this.textBoxCodigoExamen.Size = new System.Drawing.Size(100, 20);
            this.textBoxCodigoExamen.TabIndex = 5;
            // 
            // InicioEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 450);
            this.Controls.Add(this.textBoxCodigoExamen);
            this.Controls.Add(this.labelCodigoExamen);
            this.Controls.Add(this.buttonRefrescar);
            this.Controls.Add(this.buttonRealizarExamen);
            this.Controls.Add(this.dataGridViewExamenes);
            this.Controls.Add(this.buttonCerrarSesion);
            this.Name = "InicioEstudiante";
            this.Text = "Estudiante inicio";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExamenes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCerrarSesion;
        private System.Windows.Forms.DataGridView dataGridViewExamenes;
        private System.Windows.Forms.Button buttonRealizarExamen;
        private System.Windows.Forms.Button buttonRefrescar;
        private System.Windows.Forms.Label labelCodigoExamen;
        private System.Windows.Forms.TextBox textBoxCodigoExamen;
    }
}