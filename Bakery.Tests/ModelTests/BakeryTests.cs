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
      Bread newBread = new Bread(1, 0);
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }

    [TestMethod]
    public void PastryConstructor_CreatesInstanceOfPastry_Pastry()
    {
      Pastry newPastry = new Pastry(1, 0);
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }

    [TestMethod]
    public void GetBreadQuantity_ReturnsBreadQuantity_ReturnsInt()
    { 
      // Arrange
      int breadQuantity = 1;
      int breadCost = 5;
      Bread newBread = new Bread(breadQuantity, breadCost);
      
      //Act
      int result = newBread.BreadQuantity;

      //Assert
      Assert.AreEqual(breadQuantity, result);
    }

    [TestMethod]
    public void GetPastryQuantity_ReturnsPastryQuantity_ReturnsInt()
    { 
      // Arrange
      int pastryQuantity = 1;
      int pastryCost = 5;
      Pastry newPastry = new Pastry(pastryQuantity, pastryCost);
      
      //Act
      int result = newPastry.PastryQuantity;

      //Assert
      Assert.AreEqual(pastryQuantity, result);
    }

    // [TestMethod]
    // public void BreadConstructor_CreatesInstanceOfBread_Bread()
    // {
    //   int breadQuantity = 1;
    //   int breadCost = 5;
    //   Bread newBread = new Bread(breadQuantity, breadCost);
    //   Assert.AreEqual(typeof(Bread), newBread.GetType());
    // }

    // [TestMethod]
    // public void PastryConstructor_CreatesInstanceOfPastry_Pastry()
    // {
    //   Pastry newPastry = new Pastry(1, 0);
    //   Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    // }


    // [TestMethod]
    // public void NameOfMethodWeAreTesting_DescriptionOfBehavior_ExpectedReturnValue()t
    // {
    //   // any necessary logic to prep for test; instantiating new classes, etc.
    //   Assert.AreEqual(EXPECTED RESULT, CODE TO TEST);
    // }
  }
}