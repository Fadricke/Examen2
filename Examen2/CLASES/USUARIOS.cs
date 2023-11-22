using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Web.UI.WebControls;

namespace Examen2.CLASES
{
    public class USUARIOS
    {
        public static int usuarioID { get; set; }
        public static string nombre { get; set; }
        public static string correoElectronico { get; set; }
        public static string telefono { get; set; }

        public USUARIOS(int UsuarioID, string Nombre, string CorreoElectronico, string Telefono) 
        { 
            usuarioID = UsuarioID;
            nombre = Nombre;    
            correoElectronico = CorreoElectronico;
            telefono = Telefono;
        }

        public static int AgregarUsuarios(string Nombre,string CorreoElectronico,string Telefono)
        {
            int retorno = 0;

            SqlConnection Conn = new SqlConnection();
            try
            {
                using (Conn = DbConnect.obtenerConexion())
                {
                    SqlCommand cmd = new SqlCommand("AGREGARUSUARIO", Conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };  
                    cmd.Parameters.Add(new SqlParameter("@NOMBRE",Nombre));
                    cmd.Parameters.Add(new SqlParameter("@CORREO", CorreoElectronico));
                    cmd.Parameters.Add(new SqlParameter("@TELEFONO", Telefono));

                    retorno = cmd.ExecuteNonQuery();
                }
            }
            catch (System.Data.SqlClient.SqlException)
            {
                retorno = -1;
            }
            finally
            {
                Conn.Close();
            }

            return retorno;

        }
        public static int BorrarUsuarios(int code)
        {
            int retorno = 0;

            SqlConnection Conn = new SqlConnection();
            try
            {
                using (Conn = DbConnect.obtenerConexion())
                {
                    SqlCommand cmd = new SqlCommand("BORRARUSUARIO", Conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new SqlParameter("@CODIGO", code));

                    retorno = cmd.ExecuteNonQuery();
                }
            }
            catch (System.Data.SqlClient.SqlException)
            {
                retorno = -1;
            }
            finally
            {
                Conn.Close();
            }

            return retorno;

        }
        public static int ModificarUsuarios(int code,string nombre,string correo,string telefono)
        {
            int retorno = 0;

            SqlConnection Conn = new SqlConnection();
            try
            {
                using (Conn = DbConnect.obtenerConexion())
                {
                    SqlCommand cmd = new SqlCommand("MODIFICARUSUARIO", Conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new SqlParameter("@CODIGO", code));
                    cmd.Parameters.Add(new SqlParameter("@NOMBRE", nombre));
                    cmd.Parameters.Add(new SqlParameter("@CORREO", correo));
                    cmd.Parameters.Add(new SqlParameter("@TELEFONO", telefono));

                    retorno = cmd.ExecuteNonQuery();
                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                retorno = -1;
            }
            finally
            {
                Conn.Close();
            }

            return retorno;

        }

    }
}