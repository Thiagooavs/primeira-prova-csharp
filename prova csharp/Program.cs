using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace prova_csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string resp = "S";        
            int esc = 0;
            int ds = 0;
            int mc = 0;
            int ed = 0;
            int ad = 0;

            while (resp== "S")
            {
                string erro = "S";
                while (erro == "S")
                {                  
                  Console.WriteLine("Essolha um curso para se matricular: ");
                  Console.WriteLine("1 - Desenvolvimento de Sistemas (o melhor) ");
                  Console.WriteLine("2 - Edificação ");
                  Console.WriteLine("3 - Administração ");
                  Console.WriteLine("4 - Mecatrônica ");
                  Console.WriteLine("Escolha: ");
                  esc = int.Parse(Console.ReadLine());

                    switch (esc)
                    {
                        case 1:
                            if (ds == 5)
                            {
                                Console.WriteLine("Vagas já preenchidas");
                                Console.WriteLine("Por favor, escolha outro curso");
                                Console.ReadKey();
                            }
                            else
                            {
                                ds++;
                                erro = "N";
                            }
                            break;


                        case 2:
                            if (ed == 5)
                            {
                                Console.WriteLine("Vagas já preenchidas");
                                Console.WriteLine("Por favor, escolha outro curso");
                                Console.ReadKey();
                            }
                            else
                            {
                                ed++;
                                erro = "N";
                            }
                            break;

                        case 3:
                            if (ad == 5)
                            {
                                Console.WriteLine("Vagas já preenchidas");
                                Console.WriteLine("Por favor, escolha outro curso");
                                Console.ReadKey();
                            }
                            else
                            {
                                ad++;
                                erro = "N";
                            }
                            break;

                        case 4:
                            if (mc == 5)
                            {
                                Console.WriteLine("Vagas já preenchidas");
                                Console.WriteLine("Por favor, escolha outro curso");
                                Console.ReadKey();
                            }
                            else
                            {
                                mc++;
                                erro = "N";
                            }
                            break;

                        default:
                            Console.WriteLine("Curso inexistente, tente novamente.");
                            Console.ReadKey();
                            break;
                    }
                }

                Console.WriteLine("Cadastrar mais um aluno (s/n)?");               
                resp = Console.ReadLine().ToUpper();               
            }

            Console.WriteLine("Número de alunos matriculado ( max = 5):");
            Console.WriteLine("1 - Desenvolvimento de Sistemas: " + ds);
            Console.WriteLine("2 - Edificação " + ed);
            Console.WriteLine("3 - Administração " + ad);
            Console.WriteLine("4 - Mecatrônica " + mc);

            Console.ReadKey();
        }
    }
}
