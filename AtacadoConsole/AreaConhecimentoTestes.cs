using Atacado.BD.EF.Database;

namespace AtacadoConsole;

public class AreaConhecimentoTestes : BaseTestes
{
    public AreaConhecimentoTestes(AtacadoContext contexto) : base(contexto)
    {
    }

    public override void Imprimir()
    {
        Console.WriteLine("--- Exibindo Areas de Conhecimento ---");
        foreach (AreaConhecimento item in context.AreasConhecimento)
        {
        Console.WriteLine($"{item.CodigoArea} - {item.Descricao} - {item.DataInclusao}");
        }
        Console.WriteLine("--- Finalizando Areas ---");
        Console.ReadLine();
    }
}
