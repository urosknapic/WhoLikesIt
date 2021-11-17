using Microsoft.VisualStudio.TestTools.UnitTesting;
using WhoLikesIt;

namespace WhoLikesIt_Tests
{
  [TestClass]
  public class KataTest
  {
    [TestMethod]
    public void Kata_WhenNoNames_ReturnNoOneLikesIt()
    {
      // Write just enough of code to pass it;
      // Arrange -> here we create data; Any setup we need
      string[] names = new string[] { };

      // Act - perform the work we want to do;. In this case I want to call method which process my names array
      string output = Kata.Likes(names);

      // Assert
      Assert.AreEqual(output, "no one likes this");
    }
  }
}
