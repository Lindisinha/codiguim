public class ContaEstudante : Conta
{
    public double chequeEsp = 2000;
    public string cpf;
    public string instituicao;

    public virtual void Saque(double valor)
    {
        if (valor <= this.saldo + chequeEsp)
        {
            this.saldo -= valor;
        }
    }

}