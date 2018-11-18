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
    public class CheckAnswer
    {
        private const string CORRECT = "Correct!!";
        private const string WRONG1 = "It should be ";
        private const string WRONG2 = " !!";

        public int _chosenNumber;
        public string _result;
        public int _point = 0;        

        //check the answer and show thw result
        public void Check(string yourAnswer, string correctAnswer)
        {
            if (yourAnswer.Equals(correctAnswer))
            {
                _result = CORRECT;
                _point++;
            }
            else
            {
                _result = WRONG1 + correctAnswer + WRONG2;
            }
        }

        //檢查選擇答案
        public void CheckBottom(bool one, bool two, bool three)
        {
            if (one)
            {
                _chosenNumber = 0;
            }
            else if (two)
            {
                _chosenNumber = 1;
            }
            else if (three)
            {
                _chosenNumber = 2;
            }
            else
            {
                _chosenNumber = 3;
            }
        }
    }
}
