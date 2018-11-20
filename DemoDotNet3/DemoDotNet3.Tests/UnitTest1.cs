using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DemoDotNet3.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            String password = "wood";
            ExternalClass1.doSomthing(password);
            
            ExternalLib.Class1.ExternalNet20(password);
            Console.Out.WriteLine(password);
        }
    }
}
