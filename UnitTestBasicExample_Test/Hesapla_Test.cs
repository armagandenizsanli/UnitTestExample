using NUnit.Framework;
using System;
using UnitTestBasicExample;

namespace UnitTestBasicExample_Test
{
    [TestFixture]
    public class Hesapla_Test
    {
        private UnitTestBasicExample.Hesapla _nesne;
         [SetUp]
        public void Setup()
        {
            _nesne = new Hesapla();

        }
        [TestCase(3,5)]
        [TestCase(2,7)]
        [TestCase(5,5)]
        [Ignore("Ignore a fixture")]
        public void Topla_Test_True(int a,int b)
        {
            var result = _nesne.Topla(a, b);
            Assert.AreEqual(8, result,"Hata");
            //StringAssert.Contains("a", "b");
            
            
        }

        [TearDown]
        public void TearDown()
        {
            _nesne = null;
        }
    }
}
