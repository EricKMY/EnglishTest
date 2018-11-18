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
    public class CheckAnswerTests
    {
        CheckAnswer _checkAnswer = new CheckAnswer();
        const string CORRECT_ANSWER = "correct";
        const string WRONG_ANSWER = "wrong";
        const string ANSWER = "correct";
        const string CORRECT = "Correct!!";
        const string WRONG = "It should be correct !!";

        [TestMethod()]
        public void CheckTest()
        {
            _checkAnswer.Check(CORRECT_ANSWER, ANSWER);
            Assert.AreEqual(CORRECT, _checkAnswer._result);
            Assert.AreEqual(1, _checkAnswer._point);

            _checkAnswer.Check(WRONG_ANSWER, ANSWER);
            Assert.AreEqual(WRONG, _checkAnswer._result);
        }

        [TestMethod()]

        public void CheckBottomTest()
        {
            _checkAnswer.CheckBottom(true, false, false);
            Assert.AreEqual(_checkAnswer._chosenNumber, 0);

            _checkAnswer.CheckBottom(false, true, false);
            Assert.AreEqual(_checkAnswer._chosenNumber, 1);

            _checkAnswer.CheckBottom(false, false, true);
            Assert.AreEqual(_checkAnswer._chosenNumber, 2);

            _checkAnswer.CheckBottom(false, false, false);
            Assert.AreEqual(_checkAnswer._chosenNumber, 3);
        }
    }
}