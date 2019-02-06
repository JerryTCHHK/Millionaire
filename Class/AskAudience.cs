using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Millionaire.Class
{
    class AskAudience
    {
        public static int[] getAudienceAnswer(int correctAnswerIndex, int totalNumberOfAnswers, int questionLevel, int audienceSize)
        {

            Random random = new Random();

            double correctRate = random.NextDouble(); 

            int[] answerRateList = new int[totalNumberOfAnswers];

            int minIndex = 0;

            //Get Correct Rate 
            if ( questionLevel <= 5 )
            {
                while ( correctRate < 0.9 )
                {

                    correctRate = random.NextDouble();          //Correct Rate must be greater than 0.9 

                }


            } else if ( questionLevel <= 10)
            {

                while ( correctRate < 0.6  || correctRate > 0.9 )
                {

                    correctRate = random.NextDouble();          //Correct Rate is within 0.6 and 0.9      
                }


            } else
            {
                while ( correctRate  > 0.6)
                {

                    correctRate = random.NextDouble();          //Correct Rate is below 0.6

                }


            }

            //Loop through Audience 
            for ( int audience = 0; audience < audienceSize; audience++)
            {
                double answer = random.NextDouble(); 

                if ( answer < correctRate )
                {
                    answerRateList[correctAnswerIndex] += 1;  

                } else
                {
                    int incorrectAnswerIndex = random.Next(minIndex, totalNumberOfAnswers); 

                    while ( incorrectAnswerIndex == correctAnswerIndex)
                    {

                        incorrectAnswerIndex = random.Next(minIndex, totalNumberOfAnswers);
                    }


                    answerRateList[incorrectAnswerIndex] += 1; 


                }

            }


            return answerRateList;

        }

    }
}
