using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NuxBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaTeste = new ContaCorrente(2147, 00326437);

            try
            {
                contaTeste.Sacar(contaTeste, 250);
            }
            catch (SaldoInsuficienteException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
