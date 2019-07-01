using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace adressbook_web_tests
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]

        public void TestMethod1()
        {
            string[] s = new string[] { "test1",  "test2", "test3" , "test4" }; 

            foreach (string element in s)
            {
                System.Console.Out.Write(element + "\n");
            }
        }
    }
}
