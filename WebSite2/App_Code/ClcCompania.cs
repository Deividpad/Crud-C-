using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Descripción breve de ClcCompania
/// </summary>
public class ClcCompania:Conexion
{

    string tabla = "Compania";
    protected int id;
    protected string actividad;

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

    public string Actividad
    {
        get
        {
            return actividad;
        }

        set
        {
            actividad = value;
        }
    }

    public ClcCompania()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }


    public void agregar()
    {
        conectar(tabla);

        DataRow fila;
        fila = Data.Tables[tabla].NewRow();
        fila["Actividad"] = actividad;

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
            if (int.Parse(fila["Id_Compania"].ToString()) == a)
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

            if (int.Parse(fila["Id_Compania"].ToString()) == id)
            {
                Id = int.Parse(fila["Id_Compania"].ToString());
                actividad = fila["Actividad"].ToString();

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

            if (int.Parse(fila["Id_Compania"].ToString()) == id)
            {

                //fila["Id_Cuerpo"] = Id;
                fila["Actividad"] = actividad;

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