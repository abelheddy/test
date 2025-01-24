using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace CapaPrecentacion
{
    public partial class PrincipalUsuarios : Form
    {
        public PrincipalUsuarios()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwmd, int wmsg, int wparam, int lparam);

        private void icoachicar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            icoachicar.Visible = false;
            icomaximizar.Visible = true;
        }

        private void icocerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void icominimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void icomaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            icoachicar.Visible = true;
            icomaximizar.Visible = false;
        }
        //mostrar forms dentro del mismo form
        private void abrirformhija(object formhija)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            //declaramos que no es unformulario de primer nivel
            fh.TopLevel = false;
            //le desimos que se acople a todo el dock
            fh.Dock = DockStyle.Fill;
            //y que lo agrege al contenedor
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            //y lo mostramos
            fh.Show();
        }
        private void mostrarusuarioactivo()
        {
            lblnivel.Text = Program.nivel;
            lblnombre.Text = Program.usuario;
        }

        private void PrincipalUsuarios_Load(object sender, EventArgs e)
        {
            mostrarusuarioactivo();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Program.nivel == "administrador")
            {
                abrirformhija(new Usuarios());
            }
            else
            {
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            abrirformhija(new Inscripciones());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            abrirformhija(new Reinscripciones());
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Cerrarsesion cer = new Cerrarsesion();
            cer.Show();
            this.Hide();

        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
