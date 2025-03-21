using DevelopmentChallenge.Data.Formas;
using NUnit.Framework;
using System;

namespace DevelopmentChallenge.Tests.FormasGeometricasTests
{
  [TestFixture]
  public class CirculoTests
  {
    [Test]
    public void TestCalcularArea()
    {

      var circulo = new Circulo(5);  
      decimal areaRedondeada = Math.Round(circulo.CalcularArea(), 2); // Redondear a 2 decimales
      double areaEsperada = 78.54;

      Assert.AreEqual(areaEsperada, areaRedondeada);
    }

    [Test]
    public void TestCalcularPerimetro()
    {
      var circulo = new Circulo(5);      
      decimal perimetroRedondeado = Math.Round(circulo.CalcularPerimetro(), 2); // Redondear a 2 decimales
      Assert.AreEqual(31.42m, perimetroRedondeado);
    }
  }
}