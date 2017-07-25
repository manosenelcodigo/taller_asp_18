using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Add : System.Web.UI.Page
{
    private Conexion con;
    private Clientes clientes;
    protected void Page_Load(object sender, EventArgs e)
    {
        this.con = new Conexion();
        this.con.conectar();
        this.clientes = new Clientes();
        this.clientes.Jquery();
    }
    public void ProcesarFormulario(object sender, EventArgs e)
    {
        if (IsValid)
        {
            //texto.InnerHtml = "foto="+foto.PostedFile.ContentType;
            //validar lo que nos envía el usuario
            if (foto.PostedFile.ContentType == "image/jpeg")
            {
                //crear el registro en la tabla clientes
                int id = this.clientes.Insertar(nombre.Text, "");
                //subir el fichero
                String ide = id.ToString();
                String imagen = "foto_" + ide + ".jpg";
                foto.SaveAs(Server.MapPath(".") + "/public/uploads/clientes/" + imagen);
                //editar el registro de la tabla clientes
                this.clientes.Editar(imagen, id);
                //redireccionar al usuario
                Response.Redirect("Default.aspx");
            }
            else
            {
                texto.InnerHtml = "El archivo seleccionado no cumple el formato requerido";
            }
            

                
        }
    }
}