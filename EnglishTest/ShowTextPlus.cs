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
        //計時器
        private void StartTimer()
        {
            _timer = new Timer();
            _timer.Interval = MILLISECONDS_PER_SECOND;
            _timer.Tick += TickEventHandler;
            _timer.Start();
        }

        //每秒更新事項
        private void TickEventHandler(object sender, EventArgs e)
        {

            if (ChangeDeadlineValue == 0)
            {
                ChangeDeadlineValue = 100;
                _missedTime++;
            }

            if (ChangeDeadlineValue > 0)
                ChangeDeadlineValue -= 10;

            _totalScore = (_checkAnswer._point * 100) / _total - _missedTime;
            ChangeScore = SCORE + _totalScore;
            _time++;
            ShowTotalTime(_time);
            ChangeTotalTime = _hour + _minute + _second;
        }

        //顯示時間
        private void ShowTotalTime(int time)
        {
            _totalTimeHour = time / 360;
            _totalTimeMinute = time / 60 - _totalTimeHour * 60;
            _totalTimeSecond = time - _totalTimeMinute * 60 - _totalTimeHour * 360;
            if (_totalTimeHour < 10)
                _hour = "0" + _totalTimeHour + ":";
            else
                _hour = _totalTimeHour + ":";
            if (_totalTimeMinute < 10)
                _minute = "0" + _totalTimeMinute + ":";
            else
                _minute = _totalTimeMinute + ":";
            if (_totalTimeSecond < 10)
                _second = "0" + _totalTimeSecond;
            else
                _second = "" + _totalTimeSecond;
        }

        //get parameter from presentation
        public void GetParameter(int total, int type)
        {
            _total = total;
            _type = type;
        }

        //get your answer from presentation
        public void GetYourAnswer(string yourAnswer, bool choiceOneCheck, bool choiceTwoCheck, bool choiceTreeCheck)
        {
            _yourAnswer = yourAnswer;
            _choiceOneCheck = choiceOneCheck;
            _choiceTwoCheck = choiceTwoCheck;
            _choiceThreeCheck = choiceTreeCheck;
        }
    }
}
