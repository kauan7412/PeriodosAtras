using System;

namespace PeriodosAtras.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string DiaRequisitado = "04/03/2022";
            DateTime Hoje = DateTime.Now;
            Console.WriteLine($"O dia atual é: {Hoje.ToShortDateString()}");
            DateTime DataObjeto = DateTime.ParseExact(DiaRequisitado, "dd/MM/yyyy", null);
            Console.WriteLine("O dia requisitado foi: " + DataObjeto.ToShortDateString());
            TimeSpan datetime01 = Hoje - DataObjeto; 
            if(datetime01.Days > 6)
            {
                int semanasPassadas = datetime01.Days / 7;
                int aa = datetime01.Days % 7;
                Console.WriteLine($"{semanasPassadas} semanas atrás, {aa} dias atrás");
            }
            else
            {
                Console.WriteLine($"{datetime01.Days} dias atrás");
            }
        }
    }
}
