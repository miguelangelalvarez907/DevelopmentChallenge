using DevelopmentChallenge.Data;
using DevelopmentChallenge.Data.Classes;
using DevelopmentChallenge.Data.Enums;
using DevelopmentChallenge.Data.Formas;
using DevelopmentChallenge.Data.Interfaces;
using System;
using System.Collections.Generic;

namespace DevelopmentChallenge.Main
{
  class Program
  {
    static void Main(string[] args)
    {

      Console.WriteLine("****************************************************");
      Console.WriteLine("Challenger By Miguel Angel Alvarez");
      Console.WriteLine("****************************************************");
      // Configurar el contenedor de dependencias para el idioma italiano
      var containerItaliano = Startup.ConfigureServices(LanguageEnum.Italiano);      
      var traductorItaliano = containerItaliano.Resolve<ITraductor>();

      // Configurar el contenedor de dependencias para el idioma español
      var containerEspanol = Startup.ConfigureServices(LanguageEnum.Español);
      var traductorEspanol = containerEspanol.Resolve<ITraductor>();

      // Configurar el contenedor de dependencias para el idioma español
      var containerIngles = Startup.ConfigureServices(LanguageEnum.Ingles);
      var traductorIngles = containerIngles.Resolve<ITraductor>();

      // Configurar el contenedor de dependencias para el idioma portugues
      var containerPortugues = Startup.ConfigureServices(LanguageEnum.Portugues);
      var traductorPortugues = containerPortugues.Resolve<ITraductor>();

      // Registrar el generador de reportes (que va a ser el mismo para todos idiomas)
      var generadorDeReportes = containerItaliano.Resolve<GeneradorDeReportes>();

      // Listado de formas geométricas
      var formas = new List<FormaGeometrica>  { new Rectangulo(3, 5), new Trapecio(20, 10, 5, 6, 7), new Circulo(5) };


      // Generar y mostrar el reporte en italiano
      string reporteItaliano = generadorDeReportes.Imprimir(formas, traductorItaliano);
      Console.WriteLine("Reporte en Italiano:");
      Console.WriteLine(reporteItaliano);
      Console.WriteLine("-----------------------------------------");
      Console.WriteLine("");

      // Generar y mostrar el reporte en español
      string reporteEspañol = generadorDeReportes.Imprimir(formas, traductorEspanol);
      Console.WriteLine("Reporte en Español:");
      Console.WriteLine(reporteEspañol);
      Console.WriteLine("-----------------------------------------");
      Console.WriteLine("");

      // Generar y mostrar el reporte en Ingles
      string reporteIngles = generadorDeReportes.Imprimir(formas, traductorIngles);
      Console.WriteLine("Reporte en Ingles:");
      Console.WriteLine(reporteIngles);
      Console.WriteLine("-----------------------------------------");
      Console.WriteLine("");

      // Generar y mostrar el reporte en Portugues
      string reportePortugues = generadorDeReportes.Imprimir(formas, traductorPortugues);
      Console.WriteLine("Reporte en Portugues:");
      Console.WriteLine(reportePortugues);
      Console.WriteLine("-----------------------------------------");
      Console.WriteLine("");
      Console.ReadLine();
    }
  }
}
