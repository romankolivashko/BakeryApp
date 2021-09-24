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
      Bread newBread = new Bread("rye", 0, 3);
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

    // [TestMethod]
    // public void GetAll_ReturnsBreadItems_BreadList()
    // {
    //   //Arrange
    //   string description01 = "wheat";
    //   int quant01 = 0;
    //   int cost01 = 3;
    //   string description02 = "white";
    //   int quant02 = 0;
    //   int cost02 = 4;
    //   string description03 = "rye";
    //   int quant03 = 0;
    //   int cost03 = 5;
    //   Bread newBread1 = new Bread(description01, quant01, cost01);
    //   Bread newBread2 = new Bread(description02, quant02, cost02);
    //   Bread newBread3 = new Bread(description03, quant03, cost03);
    //   List<Bread> newList = new List<Bread> { newBread1, newBread2, newBread3 };

    //   //Act
    //   List<Bread> result = Bread.GetAllBread();

    //   //Assert
    //   CollectionAssert.AreEqual(newList, result);
    // }
    // [TestMethod]
    // public void NameOfMethodWeAreTesting_DescriptionOfBehavior_ExpectedReturnValue()t
    // {
    //   // any necessary logic to prep for test; instantiating new classes, etc.
    //   Assert.AreEqual(EXPECTED RESULT, CODE TO TEST);
    // }
  }
}