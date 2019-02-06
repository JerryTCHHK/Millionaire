using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using Millionaire.Class;
using Millionaire.UI;
using Millionaire.Enum;
using System.Configuration;
using MetroFramework;

namespace Millionaire
{
    public partial class mainForm : MetroForm
    {
        //Initialize Logger 
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        //Front End Classes 

        private HomeUI homeUI = null;

        private GameUI gameUI = null ;

        private ResultUI resultUI = null ;


        protected override CreateParams CreateParams
        {
            get
            {
                var cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;    // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }


        public mainForm()
        {
            InitializeComponent();

            InitializeFrontEndUI();
            
        }

        private void InitializeFrontEndUI()
        {
            try
            {
                //Create Home UI
                log.Info("Home UI is set ");
                homeUI = new HomeUI(this);
                this.Controls.Add(homeUI);
                homeUI.setVisible();

                //Create Game UI 
                log.Info("Game UI is set ");
                gameUI = new GameUI(this);
                this.Controls.Add(gameUI);


                //Create Result UI 
                log.Info("Result UI is set");
                resultUI = new ResultUI(this);
                this.Controls.Add(resultUI);

            } catch ( Exception ex)
            {
                MetroMessageBox.Show(this, String.Format("Error : {0}", ex.Message), "", MessageBoxButtons.OK, MessageBoxIcon.Error, 150);

                log.Info(String.Format("Error : {0}", ex.Message));

            }

            
        }

        public void startGame()
        {

            log.Info("Game Start");
            log.Info(String.Format("Numeber of player : {0}", homeUI.getNumberOfPlayer()));
            log.Info(String.Format("Question Set : {0}", homeUI.getQuestionSet().getName()));
            log.Info(String.Format("Number of Audience : {0}", homeUI.getNumberOfAudience()));
            //Get All the Parameters From Home UI 

            gameUI.setGame(homeUI.getNumberOfPlayer(),
                             homeUI.getQuestionSet(),
                             homeUI.getNumberOfAudience());

            //Set Game UI To Visible 
            gameUI.setVisible();

            gameUI.setUI();


           
        }

        public void gameEnd()
        {
            log.Info("Game Ended.");

            resultUI.setUI(gameUI.getPlayerList(), gameUI.getPriceLadder());

            //Set Result UI to Visible 
            resultUI.setVisible();


        }

        public void backHome()
        {
            //Remove UI 
            this.Controls.Remove(homeUI);
            this.Controls.Remove(gameUI);
            this.Controls.Remove(resultUI);

            //Re-initialise 
            this.InitializeFrontEndUI();


        }

  

        
    }
}
