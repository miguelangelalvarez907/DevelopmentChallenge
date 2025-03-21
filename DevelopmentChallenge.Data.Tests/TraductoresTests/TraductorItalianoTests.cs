using DevelopmentChallenge.Data.Languages;
using NUnit.Framework;

namespace DevelopmentChallenge.Tests.TraductoresTests
{
  [TestFixture]
  public class TraductorItalianoTests
  {
    [Test]
    public void TestTraducirTitulo()
    {
      var traductor = new TraductorItaliano();
      Assert.AreEqual("Rapporto XShapes", traductor.Traducir("Titulo"));
    }

    [Test]
    public void TestTraducirListaVacia()
    {
      var traductor = new TraductorItaliano();
      Assert.AreEqual("Lista vuota di forme!", traductor.Traducir("ListaVacia"));
    }
  }
}