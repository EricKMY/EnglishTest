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
    public class ChooseTypeTests
    {

        ChooseType _chooseType = new ChooseType();

        private int _type0;
        private int _type1;
        private int _type2;

        [TestMethod()]
        public void ChooseTest()
        {
            _type0 = _chooseType.Choose(0);
            _type1 = _chooseType.Choose(1);
            _type2 = _chooseType.Choose(2);

            Assert.AreEqual(0, _type0);

            if (!(_type1 == 1 || _type1 == 2))
            {
                Assert.Fail();
            }

            if (!(_type2 == 0 || _type2 == 1 || _type2 == 2))
            {
                Assert.Fail();
            }
        }
    }
}