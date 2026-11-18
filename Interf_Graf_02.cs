using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz_Grafica_01
{
    public partial class Interf_Graf_02 : Form
    {
        public Interf_Graf_02()
        {
            InitializeComponent();
            this.CenterToScreen();
        }
        public Interf_Graf_02(String texto)
        {
            InitializeComponent();
            lblMensaje.Text = "Mensaje Recibido de Ventana 01:\n" + texto;
            this.CenterToScreen();

        }

        private void Interf_Graf_02_Load(object sender, EventArgs e)
        {

        }

        private void btn_regresar_2_a_1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
