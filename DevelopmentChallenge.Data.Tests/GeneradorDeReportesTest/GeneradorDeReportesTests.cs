using DevelopmentChallenge.Data;
using DevelopmentChallenge.Data.Classes;
using DevelopmentChallenge.Data.Formas;
using DevelopmentChallenge.Data.Interfaces;
using DevelopmentChallenge.Data.Languages;
using NUnit.Framework;
using System.Collections.Generic;

namespace DevelopmentChallenge.Tests.GeneradorDeReportesTests
{
  [TestFixture]
  public class GeneradorDeReportesTests
  {
    [Test]
    public void TestImprimirListaVacia()
    {
      var traductor = new TraductorEspanol();
      var generador = new GeneradorDeReportes();
      var formas = new List<FormaGeometrica>();

      var resultado = generador.Imprimir(formas, traductor);

      Assert.AreEqual("<h1>Lista vacía de formas!</h1>", resultado);
    }

    [Test]
    public void TestImprimirConFormas()
    {
      var traductor = new TraductorEspanol();
      var generador = new GeneradorDeReportes();
      var formas = new List<FormaGeometrica>
            {
                new Circulo(5),
                new Rectangulo(5, 10),
                new Trapecio(10, 5, 4, 3, 3)
            };

      var resultado = generador.Imprimir(formas, traductor);

      Assert.IsTrue(resultado.Contains("Círculo"));
      Assert.IsTrue(resultado.Contains("Rectángulo"));
      Assert.IsTrue(resultado.Contains("Trapecio"));
    }
  }
}