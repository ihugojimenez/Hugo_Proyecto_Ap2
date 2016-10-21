using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoWebApplication.Consultas
{
    public partial class cEquipos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Equipos eq = new Equipos();

            if(!IsPostBack)
            {
                EquiposGridView.DataSource = eq.Listado("*", "1=1", "");
                EquiposGridView.DataBind();
            }
        }

        protected void SearchButton_Click1(object sender, EventArgs e)
        {

        }
    }
}