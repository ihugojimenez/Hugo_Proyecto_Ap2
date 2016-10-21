﻿using DAL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace BLL
{
    public class Usuarios : ClaseMaestra
    {
        ConexionDb Conexion = new ConexionDb();
        public int UsuarioId { get; set; }
        public string NombreUsuario { get; set; }
        public string Contraseña { get; set; }
        public string Nombres { get; set; }
        public int IdTipo { get; set; }
        public string Imagen { get; set; }

        public override bool Buscar(int IdBuscado)
        {
            DataTable dt = new DataTable();

            dt = Conexion.ObtenerDatos(string.Format("Select * from Usuarios where Usuarioid = " + IdBuscado));
            if (dt.Rows.Count > 0)
            {
                this.UsuarioId = IdBuscado;
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
                retorno = conexion.Ejecutar(string.Format("delete from Usuarios where UsuarioId= {0} ", this.UsuarioId));
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
                retorno = Conexion.Ejecutar(string.Format("Insert into Usuarios(NombreUsuario, Contraseña, Nombres, IdTipo, Imagen) values('{0}', '{1}','{2}', {3}, '{4}')", this.NombreUsuario, this.Contraseña, this.Nombres, this.IdTipo, this.Imagen));
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

        public  DataTable Listadodts(string Condicion)
        {
            ConexionDb conexion = new ConexionDb();
            
            return conexion.ObtenerDatos(string.Format("select *" + " from Usuarios where " + Condicion));
        }

        public DataSet GetData(int id)
        {
            
            string Cs = ConfigurationManager.ConnectionStrings["AlmacenDb"].ConnectionString;
            using (SqlConnection con = new SqlConnection(Cs))
            {
                SqlDataAdapter da = new SqlDataAdapter("Select * from Usuarios where Usuarioid=" + id, con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;
            }
        }
    }
}