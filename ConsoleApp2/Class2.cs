using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    public class Map
    {
        public Map() {
            for (int i = 0; i < maxI; i++)
            {
                for (int j = 0; j < maxJ; j++)
                {
                    this.map[i, j] = "-";
                }
            }
        }

        public void PrintMap(Map map)
        {
            for (int i = 0; i < maxI; i++)
            {
                for (int j = 0; j < maxJ; j++)
                {
                    Console.Write(map.map[i,j]);
                }
                Console.WriteLine();
            }
        }

        public bool CheckIfLost ()
        {
            int countX = 0;
            for (int i = 0; i < 10; i++) {
                for (int j = 0;j < 10; j++)
                {
                    if (map[i,j] == "X")
                    {
                        countX ++;
                    }
                }
            }
            if (countX == 9)
            {
                return true;
            } else 
            { 
                return false;
            }
            
        }

        public void ChangeOnMap (string str, int x, int y)
        {
            map[x, y] = str;
        }

        public void WhatHappens(int x, int y)
        {
            if (map[x,y] == "0")
            {
                Console.WriteLine("Damaged or Destroyed!!!");
                map[x, y] = "X";
            } else if (map[x,y] == "?" || map[x,y] == "X")
            {
                Console.WriteLine("Already used coordinates");
            } else if (map[x,y] == "-")
            {
                Console.WriteLine("Missed");
                map[x,y] = "?";
            }
        }

        public void PlaceOneCostShip (int x, int y)
        {
                map[x, y] = "0";
        }

        public bool CheckIfZero (int x, int y)
        {
            if (map[x,y] == "0")
            {
                return false;
            } else
            {
                return true;
            }
        }

        public void PlaceTwoCostShip (int x, int y, int x1, int y1)
        {
            map[x,y] = "0";
            map[x1,y1] = "0";
        }

        public void PlaceThreeCostShip(int x, int y, int x1, int y1, int x2, int y2)
        {
            map[x,y] = "0";
            map[x1,y1] = "0";
            map[x2,y2] = "0";
        }

        public bool CheckIfInOrderTwoCost (int x, int y, int x1, int y1)
        {
            if (((x == x1 + 1) && (y == y1)) || ((x == x1 - 1) && (y == y1)) || ((x == x1) && (y == y1 - 1)) || ((x == x1) && (y == y1 + 1)))
            {
                return true;
            } else
            {
                return false;
            }
        }

        private const int maxI = 10;
        private const int maxJ = 10;
        private string[,] map = new string[10, 10];
    }
}
