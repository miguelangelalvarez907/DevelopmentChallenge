using DevelopmentChallenge.Data.Constants;
using DevelopmentChallenge.Data.Interfaces;

namespace DevelopmentChallenge.Data.Languages
{
  public class TraductorItaliano : ITraductor
  {
    public string Traducir(string clave)
    {
      switch (clave)
      {
        case ReporteConstantes.Titulo:
          return "Rapporto XShapes";
        case ReporteConstantes.ListaVacia:
          return "Lista vuota di forme!";
        case ReporteConstantes.Cuadrado:
          return "Quadrato";
        case ReporteConstantes.Cuadrados:
          return "Quadri";
        case ReporteConstantes.Circulo:
          return "Cerchio";
        case ReporteConstantes.Circulos:
          return "Cerchi";
        case ReporteConstantes.Triangulo:
          return "Triangolo";
        case ReporteConstantes.Triangulos:
          return "Triangoli";
        case ReporteConstantes.Trapecio:
          return "Trapezio";
        case ReporteConstantes.Trapecios:
          return "Trapezi";
        case ReporteConstantes.Rectangulo:
          return "Rettangolo";
        case ReporteConstantes.Rectangulos:
          return "Rettangoli";
        case ReporteConstantes.Formas:
          return "Forme";
        case ReporteConstantes.Perimetro:
          return "Perimetro";
        case ReporteConstantes.Area:
          return "Area";
        default:
          return clave;
      }
    }
  }
}