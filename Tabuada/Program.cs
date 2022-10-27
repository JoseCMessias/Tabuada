
class Tabuada
{
    public static void Main(string[] args)
    {
        Console.WriteLine("=============== Tabuada ===============");
        Console.Write("Digite a operação (+ | - | * | /): ");
        char n = char.Parse(Console.ReadLine());
        Console.Write("Digite um valor para a operação: ");

        if (n == '+')
        {        
            var n1 = int.Parse(Console.ReadLine());
            for (int i = 0; i < 10; i++)
            {
                int soma = i + n1;
                Console.WriteLine($"{i} + {n1} = {soma}");
            }
        }
        if (n == '-')
        {
            var n1 = int.Parse(Console.ReadLine());
            for (int i = 0; i < 10; i++)
            {
                int Menos = i - n1;
                Console.WriteLine($"{i} - {n1} = {Menos}");
            }
        }
        if (n == '*')
        {
            var n1 = int.Parse(Console.ReadLine());
            for (int i = 0; i < 10; i++)
            {
                int Mult = i * n1;
                Console.WriteLine($"{i} * {n1} = {Mult}");
            }
        }
        if (n == '/')
        {
            var n1 = int.Parse(Console.ReadLine());
            for (int i = 0; i < 10; i++)
            {
                int Div = i / n1;
                Console.WriteLine($"{i} / {n1} = {Div}");
            }
        }
    }
}
