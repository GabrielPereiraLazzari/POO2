using Atacado.BD.EF.Database;

namespace AtacadoConsole;

public class EstadoTestes : BaseTestes
{
    public EstadoTestes(AtacadoContext contexto) : base(contexto)
    {
    }

    public override void Imprimir()
    {
        Console.WriteLine("--- Exibindo Estados ---");
        foreach (Estado item in context.Estados)
        {
        Console.WriteLine($"{item.CodigoEstado} - {item.CodigoRegiao} - {item.Nome} - {item.UF}");
        }
        Console.WriteLine("--- Finalizando Cidades ---");
        Console.ReadLine();
    }
}
