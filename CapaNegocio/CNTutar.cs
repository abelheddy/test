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
    public class CNTutar
    {
        //encapsular variables
        private CDTutor objDato = new CDTutor();//instancia a la capa de datos usuario
        public DataTable mostrartutores()
        {
            DataTable tabla = new DataTable();
            tabla = objDato.tutor();
            return tabla;
        }
        public void insertartutor(string ID_PADRE, string PADRE_O_TUTOR, string APELLIDO_PATERNO, string APELLIDO_MATERNO, string NOMBRES, string DOMICILIO_CALLE_NUMERO, string COLONIA_FRACIONAMIENTO, string MUNICIPIO, string TELEFONO, string OCUPACION, string NFOLIO, string AÑOSPRESCOLAR, string TOTAL_FAMILIARES, string NOMBREHERMANOS, string GRADO) 
        {
            objDato.insertartutor(Convert.ToDouble(ID_PADRE),PADRE_O_TUTOR,APELLIDO_PATERNO,APELLIDO_MATERNO,NOMBRES, DOMICILIO_CALLE_NUMERO,COLONIA_FRACIONAMIENTO,MUNICIPIO,TELEFONO,OCUPACION,NFOLIO,AÑOSPRESCOLAR,TOTAL_FAMILIARES,NOMBREHERMANOS,GRADO);
        }
    }
}
