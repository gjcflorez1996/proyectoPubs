using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Discounts
    {
        //Declara un objto q acceda a la Capa Datos
      
        //Declarar atributos de la clase
        private string discounttype;
        private string stor_id;
        private int lowqty;
        private int highqty;
        private decimal discount;

        public string Discounttype { get => discounttype; set => discounttype = value; }
        public string Stor_id { get => stor_id; set => stor_id = value; }
        public int Lowqty { get => lowqty; set => lowqty = value; }
        public int Highqty { get => highqty; set => highqty = value; }
        public decimal Discount { get => discount; set => discount = value; }
    }
}
