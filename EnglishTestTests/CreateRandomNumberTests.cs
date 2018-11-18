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
    public class CreateRandomNumberTests
    {
        CreateRandomNumber _createRandomNumber = new CreateRandomNumber();

        [TestMethod()]
        public void CreateTest()
        {
            _createRandomNumber.Create(16);
            Assert.AreEqual(64, _createRandomNumber._questionNumberList.Length);
            Assert.AreEqual(16, _createRandomNumber._answerNumberList.Length);
        }
    }
}