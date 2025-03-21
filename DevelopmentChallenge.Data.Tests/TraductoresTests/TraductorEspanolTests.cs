using DevelopmentChallenge.Data.Languages;
using NUnit.Framework;

namespace DevelopmentChallenge.Tests.TraductoresTests
{
  [TestFixture]
  public class TraductorEspanolTests
  {
    [Test]
    public void TestTraducirTitulo()
    {
      var traductor = new TraductorEspanol();
      Assert.AreEqual("Reporte de Formas", traductor.Traducir("Titulo"));
    }

    [Test]
    public void TestTraducirListaVacia()
    {
      var traductor = new TraductorEspanol();
      Assert.AreEqual("Lista vacía de formas!", traductor.Traducir("ListaVacia"));
    }
  }
}