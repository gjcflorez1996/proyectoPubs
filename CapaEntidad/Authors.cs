using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Authors
    {
        private string au_id;
        private string au_Iname;
        private string au_fname;
        private string phone;
        private string address;
        private string city;
        private string state;
        private string zip;
        private int contract;

        public string Au_id { get => au_id; set => au_id = value; }
        public string Au_Iname { get => au_Iname; set => au_Iname = value; }
        public string Au_fname { get => au_fname; set => au_fname = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Address { get => address; set => address = value; }
        public string City { get => city; set => city = value; }
        public string State { get => state; set => state = value; }
        public string Zip { get => zip; set => zip = value; }
        public int Contract { get => contract; set => contract = value; }
    }

}
