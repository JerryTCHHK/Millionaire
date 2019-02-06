using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Millionaire.Class
{
    class fiftyFifty
    {

        public static List<int> get5050Result(int correctAnswerIndex, int totalNumberOfAnswers)
        {
            List<int> removalList = new List<int>();

            Random random = new Random();

            int minIndex = 0;

            int removalListLength = 0;

            if (totalNumberOfAnswers % 2 == 0)
            {

                removalListLength = totalNumberOfAnswers / 2; 


            } else
            {

                removalListLength = ( totalNumberOfAnswers + 1 ) / 2;

            }

            for (int count = 0; count < removalListLength; count++)
            {
                int index = random.Next(minIndex, totalNumberOfAnswers);

                while (index == correctAnswerIndex || removalList.Contains(index))
                {

                    index = random.Next(minIndex, totalNumberOfAnswers);

                }

                removalList.Add(index);

            }


            return removalList;
        }



    }
}
