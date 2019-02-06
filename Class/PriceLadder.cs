using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Millionaire.Class
{
    public class PriceLadder
    {
        private int ladderLevel = 15;

        public Dictionary<int, int> ladderDict;

        public List<int> safeLevelList; 

        public int getLadderTotalLevel()
        {
            return ladderLevel;

        }


        public PriceLadder()
        {

            ladderDict = new Dictionary<int, int>();

            safeLevelList = new List<int>() { 5 , 10 }; 


            for ( int index = 0; index < ladderLevel; index++)
            {
                switch (index)
                {
                    case 0:

                        ladderDict.Add(index, 100);

                        break;

                    case 1:

                        ladderDict.Add(index, 200);

                        break;

                    case 2:

                        ladderDict.Add(index, 300);

                        break;

                    case 3:

                        ladderDict.Add(index, 500);

                        break;

                    case 4:

                        ladderDict.Add(index, 1000);

                        break;

                    case 5:

                        ladderDict.Add(index, 2000);

                        break;

                    case 6:

                        ladderDict.Add(index, 4000);

                        break;

                    case 7:

                        ladderDict.Add(index, 8000);

                        break;

                    case 8:

                        ladderDict.Add(index, 16000);

                        break;

                    case 9:

                        ladderDict.Add(index, 32000);

                        break;

                    case 10:

                        ladderDict.Add(index, 64000);

                        break;

                    case 11:

                        ladderDict.Add(index, 125000);

                        break;

                    case 12:

                        ladderDict.Add(index, 250000);

                        break;

                    case 13:

                        ladderDict.Add(index, 500000);

                        break;

                    case 14:

                        ladderDict.Add(index, 1000000);

                        break;
                    




                }


            }





        }




    };
}
