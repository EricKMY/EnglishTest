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
    public class ReadFile
    {
        private const string EMPTY_LINE = "";
        private string _line;
        private const string FILE_ADDRESS = "../../question.txt";

        public List<string> _answerList = new List<string>();
        // Create a stream reader from the specific file 
        System.IO.StreamReader _file = new System.IO.StreamReader(FILE_ADDRESS, Encoding.Default);

        //read the string from the file into _answerList
        public void Read()
        {
            while (!_file.EndOfStream)
            {
                // Read a new line
                _line = _file.ReadLine();

                // Ignore the line, if it is empty 
                if (_line.Equals(EMPTY_LINE))
                    continue;

                _answerList.Add(_line);
            }
        }
    }
}
