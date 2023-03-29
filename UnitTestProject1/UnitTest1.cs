using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;


namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        private const String Expected = "Hello World";
        [TestMethod]
        public void TestMethod1()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                ConsoleApp1.Program.Main();

                var result = sw.ToString().Trim();
                Assert.AreEqual(Expected, result);
            }
        }
    }
}
