using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    public class ContaCorrente
    {
        public static int TotalDeContasCriadas { get; private set; }

        private int numeroAgencia;

        public string nomeAgenca;

        public int NumeroAgencia
        {
            get { return this.numeroAgencia; }
            private set
            {
                if (value > 0)
                {

                    this.numeroAgencia = value;

                }

            }
        }
        //private string conta;
        public string Conta { get; set; }

        public Cliente Titular { get; set; }

        private double saldo = 100;

        public void Depositar(double valor)
        {
            this.saldo += valor;

        }

        public bool Sacar(double valor)
        {
            if (valor <= this.saldo)
            {
                this.saldo -= valor;
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool Transferir(double valor, ContaCorrente destino)
        {
            if (this.saldo < valor)
            {
                return false;
            }
            else
            {
                this.Sacar(valor);
                destino.Depositar(valor);

                return true;
            }
        }

        public void InformacoesConta()
        {
            Console.WriteLine($"Titular : {Titular}");
            Console.WriteLine($"conta : {Conta}");
            Console.WriteLine($"Número da Agencia : {numeroAgencia}");
            Console.WriteLine($"saldo : {saldo}");
        }

        public void SetSaldo(double valor)
        {
            if (valor < 0)
            {
                return;
            }
            else
            {
                this.saldo = valor;
            }
        }

        public double GetSaldo()
        {
            return this.saldo;
        }

        public ContaCorrente(int numeroAgencia, string numeroConta)
        {
            this.numeroAgencia = numeroAgencia;
            this.Conta = numeroConta;
            TotalDeContasCriadas++;
        }

        public ContaCorrente(Cliente titular, string nome_agencia, int numero_agencia, string conta)
        {
            Titular = titular;
            nomeAgenca = nome_agencia;
            NumeroAgencia = numero_agencia;
            Conta = conta;
        }

    }
}
