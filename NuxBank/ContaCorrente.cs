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
        public int TotalDeContasCriadas { get; set; }
        public bool Status { get; set; }
        
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
                throw new SaldoInsuficienteException($"Você tentou sacar um valor superior ao seu saldo. Valor da tentativa: R${valorDeSaque}");
            }

            conta.Saldo -= valorDeSaque;
            
        }

        public void Transferir(ContaCorrente contaOrigem, ContaCorrente contaDestino, decimal valorDeTransferencia)
        {
            if(contaOrigem.Saldo < valorDeTransferencia)
            {
                throw new SaldoInsuficienteException($"Você tentou transferir um valor para a conta {contaDestino.NumeroConta}. Valor da tentativa: R${valorDeTransferencia}");
            }

            contaOrigem.Saldo -= valorDeTransferencia;
            contaDestino.Saldo += valorDeTransferencia;

        }

    }
}
