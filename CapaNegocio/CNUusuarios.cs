using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace CapaNegocio
{
     public class CNUusuarios
    {
        //encapsular variables
        private CDUsuarios objDato = new CDUsuarios();//instancia a la capa de datos usuario
        //variables
        private String _usuario;
        private String _contraseña;
        private String _nivel;
        //todas las demas....
        //METODOS GET Y SET --> para el manejo de variables
        public String Usuario
        {
            set
            {
                if (value == "USUARIO")
                {
                    _usuario = "No a ingresado un Usuario";
                }
                else
                {
                    _usuario = value;
                }
            }
            get { return _usuario; }
        }
        public String Contraseña
        {
            set
            {
                if (value == "CONTRASEÑA")
                {
                    _contraseña = "No a ingresado una Contraseña";
                }
                else
                {
                    _contraseña = value;
                }
            }
            get { return _contraseña; }
        }
        public String Nivel
        {
            set
            {
                if (value == "NIVEL")
                {
                    _nivel = "No a ingresado un Nivel";
                }
                else { _nivel = value; }
            }
            get { return _nivel; }
        }
        public SqlDataReader iniciarsecion()
        {
            SqlDataReader Logear;
            Logear = objDato.iniciarsecion(Usuario, Contraseña, Nivel);
            return Logear;
        }
        public string recuperardatos(string usuario)
        {
            string mensaje;
            mensaje = objDato.recuperarcontraseña(usuario);
            return mensaje;
        }
    }
}
