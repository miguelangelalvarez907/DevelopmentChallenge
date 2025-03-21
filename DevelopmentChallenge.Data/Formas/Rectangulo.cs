using DevelopmentChallenge.Data.Classes;
using DevelopmentChallenge.Data.Interfaces;

namespace DevelopmentChallenge.Data.Formas
{
  public class Rectangulo : FormaGeometrica
  {
    private readonly decimal _ancho;
    private readonly decimal _alto;

    public Rectangulo(decimal ancho, decimal alto)
    {
      _ancho = ancho;
      _alto = alto;
    }

    public override decimal CalcularArea()
    {
      return _ancho * _alto;
    }

    public override decimal CalcularPerimetro()
    {
      return 2 * (_ancho + _alto);
    }

    public override string ObtenerNombre(int cantidad, ITraductor traductor)
    {
      return cantidad == 1 ? traductor.Traducir("Rectangulo") : traductor.Traducir("Rectangulos");
    }
  }
}
