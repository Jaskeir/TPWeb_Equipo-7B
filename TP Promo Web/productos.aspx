<%@ Page Title="" Language="C#" MasterPageFile="~/masterPage.Master" AutoEventWireup="true" CodeBehind="productos.aspx.cs" Inherits="TP_Promo_Web.WebForm3" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <asp:Repeater ID="rptArticulos" runat="server">
            <ItemTemplate>
                <div class="col-md-3 g-4">
                    <div class="card h-100">
                        <div class="card-body">
                            <div id="carousel<%# Eval("Id") %>" class="carousel slide" data-bs-ride="carousel">

                                <div class="carousel-inner">
                                    <asp:Repeater ID="rptImagenes" runat="server" DataSource=<%# Eval("Imagenes") %>>
                                        <ItemTemplate>
                                            <div class="carousel-item <%# Container.ItemIndex == 0 ? "active" : "" %>">
                                                <img src=<%# Eval("Url") %> class="d-block w-100" alt="...">
                                            </div>
                                        </ItemTemplate>
                                    </asp:Repeater>
                                </div>

                                <button class="carousel-control-prev" type="button" data-bs-target="#carousel<%# Eval("Id") %>" data-bs-slide="prev">
                                    <span class="carousel-control-prev-icon" aria-hidden="true"></span>
                                    <span class="visually-hidden">Anterior</span>
                                </button>
                                <button class="carousel-control-next" type="button" data-bs-target="#carousel<%# Eval("Id") %>" data-bs-slide="next">
                                    <span class="carousel-control-next-icon" aria-hidden="true"></span>
                                    <span class="visually-hidden">Siguiente</span>
                                </button>
                            </div>

                            <h5 class="card-title"><%# Eval("Nombre") %></h5>
                            <p class="card-text"><%# Eval("Descripcion")%></p>
                            
                            <a href="datosClientes.aspx" class="btn btn-primary">Canjear</a> 
                        </div>
                    </div>
                </div>
            </ItemTemplate>
        </asp:Repeater>
    </div>


</asp:Content>
