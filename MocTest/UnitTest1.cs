using Microsoft.VisualStudio.TestTools.UnitTesting;
using MockingTheCarTest;
using Moq;

namespace MocTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestEngine()
        {
            var vehicle = new Mock<Vehicle>();
            var engine = new Mock<Engine>();

        }
    }
}