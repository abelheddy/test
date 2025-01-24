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
using System.Runtime.InteropServices;

namespace CapaPrecentacion.visualizadordealumnos
{
    public partial class segundo : Form
    {
        public segundo()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwmd, int wmsg, int wparam, int lparam);

        private void mostrar() 
        {
            CNAlumnos segundo = new CNAlumnos();
            dataGridView1.DataSource = segundo.mostrarsegundo();
        }
        private void segundo_Load(object sender, EventArgs e)
        {
            mostrar();
        }
    }
}
