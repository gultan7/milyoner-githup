﻿namespace milyoner_githup
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Kim Milyoner Olmak İster - V1
            Console.WriteLine("Kim Milyoner Olmak İster\n");
            Console.Write("İsim Giriniz: ");
            
            string isim = Console.ReadLine();
            Console.Write("Soyisim Giriniz: ");
            string soyisim = Console.ReadLine();

            Console.Write("\n1.Telefon Jokerinizi Giriniz: ");
            string telefonJoker1 = Console.ReadLine();
            Console.Write("2.Telefon Jokerinizi Giriniz: ");
            string telefonJoker2 = Console.ReadLine();
            Console.Write("3.Telefon Jokerinizi Giriniz: ");
            string telefonJoker3 = Console.ReadLine();
            
            Console.Clear();
            Console.WriteLine("Hoşgeldiniz " + isim + " " + soyisim);
            
            Console.Write("Kurallar: ");
            char kuralCevap = char.Parse(Console.ReadLine().ToUpper());



        }
    }
    }
        }
    }
}