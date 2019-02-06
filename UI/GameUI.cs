using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Millionaire.Class;
using MetroFramework.Controls;
using MetroFramework;
using Millionaire.Enum;
using Millionaire.Forms;

namespace Millionaire.UI
{
    public partial class GameUI : UserControl
    {

        private mainForm parentForm;

        private Question question;

        private MillionareGame currentGame;

        private int correctAnswerIndex;

        private List<Button> answerButtonsList;

        private int audienceSize;

        public GameUI(mainForm parentForm)
        {
            InitializeComponent();

            setUIComponentsValues();

            setInvisible();

            this.parentForm = parentForm;
        }

        private void setUIComponentsValues()
        {

            this.Dock = DockStyle.Fill;

        }

        public List<Player> getPlayerList()
        {
            return currentGame.getListOfPlayer();

        }

        public PriceLadder getPriceLadder()
        {

            return currentGame.getPriceLadder();
        }


     
        public void setVisible()
        {

            this.Visible = true;

        }

        public void setInvisible()
        {

            this.Visible = false;
        }

        public void setGame(int numberOfPlayer, QuestionSet questionSet, int numberOfAudience)
        {

            this.currentGame = new MillionareGame(numberOfPlayer, questionSet, numberOfAudience);

            this.audienceSize = numberOfAudience; 
        }

        public void setUI()
        {
            //Button Enabler 
            buttonEnabler(true);

            //Next Button
            this.nextButton.Enabled = false; 

            //Get All the Required Information 
            Player currentPlayer = currentGame.getCurrentPlayer();


            this.question = currentGame.getQuestion();

            int currentPlayerNumber = currentGame.getCurrentPlayerIndex() + 1;

            //Set Current Player Label Text 
            currentPlayerLabel.Text = String.Format("Current Player : Player {0}", currentPlayerNumber);

            //Set Question 
            questionLabel.Text = String.Format("Question {0} : {1}", currentPlayer.currentLadderLevel
                                                                   , question.question);

            //Set Correct Answers 
            Random rSeed = new Random(); 

            Dictionary<MetroLabel, Boolean> answerLabelDict = new Dictionary<MetroLabel, bool>();

            answerLabelDict.Add(answerALabel, false);
            answerLabelDict.Add(answerBLabel, false);
            answerLabelDict.Add(answerCLabel, false);
            answerLabelDict.Add(answerDLabel, false);

            int correctAnswerIndex = rSeed.Next(answerLabelDict.Count);

            MetroLabel correctAnswerLabel = answerLabelDict.Keys.ToList<MetroLabel>()[correctAnswerIndex];

            correctAnswerLabel.Text = question.correctAnswer;

            answerLabelDict[correctAnswerLabel] = true;

            //Set Incorrect Answers
            foreach ( string incorrectAnswer in question.incorrectAnswers)
            {
                int incorrectAnswerIndex = rSeed.Next(answerLabelDict.Count);

                MetroLabel incorrectAnswerLabel = answerLabelDict.Keys.ToList<MetroLabel>()[incorrectAnswerIndex];

                while ( answerLabelDict[incorrectAnswerLabel] == true)
                {
                    incorrectAnswerIndex = rSeed.Next(answerLabelDict.Count);

                    incorrectAnswerLabel = answerLabelDict.Keys.ToList<MetroLabel>()[incorrectAnswerIndex];

                }

                incorrectAnswerLabel.Text = incorrectAnswer;

                answerLabelDict[incorrectAnswerLabel] = true;

            }

            //Save correctAnswerIndex  and total Number Of Questions 

            this.correctAnswerIndex = correctAnswerIndex;

            this.answerButtonsList = new List<Button>() { aButton, bButton, cButton, dButton }; 

            //Set Help Buttons
            if (currentPlayer.used5050)
            {
                fiftyfiftyButton.Enabled = false;

            } else
            {
                fiftyfiftyButton.Enabled = true; 

            }

            if (currentPlayer.usedAskAudience)
            {
                askAudienceButton.Enabled = false;

            } else
            {
                askAudienceButton.Enabled = true;

            }

            if (currentPlayer.usedPhoneCall)
            {
                phoneCallButton.Enabled = false;

            } else
            {
                phoneCallButton.Enabled = true;

            }

            //Set Ladder 
            setLadder();

            

        }


        private void resetLadder(List<MetroLabel> levelLabel, List<MetroLabel> priceLabel, PriceLadder priceLadder)
        {
            if ( levelLabel.Count == priceLabel.Count)
            {
               for ( int index = 0; index < levelLabel.Count; index++)
                {

                    levelLabel[index].FontSize = MetroFramework.MetroLabelSize.Medium;
                    levelLabel[index].FontWeight = MetroFramework.MetroLabelWeight.Light;

                    //Check if it is safe Level 
                    int currentPriceLevel = index + 1; 

                    if (priceLadder.safeLevelList.Contains(currentPriceLevel) || currentPriceLevel ==levelLabel.Count)
                    {
                        priceLabel[index].FontSize = MetroFramework.MetroLabelSize.Medium;
                        priceLabel[index].FontWeight = MetroFramework.MetroLabelWeight.Regular;

                    } else
                    {
                        priceLabel[index].FontSize = MetroFramework.MetroLabelSize.Medium;
                        priceLabel[index].FontWeight = MetroFramework.MetroLabelWeight.Light;


                    }

                    


                }



            } 


        }

        private DialogResult getUserVerification()
        {

            return MetroMessageBox.Show(this, "Final Answer?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information, 150);


        }

        private void processAnswer(string answer)
        {
            int priceLevel = currentGame.getPriceLadder().ladderDict[currentGame.getCurrentPlayer().currentLadderLevel - 1];

            int safePrice = 0;

            if (currentGame.getCurrentPlayer().safePriceLevel != 0) {

                safePrice = currentGame.getPriceLadder().ladderDict[currentGame.getCurrentPlayer().safePriceLevel - 1];

            }

            if ( answer == this.question.correctAnswer)
            {

                MetroMessageBox.Show(this, String.Format("You are correct. You get ${0}.", priceLevel), "", MessageBoxButtons.OK, MessageBoxIcon.Question, 150);

                //Update Player Info
                if (currentGame.getPriceLadder().safeLevelList.Contains(currentGame.getCurrentPlayer().currentLadderLevel)){

                    currentGame.getCurrentPlayer().safePriceLevel = currentGame.getCurrentPlayer().currentLadderLevel;

                }

                if ( currentGame.getCurrentPlayer().currentLadderLevel == currentGame.getPriceLadder().getLadderTotalLevel())
                {
                    currentGame.getCurrentPlayer().status = PlayerStatus.COMPLETED;

                }


                currentGame.getCurrentPlayer().currentLadderLevel += 1;

                currentGame.getCurrentPlayer().takeOutPriceLevel += 1;
                



            } else
            {
                MetroMessageBox.Show(this, String.Format("Sorry!You are not correct. Your price will be ${0}.", safePrice), "", MessageBoxButtons.OK, MessageBoxIcon.Stop, 150);

                currentGame.getCurrentPlayer().status = PlayerStatus.OUT;

            }

            //Update Ladder 
            setLadder();

            //Disable All Buttons Except Next Button
            buttonEnabler(false);

            //Enable Next Button
            this.nextButton.Enabled = true;


        }

        private void aButton_Click(object sender, EventArgs e)
        {
            if (getUserVerification() == DialogResult.Yes)
            {
                processAnswer(answerALabel.Text);

            }
        }

        private void bButton_Click(object sender, EventArgs e)
        {
            if (getUserVerification() == DialogResult.Yes)
            {
                processAnswer(answerBLabel.Text);

            }

        }

        private void cButton_Click(object sender, EventArgs e)
        {
            if (getUserVerification() == DialogResult.Yes)
            {
                processAnswer(answerCLabel.Text);

            }


        }

        private void dButton_Click(object sender, EventArgs e)
        {
            if (getUserVerification() == DialogResult.Yes)
            {
                processAnswer(answerDLabel.Text);

            }
        }

        private void setLadder()
        {
            //Set Ladder 
            List<MetroLabel> levelLabel = new List<MetroLabel>() { oneLevelLabel, twoLevelLabel, threeLevelLabel,
                                                                   fourLevelLabel, fiveLevelLabel, sixLevelLabel,
                                                                   sevenLevelLabel, eightLevelLabel, nineLevelLabel,
                                                                   tenLevelLabel, elevenLevelLabel, twelveLevelLabel,
                                                                   thirteenLevelLabel, fourthteenLevelLabel, fifthteenLevelLabel};


            List<MetroLabel> priceLabel = new List<MetroLabel>() { oneHundredLabel, twoHundredLabel, threeHundredLabel,
                                                                   fiveHundredLabel, oneThousandLabel, twoThousandLabel,
                                                                   fourThousandLabel, eightThousandLabel, sixteenThousandLabel,
                                                                   thirtyTwoThousandLabel, sixtyFourThousandLabel, oneHundredtwentyFiveThousandLabel,
                                                                   twoHundredfiftyThousandLabel, fiveHundredThousandLabel, oneMillionLabel};


            resetLadder(levelLabel, priceLabel, currentGame.getPriceLadder());

            int currentLadderIndex = currentGame.getCurrentPlayer().currentLadderLevel - 1;

            for (int index = 0; index < currentLadderIndex; index++)
            {

                levelLabel[index].FontWeight = MetroFramework.MetroLabelWeight.Bold;

                priceLabel[index].FontWeight = MetroFramework.MetroLabelWeight.Bold;


            }



        }

        private void buttonEnabler(Boolean enable)
        {
            aButton.Enabled = enable;

            bButton.Enabled = enable;

            cButton.Enabled = enable;

            dButton.Enabled = enable;

            fiftyfiftyButton.Enabled = enable;

            phoneCallButton.Enabled = enable;

            askAudienceButton.Enabled = enable;

            checkOutButton.Enabled = enable; 


        }

        private void fiftyfiftyButton_Click(object sender, EventArgs e)
        {
            DialogResult use5050 = MetroMessageBox.Show(this, "Do you really want to use 50/50?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information, 150);

            if (use5050 == DialogResult.Yes)
            {

                List<int> removalList = fiftyFifty.get5050Result(this.correctAnswerIndex, this.answerButtonsList.Count);

                for (int index = 0; index < removalList.Count; index++)
                {
                    answerButtonsList[removalList[index]].Enabled = false;

                }

                currentGame.getCurrentPlayer().used5050 = true;

                fiftyfiftyButton.Enabled = false;

            }
        }

        private void phoneCallButton_Click(object sender, EventArgs e)
        {
            PhoneCallForm form = new PhoneCallForm(this.correctAnswerIndex,
                                                   this.answerButtonsList.Count,
                                                   currentGame.getCurrentPlayer().currentLadderLevel);

            DialogResult usedPhoneCall = form.ShowDialog();

            if ( usedPhoneCall == DialogResult.Yes)
            {
                phoneCallButton.Enabled = false;

                currentGame.getCurrentPlayer().usedPhoneCall = true; 

            }

        }

        private void askAudienceButton_Click(object sender, EventArgs e)
        {
            DialogResult useAskAudience = MetroMessageBox.Show(this, "Do you really want to ask for help from the audience?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information, 150);

            if ( useAskAudience == DialogResult.Yes)
            {
                //Ask Audience 
                int[] audienceResult = AskAudience.getAudienceAnswer(this.correctAnswerIndex,
                                                                      this.answerButtonsList.Count,
                                                                      currentGame.getCurrentPlayer().currentLadderLevel,
                                                                      this.audienceSize);

                AudienceResultForm aRForm = new AudienceResultForm(audienceResult);

                aRForm.ShowDialog();

                askAudienceButton.Enabled = false;

                currentGame.getCurrentPlayer().usedAskAudience = true;

            }

        }

        private void checkOutButton_Click(object sender, EventArgs e)
        {
            int checkOutAmount = 0;

            if (currentGame.getCurrentPlayer().takeOutPriceLevel == 0)
            {
                checkOutAmount = 0;

            } else
            {

                checkOutAmount = currentGame.getPriceLadder().ladderDict[currentGame.getCurrentPlayer().takeOutPriceLevel - 1];
            }

            DialogResult result = MetroMessageBox.Show(this, String.Format("Do you really want to checkout. Your checkout amount : ${0} ", checkOutAmount), "", MessageBoxButtons.YesNo, MessageBoxIcon.Information, 150);

            if ( result == DialogResult.Yes)
            {
                MetroMessageBox.Show(this, String.Format("Congratulations. You won ${0}", checkOutAmount),"", MessageBoxButtons.OK,MessageBoxIcon.Question, 150);

                currentGame.getCurrentPlayer().status = PlayerStatus.COMPLETED;

                buttonEnabler(false);

                this.nextButton.Enabled = true; 

            }


        }

        private void nextButton_Click(object sender, EventArgs e)
        {

            Player player = currentGame.getValidNextPlayer(currentGame.getNumberOfPlayer());

            if ( player != null)
            {
                this.setUI();


            } else
            {
                MetroMessageBox.Show(this, "Game Ended!", "", MessageBoxButtons.OK, MessageBoxIcon.Information, 150);

                this.setInvisible();

                parentForm.gameEnd();


            }

        }
    }
}
