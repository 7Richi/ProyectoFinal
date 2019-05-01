using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chaino
{
    public class Edificio
    {
        private string _nombre;
        private string _ubicacion;

        private List<Aula> _au = new List<Aula>();
        private List<Lab> _lab = new List<Lab>();

        public string Nombre { get; set; }
        public string Ubicacion { get; set; }

        public void addau (Aula aul)
        {
            _au.Add(aul);
        }
        public void addlab(Lab labo)
        {
            _lab.Add(labo);
        }


    }
}
