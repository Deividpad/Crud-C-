using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class FrmRegistrarSoldado : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnRegistrar_Click(object sender, EventArgs e)
    {
        if(txbNombres.Text == "" || txbApellidos.Text == "" || txbFechaGraduacion.Text == "" ) 
        {
            lblEstado.Text = "Campos incompletos";
            txbNombres.Text = "";
            txbApellidos.Text = "";
            txbFechaGraduacion.Text = "";

        }
        else
        {
            try
            {
                ClcSoldado ObjSoldado = new ClcSoldado();
                ObjSoldado.Nombres = txbNombres.Text;
                ObjSoldado.Apellidos = txbApellidos.Text;
                string FechaGraduacioin = txbFechaGraduacion.Text.ToString();
                ObjSoldado.Fgraduacion = FechaGraduacioin;
                int idCompania = int.Parse(cmbCompania.SelectedValue.ToString());
                ObjSoldado.Idcompania = idCompania;
                int idCuartel = int.Parse(cmbCuartel.SelectedValue.ToString());
                ObjSoldado.IdCuartel = idCuartel;
                int idCuerpo = int.Parse(cmbCuerpo.SelectedValue.ToString());
                ObjSoldado.IdCuerpo = idCuerpo;
                ObjSoldado.agregar();
                lblEstado.Text = "Registradon Con Exito";
                txbNombres.Text = "";
                txbApellidos.Text = "";
                txbFechaGraduacion.Text = "";
            }
            catch (Exception)
            {

                lblEstado.Text = "No se Pudo Registrar";
                txbNombres.Text = "";
                txbApellidos.Text = "";
                txbFechaGraduacion.Text = "";
            }
        }
        
        
    }

    protected void btnBuscar_Click(object sender, EventArgs e)
    {
        if (txtId.Text == "")
        {
            lblEstado.Text = "No ingreso Id";
            txbNombres.Text = "";
            txbApellidos.Text = "";
            txbFechaGraduacion.Text = "";

        }
        else
        {
                ClcSoldado ObjSoldado = new ClcSoldado();
        if (txtId.Text != "")
        {
            if (ObjSoldado.buscar(int.Parse(txtId.Text)))
            {
                txbNombres.Text = ObjSoldado.Nombres;
                txbApellidos.Text = ObjSoldado.Apellidos;
                txbEditarFechaGraduacion.Text = ObjSoldado.Fgraduacion;

            }
            else
            {
                lblEstado.Text = "¡Al parecer esa Id no se existe";
                txbNombres.Text = "";
                txbApellidos.Text = "";
            }
        }
        else
        {
            lblEstado.Text = "Ingrese la Id en la ultima caja de texto";
            txbNombres.Text = "";
            txbApellidos.Text = "";
        }
        }
        


    }

    protected void btnEditar_Click(object sender, EventArgs e)
    {
        if (txtId.Text == "")
        {
            lblEstado.Text = "No ingreso Id";
            txbNombres.Text = "";
            txbApellidos.Text = "";
            txbFechaGraduacion.Text = "";

        }
        else
        {
            ClcSoldado ObjSoldado = new ClcSoldado();
            ObjSoldado.Nombres = txbNombres.Text;
            ObjSoldado.Apellidos = txbApellidos.Text;
            ObjSoldado.Fgraduacion = txbEditarFechaGraduacion.Text;
            int idCompania = int.Parse(cmbCompania.SelectedValue.ToString());
            ObjSoldado.Idcompania = idCompania;
            int idCuartel = int.Parse(cmbCuartel.SelectedValue.ToString());
            ObjSoldado.IdCuartel = idCuartel;
            int idCuerpo = int.Parse(cmbCuerpo.SelectedValue.ToString());
            ObjSoldado.IdCuerpo = idCuerpo;
            
                if (ObjSoldado.Editar(int.Parse(txtId.Text)))
                {
                    lblEstado.Text = "Se ha editado Correctamente";                
                txbNombres.Text = "";
                txbApellidos.Text = "";
                txbFechaGraduacion.Text = "";
            }
                else
                {
                    lblEstado.Text = "Al parecer esa Id no se existe";
                    txbNombres.Text = "";
                    txbApellidos.Text = "";
                    txbFechaGraduacion.Text = "";
            }
            
                

        }
         
        
    }

    protected void btnEliminar_Click(object sender, EventArgs e)
    {
        if (txtId.Text == "")
        {
            lblEstado.Text = "No ingreso Id";
            txbNombres.Text = "";
            txbApellidos.Text = "";
            txbFechaGraduacion.Text = "";

        }
        else
        {
            ClcSoldado ObjSoldado = new ClcSoldado();
            if (txtId.Text != "")
            {
                if (ObjSoldado.eliminar(int.Parse(txtId.Text)))
                {
                    lblEstado.Text = "Se ha Eliminado Correctamente";
                }
                else
                {
                    lblEstado.Text = "Al parecer esa Id no se existe";
                    txbNombres.Text = "";
                    txbApellidos.Text = "";
                    txbFechaGraduacion.Text = "";
                }
            }
            else
            {
                lblEstado.Text = "Ingrese la Id en la ultima caja de texto";
                txbNombres.Text = "";
                txbApellidos.Text = "";
                txbFechaGraduacion.Text = "";
            }
        }
        
    }

    protected void btnListar_Click(object sender, EventArgs e)
    {
        Response.Redirect("FrmListarSoldados.aspx");
    }
}