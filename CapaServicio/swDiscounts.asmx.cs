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
    /// Descripción breve de swDiscounts
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class swDiscounts : System.Web.Services.WebService
    {

        [WebMethod(Description = "Listar Discounts")]
        public DataSet Listar()
        {
            DiscountsBL discountBL = new DiscountsBL();
            return discountBL.ListarDiscount();
        }
    }
}
