using ByteBank_ADM.Funcionarios;
using ByteBank_ADM.Utilitario;
using System;

namespace ByteBank_ADM
{
    public class Program
    {
        static void Main(string[] args)
        {
            Funcionario pedro = new Funcionario();

            pedro.Nome = "pedro Malazartes";
            pedro.Cpf = "658.956.845-89";
            pedro.Salario = 1500.00;

            Console.WriteLine(@$" Nome: {pedro.Nome}
 CPF: {pedro.Cpf}
 Salário: {pedro.Salario} 
 Bonificação: {pedro.GetBonificacao()}");
            Console.WriteLine();
            Diretor Dayan = new Diretor();

            Dayan.Nome = "Dayan Belém";
            Dayan.Cpf = "869.852.369-65";
            Dayan.Salario = 20000;

            Console.WriteLine(@$" Nome: {Dayan.Nome}
 CPF: {Dayan.Cpf}
 Salário: {Dayan.Salario} 
 Bonificação: {Dayan.GetBonificacao()}");

            Console.WriteLine();

            GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();

            gerenciador.Registrar(pedro);
            gerenciador.Registrar(Dayan);

            Console.WriteLine($"Total de bonificações: {gerenciador.TotalDeBonificacao}");

        }
    }
}