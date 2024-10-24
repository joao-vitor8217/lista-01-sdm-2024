
namespace Pessoa;

public class PessoaFisica
{
    public string Nome { get; private set; }
    public long Cpf { get; private set; }
    public char Sexo { get; private set; }
    public string Nacionalidade { get; private set; }


    public PessoaFisica(string nome, long cpf, char sexo, string nacionalidade)
    {
        Nome = nome;
        Cpf = cpf;
        Sexo = sexo;
        Nacionalidade = nacionalidade;
    }

    public override string ToString()
    {
        return "Nome: " + Nome + "\nCPF: " + Cpf + "\nSexo: " + Sexo + "\nNacionalidade: " + Nacionalidade;
    }



}


