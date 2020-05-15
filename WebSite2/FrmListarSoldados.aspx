<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="FrmListarSoldados.aspx.cs" Inherits="FrmListarSoldados" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div id="content">
    <div id="content-header">
        <div id="breadcrumb"> <a href="FrmListarSoldados.aspx" title="Go to Home" class="tip-bottom"><i class="icon-home"></i> Home</a> <a href="#" class="tip-bottom">Soldado</a></div>
        <h1 style="text-align: center;">Soldados</h1>
    </div>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Id_Soldado" DataSourceID="SqlDataSource1" CssClass="table table-bordered table-striped">
        <Columns>
            <asp:BoundField DataField="Id_Soldado" HeaderText="Id_Soldado" InsertVisible="False" ReadOnly="True" SortExpression="Id_Soldado" />
            <asp:BoundField DataField="Nombres" HeaderText="Nombres" SortExpression="Nombres" />
            <asp:BoundField DataField="Apellidos" HeaderText="Apellidos" SortExpression="Apellidos" />
            <asp:BoundField DataField="F_graduacion" HeaderText="F_graduacion" SortExpression="F_graduacion" />
            <asp:BoundField DataField="Actividad" HeaderText="Actividad" SortExpression="Actividad" />
            <asp:BoundField DataField="Nombre" HeaderText="Nombre" SortExpression="Nombre" />
            <asp:BoundField DataField="Denominación" HeaderText="Denominación" SortExpression="Denominación" />
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:BD_MilitarConnectionString1 %>" SelectCommand="SELECT 
[Soldado].Id_Soldado, [Soldado].Nombres, [Soldado].Apellidos, [Soldado].F_graduacion,
[Compania].Actividad, [Cuartel].Nombre, [Cuerpo].Denominación
FROM [Soldado] 
INNER JOIN [Compania] ON [Soldado].Id_Compania = [Compania].Id_Compania
INNER JOIN [Cuartel] ON [Soldado].Id_Cuartel = [Cuartel].Id_Cuartel
INNER JOIN [Cuerpo] ON [Soldado].Id_Cuerpo = [Cuerpo].Id_Cuerpo"></asp:SqlDataSource>
        </div>
</asp:Content>