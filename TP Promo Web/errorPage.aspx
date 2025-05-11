<%@ Page Title="" Language="C#" MasterPageFile="~/masterPage.Master" AutoEventWireup="true" CodeBehind="errorPage.aspx.cs" Inherits="TP_Promo_Web.WebForm5" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="errorPage" runat="server">
        <h2 id="mensajeError" runat="server" style="color: red">MENSAJE</h2>
        <asp:Button ID="btnVolverAtras" runat="server" CssClass="btn btn-primary" OnClick="btnVolverAtras_Click" Text="Volver atras" />
        <br />
    </form>
</asp:Content>
