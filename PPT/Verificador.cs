using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPT
{
    public class Verificador
    {
        public string ChecarResultado(string[] jg1, string[] jg2)
        {
            if (jg1[0] == jg2[0])
            {
                return "Empate -> USER [" + jg2[0] + "]" + " | CPU [" + jg2[0] + "]";
            }

            if (jg1[0] == jg2[1])
            {
                return "Vencedor -> USER [ " + jg1[0] + " ]";
            }

            return "Vencedor -> CPU [ " + jg2[0] + " ]";
        }
    }
}
