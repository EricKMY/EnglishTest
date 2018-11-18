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
    public class SplitStringTests
    {
        const string ONE = "aaa   bbb";
        const string TWO = "aaa>>>bbb";
        const string THREE = "aaa   >>>bbb";
        const string RESULT_ONE = "aaa";
        const string RESULT_TWO = "bbb";
        SplitString _splitString = new SplitString();

        [TestMethod()]        
        public void SplitTest()
        {
            _splitString.Split(ONE);
            Assert.AreEqual(RESULT_ONE, _splitString._word[0]);
            Assert.AreEqual(RESULT_TWO, _splitString._word[1]);

            _splitString.Split(TWO);
            Assert.AreEqual(RESULT_ONE, _splitString._word[0]);
            Assert.AreEqual(RESULT_TWO, _splitString._word[1]);

            _splitString.Split(THREE);
            Assert.AreEqual(RESULT_ONE, _splitString._word[0]);
            Assert.AreEqual(RESULT_TWO, _splitString._word[1]);
        }
    }
}