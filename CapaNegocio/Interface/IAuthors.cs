using CapaEntidad;
using System.Data;

namespace CapaNegocio.Interface

{
    public interface IAuthors
    {
        //Declarar metodos comunes
        DataSet ListarAuthors();

        bool AgregarAuthors(Authors authors);

        bool EliminarAuthors(string codigo);

        bool ActualizarAuthors(Authors authors);

        DataSet BuscarAuthors(string texto, string criterio);
    }
}