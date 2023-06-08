using System;
public class ContaBancaria
{
    private static string Agencia;
    private static string nConta;
    private static string Operacao;
    private static string Saldo;

    public static string getSetAgencia
    {
        get { return Agencia; }
        set { Agencia = value; }
    }
    public static string getSetnConta
    {
        get { return nConta; }
        set { nConta = value; }
    }
    public static string getSetOperacao
    {
        get { return Operacao; }
        set { Operacao = value; }
    }

    public static string getSetSaldo
    {
        get { return Saldo; }
        set { Saldo = value; }
    }
    public ContaBancaria(string agencia, string nConta, string operacao, string saldo)
    {
        getSetAgencia = agencia;
        getSetnConta = nConta;
        getSetOperacao = operacao;
        getSetSaldo = saldo;
    }
    public static (string, string, string, string) Consultar()
    {
        return (Agencia, nConta, Operacao, Saldo);
    }
    public static string Depositar(string valor)
    {
        return (Convert.ToDouble(Saldo) + Convert.ToDouble(valor)).ToString();
    }
    public static string Transferir(string valor)
    {
        if (Convert.ToDouble(valor) > Convert.ToDouble(Saldo))
        {
            return false.ToString();
        }
        return (Convert.ToDouble(Saldo) - Convert.ToDouble(valor)).ToString();
    }
    public static string Sacar(string valor)
    {
        if (Convert.ToDouble(valor) > Convert.ToDouble(Saldo))
        {
            return false.ToString();
        }
        return (Convert.ToDouble(Saldo) - Convert.ToDouble(valor)).ToString();
    }
}