namespace ExamenesUniversidad.Presentacion.EstudianteVista
{
    partial class RealizarExamen
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
            this.panelPreguntas = new System.Windows.Forms.Panel();
            this.labelPreguntas = new System.Windows.Forms.Label();
            this.panelRespuestas = new System.Windows.Forms.Panel();
            this.buttonRealizarExamen = new System.Windows.Forms.Button();
            this.panelPreguntas.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPreguntas
            // 
            this.panelPreguntas.AutoScroll = true;
            this.panelPreguntas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPreguntas.Controls.Add(this.labelPreguntas);
            this.panelPreguntas.Location = new System.Drawing.Point(13, 13);
            this.panelPreguntas.Name = "panelPreguntas";
            this.panelPreguntas.Size = new System.Drawing.Size(431, 425);
            this.panelPreguntas.TabIndex = 0;
            // 
            // labelPreguntas
            // 
            this.labelPreguntas.AutoSize = true;
            this.labelPreguntas.Location = new System.Drawing.Point(16, 14);
            this.labelPreguntas.Name = "labelPreguntas";
            this.labelPreguntas.Size = new System.Drawing.Size(0, 13);
            this.labelPreguntas.TabIndex = 0;
            // 
            // panelRespuestas
            // 
            this.panelRespuestas.AutoScroll = true;
            this.panelRespuestas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRespuestas.Location = new System.Drawing.Point(450, 13);
            this.panelRespuestas.Name = "panelRespuestas";
            this.panelRespuestas.Size = new System.Drawing.Size(238, 396);
            this.panelRespuestas.TabIndex = 1;
            // 
            // buttonRealizarExamen
            // 
            this.buttonRealizarExamen.Location = new System.Drawing.Point(521, 415);
            this.buttonRealizarExamen.Name = "buttonRealizarExamen";
            this.buttonRealizarExamen.Size = new System.Drawing.Size(100, 23);
            this.buttonRealizarExamen.TabIndex = 2;
            this.buttonRealizarExamen.Text = "Realizar examen";
            this.buttonRealizarExamen.UseVisualStyleBackColor = true;
            this.buttonRealizarExamen.Click += new System.EventHandler(this.ButtonRealizarExamen_Click);
            // 
            // RealizarExamen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 450);
            this.Controls.Add(this.buttonRealizarExamen);
            this.Controls.Add(this.panelRespuestas);
            this.Controls.Add(this.panelPreguntas);
            this.Name = "RealizarExamen";
            this.Text = "Realizar examen";
            this.panelPreguntas.ResumeLayout(false);
            this.panelPreguntas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPreguntas;
        private System.Windows.Forms.Panel panelRespuestas;
        private System.Windows.Forms.Label labelPreguntas;
        private System.Windows.Forms.Button buttonRealizarExamen;
    }
}