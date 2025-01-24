using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
namespace CapaPrecentacion
{
    public partial class Contraseña : Form
    {
        public Contraseña()
        {
            InitializeComponent();
        }
        CNUusuarios obc = new CNUusuarios();
        private void button1_Click(object sender, EventArgs e)
        {
            txtmensaje.Text = obc.recuperardatos(txtusuario.Text);

        }
    }
}
