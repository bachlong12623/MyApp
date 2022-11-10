using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using MyApp;

namespace MyAppTest
{
    [TestFixture]
    public class MyAddTest
    {
        [Test]
        public void MyTest()
        {
            MyMath m = new MyMath();
            Assert.AreEqual(15, m.Add(10, 5),"False");
        }
        [Test]
        public void MyTest1()
        {
            MyMath m = new MyMath();
            Assert.AreEqual(10, m.Add(5, 5),"True");
        }
    }
}
