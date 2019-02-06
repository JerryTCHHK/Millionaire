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
using System.IO;
using System.Configuration;
using MetroFramework; 


namespace Millionaire.UI
{
    public partial class HomeUI : UserControl
    {

        private List<QuestionSet> allQuestionSets = null;

        private QuestionSet selectedQuestionSet = null;

        private int numberOfPlayer = 0 ;

        private int numberOfAudience = 0;

        private mainForm parentForm; 
        

        public HomeUI(mainForm parentForm)
        {
            InitializeComponent();

            loadQuestionSets();

            setUIComponentsValues();

            setInvisible();

            this.parentForm = parentForm; 

        }

        public QuestionSet getQuestionSet()
        {
            return  this.selectedQuestionSet; 

        }

        public int getNumberOfPlayer()
        {

            return this.numberOfPlayer; 
        }

        public int getNumberOfAudience()
        {

            return this.numberOfAudience;
        }


        private void setUIComponentsValues()
        {
            //Set Combo Boxes Default Values
            if (this.questionTypeComboBox.Items.Count > 0 && this.allQuestionSets.Count > 0 )
            {

                this.questionTypeComboBox.SelectedItem = this.questionTypeComboBox.Items[0];

                this.selectedQuestionSet = this.allQuestionSets[this.questionTypeComboBox.SelectedIndex]; 

            }

            if (this.numberOfPlayerComboBox.Items.Count > 0)
            {

                this.numberOfPlayerComboBox.SelectedItem = this.numberOfPlayerComboBox.Items[0];

                this.numberOfPlayer = int.Parse(this.numberOfPlayerComboBox.SelectedItem.ToString());

            }


            if (this.audienceSizeComboBox.Items.Count > 0)
            {

                this.audienceSizeComboBox.SelectedItem = this.audienceSizeComboBox.Items[0];

                this.numberOfAudience = int.Parse(this.audienceSizeComboBox.SelectedItem.ToString());

            }

            //Set Dock Styles
            this.Dock = DockStyle.Fill;


        }

        public void setInvisible()
        {
            this.Visible = false; 

        }


        public void setVisible()
        {

            this.Visible = true;

            this.parentForm.Text = "Who wants to become a Millionaire";

        }

        private void loadQuestionSets()
        {

            allQuestionSets = new List<QuestionSet>();

            string questionPath = Path.Combine(Environment.CurrentDirectory, 
                                               ConfigurationManager.AppSettings["QuestionSetFolder"]);

            IEnumerable<string> allQuestionFiles = Directory.GetFiles(questionPath).Where(name => name.ToUpper().EndsWith("QST"));

            foreach ( string fileFullName in allQuestionFiles)
            {

                allQuestionSets.Add(new QuestionSet(fileFullName));

            }

            //Populate Question Type Combo Box 

            foreach ( QuestionSet questionSet in allQuestionSets)
            {
                questionTypeComboBox.Items.Add(questionSet.getName());

            }



            
        }

        private void startGameButton_Click(object sender, EventArgs e)
        {

            if (selectedQuestionSet != null && numberOfPlayer != 0 && numberOfAudience != 0)
            {

                setInvisible();

                parentForm.startGame();

            }

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            DialogResult exitResult = MetroFramework.MetroMessageBox.Show(this,"Are you sure that you want to exit?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning,150);

            if ( exitResult == DialogResult.Yes)
            {

                Application.Exit();
            }

        }

        private void questionTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int questionSetIndex = this.questionTypeComboBox.SelectedIndex;

            this.selectedQuestionSet = allQuestionSets[questionSetIndex];

        }

        private void numberOfPlayerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.numberOfPlayer = int.Parse(this.numberOfPlayerComboBox.SelectedItem.ToString());

        }

        private void audienceSizeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.numberOfAudience = int.Parse(this.audienceSizeComboBox.SelectedItem.ToString());
        }
    }
}
