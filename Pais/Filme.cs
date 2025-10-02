using System.Text.Json.Serialization;

namespace Desafio_Consumindo_API.Pais;

internal class Filme

{
    [JsonPropertyName("title")]
    public string Titulo { get; set; }
    [JsonPropertyName("year")]
    public string Ano { get; set; }
    [JsonPropertyName("imDbRating")]
    public string Nota { get; set; }
  

    public void ExibirDetalhesDoFilme()
    {
        Console.WriteLine($"Ano: {Ano}");
        Console.WriteLine($"Musica: {Titulo}");
        Console.WriteLine($"Nota: {Nota}");
     

    }
}