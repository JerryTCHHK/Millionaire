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

namespace Millionaire.Forms
{
    public partial class AudienceResultForm : MetroForm
    {

        private List<string> answerLabelList = new List<string>() { "A", "B", "C", "D" };

        public AudienceResultForm(int[] answerRateList)
        {
            InitializeComponent();

            //Add Values into Bar Cart 
            for ( int index = 0; index < answerLabelList.Count; index++)
            {
                resultChart.Series[0].Points.AddXY(answerLabelList[index], answerRateList[index]);

            }



        }

      
    }
}
