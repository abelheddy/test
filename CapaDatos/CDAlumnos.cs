using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;

namespace CapaDatos
{
    public class CDAlumnos
    {
        //conexion con la clase CDConexion
        private CDConexion Conexion = new CDConexion();

        SqlDataReader leer2;
        SqlDataReader leertercero;
        SqlDataReader leersegundo;
        SqlDataReader leeregresados;
        SqlDataReader leercuarto;
        SqlDataReader leerquinto;
        SqlDataReader leersexto;
        DataTable sexto = new DataTable();
        DataTable quinto = new DataTable();
        DataTable cuarto = new DataTable();
        DataTable tercero = new DataTable();
        DataTable egresados = new DataTable(); 
        DataTable segundo = new DataTable();
        DataTable tabla = new DataTable();
        SqlCommand comando1 = new SqlCommand();
        SqlCommand comando2 = new SqlCommand();
        SqlCommand comando3 = new SqlCommand();
        SqlCommand comando4 = new SqlCommand();
        SqlCommand comando5 = new SqlCommand();
        SqlCommand comando6 = new SqlCommand();
        SqlCommand comando7 = new SqlCommand();
        SqlCommand comando8 = new SqlCommand();
        SqlCommand eliminarprimero = new SqlCommand();
        SqlCommand eliminarsegundo = new SqlCommand();
        SqlCommand eliminartercero = new SqlCommand();
        SqlCommand eliminarcuarto = new SqlCommand();
        SqlCommand eliminarquinto = new SqlCommand();
        SqlCommand elimanrsexto = new SqlCommand();
        SqlCommand mostrartercero = new SqlCommand();
        SqlCommand mostrarsegundo = new SqlCommand();
        SqlCommand mostraregtesados= new SqlCommand();
        SqlCommand mostrarcuarto = new SqlCommand();
        SqlCommand mostrarquinto = new SqlCommand();
        SqlCommand mostrarsexto = new SqlCommand();
        public DataTable tablasexto() 
        {
            mostrarsexto.Connection = Conexion.AbrirConexion();
            mostrarsexto.CommandText = "";
            mostrarsexto.CommandType = CommandType.StoredProcedure;
            leersexto = mostrarsexto.ExecuteReader();
            sexto.Load(leersexto);
            return sexto;
        }
    
        public DataTable tablaquinto() 
        {
            mostrarquinto.Connection = Conexion.AbrirConexion();
            mostrarquinto.CommandText = "";
            mostrarquinto.CommandType = CommandType.StoredProcedure;
            leerquinto = mostrarquinto.ExecuteReader();
            quinto.Load(leerquinto);
            return quinto;
        }
        public DataTable tablacuarto()
        {
            mostrarcuarto.Connection = Conexion.AbrirConexion();
            mostrarcuarto.CommandText="";
            mostrarcuarto.CommandType = CommandType.StoredProcedure;
            leercuarto = mostrarcuarto.ExecuteReader();
            cuarto.Load(leercuarto);
            return cuarto;
        }
        public DataTable tablatercero() 
        {
            mostrartercero.Connection = Conexion.AbrirConexion();
            mostrartercero.CommandText = "";
            mostrartercero.CommandType = CommandType.StoredProcedure;
            leertercero = mostrartercero.ExecuteReader();
            tercero.Load(leertercero);
            return tercero;

        }
        public DataTable tablaegresados() 
        {
            mostraregtesados.Connection = Conexion.AbrirConexion();
            mostraregtesados.CommandText = "mostraregresados";
            mostraregtesados.CommandType = CommandType.StoredProcedure;
            leeregresados = mostraregtesados.ExecuteReader();
            egresados.Load(leeregresados);
            return egresados;
        }
        public DataTable tablasegundo() 
        {
            mostrarsegundo.Connection = Conexion.AbrirConexion();
            mostrarsegundo.CommandText = "mostrarsegundo";
            mostrarsegundo.CommandType = CommandType.StoredProcedure;
            leersegundo = mostrarsegundo.ExecuteReader();
            segundo.Load(leersegundo);
            return segundo;

        }
        public void eliminarsextos() 
        {
            elimanrsexto.Connection = Conexion.AbrirConexion();
            elimanrsexto.CommandText = "eliminarsexto";
            elimanrsexto.CommandType = CommandType.StoredProcedure;
            elimanrsexto.ExecuteNonQuery();
            //elimanrsexto.BeginExecuteNonQuery();
            
            elimanrsexto.Parameters.Clear();
        }
        public void eliminarquintos()
        {
            eliminarquinto.Connection = Conexion.AbrirConexion();
            eliminarquinto.CommandText = "eliminarquinto";
            eliminarquinto.CommandType = CommandType.StoredProcedure;
            eliminarquinto.BeginExecuteNonQuery();
            eliminarquinto.Parameters.Clear();
        }
        public void eliminarcuartos() 
        {
            eliminarcuarto.Connection = Conexion.AbrirConexion();
            eliminarcuarto.CommandText = "eliminarcuarto";
            eliminarcuarto.CommandType = CommandType.StoredProcedure;
            eliminarcuarto.BeginExecuteNonQuery();
            eliminarcuarto.Parameters.Clear();
        }
        public void eliminarterceros() 
        {
            eliminartercero.Connection = Conexion.AbrirConexion();
            eliminartercero.CommandText = "eleminartercero";
            eliminartercero.CommandType = CommandType.StoredProcedure;
            eliminartercero.BeginExecuteNonQuery();
            eliminartercero.Parameters.Clear();
        }
        public void eliminarsegundos() 
        {
            eliminarsegundo.Connection = Conexion.AbrirConexion();
            eliminarsegundo.CommandText = "eliminarsegundo";
            eliminarsegundo.CommandType = CommandType.StoredProcedure;
            eliminarsegundo.BeginExecuteNonQuery();
            eliminarsegundo.Parameters.Clear();
        }
        public void eliminarprimeros() 
        {
            eliminarprimero.Connection = Conexion.AbrirConexion();
            eliminarprimero.CommandText = "eliminarprimero";
            eliminarprimero.CommandType = CommandType.StoredProcedure;
            eliminarprimero.BeginExecuteNonQuery();
            eliminarprimero.Parameters.Clear();
        }
        public void pasardesextoegresados() 
        {
            comando8.Connection = Conexion.AbrirConexion();
            comando8.CommandText = "copegresados";
            comando8.CommandType = CommandType.StoredProcedure;
            comando8.BeginExecuteNonQuery();
            comando8.Parameters.Clear();
        }
        public void pasardequintosexto() 
        {
            comando7.Connection = Conexion.AbrirConexion();
            comando7.CommandText = "copquintos";
            comando7.CommandType = CommandType.StoredProcedure;
            comando7.BeginExecuteNonQuery();
            comando7.Parameters.Clear();
        }
        public void pasardecuartoquinto() 
        {
            comando6.Connection = Conexion.AbrirConexion();
            comando6.CommandText = "copcuarto";
            comando6.CommandType = CommandType.StoredProcedure;
            comando6.BeginExecuteNonQuery();
            comando6.Parameters.Clear();
        }
        public void pasardetercerocuarto() 
        {
            comando5.Connection = Conexion.AbrirConexion();
            comando5.CommandText = "coptercero";
            comando5.CommandType = CommandType.StoredProcedure;
            comando5.BeginExecuteNonQuery();
        }
        public void pasardesegundotercero() 
        {
            comando4.Connection = Conexion.AbrirConexion();
            comando4.CommandText = "copsegundo";
            comando4.CommandType = CommandType.StoredProcedure;
            comando5.BeginExecuteNonQuery();
            comando4.Parameters.Clear();
        }
        public void pasardatos() 
        {
            comando3.Connection = Conexion.AbrirConexion();
            comando3.CommandText = "coppriemro";
            comando3.CommandType = CommandType.StoredProcedure;
            comando3.BeginExecuteNonQuery();
            comando3.Parameters.Clear();
        }
        public DataTable mostraralumno()
        {
            //transac sql
            comando1.Connection = Conexion.AbrirConexion();
            comando1.CommandText = "mostraralumnos1";
            comando1.CommandType = CommandType.StoredProcedure;
            leer2 = comando1.ExecuteReader();
            tabla.Load(leer2);
            Conexion.CerrarConexion();
            return tabla;
            //prosedimiento almacenado
        }
        public void insertaralumno(double nu,double MATRICULA, double ID_PADRE, string NOMBRE_COMPLETO, string APELLIDO_PATERNO, string APELIIDO_MATERNO, string NOMBRES, string SEXO_HM, string FECHA_NAC, string EDAD, string CURP) 
        {
            comando2.Connection = Conexion.AbrirConexion();
            comando2.CommandText = "inscripalu";
            comando2.CommandType = CommandType.StoredProcedure;
            comando2.Parameters.AddWithValue("@nu",nu);
            comando2.Parameters.AddWithValue("@MATRICULA", MATRICULA);
            comando2.Parameters.AddWithValue("@ID_PADRE", ID_PADRE);
            comando2.Parameters.AddWithValue("@NOMBRE_COMPLETO", NOMBRE_COMPLETO);
            comando2.Parameters.AddWithValue("@APELLIDO_PATERNO", APELLIDO_PATERNO);
            comando2.Parameters.AddWithValue("@APELLIDO_MATERNO", APELIIDO_MATERNO);
            comando2.Parameters.AddWithValue("@NOMBRES", NOMBRES);
            comando2.Parameters.AddWithValue("@SEXO_HM", SEXO_HM);
            comando2.Parameters.AddWithValue("@FECHA_NAC", FECHA_NAC);
            comando2.Parameters.AddWithValue("@EDAD", EDAD);
            comando2.Parameters.AddWithValue("@CURP", CURP);
            comando2.ExecuteNonQuery();
            //esto permite limpiar los parametros y asi evitar errores
            comando2.Parameters.Clear();
        }
    }
}
