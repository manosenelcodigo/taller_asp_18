using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;

public class Clientes : Conexion
{
    private SqlDataReader registro;
    private SqlConnection con;
    public Clientes()
    {
        this.con = getConexion();
    }
    public void Jquery()
    {
        ScriptManager.ScriptResourceMapping.AddDefinition
            (
                "jquery", new ScriptResourceDefinition
                {
                    Path = "~/public/js/jquery.js",
                    DebugPath = "~/public/js/jquery.js",
                    CdnSupportsSecureConnection = true,
                    LoadSuccessExpression = "window.jQuery"
                }
            );
    }
    public SqlDataReader getClientes()
    {
        conectar();
        String sql = "select id,nombre,foto from clientes order by id desc;";

        SqlCommand comando = new SqlCommand(sql, this.con);
        this.registro = comando.ExecuteReader();
        return this.registro;
    }
    public int Insertar(String nombre, String foto)
    {
        conectar();
        String sql = "insert into clientes OUTPUT INSERTED.Id " +
                        "values " +
                        "('" + nombre + "','" + foto + "')";
        SqlCommand comando = new SqlCommand(sql, this.con);
        var id = (int)comando.ExecuteScalar();
        cerrar();
        return id;

    }
    public void Editar(String foto, int id)
    {
        conectar();
        String sql = "update clientes set foto='" + foto + "' where id='" + id + "'";
        SqlCommand comando = new SqlCommand(sql, this.con);
        comando.ExecuteNonQuery();
        cerrar();
    }

}