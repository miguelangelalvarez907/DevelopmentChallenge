using DevelopmentChallenge.Data.Constants;
using DevelopmentChallenge.Data.Interfaces;

namespace DevelopmentChallenge.Data.Languages
{
  public class TraductorEspanol : ITraductor
  {
    public string Traducir(string clave)
    {
      switch (clave)
      {
        case ReporteConstantes.Titulo:
          return "Reporte de Formas";
        case ReporteConstantes.ListaVacia:
          return "Lista vacía de formas!";
        case ReporteConstantes.Cuadrado:
          return "Cuadrado";
        case ReporteConstantes.Cuadrados:
          return "Cuadrados";
        case ReporteConstantes.Circulo:
          return "Círculo";
        case ReporteConstantes.Circulos:
          return "Círculos";
        case ReporteConstantes.Triangulo:
          return "Triángulo";
        case ReporteConstantes.Triangulos:
          return "Triángulos";
        case ReporteConstantes.Trapecio:
          return "Trapecio";
        case ReporteConstantes.Trapecios:
          return "Trapecios";
        case ReporteConstantes.Rectangulo:
          return "Rectángulo";
        case ReporteConstantes.Rectangulos:
          return "Rectángulos";
        case ReporteConstantes.Formas:
          return "formas";
        case ReporteConstantes.Perimetro:
          return "Perímetro";
        case ReporteConstantes.Area:
          return "Área";
        default:
          return clave;
      }
    }
  }
}