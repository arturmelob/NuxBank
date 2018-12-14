using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NuxBank
{
    public class ContaCorrente
    {
        public int NumeroAgencia { get; set; }
        public int NumeroConta { get; set; }
        public Cliente Titular { get; set; }
        private decimal _saldo { get; set; }
        public decimal Saldo {

            get {
                return _saldo;
            }

            set {

                if (value < 0)
                    return;
                _saldo = value;
            }
        }
        public int TotalDeContasCriadas { get; set; }
        public bool Status { get; set; }

        public ContaCorrente(int agencia, int conta){

            if(agencia <= 0)
            {
                throw new ArgumentException();
            }

            TotalDeContasCriadas++;
        }

        public void Sacar(ContaCorrente conta, decimal valorDeSaque)
        {
            if(conta.Saldo <= valorDeSaque)
            {
                throw new SaldoInsuficienteException();
            }

        }

    }
}
