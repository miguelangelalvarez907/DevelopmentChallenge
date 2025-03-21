using DevelopmentChallenge.Data.Languages;
using NUnit.Framework;

namespace DevelopmentChallenge.Tests.TraductoresTests
{
  [TestFixture]
  public class TraductorPortuguesTests
  {
    [Test]
    public void TestTraducirTitulo()
    {
      var traductor = new TraductorPortugues();
      Assert.AreEqual("Relatório XShapes", traductor.Traducir("Titulo"));
    }

    [Test]
    public void TestTraducirListaVacia()
    {
      var traductor = new TraductorPortugues();
      Assert.AreEqual("Lista vazia de formas!", traductor.Traducir("ListaVacia"));
    }
  }
}