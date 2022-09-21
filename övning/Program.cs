using System; 



    namespace Uppgift_3_1
{
    class program
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Vilkan plats kom du på i den senaste idrottsturneringen du deltog i?");
            string plats = Console.ReadLine();

            switch (plats)
            {
                case "1": 
                    Console.WriteLine("Jag kom etta."); 
                    break; 

                case "2":
                    Console.WriteLine("Jag kom tvåa.");
                        break;

                case "3":
                    Console.WriteLine("Jag kom trea.");
                    break;  

                    default: Console.WriteLine("Jag kom under top tre.");
                    break;  

            }
        }
    }
}