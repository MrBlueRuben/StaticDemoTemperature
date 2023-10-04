namespace StaticDemoTemperature
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string selection = Console.ReadLine();
            while (selection != "q" && selection != "Q" )
            {
                Console.WriteLine("Enter C)elsius to Farenheit or\nF)arenheit to Celsius or\nK)elvin to Celsius or\nQ)uit");
                Console.WriteLine();
            }
        }
    }
}