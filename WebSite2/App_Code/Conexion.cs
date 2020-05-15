using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;


/// <summary>
/// Descripción breve de Conexion
/// </summary>
public class Conexion
{
    protected SqlDataReader reader;//Datos a consulatar
    protected SqlDataAdapter adaptadorDatos, adaptadorDatos2;//adaptador
    protected DataSet data; //datos
    protected SqlConnection oconexion = new SqlConnection();

    protected SqlDataReader Reader
    {
        get
        {
            return reader;
        }

        set
        {
            reader = value;
        }
    }

    protected DataSet Data
    {
        get
        {
            return data;
        }

        set
        {
            data = value;
        }
    }

    public Conexion()
    {

    }
    public void conectar(string tabla)
    {
        string strConexion = ConfigurationManager.ConnectionStrings["BD_MilitarConnectionString1"].ConnectionString;
        oconexion.ConnectionString = strConexion;
        oconexion.Open();
        adaptadorDatos = new SqlDataAdapter("Select * from " + tabla, oconexion);
        SqlCommandBuilder ejecutaComandos = new SqlCommandBuilder(adaptadorDatos);
        Data = new DataSet();
        adaptadorDatos.Fill(Data, tabla);
        oconexion.Close();
    }

}