using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace TestRunnerCs
{
    public abstract class ITestFixture
    {
        public abstract void setUp() ;
        public abstract void tearDown();
        public MethodInfo[] getMethods()
        {
            return this.GetType().GetMethods(); 
        }

        public void run() 
        {
            MethodInfo[] mi =  GetType().GetMethods();
            for (int i = 0; i < mi.Length; i++)
            {
                if (mi[i].Name.StartsWith("test"))
                {
                    System.Console.WriteLine(mi[i].Name);
                    //object[] obj = new object[] { };
                    mi[i].Invoke(this, null);
                }
            }
        }
    }
}
