using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyIndustry.Model;
using MyIndustry.Interfaces;
using System.Collections.Generic;

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

            Assert.IsTrue(i.isRight);
            Assert.IsInstanceOfType(i, typeof(Industry));
            Assert.AreEqual(i.Title, s);
        }

        [TestMethod]
        public void IndustryIncorrectConstructorTest_Null()
        {
            string s = null;

            Industry i = new Industry(s);
            
            Assert.IsFalse(i.isRight);
        }

        [TestMethod]
        public void AddItemMetalWorkingTest()
        {
            string s = "Завод";
            Industry i = new Industry(s);
            int power = 5000;

            i.AddItemMetalWorking(power);
            
            var ie=i.Plants.GetEnumerator();
            ie.MoveNext();

            Assert.IsInstanceOfType(ie.Current, typeof(IPlant));
            Assert.AreEqual(ie.Current.Power, power);
        }

        [TestMethod]
        public void AddItemWoodWorkingTest()
        {
            string s = "Завод";
            Industry i = new Industry(s);
            int power = 5000;

            i.AddItemWoodWorking(power);

            var ie = i.Plants.GetEnumerator();
            ie.MoveNext();

            Assert.IsInstanceOfType(ie.Current, typeof(IPlant));
            Assert.AreEqual(ie.Current.Power, power);
        }

        [TestMethod]
        public void RemoveItemTest()
        {
            string s = "Завод";
            Industry i = new Industry(s);
            i.AddItemWoodWorking(5000);
            int power = 4000;
            i.AddItemWoodWorking(power);
            var ie = i.Plants.GetEnumerator();
            ie.MoveNext();

            i.RemoveItem(ie.Current.Title);

            ie = i.Plants.GetEnumerator();
            ie.MoveNext();
            
            Assert.AreEqual(ie.Current.Power, power);
        }

        [TestMethod]
        public void ViewItemsTest()
        {           
            string s = "Завод";
            Industry i = new Industry(s);
            int power = 5000;
            i.AddItemWoodWorking(power);

            List<IPlant> p= i.ViewItems();

            Assert.IsInstanceOfType(p, typeof(List<IPlant>));
        }
        
        [TestMethod]
        public void SearchItemTest()
        {
            string s = "Завод";
            Industry i = new Industry(s);
            int power = 5000;
            i.AddItemWoodWorking(power);
            var ie = i.Plants.GetEnumerator();
            ie.MoveNext();

            var p = i.SearchItem(ie.Current.Title);
            
            Assert.AreEqual(p.Title,ie.Current.Title);
        }

        [TestMethod]
        public void ChangeItemTest()
        {
            string s = "Завод";
            Industry i = new Industry(s);
            int power = 5000;
            i.AddItemWoodWorking(power);
            var ie = i.Plants.GetEnumerator();
            ie.MoveNext();
            power = 1000;

            i.ChangeItem(ie.Current.Title,power);
            
            Assert.AreEqual(ie.Current.Power,power);
        }
    }
}
