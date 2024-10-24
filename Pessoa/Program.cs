using Pessoa;

class Program {
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Digite seu nome" );
        string nome = Console.ReadLine();
        
        System.Console.WriteLine("Digite seu CPF: ");
        long cpf = long.Parse(Console.ReadLine());
        
        System.Console.WriteLine("Digite seu sexo: ");
        char sexo = char.Parse(Console.ReadLine());
        
        System.Console.WriteLine("Digite sua nacionalidade: ");
        string nacionalidade =Console.ReadLine();

        PessoaFisica a = new PessoaFisica(nome, cpf, sexo, nacionalidade );

        System.Console.WriteLine(a);
        
    }
}