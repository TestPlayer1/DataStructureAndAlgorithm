public class Program
{
    public static void Main(String[] args) 
    {
        string[] foods = new string[5];

        foods[0] = "Coke Sakto";
        foods[1] = "Lucky Me! Pancit Canton";
        foods[2] = "Piattos";
        foods[3] = "Silver Swan Suka";
        foods[4] = "Kopoko Brown";

        Console.WriteLine("Current Sari-Sari Store Inventory:");
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine((i+1) + ":" + foods[i]);
        }

        Console.WriteLine();
        Console.WriteLine("Which item number do you want to restock?");
        string strNum = Console.ReadLine();
        int index = Convert.ToInt32(strNum);


        Console.WriteLine("What is the new product name?");
        string newProduct = Console.ReadLine();

        foods[index - 1] = newProduct;

        Console.WriteLine();
        Console.WriteLine("New Sari-Sari Store Inventory:");
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine((i + 1) + ":" + foods[i]);
        }
    }

}
