using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace ClienteWeb
{
    public partial class Autores : System.Web.UI.Page
    {
        // srAutor.wsAutorSoapClient servicio = new srAutor.wsAutorSoapClient();

        srAuthors.wsAuthorsSoapClient servicio = new srAuthors.wsAuthorsSoapClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            gvTabla.DataSource = servicio.Listar().Tables[0];
            gvTabla.DataBind();
        }

        private void Listar()
        {
            gvTabla.DataSource = servicio.Listar().Tables[0];
            gvTabla.DataBind();
        }



        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            string[] msj = servicio.Agregar(txtCodigo.Text, txtNombre.Text, txtApellido.Text, txtTelefono.Text, txtDireccion.Text, txtCiudad.Text, txtEstado.Text, txtZip.Text, txtContrato.MaxLength);
            Response.Write("<scrip>alert('" + msj[0] + " : " + msj[1] + "');</script>");
            Listar();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            string[] msj = servicio.Actualizar(txtCodigo.Text, txtNombre.Text, txtApellido.Text, txtTelefono.Text, txtDireccion.Text, txtCiudad.Text, txtEstado.Text, txtZip.Text, txtContrato.MaxLength);
            Response.Write("<scrip>alert('" + msj[0] + " : " + msj[1] + "');</script>");
            Listar();
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            gvTabla.DataSource = servicio.Buscar(txtCritoerio.Text, txtCampo.Text).Tables[0];
            gvTabla.DataBind();
        }
    }
}