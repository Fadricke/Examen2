using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace Examen2.CLASES
{
    public class EQUIPOS
    {
        public static int equipoID { get; set; }

        public static string tipoEquipo { get; set; }

        public static string modelo { get; set; }

        public static int usuarioID {  get; set; }

        public EQUIPOS(int EquipoID,string TipoEquipo,string Modelo, int UsuarioID_Equipo) 
        { 
            equipoID = EquipoID;
            tipoEquipo = TipoEquipo;
            modelo = Modelo;
            usuarioID = UsuarioID_Equipo;
        }


        public static int AgregarEquipo(string TipoEquipo, string Modelo, string UsuarioID_Equipo)
        {
            int retorno = 0;

            SqlConnection Conn = new SqlConnection();
            try
            {
                using (Conn = DbConnect.obtenerConexion())
                {
                    SqlCommand cmd = new SqlCommand("AGREGAREQUIPO", Conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new SqlParameter("@TIPO", TipoEquipo));
                    cmd.Parameters.Add(new SqlParameter("MODELO", Modelo));
                    cmd.Parameters.Add(new SqlParameter("@USUARIOID", UsuarioID_Equipo));

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
        public static int BorrarEquipos(int code)
        {
            int retorno = 0;

            SqlConnection Conn = new SqlConnection();
            try
            {
                using (Conn = DbConnect.obtenerConexion())
                {
                    SqlCommand cmd = new SqlCommand("BORRAREQUIPO", Conn)
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
        public static int ModificarEquipos(string code, string tipoEquipo, string modelo)
        {
            int retorno = 0;

            SqlConnection Conn = new SqlConnection();
            try
            {
                using (Conn = DbConnect.obtenerConexion())
                {
                    SqlCommand cmd = new SqlCommand("MODIFICAREQUIPO", Conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new SqlParameter("@CODIGO", code));
                    cmd.Parameters.Add(new SqlParameter("@TIPO", tipoEquipo));
                    cmd.Parameters.Add(new SqlParameter("@MODELO", modelo));

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
        
    }
}