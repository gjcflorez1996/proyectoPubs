using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using CapaNegocio;
using System.Data;
using CapaEntidad;

namespace CapaServicio
{
    /// <summary>
    /// Descripción breve de wsAuthors
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class wsAuthors : System.Web.Services.WebService
    {

        [WebMethod(Description = "Listar Authors")]
        public DataSet Listar()
        {
            AuthorsBL authorsBL = new AuthorsBL();
            return authorsBL.ListarAuthors();
        }
        [WebMethod(Description = "Agregar Authors")]

        public string[] Agregar(string Codigo, string Nombre, string Apellidos, string Telefono, string Direccion, string Ciudad, string Estado, string Zip, int Contrato)
        {
            AuthorsBL autorBL = new AuthorsBL();
            Authors autor = new Authors();
            autor.Au_id = Codigo;
            autor.Au_Iname = Nombre;
            autor.Au_fname = Apellidos;
            autor.Phone = Telefono;
            autor.Address = Direccion;
            autor.City = Ciudad;
            autor.State = Estado;
            autor.Zip = Zip;
            autor.Contract = Contrato;
            string[] valores = new string[2];
            valores[0] = autorBL.AgregarAuthors(autor).ToString();
            valores[1] = autorBL.Mensaje;
            return valores;
        }

        [WebMethod(Description = "Actualizar Authors")]

        public string[] Actualizar(string Codigo, string Nombre, string Apellidos, string Telefono, string Direccion, string Ciudad, string Estado, string Zip, int Contrato)
        {
            AuthorsBL autorBL = new AuthorsBL();
            Authors autor = new Authors();
            autor.Au_id = Codigo;
            autor.Au_Iname = Nombre;
            autor.Au_fname = Apellidos;
            autor.Phone = Telefono;
            autor.Address = Direccion;
            autor.City = Ciudad;
            autor.State = Estado;
            autor.Zip = Zip;
            autor.Contract = Contrato;
            string[] valores = new string[2];
            valores[0] = autorBL.ActualizarAuthors(autor).ToString();
            valores[1] = autorBL.Mensaje;
            return valores;
        }

        [WebMethod(Description = "Buscar Authors")]

        public DataSet Buscar(string texto, string criterio)
        {
            AuthorsBL autor = new AuthorsBL();
            return autor.BuscarAuthors(texto, criterio);
        }

    }
}
