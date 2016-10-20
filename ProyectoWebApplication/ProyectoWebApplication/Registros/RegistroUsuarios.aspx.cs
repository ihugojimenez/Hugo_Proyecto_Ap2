using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoWebApplication
{
    public partial class RegistroUsuarios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TiposUsuarios tu = new TiposUsuarios();

            if(!IsPostBack)
            {
                TipoDropDownList.DataSource = tu.Listado("*", "1=1", "");
                TipoDropDownList.DataTextField = "Detalle";
                TipoDropDownList.DataValueField = "IdTipo";
                TipoDropDownList.DataBind();
            }
        }

        protected void NewButton_Click(object sender, EventArgs e)
        {

        }
    }
}