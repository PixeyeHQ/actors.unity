//  Project  : ACTORS
//  Contacts : Pixeye - ask@pixeye.games

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;

namespace Pixeye.Framework
{
	public class ProcessorGroupAttributes
	{

	 

		public static void Setup(object b)
		{
			var type = b.GetType();
			var objectFields = type.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static);
			int length = objectFields.Length;

			var groupType = typeof(GroupCore);

			for (int i = 0; i < length; i++)
			{
				var myFieldInfo = objectFields[i];

				var bindAttribute = Attribute.GetCustomAttribute(myFieldInfo, typeof(BindAttribute)) as BindAttribute;
				if (bindAttribute != null)
				{
					var fType = myFieldInfo.FieldType;
					var hash = fType.GetHashCode();

					if (!DataSession.binds.TryGetValue(hash, out object o))
					{
//						if (!FrameworkActivator.activators.TryGetValue(hash, out ObjectActivator activator))
//						{
//							ConstructorInfo ctor = fType.GetConstructors().First();
//							activator = FrameworkActivator.GetActivator(ctor);
//							FrameworkActivator.activators.Add(hash, activator);
//						}
						o =  Activator.CreateInstance(fType);
						DataSession.binds.Add(hash, o);
					}

					myFieldInfo.SetValue(b, o);
				}
				else if (myFieldInfo.FieldType.IsSubclassOf(groupType))
				{
					var groupByAttribute =
							Attribute.GetCustomAttribute(myFieldInfo, typeof(GroupByAttribute)) as GroupByAttribute;
					var groupExcludeAttribute =
							Attribute.GetCustomAttribute(myFieldInfo, typeof(GroupExcludeAttribute)) as
									GroupExcludeAttribute;

					var excludeFilter = groupExcludeAttribute != null ? groupExcludeAttribute.filter : new int[0];
					var includeFilter = groupByAttribute != null ? groupByAttribute.filter : new int[0];

					var filter = new Composition();
					filter.tagsToExclude = excludeFilter;
					filter.tagsToInclude = includeFilter;

					myFieldInfo.SetValue(b, ProcessorGroups.SetupGroup(myFieldInfo.FieldType, filter));
				}
			}
		}

	}
	public delegate T ObjectActivator<T>(params object[] args);
	public delegate object ObjectActivator(params object[] args);
	public static class FrameworkActivator
	{

		public static Dictionary<int, ObjectActivator> activators = new Dictionary<int, ObjectActivator>(FastComparable.Default);

		public static ObjectActivator<T> GetActivator<T>
				(ConstructorInfo ctor)
		{
			ParameterInfo[] paramsInfo = ctor.GetParameters();

			ParameterExpression param =
					Expression.Parameter(typeof(object[]), "args");

			Expression[] argsExp =
					new Expression[paramsInfo.Length];

			for (int i = 0; i < paramsInfo.Length; i++)
			{
				Expression index = Expression.Constant(i);
				Type paramType = paramsInfo[i].ParameterType;

				Expression paramAccessorExp =
						Expression.ArrayIndex(param, index);

				Expression paramCastExp =
						Expression.Convert(paramAccessorExp, paramType);

				argsExp[i] = paramCastExp;
			}

			NewExpression newExp = Expression.New(ctor, argsExp);

			LambdaExpression lambda =
					Expression.Lambda(typeof(ObjectActivator<T>), newExp, param);

			ObjectActivator<T> compiled = lambda.Compile() as ObjectActivator<T>;
			return compiled;
		}

		public static ObjectActivator GetActivator
				(ConstructorInfo ctor)
		{
			ParameterInfo[] paramsInfo = ctor.GetParameters();

			ParameterExpression param =
					Expression.Parameter(typeof(object[]), "args");

			Expression[] argsExp =
					new Expression[paramsInfo.Length];

			for (int i = 0; i < paramsInfo.Length; i++)
			{
				Expression index = Expression.Constant(i);
				Type paramType = paramsInfo[i].ParameterType;

				Expression paramAccessorExp =
						Expression.ArrayIndex(param, index);

				Expression paramCastExp =
						Expression.Convert(paramAccessorExp, paramType);

				argsExp[i] = paramCastExp;
			}

			NewExpression newExp = Expression.New(ctor, argsExp);

			LambdaExpression lambda =
					Expression.Lambda(typeof(ObjectActivator), newExp, param);

			ObjectActivator compiled = lambda.Compile() as ObjectActivator;
			return compiled;
		}

	}
}