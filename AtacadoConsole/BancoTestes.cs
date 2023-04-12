using Atacado.BD.EF.Database;

namespace AtacadoConsole;

public class BancoTestes : BaseTestes
{
    public BancoTestes(AtacadoContext contexto) : base(contexto)
    {
    }

    public override void Imprimir()
    {
        Console.WriteLine("--- Exibindo Bancos ---");
        foreach (Banco item in context.Bancos)
        {
        Console.WriteLine($"{item.CodigoBanco} - {item.Descricao} - {item.SiteBanco}");
        }
        Console.WriteLine("--- Finalizando Regiões ---");
        Console.ReadLine();
    }
}
