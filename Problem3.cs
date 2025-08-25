public class Program
{
    public static void Main(String[] args) 
    {
        string[] jeepneyStops = new string[7];

        jeepneyStops[0] = "Monumento";
        jeepneyStops[1] = "5th Avenue";
        jeepneyStops[2] = "R. Papa";
        jeepneyStops[3] = "Abad Santos";
        jeepneyStops[4] = "Tayuman";
        jeepneyStops[5] = "Blumentritt";
        jeepneyStops[6] = "Carriedo";

        Console.WriteLine("-- PAPUNTA --");

        for (int i = 0; i < 7; i++)
        {
            Console.WriteLine(jeepneyStops[i]);
        }


        Console.WriteLine();
        Console.WriteLine("-- PABALIK --");

        for (int i = 6; i >= 0; i--)
        {
            Console.WriteLine(jeepneyStops[i]);
        }

    }

}
