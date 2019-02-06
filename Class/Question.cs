using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Millionaire.Enum;

namespace Millionaire.Class
{
    public partial class Question {

        public string question;

        public string correctAnswer;

        public string[] incorrectAnswers;

        public QuestionStatus status; 

        public Question(string question, string correctAnswer, string[] incorrectAnswers)
        {
            this.question = question;

            this.correctAnswer = correctAnswer;

            this.incorrectAnswers = incorrectAnswers;

            this.status = QuestionStatus.AVAILABLE;

        }


    }
}
