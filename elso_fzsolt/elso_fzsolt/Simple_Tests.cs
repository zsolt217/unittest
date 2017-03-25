using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elso_fzsolt
{
    [TestFixture]
    class Simple_Tests
    {
        [Test]
        public void Test_Add_Should_GiveBack2_When_1_1()
        {
            // Arrange
            Calculator calculator = new Calculator();
            // Act
            var result = calculator.Add("1,1");
            // Assert
            Assert.AreEqual(2, result);
        }
        [Test]
        public void Test_Add_Should_GiveBack1_When_1()
        {
            // Arrange
            Calculator calculator = new Calculator();
            // Act
            var result = calculator.Add("1");
            // Assert
            Assert.AreEqual(1, result);
        }
        [Test]
        public void Test_Add_Should_GiveBack0_When_Empty()
        {
            // Arrange
            Calculator calculator = new Calculator();
            // Act
            var result = calculator.Add(String.Empty);
            // Assert
            Assert.AreEqual(0, result);
        }
        [Test]
        public void Test_Add_Should_GiveBack3_When_1_1_1()
        {
            // Arrange
            Calculator calculator = new Calculator();
            // Act
            var result = calculator.Add("1,1,1");
            // Assert
            Assert.AreEqual(3, result);
        }
        [Test]
        public void Test_Add_Should_GiveBack2_When_1_n_1_1()
        {
            // Arrange
            Calculator calculator = new Calculator();
            // Act
            var result = calculator.Add("1\n1,1");
            // Assert
            Assert.AreEqual(3, result);
        }
        [Test]
        public void Test_Add_Should_GiveBack2_When_newdeliminter_n_1_1()
        {
            // Arrange
            Calculator calculator = new Calculator();
            // Act
            var result = calculator.Add("//;\n1;1");
            // Assert
            Assert.AreEqual(2, result);
        }
        [Test]
        public void Test_Add_Should_GiveBackException_When_negativeparamsaregiven()
        {
            // Arrange
            Calculator calculator = new Calculator();
            // Assert
            Assert.Throws<Exception>(() => { calculator.Add("-3,5,-1"); });
        }


    }
}
