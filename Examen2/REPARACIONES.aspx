<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="REPARACIONES.aspx.cs" Inherits="Examen2.REPARACIONES" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div class="text-center">
        <br />
        <br />
        <h1 style="color:ghostwhite;">REPARACIONES</h1>     
    </div>
        <br />
    <br />
    <asp:GridView runat="server" ID="datagrid" PageSize="10" HorizontalAlign="Center"
        CssClass="mydatagrid" PagerStyle-CssClass="pager" HeaderStyle-CssClass="header"
        RowStyle-CssClass="rows" AllowPaging="True" />

    <br />
    <br />
    <div class="container text-center">
    <font color="#FFFFFF"> Equipo ID: </font> <asp:TextBox ID="txtEquipoID" class="form-control" runat="server"></asp:TextBox>
            <br />
   <font color="#FFFFFF"> Fecha: </font> <asp:TextBox ID="txtFecha" class="form-control" runat="server"></asp:TextBox>
            <br />
   <font color="#FFFFFF"> Estado: </font><asp:TextBox ID="txtEstado" class="form-control" runat="server"></asp:TextBox>
    </div>
    <br />
    <br />
 <div class="container text-center">

    <asp:Button ID="btnAsignar" class="btn btn-dark" runat="server" Text="Agregar"  />
    <asp:Button ID="btnBorrar" class="btn btn-dark" runat="server" Text="Borrar"  />
    <asp:Button ID="btnModificar" runat="server" class="btn btn-dark" Text="Modificar" />
    <asp:Button ID="btnconsultar" runat="server" class="btn btn-dark" Text="Consultar" />
    
</div>
</asp:Content>
