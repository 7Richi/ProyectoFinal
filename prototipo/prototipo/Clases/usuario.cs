using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prototipo.Clases
{
    class usuario 
    {
        private string e_mail;
        private  string contrasena;
        private Persona person = new Persona();

        public string E_mail { get; set; }
        public string Contrasena { get; set; }
        public Persona Person { get; set; }


        }
}
