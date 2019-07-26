using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace TestRunnerCs
{
    class ITestRunner
    {
        public static void run()
        {
            ITestSuite.run();
        }
        public static void run(string cn)
        {
            ITestSuite.run(cn);
        }

    }
}
