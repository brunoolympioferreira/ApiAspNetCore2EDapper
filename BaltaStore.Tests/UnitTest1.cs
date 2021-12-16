using BaltaStore.Domain.StoreContext.Entities;
using BaltaStore.Domain.StoreContext.ValueObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BaltaStore.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var name = new Name("André", "Baltieri");
            var document = new Document("12345678911");
            var email = new Email("hello@balta.io");
            var c = new Customer(name, document, email, "99856456");

            var mouse = new Product("Mouse", "Rato", "image.png", 59.90M, 10);
            var teclado = new Product("Teclado", "Teclado", "image.png", 859.90M, 10);
            var impressora = new Product("impressora", "impressora", "image.png", 159.90M, 10);
            var cadeira = new Product("Cadeira", "Cadeira", "image.png", 559.90M, 10);
            var order = new Order(c);
            order.AddItem(new OrderItem(mouse, 5));
            order.AddItem(new OrderItem(teclado, 5));
            order.AddItem(new OrderItem(cadeira, 5));
            order.AddItem(new OrderItem(impressora, 5));

            order.Place();
        }
    }
}
