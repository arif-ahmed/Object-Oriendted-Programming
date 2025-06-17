namespace IoC_Container_Demo.Refactored;

public class Resolver
{
    private readonly Dictionary<Type, Type> _dependencyMapping = new Dictionary<Type, Type>();

    public void Registery<TFrom, TTo>()
    {
        _dependencyMapping.Add(typeof(TFrom), typeof(TTo));
    }

    public void Registery<T>() where T : class
    {
        _dependencyMapping.Add(typeof(T), typeof(T));
    }

    public T Resolve<T>()
    {
        return (T)Resolve(typeof(T));
    }

    private object Resolve(Type typeNeedToResolve)
    {
        Type resolvedType;

        if (_dependencyMapping.ContainsKey(typeNeedToResolve))
        {
            resolvedType = _dependencyMapping[typeNeedToResolve];
        }
        else if (!typeNeedToResolve.IsAbstract)
        {
            resolvedType = typeNeedToResolve; // If not abstract, resolve directly
        }
        else
        {
            throw new Exception($"Resolve failed for {typeNeedToResolve.FullName}");
        }

        var constructor = resolvedType.GetConstructors().FirstOrDefault();
        if (constructor == null)
            throw new Exception($"No public constructor found for {resolvedType.FullName}");

        var parameters = constructor.GetParameters();

        if (!parameters.Any())
            return Activator.CreateInstance(resolvedType);

        var parameterInstances = parameters.Select(p => Resolve(p.ParameterType)).ToArray();
        return constructor.Invoke(parameterInstances);
    }
}

