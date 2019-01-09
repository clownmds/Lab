using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyIndustry.Model;

namespace MyIndustryUnitTest
{
    [TestClass]
    public class IndustryTests
    {
        [TestMethod]
        public void IndustryConstructorTest()
        {
            string s="Завод";
            Industry i = new Industry(s);
        }

        [TestMethod]
        public void IndustryConstructorTest_Null()
        {
            string s = null;
            Industry i = new Industry(s);
        }

        [TestMethod]
        public void AddItemMetalWorkingTest()
        {
            string s = "Завод";
            Industry i = new Industry(s);
            i.AddItemMetalWorking(5000);
        }

        [TestMethod]
        public void AddItemWoodWorkingTest()
        {
            string s = "Завод";
            Industry i = new Industry(s);
            i.AddItemWoodWorking(5000);
        }
    }
}
