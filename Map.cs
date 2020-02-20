using System;
using System.Collections.Generic;
using System.Text;

namespace NavalBattle
{
    public class Cell
    {

    }
    public class Map
    {
        public int Field { get; }
        public Cell[,] Cells { get; }
        public Map()
        {
            int field = 12;
            Field = field;
            Cells = new Cell[field, field];

        }
        public void CreateMap()
        {
            for (int i = 0; i < Field; i++)
            {
                for (int k = 0; k < Field; k++)
                {
                    Cells[i, k] = new Cell();
                }
            }
        }
        public void ShowMap()
        {
            for (int i = 0; i < Field-1; i++)
            {
                Console.WriteLine();
                for (int k = 0; k < Field-1; k++)
                {
                    Console.Write("\t|");
                    if (k == 0 && i!=0)
                        Console.Write(i);
                    if (i == 0 && k!=0)
                        Console.Write(k);

                }
            }
            Console.WriteLine();
        }
    }
}
