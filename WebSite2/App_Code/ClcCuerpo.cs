using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Descripción breve de ClcCuerpo
/// </summary>
public class ClcCuerpo:Conexion
{

    string tabla = "Cuerpo";
    protected int id;
    protected string denominacion;

    public ClcCuerpo()
    {


    }

    public ClcCuerpo(string dem)
    {
        this.denominacion = dem;
    }


   

    public string Denominacion
    {
        get
        {
            return denominacion;
        }

        set
        {
            denominacion = value;
        }
    }

    public int Id
    {
        get
        {
            return id;
        }

        set
        {
            id = value;
        }
    }

    public void agregar()
    {
        conectar(tabla);

        DataRow fila;
        fila = Data.Tables[tabla].NewRow();        
        fila["Denominación"] = denominacion;        

        Data.Tables[tabla].Rows.Add(fila);
        adaptadorDatos.Update(Data, tabla);

    }


    public bool eliminar(int a)
    {
        conectar(tabla);
        DataRow fila;
        int x = Data.Tables[tabla].Rows.Count - 1;
        for (int i = 0; i <= x; i++)
        {
            fila = Data.Tables[tabla].Rows[i];
            if (int.Parse(fila["Id_Cuerpo"].ToString()) == a)
            {
                fila = Data.Tables[tabla].Rows[i];
                fila.Delete();
                DataTable tablaborrados;
                tablaborrados = Data.Tables[tabla].GetChanges(DataRowState.Deleted);
                adaptadorDatos.Update(tablaborrados);
                Data.Tables[tabla].AcceptChanges();
                return true;



            }
        }
        return false;
    }


    public bool buscar(int id)
    {
        conectar(tabla);
        DataRow fila;
        int x = Data.Tables[tabla].Rows.Count - 1;
        for (int i = 0; i <= x; i++)
        {
            fila = Data.Tables[tabla].Rows[i];

            if (int.Parse(fila["Id_Cuerpo"].ToString()) == id)
            {
                Id = int.Parse(fila["Id_Cuerpo"].ToString());
                denominacion = fila["Denominación"].ToString();             

                return true;
            }
        }
        return false;
    }


    public bool Editar(int id)
    {
        conectar(tabla);
        DataRow fila;
        int x = Data.Tables[tabla].Rows.Count - 1;

        for (int i = 0; i <= x; i++)
        {
            fila = Data.Tables[tabla].Rows[i];

            if (int.Parse(fila["Id_Cuerpo"].ToString()) == id)
            {

                //fila["Id_Cuerpo"] = Id;
                fila["Denominación"] = denominacion;                


                DataTable EditarD;
                EditarD = Data.Tables[tabla].GetChanges(DataRowState.Modified);
                adaptadorDatos.Update(Data, tabla);
                Data.Tables[tabla].AcceptChanges();
                return true;
            }

        }
        return false;
    }
}