using System; 

namespace Uppgift_5._1
{
    class Program
    {
        public static void Main()
        {
            try
            {
                Console.WriteLine("Skriv in 5 namn på nya rader");
                string[] namnArray = new string[5];
                for (int i = 0; i < namnArray.Length; i++)

                {
                    namnArray[i] = Console.ReadLine();
                }
                foreach (string namn in namnArray)
                {
                    Console.WriteLine(namn);
                }

            }
            catch
            {
                Console.WriteLine("Du måste ge rätt input, pröva igen");
                Main();
            }
        }
    }
}