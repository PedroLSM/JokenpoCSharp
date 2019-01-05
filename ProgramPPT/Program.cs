using System;
using PPT;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramPPT
{
    class Program
    {

        public static void Main(string[] args)
        {
            do
            {
                try
                {
                    string user = JogadaDoUsuario();

                    int CPU = JogadaDaCPU();

                    string result = ComputarResultado(user, CPU);

                    Console.WriteLine();
                    Console.WriteLine(result);

                }
                catch (ArgumentException e)
                {
                    Console.WriteLine();
                    Console.WriteLine(e.Message);
                }

                Console.WriteLine();

                Console.WriteLine("Pressione <Esc> para sair ...");

            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }

        private static string ComputarResultado(string user, int CPU)
        {
            string[] jogadaUser = AdicionarJogadasUser(user);
            string[,] jogadas = AdicionarJogadasCPU();
            string[] jogadaCPU = { jogadas[0, CPU], jogadas[1, CPU] };

            Verificador juiz = new Verificador();
            string result = juiz.ChecarResultado(jogadaUser, jogadaCPU);

            return result;
        }

        private static int JogadaDaCPU()
        {
            Random ppt = new Random();
            int CPU = ppt.Next(0, 3);
            return CPU;
        }

        private static string JogadaDoUsuario()
        {
            Console.WriteLine();

            Console.WriteLine("[   1   ] [   2   ] [    3    ]");
            Console.WriteLine("[ PEDRA ] [ PAPEL ] [ TESOURA ]");

            Console.WriteLine();

            string user = Console.ReadLine();

            return user;
        }

        private static string[] AdicionarJogadasUser(string user)
        {
            switch (user.ToUpper())
            {
                case "PEDRA":
                case "1":
                    return JokenPo.Pedra;
                case "PAPEL":
                case "2":
                    return JokenPo.Papel;
                case "TESOURA":
                case "3":
                    return JokenPo.Tesoura;
                default:
                    throw new ArgumentException("Jogada Inválida");
            }
        }

        private static string[,] AdicionarJogadasCPU()
        {
            string[,] matriz = new string[2, 3];

            string[] pedra = JokenPo.Pedra;
            matriz[0, 0] = pedra[0];
            matriz[1, 0] = pedra[1];

            string[] papel = JokenPo.Papel;
            matriz[0, 1] = papel[0];
            matriz[1, 1] = papel[1];

            string[] tesoura = JokenPo.Tesoura;
            matriz[0, 2] = tesoura[0];
            matriz[1, 2] = tesoura[1];

            return matriz;
        }
    }
}
