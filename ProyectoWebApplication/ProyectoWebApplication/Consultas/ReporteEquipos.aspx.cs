using BLL;
using Microsoft.Reporting.WebForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoWebApplication.Consultas
{
    public partial class ReporteEquipos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                Configurar(EquiposReportViewer);
            }
        }

        private void Configurar(ReportViewer reportViewergenerico)
        {
            Equipos eq = new Equipos();

            reportViewergenerico.LocalReport.DataSources.Clear();
            reportViewergenerico.ProcessingMode = ProcessingMode.Local;

            reportViewergenerico.LocalReport.ReportPath = @"Reportes\UsersReport.rdlc";

            ReportDataSource source = new ReportDataSource("Equipos", eq.Listadodts("1=1"));
            reportViewergenerico.LocalReport.DataSources.Add(source);

            reportViewergenerico.LocalReport.Refresh();
        }
    }
}