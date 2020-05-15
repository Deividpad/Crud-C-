<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="FrmRegistrarSoldado.aspx.cs" Inherits="FrmRegistrarSoldado" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div id="content">
  <div id="content-header">
    <div id="breadcrumb"> <a href="FrmListarSoldados.aspx" title="Go to Home" class="tip-bottom"><i class="icon-home"></i> Home</a> <a href="#" class="tip-bottom">Soldado</a></div>
    <h1 style="text-align: center;">Soldados</h1>
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
                  <label style="width: 180px; text-align: end;">Nombres :</label>
                </div>
                <div class="span6" style="margin-left: 32px;">
                    <asp:TextBox ID="txbNombres" runat="server" Width="111%"></asp:TextBox>
                </div>
              </div>
              <div class="row-fluid">
                <div class="span4">
                  <label style="width: 180px; text-align: end;">Apellidos :</label>
                </div>
                <div class="span6" style="margin-left: 32px;">
                    <asp:TextBox ID="txbApellidos" runat="server" Width="111%"></asp:TextBox>
                </div>
              </div>
              <div class="row-fluid">
                <div class="span4">
                  <label style="width: 180px; text-align: end;">Fecha de Graduación :</label>
                </div>
                <div class="span6" style="margin-left: 32px;">
                    <asp:TextBox ID="txbFechaGraduacion" runat="server" TextMode="Date" Width="111%"></asp:TextBox>
                    <asp:TextBox ID="txbEditarFechaGraduacion" runat="server" Width="111%"></asp:TextBox>
                </div>
              </div>
              <div class="row-fluid" style="margin-top: 5px;">
                <div class="span4">
                  <label style="width: 180px; text-align: end;">Compañía :</label>
                </div>
                <div class="span6" style="margin-left: 32px;">
                    <asp:DropDownList ID="cmbCompania" runat="server" DataSourceID="SqlDataSource1" DataTextField="Actividad" DataValueField="Id_Compania" Width="116%">
                    </asp:DropDownList>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:BD_MilitarConnectionString1 %>" SelectCommand="SELECT * FROM [Compania]" ></asp:SqlDataSource>
                </div>
              </div>
              <div class="row-fluid" style="margin-top: 12px;">
                <div class="span4">
                  <label style="width: 180px; text-align: end;">Cuartel :</label>
                </div>
                <div class="span6" style="margin-left: 32px;">
                    <asp:DropDownList ID="cmbCuartel" runat="server" DataSourceID="SqlDataSource2" DataTextField="Nombre" DataValueField="Id_Cuartel" Width="116%">
                    </asp:DropDownList>
                    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:BD_MilitarConnectionString1 %>" SelectCommand="SELECT * FROM [Cuartel]"></asp:SqlDataSource>
                </div>
              </div>
              <div class="row-fluid" style="margin-top: 12px;">
                <div class="span4">
                  <label style="width: 180px; text-align: end;">Cuerpo :</label>
                </div>
                <div class="span6" style="margin-left: 32px;">
                    <asp:DropDownList ID="cmbCuerpo" runat="server" DataSourceID="SqlDataSource3" DataTextField="Denominación" DataValueField="Id_Cuerpo" Width="116%">
                    </asp:DropDownList>
                    <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:BD_MilitarConnectionString1 %>" SelectCommand="SELECT * FROM [Cuerpo]"></asp:SqlDataSource>
                </div>
              </div>            
              <div class="form-actions">
                <asp:Button ID="btnRegistrar" runat="server" OnClick="btnRegistrar_Click" Text="Registrar" CssClass="btn btn-success" />
                  <asp:Label ID="lblEstado" runat="server" Text="."></asp:Label>
                  <asp:TextBox ID="txtId" runat="server" Width="35px"></asp:TextBox>
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
</div>
</asp:Content>