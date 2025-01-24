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
    public partial class Sinopadres : Form
    {
        public Sinopadres()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwmd, int wmsg, int wparam, int lparam);

        //public void mostrartodo()
        //{
        //    Inscripciones incri2 = new Inscripciones();
        //    incri2.txtapellidom.Visible = true;
        //    incri2.txtapellidop.Visible = true;
        //    incri2.txtcurp.Visible = true;
        //    incri2.txtedad.Visible = true;
        //    incri2.txtfechanacimiento.Visible = true;
        //    incri2.txtidpadre.Visible = true;
        //    incri2.txtmatricula.Visible = true;
        //    incri2.txtnombrecomp.Visible = true;
        //    incri2.txtnombres.Visible = true;
        //    incri2.txtnumero.Visible = true;
        //    incri2.txtsexo.Visible = true;
        //    //datos del tutor
        //    incri2.txtidpadrep.Visible = true;
        //    incri2.txtnombrepot.Visible = true;
        //    incri2.txttuapellidop.Visible = true;
        //    incri2.txttuapellidom.Visible = true;
        //    incri2.txtnombrepot.Visible = true;
        //    incri2.txtdomicilio.Visible = true;
        //    incri2.txtcoloniaofrac.Visible = true;
        //    incri2.txtmunicipio.Visible = true;
        //    incri2.txttelefono.Visible = true;
        //    incri2.txtocupacion.Visible = true;
        //    incri2.txtnfolio.Visible = true;
        //    incri2.txtañosprescolar.Visible = true;
        //    incri2.txtotalfamilia.Visible = true;
        //    incri2.txthermanos.Visible = true;
        //    incri2.txtgrado.Visible = true;
        //    incri2.txtnombretupa.Visible = true;
        //}
        //public void ocualtartutro()
        //{
        //    Inscripciones incri = new Inscripciones();
        //    incri.txtapellidom.Visible = true;
        //    incri.txtapellidop.Visible = true;
        //    incri.txtcurp.Visible = true;
        //    incri.txtedad.Visible = true;
        //    incri.txtfechanacimiento.Visible = true;
        //    incri.txtidpadre.Visible = true;
        //    incri.txtmatricula.Visible = true;
        //    incri.txtnombrecomp.Visible = true;
        //    incri.txtnombres.Visible = true;
        //    incri.txtnumero.Visible = true;
        //    incri.txtsexo.Visible = true;
        //    //datos del tutor
        //    incri.txtidpadrep.Visible = false;
        //    incri.txtnombrepot.Visible = false;
        //    incri.txttuapellidop.Visible = false;
        //    incri.txttuapellidom.Visible = false;
        //    incri.txtnombrepot.Visible = false;
        //    incri.txtdomicilio.Visible = false;
        //    incri.txtcoloniaofrac.Visible = false;
        //    incri.txtmunicipio.Visible = false;
        //    incri.txttelefono.Visible = false;
        //    incri.txtocupacion.Visible = false;
        //    incri.txtnfolio.Visible = false;
        //    incri.txtañosprescolar.Visible = false;
        //    incri.txtotalfamilia.Visible = false;
        //    incri.txthermanos.Visible = false;
        //    incri.txtgrado.Visible = false;
        //    incri.txtnombretupa.Visible = false;
        //}
        private void button2_Click(object sender, EventArgs e)
        {
            //ocualtartutro();
            //this.Hide();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //mostrartodo();
            //this.Hide();
            
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
