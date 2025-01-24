using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaPrecentacion.visualizadordealumnos;
using CapaNegocio;
namespace CapaPrecentacion.visualizadordealumnos
{
    public partial class egresados : Form
    {
        public egresados()
        {
            InitializeComponent();
        }
        private void mostrar()
        {
            CNAlumnos most = new CNAlumnos();
            dataGridView1.DataSource = most.mostraregresados();
        }
        private void egresados_Load(object sender, EventArgs e)
        {
            mostrar();
        }
    }
}
