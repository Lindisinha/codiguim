using System;

class programa
{
    static void Main(string[] args)
    {
        Conta conta = new Conta();
        Console.WriteLine("Digite o numero de sua conta:");
        conta.nConta = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite a agencia de sua conta:");
        conta.agencia = Console.ReadLine();
        Console.WriteLine("Digite o nome do titular:");
        conta.titular = Console.ReadLine();
        Console.WriteLine("Digite o saldo");
        conta.saldo = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Qual seu tipo de conta?\n1-normal\n2-estudantil\n3-empresarial");
        int tipo = Convert.ToInt32(Console.ReadLine());
        Console.Clear();

        switch (tipo)
        {
            case 1:
                Console.WriteLine("Que tipo de ação deseja fazer?\n1-saque\n2-deposito");
                int acao = Convert.ToInt32(Console.ReadLine()); 
                switch(acao)
                {
                    case 1:
                        Console.WriteLine("Insira o valor que deseja sacar:");
                        double saque = Convert.ToDouble(Console.ReadLine());
                        conta.Saque(saque);
                        Console.WriteLine($" saldo atual {conta.saldo}");

                        break;
                    case 2:
                        Console.WriteLine("Insira o valor que deseja depositar:");
                        double deposite = Convert.ToDouble(Console.ReadLine());
                        conta.Deposito(deposite);
                        Console.WriteLine($" saldo atual {conta.saldo}");

                        break;
                }
                break;

            case 2:
                ContaEstudante estudante = new ContaEstudante();
                Console.WriteLine("Que tipo de ação deseja fazer?\n1-saque\n2-deposito");
                int acao2 = Convert.ToInt32(Console.ReadLine());
                switch (acao2)
                {
                    case 1:
                        Console.WriteLine("Insira o valor que deseja sacar:");
                        double saque1 = Convert.ToDouble(Console.ReadLine());
                        estudante.Saque(saque1);
                        Console.WriteLine($" saldo atual {estudante.saldo}");

                        break;
                    case 2:
                        Console.WriteLine("Insira o valor que deseja depositar:");
                        double deposite1 = Convert.ToDouble(Console.ReadLine());
                        estudante.Deposito(deposite1);
                        Console.WriteLine($" saldo atual {estudante.saldo}");

                        break;
                }
                break; 
                
            case 3:
                ContaEmpresario empresario = new ContaEmpresario();
                Console.WriteLine("Que tipo de ação deseja fazer?\n1-saque\n2-deposito\n3-emprestimo");
                int acao3 = Convert.ToInt32(Console.ReadLine());
                switch (acao3)
                {
                    case 1:
                        Console.WriteLine("Insira o valor que deseja sacar:");
                        double saque2 = Convert.ToDouble(Console.ReadLine());
                        empresario.Saque(saque2);
                        Console.WriteLine($" saldo atual {empresario.saldo}");

                        break;
                    case 2:
                        Console.WriteLine("Insira o valor que deseja depositar:");
                        double deposite2 = Convert.ToDouble(Console.ReadLine());
                        conta.Deposito(deposite2);
                        Console.WriteLine($" saldo atual {conta.saldo}");

                        break;
                    case 3:
                        Console.WriteLine("Insira o valor que deseja em empréstimo:");
                        double saque3 = Convert.ToDouble(Console.ReadLine());
                        empresario.Emprestimo(saque3);
                        Console.WriteLine($" saldo atual {empresario.saldo}");
                        break;
                }
                break;
        }

    }
}





