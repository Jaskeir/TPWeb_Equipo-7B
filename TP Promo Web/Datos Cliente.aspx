<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Datos Cliente.aspx.cs" Inherits="TP_Promo_Web.Datos_Cliente" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Promo WEB</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.6/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-4Q6Gf2aSP4eDXB8Miphtr37CMZZQ5oXLH2yaXMJ2w8e2ZtHTl7GptT4jmndRuHDT" crossorigin="anonymous">
<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.6/dist/js/bootstrap.bundle.min.js" integrity="sha384-j1CDi7MgGQ12Z7Qab0qlWQ/Qqz24Gc6BM0thvEMVjHnfYGF0rmFCozFSxQBxwHKO" crossorigin="anonymous"></script>

</head>
<body>
    <form id="form1" runat="server">
        <div>
            <!----------*******************************************************--->
            <header>FELICIDADES!! CANJEA TU VOUCHER!!</header> <!----------*****deberia quedar formato con la master page ************--->
       
            <div class="row">
                
    <div class="col-md-3">
  <label for="txtDNI" class="form-label">DNI</label>
   <asp:TextBox runat="server" ID="txtDNI" CssClass="form-control" required/>
</div>

   <div class="col-md-4">
    <label for="txtname" class="form-label">Nombre</label>
     <asp:TextBox runat="server" ID="tntname" CssClass="form-control" required/>  
  </div>

  <div class="col-md-4">
     <label for="txtApel" class="form-label">Apellido</label>
 <asp:TextBox runat="server" ID="txtApel" CssClass="form-control" required/>  
  </div>

   <div class="col-md-4">
    <label for="txtDirec" class="form-label">Dirección</label>
<asp:TextBox runat="server" ID="txtDirec" CssClass="form-control" required/>  
 </div>

   <div class="col-md-4">
    <label for="txtciud" class="form-label">Ciudad</label>
<asp:TextBox runat="server" ID="txtciud" CssClass="form-control" required/>  
 </div>

   <div class="col-md-4">
    <label for="txtCP" class="form-label">Código Postal</label>
<asp:TextBox runat="server" ID="txtCP" CssClass="form-control" required/>  
 </div>
  
  <div class="col-12">
    
      <asp:Button Text="Canjear" ID="btnCanjear"   class="btn btn-primary"  OnClick="btnCanjear_Click" runat="server"  />
  </div>
  </div>
               
            <!----------*******************************************************--->

        </div>
    </form>
</body>
</html>
