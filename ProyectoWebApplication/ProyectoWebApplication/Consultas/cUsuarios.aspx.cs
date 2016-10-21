using BLL;
using System;
using System.Collections.Generic;
using System.Data;
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
                //DataSet d = new DataSet();
                //d = u.Listado();
                UsersRepeater.DataSource = u.Listado("*", "1=1", "");
                UsersRepeater.DataBind();


                UsuariosGridView.DataSource = u.Listado("*", "1=1", "");
                UsuariosGridView.DataBind();
            }
        }

        

        

        protected void SearchButton_Click1(object sender, EventArgs e)
        {

        }

        protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
        {

        }
    }
}