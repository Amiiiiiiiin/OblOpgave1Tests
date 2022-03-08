using Microsoft.VisualStudio.TestTools.UnitTesting;
using OblOpgave1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OblOpgave1.Tests
{
    [TestClass]
    public class CarTests
    {
        [TestMethod]
        public void TestId()
        {
            Car car = new Car
            {
                Id = 1
            };
            //Kan også fx skrives som
            //Car car = new Car();
            //car.Id = 1;
            Assert.IsInstanceOfType(car.Id, typeof(int));
        }

        [TestMethod]
        public void TestModel()
        {
            Car car = new Car
            {
                Model = "Audi"
            };
            Assert.AreEqual("Audi", car.Model);
            
            Assert.ThrowsException<ArgumentOutOfRangeException>((() => car.Model = "BMW"));
        }

        [TestMethod]
        public void TestPrice()
        {
            Car car = new Car
            {
                Price = 200000
            };
            Assert.AreEqual(200000, car.Price);

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => car.Price = -1);
        }

        [TestMethod]
        public void TestLicensePlate()
        {
            Car car = new Car
            {
                LicensePlate = "ABC123"
            };
            Assert.AreEqual("ABC123", car.LicensePlate);

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => car.LicensePlate = "A");
        }
    }
}