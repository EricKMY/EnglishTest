using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{

    public partial class Form1 : Form
    {
        PresentationModel.ShowText _showText = new PresentationModel.ShowText();

        public Form1()
        {
            InitializeComponent();
            _groupBox1.DataBindings.Add("Visible", _showText, "ChangeGroupBox1View");
            _groupBox2.DataBindings.Add("Visible", _showText, "ChangeGroupBox2View");
            _groupBox3.DataBindings.Add("Visible", _showText, "ChangeGroupBox3View");
            _groupBox4.DataBindings.Add("Visible", _showText, "ChangeGroupBox4View");
            _startButton.DataBindings.Add("Enabled", _showText, "ChangeStartButtonView");
            _nextButton.DataBindings.Add("Enabled", _showText, "ChangeNextButtonView");
            _stopButton.DataBindings.Add("Enabled", _showText, "ChangeStopButtonView");           
            _groupBox1.DataBindings.Add("Text", _showText, "ChangeGroupBox1");
            _groupBox2.DataBindings.Add("Text", _showText, "ChangeGroupBox2");
            _fillBlankTitleChinese.DataBindings.Add("Text", _showText, "ChangeFillBlankTitleChinese");
            _fillBlankTitleEnglish.DataBindings.Add("Text", _showText, "ChangeFillBlankTitleEnglish");
            _multipleChoiceTitle.DataBindings.Add("Text", _showText, "ChangeMultipleChoiceTitle");
            _choiceOne.DataBindings.Add("Text", _showText, "ChangeChoiceOne");
            _choiceTwo.DataBindings.Add("Text", _showText, "ChangeChoiceTwo");
            _choiceThree.DataBindings.Add("Text", _showText, "ChangeChoiceThree");
            _choiceFour.DataBindings.Add("Text", _showText, "ChangeChoiceFour");
            _result.DataBindings.Add("Text", _showText, "ChangeResult");
            _score.DataBindings.Add("Text", _showText, "ChangeScore");
            _time.DataBindings.Add("Text", _showText, "ChangeTotalTime");
            _deadline.DataBindings.Add("Value", _showText, "ChangeDeadlineValue");
            _showText.StartForm();       
        }

        //action taken after click on Start button
        private void ClickStart(object sender, EventArgs e)
        {
            _showText.GetParameter((int)_numericUpDown1.Value, _comboBox1.SelectedIndex);
            _showText.ClickStartShow();
        }

        //action taken after click on Next button
        private void ClickNext(object sender, EventArgs e)
        {
            _showText.GetYourAnswer(_fillBlankAnswer.Text, _choiceOne.Checked, _choiceTwo.Checked, _choiceThree.Checked);
            _showText.ClickNextShow();
        }

        //action taken after click on Stop button
        private void ClickStop(object sender, EventArgs e)
        {
            _showText.ClickStopShow();
        }
    }
}