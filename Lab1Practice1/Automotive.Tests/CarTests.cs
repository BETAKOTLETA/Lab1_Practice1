using FluentAssertions;
using System;

namespace Automotive.Tests
{
    public class CarTests
    {
        //[Theory]
        //[InlineData("Toyota", 200, 4)]
        //[InlineData("Honda", 300, 6)]
        //[InlineData("Ferrari", 175, 10)]

        [Theory]
        [InlineData("Toyota", 200, 4, "Toyota", 200, 4)]
        [InlineData("Honda", 300, 6, "Honda", 300, 6)]
        [InlineData("Ferrari", 175, 10, "Ferrari", 175, 10)]

        // exbrand, means expected brand, extankCapacity, means expected tank capacity, etc...
        public void Car_can_be_created(string brand, int tankCapacity, int fuelConsumptionPer100km, string exbrand, int extankCapacity, int exfuelConsumptionPer100km)
        {
            var Testcar = new Car(brand, tankCapacity, fuelConsumptionPer100km);

            Testcar.Should().BeOfType<Car>();
            Testcar.Brand.Should().Be(exbrand);
            Testcar.TankCapacity.Should().Be(extankCapacity);
            Testcar.FuelConsumptionPer100Km.Should().Be(exfuelConsumptionPer100km);            
        }
        [Theory]
        [InlineData("", 200, 4)]
        [InlineData(null, 300, 6)]
        [InlineData("", 175, 10)]

        public void Car_cannot_created_with_invalid_brand(string brand, int tankCapacity, int fuelConsumptionPer100km)
        {
            Assert.Throws<ArgumentException>(() => new Car(brand, tankCapacity, fuelConsumptionPer100km));
        }

        [Theory]
        [InlineData("Toyota", -10, 4)]
        [InlineData("Honda",0, 6)]
        [InlineData("Ferrari", -1, 10)]

        public void Car_cannot_created_with_invalid_tank_capacity(string brand, int tankCapacity, int fuelConsumptionPer100km)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Car(brand, tankCapacity, fuelConsumptionPer100km));
        }


        [Theory]
        [InlineData("Toyota", 200, 0)]
        [InlineData("Honda", 300, -6)]
        [InlineData("Ferrari", 175, -10)]

        public void Car_cannot_be_created_with_invalid_fuel_consumption_per_100km(string brand, int tankCapacity, int fuelConsumptionPer100km)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Car(brand, tankCapacity, fuelConsumptionPer100km));
        }

        [Theory]
        [InlineData(100, 100)]
        [InlineData(50, 50)]
        [InlineData(250, 200)]

        public void Car_can_be_refueled(int amount, int exfuelLevel)
        {
            var Testcar = new Car("Toyota", 200, 4);
            Testcar.Refuel(amount);
            Testcar.CurrentFuelLevel.Should().Be(exfuelLevel);
        }

        [Theory]
        [InlineData(200, 100)]
        [InlineData(400, 0)]
        [InlineData(500, 0)]

        public void Fuel_level_should_be_properly_updated(int kilometers, int expected)
        {
            var Testcar = new Car("Toyota", 200, 50);
            Testcar.Refuel(200);
            Testcar.Drive(kilometers);
            Testcar.CurrentFuelLevel.Should().Be(expected);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-50)]
        [InlineData(-100)]

        public void Car_cannot_be_refueled_with_invalid_amount(int amount)
        {
            var Testcar = new Car("Toyota", 200, 4);
            Assert.Throws<ArgumentOutOfRangeException>(() => Testcar.Refuel(amount));
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-50)]

        public void Car_cannot_be_driven_with_invalid_distance(int kilometers)
        {
            var Testcar = new Car("Toyota", 200, 4);
            Testcar.Refuel(200);
            Assert.Throws<ArgumentOutOfRangeException>(() => Testcar.Drive(kilometers));
        }

        [Theory]
        [InlineData(50, 50)]
        [InlineData(100, 100)]
        [InlineData(500, 400)]

        public void Odometer_should_return_proper_value(int distance, int expected)
        {
            var Testcar = new Car("Toyota", 200, 50);
            Testcar.Refuel(200);
            Testcar.Drive(distance);
            Testcar.Odometer.Should().Be(expected);
        }

        [Fact]
        public void Odometer_can_be_reset()
        {
            var Testcar = new Car("Toyota", 200, 50);
            Testcar.Refuel(200);
            Testcar.Drive(100);
            Testcar.ResetTripOdometer();
            Testcar.TripOdometer.Should().Be(0);
        }

        [Theory]
        [InlineData(50, 50)]
        [InlineData(100, 100)]
        [InlineData(500, 400)]

        public void DailyOdometer_should_return_proper_value(int distance, int expected)
        {
            var Testcar = new Car("Toyota", 200, 50);
            Testcar.Refuel(200);
            Testcar.Drive(distance);
            Testcar.TripOdometer.Should().Be(expected);
        }


    }
}