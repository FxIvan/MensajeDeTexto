using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MensajeDeTexto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMensajeUno_Click(object sender, EventArgs e)
        {
            MessageBox.Show("mensaje", "titulo del mensaje");
        }

        private void btnMensaje2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("mensaje", "titulo del mensaje", MessageBoxButtons.YesNo);
        }

        private void btnMensajeTres_Click(object sender, EventArgs e)
        {
            MessageBox.Show("mensaje", "titulo del mensaje", MessageBoxButtons.YesNo,
MessageBoxIcon.Asterisk);

        }
    }
}
