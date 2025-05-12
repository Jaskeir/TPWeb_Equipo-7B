<%@ Page Title="" Language="C#" MasterPageFile="~/masterPage.Master" AutoEventWireup="true" CodeBehind="datosClientes.aspx.cs" Inherits="TP_Promo_Web.WebForm2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <form id="form1" runat="server">
        <h2>Artículo a canjear:</h2>
        <asp:Label ID="productName" runat="server" Text=""></asp:Label>
        <div class="row">

            <div class="col-md-3">
                <label for="txtDNI" class="form-label">DNI</label>
                <div class="d-flex align-items-center">
                    <asp:TextBox runat="server" ID="txtDNI" CssClass="form-control" AutoPostBack="true" OnTextChanged="txtDNI_TextChanged" />
                    <asp:Label ID="errorDNI" runat="server" CssClass="text-danger small d-inline" />
                </div>
            </div>

            <div class="col-md-4">
                <label for="txtname" class="form-label">Nombre</label>
                <div class="d-flex align-items-center">
                    <asp:TextBox Style="margin-right: 10px;" runat="server" ID="txtname" CssClass="form-control me-2" />
                    <asp:Label ID="errorNombre" runat="server" CssClass="text-danger small d-inline" />
                </div>
            </div>

            <div class="col-md-4">
                <label for="txtApel" class="form-label">Apellido</label>
                <div class="d-flex align-items-center">
                    <asp:TextBox Style="margin-right: 10px;" runat="server" ID="txtApel" CssClass="form-control" />
                    <asp:Label ID="errorApel" runat="server" CssClass="text-danger small d-inline" />
                </div>
            </div>

            <div class="col-md-4">
                <label for="txtDirec" class="form-label">Email</label>
                <div class="d-flex align-items-center">
                    <asp:TextBox runat="server" ID="txtEmail" CssClass="form-control" />
                    <asp:Label ID="errorEmail" runat="server" CssClass="text-danger small d-inline" />
                </div>
            </div>

            <div class="col-md-4">
                <label for="txtDirec" class="form-label">Dirección</label>
                <div class="d-flex align-items-center">
                    <asp:TextBox runat="server" ID="txtDirec" CssClass="form-control" />
                    <asp:Label ID="errorDirec" runat="server" CssClass="text-danger small d-inline" />
                </div>
            </div>

            <div class="col-md-4">
                <label for="txtciud" class="form-label">Ciudad</label>
                <div class="d-flex align-items-center">
                    <asp:TextBox runat="server" ID="txtciud" CssClass="form-control" />
                    <asp:Label ID="errorCiud" runat="server" CssClass="text-danger small d-inline" />
                </div>
            </div>

            <div class="col-md-4">
                <label for="txtCP" class="form-label">Código Postal</label>
                <div class="d-flex align-items-center">
                    <asp:TextBox runat="server" ID="txtCP" CssClass="form-control" />
                    <asp:Label ID="errorCp" runat="server" CssClass="text-danger small d-inline" />
                </div>
            </div>

            <div class="col-12">
                <asp:Button Text="Participar!" ID="btnParticipar" class="btn btn-primary" OnClick="btnParticipar_Click" runat="server" Style="margin-top: 10px;" />
            </div>

        </div>
    </form>

</asp:Content>




