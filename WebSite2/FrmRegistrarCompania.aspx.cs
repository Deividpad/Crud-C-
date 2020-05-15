using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class FrmRegistrarCompania : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    protected void btnRegistrar_Click(object sender, EventArgs e)
    {
        if(txbActividad.Text == "")
        {
            lblmensaje.Text = "Campos incompletos";
        }
        else
        {
            try
            {
                ClcCompania Objcompania = new ClcCompania();
                Objcompania.Actividad = txbActividad.Text;
                Objcompania.agregar();
                //Response.Redirect("FrmRegistrarCuerpo.aspx");
                lblmensaje.Text = "Registrado con Exito";
                txbActividad.Text = "";
                txbid.Text = "";
            }
            catch (Exception)
            {
                lblmensaje.Text = "No se puedo registrar";
                txbActividad.Text = "";
                txbid.Text = "";
            }
        }
        GridView1.DataBind();
    }


    protected void btnBuscar_Click(object sender, EventArgs e)
    {
        if (txbid.Text == "")
        {
            lblmensaje.Text = "No ingreso Id";
            txbActividad.Text = "";
            txbid.Text = "";
        }
        else
        {
            ClcCompania Objcompania = new ClcCompania();
            if (Objcompania.buscar(int.Parse(txbid.Text)))
            {
                //txbCodigo.Text = c.Id.ToString();
                txbActividad.Text = Objcompania.Actividad;

            }
            else
            {
                lblmensaje.Text = "No Se encontro registro";
                txbActividad.Text = "";
                txbid.Text = "";
            }
        }
       
    }



    protected void btnEditar_Click(object sender, EventArgs e)
    {

        if (txbid.Text == "")
        {
            lblmensaje.Text = "No ingreso Id";
            txbActividad.Text = "";
            txbid.Text = "";
        }
        else
        {
            ClcCompania Objcompania = new ClcCompania();
            Objcompania.Actividad = txbActividad.Text;


            if (Objcompania.Editar(int.Parse(txbid.Text)))
            {
                lblmensaje.Text = " Editada";
                txbActividad.Text = "";
                txbid.Text = "";
            }
            else
            {
                lblmensaje.Text = "No Se Puede Editado ";
                txbActividad.Text = "";
                txbid.Text = "";
            }
        }
        GridView1.DataBind();
    }

    protected void btnEliminar_Click(object sender, EventArgs e)
    {
        if (txbid.Text == "")
        {
            lblmensaje.Text = "No ingreso Id";
            txbActividad.Text = "";
            txbid.Text = "";
        }
        else
        {
            try
            {
                ClcCompania Objcompania = new ClcCompania();
                Objcompania.eliminar(int.Parse(txbid.Text));

                lblmensaje.Text = "Registro eliminado con exito";
            }
            catch
            {

                lblmensaje.Text = "No fue posible eliminar el registro";
            }
        }
        GridView1.DataBind();
    }

    protected void btnListar_Click(object sender, EventArgs e)
    {
        Response.Redirect("FrmListarCompania.aspx");
    }
}