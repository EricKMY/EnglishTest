using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationModel
{
    public partial class ShowText : INotifyPropertyChanged
    {
        Model.CheckAnswer _checkAnswer = new Model.CheckAnswer();
        Model.ChooseType _chooseType = new Model.ChooseType();
        Model.FillBlankShow _fillBlank = new Model.FillBlankShow();
        Model.MultipleChoiceForm _multipleChoice = new Model.MultipleChoiceForm();        

        private string _yourAnswer;
        private string _hour;
        private string _minute;
        private string _second;

        private bool _choiceOneCheck;
        private bool _choiceTwoCheck;
        private bool _choiceThreeCheck;

        private int _total;
        private int _count;
        private int _type;
        private int _topic;
        private int _time;
        private int _missedTime;
        private int _totalScore;
        private int _totalTimeSecond;
        private int _totalTimeMinute;
        private int _totalTimeHour;

        private const int MILLISECONDS_PER_SECOND = 1000;
        private Timer _timer;

        const string QUESTION = "Q ";
        const string TOPIC1 = " : Fill in The Blanks";
        const string TOPIC2 = " : Multiple Choice Question";
        const string ABOUT_DICTIONARY = "Total 1000 words in the dictionary.";
        const string ABOUT_SPELLING1 = "Spelling Checker 1000 Words";
        const string ABOUT_SPELLING2 = "All rights reserved";
        const string ABOUT_SPELLING3 = "Spirit Du";
        const string END1 = "you pass ";
        const string END2 = " of ";
        const string END3 = " questions";
        const string CHOICE1 = "(1) ";
        const string CHOICE2 = "(2) ";
        const string CHOICE3 = "(3) ";
        const string CHOICE4 = "(4) ";
        const string SCORE = "Score: ";

        //start form
        public void StartForm()
        {
            ChangeGroupBox1View = false;
            ChangeGroupBox2View = false;
            ChangeGroupBox3View = true;
            ChangeGroupBox4View = false;

            ChangeStartButtonView = true;
            ChangeNextButtonView = false;
            ChangeStopButtonView = false;
        }

        //all action taken after clicking start
        public void ClickStartShow(bool unitTest = false)
        {         
            ChangeGroupBox4View = true;
            ChangeStartButtonView = false;
            ChangeNextButtonView = true;
            ChangeStopButtonView = true;

            _fillBlank.RunModel(_total, unitTest);
            _multipleChoice.RunModel(_total, unitTest);
            _topic = _chooseType.Choose(_type, unitTest);
            ChooseTopic(_topic, _count);
            ChangeDeadlineValue = 100;
            StartTimer();                   
            ChangeScore = SCORE + _checkAnswer._point;                  
        }

        //all action taken after clicking next
        public void ClickNextShow(bool unitTest = false)
        {
            CheckAnswer(_topic);
            _topic = _chooseType.Choose(_type);     
            _count++;
            ChooseTopic(_topic, _count);
            ChangeDeadlineValue = 100;
            EndForm(unitTest);
        }

        //all action taken after clicking stop
        public void ClickStopShow(bool unitTest = false)
        {
            ChangeNextButtonView = false;
            ChangeStopButtonView = false;
            if (!unitTest)
            {
                MessageBox.Show(END1 + _checkAnswer._point + END2 + _total + END3);
                MessageBox.Show(SCORE + _totalScore);
            }          
        }

        public void EndForm(bool unitTest = false)
        {
            if (_count == (_total - 1) && !unitTest)
            {
                ChangeNextButtonView = false;
                ChangeStopButtonView = false;
                MessageBox.Show(END1 + _checkAnswer._point + END2 + _total + END3);
                MessageBox.Show(SCORE + _totalScore);
            }
        }

        //choice topic
        private void ChooseTopic(int topic, int count)
        {
            switch (topic)
            {
                case 0:
                    GetFillBlankForm(count);
                    break;
                case 1:
                    GetMultipleChoiceForm1(count);
                    break;
                case 2:
                    GetMultipleChoiceForm2(count);
                    break;
            }
        }

        // fill in blank form
        private void GetFillBlankForm(int count)
        {
            ChangeGroupBox1View = true;
            ChangeGroupBox2View = false;
            ChangeGroupBox3View = false;

            _fillBlank.Show(count);
            ChangeGroupBox1 = QUESTION + (count + 1) + TOPIC1;
            ChangeResult = _checkAnswer._result;
            ChangeFillBlankTitleChinese = _fillBlank._chinese;
            ChangeFillBlankTitleEnglish = _fillBlank._englishQuestion;
        }

        //multiple choice form - english title
        private void GetMultipleChoiceForm1(int count)
        {
            ChangeGroupBox1View = false;
            ChangeGroupBox2View = true;
            ChangeGroupBox3View = false;

            _multipleChoice.ShowEnglish(count);
            ChangeGroupBox2 = QUESTION + (count + 1) + TOPIC2;
            ChangeMultipleChoiceTitle = _multipleChoice._english;
            ChangeResult = _checkAnswer._result;
            ChangeChoiceOne = CHOICE1 + _multipleChoice._chineseChoice[0];
            ChangeChoiceTwo = CHOICE2 + _multipleChoice._chineseChoice[1];
            ChangeChoiceThree = CHOICE3 + _multipleChoice._chineseChoice[2];
            ChangeChoiceFour = CHOICE4 + _multipleChoice._chineseChoice[3];
        }

        //multiple choice form - chinese title
        private void GetMultipleChoiceForm2(int count)
        {
            ChangeGroupBox1View = false;
            ChangeGroupBox2View = true;
            ChangeGroupBox3View = false;

            _multipleChoice.ShowEnglish(count);
            ChangeGroupBox2 = QUESTION + (count + 1) + TOPIC2;
            ChangeResult = _checkAnswer._result;
            ChangeMultipleChoiceTitle = _multipleChoice._chinese;
            ChangeChoiceOne = CHOICE1 + _multipleChoice._englishChoice[0];
            ChangeChoiceTwo = CHOICE2 + _multipleChoice._englishChoice[1];
            ChangeChoiceThree = CHOICE3 + _multipleChoice._englishChoice[2];
            ChangeChoiceFour = CHOICE4 + _multipleChoice._englishChoice[3];
        }

        //check answer
        private void CheckAnswer(int topic)
        {
            switch (topic)
            {
                case 0:
                    _checkAnswer.Check(_yourAnswer, _fillBlank._englishAnswer);
                    break;
                case 1:
                    _checkAnswer.CheckBottom(_choiceOneCheck, _choiceTwoCheck, _choiceThreeCheck);
                    _checkAnswer.Check(_multipleChoice._chineseChoice[_checkAnswer._chosenNumber], _multipleChoice._chinese);
                    break;
                case 2:
                    _checkAnswer.CheckBottom(_choiceOneCheck, _choiceTwoCheck, _choiceThreeCheck);
                    _checkAnswer.Check(_multipleChoice._englishChoice[_checkAnswer._chosenNumber], _multipleChoice._english);
                    break;
            }
        }
    }
}
