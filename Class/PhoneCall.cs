using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Millionaire.Enum;

namespace Millionaire.Class
{
    class PhoneCall
    {
        public static int getPhoneCallResult(int correctAnswerIndex, int totalNumberOfAnswers, int questionLevel, KnowledgeLevel knowledgeLevel)
        {
            Random random = new Random();

            int phoneResult = 0;

            int minIndex = 0; 

            double correctRate = 0.0; 

            if ( questionLevel <= 5)
            {
                correctRate = 1.0;

            } else if ( questionLevel <= 10 )
            {
                switch (knowledgeLevel)
                {
                    case KnowledgeLevel.LOW:

                        correctRate = 0.55; 

                        break;

                    case KnowledgeLevel.MEDIUM:

                        correctRate = 0.75; 

                        break;

                    case KnowledgeLevel.HIGH:

                        correctRate = 0.95;

                        break;



                }

            } else 
            {
                switch (knowledgeLevel)
                {
                    case KnowledgeLevel.LOW:

                        correctRate = 0.25;

                        break;

                    case KnowledgeLevel.MEDIUM:

                        correctRate = 0.55;

                        break;

                    case KnowledgeLevel.HIGH:

                        correctRate = 0.75;

                        break;



                }



            }

            if ( random.NextDouble() <= correctRate)
            {
                //Answer Correctly
                phoneResult = correctAnswerIndex; 

            } else
            {
                phoneResult = random.Next(minIndex, totalNumberOfAnswers);

                while ( phoneResult == correctAnswerIndex)
                {
                    phoneResult = random.Next(minIndex, totalNumberOfAnswers);
                }


            }

            
            return phoneResult; 


        }
    }
}
