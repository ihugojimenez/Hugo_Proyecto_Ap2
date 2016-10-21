using BLL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoWebApplication.Consultas
{
    public partial class cUsuarios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Usuarios u = new Usuarios();
            if(!IsPostBack)
            {
                


                UsuariosGridView.DataSource = u.Listado("*", "1=1", "");
                UsuariosGridView.DataBind();
            }
        }


        private DataSet GetData()
        {
            int id = 0;
            int.TryParse(IdTextBox.Text, out id);
            string Cs = ConfigurationManager.ConnectionStrings["AlmacenDb"].ConnectionString;
            using (SqlConnection con = new SqlConnection(Cs))
            {
                SqlDataAdapter da = new SqlDataAdapter("Select * from Usuarios where Usuarioid=" + id, con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;
            }
        }


        protected void SearchButton_Click1(object sender, EventArgs e)
        {
            
            DataSet ds = GetData();

            Repeater1.DataSource = ds;
            Repeater1.DataBind();
        }

        protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
        {

        }

        protected void PrintButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Consultas/ReporteUsuarios.aspx");
            Response.Clear();
        }
    }
}