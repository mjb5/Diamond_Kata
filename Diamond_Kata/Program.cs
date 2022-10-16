using Diamond_Kata;

internal class Program
{    
    private static void Main(string[] args)
    {
        DiamondBuilder builder = new DiamondBuilder();

        Console.WriteLine(builder.Build(args[0]));
    }
}