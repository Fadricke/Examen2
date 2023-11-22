<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="EQUIPOS.aspx.cs" Inherits="Examen2.EQUIPOS" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="text-center">
         <br />
         <br />
        <h1 style="color:ghostwhite;">EQUIPOS</h1>   
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
    <font color="#FFFFFF"> Tipo: </font> <asp:TextBox ID="txtTipo" class="form-control" runat="server"></asp:TextBox>
            <br />
    <font color="#FFFFFF"> Modelo: </font> <asp:TextBox ID="txtModelo" class="form-control" runat="server"></asp:TextBox>
        <br />
    <font color="#FFFFFF"> Usuario ID: </font> <asp:TextBox ID="txtUsuarioID_Equipo" class="form-control" runat="server"></asp:TextBox>
    </div>
    <br />
    <br />
 <div class="container text-center">

    <asp:Button ID="btnAgregar" class="btn btn-dark" runat="server" Text="Agregar" OnClick="btnAgregar_Click"   />
    <asp:Button ID="btnBorrar" class="btn btn-dark" runat="server" Text="Borrar" OnClick="btnBorrar_Click"   />
    <asp:Button ID="btnModificar" runat="server" class="btn btn-dark" Text="Modificar" OnClick="btnModificar_Click"  />
    <asp:Button ID="btnconsultar" runat="server" class="btn btn-dark" Text="Consultar" OnClick="btnconsultar_Click"  />
    
</div>
</asp:Content>
