using System;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Text;

namespace PIII_Lab3
{
    class Program
    {

        static void Suma(ref int[][] tab1)
        {
            int wynik = 0;
            for (int i = 0; i < tab1.Length; i++)
            {
                for (int j = 0; j < tab1[i].Length; j++)
                {
                    wynik += tab1[i][j];

                }
            }

            Console.WriteLine($"Suma wartosci tabeli wynosi: {wynik}");

        }

        static void SprawdzTekst(ref string text)
        {
            string v = char.ToUpper(text[0]) + text.Substring(1);

            if (v.EndsWith("."))
            {

                Console.WriteLine(v);

            }
            else
            {
                StringBuilder stringBuilder = new StringBuilder(v);
                stringBuilder.Append(".");
                Console.WriteLine(stringBuilder);
            }

        }

        static void Main(string[] args)
        {
            int[][] tab1 =
            {
                new int[3] { 4, 2, 4 },
                new int[2] { 5, 7 }
            };

            for (int i = 0; i < tab1.Length; i++)
            {
                System.Console.Write("tabela({0}): ", i);

                for (int j = 0; j < tab1[i].Length; j++)
                {
                    System.Console.Write("{0}{1}", tab1[i][j], j == (tab1[i].Length - 1) ? "" : " ");
                }
                System.Console.WriteLine();
            }

            Suma(ref tab1);

            Console.WriteLine("Podaj zdanie: ");
            string text = Console.ReadLine();
            if (!string.IsNullOrEmpty(text) && !string.IsNullOrWhiteSpace(text))
            {
                SprawdzTekst(ref text);
            }
            else
            {
                Console.WriteLine("nie wpisano zadnego tekstu");
            }
        }

    }
}