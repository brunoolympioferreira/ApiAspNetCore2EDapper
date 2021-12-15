using BaltaStore.Domain.StoreContext.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BaltaStore.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var c = new Customer(
                "Bruno",
                "Ferreira",
                "36523698752",
                "bruno@gmail",
                "119985632",
                "Rua dos Patos,30");

            var order = new Order(c);
        }
    }
}
