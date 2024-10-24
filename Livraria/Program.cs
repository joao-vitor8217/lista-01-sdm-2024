using System.Globalization;

class Program {
    public static void Main(string[] args)
    {
        CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

        System.Console.WriteLine("Digite o nome do livro: ");
        string nomedolivro = Console.ReadLine();
        
        System.Console.WriteLine("Digite o nome do autor: ");
        string autor = Console.ReadLine();
        
        System.Console.WriteLine("Digite o preco dele: ");
        double preco = double.Parse(Console.ReadLine());
        

        Livro a = new Livro(nomedolivro, autor, preco);

        System.Console.WriteLine(a);
    }
}