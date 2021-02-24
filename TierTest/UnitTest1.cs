using Microsoft.VisualStudio.TestTools.UnitTesting;
using Projekttyp1;

namespace TierTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AffeName()
        {
            var affenn = new Affe("Marko");
            Assert.AreEqual("Marko", affenn.Name);
        }
        [TestMethod]
        public void HundName()
        {
            var hund = new Hund("Marko");
            Assert.AreEqual("Marko", hund.Name);
        }
        [TestMethod]
        public void Beine()
        {
            var hund = new Hund("Marko");
            var affenn = new Affe("Marko");
            Assert.AreEqual(4, hund.Beine);
            Assert.AreEqual(2, affenn.Name);
        }
    }
}
