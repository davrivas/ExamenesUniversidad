namespace ExamenesUniversidad.Presentacion.ProfesorVista
{
    partial class AgregarExamen
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
            this.labelCodigoCurso = new System.Windows.Forms.Label();
            this.textBoxCodigoCurso = new System.Windows.Forms.TextBox();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.tabControlExamen = new System.Windows.Forms.TabControl();
            this.tabPageEscoger = new System.Windows.Forms.TabPage();
            this.dataGridViewCursoPreguntas = new System.Windows.Forms.DataGridView();
            this.checkedListBoxPreguntas = new System.Windows.Forms.CheckedListBox();
            this.tabPageAlAzar = new System.Windows.Forms.TabPage();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tabControlExamen.SuspendLayout();
            this.tabPageEscoger.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCursoPreguntas)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCodigoCurso
            // 
            this.labelCodigoCurso.AutoSize = true;
            this.labelCodigoCurso.Location = new System.Drawing.Point(13, 13);
            this.labelCodigoCurso.Name = "labelCodigoCurso";
            this.labelCodigoCurso.Size = new System.Drawing.Size(69, 13);
            this.labelCodigoCurso.TabIndex = 0;
            this.labelCodigoCurso.Text = "Código curso";
            // 
            // textBoxCodigoCurso
            // 
            this.textBoxCodigoCurso.Location = new System.Drawing.Point(89, 13);
            this.textBoxCodigoCurso.Name = "textBoxCodigoCurso";
            this.textBoxCodigoCurso.Size = new System.Drawing.Size(100, 20);
            this.textBoxCodigoCurso.TabIndex = 1;
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(196, 13);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscar.TabIndex = 2;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.ButtonBuscar_Click);
            // 
            // tabControlExamen
            // 
            this.tabControlExamen.Controls.Add(this.tabPageEscoger);
            this.tabControlExamen.Controls.Add(this.tabPageAlAzar);
            this.tabControlExamen.Location = new System.Drawing.Point(16, 53);
            this.tabControlExamen.Name = "tabControlExamen";
            this.tabControlExamen.SelectedIndex = 0;
            this.tabControlExamen.Size = new System.Drawing.Size(678, 193);
            this.tabControlExamen.TabIndex = 4;
            // 
            // tabPageEscoger
            // 
            this.tabPageEscoger.AutoScroll = true;
            this.tabPageEscoger.Controls.Add(this.dataGridViewCursoPreguntas);
            this.tabPageEscoger.Controls.Add(this.checkedListBoxPreguntas);
            this.tabPageEscoger.Location = new System.Drawing.Point(4, 22);
            this.tabPageEscoger.Name = "tabPageEscoger";
            this.tabPageEscoger.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEscoger.Size = new System.Drawing.Size(670, 167);
            this.tabPageEscoger.TabIndex = 0;
            this.tabPageEscoger.Text = "Escoger preguntas";
            this.tabPageEscoger.UseVisualStyleBackColor = true;
            // 
            // dataGridViewCursoPreguntas
            // 
            this.dataGridViewCursoPreguntas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCursoPreguntas.Location = new System.Drawing.Point(176, 7);
            this.dataGridViewCursoPreguntas.Name = "dataGridViewCursoPreguntas";
            this.dataGridViewCursoPreguntas.Size = new System.Drawing.Size(488, 150);
            this.dataGridViewCursoPreguntas.TabIndex = 1;
            // 
            // checkedListBoxPreguntas
            // 
            this.checkedListBoxPreguntas.FormattingEnabled = true;
            this.checkedListBoxPreguntas.Location = new System.Drawing.Point(6, 6);
            this.checkedListBoxPreguntas.Name = "checkedListBoxPreguntas";
            this.checkedListBoxPreguntas.Size = new System.Drawing.Size(163, 154);
            this.checkedListBoxPreguntas.TabIndex = 0;
            // 
            // tabPageAlAzar
            // 
            this.tabPageAlAzar.AutoScroll = true;
            this.tabPageAlAzar.Location = new System.Drawing.Point(4, 22);
            this.tabPageAlAzar.Name = "tabPageAlAzar";
            this.tabPageAlAzar.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAlAzar.Size = new System.Drawing.Size(670, 167);
            this.tabPageAlAzar.TabIndex = 1;
            this.tabPageAlAzar.Text = "Al azar";
            this.tabPageAlAzar.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(16, 252);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // AgregarExamen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 352);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.tabControlExamen);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.textBoxCodigoCurso);
            this.Controls.Add(this.labelCodigoCurso);
            this.Name = "AgregarExamen";
            this.Text = "AgregarExamen";
            this.tabControlExamen.ResumeLayout(false);
            this.tabPageEscoger.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCursoPreguntas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCodigoCurso;
        private System.Windows.Forms.TextBox textBoxCodigoCurso;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.TabControl tabControlExamen;
        private System.Windows.Forms.TabPage tabPageEscoger;
        private System.Windows.Forms.TabPage tabPageAlAzar;
        private System.Windows.Forms.CheckedListBox checkedListBoxPreguntas;
        private System.Windows.Forms.DataGridView dataGridViewCursoPreguntas;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}