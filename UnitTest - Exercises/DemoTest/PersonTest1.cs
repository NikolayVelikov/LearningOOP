using NUnit.Framework;
using System;
using UnitTest;

namespace DemoTest
{
    [TestFixture]
    public class PersonTest1
    {
        [Test]
        [TestCase("Ivan",45)]
        [TestCase("Gosho",25)]
        [TestCase("Govnar",30)]
        public void DoesWhatMyName(string name,int age)
        {
            //Arrange
            Person person = new Person(name, age);

            //Act
            string expectedResult = $"Lainar {name}";
            string actualResult = person.WhatsMyName();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
