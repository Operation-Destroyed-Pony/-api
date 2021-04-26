using Destroyed.Pony.Domain.Catalog;
using Destroyed.Pony.Domain.Tests;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Destroyed.Pony.Domain.Tests
{
    [TestClass]
    public class ItemTests
    {
        [TestMethod]
        public void Can_Create_New_Item()
        {
            var item = new Item("Name", "Description", "Brand","/images/d1.jpg", 10.00m);

            Assert.AreEqual("Name", item.Name);
            Assert.AreEqual("Description", item.Description);
            Assert.AreEqual("Brand", item.Brand);
            Assert.AreEqual(10.00m, item.Price);
        }

        [TestMethod]
        public void Can_Create_Add_Rating()
        {

            // Arrange
            var item = new Item("Name", "Description", "Brand","/images/d1.jpg", 10.00m);
            var rating = new Rating(5, "Name", "Review");

            //Act
            item.AddRating(rating);

            //Assert
            Assert.AreEqual(rating, item.Ratings[0]);
        }


    }

}