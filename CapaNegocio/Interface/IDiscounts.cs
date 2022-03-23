using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaEntidad;
using System.Data;

namespace CapaNegocio.Interface
{
    interface IDiscounts
    {
        //Declarar metodos comunes
        DataSet ListarDiscount();

        bool AgregarDiscount(Discounts discounts);

        bool EliminarDiscount(string codigo);

        bool ActualizarDiscount(Discounts discounts);

        DataSet BuscarDiscount(string texto, string criterio);
    }
}
