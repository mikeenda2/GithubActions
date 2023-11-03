using System;
using NUnit.Framework;

namespace GithubActionsLab
{
    [TestFixture]
    public class Math
    {
        [Test]
        public void Add_Valid()
        {
            Assert.AreEqual(3, Program.Add("1", "2"));
            Assert.AreEqual(5, Program.Add("3", "2"));
            Assert.AreEqual(12, Program.Add("5", "7"));
        }

        [Test]
        public void Add_Invalid()
        {
            Assert.Throws<FormatException>(() => Program.Add("1", "a"));
            Assert.Throws<FormatException>(() => Program.Add("a", "1"));
            Assert.Throws<FormatException>(() => Program.Add("a", "a"));
        }

        [Test]
        public void Add_Null()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Add("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Add(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Add(null, null));
        }

        [[Test]
        public void Add_ValidMichaelEndacott()
        {
            string x = "2";
            string y = "3";

            double result = Program.Add(x, y);
            Assert.AreEqual(5, result);
        }

        [Test]
        public void Subtract_ValidMichaelEndacott()
        {
            string x = "5";
            string y = "3";
            double result = Program.Subtract(x, y);
            Assert.AreEqual(2, result);
        }

        [Test]
        public void Multiply_ValidMichaelEndacott()
        {
            string x = "4";
            string y = "3";
            double result = Program.Multiply(x, y);

            Assert.AreEqual(12, result);
        }

        [Test]
        public void Divide_ValidMichaelEndacott()
        {
            string x = "12";
            string y = "3";
            double result = Program.Divide(x, y);
            Assert.AreEqual(4, result);
        }
    }
}
