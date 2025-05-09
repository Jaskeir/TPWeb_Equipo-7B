<%@ Page Title="" Language="C#" MasterPageFile="~/masterPage.Master" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="TP_Promo_Web.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="formDefault" runat="server">
        <div class="row" style="margin:10px">
            <div class="col-4"></div>
                <div class="col">
                    <asp:TextBox ID="insertCode" runat="server" CssClass="form-control" placeholder ="Ingrese su codigo de voucher" style="margin-bottom:10px"></asp:TextBox>
                    <asp:Button Text="Canjear" ID="btnCanjear" CssClass="btn btn-primary" runat="server" OnClick="btnCanjear_Click" />
                </div>
                
            <div class="col-4"></div>
        </div>
    </form>
</asp:Content>