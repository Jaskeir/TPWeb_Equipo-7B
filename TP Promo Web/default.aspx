<%@ Page Title="" Language="C#" MasterPageFile="~/masterPage.Master" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="TP_Promo_Web.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="formDefault" runat="server">
        <div class="row">
            <div class="col-4"></div>
                <div class="col">
                    <asp:TextBox ID="insertCode" runat="server" CssClass="form-control"></asp:TextBox>
                    <asp:Button Text="Canjear" ID="btnCanjear" CssClass="btn btn-primary" runat="server" OnClick="btnCanjear_Click" />
                </div>
                <div class="col">
                    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                </div>
            <div class="col-4"></div>
        </div>
    </form>
</asp:Content>