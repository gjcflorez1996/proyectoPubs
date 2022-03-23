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
    /// Descripción breve de wsJobs
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class wsJobs : System.Web.Services.WebService
    {

        [WebMethod(Description = "ListarJobs")]
        public DataSet Listar()
        {
            JobsBL jobs = new JobsBL();
            return jobs.ListarJobs();
        }

        [WebMethod(Description = "Agregar jobs")]
        public string[] Agregar(string JobDesc, int MinLvl, int MaxLvl)
        {
            JobsBL jobsBL = new JobsBL();
            Jobs jobs = new Jobs();

            jobs.Job_desc = JobDesc;
            jobs.Min_lvl = MinLvl;
            jobs.Max_lvl = MaxLvl;

            string[] valores = new string[2];
            valores[0] = jobsBL.AgregarJobs(jobs).ToString();
            valores[1] = jobsBL.Mensaje;

            return valores;
        }

        [WebMethod(Description = "Actualizar jobs")]
        public string[] Actualizar(int JobId, string JobDesc, int MinLvl, int MaxLvl)
        {
            JobsBL jobsBL = new JobsBL();
            Jobs jobs = new Jobs();

            jobs.Job_id = JobId;
            jobs.Job_desc = JobDesc;
            jobs.Min_lvl = MinLvl;
            jobs.Max_lvl = MaxLvl;

            string[] valores = new string[2];
            valores[0] = jobsBL.ActualizarJobs(jobs).ToString();
            valores[1] = jobsBL.Mensaje;

            return valores;
        }



        /*[WebMethod(Description = "Eliminar Jobs ")]
        public string[] Eliminar(int JobId)
         {
           JobsBL jobsBL = new JobsBL();
           Jobs jobs = new Jobs();

           jobs.Job_id = JobId;
           string[] valores = new string[2];
           valores[0] = jobsBL.EliminarJobs(jobs).ToString();
           valores[1] = jobsBL.Mensaje;
           return valores;

       }*/


        [WebMethod(Description = "Buscar jobs")]

        public DataSet Buscar(string texto, string criterio)
        {
            JobsBL jobsBL = new JobsBL();
            return jobsBL.BuscarJobs(texto, criterio);
        }

    }

}
