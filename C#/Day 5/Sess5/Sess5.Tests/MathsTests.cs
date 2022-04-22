using System;
using System.Collections.Generic;
using System.Text;
using Sess5;
using Microsoft.VisualStudio.TestPlatform;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;

namespace Sess5.Tests
{
    [TestFixture] //NUnit
    [TestClass] //MS Test
    public class MathsTests
    {
        [Test] //NUnit
        [TestMethod] //MS Test
        public void TestAdd()
        {
            //Arrange
            Maths maths = new Maths();
            int a = 5, b = 7;

            //Act
            int result = maths.Add(a, b);

            //Assert
            //Check if the result is equal to sum of a and b
            NUnit.Framework.Assert.That(result == (a + b), "Add function is not working properly");

            //MS Test
            //Assert.AreEqual(result, a + b,
            //    "Add function is not adding properly");
        }
        [Test]
        [TestMethod]
        public void TestSubtract()
        {
            //Arrange
            Maths maths = new Maths();
            int a = 5, b = 7;

            //Act
            int result = maths.Subtract(a, b);

            //Assert
            //NUnit
            NUnit.Framework.Assert.IsTrue(result == (a - b), 
                "Subtract function is not working properly");

            //MS Test
            //Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsTrue(result == (a - b), 
            //    "Subtract function is not working properly");
        }

        [Test]
        [TestMethod]
        public void TestMultiply()
        {
            //Arrange
            Maths maths = new Maths();
            int a = 5, b = 7;

            //Act
            int result = maths.Multiply(a, b);

            //Assert
            //NUnit
            //NUnit.Framework.Assert.IsTrue(result == (a * b),
            //    "Multiply function is not working properly");
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(result , (a * b),"Multiply func not working properly");
        }

        [Test]
        [TestMethod]
        public void TestDivide()
        {
            //Arrange
            Maths maths = new Maths();
            int a = 5, b = 7;

            //Act
            int result = maths.Divide(a, b);

            //Assert
            //NUnit
            //NUnit.Framework.Assert.IsTrue(result == (a / b),
            //    "Divide function is not working properly");
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsTrue(result == (a / b),
                "Divide func not working properly");
        }
    }
}
