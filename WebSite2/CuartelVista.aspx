<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="CuartelVista.aspx.cs" Inherits="CuartelVista" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div id="content">
  <div id="content-header">
    <div id="breadcrumb"> <a href="FrmListarSoldados.aspx" title="Go to Home" class="tip-bottom"><i class="icon-home"></i> Home</a> <a href="#" class="tip-bottom">Cuartel</a></div>
    <h1 style="text-align: center;">Cuartel</h1>
  </div>
  <div class="container-fluid">
    <hr>
    <div class="row-fluid">
      <div class="span3"></div>
      <div class="span6">
        <div class="widget-box">
          <div class="widget-title"> <span class="icon"> <i class="icon-align-justify"></i> </span>
            <h5>Registro-Actualización</h5>
          </div>
          <div class="widget-content nopadding">
              <div class="row-fluid">
                <div class="span4">
                  <label style="width: 180px; text-align: end;">Nombre :</label>
                </div>
                <div class="span6" style="margin-left: 32px;">
                    <asp:TextBox ID="txbNombre" runat="server" Width="111%"></asp:TextBox>
                </div>
              </div>
              <div class="row-fluid">
                <div class="span4">
                  <label style="width: 180px; text-align: end;">Ubicacion :</label>
                </div>
                <div class="span6" style="margin-left: 32px;">
                    <asp:TextBox ID="txbUbicacion" runat="server" Width="111%"></asp:TextBox>
                </div>
              </div>               
              <div class="form-actions">
                <asp:Button ID="btnAgregar" runat="server" OnClick="btnAgregar_Click1" Text="Agregar" CssClass="btn btn-success"/>
                  <asp:Label ID="LbEstado" runat="server" Text="."></asp:Label>
                  <asp:TextBox ID="txbCodigo" runat="server" Width="35px"></asp:TextBox>
              </div>
              <div class="form-actions">
                  <div class="row-fluid" style="margin-top: 12px;">
                    <div class="span4">
                        <asp:Button ID="Buscar" runat="server" OnClick="Buscar_Click" Text="Buscar" CssClass="btn btn-primary"/>
                    </div>
                    <div class="span4">
                        <asp:Button ID="Editar" runat="server" OnClick="Editar_Click" Text="Editar" CssClass="btn btn-info"/>
                    </div>
                    <div class="span4">
                        <asp:Button ID="Eliminar" runat="server" OnClick="Eliminar_Click" style="margin-top: 0px" Text="Eliminar" CssClass="btn btn-danger"/>
                    </div>
                  </div>
              </div>
          </div>
        </div>
      </div>    
    </div>
  </div>    
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Id_Cuartel" DataSourceID="SqlDataSource1" CssClass="table table-bordered table-striped">
        <Columns>
            <asp:BoundField DataField="Id_Cuartel" HeaderText="Id_Cuartel" InsertVisible="False" ReadOnly="True" SortExpression="Id_Cuartel" />
            <asp:BoundField DataField="Nombre" HeaderText="Nombre" SortExpression="Nombre" />
            <asp:BoundField DataField="Ubicacion" HeaderText="Ubicacion" SortExpression="Ubicacion" />
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:BD_MilitarConnectionString1 %>" SelectCommand="SELECT * FROM [Cuartel]"></asp:SqlDataSource>
</div>
</asp:Content>

