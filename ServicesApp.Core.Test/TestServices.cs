using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ServicesApp.Core.Test
{
    [TestClass]
    public class TestServices
    {
        [TestMethod]
        public void ServicesTest()
        {
            Services services = new Services("WRARE Talintz, Creative Support");
            Assert.AreEqual("WRARE Talintz, Creative Support", services.Name, services.Type);
        }
    }
}
