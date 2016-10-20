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

        protected void Limpiar()
        {
            UserNameTextBox.Text = "";
            NameTextBox.Text = "";
            PassTextBox.Text = "";
            RpassTextBox.Text = "";
            TipoDropDownList.SelectedIndex = 1;
        }

        protected void NewButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        protected void LLenarClase(Usuarios u)
        {
            u.NombreUsuario = UserNameTextBox.Text;
            u.Nombres = NameTextBox.Text;
            u.Contraseña = PassTextBox.Text;
            u.IdTipo = int.Parse(TipoDropDownList.SelectedValue);
        }

        protected void LLenarCampos(Usuarios u)
        {
            NameTextBox.Text = u.Nombres;
            UserNameTextBox.Text = u.NombreUsuario;
            PassTextBox.Text = u.Contraseña;
            RpassTextBox.Text = u.Contraseña;
            TipoDropDownList.SelectedIndex = u.IdTipo;
        }

        protected void SaveButton_Click(object sender, EventArgs e)
        {
            Usuarios usuario = new Usuarios();
            LLenarClase(usuario);
            usuario.Insertar();
            Limpiar();
        }

        protected void DeleteButton_Click(object sender, EventArgs e)
        {
            Usuarios usuario = new Usuarios();
            usuario.Usuarioid = Convert.ToInt32(IdTextBox.Text);
            usuario.Eliminar();
            Limpiar();
        }

        protected void SearchButton_Click(object sender, EventArgs e)
        {
            Usuarios u = new Usuarios();
            u.Buscar(Convert.ToInt32(IdTextBox.Text));
            LLenarCampos(u);
            
        }
    }
}