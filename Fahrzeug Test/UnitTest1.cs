using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pos_Project1;

namespace Pos_Project1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void TestMethod1()
        {
            Person p = new Person("sadasd", "Mayer", "6988", "Herr", "Straße xx");
            p.Nachname = null;
        }

        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void TestMethod2()
        {
            Person p = new Person("sadasd", "Mayer", "6988", "Herr", "Straße xx");
            p.Vorname = null;
        }

        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void TestMethod3()
        {
            Mitarbeiter p = new Mitarbeiter("sadasd", "Mayer", "6988", "Herr", "Straße xx", "LKWs", 5000);
            p.Gehalt = -5;

        }

    }
}
