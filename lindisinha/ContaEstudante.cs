public class ContaEstudante : Conta
{
    public double chequeEsp = 2000;
    public string cpf;
    public string instituicao;
    public double teste;
    Conta c = new Conta();
    public virtual double Saque(double valor)
    {
        if (valor <= c.saldo + chequeEsp)
        {
            c.saldo -= valor;
            teste = c.saldo;
        }
        return this.teste;
    }

}