using Destroyed.Pony.Domain.Tests.RatingTests.cs;

[TestMethod]
public void Can_Create_New_Item()
{
	var item = new Item(“Name”, “Description”, “Brand”, 10.00m);

	Assert.AreEqual(“Name”, item.Name);
	Assert.AreEqual(“Description”, item.Description);
	Assert.AreEqual(“Brand”, item.Brand);
	Assert.AreEqual(10.00m, item.Price);
}
