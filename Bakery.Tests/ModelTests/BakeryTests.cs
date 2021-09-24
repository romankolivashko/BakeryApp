using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Bakery;

namespace Bakery.Tests
{
  [TestClass]
  public class Tests
  {
    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
      Bread newBread = new Bread("rye");
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }
    
    [TestMethod]
    public void GetDescription_ReturnsDescription_Bread()
    {
      //Arrange
      string description = "wheat";
      Bread newBread = new Bread(description);

      //Act
      string result = newBread.Description;

      //Assert
      Assert.AreEqual(description, result);
    }

    [TestMethod]
    public void SetDescription_SetDescription_Bread()
    {
      //Arrange
      string description = "wheat";
      Bread newBread = new Bread(description);

      //Act
      string updatedDescription = "white";
      newBread.Description = updatedDescription;
      string result = newBread.Description;

      //Assert
      Assert.AreEqual(updatedDescription, result);
    }

    [TestMethod]
    public void GetAll_ReturnsBreadItems_BreadList()
    {
      //Arrange
      string description01 = "wheat";
      string description02 = "white";
      string description03 = "rye";
      Bread newBread1 = new Bread(description01);
      Bread newBread2 = new Bread(description02);
      Bread newBread3 = new Bread(description03);
      List<Bread> newList = new List<Bread> { newBread1, newBread2, newBread3 };

      //Act
      List<Bread> result = Bread.GetAll();

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }
    // [TestMethod]
    // public void NameOfMethodWeAreTesting_DescriptionOfBehavior_ExpectedReturnValue()t
    // {
    //   // any necessary logic to prep for test; instantiating new classes, etc.
    //   Assert.AreEqual(EXPECTED RESULT, CODE TO TEST);
    // }
  }
}