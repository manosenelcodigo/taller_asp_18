﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

public class Conexion
{
    private SqlConnection conexion;
    public Conexion()
    {
        string s = System.Configuration.ConfigurationManager.ConnectionStrings["manosenelcodigo"].ConnectionString;
        this.conexion = new SqlConnection(s);
    }
    public void conectar()
    {
        this.conexion.Open();
    }
    public void cerrar()
    {
        this.conexion.Close();
    }
    public SqlConnection getConexion()
    {
        return this.conexion;
    }
}