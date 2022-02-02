using System;
using System.Collections.Generic;
using System.Linq;

namespace MySimpleIOCContainer
{
    /// <summary>
    /// Our simple IoC container
    /// </summary>
    public class Resolver
    {
        //This is dictionary used to keep mapping between classes
        private readonly Dictionary<Type, Type> _dependencyMapping = new Dictionary<Type, Type>();


        /// <summary>
        /// return requested object with requested type
        /// </summary>
        /// <typeparam name="T">Takes type which need to resolved</typeparam>
        /// <returns></returns>
        public T Resolve<T>()
        {
            // cast object to resolved type
            return (T)Resolve(typeof(T));
        }


        /// <summary>
        /// This method takes the type which need to resolve and returns an object based on configuration
        /// </summary>
        /// <param name="typeNeedToResolve">takes type which need to resolve</param>
        /// <returns>return an object based on requested type</returns>
        private object Resolve(Type typeNeedToResolve)
        {
            Type resolvedType;
            try
            {
                //Taking resolved/return type from dictionary which was configured earlier by Register method
                resolvedType = _dependencyMapping[typeNeedToResolve];
            }
            catch
            {
                //If no mapping found between requested type and resolved type then it will through exception
                throw new Exception(string.Format("resolve failed for {0}", typeNeedToResolve.FullName));
            }

            //Getting first constructor of resolved type by reflection
            var firstConstructor = resolvedType.GetConstructors().First();

            //Getting first constructor's parameter by reflection
            var constructorParameters = firstConstructor.GetParameters();

            //if no parameter found then we dont need to think about other resolved type from the parameter
            if (!constructorParameters.Any())
                return Activator.CreateInstance(resolvedType); // returning an instance of resolved type

            //if our resolved type has constructor then again we have to resolve that types; 
            //so again we are calling our resolve method to resolve from constructor
            IList<object> parameterList = constructorParameters.Select(parameterToResolve => Resolve(parameterToResolve.ParameterType)).ToList();
            //invoking parameters to constructor
            return firstConstructor.Invoke(parameterList.ToArray());

        }


        /// <summary>
        /// This method is used  to store mapping between request type and return type
        /// If you request for IRepository then what implementation will be returned; you can configure it from here by writing
        /// Registery<IRepository, TextRepository>()
        /// That means when resolver request for IRepository then TextRepository will be returned
        /// </summary>
        /// <typeparam name="TFrom">Request Type</typeparam>
        /// <typeparam name="TTo">Return Type</typeparam>
        public void Registery<TFrom, TTo>()
        {
            _dependencyMapping.Add(typeof(TFrom), typeof(TTo));
        }
    }



  
}