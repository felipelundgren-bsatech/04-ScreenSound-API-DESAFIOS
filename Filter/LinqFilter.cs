using Desafio_Consumindo_API;
namespace Desafio_Consumindo_API.Filter;

internal class LinqFilter
{
    public static void FiltrarNumerosDistintos(List<int> numeros)
    {
        var numerosFiltrados = numeros.Distinct();
        foreach (var numero in numerosFiltrados)
        {
            Console.WriteLine($"-{numero}");
        }
    }
        
    
}
