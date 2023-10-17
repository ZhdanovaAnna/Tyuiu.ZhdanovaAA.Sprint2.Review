using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ZhdanovaAA.Sprint2.TaskReview.V5.Lib;

namespace Tyuiu.ZhdanovaAA.Sprint2.TaskReview.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDot()
        {
            DataService ds = new DataService();

            double x = -0.5, y = 0.5;
            Assert.AreEqual(true, ds.CheckDot(x, y));

            x = 0.5; y = -0.5;
            Assert.AreEqual(false, ds.CheckDot(x, y));
        }
    }
}
 