namespace Interfaz_Grafica_01
{
    public partial class Interf_Graf_01 : Form
    {
        string usuario = "user";
        string password = "password";
        public Interf_Graf_01()
        {
            InitializeComponent();
            this.CenterToScreen();

        }

        private void Interf_Graf_01_Load(object sender, EventArgs e)
        {

        }

        private void btnMensaje_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Este es un mensaje emergente hecho con \nMessageBox.show()");
        }

        private void btn_clic_salir(object sender, EventArgs e)
        {
            //Application.Exit();
            DialogResult resultado = MessageBox.Show(
                                                        "¿Desea salir?",
                                                        "Salir",
                                                        MessageBoxButtons.YesNo,
                                                        MessageBoxIcon.Question
                                                    );

            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void mostrarTexto(object sender, EventArgs e)
        {
            MessageBox.Show(boxTexto.Text);
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            String textoEnviar = boxTexto.Text;
            Interf_Graf_02 ventana2 = new Interf_Graf_02(textoEnviar);
            ventana2.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void login(object sender, EventArgs e)
        {
            string user = textoUsuario.Text;
            string password = textoPassword.Text;

            //string dir = "C:\\Users\\AORUS 15P\\Documents\\programas c#\\Interfaz_Grafica_01\\"+user+".txt";

            if (user.Equals(usuario))
            //if(File.Exists(dir))
            {
                //string contraseñaAverificar = File.ReadAllText(dir);
                if (password.Equals(this.password))
                //if(password.Equals(contraseñaAverificar))
                {
                    MessageBox.Show("Login Exitoso");
                }
                else
                {
                    MessageBox.Show("Constraseña Incorrecta\nIntente de nuevo");
                }
            }
            else
            {
                MessageBox.Show("Usuario Incorrecto");
            }
        }

        private void verPassw_CheckedChanged(object sender, EventArgs e)
        {
            if (!verPassw.Checked)
            {
                textoPassword.PasswordChar = '*';
            }
            else
            {
                textoPassword.PasswordChar = '\0';
            }
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            string user = textoUsuario.Text;
            string password = textoPassword.Text;
            string dir = "C:\\Users\\AORUS 15P\\Documents\\programas c#\\Interfaz_Grafica_01\\" + user + ".txt";
            if (File.Exists(dir))
            { //registro no valido
                MessageBox.Show("Usuario ya registrado");
            }
            else
            {
                File.WriteAllText(dir, password);
                MessageBox.Show("Usuario: " + user + "\nPassword: " + password + "\nREGISTRADO EXITOSAMENTE");
                textoUsuario.Text = "";
                textoPassword.Text = "";
            }

        }
    }
}