using DevelopmentChallenge.Data.Languages;
using NUnit.Framework;

namespace DevelopmentChallenge.Tests.TraductoresTests
{
  [TestFixture]
  public class TraductorInglesTests
  {
    [Test]
    public void TestTraducirTitulo()
    {
      var traductor = new TraductorIngles();
      Assert.AreEqual("Shapes Report", traductor.Traducir("Titulo"));
    }

    [Test]
    public void TestTraducirListaVacia()
    {
      var traductor = new TraductorIngles();
      Assert.AreEqual("Empty list of shapes!", traductor.Traducir("ListaVacia"));
    }
  }
}