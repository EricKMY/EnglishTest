using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ChooseType
    {
        Random _random = new Random();

        private int _topic;

        //選擇題型
        public int Choose(int type, bool unitTest = false)
        {
            if (!unitTest)
            {
                switch (type)
                {
                    case 0:
                        _topic = 0;
                        break;

                    case 1:
                        _topic = _random.Next(1, 3);
                        break;

                    case 2:
                        _topic = _random.Next(0, 3);
                        break;
                }
            }else
                _topic = type;
            return _topic;
        }
    }
}
