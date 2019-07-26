using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
namespace TestRunnerCs
{
    class Program
    {
        static void Main(string[] args)
        {
           
            ITestSuite.registerTest("TestCsDaf",new TestCsDaf());
            ITestRunner.run("TestCsDaf");
            string line=System.Console.In.ReadLine();
        } 
    }
}
