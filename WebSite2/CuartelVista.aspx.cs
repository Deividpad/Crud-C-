using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class CuartelVista : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {


    }

    protected void btnAgregar_Click(object sender, EventArgs e)
    {
        CuartelModelo ocuartel = new CuartelModelo(0,"","");
        ocuartel.Id = int.Parse(txbCodigo.Text);
        ocuartel.Nombre = txbNombre.Text;
        ocuartel.Nombre = txbUbicacion.Text;
        ocuartel.agregar();
    }



    protected void btnAgregar_Click1(object sender, EventArgs e)
    {

        if(txbNombre.Text == "" || txbUbicacion.Text == "")
        {
            LbEstado.Text = "Campos incompletos";
        }
        else
        {
            try
            {
                CuartelModelo ocuartel = new CuartelModelo(0, "", "");                
                ocuartel.Nombre = txbNombre.Text;
                ocuartel.Ubicacion = txbUbicacion.Text;
                ocuartel.agregar();
                
                LbEstado.Text = "Registrado con Exito";
                txbCodigo.Text = "";
                txbNombre.Text = "";
                txbUbicacion.Text = "";
            }
            catch (Exception)
            {

                LbEstado.Text = "No fue posible realizar el registro";
                txbCodigo.Text = "";
                txbNombre.Text = "";
                txbUbicacion.Text = "";
            }
        }

        GridView1.DataBind();
    }

    protected void txbNombre_TextChanged(object sender, EventArgs e)
    {

    }

    protected void Eliminar_Click(object sender, EventArgs e)
    {
       
        if(txbCodigo.Text == "")
        {
            LbEstado.Text = "No ingreso Id";
            txbCodigo.Text = "";
            txbNombre.Text = "";
            txbUbicacion.Text = "";
        }
        else
        {
            
                CuartelModelo ocuartel = new CuartelModelo(0, "", "");
                if(ocuartel.eliminar(int.Parse(txbCodigo.Text)))
            { 
                LbEstado.Text = "Registro eliminado con exito";
                txbCodigo.Text = "";
                txbNombre.Text = "";
                txbUbicacion.Text = "";
            }
            else
            {

                LbEstado.Text = "No fue posible eliminar el registro";
                txbCodigo.Text = "";
                txbNombre.Text = "";
                txbUbicacion.Text = "";
            }
        }
        GridView1.DataBind();
    }

    protected void Editar_Click(object sender, EventArgs e)
    {        
        if (txbCodigo.Text == "")
        {
            LbEstado.Text = "No ingreso Id";
        }
        else
        {
            CuartelModelo c = new CuartelModelo(0, "", "");
            c.Id = int.Parse(txbCodigo.Text);
            c.Nombre = txbNombre.Text;
            c.Ubicacion = txbUbicacion.Text;
            if (c.Editar(int.Parse(txbCodigo.Text)))
            {
                LbEstado.Text = " Editada";
                txbCodigo.Text = "";
                txbNombre.Text = "";
                txbUbicacion.Text = "";
            }
            else
            {
                LbEstado.Text = "No Se Pudo editar ";
                txbCodigo.Text = "";
                txbNombre.Text = "";
                txbUbicacion.Text = "";
            }
        }
        GridView1.DataBind();
    }

    protected void Buscar_Click(object sender, EventArgs e)
    {
        if (txbCodigo.Text == "")
        {
            LbEstado.Text = "No ingreso Id";
        }
        else
        {
            CuartelModelo c = new CuartelModelo(0, "", "");
            if (c.buscar(int.Parse(txbCodigo.Text)))
            {
                
                txbNombre.Text = c.Nombre;
                txbUbicacion.Text = c.Ubicacion;

            }
            else
            {
                LbEstado.Text = "No Se Puede Buscar";
                txbCodigo.Text = "";
                txbNombre.Text = "";
                txbUbicacion.Text = "";
            }            
        }     
    }

    protected void btnListar_Click(object sender, EventArgs e)
    {
        Response.Redirect("FrmListarCuartel.aspx");
    }
}

