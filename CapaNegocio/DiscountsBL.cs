using CapaEntidad;
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
    public class DiscountsBL : Interface.IDiscounts
    {
        //utilizar los archivos cs de la capa de datos
        Datos datos = new DatosSQL();

        //Propiedad de lectura para mostrar el mensaje 
        private string mensaje;
        public string Mensaje
        {
            get { return mensaje; }

        }

        public bool ActualizarDiscount(Discounts discounts)
        {
            DataRow fila = datos.TraerDataRow("spActualizarDiscounts", discounts.Discounttype, discounts.Stor_id, discounts.Lowqty, discounts.Highqty,discounts.Discount);
            mensaje = fila["Mensaje"].ToString();
            byte codError = Convert.ToByte(fila["CodError"]);
            if (codError == 0) return false;
            else return true;
        }

        public bool AgregarDiscount(Discounts discounts)
        {
            DataRow fila = datos.TraerDataRow("spAgregarDiscounts", discounts.Discounttype, discounts.Stor_id, discounts.Lowqty, discounts.Highqty, discounts.Discount);
            mensaje = fila["Mensaje"].ToString();
            byte codError = Convert.ToByte(fila["CodError"]);
            if (codError == 0) return false;
            else return true;
        }

        public DataSet BuscarDiscount(string texto, string criterio)
        {
            return datos.TraerDataSet("spBuscarDiscounts", texto, criterio);
        }

        public bool EliminarDiscount(string codigo)
        {
            DataRow fila = datos.TraerDataRow("spEliminarDiscounts", codigo);
            byte codError = Convert.ToByte(fila["CodError"]);
            mensaje = fila["Mensaje"].ToString();
            if (codError == 0) return false;
            else return true;
        }

        public DataSet ListarDiscount()
        {
            return datos.TraerDataSet("spListarDiscounts");
        }
    }
}
