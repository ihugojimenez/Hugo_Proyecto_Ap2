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
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="IdTextBox" ErrorMessage="Favor ingrese el Id" ForeColor="#CC0000" ValidationGroup="Delete&amp;Search">*</asp:RequiredFieldValidator>
                                </div>

                                </div>

                                <div class="col-md-4">
                                    <div class="form-group">
                                    <div id="Buscar">
                                        <asp:Button ID="SearchButton" CssClass="btn navbar-btn btn-lg" runat="server" Text="Buscar" Height="39px" OnClick="SearchButton_Click" ValidationGroup="Delete&amp;Search" />
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
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="NameTextBox" ErrorMessage="Favor Ingresar su Nombre" ForeColor="#CC0000" ValidationGroup="SaveGroup">*</asp:RequiredFieldValidator>
                                </div>

                                
                                <div class="form-group">
                                    <asp:TextBox ID="PassTextBox" CssClass="form-control" runat="server"></asp:TextBox>
                                    <asp:Label ID="Label3" runat="server" Text="Contraseña"></asp:Label>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="PassTextBox" ErrorMessage="Favor ingrese la contraseña" ForeColor="#CC0000" ValidationGroup="SaveGroup">*</asp:RequiredFieldValidator>
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
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="UserNameTextBox" ErrorMessage="Favor ingrese su nombre de Usuario" ForeColor="#CC0000" ValidationGroup="SaveGroup">*</asp:RequiredFieldValidator>
                                </div>
                                <div class="form-group">
                                    <asp:TextBox ID="RpassTextBox" CssClass="form-control" runat="server"></asp:TextBox>
                                    <asp:Label ID="Label4" runat="server" Text="Repetir contraseña"></asp:Label>
                                    <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="PassTextBox" ControlToValidate="RpassTextBox" ErrorMessage="Las contraseñas no coinciden" ForeColor="#CC0000" ValidationGroup="SaveGroup">*</asp:CompareValidator>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="RpassTextBox" ErrorMessage="Favor Repita la contraseña" ForeColor="#CC0000" ValidationGroup="SaveGroup">*</asp:RequiredFieldValidator>
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

                            
                            
                            <div class="col-lg-12 text-center">
                                <div class="clearfix">
                                <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="#CC0000" ValidationGroup="SaveGroup" />
                            </div>
                                <%--</div>
                <asp:ValidationSummary ID="ValidationSummary2" runat="server" ForeColor="#CC0000" ValidationGroup="Delete&amp;Search" />
            </div>--%>

                                <%--<button type="submit" class="btn btn-xl" id="NewButton">Nuevo</button>--%>
                                <asp:Button ID="NewButton" class="btn btn-warning" runat="server" Text="Nuevo" Height="39px" Width="104px" OnClick="NewButton_Click" />
                                
                            &nbsp;&nbsp;&nbsp;
                                <asp:Button ID="SaveButton" class="btn btn-success" runat="server" Text="Guardar" Height="39px" Width="104px" OnClick="SaveButton_Click" ValidationGroup="SaveGroup" />
&nbsp;&nbsp;
                                <asp:Button ID="DeleteButton" CssClass="btn btn-danger" runat="server" Text="Eliminar" Height="39px" Width="104px" OnClick="DeleteButton_Click" ValidationGroup="Delete&amp;Search"  />
                                
                            </div>
                        </div>
                    
                </div>
        </div>
    </section>




        


</asp:Content>
