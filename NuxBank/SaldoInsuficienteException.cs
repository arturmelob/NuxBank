using System;
using System.Runtime.Serialization;

namespace NuxBank
{
    public class SaldoInsuficienteException : Exception
    {
        public decimal Saldo { get; set; }
        public decimal ValorSaque { get; set; }
        public SaldoInsuficienteException()
        {
        }

        public SaldoInsuficienteException(decimal saldo, decimal valorSaque)
                : this($"Tentativa de realizar saque no valor de {valorSaque} em uma conta de saldo {saldo}")
        {
        }

        public SaldoInsuficienteException(string message)
            : base(message)
        {
        }

        public SaldoInsuficienteException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
           }

    }
}