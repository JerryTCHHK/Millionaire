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
using Millionaire.Enum;
using MetroFramework.Controls;
using MetroFramework;

namespace Millionaire.UI
{
    public partial class ResultUI : UserControl
    {

        private mainForm parentForm;

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ResultUI( mainForm parentForm)
        {
            InitializeComponent();

            setUIComponentValues();

            this.parentForm = parentForm;

            setInvisible();
        }


        public void setUIComponentValues()
        {

            this.Dock = DockStyle.Fill;

        }


        public void setUI(List<Player> playerList, PriceLadder ladder )
        {
            for ( int index = 0; index < playerList.Count; index++)
            {
                //Get Status
                PlayerStatus status = playerList[index].status;

                //Get Price Level 
                int priceLevel = playerList[index].takeOutPriceLevel;


                //Get Price 
                int price = 0;

                if (status == PlayerStatus.COMPLETED)
                {
                    if (priceLevel != 0)
                    {

                        price = ladder.ladderDict[playerList[index].takeOutPriceLevel - 1];

                    }
                } else if (status == PlayerStatus.OUT)
                {
                    if (playerList[index].safePriceLevel != 0)
                    {
                        price = ladder.ladderDict[playerList[index].safePriceLevel - 1];

                    }

                }
                //Get 50/50 Status

                string used5050 = "N";

                if ( playerList[index].used5050)
                {

                    used5050 = "Y";

                } else
                {
                    used5050 = "N";

                }

                //Get Phone Call Status 

                string usedPhoneCall = "N"; 

                if (playerList[index].usedPhoneCall)
                {

                    usedPhoneCall = "Y"; 
                } else
                {

                    usedPhoneCall = "N";
                }

                //Get Audience Stats 

                string usedAskAudience = "N"; 

                if (playerList[index].usedAskAudience)
                {
                    usedAskAudience = "Y";

                } else
                {
                    usedAskAudience = "N";

                }


                switch (index)
                {
                    case 0:

                        player1StatusLabel.Text = status.ToString();
                        player1LevelLabel.Text = priceLevel.ToString();
                        player1PriceLabel.Text = price.ToString();
                        player15050StatusLabel.Text = used5050;
                        player1PhoneCallStatusLabel.Text = usedPhoneCall;
                        player1AskAudienceStatusLabel.Text = usedAskAudience;


                        break;

                    case 1:

                        player2StatusLabel.Text = status.ToString();
                        player2LevelLabel.Text = priceLevel.ToString();
                        player2PriceLabel.Text = price.ToString();
                        player25050StatusLabel.Text = used5050;
                        player2PhoneCallStatusLabel.Text = usedPhoneCall;
                        player2AskAudienceStatusLabel.Text = usedAskAudience;

                        break;

                    case 2:

                        player3StatusLabel.Text = status.ToString();
                        player3LevelLabel.Text = priceLevel.ToString();
                        player3PriceLabel.Text = price.ToString();
                        player35050StatusLabel.Text = used5050;
                        player3PhoneCallStatusLabel.Text = usedPhoneCall;
                        player3AskAudienceStatusLabel.Text = usedAskAudience;


                        break;

                    case 3:

                        player4StatusLabel.Text = status.ToString();
                        player4LevelLabel.Text = priceLevel.ToString();
                        player4PriceLabel.Text = price.ToString();
                        player45050StatusLabel.Text = used5050;
                        player4PhoneCallStatusLabel.Text = usedPhoneCall;
                        player4AskAudienceStatusLabel.Text = usedAskAudience;

                        break;
                     





                }




            }



        }


        public void setVisible()
        {
            this.Visible = true; 

        }

        public void setInvisible()
        {
            this.Visible = false;

        }

        private void BackToHomeButton_Click(object sender, EventArgs e)
        {
            this.setInvisible();

            parentForm.backHome();

        }

        private void exportToPDFButton_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> player1Result = new List<string>() { player1StatusLabel.Text, player1LevelLabel.Text, player1PriceLabel.Text, player15050StatusLabel.Text, player1PhoneCallStatusLabel.Text, player1AskAudienceStatusLabel.Text };

                List<string> player2Result = new List<string>() { player2StatusLabel.Text, player2LevelLabel.Text, player2PriceLabel.Text, player25050StatusLabel.Text, player2PhoneCallStatusLabel.Text, player2AskAudienceStatusLabel.Text };

                List<string> player3Result = new List<string>() { player3StatusLabel.Text, player3LevelLabel.Text, player3PriceLabel.Text, player35050StatusLabel.Text, player3PhoneCallStatusLabel.Text, player3AskAudienceStatusLabel.Text };

                List<string> player4Result = new List<string>() { player4StatusLabel.Text, player4LevelLabel.Text, player4PriceLabel.Text, player45050StatusLabel.Text, player4PhoneCallStatusLabel.Text, player4AskAudienceStatusLabel.Text };

                SaveFileDialog openFileDialog = new SaveFileDialog();

                openFileDialog.Title = "Where to save your PDF?";
                openFileDialog.Filter = "*.pdf|";
                openFileDialog.FileName = "Game-Report.pdf";
                openFileDialog.DefaultExt = "pdf";
                openFileDialog.ValidateNames = true;
                openFileDialog.RestoreDirectory = true;
                openFileDialog.ShowDialog();

                PDFHandler pHandler = new PDFHandler(openFileDialog.FileName);

                pHandler.createPDF(player1Result, player2Result, player3Result, player4Result);

                MetroMessageBox.Show(this, String.Format("{0} is created", openFileDialog.FileName), "", MessageBoxButtons.OK, MessageBoxIcon.Information, 150);

                log.Info(String.Format("{0} is created", openFileDialog.FileName));

            }
            catch (Exception ex)
            {

                MetroMessageBox.Show(this,String.Format("Error: {0}", ex.Message), "", MessageBoxButtons.OK, MessageBoxIcon.Error, 150);

                log.Info(String.Format("Error: {0}", ex.Message));
            }

        }
    }
}
