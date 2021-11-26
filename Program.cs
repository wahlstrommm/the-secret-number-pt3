using System;

namespace Det_hemliga_talet_del_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y = 0; //x motsvarar det talet som användaren skriver in och y motsvarar "varven"
            Random randomerare = new Random();
            int slump_tal = randomerare.Next(1, 101); // genrerar ett tal 1-100

            Console.WriteLine("Var vänlig att skriv in ett tal mellan 1-100:"); // skriver ut till användare och frågar efter ett tal.
            
            do //do while loop börjar här.
            {


                 x = Convert.ToInt32(Console.ReadLine());// "fångar" upp användares tal och konverterar det till ex

                
                if (x < slump_tal) // om slumptalet är större än x så kommer instruktionerna nedan skrivas ut.
                {
                    
                    if (slump_tal - x < 10) // om det är inom 10 kommer detta skrivas ut
                    {
                        Console.WriteLine("Ditt tal var för lågt men väldigt nära skriv ett nytt!");// skrivs ut
                    }
                    else //annars om det är längre ifrån 10 eller mer kommer detta nedanför skrivas ut
                    {
                        Console.WriteLine("Ditt tal var för lågt skriv ett nytt!"); // skrivs ut
                    }
                }
                else if (x > slump_tal) //om x är större än slumptalet kommer instruktionerna nedan för skrivas ut
                {
                    if (x - slump_tal < 10) // om det är inom 10 eller mindre kommer detta nedanför skirvas ut
                    {
                        Console.WriteLine("Ditt tal var för högt men väldigt nära skriv ett nytt!"); // skrivs ut
                    }
                    else //annars om det är längre ifrån 10 eller mer kommer detta nedanför skrivas ut
                    {
                        Console.WriteLine("Ditt tal var för högt skriv ett nytt!");//skrivs ut
                    }
                }

                y++;// lägger på 1 på mina "varv"


            } while (slump_tal != x); // Loopa så länge gissningen är inte lika med slump_talet.
            Console.WriteLine("Du gissade rätt! Det tog " + y + " gånger!"); //kommer skriva ut hur många gånger det tog att gissa rätt!
                Console.ReadKey();//så programmet inte stängs ner.
        }
    }
}
