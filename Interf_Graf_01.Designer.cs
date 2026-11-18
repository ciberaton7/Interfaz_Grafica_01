namespace Interfaz_Grafica_01
{
    partial class Interf_Graf_01
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnMensaje = new Button();
            btnSalir = new Button();
            boxTexto = new TextBox();
            label1 = new Label();
            button2 = new Button();
            btnEnviar = new Button();
            label2 = new Label();
            label3 = new Label();
            textoUsuario = new TextBox();
            textoPassword = new TextBox();
            button1 = new Button();
            verPassw = new CheckBox();
            btnRegistro = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // btnMensaje
            // 
            btnMensaje.BackColor = Color.DimGray;
            btnMensaje.FlatStyle = FlatStyle.Popup;
            btnMensaje.Font = new Font("Sylfaen", 10.2F, FontStyle.Italic, GraphicsUnit.Point);
            btnMensaje.ForeColor = SystemColors.ButtonFace;
            btnMensaje.Location = new Point(12, 366);
            btnMensaje.Name = "btnMensaje";
            btnMensaje.Size = new Size(235, 72);
            btnMensaje.TabIndex = 0;
            btnMensaje.Text = "Presiona acá para un mensaje!";
            btnMensaje.UseVisualStyleBackColor = false;
            btnMensaje.Click += btnMensaje_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.Transparent;
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnSalir.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Sylfaen", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnSalir.Location = new Point(707, 392);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(81, 46);
            btnSalir.TabIndex = 1;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btn_clic_salir;
            // 
            // boxTexto
            // 
            boxTexto.Location = new Point(12, 57);
            boxTexto.Name = "boxTexto";
            boxTexto.Size = new Size(235, 27);
            boxTexto.TabIndex = 2;
            boxTexto.Text = "Escriba su Texto acá";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 34);
            label1.Name = "label1";
            label1.Size = new Size(112, 20);
            label1.TabIndex = 3;
            label1.Text = "Texto a Mostrar";
            // 
            // button2
            // 
            button2.BackColor = Color.DimGray;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Sylfaen", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ButtonFace;
            button2.Location = new Point(12, 99);
            button2.Name = "button2";
            button2.Size = new Size(235, 30);
            button2.TabIndex = 4;
            button2.Text = "Presione para obtener el texto";
            button2.UseVisualStyleBackColor = false;
            button2.Click += mostrarTexto;
            // 
            // btnEnviar
            // 
            btnEnviar.BackColor = Color.DimGray;
            btnEnviar.FlatStyle = FlatStyle.Popup;
            btnEnviar.Font = new Font("Sylfaen", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnEnviar.ForeColor = SystemColors.ButtonFace;
            btnEnviar.Location = new Point(12, 152);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(235, 53);
            btnEnviar.TabIndex = 5;
            btnEnviar.Text = "Pasar Texto a Otra Ventana";
            btnEnviar.UseVisualStyleBackColor = false;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(403, 34);
            label2.Name = "label2";
            label2.Size = new Size(84, 28);
            label2.TabIndex = 6;
            label2.Text = "Usuario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(403, 134);
            label3.Name = "label3";
            label3.Size = new Size(118, 28);
            label3.TabIndex = 7;
            label3.Text = "Contraseña";
            label3.Click += label3_Click;
            // 
            // textoUsuario
            // 
            textoUsuario.Location = new Point(403, 65);
            textoUsuario.Name = "textoUsuario";
            textoUsuario.Size = new Size(266, 27);
            textoUsuario.TabIndex = 8;
            // 
            // textoPassword
            // 
            textoPassword.Location = new Point(403, 165);
            textoPassword.Name = "textoPassword";
            textoPassword.PasswordChar = '*';
            textoPassword.Size = new Size(266, 27);
            textoPassword.TabIndex = 9;
            // 
            // button1
            // 
            button1.BackColor = Color.WhiteSmoke;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point);
            button1.Location = new Point(557, 215);
            button1.Name = "button1";
            button1.Size = new Size(112, 67);
            button1.TabIndex = 10;
            button1.Text = "Iniciar Sesión";
            button1.UseVisualStyleBackColor = false;
            button1.Click += login;
            // 
            // verPassw
            // 
            verPassw.AutoSize = true;
            verPassw.Location = new Point(680, 162);
            verPassw.Name = "verPassw";
            verPassw.Size = new Size(117, 24);
            verPassw.TabIndex = 11;
            verPassw.Text = "Ver Password";
            verPassw.UseVisualStyleBackColor = true;
            verPassw.CheckedChanged += verPassw_CheckedChanged;
            // 
            // btnRegistro
            // 
            btnRegistro.BackColor = Color.WhiteSmoke;
            btnRegistro.FlatStyle = FlatStyle.Popup;
            btnRegistro.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point);
            btnRegistro.Location = new Point(403, 215);
            btnRegistro.Name = "btnRegistro";
            btnRegistro.Size = new Size(112, 67);
            btnRegistro.TabIndex = 12;
            btnRegistro.Text = "Registrar Usuario";
            btnRegistro.UseVisualStyleBackColor = false;
            btnRegistro.Click += btnRegistro_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.FlatAppearance.BorderColor = Color.White;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button3.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(445, 337);
            button3.Name = "button3";
            button3.Size = new Size(224, 80);
            button3.TabIndex = 13;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = false;
            // 
            // Interf_Graf_01
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(btnRegistro);
            Controls.Add(verPassw);
            Controls.Add(button1);
            Controls.Add(textoPassword);
            Controls.Add(textoUsuario);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnEnviar);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(boxTexto);
            Controls.Add(btnSalir);
            Controls.Add(btnMensaje);
            Name = "Interf_Graf_01";
            Text = "Titulo en Propiedades";
            Load += Interf_Graf_01_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnMensaje;
        private Button btnSalir;
        private TextBox boxTexto;
        private Label label1;
        private Button button2;
        private Button btnEnviar;
        private Label label2;
        private Label label3;
        private TextBox textoUsuario;
        private TextBox textoPassword;
        private Button button1;
        private CheckBox verPassw;
        private Button btnRegistro;
        internal Button button3;
    }
}