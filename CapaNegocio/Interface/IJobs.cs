using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaEntidad;
using System.Data;

namespace CapaNegocio.Interface
{
    interface IJobs
    {
        //Declarar metodos comunes
        DataSet ListarJobs();

        bool AgregarJobs(Jobs job);

        bool EliminarJobs(int codigo);

        bool ActualizarJobs(Jobs job);

        DataSet BuscarJobs(string texto, string criterio);

    }
}
