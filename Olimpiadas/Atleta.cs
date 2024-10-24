
class Atleta
{
    public string Nome { get; private set; }
    public int QtdDeMedalha { get; private set; }
    public string Pais { get; private set; }



public Atleta (string nome, int qtddemedalha, string pais) {
    Nome = nome;
    QtdDeMedalha = qtddemedalha;
    Pais = pais;
}

public override string ToString()
{
    
    return "Nome: " + Nome + "\nQuantidade de medalha: " + QtdDeMedalha + "\nPais: " + Pais;
}
}
