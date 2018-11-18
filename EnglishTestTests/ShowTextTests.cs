using Microsoft.VisualStudio.TestTools.UnitTesting;
using PresentationModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationModel.Tests
{
    [TestClass()]
    public class ShowTextTests
    {
        ShowText _showText = new ShowText();

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
        const string CORRECT = "Correct!!";
        const string SCORE = "Score: 0";

        [TestMethod()]

        public void StartFormTest()
        {
            _showText.StartForm();
            Assert.AreEqual(false, _showText.ChangeGroupBox1View);
            Assert.AreEqual(false, _showText.ChangeGroupBox2View);
            Assert.AreEqual(true, _showText.ChangeGroupBox3View);
            Assert.AreEqual(true, _showText.ChangeStartButtonView);
            Assert.AreEqual(false, _showText.ChangeNextButtonView);
            Assert.AreEqual(false, _showText.ChangeStopButtonView);
        }

        [TestMethod()]

        public void ClickStartShowTest()
        {
            _showText.GetParameter(10, 0);
            _showText.ClickStartShow(true);
            Assert.AreEqual(false, _showText.ChangeStartButtonView);
            Assert.AreEqual(true, _showText.ChangeNextButtonView);
            Assert.AreEqual(true, _showText.ChangeStopButtonView);
            Assert.AreEqual(true, _showText.ChangeGroupBox1View);
            Assert.AreEqual(false, _showText.ChangeGroupBox2View);
            Assert.AreEqual(false, _showText.ChangeGroupBox3View);
            Assert.AreEqual(true, _showText.ChangeGroupBox4View);
            Assert.AreEqual(QUESTION + "1" + TOPIC1, _showText.ChangeGroupBox1);
            Assert.AreEqual(null, _showText.ChangeResult);
            Assert.AreEqual("[冠]一個;一種", _showText.ChangeFillBlankTitleChinese);
            Assert.AreEqual("a (1)", _showText.ChangeFillBlankTitleEnglish);

            _showText.GetParameter(10, 1);
            _showText.ClickStartShow(true);
            Assert.AreEqual(false, _showText.ChangeStartButtonView);
            Assert.AreEqual(true, _showText.ChangeNextButtonView);
            Assert.AreEqual(true, _showText.ChangeStopButtonView);
            Assert.AreEqual(false, _showText.ChangeGroupBox1View);
            Assert.AreEqual(true, _showText.ChangeGroupBox2View);
            Assert.AreEqual(false, _showText.ChangeGroupBox3View);
            Assert.AreEqual(QUESTION + "1" + TOPIC2, _showText.ChangeGroupBox2);
            Assert.AreEqual(null, _showText.ChangeResult);
            Assert.AreEqual("a", _showText.ChangeMultipleChoiceTitle);
            Assert.AreEqual(CHOICE1 + "[冠]一個;一種", _showText.ChangeChoiceOne);
            Assert.AreEqual(CHOICE2 + "[片]一些", _showText.ChangeChoiceTwo);
            Assert.AreEqual(CHOICE3 + "[片]一點點", _showText.ChangeChoiceThree);
            Assert.AreEqual(CHOICE4 + "[片]很多", _showText.ChangeChoiceFour);

            _showText.GetParameter(10, 2);
            _showText.ClickStartShow(true);
            Assert.AreEqual(false, _showText.ChangeStartButtonView);
            Assert.AreEqual(true, _showText.ChangeNextButtonView);
            Assert.AreEqual(true, _showText.ChangeStopButtonView);
            Assert.AreEqual(false, _showText.ChangeGroupBox1View);
            Assert.AreEqual(true, _showText.ChangeGroupBox2View);
            Assert.AreEqual(false, _showText.ChangeGroupBox3View);
            Assert.AreEqual(QUESTION + "1" + TOPIC2, _showText.ChangeGroupBox2);
            Assert.AreEqual(null, _showText.ChangeResult);
            Assert.AreEqual("[冠]一個;一種", _showText.ChangeMultipleChoiceTitle);
            Assert.AreEqual(CHOICE1 + "a", _showText.ChangeChoiceOne);
            Assert.AreEqual(CHOICE2 + "a_few", _showText.ChangeChoiceTwo);
            Assert.AreEqual(CHOICE3 + "a_little", _showText.ChangeChoiceThree);
            Assert.AreEqual(CHOICE4 + "a_lot", _showText.ChangeChoiceFour);
        }

        [TestMethod()]

        public void ClickNextShowTest()
        {
            _showText.GetParameter(10, 1);
            _showText.GetYourAnswer("a", true, false, false);
            _showText.ClickStartShow(true);
            _showText.ClickNextShow(true);
            Assert.AreEqual(CORRECT, _showText.ChangeResult);
            Assert.AreEqual(SCORE, _showText.ChangeScore);
            Assert.AreEqual(null, _showText.ChangeTotalTime);
            Assert.AreEqual(null, _showText.ChangeFillBlankAnswerEnglish);
            Assert.AreEqual(100, _showText.ChangeDeadlineValue);
        }

        [TestMethod()]

        public void ClickStopShowTest()
        {
            _showText.ClickStopShow(true);
            Assert.AreEqual(false, _showText.ChangeNextButtonView);
            Assert.AreEqual(false, _showText.ChangeStartButtonView);
        }

        [TestMethod()]

        public void GetParameterTest()
        {
            _showText.GetParameter(10, 15);
        }

        [TestMethod()]

        public void GetYourAnswerTest()
        {
            _showText.GetYourAnswer("aaaaa", true, true, true);
        }

    }
}