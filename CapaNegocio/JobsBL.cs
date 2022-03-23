using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDato;
using CapaEntidad;

namespace CapaNegocio
{
    public class JobsBL : Interface.IJobs
    {
        //utilizar los archivos cs de la capa de datos
        Datos datos = new DatosSQL();

        //Propiedad de lectura para mostrar el mensaje 
        private string mensaje;
        public string Mensaje
        {
            get { return mensaje; }

        }

        public bool ActualizarJobs(Jobs job)
        {
            DataRow fila = datos.TraerDataRow("spActualizarJobs", job.Job_id, job.Job_desc, job.Min_lvl, job.Max_lvl);
            mensaje = fila["Mensaje"].ToString();
            byte codError = Convert.ToByte(fila["CodError"]);
            if (codError == 0) return false;
            else return true;
        }

        public bool AgregarJobs(Jobs job)
        {
            DataRow fila = datos.TraerDataRow("spAgregarJobs", job.Job_desc, job.Min_lvl, job.Max_lvl);
            mensaje = fila["Mensaje"].ToString();
            byte codError = Convert.ToByte(fila["CodError"]);
            if (codError == 0) return false;
            else return true;
        }

        public DataSet BuscarJobs(string texto, string criterio)
        {
            return datos.TraerDataSet("spBuscarJobs", texto, criterio);
        }

        public bool EliminarJobs(int codigo)
        {
            DataRow fila = datos.TraerDataRow("spEliminarJobs", codigo);
            byte codError = Convert.ToByte(fila["CodError"]);
            mensaje = fila["Mensaje"].ToString();
            if (codError == 0) return false;
            else return true;
        }

 

        public DataSet ListarJobs()
        {
            return datos.TraerDataSet("spListarJobs");
        }
    }
}
