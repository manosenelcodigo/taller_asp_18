<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Add.aspx.cs" Inherits="Add" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta charset="utf-8"/>
    <title>Upload de Archivos</title>
    <link href="public/css/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
        <div class="container">
            <div class="panel panel-primary">
                <div class="panel-heading">Upload de Archivos</div>
                <div class="panel-body">
                    <ol class="breadcrumb">
                      <li><a href="Default.aspx">Inicio</a></li>
                      <li class="active">Subir Archivo</li>
                    </ol>
                    <!--formulario-->
                    <form runat="server" method="post"  id="form">
                        <p>
                         <span runat="server" id="texto"></span>
                        <asp:ValidationSummary runat="server" HeaderText="" DisplayMode="BulletList" CssClass="alert alert-danger" />
                        </p>
                        <p>
                        <asp:Label runat="server" >Nombre:</asp:Label>
                        <asp:TextBox ID="nombre" runat="server" CssClass="form-control" />
                        <asp:RequiredFieldValidator runat="server" ControlToValidate="nombre" ErrorMessage="El campo nombre es requerido" Display="None"></asp:RequiredFieldValidator>
                        </p>
                        <p>
                        <asp:Label runat="server" >Foto:</asp:Label>
                        <asp:FileUpload ID="foto" runat="server" CssClass="form-control" />
                        </p>
                        <hr />
                    <asp:Button ID="enviar_form" runat="server" Text="Enviar" CssClass="btn btn-default" OnClick="ProcesarFormulario"/>
                    </form>

                    <!--/formulario-->

                </div>
        </div>
        </div>
   
</body>
</html>

