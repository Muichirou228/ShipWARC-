using System.Runtime.CompilerServices;
using System.Security.Cryptography;
namespace project
{
    class Programm
    {
        static void Skip()
        {
            for (int i = 0; i < 5; i++) 
            {
                Console.WriteLine();
            }
        }

        static void PrintTwoMaps (Player pl1, Player pl2)
        {
            pl1.PrintMap();
            Console.WriteLine();
            Console.WriteLine();
            pl2.PrintMap();
        }

        static void Main()
        {
            int turn = 1;
            Console.WriteLine("GAME RULES");
            Console.WriteLine("There are 2 players in the game. Each player has its map 10x10. Each player has 5 ships: 2 ships cost 1, 2 ships cost 2,and 1 ship cost 3.");
            Console.WriteLine("Each player has right to place their ships on map, using coordinates. For example, if the game says PLACE FIRST 1 COST SHIP, you need to write 5 and 5");
            Console.WriteLine("Your ship will be placed on cell where x = 5 and y = 5. Count starts from 0!");
            Console.WriteLine("Remember that between ships has to be a gap. In other way, game will crush :( ");
            Skip();



            // PLAYER 1

            Player pl1 = new Player();
            Console.WriteLine("Player 1 starts!");
            Console.WriteLine("Player 1 map looks like this: ");
            pl1.PrintMap();
            Skip();
            Console.WriteLine("Player 1 place FIRST 1 COST SHIP, insert coordinates: ");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            while (pl1.CheckIfZero(x, y))
            {
                Console.WriteLine("Error, those coordinates are already taken, insert again");
                x = Convert.ToInt32(Console.ReadLine());
                y = Convert.ToInt32(Console.ReadLine());
            }
            pl1.PlaceOneCostShip(x, y);
            pl1.PrintMap();
            Skip();
            Console.WriteLine("Player 1 place SECOND 1 COST SHIP, insert coordinates: ");
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());
            while (pl1.CheckIfZero(x,y)) 
            {
                Console.WriteLine("Error, those coordinates are already taken, insert again");
                x = Convert.ToInt32(Console.ReadLine());
                y = Convert.ToInt32(Console.ReadLine());
            }
            pl1.PlaceOneCostShip(x, y);
            pl1.PrintMap();
            Skip();





            Console.WriteLine("Player 1 place FIRST 2 COST SHIP, insert coordinates (x and y, x1 and y1): ");
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());
            int x1 = Convert.ToInt32(Console.ReadLine());
            int y1 = Convert.ToInt32(Console.ReadLine());
            while (pl1.CheckIfZero(x, y) || !pl1.CheckIfInOrderTwoCost(x,y,x1,y1) || pl1.CheckIfZero(x1,y1))
            {
                Console.WriteLine("Error, those coordinates are already taken or ship is not in order, insert again");
                x = Convert.ToInt32(Console.ReadLine());
                y = Convert.ToInt32(Console.ReadLine());
                x1 = Convert.ToInt32(Console.ReadLine());
                y1 = Convert.ToInt32(Console.ReadLine());
            }
            pl1.PlaceTwoCostShip(x, y, x1, y1);
            pl1.PrintMap();
            Skip();




            Console.WriteLine("Player 1 place SECOND 2 COST SHIP, insert coordinates (x and y, x1 and y1): ");
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());
            x1 = Convert.ToInt32(Console.ReadLine());
            y1 = Convert.ToInt32(Console.ReadLine());
            while (pl1.CheckIfZero(x, y) || !pl1.CheckIfInOrderTwoCost(x, y, x1, y1) || pl1.CheckIfZero(x1, y1))
            {
                Console.WriteLine("Error, those coordinates are already taken or ship is not in order, insert again");
                x = Convert.ToInt32(Console.ReadLine());
                y = Convert.ToInt32(Console.ReadLine());
                x1 = Convert.ToInt32(Console.ReadLine());
                y1 = Convert.ToInt32(Console.ReadLine());
            }
            pl1.PlaceTwoCostShip(x, y, x1, y1);
            pl1.PrintMap();
            Skip();



            Console.WriteLine("Player 1 place 3 COST SHIP, insert coordinates (x and y, x1 and y1, x2 and y2): ");
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());
            x1 = Convert.ToInt32(Console.ReadLine());
            y1 = Convert.ToInt32(Console.ReadLine());
            int x2 = Convert.ToInt32(Console.ReadLine());
            int y2 = Convert.ToInt32(Console.ReadLine());
            while (pl1.CheckIfZero(x, y) || !pl1.CheckIfInOrderTwoCost(x, y, x1, y1) || pl1.CheckIfZero(x1, y1) || pl1.CheckIfZero(x2,y2) || !pl1.CheckIfInOrderTwoCost(x1,y1,x2,y2))
            {
                Console.WriteLine("Error, those coordinates are already taken or ship is not in order, insert again");
                x = Convert.ToInt32(Console.ReadLine());
                y = Convert.ToInt32(Console.ReadLine());
                x1 = Convert.ToInt32(Console.ReadLine());
                y1 = Convert.ToInt32(Console.ReadLine());
                x2 = Convert.ToInt32(Console.ReadLine());
                y2 = Convert.ToInt32(Console.ReadLine());
            }
            pl1.PlaceThreeCostShip(x, y, x1, y1, x2, y2);
            pl1.PrintMap();
            Skip();
            Console.WriteLine("Player 1 MAP IS FINISHED");
            Skip();
            Skip();

            //PLAYER 2

            Player pl2 = new Player();
            Console.WriteLine("Player 2 starts!");
            Console.WriteLine("Player 2 map looks like this: ");
            pl2.PrintMap();
            Skip();
            Console.WriteLine("Player 2 place FIRST 1 COST SHIP, insert coordinates: ");
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());
            while (pl2.CheckIfZero(x, y))
            {
                Console.WriteLine("Error, those coordinates are already taken, insert again");
                x = Convert.ToInt32(Console.ReadLine());
                y = Convert.ToInt32(Console.ReadLine());
            }
            pl2.PlaceOneCostShip(x, y);
            pl2.PrintMap();
            Skip();
            Console.WriteLine("Player 2 place SECOND 1 COST SHIP, insert coordinates: ");
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());
            while (pl2.CheckIfZero(x, y))
            {
                Console.WriteLine("Error, those coordinates are already taken, insert again");
                x = Convert.ToInt32(Console.ReadLine());
                y = Convert.ToInt32(Console.ReadLine());
            }
            pl2.PlaceOneCostShip(x, y);
            pl2.PrintMap();
            Skip();





            Console.WriteLine("Player 2 place FIRST 2 COST SHIP, insert coordinates (x and y, x1 and y1): ");
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());
            x1 = Convert.ToInt32(Console.ReadLine());
            y1 = Convert.ToInt32(Console.ReadLine());
            while (pl2.CheckIfZero(x, y) || !pl2.CheckIfInOrderTwoCost(x, y, x1, y1) || pl2.CheckIfZero(x1, y1))
            {
                Console.WriteLine("Error, those coordinates are already taken or ship is not in order, insert again");
                x = Convert.ToInt32(Console.ReadLine());
                y = Convert.ToInt32(Console.ReadLine());
                x1 = Convert.ToInt32(Console.ReadLine());
                y1 = Convert.ToInt32(Console.ReadLine());
            }
            pl2.PlaceTwoCostShip(x, y, x1, y1);
            pl2.PrintMap();
            Skip();




            Console.WriteLine("Player 2 place SECOND 2 COST SHIP, insert coordinates (x and y, x1 and y1): ");
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());
            x1 = Convert.ToInt32(Console.ReadLine());
            y1 = Convert.ToInt32(Console.ReadLine());
            while (pl2.CheckIfZero(x, y) || !pl2.CheckIfInOrderTwoCost(x, y, x1, y1) || pl2.CheckIfZero(x1, y1))
            {
                Console.WriteLine("Error, those coordinates are already taken or ship is not in order, insert again");
                x = Convert.ToInt32(Console.ReadLine());
                y = Convert.ToInt32(Console.ReadLine());
                x1 = Convert.ToInt32(Console.ReadLine());
                y1 = Convert.ToInt32(Console.ReadLine());
            }
            pl2.PlaceTwoCostShip(x, y, x1, y1);
            pl2.PrintMap();
            Skip();



            Console.WriteLine("Player 2 place 3 COST SHIP, insert coordinates (x and y, x1 and y1, x2 and y2): ");
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());
            x1 = Convert.ToInt32(Console.ReadLine());
            y1 = Convert.ToInt32(Console.ReadLine());
            x2 = Convert.ToInt32(Console.ReadLine());
            y2 = Convert.ToInt32(Console.ReadLine());
            while (pl2.CheckIfZero(x, y) || !pl2.CheckIfInOrderTwoCost(x, y, x1, y1) || pl2.CheckIfZero(x1, y1) || pl2.CheckIfZero(x2, y2) || !pl2.CheckIfInOrderTwoCost(x1, y1, x2, y2))
            {
                Console.WriteLine("Error, those coordinates are already taken or ship is not in order, insert again");
                x = Convert.ToInt32(Console.ReadLine());
                y = Convert.ToInt32(Console.ReadLine());
                x1 = Convert.ToInt32(Console.ReadLine());
                y1 = Convert.ToInt32(Console.ReadLine());
                x2 = Convert.ToInt32(Console.ReadLine());
                y2 = Convert.ToInt32(Console.ReadLine());
            }
            pl2.PlaceThreeCostShip(x, y, x1, y1, x2, y2);
            pl2.PrintMap();
            Skip();
            Console.WriteLine("Player 2 MAP IS FINISHED");
            Skip();
            Skip();
            Console.WriteLine("Maps player 1 and player 2 looks like this");
            PrintTwoMaps(pl1, pl2);

            while (!pl1.CheckIfLost() && !pl2.CheckIfLost())
            {
                if (turn == 1)
                {
                    Console.WriteLine("PLAYER 1 turn. Please, insert coordinates for damaging/missing enemy's ship: ");
                    x = Convert.ToInt32(Console.ReadLine());
                    y = Convert.ToInt32(Console.ReadLine());
                    pl2.WhatHappens(x, y);
                } else
                {
                    Console.WriteLine("PLAYER 2 turn. Please, insert coordinates for damaging/missing enemy's ship: ");
                    x = Convert.ToInt32(Console.ReadLine());
                    y = Convert.ToInt32(Console.ReadLine());
                    pl1.WhatHappens(x, y);
                }
                if (turn == 1) { turn = 2; } else
                if (turn == 2) {  turn = 1; };
            }

            if (pl1.CheckIfLost())
            {
                Console.WriteLine("PLAYER 2 WINS, ALL SHIPS ARE DESTROYED");
            } else if (pl2.CheckIfLost())
            {
                Console.WriteLine("PLAYER 1 WINS, ALL SHIPS ARE DESTROYED");
            }
        }
    }
}





