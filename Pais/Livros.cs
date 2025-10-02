namespace Desafio_Consumindo_API.Pais
{
    internal class Livros
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int Ano { get; set; }

        public void ExibirDetalhesDoLivro()
        {
            Console.WriteLine($"Título: {Titulo}");
            Console.WriteLine($"Autor: {Autor}");
            Console.WriteLine($"Ano: {Ano}");
        }
    }
}
