namespace BancoTeste
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Banco conta;
            Console.Write("Numero Conta: ");
            int numconta = int.Parse(Console.ReadLine());
            Console.Write("Titular Conta: ");
            string titularConta = Console.ReadLine();
            Console.Write("Havera deposito inicial? (s/n)");
            String escolha = Console.ReadLine();
            if (escolha == "s")
            {
                Console.WriteLine("Entre com o Valor de deposito inicial: ");
                double depini = double.Parse(Console.ReadLine());
                conta = new Banco(numconta,titularConta,depini);
            } else
            {
                conta = new Banco(numconta,titularConta);
            }
            Console.WriteLine();// pula linha
            Console.WriteLine("Dados da Conta: ");
            Console.WriteLine(conta);
            Console.WriteLine();// pula linha

            Console.Write("Entre com um valor para deposito: ");
            double deposito = double.Parse(Console.ReadLine());
            conta.AddDeposito(deposito);
            Console.WriteLine("Dados Atualizados:");
            Console.WriteLine(conta);
            Console.WriteLine();
            Console.Write("Entre com um valor para saque: ");
            double saque = double.Parse(Console.ReadLine());
            conta.Saque(saque);
            Console.WriteLine("Dados Atualizados:");
            Console.WriteLine(conta);

        }
    }
}
