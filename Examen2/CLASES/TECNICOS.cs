using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace Examen2.CLASES
{
    public class TECNICOS
    {
        public static int tecnicoID { get; set; }
        public static string nombre { get; set; }
        public static string especialidad { get; set; }

        public TECNICOS(int TecnicoID,string Nombre, string Especialidad)
        {
            tecnicoID = TecnicoID;
            nombre = Nombre;
            especialidad = Especialidad;
        }
        public static int AgregarTecnico(string Nombre, string Especialidad)
        {
            int retorno = 0;

            SqlConnection Conn = new SqlConnection();
            try
            {
                using (Conn = DbConnect.obtenerConexion())
                {
                    SqlCommand cmd = new SqlCommand("AGREGARTECNICO", Conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new SqlParameter("@NOMBRE", Nombre));
                    cmd.Parameters.Add(new SqlParameter("@ESPECIALIDAD", Especialidad));

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
        public static int BorrarTecnico(int code)
        {
            int retorno = 0;

            SqlConnection Conn = new SqlConnection();
            try
            {
                using (Conn = DbConnect.obtenerConexion())
                {
                    SqlCommand cmd = new SqlCommand("BORRARTECNICO", Conn)
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
        public static int ModificarTecnicos(string code, string Nombre, string Especialidad)
        {
            int retorno = 0;

            SqlConnection Conn = new SqlConnection();
            try
            {
                using (Conn = DbConnect.obtenerConexion())
                {
                    SqlCommand cmd = new SqlCommand("MODIFICARTECNICOS", Conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new SqlParameter("@CODIGO", code));
                    cmd.Parameters.Add(new SqlParameter("@NOMBRE", Nombre));
                    cmd.Parameters.Add(new SqlParameter("@ESPECIALIDAD", Especialidad));

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
