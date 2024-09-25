using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace project
{
    public class Player
    {
        private Map _map;
        public Player()
        {
            _map = new Map();
        }

        public void WhatHappens (int x, int y)
        {
            _map.WhatHappens(x, y);
            _map.PrintMap(_map);
        }

        public void PrintMap ()
        {
            _map.PrintMap(_map);
        }

        public bool CheckIfLost()
        {
            if (_map.CheckIfLost())
            {
                return true;
            } else { return false; }
        }

        public void ChangeOnMap (string str, int x, int y)
        {
            _map.ChangeOnMap(str, x, y);
        }

        public void PlaceOneCostShip (int x, int y)
        {
           _map.PlaceOneCostShip(x, y);
        }

        public bool CheckIfZero(int x, int y)
        {
            if (_map.CheckIfZero(x,y))
            {
                return false;
            }
            else
            {
                return true;
            }
        }


        public void PlaceTwoCostShip (int x, int y, int x1, int y1) 
        {
            _map.PlaceTwoCostShip(x, y, x1, y1);
        }

        public bool CheckIfInOrderTwoCost (int x, int y, int x1, int y1)
        {
            if (_map.CheckIfInOrderTwoCost(x, y, x1, y1))
            {
                return true;
            } else
            {
                return false;
            }
        }

        public void PlaceThreeCostShip(int x, int y, int x1, int y1, int x2, int y2)
        {
            _map.PlaceThreeCostShip(x, y, x1, y1, x2, y2);
        }
    }
}
