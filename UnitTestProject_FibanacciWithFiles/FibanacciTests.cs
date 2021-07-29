using Microsoft.VisualStudio.TestTools.UnitTesting;
using static ConsoleApp_FibonacciWithFiles.Fibanacci;
using System;

namespace UnitTestProject_FibanacciWithFiles
{
    [TestClass]
    public class FibanacciTests
    {
        [TestMethod]
        public void NumberFromString_oak123String_ReturnedInt123()
        {
            Assert.AreEqual(NumberFromString("oak 123"), 123);
        }
        [TestMethod]
        public void NumberFromString_pushString_ReturnedInt0() 
        {
            Assert.AreEqual(NumberFromString("push"), 0);
        }
        [TestMethod]
        public void IsFibanacci_Number8_ReturnedTrue()
        {
            Assert.AreEqual(IsFibanacci(8),true);
        }
        [TestMethod]
        public void IsFibanacci_Number12_ReturnedFalse()
        {
            Assert.AreEqual(IsFibanacci(12), false);
        }
        [TestMethod]
        public void ReverseString_row1_Returned1row() 
        {
            Assert.AreEqual(ReverseString("row1"),"1wor");
        }
        [TestMethod]
        public void ReverseString_null_ReturnedNull()
        {
            Assert.AreEqual(ReverseString(string.Empty), string.Empty);
        }
    }
}
