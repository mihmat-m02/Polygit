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
            Assert.AreEqual(2, affenn.Beine);
        }
        [TestMethod]
        [ExpectedException(typeof(TierException))]
        public void Exceptionn()
        {
            var affenn = new Affe("");
            
        }

        [TestMethod]
        public void istrueTEst()
        {
            var hund = new Hund("Marko");
            Assert.IsTrue(hund.Name == "Marko");
        }
        [TestMethod]
        public void IsInstanceOfTypeTEst()
        {
            var hund = new Hund("Marko");
            var affenn = new Affe("Marko");
            Assert.IsInstanceOfType(hund, typeof(Hund));
        }

    }
}
