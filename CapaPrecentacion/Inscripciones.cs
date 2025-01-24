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
//using System.Net.Mail;

namespace CapaPrecentacion
{
    public partial class Inscripciones : Form
    {
        public Inscripciones()
        {
            InitializeComponent();
        }
        CNAlumnos objetoalu = new CNAlumnos();
        CNTutar objetotutor = new CNTutar();
        private void btnvisualizar_Click(object sender, EventArgs e)
        {
            Visualizar vi = new Visualizar();
            vi.Show();

        }
        private void advertencia() 
        {
            Sinopadres siono = new Sinopadres();
            siono.Show();
        }
        public void ocualtartutro()
        {
            mostraralumno();
            //datos del tutor
            txtidpadrep.Visible = false;
            txtnombrepot.Visible = false;
            txttuapellidop.Visible = false;
            txttuapellidom.Visible = false;
            txtnombrepot.Visible = false;
            txtdomicilio.Visible = false;
            txtcoloniaofrac.Visible = false;
            txtmunicipio.Visible = false;
            txttelefono.Visible = false;
            txtocupacion.Visible = false;
            txtnfolio.Visible = false;
            txtañosprescolar.Visible = false;
            txtotalfamilia.Visible = false;
            txthermanos.Visible = false;
            txtgrado.Visible = false;
            txtnombretupa.Visible = false;
            //datos del tutor
            lblidpadrep.Visible = false;
            lblnombrepot.Visible = false;
            lbltuapellidop.Visible = false;
            lbltuapellidom.Visible = false;
            lblnombrepot.Visible = false;
            lbldomicilio.Visible = false;
            lblcoloniaofrac.Visible = false;
            lblmunicipio.Visible = false;
            lbltelefono.Visible = false;
            lblocupacion.Visible = false;
            lblnfolio.Visible = false;
            lblañosprescolar.Visible = false;
            lblotalfamilia.Visible = false;
            lblhermanos.Visible = false;
            lblgrado.Visible = false;
            lblnombretupa.Visible = false;
        }
        public void mostraralumno() 
        {
            txtapellidom.Visible = true;
            txtapellidop.Visible = true;
            txtcurp.Visible = true;
            txtedad.Visible = true;
            txtfechanacimiento.Visible = true;
            txtidpadre.Visible = true;
            txtmatricula.Visible = true;
            txtnombrecomp.Visible = true;
            txtnombres.Visible = true;
            txtnumero.Visible = true;
            txtsexo.Visible = true;
            //datos de los alumnos labeles
            lblapellidom.Visible = true;
            lblapellidop.Visible = true;
            lblcurp.Visible = true;
            lbledad.Visible = true;
            lblfechanacimiento.Visible = true;
            lblidpadre.Visible = true;
            lblmatricula.Visible = true;
            lblnombrecomp.Visible = true;
            lblnombres.Visible = true;
            lblnumero.Visible = true;
            lblsexo.Visible = true;
        }
        public void limpiaralumno()
        {
            txtapellidom.Clear();
            txtapellidop.Clear();
            txtcurp.Clear();
            txtedad.Clear();
            txtfechanacimiento.Clear();
            txtidpadre.Clear();
            txtmatricula.Clear();
            txtnombrecomp.Clear();
            txtnombres.Clear();
            txtnumero.Clear();
            txtsexo.Clear();
        }
        public void mostrartodo()
        {

            txtapellidom.Visible = true;
            txtapellidop.Visible = true;
            txtcurp.Visible = true;
            txtedad.Visible = true;
            txtfechanacimiento.Visible = true;
            txtidpadre.Visible = true;
            txtmatricula.Visible = true;
            txtnombrecomp.Visible = true;
            txtnombres.Visible = true;
            txtnumero.Visible = true;
            txtsexo.Visible = true;
            //datos del tutor
            txtidpadrep.Visible = true;
            txtnombrepot.Visible = true;
            txttuapellidop.Visible = true;
            txttuapellidom.Visible = true;
            txtnombrepot.Visible = true;
            txtdomicilio.Visible = true;
            txtcoloniaofrac.Visible = true;
            txtmunicipio.Visible = true;
            txttelefono.Visible = true;
            txtocupacion.Visible = true;
            txtnfolio.Visible = true;
            txtañosprescolar.Visible = true;
            txtotalfamilia.Visible = true;
            txthermanos.Visible = true;
            txtgrado.Visible = true;
            txtnombretupa.Visible = true;
            //datos de los alumnos labeles
            lblapellidom.Visible = true;
            lblapellidop.Visible = true;
            lblcurp.Visible = true;
            lbledad.Visible = true;
            lblfechanacimiento.Visible = true;
            lblidpadre.Visible = true;
            lblmatricula.Visible = true;
            lblnombrecomp.Visible = true;
            lblnombres.Visible = true;
            lblnumero.Visible = true;
            lblsexo.Visible = true;
            //datos del tutor
            lblidpadrep.Visible = true;
            lblnombrepot.Visible = true;
            lbltuapellidop.Visible = true;
            lbltuapellidom.Visible = true;
            lblnombrepot.Visible = true;
            lbldomicilio.Visible = true;
            lblcoloniaofrac.Visible = true;
            lblmunicipio.Visible = true;
            lbltelefono.Visible = true;
            lblocupacion.Visible = true;
            lblnfolio.Visible = true;
            lblañosprescolar.Visible = true;
            lblotalfamilia.Visible = true;
            lblhermanos.Visible = true;
            lblgrado.Visible = true;
            lblnombretupa.Visible = true;
        }
        public void texboxs() 
        {
            //datos de los alumnos
            txtapellidom.Visible = false;
            txtapellidop.Visible = false;
            txtcurp.Visible = false;
            txtedad.Visible = false;
            txtfechanacimiento.Visible = false;
            txtidpadre.Visible = false;
            txtmatricula.Visible = false;
            txtnombrecomp.Visible = false;
            txtnombres.Visible = false;
            txtnumero.Visible = false;
            txtsexo.Visible = false;
            //datos del tutor
            txtidpadrep.Visible = false;
            txtnombrepot.Visible = false;
            txttuapellidop.Visible = false;
            txttuapellidom.Visible = false;
            txtnombrepot.Visible = false;
            txtdomicilio.Visible = false;
            txtcoloniaofrac.Visible = false;
            txtmunicipio.Visible = false;
            txttelefono.Visible = false;
            txtocupacion.Visible = false;
            txtnfolio.Visible = false;
            txtañosprescolar.Visible = false;
            txtotalfamilia.Visible = false;
            txthermanos.Visible = false;
            txtgrado.Visible = false;
            txtnombretupa.Visible = false;
        }
        public void ocultarlabeles() 
        {
            //datos de los alumnos
            lblapellidom.Visible = false;
            lblapellidop.Visible = false;
            lblcurp.Visible = false;
            lbledad.Visible = false;
            lblfechanacimiento.Visible = false;
            lblidpadre.Visible = false;
            lblmatricula.Visible = false;
            lblnombrecomp.Visible = false;
            lblnombres.Visible = false;
            lblnumero.Visible = false;
            lblsexo.Visible = false;
            //datos del tutor
            lblidpadrep.Visible = false;
            lblnombrepot.Visible = false;
            lbltuapellidop.Visible = false;
            lbltuapellidom.Visible = false;
            lblnombrepot.Visible = false;
            lbldomicilio.Visible = false;
            lblcoloniaofrac.Visible = false;
            lblmunicipio.Visible = false;
            lbltelefono.Visible = false;
            lblocupacion.Visible = false;
            lblnfolio.Visible = false;
            lblañosprescolar.Visible = false;
            lblotalfamilia.Visible = false;
            lblhermanos.Visible = false;
            lblgrado.Visible = false;
            lblnombretupa.Visible = false;
        }
        private void Inscripciones_Load(object sender, EventArgs e)
        {
            ocultarlabeles();
            texboxs();
            advertenciaoffii();
        }

        private void btninscrippadres_Click(object sender, EventArgs e)
        {
            try
            {
                objetotutor.insertartutor(txtidpadrep.Text,txtnombretupa.Text,txttuapellidop.Text,txttuapellidom.Text,txtnombretupa.Text,txtdomicilio.Text,txtcoloniaofrac.Text,txtmunicipio.Text,txttelefono.Text,txtocupacion.Text,txtnfolio.Text,txtañosprescolar.Text,txtotalfamilia.Text,txthermanos.Text,txtgrado.Text);
                btninscripcion.Enabled = true;
                Inscripcionescompleta incricomple = new Inscripcionescompleta();
                incricomple.Show();
                texboxs();
                advertenciaoffii();
            }
            catch 
            {
                ErrorInscripcionalumno error1 = new ErrorInscripcionalumno();
                error1.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btninscrippadres.Enabled = false;
            btninscripcion.Enabled = true;
            ocualtartutro();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            btninscripcion.Enabled = false;
            btninscrippadres.Enabled = true;
            mostrartodo();
        }
        public void advertenciaoffii() 
        {
            advertenciaoffi adver = new advertenciaoffi();
            adver.Show();
        }

        private void btninscripcion_Click(object sender, EventArgs e)
        {
            try
            {
                objetoalu.insertaralumnos(txtnumero.Text,txtmatricula.Text,txtidpadre.Text,txtnombrecomp.Text,txtapellidop.Text,txtapellidom.Text,txtnombres.Text,txtsexo.Text,txtfechanacimiento.Text,txtedad.Text,txtcurp.Text);
                Inscripcionescompleta incricomple = new Inscripcionescompleta();
                incricomple.Show();
                btns();
                limpiaralumno();
                texboxs();
                advertenciaoffii();
            }catch
            {
                ErrorInscripcionalumno error1 = new ErrorInscripcionalumno();
                error1.Show();
            }
        }
        public void btns() 
        {
            btninscrippadres.Enabled = false;
            btninscripcion.Enabled = false;
        }

        private void btnmodificacion_Click(object sender, EventArgs e)
        {

        }

        private void btnbaja_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
