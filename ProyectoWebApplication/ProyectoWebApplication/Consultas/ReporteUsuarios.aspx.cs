﻿using BLL;
using Microsoft.Reporting.WebForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoWebApplication.Consultas
{
    public partial class ReporteUsuarios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if(!IsPostBack)
            {
                Configurar(UsuariosReportViewer);
            }
            
            

            
        }

        private void Configurar(ReportViewer reportViewergenerico)
        {
            Usuarios u = new Usuarios();

            reportViewergenerico.LocalReport.DataSources.Clear();
            reportViewergenerico.ProcessingMode = ProcessingMode.Local;

            reportViewergenerico.LocalReport.ReportPath = @"Reportes\UsersReport.rdlc";

            ReportDataSource source = new ReportDataSource("Usuarios", u.Listadodts("1=1"));
            reportViewergenerico.LocalReport.DataSources.Add(source);

            reportViewergenerico.LocalReport.Refresh();
        }

       
    }
}