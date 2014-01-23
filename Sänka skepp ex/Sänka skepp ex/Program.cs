using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Battleship
{
    class BattleshipBoard
    {


        public void DisplayBoard(char[,] Board)//Skapar spelplanen men fyller inte i skeppen.
        {
            int Row;
            int Column;

            Console.WriteLine("  ¦ 0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("--+--------------------");
            for (Row = 0; Row <= 9; Row++)
            {
                Console.Write((Row).ToString() + " ¦ ");
                for (Column = 0; Column <= 9; Column++)
                {
                    Console.Write(Board[Column, Row] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n");
        }
    }

    class Player
    {
        char[,] Grid = new char[10, 10];
        public int HitCount = 0;
        public int MissCount = 0;
        int x = 0;
        int y = 0;

        public int getHitCount()
        {
            return HitCount;
        }
        public int getMissCount()//gethit och getmiss skriver ut antalet träffar och missar.
        {
            return MissCount;
        }
        public void AskCoordinates() //Läser av koordinater för missiler.
        {
            Console.WriteLine("Enter X");
            string line = Console.ReadLine();
            int value;
            if (int.TryParse(line, out value))
            {
                x = value;
            }

            Console.WriteLine("Enter Y");
            line = Console.ReadLine();
            if (int.TryParse(line, out value))
            {
                y = value;
            }

            try
            {
                if (Grid[x, y].Equals('S') || Grid[x ,y].Equals('H'))
                {
                    if (Grid[x, y].Equals('S'))
                        HitCount++;
                    Grid[x, y] = 'H'; 
                    Console.Clear();
                    Console.WriteLine("Hit!\r\n");
                    
                    
                    
                }
                else
                {
                    Grid[x, y] = 'M';
                    Console.Clear();
                    Console.WriteLine("Miss!\r\n");
                    MissCount ++;
                }
            }
            catch
            {
                Console.Clear();
                Console.WriteLine("Error: Please enter numbers between 0 and 9."); //Felmeddelande om koordinaterna inte finns.
            }
        }
        public char[,] GetGrid()//Visar spelplanen efter ändring.
        {

            return Grid;
            
        }
        public void SetGrid(int q, int w)//Placerar skeppen.
        {
            Grid[q, w] = 'S';
            if (Grid[q, w] == 'S')
            {
                Grid[q, w] = ' ';
            }
        }
        public void Placeships()//Skapar skeppen.
        {

            Random r = new Random(2);
            //1 skepp med längd 2.
            SetGrid(1, 2);
            SetGrid(2, 2);
            //2 skepp med längd 3.
            SetGrid(4, 3);
            SetGrid(4, 4);
            SetGrid(4, 5);

            SetGrid(5, 0);
            SetGrid(6, 0);
            SetGrid(7, 0);
            //1 skepp med längd 4.
            SetGrid(0, 8);
            SetGrid(1, 8);
            SetGrid(2, 8); 
            SetGrid(3, 8);
            //1 skepp med längd 5.
            SetGrid(7, 4);
            SetGrid(7, 5);
            SetGrid(7, 6);
            SetGrid(7, 7);
            SetGrid(7, 8);
        }
    }



    class Program
    {

        static void Main(string[] args)//Kör programmet.
        {
          
            Console.Title = "Battleship!";
            Console.WriteLine("Welcome to Battleship!\r\n\r\n");
            Console.WriteLine("What is your name?");
            string name = System.Console.ReadLine();
            Console.WriteLine();
            BattleshipBoard b = new BattleshipBoard();
            Player p = new Player();
            p.Placeships();
            while (p.getHitCount() < 17)
            {
                b.DisplayBoard(p.GetGrid());
                p.AskCoordinates();
            }
            Console.WriteLine("Congratulations, " + name + "! You Win!\r\n");
            Console.WriteLine("You missed: " + p.getMissCount() + " times\r\n");
            Console.WriteLine("Thanks for playing Battleship. Press enter to quit.");
            System.Console.ReadLine();
        }


    }
}
