using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoTeste
{
    internal class Banco
    {
        public int Numconta { get; private set; }
        public string TitularConta { get; set; }
        public double Saldo  { get; private set; }
        
        public Banco(int numconta, string titularConta)
        {
            Numconta = numconta;
            TitularConta = titularConta;
        }
        public Banco(int numconta, string titularConta, double saldo) : this(numconta, titularConta) {
            Saldo = saldo;
        }
        //metodos
        public double AddDeposito(double deposito) {
            return Saldo = Saldo + deposito;
        }

        public double Saque(double saque) {
            return Saldo = Saldo - saque - 5;
        }

        public override string ToString()
        {
            return "Conta: " + Numconta + " Titular: " + TitularConta + " Saldo: R$ " + Saldo;
        }
    }
}
