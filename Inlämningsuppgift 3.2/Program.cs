using System;

namespace uppgift_3._2
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Har du gått ut gymnasiet? (svara med \"j\" för ja och \"n\" nej)");
            string svar = Console.ReadLine();
            Console.WriteLine("Hur gammal är du?");
            int ålder = int.Parse(Console.ReadLine());
            if (svar == "j" && ålder < 22)
            {
                Console.WriteLine("Vi vill gärna anställa dig!");
            }
            else
            {
                Console.WriteLine("Vi letar tyvärr efter annan personal just nu.");
            }
            Console.Read();
        }
    }
}