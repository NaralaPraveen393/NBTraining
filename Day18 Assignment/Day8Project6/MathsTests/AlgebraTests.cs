using Microsoft.VisualStudio.TestTools.UnitTesting;
using Maths;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maths.Tests
{
    [TestClass()]
    public class AlgebraTests
    {
        [TestMethod()]
        public void FactorialTest_Zero_Input()
        {
            //Arrange
            int n = 0;
            int expected = 1;

            //Act
            int actual=Algebra.Factorial(n);    

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void Factorialtest_Greaterthan_seven()
        {
            //Arrange
            int n = 8;
            int expected = -999;

            //Act
            int actual = Algebra.Factorial(n);

            //Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod()]
        public void Factorialtest_Lessthan_Zero()
        {
            //Arrange
            int n = -2;
            int expected = -9999;
            
            //Act
            int actual=Algebra.Factorial(n);
            
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void Factorialtest_Lessthan_Seven()
        {
            //Arrange
            int n = 5;
            int expected = 120;

            //Act
            int actual = Algebra.Factorial(n);  

            //Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod()]
        public void Palindrometest()
        {
            //Arrange
            int n = 363;
            string expected = "Palindrome";

            //Act
            string actual=Algebra.Palindrome(n);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void Not_Palindrometest()
        {
            //Arrange
            int n = 123;
            string expected = "Not Palindrome";

            //Act
            string actual = Algebra.Palindrome(n);

            //Assert
            Assert.AreEqual(expected,actual);   
        }

    }
}