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
using CapaNegocio;
using System.Data.SqlClient;

namespace CapaPrecentacion
{
    public partial class LoginPrincipal : Form
    {
        public LoginPrincipal()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwmd, int wmsg, int wparam, int lparam);

        private void LoginPrincipal_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void LOGIN_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtuser_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtuser_Enter(object sender, EventArgs e)
        {
            if (txtuser.Text == "USUARIO")
            {
                txtuser.Text = "";
                txtuser.ForeColor = Color.LightGray;
            }
        }

        private void txtuser_Leave(object sender, EventArgs e)
        {
            if (txtuser.Text == "")
            {
                txtuser.Text = "USUARIO";
                txtuser.ForeColor = Color.DimGray;
            }
        }

        private void txtpass_Enter(object sender, EventArgs e)
        {
            if (txtpass.Text == "CONTRASEÑA")
            {
                txtpass.Text = "";
                txtpass.ForeColor = Color.LightGray;
                txtpass.UseSystemPasswordChar = true;
            }
        }

        private void txtpass_Leave(object sender, EventArgs e)
        {
            if (txtpass.Text == "")
            {
                txtpass.Text = "CONTRASEÑA";
                txtpass.ForeColor = Color.DimGray;
                txtpass.UseSystemPasswordChar = false;
            }
        }

        private void txtnivel_Enter(object sender, EventArgs e)
        {
            if (txtnivel.Text == "NIVEL")
            {
                txtnivel.Text = "";
                txtnivel.ForeColor = Color.LightGray;

            }
        }

        private void txtnivel_Leave(object sender, EventArgs e)
        {
            if (txtnivel.Text == "")
            {
                txtnivel.Text = "NIVEL";
                txtnivel.ForeColor = Color.DimGray;

            }
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            CNUusuarios objUsuarios = new CNUusuarios();
            SqlDataReader Logear;
            objUsuarios.Usuario = txtuser.Text;
            objUsuarios.Contraseña = txtpass.Text;
            objUsuarios.Nivel = txtnivel.Text;
            if (objUsuarios.Usuario == txtuser.Text)
            {


                laErroruser.Visible = false;
                if (objUsuarios.Contraseña == txtpass.Text)
                {
                    laErrorpass.Visible = false;
                    if (objUsuarios.Nivel == txtnivel.Text)
                    {
                        laErrornivel.Visible = false;
                        Logear = objUsuarios.iniciarsecion();
                        if (Logear.Read() == true)
                        {
                            this.Hide();
                            PrincipalUsuarios pri = new PrincipalUsuarios();
                            Program.nivel = Logear["nivel"].ToString();
                            Program.usuario = Logear["usuario"].ToString();
                            pri.Show();
                        }
                        else
                        {
                            laErrorlogeo.Text = "Usuario, Contraseña o Nivel invalidos";
                            laErrorlogeo.Visible = true;
                            txtpass.Text = "";
                            txtnivel.Text = "NIVEL";
                            txtpass_Leave(null, e);
                            txtuser.Focus();
                        }
                    }
                    else
                    {
                        laErrornivel.Text = objUsuarios.Nivel;
                        laErrornivel.Visible = true;
                    }
                }
                else
                {
                    laErrorpass.Text = objUsuarios.Contraseña;
                    laErrorpass.Visible = true;
                }
            }
            else
            {
                laErroruser.Text = objUsuarios.Usuario;
                laErroruser.Visible = true;
            }
        }

        private void LoginPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btninformacion_Click(object sender, EventArgs e)
        {
            Informacion info = new Informacion();
            info.Show();
        }

        private void linkpass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Contraseña cont = new Contraseña();
            cont.ShowDialog();
        }
    }
}
