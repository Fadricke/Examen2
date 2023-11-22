using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Examen2
{
    public partial class EQUIPOS : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LlenarGrid();
            }
        }
        protected void LlenarGrid()
        {
            string constr = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT *  FROM EQUIPOS"))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter())
                    {
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            datagrid.DataSource = dt;
                            datagrid.DataBind();  // actualizar el grid view
                        }
                    }
                }
            }
        }
        public void alertas(String texto)
        {
            string message = texto;
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append("<script type = 'text/javascript'>");
            sb.Append("window.onload=function(){");
            sb.Append("alert('");
            sb.Append(message);
            sb.Append("')};");
            sb.Append("</script>");
            ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", sb.ToString());
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            int valor = CLASES.EQUIPOS.AgregarEquipo(txtTipo.Text, txtModelo.Text, txtUsuarioID_Equipo.Text);

            if (valor > 0)
            {
                LlenarGrid();
            }
            else
            {
                alertas("Error al ingresar Equipo");
            }
        }

        protected void btnBorrar_Click(object sender, EventArgs e)
        {
            int valor = CLASES.EQUIPOS.BorrarEquipos(int.Parse(txtEquipoID.Text));

            if (valor > 0)
            {
                LlenarGrid();
            }
            else
            {
                alertas("Error al eliminar Equipo");
            }
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            int valor = CLASES.EQUIPOS.ModificarEquipos(txtEquipoID.Text,txtModelo.Text, txtTipo.Text);

            if (valor > 0)
            {
                LlenarGrid();
            }
            else
            {
                alertas("Error al modificar Equipo");
            }
        }
        protected void ConsultarEquipos_Filtro()
        {
            string constr = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT *  FROM EQUIPOS WHERE EQUIPOID = '" + txtEquipoID.Text + "'"))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter())
                    {
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            datagrid.DataSource = dt;
                            datagrid.DataBind();  // actualizar el grid view
                        }
                    }
                }
            }
        }

        protected void btnconsultar_Click(object sender, EventArgs e)
        {
            ConsultarEquipos_Filtro();
        }
    }
}
