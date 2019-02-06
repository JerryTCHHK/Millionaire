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
using Millionaire.Enum;


namespace Millionaire.Forms
{
    public partial class PhoneCallForm : MetroForm
    {
        private int correctAnswerIndex;

        private int totalNumberOfAnswers;

        private int questionLevel;

        private KnowledgeLevel selectedKnowledgeLevel;

        private List<string> answerIndicatorList = new List<string>() { "A", "B", "C", "D" };

        private Boolean usedPhoneCall = false;

        public PhoneCallForm(int correctAnswerIndex, int totalNumberOfAnswers, int questionLevel)
        {
            InitializeComponent();

            this.correctAnswerIndex = correctAnswerIndex;

            this.totalNumberOfAnswers = totalNumberOfAnswers;

            this.questionLevel = questionLevel;

              
        }

        private void friendButton_Click(object sender, EventArgs e)
        {
            callLabel.Text = "Call your friend ?";

            this.selectedKnowledgeLevel = KnowledgeLevel.LOW;

            this.callButton.Enabled = true;
            
        }

        private void teacherButton_Click(object sender, EventArgs e)
        {
            callLabel.Text = "Call your teacher ?";

            this.selectedKnowledgeLevel = KnowledgeLevel.MEDIUM;

            this.callButton.Enabled = true;

        }

        private void jerryButton_Click(object sender, EventArgs e)
        {
            callLabel.Text = "Call Jerry ?";

            this.selectedKnowledgeLevel = KnowledgeLevel.HIGH;

            this.callButton.Enabled = true;

        }

        private void callButton_Click(object sender, EventArgs e)
        {
            //Disable All Buttons
            this.friendButton.Enabled = false;
            this.teacherButton.Enabled = false;
            this.jerryButton.Enabled = false;
            this.callButton.Enabled = false;


            //Change Text 
            callLabel.Text = "Calling....";

            callingTimer.Start();

            
            

            
        }

        private void callingTimer_Tick(object sender, EventArgs e)
        {
            
            int answerIndex = PhoneCall.getPhoneCallResult(this.correctAnswerIndex,
                                                           this.totalNumberOfAnswers,
                                                           this.questionLevel,
                                                           this.selectedKnowledgeLevel);


            callLabel.Text = String.Format("Answer : {0} ", answerIndicatorList[answerIndex]);


            this.usedPhoneCall = true; 

            callingTimer.Stop();
        }

        private void PhoneCallForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (usedPhoneCall)
            {
                this.DialogResult = DialogResult.Yes; 

            } else
            {
                this.DialogResult = DialogResult.No;

            }
        }
    }
}
