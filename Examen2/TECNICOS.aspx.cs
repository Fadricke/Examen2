using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Examen2.CLASES;

namespace Examen2
{
    public partial class TECNICOS : System.Web.UI.Page
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
                using (SqlCommand cmd = new SqlCommand("SELECT *  FROM TECNICOS"))
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
            int valor = CLASES.TECNICOS.AgregarTecnico(txtNombre.Text, txtEspecialidad.Text);

            if (valor > 0)
            {
                LlenarGrid();
            }
            else
            {
                alertas("Error al ingresar Tecnico");
            }
        }

        protected void btnBorrar_Click(object sender, EventArgs e)
        {
            int valor = CLASES.TECNICOS.BorrarTecnico(int.Parse(txtTecnicoID.Text));

            if (valor > 0)
            {
                LlenarGrid();
            }
            else
            {
                alertas("Error al eliminar Tecnico");
            }
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            int valor = CLASES.TECNICOS.ModificarTecnicos(txtTecnicoID.Text, txtNombre.Text, txtEspecialidad.Text);

            if (valor > 0)
            {
                LlenarGrid();
            }
            else
            {
                alertas("Error al modificar Tecnico");
            }
        }

        protected void ConsultarTecnicos_Filtro()
        {
            string constr = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT *  FROM TECNICOS WHERE TECNICOID = '" + txtTecnicoID.Text + "'"))
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
            ConsultarTecnicos_Filtro();
        }
    }
}