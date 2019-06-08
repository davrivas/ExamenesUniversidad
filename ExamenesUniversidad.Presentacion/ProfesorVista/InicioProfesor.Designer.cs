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
            this.tabControlProfesor = new System.Windows.Forms.TabControl();
            this.tabPageCursos = new System.Windows.Forms.TabPage();
            this.tabPageExamenes = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabControlProfesor.SuspendLayout();
            this.tabPageCursos.SuspendLayout();
            this.tabPageExamenes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlProfesor
            // 
            this.tabControlProfesor.Controls.Add(this.tabPageCursos);
            this.tabControlProfesor.Controls.Add(this.tabPageExamenes);
            this.tabControlProfesor.Location = new System.Drawing.Point(13, 13);
            this.tabControlProfesor.Name = "tabControlProfesor";
            this.tabControlProfesor.SelectedIndex = 0;
            this.tabControlProfesor.Size = new System.Drawing.Size(561, 266);
            this.tabControlProfesor.TabIndex = 0;
            // 
            // tabPageCursos
            // 
            this.tabPageCursos.Controls.Add(this.dataGridView1);
            this.tabPageCursos.Location = new System.Drawing.Point(4, 22);
            this.tabPageCursos.Name = "tabPageCursos";
            this.tabPageCursos.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCursos.Size = new System.Drawing.Size(553, 240);
            this.tabPageCursos.TabIndex = 0;
            this.tabPageCursos.Text = "Cursos";
            this.tabPageCursos.UseVisualStyleBackColor = true;
            // 
            // tabPageExamenes
            // 
            this.tabPageExamenes.Controls.Add(this.dataGridView2);
            this.tabPageExamenes.Location = new System.Drawing.Point(4, 22);
            this.tabPageExamenes.Name = "tabPageExamenes";
            this.tabPageExamenes.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageExamenes.Size = new System.Drawing.Size(553, 240);
            this.tabPageExamenes.TabIndex = 1;
            this.tabPageExamenes.Text = "Examenes";
            this.tabPageExamenes.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(553, 240);
            this.dataGridView1.TabIndex = 0;
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
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(553, 240);
            this.dataGridView2.TabIndex = 0;
            // 
            // InicioProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.tabControlProfesor);
            this.Name = "InicioProfesor";
            this.Text = "Profesor inicio";
            this.tabControlProfesor.ResumeLayout(false);
            this.tabPageCursos.ResumeLayout(false);
            this.tabPageExamenes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlProfesor;
        private System.Windows.Forms.TabPage tabPageCursos;
        private System.Windows.Forms.TabPage tabPageExamenes;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}