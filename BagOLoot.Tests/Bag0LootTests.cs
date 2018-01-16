using System;
using System.Collections.Generic;
using Xunit;

namespace BagOLoot.Tests
{
    public class BagShould
    {
        [Fact]
            public void AddChildToRegister()
            {
                Child suzie = new Child();
                suzie.FirstName = "Laura";
                suzie.LastName = "McDonald";
                suzie.Address = "123 Main St. USA";

                ChildRegister childRegister = new ChildRegister();
                childRegister.AddChild(suzie);

                Assert.Contains(suzie, childRegister.GetRegister());
            }

        [Fact]
        public void AddPresent()
        {
            Present bike = new Present();
            bike.Name = "Bike";

            Child bobby = new Child();
            bobby.FirstName = "Bobby";
            bobby.LastName = "Tables";
            bobby.Address = "1000 Infinity Loop";

            bike.Child = bobby;

            Bag bag = new Bag();
            bag.AddPresent(bike);

            Assert.Contains(bike, bag.GetContents());
        }

        [Fact]
        public void RemovePresent()
        {
            Present bike = new Present();
            bike.Name = "Bike";

            Child bobby = new Child();
            bobby.FirstName = "Bobby";
            bobby.LastName = "Tables";
            bobby.Address = "1000 Infinity Loop";

            bike.Child = bobby;

            Bag bag = new Bag();
            bag.AddPresent(bike);
            bag.RemovePresent(bike);

            Assert.DoesNotContain(bike, bag.GetContents());
        }

        [Fact]
        public void DeliverPresent()
        {
            Present bike = new Present();
            bike.Name = "Bike";

            Child bobby = new Child();
            bobby.FirstName = "Bobby";
            bobby.LastName = "Tables";
            bobby.Address = "1000 Infinity Loop";

            bike.Child = bobby;

            Bag bag = new Bag();
            bag.AddPresent(bike);
            bag.DeliverPresent(bike);

            Assert.True(bike.Delivered);
            Assert.DoesNotContain(bike, bag.GetContents());
        }
    }
}
