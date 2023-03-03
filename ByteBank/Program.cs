using ByteBank;
using System;

#region comentários
//ContaCorrente contaDoAndre = new ContaCorrente();
//contaDoAndre.titular = "André Silva";
//contaDoAndre.numeroAgencia = 15;
//contaDoAndre.conta = "1010-X";
//contaDoAndre.saldo = 100;

//contaDoAndre.InformacoesConta();

//Console.WriteLine($"Saldo da conta do {contaDoAndre.titular} é {contaDoAndre.saldo}");

//ContaCorrente contaDoFabio = new ContaCorrente();

//contaDoFabio.titular = "Fabio Zanini";
//contaDoFabio.numeroAgencia = 17;
//contaDoFabio.conta = "1010-5";
//contaDoFabio.saldo = 350;

//Console.WriteLine($"Saldo da conta do Fabio = {contaDoFabio.saldo}");

//contaDoAndre.Transferir(50, contaDoFabio);
//Console.WriteLine($"Saldo do André = {contaDoAndre.saldo}");
//Console.WriteLine($"Saldo do Fabio = {contaDoFabio.saldo}");

//ContaCorrente contaDoPedro = new ContaCorrente();
//Console.WriteLine(contaDoPedro.titular);
//Console.WriteLine(contaDoPedro.saldo);
//Console.WriteLine(contaDoPedro.numeroAgencia);
//Console.WriteLine(contaDoPedro.conta);

#endregion 


//Cliente cliente = new Cliente();
//cliente.Nome = "Alfredo Neto";
//cliente.cpf = "046.473.331-67";
//cliente.Profissao = "Desenvolvedor back-end Júnior";

//ContaCorrente conta = new ContaCorrente(5, "1312-X");
//conta.SetSaldo(210);
//conta.saldo = 100;

//Console.WriteLine($"Titular = {conta.titular.nome}");
//Console.WriteLine($"CPF = {conta.titular.cpf}");
//Console.WriteLine($"Profissão = {conta.titular.profissao}");
//Console.WriteLine($"Nº Conta = {conta.conta}");
//Console.WriteLine($"Nº Agência = {conta.NumeroAgencia}");
//Console.WriteLine($"Saldo = {conta.GetSaldo()}");

//ContaCorrente conta2 = new ContaCorrente(18, "1010-X");

//conta2.SetSaldo(500);
//conta2.Titular = new Cliente();
//conta2.Titular.Nome = "José Gomes";

//Console.WriteLine(conta2.GetSaldo());
//Console.WriteLine(conta2.NumeroAgencia);


//ContaCorrente conta3 = new ContaCorrente(138, "1234-X");
//conta3.SetSaldo(300);
//Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

//ContaCorrente conta4 = new ContaCorrente(256, "9875-X");
//conta4.SetSaldo(200);
//Console.WriteLine(ContaCorrente.TotalDeContasCriadas);



Cliente titular = new Cliente();

titular.Nome = "Alfredo Neto";
titular.cpf = "046.473.331-67";
titular.Profissao = "Desenvolvedor júnior";

ContaCorrente conta = new ContaCorrente(titular, "Bradesco", 15, "10123-X");

Console.WriteLine($" Titular: {conta.Titular.Nome}");
Console.WriteLine($" Nome Da Agencia: {conta.nomeAgenca}");
Console.WriteLine($" Número Da Agencia: {conta.NumeroAgencia}");
Console.WriteLine($" conta: {conta.Conta}");

