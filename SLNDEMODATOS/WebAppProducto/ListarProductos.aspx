<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListarProductos.aspx.cs" Inherits="WebAppProducto.ListarProductos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Button ID="btnInsertar" runat="server" Text="Insertar Producto" OnClick="btnInsertar_Click" />
        <asp:Button ID="btnInsertarCategoria" runat="server" OnClick="btnInsertarCategoria_Click" Text="Insertar Categoria" Width="151px" />
        <p>
            <asp:Button ID="btnModificar" runat="server" OnClick="btnModificar_Click" Text="Modificar Producto" Width="139px" />
            <asp:Button ID="btnModificarCategoria" runat="server" OnClick="btnModificarCategoria_Click" Text="Modificar Categoria" Width="171px" />
        </p>
        <asp:Button ID="btnEliminar" runat="server" OnClick="btnEliminar_Click" Text="Eliminar Producto" Width="133px" />
        <asp:Button ID="btnEliminarCategoria" runat="server" OnClick="btnEliminarCategoria_Click" Text="Eliminar Categoria" Width="168px" />
        <asp:GridView ID="gridProducto" runat="server" Height="164px" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" style="margin-right: 0px" Width="219px">
        </asp:GridView>
        <asp:Label ID="txtColor" runat="server" Text="Traer por Color"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:Button ID="btnTraerPorColor" runat="server" Text="Filtrar" Width="96px" />
        <asp:DropDownList ID="cbColor" runat="server" OnSelectedIndexChanged="cbColor_SelectedIndexChanged" style="height: 22px" AutoPostBack="True">
        </asp:DropDownList>
    </form>
</body>
</html>
