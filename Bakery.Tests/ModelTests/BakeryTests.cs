using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class Tests
  {
    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
      //int quantInputB = 1;
      Bread newBread = new Bread();
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }
    
    [TestMethod]
    public void GetDescription_ReturnsDescription_Bread()
    {
      //Arrange
      string description = "wheat";
      Bread newBread = new Bread(description, 0, 4);

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
      Bread newBread = new Bread(description, 0, 4);

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

      //Act
      List<Bread> result = Bread.GetAllBread();

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void NameOfMethodWeAreTesting_DescriptionOfBehavior_ExpectedReturnValue()t
    {
      // any necessary logic to prep for test; instantiating new classes, etc.
      Assert.AreEqual(EXPECTED RESULT, CODE TO TEST);
    }
  }
}