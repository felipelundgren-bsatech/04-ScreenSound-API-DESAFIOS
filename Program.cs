////desafio 1
//using (HttpClient client = new HttpClient())
//{
//    try
//    {
//        string resposta = await client.GetStringAsync("https://www.cheapshark.com/api/1.0/deals");
//        Console.WriteLine(resposta);
//    }
//    catch (Exception ex)
//    {
//        Console.WriteLine($"Ocorreu um erro: {ex.Message}");
//    }
//}
//---------------------------------------------------------------------------------------------------
////desafio 2
//Console.WriteLine("escolha 2 numeros:");
//Console.Write("numero 1: ");
//int a = int.Parse(Console.ReadLine());
//Console.Write("\nnumero 2: ");
//int b = int.Parse(Console.ReadLine());

//try
//{
//    Console.WriteLine($"O resultado da divisao entre A e B é {a / b}");
//}
//catch (Exception ex)
//{
//    Console.WriteLine($"Ocorreu um erro: {ex.Message}");
//}
//---------------------------------------------------------------------------------------------------
////desafio 3
//List<int> numeros = new List<int> { 4, 6, 8, 10 };
//Console.WriteLine("Escolha um indice para acessar na lista(entre 0 e 3): ");
//int num = int.Parse(Console.ReadLine());
//try
//{
//    Console.WriteLine($"numero escolhido pelo indice é {numeros[num]}");
//}

//catch (Exception ex)
//{
//    Console.WriteLine($"Ocorreu um erro: {ex.Message}");
//}
//---------------------------------------------------------------------------------------------------
////desafio 4

//class Pessoa
//{
//    public Pessoa(string nome)
//    {
//        Nome = nome;
//    }
//    public string Nome { get; }

//    public void Apresentar()
//    {
//        Console.WriteLine($"Olá, meu nome é {Nome}");
//    }
//}

//Pessoa p = null;

//try
//{

//    p.Apresentar();
//}
//catch (Exception ex)
//{
//    Console.WriteLine("Erro! O objeto é nulo. Você não pode chamar um método nele.");
//}
//---------------------------------------------------------------------------------------------------
////Desafio 5

//using Desafio_Consumindo_API.Filter;
//using Desafio_Consumindo_API.Pais;
//using System.Text.Json;

//using (HttpClient client = new HttpClient())
//{
//    try
//    {
//        string resposta = await client.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/TopMovies.json");
//        var filme = JsonSerializer.Deserialize<List<Filme>>(resposta)!;
//        Console.WriteLine(filme.Count);

//        filme[1].ExibirDetalhesDoFilme();
//    }
//    catch (Exception ex)
//    {
//        Console.WriteLine($"Ocorreu um erro: {ex.Message}");
//    }
//}
//---------------------------------------------------------------------------------------------------
////Desafio 6
//using Desafio_Consumindo_API.Filter;

//List<int> numeros = new List<int> { 4, 6, 8, 10,10,10 };

//LinqFilter.FiltrarNumerosDistintos(numeros);
////---------------------------------------------------------------------------------------------------
/////Desafio 7
//using Desafio_Consumindo_API.Pais;
//using Desafio_Consumindo_API.Filter;
//using Desafio_Consumindo_API;


//var livros = new List<Livro>
//        {
//            new Livro { Titulo = "O Nome do Vento", Autor = "Patrick Rothfuss", Ano = 2007 },
//            new Livro { Titulo = "A Guerra dos Tronos", Autor = "George R. R. Martin", Ano = 1996 },
//            new Livro { Titulo = "A Dança dos Dragões", Autor = "George R. R. Martin", Ano = 2011 },
//            new Livro { Titulo = "O Senhor dos Anéis", Autor = "J.R.R. Tolkien", Ano = 1954 },
//            new Livro { Titulo = "Mistborn", Autor = "Brandon Sanderson", Ano = 2006 }
//        };

//LinqFilter.FiltrarLivrosPorAno(livros, 2000);
//---------------------------------------------------------------------------------------------------
////Desafio 8

//using Desafio_Consumindo_API.Filter;
//using Desafio_Consumindo_API.Pais;

//var produtos = new List<Produtos>
//        {
//            new Produtos { Nome = "Notebook", Preco = 2500 },
//            new Produtos { Nome = "Mouse", Preco = 75 },
//            new Produtos { Nome = "Teclado", Preco = 120 },
//            new Produtos { Nome = "Monitor", Preco = 950 }
//        };
//LinqFilter.FiltrarPrecoMedio(produtos);
//---------------------------------------------------------------------------------------------------
////Desafio 9
//using Desafio_Consumindo_API.Pais;
//using Desafio_Consumindo_API.Filter;

//var numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

//LinqFilter.RetornarApenasPares(numeros);
//---------------------------------------------------------------------------------------------------


