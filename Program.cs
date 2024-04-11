using System;

class Program
{
    static void Main(string[] args)
    {
     
        int[,] tableauUni = {
            {1, 2, 3},
            {2, 3, 4},
            {3, 4, 5}
        };

        int[][] tableauIrre = new int[tableauUni.GetLength(0)][];

        for (int i = 0; i < tableauUni.GetLength(0); i++)
        {
            tableauIrre[i] = new int[tableauUni.GetLength(1) - 1];
            for (int j = 0; j < tableauUni.GetLength(1) - 1; j++)
            {
                tableauIrre[i][j] = tableauUni[i, j];
            }
        }


        Console.WriteLine("Tableau uni : ");
        for (int i = 0; i < tableauUni.GetLength(0); i++)
        {
            for (int j = 0; j < tableauUni.GetLength(1); j++)
            {
                Console.Write(tableauUni[i, j] + " ");
            }
            Console.WriteLine();
        }

        Console.WriteLine("Tableau irr : ");
        for (int i = 0; i < tableauIrre.Length; i++)
        {
            for (int j = 0; j < tableauIrre[i].Length; j++)
            {
                Console.Write(tableauIrre[i][j] + " ");
            }
            Console.WriteLine();
        }
    }
}
