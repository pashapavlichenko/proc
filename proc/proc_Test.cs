using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data;

namespace ProcA.Tests
{
    [TestClass]
    public class ProcTests
    {
        [TestMethod]
        public void Proc30_1234and3_2()
        {
            int expected = 2;
            int k = 1234, n = 3;

            ProcTasks c = new ProcTasks();
            int actual = c.Proc30(k, n);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Proc34_12345_12624120()
        {
            double[] expected = { 1, 2, 6, 24, 120 };
            double[] a = { 1, 2, 3, 4, 5 };

            for (int i = 0; i < 5; i++)
            {

                ProcTasks c = new ProcTasks();
                double actual = c.Proc34(a[i]);

                Assert.AreEqual(expected[i], actual);

            }
        }
    }
}