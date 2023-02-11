using System;

namespace String_Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string degisken = "Dersimiz c# Hoşgeldiniz";
            string degisken2 = "C#";
            //Length
            Console.WriteLine(degisken.Length);
            //ToUpper , Tolower
            Console.WriteLine(degisken.ToLower());
            Console.WriteLine(degisken.ToUpper());

            //Concat
            Console.WriteLine(String.Concat(degisken, "Merhaba"));

            //Compare Compareto karşılaştırma

            Console.WriteLine(degisken.CompareTo(degisken2));//0,1-1
            Console.WriteLine(String.Compare(degisken, degisken2, true));
            Console.WriteLine(String.Compare(degisken, degisken2, false));

            //Contains

            Console.WriteLine(degisken.Contains(degisken2));
            Console.WriteLine(degisken.EndsWith("Hoşgeldiniz"));
            Console.WriteLine(degisken.StartsWith("Merhaba"));
            Console.WriteLine(degisken.IndexOf("CS"));
            //LastIndexOf
            Console.WriteLine(degisken.LastIndexOf("i"));

            //Insert
            Console.WriteLine(degisken.Insert(0, "Merhaba"));

            //Padleft,PadRight
            Console.WriteLine(degisken + degisken2.PadLeft(30));
            Console.WriteLine(degisken.PadRight(50), "*");
            Console.WriteLine(degisken + degisken2.PadLeft(30));

            //Remove 
            Console.WriteLine(degisken.Remove(10));
            Console.WriteLine(degisken.Remove(5, 3));
            Console.WriteLine(degisken.Remove(0, 1));

            //Replace
            Console.WriteLine(degisken.Replace("Csharp", "C#"));
            Console.WriteLine(degisken.Replace(" ", "*"));

            //Split
            Console.WriteLine(degisken.Split(' ')[1]);

            //Substring
            Console.WriteLine(degisken.Substring(4));
            Console.WriteLine(degisken.Substring(0,4));


        }
    }
}
