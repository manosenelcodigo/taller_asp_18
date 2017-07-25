<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

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
                    <p>
                        <a href="Add.aspx" class="btn btn-success">Agregar</a>
                    </p>
                    <table class="table table-bordered">
                        <thead>
                            <tr>
                                <th>ID</th>
                                <th>Nombre</th>
                                <th>Foto</th>
                            </tr>
                        </thead>
                        <tbody>
                            <%
                                while(getRegistro().Read())
                                    {
                                    %>
                                    <tr>
                                        <td><%=getRegistro()["id"] %></td>
                                        <td><%=getRegistro()["nombre"] %></td>
                                        <td><img width="100" height="100" src="public/uploads/clientes/<%=getRegistro()["foto"] %>" /></td>
                                    </tr>
                                    <%
                                    }
                            %>
                        </tbody>
                    </table>
                </div>
        </div>
        </div>
   
</body>
</html>
