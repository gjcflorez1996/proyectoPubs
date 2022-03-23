using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDato;


namespace CapaNegocio
{
    public class EscuelaBL : Interface.IEscuela
    {
        //utilizar los archivos cs de la capa de datos
        Datos datos = new DatosSQL();

        //Propiedad de lectura para mostrar el mensaje 
        private string mensaje;
        public string Mensaje
        {
            get { return mensaje; }

        }

        public bool Actualizar(Escuela escuela)
        {
            DataRow fila = datos.TraerDataRow("spActualizarEscuela", escuela.Codigo, escuela.Nombre);
            mensaje = fila["Mensaje"].ToString();
            byte codError = Convert.ToByte(fila["CodError"]);
            if (codError == 0) return false;
            else return true;
        }

        public bool Agregar(Escuela escuela)
        {
            DataRow fila = datos.TraerDataRow("spAgregarEscuela", escuela.Codigo, escuela.Nombre);
            mensaje = fila["Mensaje"].ToString();
            byte codError = Convert.ToByte(fila["CodError"]);
            if (codError == 0) return false;
            else return true;

        }

        public DataSet Buscar(string texto, string criterio)
        {
            return datos.TraerDataSet("spBuscarEscuela", texto, criterio);
        }

        public bool Eliminar(string codigo)
        {
            DataRow fila = datos.TraerDataRow("spEliminarEscuela", codigo);
            byte codError = Convert.ToByte(fila["CodError"]);
            mensaje = fila["Mensaje"].ToString();
            if (codError == 0) return false;
            else return true;
        }

        public DataSet Listar()
        {
            return datos.TraerDataSet("spListarEscuela");
        }
    }
}
