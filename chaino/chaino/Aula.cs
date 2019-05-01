using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chaino
{
    public class Aula
    {
        private int _nosillas;

        private Edificio edi = new Edificio();
        private Espacio esp = new Espacio();

        public int NoSillas { get; set; }
        public Edificio Edi { get; set; }
        public Espacio Esp { get; set; }
    }
}
