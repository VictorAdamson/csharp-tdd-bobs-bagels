﻿using NUnit.Framework;
using tdd_bobs_bagels.CSharp.Main;

namespace tdd_bobs_bagels.CSharp.Test
{
    [TestFixture]
    public class BasketTests
    {
        private Basket _basket;
        public BasketTests()
        {
            _basket = new Basket(6);
            _basket.addBagel("poppy seed");
            _basket.addBagel("cream cheese");
            _basket.addBagel("smoked ham");
            _basket.addBagel("bacon");
            _basket.addBagel("standard");
            _basket.removeBagel("bacon");
        }
        [Test]
        public void addBagelTest()
        {
            Assert.IsTrue(_basket.content.Contains("poppy seed"));
            Assert.IsTrue(_basket.content.Contains("cream cheese"));
            Assert.IsFalse(_basket.content.Contains("sesame seed"));
        }
        [Test]
        public void removeBagelTest()
        {
            Assert.IsTrue(_basket.content.Contains("poppy seed"));
            Assert.IsFalse(_basket.content.Contains("bacon"));
        }
        [Test]
        public void changeCapacityTest()
        {
            Assert.AreEqual(7, _basket.changeCapacity(1));
        }
    }
}