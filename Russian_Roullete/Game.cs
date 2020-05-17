using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Russian_Roullete
{
    class Game
    {
        public int loder;
        public int totalchance = 2;
        public int shoter = 6;
        public int bulleteload = 1;


        public int spinner(int i)
        {
            if (i == 6)
            {
                i = 1;

            }
            else
            {
                i++;
            }

            return i;
        }
       
        public int Awayshoot()
        {
            int k=0;
            if (shoter > 0 && loder == 1 && totalchance == 2)

            {
                k = 10;


            }
            if (shoter > 0 && loder == 1 && totalchance == 1)
            {
                k = 5;
            }
            if (shoter > 0 && loder != 1)
            {

                k = 3;

                shoter = shoter - 1;
                totalchance = totalchance - 1;
                loder = spinner(loder);
                bulleteload++;

            }
            if (shoter == 0)
            {

                k = 0;


            }
            if (totalchance == 0)
            {

                k = 1;


            }
            return k;
        }
        public int Shooter()
        {
            int points = 0;
            if (shoter > 0 && bulleteload == loder)
            {
                points = 1;
            }
            else if (shoter > 0 && loder != bulleteload)
            {
                points = 2;
                shoter = shoter - 1;
                loder = spinner(loder);
            }
            return points;
        }
    }
}
