public class Conta
{

    public int nConta;
    public string agencia;
    public string titular;
    public double saldo;

    public double Saque(double valor)
    {
        if (valor <= this.saldo)
        {
            this.saldo = saldo - valor;           
        }
        return this.saldo;
    }
    public double Deposito(double deposito)
    {
        this.saldo = saldo + deposito;
        return this.saldo;
    }
}
