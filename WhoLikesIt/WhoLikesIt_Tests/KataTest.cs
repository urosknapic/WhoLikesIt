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
    [TestMethod]
    public void Kata_When1Name_ReturnNameLikesThis()
    {
      string[] names = new string[] { "Peter" };
      string output = Kata.Likes(names);
      Assert.AreEqual(output, "Peter likes this");
    }

    [TestMethod]
    public void Kata_When2Names_Return1And2LikeThis()
    {
      string[] names = new string[] { "Jacob", "Alex" };
      string output = Kata.Likes(names);
      Assert.AreEqual(output, "Jacob and Alex like this");
    }

    [TestMethod]
    public void Kata_When3Names_Return12And3LikeThis()
    {
      string[] names = new string[] { "Max", "John", "Mark" };
      string output = Kata.Likes(names);
      Assert.AreEqual(output, "Max, John and Mark like this");

      string[] secondNames = new string[] { "Uros", "Anja", "Mark" };
      string secondOutput = Kata.Likes(secondNames);
      Assert.AreEqual(secondOutput, "Uros, Anja and Mark like this");
    }
  }
}
