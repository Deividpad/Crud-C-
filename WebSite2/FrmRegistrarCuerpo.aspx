<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="FrmRegistrarCuerpo.aspx.cs" Inherits="FrmRegistrarCuerpo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div id="content">
  <div id="content-header">
    <div id="breadcrumb"> <a href="FrmListarSoldados.aspx" title="Go to Home" class="tip-bottom"><i class="icon-home"></i> Home</a> <a href="#" class="tip-bottom">Cuerpo</a></div>
    <h1 style="text-align: center;">Cuerpo</h1>
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
                  <label style="width: 180px; text-align: end;">Denominación :</label>
                </div>
                <div class="span6" style="margin-left: 32px;">
                    <asp:TextBox ID="txbdenominacion" runat="server" Width="111%"></asp:TextBox>
                </div>
              </div>              
              <div class="form-actions">
                <asp:Button ID="btnRegistrar" runat="server" OnClick="btnRegistrar_Click" Text="Registrar" CssClass="btn btn-success" />
                  <asp:Label ID="lblmensaje" runat="server" Text="."></asp:Label>
                  <asp:TextBox ID="txbid" runat="server" Width="35px"></asp:TextBox>
              </div>
              <div class="form-actions">
                  <div class="row-fluid" style="margin-top: 12px;">
                    <div class="span4">
                        <asp:Button ID="btnBuscar" runat="server" OnClick="btnBuscar_Click" Text="Buscar" CssClass="btn btn-primary"/>
                    </div>
                    <div class="span4">
                        <asp:Button ID="btnEditar" runat="server" Text="Editar" OnClick="btnEditar_Click" CssClass="btn btn-info"/>
                    </div>
                    <div class="span4">
                        <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" OnClick="btnEliminar_Click" CssClass="btn btn-danger"/>
                    </div>
                  </div>
              </div>
          </div>
        </div>
      </div>    
    </div>
  </div>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Id_Cuerpo" DataSourceID="SqlDataSource1" CssClass="table table-bordered table-striped">
        <Columns>
            <asp:BoundField DataField="Id_Cuerpo" HeaderText="Id_Cuerpo" InsertVisible="False" ReadOnly="True" SortExpression="Id_Cuerpo" />
            <asp:BoundField DataField="Denominación" HeaderText="Denominación" SortExpression="Denominación" />
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:BD_MilitarConnectionString1 %>" SelectCommand="SELECT * FROM [Cuerpo]"></asp:SqlDataSource>
</div>
</asp:Content>

