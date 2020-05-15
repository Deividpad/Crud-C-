using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class FrmRegistrarCuerpo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnRegistrar_Click(object sender, EventArgs e)
    {
        if(txbdenominacion.Text == "")
        {
            lblmensaje.Text = "Campos incompletos";
            txbdenominacion.Text = "";
            txbid.Text = "";
        }
        else
        {
            try
            {
                ClcCuerpo Objcuerpo = new ClcCuerpo();
                Objcuerpo.Denominacion = txbdenominacion.Text;
                Objcuerpo.agregar();
                //Response.Redirect("FrmRegistrarCuerpo.aspx");
                lblmensaje.Text = "Registrado con Exito";
                txbdenominacion.Text = "";
                txbid.Text = "";
            }
            catch (Exception)
            {
                lblmensaje.Text = "No se puedo registrar";
                txbdenominacion.Text = "";
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
            txbdenominacion.Text = "";
            txbid.Text = "";
        }
        else
        {
            try
            {
                ClcCuerpo ObjCuerpo = new ClcCuerpo();
                ObjCuerpo.eliminar(int.Parse(txbid.Text));
                lblmensaje.Text = "Registro eliminado con exito";
                txbdenominacion.Text = "";
                txbid.Text = "";
            }
            catch
            {

                lblmensaje.Text = "No fue posible eliminar el registro";
                txbdenominacion.Text = "";
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
            txbdenominacion.Text = "";
            txbid.Text = "";
        }
        else
        {
            ClcCuerpo ObjCuerpo = new ClcCuerpo();
            if (ObjCuerpo.buscar(int.Parse(txbid.Text)))
            {
                //txbCodigo.Text = c.Id.ToString();
                txbdenominacion.Text = ObjCuerpo.Denominacion;

            }
            else
            {
                lblmensaje.Text = "No Se Puede Buscar";
                txbdenominacion.Text = "";
                txbid.Text = "";
            }
        }
        
    }

    protected void btnEditar_Click(object sender, EventArgs e)
    {
        if (txbid.Text == "")
        {
            lblmensaje.Text = "No ingreso Id";
            txbdenominacion.Text = "";
            txbid.Text = "";
        }
        else
        {
            ClcCuerpo ObjCuerpo = new ClcCuerpo();
            ObjCuerpo.Denominacion = txbdenominacion.Text;


            if (ObjCuerpo.Editar(int.Parse(txbid.Text)))
            {
                lblmensaje.Text = " Editada";
            }
            else
            {
                lblmensaje.Text = "No Se Puede Editado ";
            }
        }
        GridView1.DataBind();
    }

    protected void btnListar_Click(object sender, EventArgs e)
    {
        Response.Redirect("FrmLIstarCuerpo.aspx");
    }
}