public class ContaEmpresario : Conta
{
    public double anuidade;
    public double limiteEmprestimo = 10000;
    public double totalEmprestimo;

    public double Emprestimo(double valor)
    {
        if (valor <= limiteEmprestimo)
        {
            this.saldo = saldo + valor;
            this.totalEmprestimo += valor;
            Console.WriteLine("Empréstimpo realizado com sucesso");
        }
        else
        {
            Console.WriteLine("O valor de empréstimo não pode ser concedido");
        }
        return saldo;
    }
    public virtual double Saque(double valor)
    {
        if (valor <= this.saldo)
        {
            if (valor >= 5000)
            {
                this.saldo = saldo - (valor + 5);
            }
            else
            {
                this.saldo = saldo - valor;
            }
        }
        return saldo;
    }
}