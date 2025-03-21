using DevelopmentChallenge.Data.Constants;
using DevelopmentChallenge.Data.Interfaces;

namespace DevelopmentChallenge.Data.Languages
{
  public class TraductorIngles : ITraductor
  {
    public string Traducir(string clave)
    {
      switch (clave)
      {
        case ReporteConstantes.Titulo:
          return "Shapes Report";
        case ReporteConstantes.ListaVacia:
          return "Empty list of shapes!";
        case ReporteConstantes.Cuadrado:
          return "Square";
        case ReporteConstantes.Cuadrados:
          return "Squares";
        case ReporteConstantes.Circulo:
          return "Circle";
        case ReporteConstantes.Circulos:
          return "Circles";
        case ReporteConstantes.Triangulo:
          return "Triangle";
        case ReporteConstantes.Triangulos:
          return "Triangles";
        case ReporteConstantes.Trapecio:
          return "Trapezoid";
        case ReporteConstantes.Trapecios:
          return "Trapezoids";
        case ReporteConstantes.Rectangulo:
          return "Rectangle";
        case ReporteConstantes.Rectangulos:
          return "Rectangles";
        case ReporteConstantes.Formas:
          return "shapes";
        case ReporteConstantes.Perimetro:
          return "Perimeter";
        case ReporteConstantes.Area:
          return "Area";
        default:
          return clave;
      }
    }
  }
}