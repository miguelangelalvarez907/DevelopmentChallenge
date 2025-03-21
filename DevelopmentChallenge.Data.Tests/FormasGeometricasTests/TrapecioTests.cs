using DevelopmentChallenge.Data.Formas;
using NUnit.Framework;

namespace DevelopmentChallenge.Tests.FormasGeometricasTests
{
  [TestFixture]
  public class TrapecioTests
  {
    [Test]
    public void TestCalcularArea()
    {
      var trapecio = new Trapecio(10, 5, 4, 3, 3);
      Assert.AreEqual(30m, trapecio.CalcularArea());
    }

    [Test]
    public void TestCalcularPerimetro()
    {
      var trapecio = new Trapecio(10, 5, 4, 3, 3);
      Assert.AreEqual(21m, trapecio.CalcularPerimetro());
    }
  }
}