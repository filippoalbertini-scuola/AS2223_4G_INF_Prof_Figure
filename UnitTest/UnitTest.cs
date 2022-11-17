using Microsoft.VisualStudio.TestPlatform.TestHost;
using Library;

#pragma warning disable NUnit2005 // Consider using Assert.That(actual, Is.EqualTo(expected)) instead of Assert.AreEqual(expected, actual)
#pragma warning disable NUnit2007 // The actual value should not be a constant

namespace UnitTest
{
    public class Tests
    {
        // https://docs.microsoft.com/it-it/visualstudio/test/getting-started-with-unit-testing?view=vs-2019&tabs=dotnet%2Cmstest

        [SetUp]
        public void Setup()
        {

        }

        /// <summary>
        /// Test figura Quadrato
        /// </summary>
        [Test]
        public void Figure_Quadrato()
        {
            Quadrato q = new Quadrato(4);

            Assert.AreEqual(q.Area(), 16.0, 0, "Errore Area " + q.Nome);
            Assert.AreEqual(q.Perimetro(), 16.0, 0, "Errore Perimetro " + q.Nome);
        }

        /// <summary>
        /// Test figura Rettangolo
        /// </summary>
        [Test]
        public void Figure_Rettangolo()
        {
            Rettangolo r = new Rettangolo(4, 2);

            Assert.AreEqual(r.Area(), 8.0, 0, "Errore Area " + r.Nome);
            Assert.AreEqual(r.Perimetro(), 12.0, 0, "Errore Perimetro " + r.Nome);
        }

        /// <summary>
        /// Test figura Cerchio
        /// </summary>
        [Test]
        public void Figure_Cerchio()
        {
            Cerchio c = new Cerchio(4);

            Assert.AreEqual(c.Area(), 50.26, 0.5, "Errore Area " + c.Nome);
            Assert.AreEqual(c.Perimetro(), 25.13, 0.5, "Errore Perimetro " + c.Nome);
        }
    }
}