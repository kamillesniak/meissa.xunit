using System;
using System.IO;
using Meissa.xunit;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Meissa.XUnit.UnitTests
{
    [TestClass]
    public class XunitRunnerTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            
            var test = Directory.GetCurrentDirectory() + @"\Meissa.XUnit.SampleTests.dll";
            var runner = new NativeTestsRunnerTestCasesPluginService();
            runner.ExtractAllTestCasesFromTestLibrary(test);
            
        }
    }
}
