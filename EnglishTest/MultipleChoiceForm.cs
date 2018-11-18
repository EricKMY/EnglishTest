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
    public class MultipleChoiceForm
    {
        ReadFile _readFile = new ReadFile();
        CreateRandomNumber _createRandomNumber = new CreateRandomNumber();
        SplitString _splitString = new SplitString();

        private int _random;
        private int[] _randomChoice = new int[4];
        private string _text;
      
        public string _english;
        public string _chinese;
        public string[] _chineseChoice = new string[4];
        public string[] _englishChoice = new string[4];

        //執行在Model中的需要程式
        public void RunModel(int total, bool unitTest = false)
        {
            _readFile.Read();
            _createRandomNumber.Create(total, unitTest);
        }

        //將字典處理成填充題
        public void ShowEnglish(int count)
        {
            _random = _createRandomNumber._answerNumberList[count];
            _text = _readFile._answerList.ElementAt(_random);
            _splitString.Split(_text);

            _english = _splitString._word[0];
            _chinese = _splitString._word[1];

            for (int i = 0; i < 4; i++)
            {
                _randomChoice[i] = _createRandomNumber._questionNumberList[count * 4 + i];
                _text = _readFile._answerList.ElementAt(_randomChoice[i]);
                _splitString.Split(_text);
                _chineseChoice[i] = _splitString._word[1];
                _englishChoice[i] = _splitString._word[0];
            }               
        }
    }
}
