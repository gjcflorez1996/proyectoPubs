using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Escuela
    {
        //Declara un objto q acceda a la Capa Datos
        // Datos datos = new DatosSQL();
        //Declarar atributos de la clase
        private string codigo;
        private string nombre;
        
        // Propiedad para Mensaje (De Lectura)
        private string mensaje;

        //Declarar propiedades de la clase
        public string Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
    }
}
