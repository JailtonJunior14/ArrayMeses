using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayMeses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] meses = {"","Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho", "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro"};
            Console.WriteLine("Digite o numero de um mês: ");
            int i = int.Parse(Console.ReadLine());
            Console.WriteLine("Mês selecionado: " + meses[i]);
            Console.ReadKey();
        }
    }
}
