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
using CapaPrecentacion.visualizadordealumnos;

namespace CapaPrecentacion
{
    public partial class Reinscripciones : Form
    {
        public Reinscripciones()
        {
            InitializeComponent();
        }

        CNAlumnos objetoalu = new CNAlumnos();

        private void desabilitar() {
            btn12.Enabled = false;
            btn23.Enabled = false;
            btn34.Enabled = false;
            btn45.Enabled = false;
            btn56.Enabled = false;
        }

        private void Reinscripciones_Load(object sender, EventArgs e)
        {
            desabilitar();
        }

        private void btn12_Click(object sender, EventArgs e)
        {
            try{
                objetoalu.copiaralmunos();
                Resinscritosaviso echo = new Resinscritosaviso();
                echo.Show();
                desabilitar();
                try 
                { 
                    objetoalu.eliminarprimero();
                    segundo visegundo = new segundo();
                    visegundo.Show();
                }
                catch (Exception exc)
                {
                    //eliminacion de datos dela tabla de primero
                    ERRORCRITICOREINSCRIPCIONES errorborrar = new ERRORCRITICOREINSCRIPCIONES();
                    errorborrar.Show();
                    //soluciones posibles
                }
            }catch
            {
                //advertencia de error
                Errornoreinscrito noreins = new Errornoreinscrito();
                noreins.Show();
            }
        }

        private void btnegresados_Click(object sender, EventArgs e)
        {
            try
            {
                objetoalu.coiardesextoegresados();
                AdvertenciaEgresados exito = new AdvertenciaEgresados();
                exito.Show();
                btn56.Enabled = true;
                egresados egre = new egresados();
                egre.Show();
                try 
                {
                    objetoalu.eliminarsexto();
                }
                catch (Exception exc)
                {
                    //eliminacion de datos dela tabla de sexto
                    ERRORCRITICOREINSCRIPCIONES errorborrar = new ERRORCRITICOREINSCRIPCIONES();
                    errorborrar.Show();
                    //soluciones posibles

                }
            }
            catch 
            {
                Errornoreinscrito noreins= new Errornoreinscrito();
                noreins.Show();
            }
        }

        private void btn56_Click(object sender, EventArgs e)
        {
            try
            {
                objetoalu.copiardequintosexto();
                Resinscritosaviso echo = new Resinscritosaviso();
                echo.Show();
                btn45.Enabled = true;
                sexto mostrasext = new sexto();
                mostrasext.Show();
                try 
                {
                    objetoalu.eliminarquinto();
                }
                catch (Exception exc)
                {
                    //eliminacion de datos dela tabla de quinto
                    ERRORCRITICOREINSCRIPCIONES errorborrar = new ERRORCRITICOREINSCRIPCIONES();
                    errorborrar.Show();
                    //soluciones posibles
                }
            }
            catch 
            {
                Errornoreinscrito noreins = new Errornoreinscrito();
                noreins.Show();
            }
        }

        private void btn45_Click(object sender, EventArgs e)
        {
            try
            {
                objetoalu.copiardecuartoquinto();
                Resinscritosaviso echo = new Resinscritosaviso();
                echo.Show();
                btn34.Enabled = true;
                try 
                {
                    objetoalu.eliminarcuarto();
                }
                catch (Exception exc)
                {
                    //eliminacion de datos dela tabla de cuarto
                    ERRORCRITICOREINSCRIPCIONES errorborrar = new ERRORCRITICOREINSCRIPCIONES();
                    errorborrar.Show();
                    //soluciones posibles
                }
            }
            catch 
            {
                Errornoreinscrito noreins = new Errornoreinscrito();
                noreins.Show();
            }
        }

        private void btn34_Click(object sender, EventArgs e)
        {
            try
            {
                objetoalu.copiartercerocuarto();
                Resinscritosaviso echo = new Resinscritosaviso();
                echo.Show();
                btn23.Enabled = true;
                try 
                {
                    objetoalu.eliminartercero();
                }
                catch (Exception exc)
                {
                    //eliminacion de datos dela tabla de tercero
                    ERRORCRITICOREINSCRIPCIONES errorborrar = new ERRORCRITICOREINSCRIPCIONES();
                    errorborrar.Show();
                    //soluciones posibles
                }
            }
            catch 
            {
                Errornoreinscrito noreins = new Errornoreinscrito();
                noreins.Show();
            }
        }

        private void btn23_Click(object sender, EventArgs e)
        {
            try
            {
                objetoalu.copiarsegundotercero();
                Resinscritosaviso echo = new Resinscritosaviso();
                echo.Show();
                btn12.Enabled = true; 
                try 
                {
                    objetoalu.eliminarsegundos();
                }
                catch (Exception exc)
                {
                    //eliminacion de datos dela tabla de segundo 
                    ERRORCRITICOREINSCRIPCIONES errorborrar = new ERRORCRITICOREINSCRIPCIONES();
                    errorborrar.Show();
                    //soluciones posibles
                }
            }
            catch 
            {
                Errornoreinscrito noreins = new Errornoreinscrito();
                noreins.Show();
            }
        }
    }
}
