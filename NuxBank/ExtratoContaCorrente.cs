using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NuxBank
{
    public class ExtratoContaCorrente
    {
        List<decimal> saldos = new List<decimal>();
        public decimal Saldo { get; set; }
        public ContaCorrente Conta { get; set; }

        public ExtratoContaCorrente(ContaCorrente conta)
        {
            this.Conta = conta;
            this.Saldo = conta.Saldo;
            
        }


    }
}
