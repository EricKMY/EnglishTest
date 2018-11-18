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
    public class SplitString
    {
        private const char DELETE_WORD1 = ' ';
        private const char DELETE_WORD2 = '>';

        public string[] _word;

        //seperate the chinese and engilshin in the string to two diffrient string
        public void Split(string text)
        {
            char[] deleteCharacter = { DELETE_WORD1, DELETE_WORD2 };
            _word = text.Split(deleteCharacter, StringSplitOptions.RemoveEmptyEntries);
        }  
    }
}
