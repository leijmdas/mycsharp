using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Reflection;

namespace TestRunnerCs
{
    
    public class ITestSuite
    {
        public static Hashtable  getHashtable()
        {
            return hashtable;
        }
        static System.Collections.Hashtable  hashtable = new Hashtable ();

        public static void run(ITestFixture tf)
        {
            run(tf.ToString());
        }

        public static void run(string tfname)
        {
            //System.Console.WriteLine(tfname);
            foreach (string str in hashtable.Keys)
            {
                ITestFixture tf = (ITestFixture)hashtable[str];
                //System.Console.WriteLine(tf.GetType().Name);
                if (tf.GetType().Name.Equals(tfname))
                {
                    tf.run();
                }

            }
        }

        public static void run()
        {
            foreach (string str in hashtable.Keys)
            {
                ITestFixture tf = (ITestFixture)hashtable[str]; 
                tf.run();
                
            }
        }

        public static void registerTest(string key,ITestFixture tf)
        {
            hashtable.Add(key,tf);
        }

        
    }
}
