using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPT
{
    public class JokenPo
    {
        public static string[] Pedra { get; } = { "PEDRA", "PAPEL" };
        public static string[] Papel { get; } = { "PAPEL", "TESOURA" };
        public static string[] Tesoura { get; } = { "TESOURA", "PEDRA" };
    }
}
