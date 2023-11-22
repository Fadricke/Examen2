<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="USUARIOS.aspx.cs" Inherits="Examen2.USUARIOS" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="text-center">
         <br />
         <br />
        <h1 style="color:ghostwhite;">USUARIOS</h1>  
    </div>

    <br />
    <br />
    <asp:GridView runat="server" ID="datagrid" PageSize="10" HorizontalAlign="Center"
        CssClass="mydatagrid" PagerStyle-CssClass="pager" HeaderStyle-CssClass="header"
        RowStyle-CssClass="rows" AllowPaging="True" />

    <br />
    <br />
    <div class="container text-center">
    <font color="#FFFFFF"> UsuarioID: </font> <asp:TextBox ID="txtUsuarioID" class="form-control" runat="server"></asp:TextBox>
            <br />
    <font color="#FFFFFF"> Nombre: </font> <asp:TextBox ID="txtNombre" class="form-control" runat="server"></asp:TextBox>
            <br />
    <font color="#FFFFFF"> Correo Electronico: </font> <asp:TextBox ID="txtCorreo" class="form-control" runat="server"></asp:TextBox>
            <br />
    <font color="#FFFFFF"> Telefono: </font> <asp:TextBox ID="txtTelefono" class="form-control" runat="server"></asp:TextBox>
    </div>
    <br />
    <br />
 <div class="container text-center">

    <asp:Button ID="btnAgregar" class="btn btn-dark" runat="server" Text="Agregar" OnClick="btnAgregar_Click"  />
    <asp:Button ID="btnBorrar" class="btn btn-dark" runat="server" Text="Borrar" OnClick="btnBorrar_Click"  />
    <asp:Button ID="btnModificar" runat="server" class="btn btn-dark" Text="Modificar" OnClick="btnModificar_Click" />
    <asp:Button ID="btnconsultar" runat="server" class="btn btn-dark" Text="Consultar" OnClick="btnconsultar_Click"  />
    
</div>

</asp:Content>
