using DevelopmentChallenge.Data.Classes;
using DevelopmentChallenge.Data.Interfaces;

namespace DevelopmentChallenge.Data.Formas
{
  public class Trapecio : FormaGeometrica
  {
    private readonly decimal _baseMayor;
    private readonly decimal _baseMenor;
    private readonly decimal _altura;
    private readonly decimal _lado1;
    private readonly decimal _lado2;

    public Trapecio(decimal baseMayor, decimal baseMenor, decimal altura, decimal lado1, decimal lado2)
    {
      _baseMayor = baseMayor;
      _baseMenor = baseMenor;
      _altura = altura;
      _lado1 = lado1;
      _lado2 = lado2;
    }

    public override decimal CalcularArea()
    {
      return ((_baseMayor + _baseMenor) / 2) * _altura;
    }

    public override decimal CalcularPerimetro()
    {
      return _baseMayor + _baseMenor + _lado1 + _lado2;
    }

    public override string ObtenerNombre(int cantidad, ITraductor traductor)
    {
      return cantidad == 1 ? traductor.Traducir("Trapecio") : traductor.Traducir("Trapecios");
    }
  }
}
