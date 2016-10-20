using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace BLL
{
    public class Usuarios : ClaseMaestra
    {
        ConexionDb Conexion = new ConexionDb();
        public int Usuarioid { get; set; }
        public string NombreUsuario { get; set; }
        public string Contraseña { get; set; }
        public string Nombres { get; set; }
        public int IdTipo { get; set; }

        public override bool Buscar(int IdBuscado)
        {
            DataTable dt = new DataTable();

            dt = Conexion.ObtenerDatos(string.Format("Select * from Usuarios where Usuarioid = " + IdBuscado));
            if (dt.Rows.Count > 0)
            {
                this.Usuarioid = IdBuscado;
                this.NombreUsuario = dt.Rows[0]["NombreUsuario"].ToString();
                this.Contraseña = dt.Rows[0]["Contraseña"].ToString();
                this.Nombres = dt.Rows[0]["Nombres"].ToString();
                this.IdTipo = int.Parse(dt.Rows[0]["IdTipo"].ToString());
            }

            return dt.Rows.Count > 0;
        }

        public override bool Editar()
        {
            throw new NotImplementedException();
        }

        public override bool Eliminar()
        {
            ConexionDb conexion = new ConexionDb();
            bool retorno = false;
            try
            {
                retorno = conexion.Ejecutar(string.Format("delete from Usuarios where UsuarioId= {0} ", this.Usuarioid));
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return retorno;
        }

        public override bool Insertar()
        {
            bool retorno = false;

            try
            {
                retorno = Conexion.Ejecutar(string.Format("Insert into Usuarios(NombreUsuario, Contraseña, Nombres, IdTipo) values('{0}', '{1}','{2}', {3})", this.NombreUsuario, this.Contraseña, this.Nombres, this.IdTipo));
            }
            catch(Exception ex)
            {
                retorno = false;
                throw ex;
                
            }
            return retorno;
        }

        public override DataTable Listado(string Campos, string Condicion, string Orden)
        {
            ConexionDb conexion = new ConexionDb();
            string ordenFinal = "";
            if (!Orden.Equals(""))
                ordenFinal = " order by  " + Orden;
            return conexion.ObtenerDatos(string.Format("select " + Campos + " from Usuarios where " + Condicion + ordenFinal));
        }
    }
}