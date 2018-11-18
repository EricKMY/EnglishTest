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
    public class CreateRandomNumber
    {
        Random _randomNumber = new Random();
        private const int ANSWER_LENGTH = 1;
        private const int QUESTION_LENGTH = 4;
        private const int LIBRARY_LENGTH = 1081;
        private int _random;

        public int[] _answerNumberList;
        public int[] _questionNumberList;

        //creat a list of random number
        public void Create(int total, bool unitTest = false)
        {
            _answerNumberList = new int[ANSWER_LENGTH * total];
            _questionNumberList = new int[QUESTION_LENGTH * total];
            for (int i = 0; i < _questionNumberList.Length; i++)
            {
                if (!unitTest)
                    _questionNumberList[i] = _randomNumber.Next(0, LIBRARY_LENGTH);
                else
                    _questionNumberList[i] = i;              
            }
            for (int i = 0; i < _answerNumberList.Length; i++)
            {
                if (!unitTest)
                    _random = _randomNumber.Next((i * 4), (i * 4 + 3));
                else
                    _random = i * 4;
                _answerNumberList[i] = _questionNumberList[_random]; 
            }
        }
    }
}
