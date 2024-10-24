
class Program {
    public static void Main(string[] args)
    {
    
        System.Console.WriteLine("Digite seu nome: ");
        string nome = Console.ReadLine();
        
        System.Console.WriteLine("Digite a quantidade de medalhas: ");
        int qtddemedalha = int.Parse(Console.ReadLine());
        
        System.Console.WriteLine("Digite seu pais: ");
        string pais = Console.ReadLine();

        Atleta a = new Atleta(nome, qtddemedalha, pais);

        System.Console.WriteLine(a);
        
    }
}
