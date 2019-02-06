using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Millionaire.Enum;

namespace Millionaire.Class
{
    public partial class QuestionSet
    {
        private string questionFileFullName;

        private string name;

        private string description;

        private int totalNumberOfQuestions = 0;

        private Dictionary<int, List<Question>> allQuestions; 

        public string getName()
        {

            return name; 
        }


        public string getDescription()
        {
            return description;

        }


        public QuestionSet(string questionFileFullName) {
            try
            {
                this.questionFileFullName = questionFileFullName;

                this.allQuestions = new Dictionary<int, List<Question>>();

                StreamReader qFileReader = new StreamReader(questionFileFullName);

                while ( qFileReader.EndOfStream == false)
                {
                    string extractedLine = qFileReader.ReadLine();

                    if ( extractedLine.StartsWith("Name=",StringComparison.OrdinalIgnoreCase)) {

                        this.name = getStringValue("Name=", extractedLine);

                    } else if (extractedLine.StartsWith("Description=", StringComparison.OrdinalIgnoreCase)){

                        this.description = getStringValue("Description=", extractedLine);

                    } else if (extractedLine.StartsWith("Question=", StringComparison.OrdinalIgnoreCase)) {

                        string questionInfoString = getStringValue("Question=", extractedLine);

                        addQuestion(questionInfoString);
                     
                    }


                }

                qFileReader.Close(); 

            } catch ( Exception e)
            {

                throw new Exception(String.Format("Error : {0} ", e.Message.ToString()));

            }
        }

        private string getStringValue(string key , string line) {

            string value = line.Replace(key, "").Trim(); 

            if ( value == "")
            {

                throw new Exception(String.Format("Error : {0} is Empty", value));
            }

            return value;

            
            
        }

        private void addQuestion(string line)
        {
            string[] questionInfo = line.Split('|');

            if ( questionInfo.Length == 4)
            {
                //Get Question Level 
                int questionLevel;
                string question;
                string correctAnswer;
                string[] incorrectAnswers;

                if ( !int.TryParse(questionInfo[0], out questionLevel)) {

                    throw new Exception(String.Format("Error: Question Level must be an integer, not {0}, in {1}", questionInfo[0], questionFileFullName));
                }

                //Get Question 
                if ( questionInfo[1].Trim() != "")
                {

                    question = questionInfo[1].Trim();

                } else {

                    throw new Exception(String.Format("Error: Question field cannot be empty in {0} ", questionFileFullName));

                }

                //Get Question Correct Answer

                if ( questionInfo[2].Trim() != "")
                {
                    correctAnswer = questionInfo[2].Trim(); 

                } else
                {
                    throw new Exception(String.Format("Error : Correct Answer field cannot be empty in {0} ", questionFileFullName));

                }
     
                //Get Question Wrong Answers 

                if ( questionInfo[3].Trim().Split(',').Length >= 3) {

                    incorrectAnswers = questionInfo[3].Trim().Split(',');

                } else {

                    throw new Exception(String.Format("Error : There should be at least 3 incorrect answers in {0}", questionFileFullName));

                }

                Question newQuestion = new Question(question, correctAnswer, incorrectAnswers);

                //Add into AllQuestions
                if (this.allQuestions.ContainsKey(questionLevel)) {

                    List<Question> questionList = this.allQuestions[questionLevel];

                    questionList.Add(newQuestion);

                    this.allQuestions[questionLevel] = questionList; 

                } else {

                    List<Question> newQuestionList = new List<Question>();

                    newQuestionList.Add(newQuestion);

                    this.allQuestions.Add(questionLevel, newQuestionList);


                }

                this.totalNumberOfQuestions = this.totalNumberOfQuestions + 1;



            } else
            {

                throw new Exception(String.Format("Error: {0} has an invalid question {1} ", questionFileFullName, line));

            }



        }

        public Question GetQuestion(int questionLevel)
        {
            List<Question> questionsInLevel = allQuestions[questionLevel];

            //Check Questions In Level Status 
            bool questionAvailable = false; 

            for ( int i = 0; i < questionsInLevel.Count; i ++)
            {
                if ( questionsInLevel[i].status == QuestionStatus.AVAILABLE)
                {
                    questionAvailable = true; 

                    break;

                }


            }

            if ( questionAvailable == false)
            {

                for ( int i = 0; i < questionsInLevel.Count; i++)
                {

                    questionsInLevel[i].status = QuestionStatus.AVAILABLE;


                }

            }

            //Generate Random Question

            Random random = new Random();

            int randomQuestionIndex = random.Next(0, questionsInLevel.Count);

            Question selectedQuestion = questionsInLevel[randomQuestionIndex];

            while ( selectedQuestion.status == QuestionStatus.USED)
            {

                randomQuestionIndex = random.Next(0, questionsInLevel.Count);

                selectedQuestion = questionsInLevel[randomQuestionIndex];


            }

            return selectedQuestion;

        }
    }
}
