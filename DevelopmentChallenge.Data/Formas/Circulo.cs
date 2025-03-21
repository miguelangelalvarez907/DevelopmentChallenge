using DevelopmentChallenge.Data.Classes;
using DevelopmentChallenge.Data.Interfaces;
using System;

namespace DevelopmentChallenge.Data.Formas
{
  public class Circulo : FormaGeometrica
  {
    private readonly decimal _radio;

    public Circulo(decimal radio)
    {
      _radio = radio;
    }

    public override decimal CalcularArea()
    {
      return (decimal)Math.PI * _radio * _radio;
    }

    public override decimal CalcularPerimetro()
    {
      return (decimal)Math.PI * 2 * _radio;
    }

    public override string ObtenerNombre(int cantidad, ITraductor traductor)
    {
      return cantidad == 1 ? traductor.Traducir("Circulo") : traductor.Traducir("Circulos");
    }
  }
}
