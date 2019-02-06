using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Millionaire.Enum;

namespace Millionaire.Class
{
    public partial class MillionareGame
    {
        private int numberOfPlayer;

        private int currentPlayerIndex;

        private List<Player> playerList;

        private PriceLadder priceLadder;

        private QuestionSet questionSet;

        private Question currentQuestion;

        private int audienceSize; 

        //Description       : Constructor / Game Initializer
        //Pre-condition     : Number Of Player  and Question Set 
        //Post-condition    : Game will be initialized
        public MillionareGame(int numberOfPlayer, QuestionSet questionSet, int audienceSize)
        {
            //Create price Ladder

            priceLadder = new PriceLadder();

            //Create Players 

            playerList = new List<Player>();

            if ( numberOfPlayer > 0 ) {

                this.numberOfPlayer = numberOfPlayer; 

                for ( int index = 0; index < numberOfPlayer; index++ ) {

                    playerList.Add(new Player());

                }


            } else {

                throw new Exception("Number of Player cannot be 0 "); 

            }

            //Set the Game Question Type
            this.questionSet = questionSet;

            //Set current Player Index 

            this.currentPlayerIndex = 0;

            //Set Audience Size 

            this.audienceSize = audienceSize;

        }
     
        public int getCurrentPlayerIndex()
        {

            return this.currentPlayerIndex;

        }

        public PriceLadder getPriceLadder()
        {

            return this.priceLadder; 

        }


        public Player getCurrentPlayer()
        {

            return this.playerList[this.currentPlayerIndex];


        }

        public int getNumberOfPlayer()
        {

            return this.numberOfPlayer;
        }

        public List<Player> getListOfPlayer()
        {

            return this.playerList; 
        }


        public Player getValidNextPlayer(int numberOfPlayer)
        {

            numberOfPlayer = numberOfPlayer - 1; 

            this.currentPlayerIndex = currentPlayerIndex + 1; 

            if ( this.currentPlayerIndex == this.playerList.Count)
            {
                this.currentPlayerIndex = 0;

            }

            Player player = this.playerList[this.currentPlayerIndex];
   
            if ( player.status == PlayerStatus.IN)
            {
                return player;
            }

            if ( numberOfPlayer == 0)
            {

                return null;
            }

            return getValidNextPlayer(numberOfPlayer);

        }

        public Question getQuestion()
        {

            Question question = questionSet.GetQuestion(priceLadder.ladderDict[getCurrentPlayer().currentLadderLevel - 1 ]);

            this.currentQuestion = question;

            return question;

        }

        public Boolean isUserAnswerCorrect(string answer)
        {

            if ( answer == this.currentQuestion.correctAnswer) {
                
                return true; 
            }

            return false;

        }

        public void updatePlayerStatus(Boolean isAnswerCorrect)
        {

            Player player = this.getCurrentPlayer(); 

            if (isAnswerCorrect)
            {

                player.currentLadderLevel += 1;

                player.takeOutPriceLevel = player.currentLadderLevel - 1;

                if ( priceLadder.safeLevelList.Contains(player.takeOutPriceLevel))
                {

                    player.safePriceLevel = player.takeOutPriceLevel; 

                }

                if ( player.currentLadderLevel > priceLadder.getLadderTotalLevel())
                {

                    player.status = PlayerStatus.COMPLETED; 

                }
                
            } else
            {
                player.status = PlayerStatus.OUT;

            }


        }

        public List<int> trigger5050(int correctAnswerIndex, int totalNumberOfAnswers)
        {

            List<int> removalList = fiftyFifty.get5050Result(correctAnswerIndex, totalNumberOfAnswers);

            this.getCurrentPlayer().used5050 = true;

            return removalList;


        }

        public int triggerPhoneCall(int correctAnswerIndex, int totalNumberOfAnswers, KnowledgeLevel knowledgeLevel)
        {
            int questionLevel = this.getCurrentPlayer().currentLadderLevel;

            int phoneCallAnswer = PhoneCall.getPhoneCallResult(correctAnswerIndex, totalNumberOfAnswers, questionLevel, knowledgeLevel);
          
            this.getCurrentPlayer().usedPhoneCall = true; 

            return phoneCallAnswer;


        }

        public int[] triggerAskAudience(int correctAnswerIndex, int totalNumberOfAnswers)
        {

            int questionLevel = this.getCurrentPlayer().currentLadderLevel;

            int[] audienceAnswerList = AskAudience.getAudienceAnswer(correctAnswerIndex, totalNumberOfAnswers, questionLevel, this.audienceSize) ;
   
            this.getCurrentPlayer().usedAskAudience = true; 

            return audienceAnswerList;

        }
     




    }
}
