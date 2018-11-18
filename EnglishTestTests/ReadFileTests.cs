using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Tests
{
    [TestClass()]
    public class ReadFileTests
    {
        const string FIRST_LINE = "a                    >>> [冠]一個;一種                           ";
        const string LAST_LINE = "zoo                  >>> [名]動物園                              ";

        ReadFile _readFile = new ReadFile();

        [TestMethod()]
        public void ReadTest()
        {
            _readFile.Read();
            Assert.AreEqual<string>(FIRST_LINE, _readFile._answerList.ElementAt(0));
            Assert.AreEqual<string>(LAST_LINE, _readFile._answerList.ElementAt(1080));
        }
    }
}