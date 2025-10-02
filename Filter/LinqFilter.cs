using Desafio_Consumindo_API.Pais;
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
        
    public static void FiltrarLivrosPorAno(List<Livros> livros, int ano) 
    {
        var livrosFiltrados = livros.Where(l => l.Ano > ano);
        foreach (var livro in livrosFiltrados)
        {
            Console.WriteLine($"-{livro.Titulo} - {livro.Ano}");
        }
    }

    public static void FiltrarPrecoMedio(List<Produtos> produtos)
    {
        var precoMedio = produtos.Average(p => p.Preco);
        Console.WriteLine($"Preço médio dos produtos: R$ {precoMedio}");
    }

    public static void RetornarApenasPares(List<int> numeros)
    {
        var numerosPares = numeros.Where(n => n % 2 == 0);
        foreach (var numero in numerosPares)
        {
            Console.WriteLine($"O numero {numero} é par");
        }
    }
}
    