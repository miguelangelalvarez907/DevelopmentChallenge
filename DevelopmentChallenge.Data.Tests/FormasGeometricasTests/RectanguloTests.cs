using DevelopmentChallenge.Data.Formas;
using NUnit.Framework;

namespace DevelopmentChallenge.Tests.FormasGeometricasTests
{
  [TestFixture]
  public class RectanguloTests
  {
    [Test]
    public void TestCalcularArea()
    {
      var rectangulo = new Rectangulo(5, 10);
      Assert.AreEqual(50m, rectangulo.CalcularArea());
    }

    [Test]
    public void TestCalcularPerimetro()
    {
      var rectangulo = new Rectangulo(5, 10);
      Assert.AreEqual(30m, rectangulo.CalcularPerimetro());
    }
  }
}