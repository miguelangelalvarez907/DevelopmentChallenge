using DevelopmentChallenge.Data.Constants;
using DevelopmentChallenge.Data.Interfaces;

namespace DevelopmentChallenge.Data.Languages
{
  public class TraductorPortugues : ITraductor
  {
    public string Traducir(string clave)
    {
      switch (clave)
      {
        case ReporteConstantes.Titulo:
          return "Relatório XShapes";
        case ReporteConstantes.ListaVacia:
          return "Lista vazia de formas!";
        case ReporteConstantes.Cuadrado:
          return "Quadrado";
        case ReporteConstantes.Cuadrados:
          return "Quadrados";
        case ReporteConstantes.Circulo:
          return "Círculo";
        case ReporteConstantes.Circulos:
          return "Círculos";
        case ReporteConstantes.Triangulo:
          return "Triângulo";
        case ReporteConstantes.Triangulos:
          return "Triângulos";
        case ReporteConstantes.Trapecio:
          return "Trapézio";
        case ReporteConstantes.Trapecios:
          return "Trapézios";
        case ReporteConstantes.Rectangulo:
          return "Retângulo";
        case ReporteConstantes.Rectangulos:
          return "Retângulos";
        case ReporteConstantes.Formas:
          return "Formas";
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