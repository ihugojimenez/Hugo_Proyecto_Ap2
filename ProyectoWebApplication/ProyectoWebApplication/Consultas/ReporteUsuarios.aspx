<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMaster.Master" AutoEventWireup="true" CodeBehind="ReporteUsuarios.aspx.cs" Inherits="ProyectoWebApplication.Consultas.ReporteUsuarios" %>
<%@ Register assembly="Microsoft.ReportViewer.WebForms, Version=12.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br/>
    <br/>
    <div class="row">
                <div class="col-lg-12 text-center">
<rsweb:ReportViewer ID="UsuariosReportViewer" runat="server" Width="501px">                    
                </div>
            </div>
    
    </rsweb:ReportViewer>
    <br/>
    <br />

</asp:Content>
