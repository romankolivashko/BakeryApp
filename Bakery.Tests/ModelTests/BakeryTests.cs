using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery;

namespace Bakery.Tests
{
  [TestClass]
  public class Tests
  {
    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
      Bread newBread = new Bread("test");
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }
    
    

    // [TestMethod]
    // public void NameOfMethodWeAreTesting_DescriptionOfBehavior_ExpectedReturnValue()t
    // {
    //   // any necessary logic to prep for test; instantiating new classes, etc.
    //   Assert.AreEqual(EXPECTED RESULT, CODE TO TEST);
    // }
  }
}