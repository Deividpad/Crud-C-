using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Descripción breve de Cuartel
/// </summary>
public class CuartelModelo:Conexion
{
    string tabla = "Cuartel";
    protected int id;
    protected string ubicacion;
    protected string nombre;

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

    public string Nombre
    {
        get
        {
            return nombre;
        }

        set
        {
            nombre = value;
        }
    }

    public string Ubicacion
    {
        get
        {
            return ubicacion;
        }

        set
        {
            ubicacion = value;
        }
    }

    public CuartelModelo(int idC, string nombreC, string ubicacionC)
    {
        this.Id = idC;
        this.Nombre = nombreC;
        this.Ubicacion = ubicacionC;
    }

    public void agregar()
    {
        conectar(tabla);

        DataRow fila;
        fila = Data.Tables[tabla].NewRow();
        fila["Id_Cuartel"] = Id;
        fila["Nombre"] = Nombre;
        fila["Ubicacion"] = Ubicacion;

        Data.Tables[tabla].Rows.Add(fila);
        adaptadorDatos.Update(Data, tabla);

    }

    public bool eliminar(int a)
    {
        conectar(tabla);
        DataRow fila;
        int x = Data.Tables[tabla].Rows.Count - 1;
        for (int i= 0; i<=x; i++)
        {
            fila = Data.Tables[tabla].Rows[i];
            if (int.Parse(fila["Id_Cuartel"].ToString()) == a)
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

            if (int.Parse(fila["Id_Cuartel"].ToString()) == id)
            {                
                Nombre = fila["Nombre"].ToString();
                Ubicacion = fila["Ubicacion"].ToString();

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

            if (int.Parse(fila["Id_Cuartel"].ToString()) == id)
            {

                //fila["Id_Cuartel"] = Id;
                fila["Nombre"] = Nombre;
                fila["Ubicacion"] = Ubicacion;


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