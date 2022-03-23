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
    /// Descripción breve de wsEscuela
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class wsEscuela : System.Web.Services.WebService
    {

        [WebMethod(Description = "ListarEscuela")]
        public DataSet Listar() {
            EscuelaBL escuela = new EscuelaBL();
            return escuela.Listar();
        }

        [WebMethod(Description = "Agregar escuela")]
        public string[] Agregar(string Codigo, string Nombre) {
            
            EscuelaBL escuelaBL = new EscuelaBL();
            Escuela escuela = new Escuela();
            escuela.Codigo = Codigo;
            escuela.Nombre = Nombre;

            string[] valores = new string[2];
            valores[0] = escuelaBL.Agregar(escuela).ToString();
            valores[1] = escuelaBL.Mensaje;

            return valores;
     
        }


    }
}
