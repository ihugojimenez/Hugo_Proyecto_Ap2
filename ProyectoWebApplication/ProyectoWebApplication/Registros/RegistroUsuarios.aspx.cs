using BLL;
using DAL;
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
            IdTextBox.Text = "";
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
            string str = FileUpload1.FileName;
            FileUpload1.PostedFile.SaveAs(Server.MapPath("//Imagenes//") + str);
            string path = "~//Imagenes//" + str.ToString();
            u.Imagen = path;
        }

        protected void LLenarCampos(Usuarios u)
        {
            NameTextBox.Text = u.Nombres;
            UserNameTextBox.Text = u.NombreUsuario;
            PassTextBox.Text = u.Contraseña;
            RpassTextBox.Text = u.Contraseña;
            

            //TipoDropDownList.SelectedIndex = u.IdTipo;
        }

        protected void SaveButton_Click(object sender, EventArgs e)
        {
            ConexionDb con = new ConexionDb();
            Usuarios usuario = new Usuarios();
            LLenarClase(usuario);
            
            usuario.Insertar();
            Limpiar();
        }

        protected void DeleteButton_Click(object sender, EventArgs e)
        {
            Usuarios usuario = new Usuarios();
            usuario.UsuarioId = Convert.ToInt32(IdTextBox.Text);
            if(usuario.Eliminar())
            {
                Response.Write("<script>alert('Eliminado con exito')</script>");
            }
            //Limpiar();
        }

        protected void SearchButton_Click(object sender, EventArgs e)
        {
            Usuarios u = new Usuarios();
            u.Buscar(Convert.ToInt32(IdTextBox.Text));
            LLenarCampos(u);
            
        }

        

        public void subirFoto()
        {
            ConexionDb cone = new ConexionDb();
           
                //string str = FileUpload1.FileName;
                //FileUpload1.PostedFile.SaveAs(Server.MapPath("//Imagenes//") + str);
                //string path = "~//Imagenes/descarga.jpg" /*+ str.ToString()*/;
                //con.Ejecutar(String.Format("Insert into Usuarios(Imagen) Values('{0}')", path));

            if(FileUpload1.HasFile)
            {
                string str = FileUpload1.FileName;
                FileUpload1.PostedFile.SaveAs(Server.MapPath("//Imagenes//") + str);
                string path = "~//Imagenes//" + str.ToString();
                cone.Ejecutar(String.Format("Insert into Usuarios(Imagen) Values('{0}')", path));




            }





        }
    }
}