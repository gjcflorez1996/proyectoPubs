using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Jobs
    {
        //Declara un objto q acceda a la Capa Datos
        // Datos datos = new DatosSQL();
        //Declarar atributos de la clase
        private int job_id;
        private string job_desc;
        private int min_lvl;
        private int max_lvl;

        // Propiedad para Mensaje (De Lectura)
        private string mensaje;

        public int Job_id { get => job_id; set => job_id = value; }
        public string Job_desc { get => job_desc; set => job_desc = value; }
        public int Min_lvl { get => min_lvl; set => min_lvl = value; }
        public int Max_lvl { get => max_lvl; set => max_lvl = value; }

        //Declarar propiedades de la clase

    }
}
