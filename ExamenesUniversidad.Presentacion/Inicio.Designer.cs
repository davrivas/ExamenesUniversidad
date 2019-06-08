namespace ExamenesUniversidad.Presentacion
{
    partial class Inicio
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
            this.comboBoxRol = new System.Windows.Forms.ComboBox();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.textBoxClave = new System.Windows.Forms.TextBox();
            this.labelClave = new System.Windows.Forms.Label();
            this.buttonIniciar = new System.Windows.Forms.Button();
            this.buttonRegistrar = new System.Windows.Forms.Button();
            this.textBoxUsuarioReg = new System.Windows.Forms.TextBox();
            this.labelUsuarioReg = new System.Windows.Forms.Label();
            this.textBoxNombres = new System.Windows.Forms.TextBox();
            this.labelNombres = new System.Windows.Forms.Label();
            this.comboBoxRegistro = new System.Windows.Forms.ComboBox();
            this.textBoxClaveReg = new System.Windows.Forms.TextBox();
            this.labelClaveReg = new System.Windows.Forms.Label();
            this.textBoxApellidos = new System.Windows.Forms.TextBox();
            this.labelApellidos = new System.Windows.Forms.Label();
            this.textBoxIdentificacion = new System.Windows.Forms.TextBox();
            this.labelIdentificacion = new System.Windows.Forms.Label();
            this.textBoxConfirmar = new System.Windows.Forms.TextBox();
            this.labelConfirmar = new System.Windows.Forms.Label();
            this.panelReg = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxRol
            // 
            this.comboBoxRol.FormattingEnabled = true;
            this.comboBoxRol.Items.AddRange(new object[] {
            "Estudiante",
            "Profesor"});
            this.comboBoxRol.Location = new System.Drawing.Point(12, 24);
            this.comboBoxRol.Name = "comboBoxRol";
            this.comboBoxRol.Size = new System.Drawing.Size(180, 21);
            this.comboBoxRol.TabIndex = 0;
            this.comboBoxRol.Text = "Seleccione rol";
            // 
            // labelTitulo
            // 
            this.labelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(13, 9);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(625, 23);
            this.labelTitulo.TabIndex = 1;
            this.labelTitulo.Text = "Examenes";
            this.labelTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Location = new System.Drawing.Point(12, 53);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(43, 13);
            this.labelUsuario.TabIndex = 2;
            this.labelUsuario.Text = "Usuario";
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.Location = new System.Drawing.Point(12, 69);
            this.textBoxUsuario.MaxLength = 16;
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(180, 20);
            this.textBoxUsuario.TabIndex = 3;
            // 
            // textBoxClave
            // 
            this.textBoxClave.Location = new System.Drawing.Point(12, 108);
            this.textBoxClave.MaxLength = 16;
            this.textBoxClave.Name = "textBoxClave";
            this.textBoxClave.PasswordChar = '*';
            this.textBoxClave.Size = new System.Drawing.Size(180, 20);
            this.textBoxClave.TabIndex = 5;
            // 
            // labelClave
            // 
            this.labelClave.AutoSize = true;
            this.labelClave.Location = new System.Drawing.Point(12, 92);
            this.labelClave.Name = "labelClave";
            this.labelClave.Size = new System.Drawing.Size(34, 13);
            this.labelClave.TabIndex = 4;
            this.labelClave.Text = "Clave";
            // 
            // buttonIniciar
            // 
            this.buttonIniciar.Location = new System.Drawing.Point(12, 135);
            this.buttonIniciar.Name = "buttonIniciar";
            this.buttonIniciar.Size = new System.Drawing.Size(180, 23);
            this.buttonIniciar.TabIndex = 6;
            this.buttonIniciar.Text = "Iniciar";
            this.buttonIniciar.UseVisualStyleBackColor = true;
            this.buttonIniciar.Click += new System.EventHandler(this.ButtonIniciar_Click);
            // 
            // buttonRegistrar
            // 
            this.buttonRegistrar.Location = new System.Drawing.Point(272, 194);
            this.buttonRegistrar.Name = "buttonRegistrar";
            this.buttonRegistrar.Size = new System.Drawing.Size(180, 23);
            this.buttonRegistrar.TabIndex = 12;
            this.buttonRegistrar.Text = "Registrarse";
            this.buttonRegistrar.UseVisualStyleBackColor = true;
            this.buttonRegistrar.Click += new System.EventHandler(this.ButtonRegistrar_Click);
            // 
            // textBoxUsuarioReg
            // 
            this.textBoxUsuarioReg.Location = new System.Drawing.Point(272, 157);
            this.textBoxUsuarioReg.MaxLength = 16;
            this.textBoxUsuarioReg.Name = "textBoxUsuarioReg";
            this.textBoxUsuarioReg.Size = new System.Drawing.Size(180, 20);
            this.textBoxUsuarioReg.TabIndex = 11;
            // 
            // labelUsuarioReg
            // 
            this.labelUsuarioReg.AutoSize = true;
            this.labelUsuarioReg.Location = new System.Drawing.Point(272, 141);
            this.labelUsuarioReg.Name = "labelUsuarioReg";
            this.labelUsuarioReg.Size = new System.Drawing.Size(96, 13);
            this.labelUsuarioReg.TabIndex = 10;
            this.labelUsuarioReg.Text = "Nombre de usuario";
            // 
            // textBoxNombres
            // 
            this.textBoxNombres.Location = new System.Drawing.Point(272, 118);
            this.textBoxNombres.MaxLength = 25;
            this.textBoxNombres.Name = "textBoxNombres";
            this.textBoxNombres.Size = new System.Drawing.Size(180, 20);
            this.textBoxNombres.TabIndex = 9;
            // 
            // labelNombres
            // 
            this.labelNombres.AutoSize = true;
            this.labelNombres.Location = new System.Drawing.Point(272, 102);
            this.labelNombres.Name = "labelNombres";
            this.labelNombres.Size = new System.Drawing.Size(49, 13);
            this.labelNombres.TabIndex = 8;
            this.labelNombres.Text = "Nombres";
            // 
            // comboBoxRegistro
            // 
            this.comboBoxRegistro.FormattingEnabled = true;
            this.comboBoxRegistro.Items.AddRange(new object[] {
            "Estudiante",
            "Profesor"});
            this.comboBoxRegistro.Location = new System.Drawing.Point(272, 73);
            this.comboBoxRegistro.Name = "comboBoxRegistro";
            this.comboBoxRegistro.Size = new System.Drawing.Size(180, 21);
            this.comboBoxRegistro.TabIndex = 7;
            this.comboBoxRegistro.Text = "Seleccione rol";
            // 
            // textBoxClaveReg
            // 
            this.textBoxClaveReg.Location = new System.Drawing.Point(458, 157);
            this.textBoxClaveReg.MaxLength = 16;
            this.textBoxClaveReg.Name = "textBoxClaveReg";
            this.textBoxClaveReg.PasswordChar = '*';
            this.textBoxClaveReg.Size = new System.Drawing.Size(180, 20);
            this.textBoxClaveReg.TabIndex = 17;
            // 
            // labelClaveReg
            // 
            this.labelClaveReg.AutoSize = true;
            this.labelClaveReg.Location = new System.Drawing.Point(458, 141);
            this.labelClaveReg.Name = "labelClaveReg";
            this.labelClaveReg.Size = new System.Drawing.Size(34, 13);
            this.labelClaveReg.TabIndex = 16;
            this.labelClaveReg.Text = "Clave";
            // 
            // textBoxApellidos
            // 
            this.textBoxApellidos.Location = new System.Drawing.Point(458, 118);
            this.textBoxApellidos.MaxLength = 45;
            this.textBoxApellidos.Name = "textBoxApellidos";
            this.textBoxApellidos.Size = new System.Drawing.Size(180, 20);
            this.textBoxApellidos.TabIndex = 15;
            // 
            // labelApellidos
            // 
            this.labelApellidos.AutoSize = true;
            this.labelApellidos.Location = new System.Drawing.Point(458, 102);
            this.labelApellidos.Name = "labelApellidos";
            this.labelApellidos.Size = new System.Drawing.Size(49, 13);
            this.labelApellidos.TabIndex = 14;
            this.labelApellidos.Text = "Apellidos";
            // 
            // textBoxIdentificacion
            // 
            this.textBoxIdentificacion.Location = new System.Drawing.Point(458, 73);
            this.textBoxIdentificacion.MaxLength = 10;
            this.textBoxIdentificacion.Name = "textBoxIdentificacion";
            this.textBoxIdentificacion.Size = new System.Drawing.Size(180, 20);
            this.textBoxIdentificacion.TabIndex = 19;
            // 
            // labelIdentificacion
            // 
            this.labelIdentificacion.AutoSize = true;
            this.labelIdentificacion.Location = new System.Drawing.Point(458, 57);
            this.labelIdentificacion.Name = "labelIdentificacion";
            this.labelIdentificacion.Size = new System.Drawing.Size(70, 13);
            this.labelIdentificacion.TabIndex = 18;
            this.labelIdentificacion.Text = "Identificación";
            // 
            // textBoxConfirmar
            // 
            this.textBoxConfirmar.Location = new System.Drawing.Point(458, 196);
            this.textBoxConfirmar.MaxLength = 16;
            this.textBoxConfirmar.Name = "textBoxConfirmar";
            this.textBoxConfirmar.PasswordChar = '*';
            this.textBoxConfirmar.Size = new System.Drawing.Size(180, 20);
            this.textBoxConfirmar.TabIndex = 21;
            // 
            // labelConfirmar
            // 
            this.labelConfirmar.AutoSize = true;
            this.labelConfirmar.Location = new System.Drawing.Point(458, 180);
            this.labelConfirmar.Name = "labelConfirmar";
            this.labelConfirmar.Size = new System.Drawing.Size(80, 13);
            this.labelConfirmar.TabIndex = 20;
            this.labelConfirmar.Text = "Confirmar clave";
            // 
            // panelReg
            // 
            this.panelReg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelReg.Location = new System.Drawing.Point(261, 47);
            this.panelReg.Name = "panelReg";
            this.panelReg.Size = new System.Drawing.Size(398, 200);
            this.panelReg.TabIndex = 22;
            this.panelReg.Tag = "Registrarse";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.comboBoxRol);
            this.panel1.Controls.Add(this.labelUsuario);
            this.panel1.Controls.Add(this.textBoxUsuario);
            this.panel1.Controls.Add(this.labelClave);
            this.panel1.Controls.Add(this.textBoxClave);
            this.panel1.Controls.Add(this.buttonIniciar);
            this.panel1.Location = new System.Drawing.Point(12, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(206, 180);
            this.panel1.TabIndex = 23;
            this.panel1.Tag = "Registrarse";
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 262);
            this.Controls.Add(this.textBoxConfirmar);
            this.Controls.Add(this.labelConfirmar);
            this.Controls.Add(this.textBoxIdentificacion);
            this.Controls.Add(this.labelIdentificacion);
            this.Controls.Add(this.textBoxClaveReg);
            this.Controls.Add(this.labelClaveReg);
            this.Controls.Add(this.textBoxApellidos);
            this.Controls.Add(this.labelApellidos);
            this.Controls.Add(this.buttonRegistrar);
            this.Controls.Add(this.textBoxUsuarioReg);
            this.Controls.Add(this.labelUsuarioReg);
            this.Controls.Add(this.textBoxNombres);
            this.Controls.Add(this.labelNombres);
            this.Controls.Add(this.comboBoxRegistro);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.panelReg);
            this.Controls.Add(this.panel1);
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxRol;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.TextBox textBoxClave;
        private System.Windows.Forms.Label labelClave;
        private System.Windows.Forms.Button buttonIniciar;
        private System.Windows.Forms.Button buttonRegistrar;
        private System.Windows.Forms.TextBox textBoxUsuarioReg;
        private System.Windows.Forms.Label labelUsuarioReg;
        private System.Windows.Forms.TextBox textBoxNombres;
        private System.Windows.Forms.Label labelNombres;
        private System.Windows.Forms.ComboBox comboBoxRegistro;
        private System.Windows.Forms.TextBox textBoxClaveReg;
        private System.Windows.Forms.Label labelClaveReg;
        private System.Windows.Forms.TextBox textBoxApellidos;
        private System.Windows.Forms.Label labelApellidos;
        private System.Windows.Forms.TextBox textBoxIdentificacion;
        private System.Windows.Forms.Label labelIdentificacion;
        private System.Windows.Forms.TextBox textBoxConfirmar;
        private System.Windows.Forms.Label labelConfirmar;
        private System.Windows.Forms.Panel panelReg;
        private System.Windows.Forms.Panel panel1;
    }
}

