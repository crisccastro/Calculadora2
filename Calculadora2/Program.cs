using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora2
{
    class Program
    {
        static decimal valor1 = 0;
        static decimal valor2 = 0;
        static Operador operador;

        static void Main(string[] args)
        {
            int menu = 0;
            while (menu == 0)
            {
                try
                {
                    Menu();
                    menu = int.Parse(Console.ReadLine());
                    Console.Clear();

                    switch (menu)
                    {
                        case 1:
                        case 2:
                        case 3:
                        case 4:
                            Console.WriteLine($"{ Operacoes(menu)}");
                            break;
                        case 99:
                            Console.WriteLine("Deseja realmente sair?");
                            break;
                        default:
                            Console.WriteLine("Opção inválida!");
                            break;
                    }

                    Console.WriteLine("Pressione qualquer tecla para continuar");
                    Console.ReadKey();

                    Console.WriteLine("Pressione 0 para retornar ao menu ou qualquer tecla para sair");
                    var tecla = Console.ReadLine();

                    if (tecla == "0")
                        menu = 0;
                    else
                    {
                        Console.ReadKey();
                        menu = 99;
                    }
                }
                catch (DivideByZeroException e)
                {
                    Console.WriteLine($"Erro {e.Message}");
                    menu = 0;
                    Console.ReadKey();
                }
                catch(FormatException e)
                {
                    Console.WriteLine($"Erro {e.Message}");
                    menu = 0;
                    Console.ReadKey();
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Erro {e.Message}");
                    menu = 0;
                    Console.ReadKey();
                }
                finally
                {
                    Console.Clear();
                }
            }
        }
        static public void Menu()
        {
            Console.WriteLine("------------CALCULADORA------------");
            Console.WriteLine(" 1 - SOMA");
            Console.WriteLine(" 2 - SUBTRAÇÃO");
            Console.WriteLine(" 3 - MULTIPLICAÇÃO");
            Console.WriteLine(" 4 - DIVISÃO");
            Console.WriteLine("99 - SAIR");
            Console.WriteLine("-----------------------------------");
        }

        static void LerValores()
        {
            Console.WriteLine("Informe o Valor 1");
            valor1 = decimal.Parse(Console.ReadLine());
            Console.WriteLine($"Valor1 informado {valor1}");
            Console.WriteLine("Informe o Valor 2");
            valor2 = decimal.Parse(Console.ReadLine());
            Console.WriteLine($"Valor2 informado {valor2}");

        }

        private static string Operacoes(int menu)
        {
            switch (menu)
            {
                case 1:
                    Console.WriteLine("Selecionado - SOMA");
                    LerValores();
                    operador = new Soma(valor1, valor2);
                    break;
                case 2:
                    Console.WriteLine("Selecionado - SUBTRAÇÃO");
                    LerValores();
                    operador = new Subtrair(valor1, valor2);
                    break;
                case 3:
                    Console.WriteLine("Selecionado - MULTIPLICAÇÃO");
                    LerValores();
                    operador = new Multiplica(valor1, valor2);
                    break;
                case 4:
                    Console.WriteLine("Selecionado - DIVISÃO");
                    LerValores();
                    operador = new Divide(valor1, valor2);
                    break;
                default:
                    break;

            }

            return operador.ToString();

        }
    }
}
