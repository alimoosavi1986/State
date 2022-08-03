using Microsoft.VisualStudio.TestTools.UnitTesting;
using State.Orders;
using System;

namespace StateTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void WaitingToSendStateTest()
        {
            Order order = new Order(new Waiting_to_SendState());
            string expected = string.Empty;
            string actual = string.Empty;

            expected = "Sefaresh Ersal Shod";
            actual = order.Send();
            Assert.AreEqual(expected, actual);

            expected = "Sefaresh tahvil Shod";
            actual = order.Delivered();
            Assert.AreEqual(expected, actual);

            expected = "Sefaresh tahvil shode ra nemitavan CANCEL kard";
            actual = order.Cancel();
            Assert.AreEqual(expected, actual);
        }


    }
}
