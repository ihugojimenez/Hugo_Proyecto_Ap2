<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMaster.Master" AutoEventWireup="true" CodeBehind="RegistroUsuarios.aspx.cs" Inherits="ProyectoWebApplication.RegistroUsuarios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <br/>
    <br/>
    <br/>

    
    <!-- Header -->
    <%--<input type="text" class="form-control" placeholder="Nombres*" id="UserName"/>--%>

      
     <section id="Registro">
        <div class="container">
            <div class="row">
                <div class="col-lg-12 text-center">
                    <h2 class="section-heading">Registro de Usuarios</h2>
                </div>
            </div>
            <div class="row">
                <div class="col-lg-12">
                        <div class="row">

                            <div class="col-lg-11">
                                <div class="col-md-4">
                                    <div class="form-group">
                                    <asp:TextBox ID="IdTextBox" CssClass="form-control"  runat="server"></asp:TextBox>
                                    <asp:Label ID="Label5" runat="server" Text="ID"></asp:Label>
                                </div>

                                </div>

                                <div class="col-md-4">
                                    <div class="form-group">
                                    <div id="Buscar">
                                        <asp:Button ID="SearchButton" CssClass="btn navbar-btn btn-lg" runat="server" Text="Buscar" Height="39px" />
                                    </div>
                                </div>

                                </div>


                                  
                            </div>


                            <div class="col-md-6">
                              
                                    <div class="form-group">
                                        <%--<div class="form-group">
                                    <div id="Buscar">
                                        <asp:Button ID="Button1" CssClass="btn navbar-btn btn-lg" runat="server" Text="Buscar" Height="39px" />
                                    </div>
                                </div>--%>
                                    <asp:TextBox ID="NameTextBox" CssClass="form-control"  runat="server"></asp:TextBox>
                                    <asp:Label ID="Label2" runat="server" Text="Nombres: "></asp:Label>
                                </div>

                                
                                <div class="form-group">
                                    <asp:TextBox ID="PassTextBox" CssClass="form-control" runat="server"></asp:TextBox>
                                    <asp:Label ID="Label3" runat="server" Text="Contraseña"></asp:Label>
                                </div>                                
                            </div>


                            <div class="col-md-6">
                                <%--<div class="form-group">
                                    <textarea class="form-control" placeholder="Your Message *" id="message" required data-validation-required-message="Please enter a message."></textarea>
                                    <p class="help-block text-danger"></p>
                                </div>--%>

                                <div class="form-group">
                                    <asp:TextBox ID="UserNameTextBox" CssClass="form-control" runat="server"></asp:TextBox>
                                    <asp:Label ID="Label1" runat="server" Text="Nombre de Usuario"></asp:Label>
                                </div>
                                <div class="form-group">
                                    <asp:TextBox ID="RpassTextBox" CssClass="form-control" runat="server"></asp:TextBox>
                                    <asp:Label ID="Label4" runat="server" Text="Repetir contraseña"></asp:Label>
                                </div>
                                <%--<div class="form-group">
                                    <textarea class="form-control" placeholder="Your Message *" id="message" required data-validation-required-message="Please enter a message."></textarea>
                                    <p class="help-block text-danger"></p>
                                </div>--%>
                                <div class="form-group">
                                    <asp:Label ID="Label6" runat="server" Text="Tipo de Usuario"></asp:Label>
                                &nbsp;
                                    <asp:DropDownList ID="TipoDropDownList" CssClass="form-control" runat="server">
                                    </asp:DropDownList>
                                </div>
                            </div>


                            <div class="clearfix"></div>
                            <div class="col-lg-12 text-center">
                                <%--<button type="submit" class="btn btn-xl" id="NewButton">Nuevo</button>--%>
                                <asp:Button ID="NewButton" class="btn btn-warning" runat="server" Text="Nuevo" Height="39px" Width="104px" OnClick="NewButton_Click" />
                                
                            &nbsp;&nbsp;&nbsp;
                                <asp:Button ID="SaveButton" class="btn btn-success" runat="server" Text="Guardar" Height="39px" Width="104px" />
&nbsp;&nbsp;
                                <asp:Button ID="DeleteButton" CssClass="btn btn-danger" runat="server" Text="Eliminar" Height="39px" Width="104px"  />
                                
                            </div>
                        </div>
                    
                </div>
            </div>
        </div>
    </section>




        


</asp:Content>
