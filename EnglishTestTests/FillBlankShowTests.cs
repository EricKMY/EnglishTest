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
    public class FillBlankShowTests
    {
        FillBlankShow _fillBlankShow = new FillBlankShow();

        private const string FIRST_ENGLISH_QUESTION = "a (1)";
        private const string FIRST_ENGLISH_ANSWER = "a";
        private const string FIRST_CHINESE = "[冠]一個;一種";
        private const string LAST_ENGLISH_QUESTION = "y_____s (5)";
        private const string LAST_ENGLISH_ANSWER = "yours";
        private const string LAST_CHINESE = "[代](所有格)你的(東西);你們的(東西)";
        private const int TOTAL = 1081;

        [TestMethod()]

        public void RunModelTest()
        {
            _fillBlankShow.RunModel(TOTAL);
        }

        [TestMethod()]

        public void ShowTest()
        {
            _fillBlankShow.RunModel(TOTAL, true);

            _fillBlankShow.Show(0);
            Assert.AreEqual(FIRST_ENGLISH_QUESTION, _fillBlankShow._englishQuestion);
            Assert.AreEqual(FIRST_ENGLISH_ANSWER, _fillBlankShow._englishAnswer);
            Assert.AreEqual(FIRST_CHINESE, _fillBlankShow._chinese);

            _fillBlankShow.Show(269);
            Assert.AreEqual(LAST_ENGLISH_QUESTION, _fillBlankShow._englishQuestion);
            Assert.AreEqual(LAST_ENGLISH_ANSWER, _fillBlankShow._englishAnswer);
            Assert.AreEqual(LAST_CHINESE, _fillBlankShow._chinese);
        }
    }
}