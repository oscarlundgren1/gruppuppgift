using System.Data.Common;
using static System.Net.Mime.MediaTypeNames;

namespace gruppuppgift
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "C:\\Users\\"
                + "oscar.lundgren1\\Documents\\prog2\\gruppuppgift\\notes.txt";

            if (!File.Exists(path))
            {
                using (FileStream fs = File.Create(path)) ;
            }

            Console.WriteLine("Anteckningsblock");
            Console.WriteLine("Välkommen till anteckningsblocket!");
            Console.WriteLine("Skriv ditt Användarnamn:");
            string userName = Console.ReadLine();
            Console.WriteLine("Användarnamn är: " + userName);

            Console.WriteLine("Skriv din anteckning, ENTER för att fortsätta:");
            string note = Console.ReadLine();
            Console.WriteLine("Vill du spara dina anteckningar?");
            string save = Console.ReadLine();
            if (save == "ja")
            {
                using (StreamWriter writer = File.AppendText(path))
                {
                    writer.WriteLine(userName + "-");

                    writer.WriteLine(note + "\n");
                }
                Console.WriteLine("Dina anteckningar är sparade");
                Console.WriteLine("Vill du skriva ut dina antäckningar?");
                string read = Console.ReadLine();
                if (read == "ja")
                {
                    Console.WriteLine(note);
                }
            }
            else
            {
                Console.WriteLine("Inte sparat! Avslutar program...");
                Environment.Exit(0);
            }
        }
    }
}