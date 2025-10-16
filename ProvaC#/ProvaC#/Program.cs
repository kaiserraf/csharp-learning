/*
 * DESENVOLVEDORES:
 * RAFAEL DE OLIVEIRA MACHADO - 2025105563
 * RAFAEL SALES - 2025105454s
 * LUCAS VINICIUS BARROS DIAS - 2025105450
 * MATHEUS SIZANOSKI FIGUEIREDO - 2025105007
 */

using System;
namespace calendario
{
    class Program
    {
        public static void Main(string[] args)
        {

            int ano = 0, mes = 0, dia = 0, i = 0;

            string[] mesesAparecer =
        {
            "Janeiro",
            "Fevereiro",
            "Março",
            "Abril",
            "Maio",
            "Junho",
            "Julho",
            "Agosto",
            "Setembro",
            "Outubro",
            "Novembro",
            "Dezembro"
        }; 

            Console.WriteLine("Digite o ano:");
            ano = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o mês");
            mes = int.Parse(Console.ReadLine());

            DateTime primeiroDia = new DateTime(ano, mes, 1); 
            int diaMes = DateTime.DaysInMonth(ano, mes);

            Console.WriteLine("====================");
            Console.WriteLine("     Calendário     ");
            Console.WriteLine("====================");
            Console.WriteLine(mesesAparecer[mes - 1]);

            Console.WriteLine("DOM SEG TER QUA QUI SEX SAB");

            int diaSemana = (int)primeiroDia.DayOfWeek;

            for (i = 0; i < diaSemana; i++)
            {
                Console.Write("    ");
            }

            for (dia = 1; dia <= diaMes; dia++)
            {
                Console.Write($"{dia,3} ");

                if ((diaSemana + dia) % 7 == 0)
                {
                    Console.WriteLine();
                }
            }

            Console.WriteLine();


        }

    }
}


/*
DateTime.DaysInMonth() -> recebe a quantidade de dias no mes
DateTime.DayOfWeek() -> recebe o dia da semana
*/