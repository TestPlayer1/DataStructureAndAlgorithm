public class Program
{
    public static void Main(String[] args) 
    {
        string[] foods = new string[5];

        for (int i = 0; i < 5; i++)
        {   
            Console.Write("Enter food #" + (i + 1) + ":");
            foods[i] = Console.ReadLine();
        }

        Console.WriteLine("Your favorite foods are:");

        for (int i = 0;i < 5; i++)
        {
            Console.WriteLine(foods[i]);
        }
    }
}
