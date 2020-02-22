using System;
using System.Collections.Generic;
using System.Text;

namespace NavalBattle
{
    public enum ShipName { battleship, cruiser, destroyer, submarine };
    public class Ship
    {
        public ShipName name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public int ShipDeck
         {
            get
            {
                return ShipDeck;
            }

            set
            {
                ShipDeck = value;
            }
        }
        public Ship(ShipName name)
        {
            int shipLength = 0;
            switch (name)
            {
                case ShipName.submarine:
                    shipLength = 1;
                    break;
                case ShipName.destroyer:
                    shipLength = 2;
                    break;
                case ShipName.cruiser:
                    shipLength = 3;
                    break;
                case ShipName.battleship:
                    shipLength = 4;
                    break;
            }
            this.ShipDeck = shipLength;
            this.name = name;
        }

    }
}
