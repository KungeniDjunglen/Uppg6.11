using System;

class program
{
    static void RitaKvadrat(int Size, string Tecken, int Space = 0)
    {
        for (int i = 0; i < Size; i++) // Höjden
        {
            for (int j = 0; j < Size; j++) //bredden
            {
                Console.Write(Tecken);
                for (int k = 0; k < Space; k++) //Mellanslag Space
                {
                    Console.Write(" ");
                }
            }
            for (int k = 0; k < Space; k++) { Console.Write("\n"); } //Skriver entertecken
            Console.WriteLine();
        }
    }
    static void Main()
    {
        RitaKvadrat(5, "X", 2);
    }
}