using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data.SqlClient;
using System.Data;
using System.Data.Sql;

namespace CapaNegocio
{
    public class CNAlumnos
    {
        private CDAlumnos objeto = new CDAlumnos();
        public DataTable mostrarsexto() 
        {
            DataTable tablasexto = new DataTable();
            tablasexto = objeto.tablasexto();
            return tablasexto;
        }
        public DataTable mostrarquinto() 
        {
            DataTable tablaquin = new DataTable();
            tablaquin = objeto.tablaquinto();
            return tablaquin;
        }
        public DataTable mostrarcuarto() 
        {
            DataTable tablacuar = new DataTable();
            tablacuar = objeto.tablacuarto();
            return tablacuar;
        }
        public DataTable mostrartercero() 
        {
            DataTable tablater = new DataTable();
            tablater = objeto.tablatercero();
            return tablater;
        } 
        public DataTable mostraregresados() 
        {
            DataTable tablaegre = new DataTable();
            tablaegre = objeto.tablaegresados();
            return tablaegre;
        }
        public DataTable mostrarsegundo() 
        {
            DataTable tablasegundo = new DataTable();
            tablasegundo = objeto.tablasegundo();
            return tablasegundo;
        }
        public void eliminarsexto() 
        {
            objeto.eliminarsextos();
        }
        public void eliminarquinto() 
        {
            objeto.eliminarquintos();
        }
        public void eliminarcuarto() 
        {
            objeto.eliminarcuartos();
        }
        public void eliminartercero() 
        {
            objeto.eliminarterceros();
        }
        public void eliminarsegundos() 
        {
            objeto.eliminarsegundos();
        }
        public void eliminarprimero() 
        {
            objeto.eliminarprimeros();
        }
        public void coiardesextoegresados() 
        {
            objeto.pasardesextoegresados();
        }
        public void copiardequintosexto() 
        {
            objeto.pasardequintosexto();
        }
        public void copiardecuartoquinto() 
        {
            objeto.pasardecuartoquinto();
        }
        public void copiartercerocuarto() 
        {
            objeto.pasardetercerocuarto();
        }
        public void copiarsegundotercero() 
        {
            objeto.pasardesegundotercero();
        }
        public void copiaralmunos() 
        {
            objeto.pasardatos();
        }
        public DataTable mostrarprimero() 
        {
            DataTable tabla1 = new DataTable();
            tabla1 = objeto.mostraralumno();
            return tabla1;
        }
        public void insertaralumnos(string nu, string MATRICULA, string ID_PADRE, string NOMBRE_COMPLETO, string APELLIDO_PATERNO, string APELIIDO_MATERNO, string NOMBRES, string SEXO_HM, string FECHA_NAC, string EDAD, string CURP) 
        {
            objeto.insertaralumno(Convert.ToDouble(nu), Convert.ToDouble(MATRICULA), Convert.ToDouble(ID_PADRE), NOMBRE_COMPLETO, APELLIDO_PATERNO, APELIIDO_MATERNO, NOMBRES, SEXO_HM, FECHA_NAC, EDAD, CURP);
        }
    }
}
