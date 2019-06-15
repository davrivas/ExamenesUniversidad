namespace ExamenesUniversidad.Presentacion.ProfesorVista
{
    partial class AgregarPreguntaExamen
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
            this.buttonAgregarPregunta = new System.Windows.Forms.Button();
            this.dataGridViewPreguntas = new System.Windows.Forms.DataGridView();
            this.textBoxPregunta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPreguntas)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAgregarPregunta
            // 
            this.buttonAgregarPregunta.Location = new System.Drawing.Point(219, 10);
            this.buttonAgregarPregunta.Name = "buttonAgregarPregunta";
            this.buttonAgregarPregunta.Size = new System.Drawing.Size(75, 23);
            this.buttonAgregarPregunta.TabIndex = 9;
            this.buttonAgregarPregunta.Text = "Agregar";
            this.buttonAgregarPregunta.UseVisualStyleBackColor = true;
            this.buttonAgregarPregunta.Click += new System.EventHandler(this.ButtonAgregarPregunta_Click);
            // 
            // dataGridViewPreguntas
            // 
            this.dataGridViewPreguntas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPreguntas.Location = new System.Drawing.Point(12, 50);
            this.dataGridViewPreguntas.Name = "dataGridViewPreguntas";
            this.dataGridViewPreguntas.Size = new System.Drawing.Size(720, 278);
            this.dataGridViewPreguntas.TabIndex = 5;
            // 
            // textBoxPregunta
            // 
            this.textBoxPregunta.Location = new System.Drawing.Point(113, 12);
            this.textBoxPregunta.Name = "textBoxPregunta";
            this.textBoxPregunta.Size = new System.Drawing.Size(100, 20);
            this.textBoxPregunta.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Codigo pregunta";
            // 
            // AgregarPreguntaExamen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 339);
            this.Controls.Add(this.textBoxPregunta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonAgregarPregunta);
            this.Controls.Add(this.dataGridViewPreguntas);
            this.Name = "AgregarPreguntaExamen";
            this.Text = "Agregar pregunta examen";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPreguntas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAgregarPregunta;
        private System.Windows.Forms.DataGridView dataGridViewPreguntas;
        private System.Windows.Forms.TextBox textBoxPregunta;
        private System.Windows.Forms.Label label2;
    }
}