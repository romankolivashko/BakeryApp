using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class BakeryTests
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
      //int breadCost = 5;
      Bread newBread = new Bread(breadQuantity, 0);
      
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
      //int pastryCost = 5;
      Pastry newPastry = new Pastry(pastryQuantity, 0);
      
      //Act
      int result = newPastry.PastryQuantity;

      //Assert
      Assert.AreEqual(pastryQuantity, result);
    }

    
    [TestMethod]
    public void GetBreadCost_ReturnsBreadCost_ReturnsInt()
    { 
      // Arrange
      int breadCost = 5;
      Bread newBread = new Bread(0, breadCost);
      
      //Act
      int result = newBread.BreadCost;

      //Assert
      Assert.AreEqual(breadCost, result);
    }

    [TestMethod]
    public void GetPastryCost_ReturnsPastryCost_ReturnsInt()
    { 
      // Arrange
      int pastryCost = 2;
      Pastry newPastry = new Pastry(0, pastryCost);
      
      //Act
      int result = newPastry.PastryCost;

      //Assert
      Assert.AreEqual(pastryCost, result);
    }
  }
}