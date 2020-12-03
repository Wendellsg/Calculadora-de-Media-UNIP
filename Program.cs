using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixEDH_94
{
    class Program
    {
        public static int calcularMedia(int nota1, int nota2, int nota3)
        {

            int _media = 0;

            _media = (nota1 + nota2 + nota3) / 3;

            return _media;
        }

        public static bool verificarAprovacao(int _media)
        {

            if (_media >= 7)
            {

                return true;
            }
            else { return false; }

        }

        static void Main(string[] args)
        {
            int[] prova1 = new int[7];
            int[] prova2 = new int[7];
            int[] seminario = new int[7];

            int[] mediaGeral = new int[7];
            int mediaTotal = 0;
            int soma = 0;

            //Tela 1(Entrada de dados)


            Console.WriteLine("\tSeja bem vindos à Calculadora de médias\n");
            Console.WriteLine("________________________________________________________\n");
            Console.WriteLine("Digita a seguir as notas dos alunos:\n\n");

            for (int i = 0; i < mediaGeral.Length; i++) {

                Console.WriteLine("Notas do Aluno {0}\n\n", i + 1);
                Console.WriteLine("Digite a nota da Prova 1\n");
                prova1[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite a nota da Prova 2\n");
                prova2[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite a nota do Seminário\n");
                seminario[i] = int.Parse(Console.ReadLine());
                Console.Clear();
            }

            Console.WriteLine("Tudo pronto, para ver as notas e média de cada aluno tecle (espaço)\n\n");

            Console.Clear();
            //Tela 2 (Dados completos)

            Console.Clear();
            for (int i = 0; i < mediaGeral.Length; i++)
            {

                mediaGeral[i] = calcularMedia(prova1[i], prova2[i], seminario[i]);

            }
            Console.WriteLine("\t\t\t\tLista de médias gerais dos alunos\n");
            Console.WriteLine("_______________________________________________________________________________________\n");
            Console.WriteLine("Nome\t\tProva 1\t\tProva 2\t\tSeminário\t\tMédia Geral\n");

            for (int i = 0; i < mediaGeral.Length; i++)
            {

                Console.WriteLine("Aluno {0}:\t\t{1}\t\t{2}\t\t{3}\t\t\t{4}\n", i + 1, prova1[i], prova2[i], seminario[i], mediaGeral[i]);
            }

            for (int i = 0; i < mediaGeral.Length; i++)
            {

                soma = soma + mediaGeral[i];
            }

            mediaTotal = soma / mediaGeral.Length;

            Console.WriteLine("_______________________________________________________________________________________\n");
            Console.WriteLine("Para ver a lista de aprovados, reprovados e média total da turma tecle (espaço):\n");
            Console.ReadKey();
            Console.Clear();

            //Tela 3(Listas Separadas)


            Console.WriteLine("Lista dos alunos aprovados\n");
            Console.WriteLine("Nome\t\tMédia Geral\n");


            for (int i = 0; i < mediaGeral.Length; i++)
            {

                if (verificarAprovacao(mediaGeral[i]))
                {

                    Console.WriteLine("Aluno {0}:\t\t{1}\n", i + 1, mediaGeral[i]);

                }

            }

            Console.WriteLine("_________________________________\n");
            Console.WriteLine("Lista dos alunos Reprovados\n");
            Console.WriteLine("Nome\t\tMédia Geral\n");


            for (int i = 0; i < mediaGeral.Length; i++)
            {

                if (!verificarAprovacao(mediaGeral[i]))
                {

                    Console.WriteLine("Aluno {0}:\t\t{1}\n", i + 1, mediaGeral[i]);

                }


            }

            Console.WriteLine("_________________________________\n");
            Console.WriteLine("A média de notas da Turma foi de {0} pontos. ", mediaTotal);

            Console.WriteLine("\n\nDesenvolvido por Wendell Guimarães RA:N2292A6");
            Console.ReadKey();

        }
    }
}
