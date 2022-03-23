using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaEntidad;
using System.Data;


namespace CapaNegocio.Interface
{
    interface IEscuela
    {
        //Declara metodos comunes
        DataSet Listar();
        bool Agregar(Escuela escuela);

        bool Eliminar(string codigo);

        bool Actualizar(Escuela escuela);

        DataSet Buscar(string texto, string criterio);

    }
}
