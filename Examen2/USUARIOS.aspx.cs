using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Configuration;

namespace Examen2
{
    public partial class USUARIOS : System.Web.UI.Page
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
                using (SqlCommand cmd = new SqlCommand("SELECT *  FROM USUARIOS"))
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
            int valor = CLASES.USUARIOS.AgregarUsuarios(txtNombre.Text, txtCorreo.Text, txtTelefono.Text);

            if (valor > 0)
            {
                LlenarGrid();
            }
            else
            {
                alertas("Error al ingresar Usuario");
            }
        }

        protected void btnBorrar_Click(object sender, EventArgs e)
        {
            int valor = CLASES.USUARIOS.BorrarUsuarios(int.Parse(txtUsuarioID.Text));

            if (valor > 0)
            {
                LlenarGrid();
            }
            else
            {
                alertas("Error al eliminar Usuario");
            }
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            int valor = CLASES.USUARIOS.ModificarUsuarios(int.Parse(txtUsuarioID.Text), txtNombre.Text, txtCorreo.Text, txtTelefono.Text);

            if (valor > 0)
            {
                LlenarGrid();
            }
            else
            {
                alertas("Error al modificar Usuario");
            }
        }

        protected void ConsultarUsuario_Filtro()
        {
            string constr = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT *  FROM USUARIOS WHERE USUARIOID = '"+ txtUsuarioID.Text +"'"))
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
            ConsultarUsuario_Filtro();
        }
    }
}
