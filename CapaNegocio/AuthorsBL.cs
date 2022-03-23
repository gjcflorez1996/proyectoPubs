using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using System.Data;
using CapaDato;

namespace CapaNegocio
{
    public class AuthorsBL : Interface.IAuthors
    {

        //utilizar los archivos cs de la capa de datos
        Datos datos = new DatosSQL();

        //Propiedad de lectura para mostrar el mensaje 
        private string mensaje;
        public string Mensaje
        {
            get { return mensaje; }

        }
        public bool ActualizarAuthors(Authors authors)
        {
            DataRow fila = datos.TraerDataRow("spAgregarAuthors", authors.Au_id, authors.Au_Iname, authors.Au_fname, authors.Phone, authors.Address, authors.City, authors.State, authors.Zip, authors.Contract);
            mensaje = fila["Mensaje"].ToString();
            byte codError = Convert.ToByte(fila["CodError"]);
            if (codError == 0) return false;
            else return true; ;
        }

        public bool AgregarAuthors(Authors authors)
        {
            DataRow fila = datos.TraerDataRow("spAgregarAuthors", authors.Au_id, authors.Au_Iname, authors.Au_fname, authors.Phone, authors.Address, authors.City, authors.State, authors.Zip, authors.Contract);
            mensaje = fila["Mensaje"].ToString();
            byte codError = Convert.ToByte(fila["CodError"]);
            if (codError == 0) return false;
            else return true;
        }

        public DataSet BuscarAuthors(string texto, string criterio)
        {
            return datos.TraerDataSet("spBuscarAuthors", texto, criterio);
        }

        public bool EliminarAuthors(string codigo)
        {
            DataRow fila = datos.TraerDataRow("spEliminarAuthors", codigo);
            byte codError = Convert.ToByte(fila["CodError"]);
            mensaje = fila["Mensaje"].ToString();
            if (codError == 0) return false;
            else return true;
        }

        public DataSet ListarAuthors()
        {
            return datos.TraerDataSet("spListarAuthors");
        }
    }
}
