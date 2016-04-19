using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Uppgift;
using System.Text.RegularExpressions;

namespace UppgiftTest
{
    [TestClass]
    public class UnitTest1
    {
        private TestContext testContextInstance;
        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        
        [TestMethod]
        public void ConcatArrayWithSpace()
        {
            Uppgifter up = new Uppgifter();

            string[] str = new string[] { "String1", "String2", "String3" };


            var act = up.ConcatArrayWithSpace(str);
            Assert.IsInstanceOfType(act, typeof(string));
            TestContext.WriteLine(act);

        }
        [TestMethod]
        public void Capitalize()
        {
            Uppgifter up = new Uppgifter();

            string str = "test1 test2 test3.,:";


            var act = up.Capitalize(str);

            Regex number = new Regex(@"[0-9]+$");

            Assert.IsTrue(act.IsUpper() && act.Contains("_") && !act.Contains(" ") && !number.IsMatch(act));
            TestContext.WriteLine(act);

        }
        [TestMethod]
        public void UppercaseFirstEach()
        {
            Uppgifter up = new Uppgifter();

            string str = "test test test";

            var act = up.UppercaseFirstEach(str);

            Assert.IsTrue(act.IsUpper());
            TestContext.WriteLine(act);

        }
        [TestMethod]
        public void Avrage()
        {
            Uppgifter up = new Uppgifter();

            int tal1 = 8;

            int tal2 = 6;

            int avg = 7;

            var act = up.Average(tal1, tal2);
            Assert.AreEqual(act, avg, "result is not equal to expected value" + avg);
            TestContext.WriteLine(act.ToString());


        }


    }

    static class Extensions
    {
        public static bool IsUpper(this string value)
        {
            for (int i = 0; i < value.Length; i++)

                if (char.IsUpper(value[i]))

                    return true;

            return false;
        }
    }
}
