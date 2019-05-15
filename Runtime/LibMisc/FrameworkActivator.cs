//  Project : game.tuco
// Contacts : Pix - ask@pixeye.games

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;
using Pixeye.Framework;

namespace Pixeye.Source
{
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