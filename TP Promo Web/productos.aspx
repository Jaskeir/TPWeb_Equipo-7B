<%@ Page Title="" Language="C#" MasterPageFile="~/masterPage.Master" AutoEventWireup="true" CodeBehind="productos.aspx.cs" Inherits="TP_Promo_Web.WebForm3" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <%--
        <form class="card">
        <div class="row row-cols-1 row-cols-md-3 g-4">
        <div class="col">
            <div class="card">
                <img src="..." class="card-img-top" alt="...">
                <div class="card-body">
                    <h5 class="card-title">Card title</h5>
                    <p class="card-text">This is a longer card with supporting text below as a natural lead-in to additional content. This content is a little bit longer.</p>
                </div>
            </div>
        </div>
    </div>
        </form>--%>

    <div class="row">
        <asp:Repeater ID="rptArticulos" runat="server">
            <ItemTemplate>
                <div class="col-md-3 g-4">
                    <div class="card h-100">
                        <div id="carouselExampleDark" class="carousel carousel-dark slide">
                            <div class="carousel-inner">
                                <asp:Repeater ID="rptImagenes" runat="server">
                                    <ItemTemplate>
                                        <div class='carousel-item active'>
                                            <img src='https://i.blogs.es/821b82/captura-de-pantalla-2021-03-25-a-las-16.23.17/650_1200.jpg' class="d-block w-100" alt="https://i.blogs.es/821b82/captura-de-pantalla-2021-03-25-a-las-16.23.17/650_1200.jpg">
                                        </div>
                                    </ItemTemplate>
                                </asp:Repeater>
                            </div>
                            <button class="carousel-control-prev" type="button" data-bs-target="#carouselExampleDark" data-bs-slide="prev">
                                <span class="carousel-control-prev-icon" aria-hidden="true"></span>
                                <span class="visually-hidden">Previous</span>
                            </button>
                            <button class="carousel-control-next" type="button" data-bs-target="#carouselExampleDark" data-bs-slide="next">
                                <span class="carousel-control-next-icon" aria-hidden="true"></span>
                                <span class="visually-hidden">Next</span>
                            </button>
                        </div>

                        <div class="card-body">
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


<%--<div class="col-md-3 mb-3">
    <div class="card h-100">
        <%--<img src='<%# Eval("ImagenURL") %>' class="card-img-top" alt="Imagen del producto">
        <div class="card-body">
            <h5 class="card-title"><%# Eval("Nombre") %></h5>
          <%--  <p class="card-text"><%# Eval("Descripcion") %></p>
            <p class="card-text"><strong>Marca:</strong> <%# Eval("Marca.Nombre") %></p>
            <p class="card-text"><strong>Precio:</strong> $<%# Eval("Precio", "{0:N2}") %></p>
            <a href="#" class="btn btn-primary">Canjear</a>
        </div>
    </div>
</div>--%>