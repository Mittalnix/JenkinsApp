using NUnit.Framework;
using ClassLibrary1;

namespace TestProject2
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }
        [Test]
        public void add_check()
        {
            MyMaths cls1 = new MyMaths();
            int exp = 180;
            int act = cls1.add(180, 20);
            Assert.AreEqual(exp, act);


        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}