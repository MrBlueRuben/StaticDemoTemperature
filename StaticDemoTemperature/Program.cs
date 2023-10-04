namespace StaticDemoTemperature
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string selection = String.Empty;
            while (selection != "q" && selection != "Q" )
            {
                Console.WriteLine("Enter C)elsius to Farenheit or\nF)arenheit to Celsius or\nK)elvin to Celsius or\nQ)uit");
                selection = Console.ReadLine();
                double farenheit, celsius = 0;

                switch (selection)
                {
                    case "C":
                    case "C":
                        Console.WriteLine("Please enter Celsius temperature:");
                        
                }


            }
        }
    }
}