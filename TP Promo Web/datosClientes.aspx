<%@ Page Title="" Language="C#" MasterPageFile="~/masterPage.Master" AutoEventWireup="true" CodeBehind="datosClientes.aspx.cs" Inherits="TP_Promo_Web.WebForm2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
        <div>
            
            <div class="row">

                <div class="col-md-3">
                    <label for="txtDNI" class="form-label">DNI</label>
                    <asp:TextBox runat="server" ID="txtDNI" CssClass="form-control" AutoPostBack ="true" OnTextChanged="txtDNI_TextChanged"/>
                </div>

                <div class="col-md-4">
                    <label for="txtname" class="form-label">Nombre</label>
                    <asp:TextBox runat="server" ID="txtname" CssClass="form-control" />
                </div>

                <div class="col-md-4">
                    <label for="txtApel" class="form-label">Apellido</label>
                    <asp:TextBox runat="server" ID="txtApel" CssClass="form-control" />
                </div>

                 <div class="col-md-4">
                    <label for="txtDirec" class="form-label">Email</label>
                    <asp:TextBox runat="server" ID="txtEmail" CssClass="form-control" />
                </div>

                <div class="col-md-4">
                    <label for="txtDirec" class="form-label">Dirección</label>
                    <asp:TextBox runat="server" ID="txtDirec" CssClass="form-control" />
                </div>

                <div class="col-md-4">
                    <label for="txtciud" class="form-label">Ciudad</label>
                    <asp:TextBox runat="server" ID="txtciud" CssClass="form-control" />
                </div>

                <div class="col-md-4">
                    <label for="txtCP" class="form-label">Código Postal</label>
                    <asp:TextBox runat="server" ID="txtCP" CssClass="form-control" />
                </div>

                <div class="col-12">
                    <asp:Button Text="Participar!" ID="btnParticipar" class="btn btn-primary" OnClick="btnCanjear_Click" runat="server" style="margin-top: 10px;" />
                </div>
            </div>
        </div>
    </form>
</asp:Content>



