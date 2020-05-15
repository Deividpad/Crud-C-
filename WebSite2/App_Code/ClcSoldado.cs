using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Descripción breve de ClcSoldado
/// </summary>
public class ClcSoldado:Conexion
{

    string tabla = "Soldado";
    protected int id;
    protected string nombres;
    protected string apellidos;
    protected string fgraduacion;
    protected int idcompania;
    protected int idCuartel;
    protected int idCuerpo;

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

    public string Nombres
    {
        get
        {
            return nombres;
        }

        set
        {
            nombres = value;
        }
    }

    public string Apellidos
    {
        get
        {
            return apellidos;
        }

        set
        {
            apellidos = value;
        }
    }

    public int Idcompania
    {
        get
        {
            return idcompania;
        }

        set
        {
            idcompania = value;
        }
    }

    public int IdCuartel
    {
        get
        {
            return idCuartel;
        }

        set
        {
            idCuartel = value;
        }
    }

    public int IdCuerpo
    {
        get
        {
            return idCuerpo;
        }

        set
        {
            idCuerpo = value;
        }
    }

    public string Fgraduacion
    {
        get
        {
            return fgraduacion;
        }

        set
        {
            fgraduacion = value;
        }
    }

    public ClcSoldado()
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
        fila["Nombres"] = nombres;
        fila["Apellidos"] = apellidos;
        fila["F_graduacion"] = Fgraduacion;
        fila["Id_Compania"] = idcompania;
        fila["Id_Cuartel"] = idCuartel;
        fila["Id_Cuerpo"] = IdCuerpo;

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
            if (int.Parse(fila["Id_Soldado"].ToString()) == a)
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

            if (int.Parse(fila["Id_Soldado"].ToString()) == id)
            {
                Id = int.Parse(fila["Id_Soldado"].ToString());
                nombres = fila["Nombres"].ToString();
                apellidos = fila["Apellidos"].ToString();
                Fgraduacion = fila["F_graduacion"].ToString();
                idcompania = int.Parse(fila["Id_Compania"].ToString());
                idCuartel = int.Parse(fila["Id_Cuartel"].ToString());
                IdCuerpo = int.Parse(fila["Id_Cuerpo"].ToString());

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

            if (int.Parse(fila["Id_Soldado"].ToString()) == id)
            {
                fila["Nombres"] = Nombres;
                fila["Apellidos"] = apellidos;
                fila["F_graduacion"] = Fgraduacion;
                fila["Id_Compania"] = Idcompania;
                fila["Id_Cuartel"] = idCuartel;
                fila["Id_Cuerpo"] = idCuerpo;

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