using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoMp123_S2019_Lesson9B
{
    public partial class CalculatorForm : Form
    {
        /// <summary>
        /// This is the structure for the calculator form
        /// </summary>
        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// This is the shared event handler for all the calculator 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CalculatorButton_Click(object sender, EventArgs e)
        {
            var TheButton = sender as Button;
            int buttonValue;
            bool resultCondition = int.TryParse(TheButton.Text,out buttonValue);

            if(resultCondition)
            {
                ResultLable.Text += TheButton.Text;
            }
            else
            {
                ResultLable.Text = "Not A Number (NAN)";
            }
        }
    }
}
