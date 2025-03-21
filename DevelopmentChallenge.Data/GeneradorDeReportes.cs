using DevelopmentChallenge.Data.Classes;
using DevelopmentChallenge.Data.Constants;
using DevelopmentChallenge.Data.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DevelopmentChallenge.Data
{
  public class GeneradorDeReportes
  {
    public string Imprimir(List<FormaGeometrica> formas, ITraductor traductor)
    {
      var sb = new StringBuilder();

      if (!formas.Any())
      {
        sb.Append($"<h1>{traductor.Traducir(ReporteConstantes.ListaVacia)}</h1>");
      }
      else
      {
        sb.Append($"<h1>{traductor.Traducir(ReporteConstantes.Titulo)}</h1>");

        var resumen = formas
            .GroupBy(f => f.GetType())
            .Select(g => new
            {
              Tipo = g.Key,
              Cantidad = g.Count(),
              Area = g.Sum(f => f.CalcularArea()),
              Perimetro = g.Sum(f => f.CalcularPerimetro())
            });

        foreach (var item in resumen)
        {
          var forma = formas.First(f => f.GetType() == item.Tipo);

          sb.Append($"{item.Cantidad} {forma.ObtenerNombre(item.Cantidad, traductor)} | ");
          sb.Append($"{traductor.Traducir(ReporteConstantes.Area)} {item.Area:#.##} | ");
          sb.Append($"{traductor.Traducir(ReporteConstantes.Perimetro)} {item.Perimetro:#.##} <br/>");
        }

        // FOOTER
        sb.Append("TOTAL:<br/>");
        sb.Append($"{formas.Count} {traductor.Traducir(ReporteConstantes.Formas)} ");
        sb.Append($"{traductor.Traducir(ReporteConstantes.Perimetro)} {formas.Sum(f => f.CalcularPerimetro()):#.##} ");
        sb.Append($"{traductor.Traducir(ReporteConstantes.Area)} {formas.Sum(f => f.CalcularArea()):#.##}");
      }

      return sb.ToString();
    }
  }
}