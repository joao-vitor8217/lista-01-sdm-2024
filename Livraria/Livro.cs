class Livro {
    public string NomeDoLivro { get; private set; }
    public string Autor { get; private set; }
    public double Preco { get; set; }


public Livro(string nomedolivro, string autor, double preco) {
    NomeDoLivro = nomedolivro;
    Autor = autor;
    Preco = preco;
    }

    public override string ToString()
    {
        return "Nome do Livro: " + NomeDoLivro + "\nAutor: " + Autor + "\nPreco: " + Preco.ToString("F2");
    }
}