using NUnit.Framework;

using System;



namespace dealershippractice.Domain.Tests
{
    [TestFixture]
    public class CarTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ToString_ValidData_Success()
        {

            //arrange
            var car = new Car(1, 2, "BMW-iX", 2021, 1.2, "blue", 1200000.00);

            // act
            var result = car.ToString();

            //Assert
            Assert.AreEqual("BMW-iX blue 2021  1200000", result);

        }

        [Test]
        public void Ctor_WrongData_Empty_Model_Fail()
        {
            var car = new Car(1, 2, "", 2021, 1.2, null, 1200000.00);
            Assert.IsEmpty(car.model);
            Assert.IsNull(car.color);

        }

        [Test]
        public void Ctor_WrongData_Null_Color_Fail()
        {
            var car = new Car(1, 2, "BMW-iX", 2021, 1.2, null, 1200000.00);
            Assert.IsNull(car.color);

        }

    }


}