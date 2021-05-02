using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class ParametroDB
    {
        public string nombre { get; set; }
        public dynamic valor { get; set; }
        public bool esIn { get; set; }

        public ParametroDB(string nom, dynamic para, bool soloIn = true)
        {
            nombre = nom;
            valor = para;
            esIn = soloIn;
        }
    }
}
