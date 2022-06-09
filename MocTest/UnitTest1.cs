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

		}

		[TestMethod]
		public void AndreaTestEngine()
		{

			var vehicle = new Mock<Vehicle>();
			var engine = new Mock<Engine>();

			//engine.Setup(e => e.(1, "type", "amout")).Returns(false);
			//vehicle.Object.Validate("hi", "fuel", "amount");
		}

	}
}