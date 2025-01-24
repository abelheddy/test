using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CDTutor
    {
        //conexion con la clase CDConexion
        private CDConexion Conexion = new CDConexion();

        SqlDataReader leer3;
        DataTable tabla = new DataTable();
        SqlCommand comando2 = new SqlCommand();
        SqlCommand comando3 = new SqlCommand();
        public DataTable tutor()
        {
            //transac sql
            comando2.Connection = Conexion.AbrirConexion();
            comando2.CommandText = "mostrartutor";
            comando2.CommandType = CommandType.StoredProcedure;
            leer3 = comando2.ExecuteReader();
            tabla.Load(leer3);
            Conexion.CerrarConexion();
            return tabla;
            //prosedimiento almacenado
        }
        public void insertartutor(double ID_PADRE,string PADRE_O_TUTOR, string APELLIDO_PATERNO,string APELLIDO_MATERNO,string NOMBRES,string DOMICILIO_CALLE_NUMERO,string COLONIA_FRACIONAMIENTO,string MUNICIPIO,string TELEFONO, string OCUPACION,string NFOLIO,string AÑOSPRESCOLAR,string TOTAL_FAMILIARES,string NOMBREHERMANOS,string GRADO) 
        {
            //transac sql
            comando3.Connection = Conexion.AbrirConexion();
            comando3.CommandText = "insertatutor";
            comando3.CommandType = CommandType.StoredProcedure;
            comando3.Parameters.AddWithValue("@ID_PADRE", ID_PADRE);
            comando3.Parameters.AddWithValue("@PADRE_O_TUTOR", PADRE_O_TUTOR);
            comando3.Parameters.AddWithValue("@APELLIDO_PATERNO", APELLIDO_PATERNO);
            comando3.Parameters.AddWithValue("@APELLIDO_MATERNO", APELLIDO_MATERNO);
            comando3.Parameters.AddWithValue("@NOMBRES", NOMBRES);
            comando3.Parameters.AddWithValue("@DOMICILIO_CALLE_NUMERO", DOMICILIO_CALLE_NUMERO);
            comando3.Parameters.AddWithValue("@COLONIA_FRACIONAMIENTO", COLONIA_FRACIONAMIENTO);
            comando3.Parameters.AddWithValue("@MUNICIPIO", MUNICIPIO);
            comando3.Parameters.AddWithValue("@TELEFONO", TELEFONO);
            comando3.Parameters.AddWithValue("@OCUPACION", OCUPACION);
            comando3.Parameters.AddWithValue("@NFOLIO", NFOLIO);
            comando3.Parameters.AddWithValue("@AÑOSPRESCOLAR", AÑOSPRESCOLAR);
            comando3.Parameters.AddWithValue("@TOTAL_FAMILIARES", TOTAL_FAMILIARES);
            comando3.Parameters.AddWithValue("@NOMBREHERMANOS", NOMBREHERMANOS);
            comando3.Parameters.AddWithValue("@GRADO", GRADO);
            comando3.ExecuteNonQuery();
            //esto permite limpiar los parametros y asi evitar errores
            comando3.Parameters.Clear();
        }
    }
}
