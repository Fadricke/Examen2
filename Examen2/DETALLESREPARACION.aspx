<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="DETALLESREPARACION.aspx.cs" Inherits="Examen2.DETALLESREPARACION" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
            <div class="text-center">
        <br />
        <br />
        <h1 style="color:ghostwhite;">DETALLES DE REPARACION</h1>     
    </div>
        <br />
    <br />
    <asp:GridView runat="server" ID="datagrid" PageSize="10" HorizontalAlign="Center"
        CssClass="mydatagrid" PagerStyle-CssClass="pager" HeaderStyle-CssClass="header"
        RowStyle-CssClass="rows" AllowPaging="True" />

    <br />
    <br />
    <div class="container text-center">
            <br />
    <font color="#FFFFFF"> DetalleID: </font> <asp:TextBox ID="TextBox1" class="form-control" runat="server"></asp:TextBox>
            <br />  
    <font color="#FFFFFF"> Reparacion ID: </font> <asp:TextBox ID="txtReparacionID" class="form-control" runat="server"></asp:TextBox>
            <br />
   <font color="#FFFFFF"> Descripcion: </font> <asp:TextBox ID="txtDescripcion" class="form-control" runat="server"></asp:TextBox>
            <br />
   <font color="#FFFFFF"> FechaFin: </font><asp:TextBox ID="txtFechaFin" class="form-control" runat="server"></asp:TextBox>
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
