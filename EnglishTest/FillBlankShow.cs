using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Model
{
    public class FillBlankShow
    {
        ReadFile _readFile = new ReadFile();
        CreateRandomNumber _createRandomNumber = new CreateRandomNumber();
        SplitString _splitString = new SplitString();

        private const string WORD1 = "_____";
        private const string WORD2 = " (";
        private const string WORD3 = ")";
        private string _firstWord;
        private string _lastWord;

        public string _chinese;
        public string _englishQuestion;
        public string _englishAnswer;

        //run the model that need to used in the form
        public void RunModel(int total, bool unitTest = false)
        {
            _readFile.Read();
            _createRandomNumber.Create(total, unitTest);
        }

        //show all the text in every textbox
        public void Show(int count)
        {
            int random = _createRandomNumber._answerNumberList[count];
            string text = _readFile._answerList.ElementAt(random);
            _splitString.Split(text);
            _chinese = _splitString._word[1];
            _englishAnswer = _splitString._word[0];
            _firstWord = _englishAnswer.First().ToString();
            _lastWord = _englishAnswer.Last().ToString();
            CheckLength(_englishAnswer.Length);
            
        }

        private void CheckLength(int length)
        {
            switch (length)
            {
                case 1:
                case 2:
                    _englishQuestion = _englishAnswer + WORD2 + _englishAnswer.Length + WORD3;
                    break;

                default:
                    _englishQuestion = _firstWord + WORD1 + _lastWord + WORD2 + _englishAnswer.Length + WORD3;
                    break;
            }
        }
    }
}