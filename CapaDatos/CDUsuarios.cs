using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Data.Sql;
using System.Net;
using System.Net.Mail;

namespace CapaDatos
{
    public class CDUsuarios
    {
        private CDConexion Conexion = new CDConexion();
        private SqlDataReader leer;
        private SqlDataReader leer2;
        private string correo, usuario, contraseña,mensaje;
        private SqlCommand comando = new SqlCommand();
        public string recuperarcontraseña(string usuario)
        {
            comando.Connection = Conexion.AbrirConexion();
            comando.CommandText = "contraseña";
            leer2 = comando.ExecuteReader();
            if (leer2.Read() == true)
            {
                correo = leer2["correo"].ToString();
                usuario = leer2["usuario"].ToString();
                contraseña = leer2["contraseña"].ToString();
                //metodo de envio de email por hotmail
                Enviaracorreo();
                mensaje = "Estimado " + usuario + ", se ha enviado a su correo electronico " + correo + ", su contraseña correspondiente";
                leer2.Close();
            }
            else
            {
                mensaje = "No se encontro el usuario........";
            }
            return mensaje;
        }
        public void Enviaracorreo() {
         //correo a enviar
            MailMessage email = new MailMessage();
            email.From = new MailAddress("heckscorporation@gmail.com");
            email.To.Add(correo);
            email.Subject=("RECUPERACION DE CONTRASEÑA DE SYSTEM");
            email.Body = "Hola "+usuario+", ha solicitado la recuperaion de su contraseña\n Su contraseña es: "+contraseña+", \n Que tenga un exelente dia.";
            email.Priority = MailPriority.High;
            //smpt=protocolo de transferencia
            SmtpClient servidoremail = new SmtpClient();
            servidoremail.Credentials = new NetworkCredential("heckscorporation@gmail.com", "@Industria123");
            servidoremail.Host = "smtp.gmail.com";
            servidoremail.Port = 587;
            servidoremail.EnableSsl = true;
            try
            {
                servidoremail.Send(email);
            }
            catch(Exception ex)
            {

            }
            email.Dispose();
        }
        public SqlDataReader iniciarsecion(string user, string pass, string nivel)
        {
            // string sql = "select * from usuarios where usuario='"+user+"'and contraseña='"+pass+"' and nivel='"+nivel+"'";
            SqlCommand comando = new SqlCommand("iniciarsesion", Conexion.AbrirConexion());
            // comando.Connection = Conexion.AbrirConexion();
            // comando.CommandText = sql;
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@usuario", user);
            comando.Parameters.AddWithValue("@pass", pass);
            comando.Parameters.AddWithValue("@nivel", nivel);
            leer = comando.ExecuteReader();
            comando.Parameters.Clear();
            return leer;
        }
    }
}
