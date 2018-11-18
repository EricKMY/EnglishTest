using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PresentationModel
{
    public partial class ShowText : INotifyPropertyChanged
    {
        private bool _groupBox1View;
        private bool _groupBox2View;
        private bool _groupBox3View;
        private bool _groupBox4View;
        private bool _startButtonView;
        private bool _nextButtonView;
        private bool _stopButtonView;      
        private string _groupBox1;
        private string _groupBox2;
        private string _fillBlankTitleChinese;
        private string _fillBlankTitleEnglish;
        private string _fillBlankAnswerEnglish;
        private string _multipleChoiceTitle;
        private string _choiceOne;
        private string _choiceTwo;
        private string _choiceThree;
        private string _choiceFour;
        private string _result;
        private string _score;
        private string _changeTotalTime;
        private int _deadlineValue;


        void NotifyPropertyChanged([CallerMemberName] string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
        
        public bool ChangeGroupBox1View
        {
            get
            {
                return _groupBox1View;
            }
            set
            {
                _groupBox1View = value;
                NotifyPropertyChanged();
            }
        }

        public bool ChangeGroupBox2View
        {
            get
            {
                return _groupBox2View;
            }
            set
            {
                _groupBox2View = value;
                NotifyPropertyChanged();
            }
        }

        public bool ChangeGroupBox3View
        {
            get
            {
                return _groupBox3View;
            }
            set
            {
                _groupBox3View = value;
                NotifyPropertyChanged();
            }
        }

        public bool ChangeGroupBox4View
        {
            get
            {
                return _groupBox4View;
            }
            set
            {
                _groupBox4View = value;
                NotifyPropertyChanged();
            }
        }

        public bool ChangeStartButtonView
        {
            get
            {
                return _startButtonView;
            }
            set
            {
                _startButtonView = value;
                NotifyPropertyChanged();
            }
        }

        public bool ChangeNextButtonView
        {
            get
            {
                return _nextButtonView;
            }
            set
            {
                _nextButtonView = value;
                NotifyPropertyChanged();
            }
        }

        public bool ChangeStopButtonView
        {
            get
            {
                return _stopButtonView;
            }
            set
            {
                _stopButtonView = value;
                NotifyPropertyChanged();
            }
        }

        public string ChangeGroupBox1
        {
            get
            {
                return _groupBox1;
            }
            set
            {
                _groupBox1 = value;
                NotifyPropertyChanged();
            }
        }

        public string ChangeGroupBox2
        {
            get
            {
                return _groupBox2;
            }
            set
            {
                _groupBox2 = value;
                NotifyPropertyChanged();
            }
        }

        public string ChangeFillBlankTitleChinese
        {
            get
            {
                return _fillBlankTitleChinese;
            }
            set
            {
                _fillBlankTitleChinese = value;
                NotifyPropertyChanged();
            }
        }

        public string ChangeFillBlankTitleEnglish
        {
            get
            {
                return _fillBlankTitleEnglish;
            }
            set
            {
                _fillBlankTitleEnglish = value;
                NotifyPropertyChanged();
            }
        }

        public string ChangeFillBlankAnswerEnglish
        {
            get
            {
                return _fillBlankAnswerEnglish;
            }
            set
            {
                _fillBlankAnswerEnglish = value;
                NotifyPropertyChanged();
            }
        }

        public string ChangeMultipleChoiceTitle
        {
            get
            {
                return _multipleChoiceTitle;
            }
            set
            {
                _multipleChoiceTitle = value;
                NotifyPropertyChanged();
            }
        }

        public string ChangeChoiceOne
        {
            get
            {
                return _choiceOne;
            }
            set
            {
                _choiceOne = value;
                NotifyPropertyChanged();
            }
        }

        public string ChangeChoiceTwo
        {
            get
            {
                return _choiceTwo;
            }
            set
            {
                _choiceTwo = value;
                NotifyPropertyChanged();
            }
        }

        public string ChangeChoiceThree
        {
            get
            {
                return _choiceThree;
            }
            set
            {
                _choiceThree = value;
                NotifyPropertyChanged();
            }
        }

        public string ChangeChoiceFour
        {
            get
            {
                return _choiceFour;
            }
            set
            {
                _choiceFour = value;
                NotifyPropertyChanged();
            }
        }

        public string ChangeResult
        {
            get
            {
                return _result;
            }
            set
            {
                _result = value;
                NotifyPropertyChanged();
            }
        }

        public string ChangeScore
        {
            get
            {
                return _score;
            }
            set
            {
                _score = value;
                NotifyPropertyChanged();
            }
        }

        public string ChangeTotalTime
        {
            get
            {
                return _changeTotalTime;
            }
            set
            {
                _changeTotalTime = value;
                NotifyPropertyChanged();
            }
        }

        public int ChangeDeadlineValue
        {
            get
            {
                return _deadlineValue;
            }
            set
            {
                _deadlineValue = value;
                NotifyPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
