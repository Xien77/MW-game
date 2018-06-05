using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MW_project
{
    class Tile
    {

        public int heightLevel { get; private set; }
        public int Hp = 0;
        public int FreeSpot;

        public static int Width = 50;
        public static int Height = 50;


        public void IncreaseHeightLevel();
        {
            if (Hp<-100) 
                {
                    heightLevel +1

                }
        }
    }

}
