using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Input;
using System.Windows.Forms;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;


namespace CodedUITestProject
{
    /// <summary>
    /// MainFormUITest 的摘要描述
    /// </summary>
    [CodedUITest]
    public class MainFormUITest
    {
        const string FILE_PATH = @"../../../EnglishTest/bin/Debug/EnglishTest.exe";
        private const string ENGLISH_TEST_TITLE = "基本能力測驗英文1000字";

        [TestInitialize()]
        public void Initialize()
        {
            Robot.Initialize(FILE_PATH, ENGLISH_TEST_TITLE);
        }

        [TestCleanup()]
        public void Cleanup()
        {
            Robot.CleanUp();
        }

        private void RunButton()
        {
            Robot.ClickButton("Start");  
            Robot.ClickButton("Next");
            Robot.ClickButton("Stop");
        }

        private void RunMenu()
        {
            Robot.ClickMenuItem(new string[] {"Examination", "Number Of Questions", "10 Questions" });
            Robot.ClickMenuItem(new string[] { "Examination", "Number Of Questions", "20 Questions" });
            Robot.ClickMenuItem(new string[] { "Examination", "Number Of Questions", "50 Questions" });
            Robot.ClickMenuItem(new string[] { "Examination", "Question Type", "All fill in blank questions" });
            Robot.ClickMenuItem(new string[] { "Examination", "Question Type", "All multiple-choice questions" });
            Robot.ClickMenuItem(new string[] { "Examination", "Question Type", "Pick up qustions randomly" });
            Robot.ClickMenuItem(new string[] { "File", "Exit"});

        }

        [TestMethod]
        public void TestButton()
        {
            RunButton();
        }

        [TestMethod]
        public void TestMenu()
        {
            RunMenu();
        }
    }
}
