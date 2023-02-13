using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication19
{
    class Program
    {
        static void Main(string[] args)
        {

            
            char[] karakter = new char[36]; 
            int i = 0;

            
            for (char k = 'a'; k <= 'z'; k++) 
            {
                karakter[i] = k;
                i++;
            }

            
            for (char k = '0'; k <= '9'; k++)
            {
                karakter[i] = k;
                i++;
            }


            Console.WriteLine();

            
            string sifre = ""; 
            int dizisayaci = 0;

            Random uret = new Random(); 
            for (i = 0; i <= 9; i++)
            {
                dizisayaci = uret.Next(0, 35); 

                
                sifre = sifre + karakter[dizisayaci]; 
            }

            
            Console.WriteLine("Üretilmiş olan şifre = " + sifre);

            Console.ReadKey();

        }
    }
}