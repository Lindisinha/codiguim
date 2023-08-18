public class Conta
{

    public int nConta;
    public string agencia;
    public string titular;
    public double saldo;

    public void Saque(double valor)
    {
        if (valor <= this.saldo)
        {
            this.saldo = saldo - valor;
        }
    }
    public void Deposito(double deposito)
    {
        this.saldo = saldo + deposito;
    }
}
