using System;
using System.Collections.Generic;

namespace DevelopmentChallenge.Main
{
  /// <summary>
  /// DependencyContainer actuá como un contenedor simple para registrar y resolver dependencias.
  /// Basicamente es el lugar donde se registran y resuelven las dependencias
  /// Patron utilizado Inyeccion de Dependencia (DI) en conjunto con singleton para mantener la instancia unioa de un objeto
  /// </summary>
  public class DependencyContainer
  {
    private readonly Dictionary<Type, Type> _registrations = new Dictionary<Type, Type>();
    private readonly Dictionary<Type, object> _instances = new Dictionary<Type, object>();

    public void Register<TInterface, TImplementation>()
        where TImplementation : TInterface
    {
      _registrations[typeof(TInterface)] = typeof(TImplementation);
    }

    public void RegisterSingleton<TInterface, TImplementation>()
        where TImplementation : TInterface
    {
      var instance = Activator.CreateInstance<TImplementation>();
      _instances[typeof(TInterface)] = instance;
    }

    public TInterface Resolve<TInterface>()
    {
      if (_instances.ContainsKey(typeof(TInterface)))
      {
        return (TInterface)_instances[typeof(TInterface)];
      }

      if (_registrations.ContainsKey(typeof(TInterface)))
      {
        var implementationType = _registrations[typeof(TInterface)];
        return (TInterface)Activator.CreateInstance(implementationType);
      }

      throw new InvalidOperationException($"No registration found for {typeof(TInterface)}");
    }
  }
}