namespace Interfaz_Grafica_01
{
    partial class Interf_Graf_02
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
            lblMensaje = new Label();
            btn_regresar_2_a_1 = new Button();
            SuspendLayout();
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.BackColor = SystemColors.ControlDarkDark;
            lblMensaje.Font = new Font("Sylfaen", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblMensaje.ForeColor = SystemColors.ButtonFace;
            lblMensaje.Location = new Point(19, 21);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(321, 26);
            lblMensaje.TabIndex = 0;
            lblMensaje.Text = "Mensaje Recibido de Ventana 01";
            // 
            // btn_regresar_2_a_1
            // 
            btn_regresar_2_a_1.BackColor = SystemColors.ActiveCaptionText;
            btn_regresar_2_a_1.Font = new Font("Sylfaen", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btn_regresar_2_a_1.ForeColor = SystemColors.ButtonFace;
            btn_regresar_2_a_1.Location = new Point(125, 281);
            btn_regresar_2_a_1.Name = "btn_regresar_2_a_1";
            btn_regresar_2_a_1.Size = new Size(91, 41);
            btn_regresar_2_a_1.TabIndex = 1;
            btn_regresar_2_a_1.Text = "Regresar";
            btn_regresar_2_a_1.UseVisualStyleBackColor = false;
            btn_regresar_2_a_1.Click += btn_regresar_2_a_1_Click;
            // 
            // Interf_Graf_02
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(362, 396);
            Controls.Add(btn_regresar_2_a_1);
            Controls.Add(lblMensaje);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "Interf_Graf_02";
            Text = "Interf_Graf_02";
            Load += Interf_Graf_02_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMensaje;
        private Button btn_regresar_2_a_1;
    }
}