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



/*
 * Andrea testing notes

public void TestEngine()
{
	// need to see if the Engine starts
	// Test constructor function for Vehicle(Engine)
	// Calls bool::Start()
	// Does Start(return true)
}


[TestMethod]
public void TestMethod1()
{

	var person = new Mock<Person>();
	person.Setup(p => p.Validate(
		 It.IsAny<string>(),
		 21,
		 It.IsAny<string>())).Returns(false);
	Assert.IsFalse(
		 person.Object.Validate("Jordan", 21, "Russia"));

}

*/
