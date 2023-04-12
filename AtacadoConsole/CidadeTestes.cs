using Atacado.BD.EF.Database;

namespace AtacadoConsole;

public class CidadeTestes : BaseTestes
{
    public CidadeTestes(AtacadoContext contexto) : base(contexto)
    {
    }

    public override void Imprimir()
    {
        Console.WriteLine("--- Exibindo Cidades ---");
        foreach (Cidade item in context.Cidades)
        {
        Console.WriteLine($"{item.CodigoCidade} - {item.CodigoEstado} - {item.CodigoIBGE7}");
        }
        Console.WriteLine("--- Finalizando Cidades ---");
        Console.ReadLine();
    }
}
