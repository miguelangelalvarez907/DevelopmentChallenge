using DevelopmentChallenge.Data.Classes;
using DevelopmentChallenge.Data.Constants;
using DevelopmentChallenge.Data.Formas;
using DevelopmentChallenge.Data.Interfaces;
using DevelopmentChallenge.Data.Languages;
using Microsoft.SqlServer.Server;
using Moq;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace DevelopmentChallenge.Data.Tests
{
  [TestFixture]
  public class DataTests
  {
    private readonly Mock<ITraductor> traductorMock = new Mock<ITraductor>();
    private readonly GeneradorDeReportes generador = null;

    public DataTests()
    {
      generador = new GeneradorDeReportes();
      traductorMock.Setup(t => t.Traducir(ReporteConstantes.ListaVacia))
           .Returns("Lista vacía de formas!");

      traductorMock.Setup(t => t.Traducir(ReporteConstantes.Titulo))
           .Returns("Reporte de Formas");
    }

    [TestCase]
    public void TestImprimir_SeLlamaATraducirListaVacia()
    {
      var resultado = generador.Imprimir(new List<FormaGeometrica>(), traductorMock.Object);

      Assert.AreEqual("<h1>Lista vacía de formas!</h1>", resultado);
    }

    [TestCase]
    public void TestImprimir_SeLlamaUnaVezAResumenTituloSiFormasTieneValores()
    {
      var formaMock = new Mock<FormaGeometrica>();
      var formas = new List<FormaGeometrica>() { formaMock.Object };
            
      generador.Imprimir(formas, traductorMock.Object);

      traductorMock.Verify(t => t.Traducir(ReporteConstantes.Titulo), Times.AtLeastOnce);
    }

    //MAA - Y así con cada línea ****** dentro del metodo imprimir************************
    //MAA - Hago funcionar estos metodo preexistente y cierro el challenger***************

    [TestCase]
    public void TestResumenListaVaciaFormasEnIngles()
    {
      Mock<TraductorIngles> traductorInglesMock = new Mock<TraductorIngles>();    

      var resultado = generador.Imprimir(new List<FormaGeometrica>(), traductorInglesMock.Object);
      Assert.AreEqual("<h1>Empty list of shapes!</h1>", resultado);
    }
    //MAA - Hice hasta aquí, no puedo dedicarle mas tiempo

  }
}
