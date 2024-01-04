class Program
{
    static void Main(string[] args)

    {

        int[] pesoPessoas = { 30, 60, 95, 100, 120, 98 };
        int soma = 0;
        
        for(int i = 0; i < pesoPessoas.Length; i++)
        {
            if (pesoPessoas[i] > 90)
            {
                Console.WriteLine($"Você tem {pesoPessoas[i]} kg, não podm entrar");
                Console.WriteLine("Próximo por favor");
                Console.WriteLine();
                continue;
            }
            soma += pesoPessoas[i];
        }
        Console.WriteLine(soma);
    }
}