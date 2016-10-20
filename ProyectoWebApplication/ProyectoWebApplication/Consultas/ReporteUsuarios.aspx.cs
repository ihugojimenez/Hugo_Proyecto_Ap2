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

        }

        private void Configurar(ReportViewer reportViewergenerico, DataSet data)
        {
            reportViewergenerico.LocalReport.DataSources.Clear();
            reportViewergenerico.ProcessingMode = ProcessingMode.Local;

            reportViewergenerico.LocalReport.ReportPath = @"Reportes\UsersReport.rdlc";

            ReportDataSource source = new ReportDataSource("Usuarios", data);
            reportViewergenerico.LocalReport.DataSources.Add(source);

            reportViewergenerico.LocalReport.Refresh();
        }
    }
}