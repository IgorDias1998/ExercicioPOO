using ContaBancariaHeranca;

Console.WriteLine("\n---  Conta Corrente :  Numero: 111 Titular: Maria   ---");
Conta conta = new();
conta.NumeroConta = 111;
conta.NomeCliente = "Igor";

Console.WriteLine("Depositando R$ 1.000,00");
conta.Depositar(1000);
Console.WriteLine("Sacando R$ 100,00");
conta.Sacar(100);
Console.WriteLine($"Saldo da conta: " + conta.Saldo.ToString("c"));
Console.WriteLine("\nSacando R$ 2.000,00");
conta.Sacar(2000);
Console.WriteLine($"Saldo da conta: " + conta.Saldo.ToString("c"));

Console.ReadKey();
Console.WriteLine("\n---  Conta Poupança :  Numero: 222 Titular: José   ---");
ContaPoupanca contapoupanca = new();
conta.NumeroConta = 222;
conta.NomeCliente = "Roger";

Console.WriteLine("Depositando R$ 1.000,00");
contapoupanca.Depositar(1000);
Console.WriteLine($"Saldo da conta poupança: " + contapoupanca.Saldo.ToString("c"));
Console.WriteLine("Sacando R$ 100,00");
contapoupanca.Sacar(100);
Console.WriteLine($"Saldo da conta poupança: " + contapoupanca.Saldo.ToString("c"));

Console.WriteLine("\nSacando R$ 2.000,00");
contapoupanca.Sacar(2000);
Console.WriteLine($"Saldo da conta poupança: " + contapoupanca.Saldo.ToString("c"));


Console.WriteLine("\n---   Conta Investimento :  Numero: 333 Titular: Ana   ---");
ContaInvestimento containvestimento = new();
conta.NumeroConta = 321;
conta.NomeCliente = "Zé";

Console.WriteLine("Depositando R$ 1.000,00");
containvestimento.Depositar(1000);
Console.WriteLine($"Saldo da conta investimento: " + containvestimento.Saldo.ToString("c"));
Console.WriteLine("Sacando R$ 100,00");
containvestimento.Sacar(100);
Console.WriteLine($"Saldo da conta investimento: " + containvestimento.Saldo.ToString("c"));

Console.WriteLine("\nSacando R$ 2.000,00");
containvestimento.Sacar(2000);
Console.WriteLine($"Saldo da conta investimento: " + containvestimento.Saldo.ToString("c"));

Console.ReadKey();

