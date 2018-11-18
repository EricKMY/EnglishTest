using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Tests
{
    [TestClass()]
    public class MultipleChoiceFormTests
    {
        MultipleChoiceForm _multipleChoiceForm = new MultipleChoiceForm();

        private const string FIRST_ENGLISH = "a";
        private const string FIRST_CHINESE = "[冠]一個;一種";
        private const string FIRST_CHINESE_CHOICE1 = "[冠]一個;一種";
        private const string FIRST_CHINESE_CHOICE2 = "[片]一些";
        private const string FIRST_CHINESE_CHOICE3 = "[片]一點點";
        private const string FIRST_CHINESE_CHOICE4 = "[片]很多";
        private const string FIRST_ENGLISH_CHOICE1 = "a";
        private const string FIRST_ENGLISH_CHOICE2 = "a_few";
        private const string FIRST_ENGLISH_CHOICE3 = "a_little";
        private const string FIRST_ENGLISH_CHOICE4 = "a_lot";
        private const string LAST_ENGLISH = "yours";
        private const string LAST_CHINESE = "[代](所有格)你的(東西);你們的(東西)";
        private const string LAST_CHINESE_CHOICE1 = "[代](所有格)你的(東西);你們的(東西)";
        private const string LAST_CHINESE_CHOICE2 = "[代](反身代名詞)你自己";
        private const string LAST_CHINESE_CHOICE3 = "[代](反身代名詞)你們自己";
        private const string LAST_CHINESE_CHOICE4 = "[縮]youhave";
        private const string LAST_ENGLISH_CHOICE1 = "yours";
        private const string LAST_ENGLISH_CHOICE2 = "yourself";
        private const string LAST_ENGLISH_CHOICE3 = "yourselves";
        private const string LAST_ENGLISH_CHOICE4 = "you've";
        private const int TOTAL = 1081;

        [TestMethod()]
        public void RunModelTest()
        {
            _multipleChoiceForm.RunModel(TOTAL);
        }

        [TestMethod()]

        public void ShowEnglishTest()
        {
            _multipleChoiceForm.RunModel(TOTAL, true);

            _multipleChoiceForm.ShowEnglish(0);
            Assert.AreEqual(FIRST_ENGLISH, _multipleChoiceForm._english);
            Assert.AreEqual(FIRST_CHINESE, _multipleChoiceForm._chinese);
            Assert.AreEqual(FIRST_CHINESE_CHOICE1, _multipleChoiceForm._chineseChoice[0]);
            Assert.AreEqual(FIRST_CHINESE_CHOICE2, _multipleChoiceForm._chineseChoice[1]);
            Assert.AreEqual(FIRST_CHINESE_CHOICE3, _multipleChoiceForm._chineseChoice[2]);
            Assert.AreEqual(FIRST_CHINESE_CHOICE4, _multipleChoiceForm._chineseChoice[3]);
            Assert.AreEqual(FIRST_ENGLISH_CHOICE1, _multipleChoiceForm._englishChoice[0]);
            Assert.AreEqual(FIRST_ENGLISH_CHOICE2, _multipleChoiceForm._englishChoice[1]);
            Assert.AreEqual(FIRST_ENGLISH_CHOICE3, _multipleChoiceForm._englishChoice[2]);
            Assert.AreEqual(FIRST_ENGLISH_CHOICE4, _multipleChoiceForm._englishChoice[3]);

            _multipleChoiceForm.ShowEnglish(269);
            Assert.AreEqual(LAST_ENGLISH, _multipleChoiceForm._english);
            Assert.AreEqual(LAST_CHINESE, _multipleChoiceForm._chinese);
            Assert.AreEqual(LAST_CHINESE_CHOICE1, _multipleChoiceForm._chineseChoice[0]);
            Assert.AreEqual(LAST_CHINESE_CHOICE2, _multipleChoiceForm._chineseChoice[1]);
            Assert.AreEqual(LAST_CHINESE_CHOICE3, _multipleChoiceForm._chineseChoice[2]);
            Assert.AreEqual(LAST_CHINESE_CHOICE4, _multipleChoiceForm._chineseChoice[3]);
            Assert.AreEqual(LAST_ENGLISH_CHOICE1, _multipleChoiceForm._englishChoice[0]);
            Assert.AreEqual(LAST_ENGLISH_CHOICE2, _multipleChoiceForm._englishChoice[1]);
            Assert.AreEqual(LAST_ENGLISH_CHOICE3, _multipleChoiceForm._englishChoice[2]);
            Assert.AreEqual(LAST_ENGLISH_CHOICE4, _multipleChoiceForm._englishChoice[3]);
        }
    }
}