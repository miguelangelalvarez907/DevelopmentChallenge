using DevelopmentChallenge.Data;
using DevelopmentChallenge.Data.Enums;
using DevelopmentChallenge.Data.Interfaces;
using DevelopmentChallenge.Data.Languages;
using System;

namespace DevelopmentChallenge.Main
{
  public class Startup
  {
    /// <summary>
    /// Se aplica el patron Facty (patron fábrica)
    /// </summary>
    /// <param name="language"></param>
    /// <returns></returns>
    public static DependencyContainer ConfigureServices(LanguageEnum language)
    {
      var container = new DependencyContainer();

      // Registrar las dependencias
      // Configurar el traductor según el idioma seleccionado
      switch (language)
      {
        case LanguageEnum.Español:
          container.RegisterSingleton<ITraductor, TraductorEspanol>();
          break;
        case LanguageEnum.Ingles:
          container.RegisterSingleton<ITraductor, TraductorIngles>();
          break;
        case LanguageEnum.Italiano:
          container.RegisterSingleton<ITraductor, TraductorItaliano>();
          break;
        case LanguageEnum.Portugues:
          container.RegisterSingleton<ITraductor, TraductorPortugues>();
          break;
        default:
          throw new ArgumentException("Idioma no soportado");
      }


      container.Register<GeneradorDeReportes, GeneradorDeReportes>();

      return container;
    }
  }
}
