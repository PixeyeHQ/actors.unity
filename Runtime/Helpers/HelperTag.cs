//  Project : ecs
// Contacts : Pix - ask@pixeye.games
// Author : Geobrain
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;
using System.Reflection;
using Unity.IL2CPP.CompilerServices;


namespace Pixeye.Framework
{
	[Il2CppSetOption(Option.NullChecks | Option.ArrayBoundsChecks | Option.DivideByZeroChecks, false)]
	public static class HelperTag
	{
		
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static Type GetTypeTag()
		{
			Type typeTag = default;
			var assemblies = AppDomain.CurrentDomain.GetAssemblies();
			var executing = Assembly.GetExecutingAssembly();
			for (int i = 0; i < assemblies.Length; i++)
			{
				var a = assemblies[i];
				if (a != executing)
				{
					var types = a.GetTypes();
					foreach (Type type in types)
					{
						if (typeof(ITag).IsAssignableFrom(type)) typeTag = type;
					}
				}
			}
			return typeTag;
		}
		
		
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static object GetFieldId(this string fieldName, Type typeTag)
		{
			object value;
			FieldInfo info = typeTag.GetField(fieldName, BindingFlags.Public | BindingFlags.Static);
			value = info.GetValue(null);

			return value;
		}


		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static List<string> GetMembersString()
		{
			Type typeTag = GetTypeTag();
			MemberInfo[] memberArray = typeTag.GetMembers();

			List<string> memberString = new List<string>();
			foreach (var member in memberArray)
			{
				if (member.DeclaringType.ToString() == typeTag.FullName)
				{
					memberString.Add(member.Name);
				}
			}

			return memberString;
		}


		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static string TagToName(in this int tag)
		{
			List<string> listTagName = GetMembersString();
			
			Type typeTag = GetTypeTag();

			for (int i = 1; i < listTagName.Count; i++)
			{
				int tagId = (int) GetFieldId(listTagName[i], typeTag);

				if (tag == tagId)
				{
					return listTagName[i];
				}
			}

			return default;
		}


		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void CheckDuplicateID()
		{
			List<string> listTagName = GetMembersString();
			List<int> listTagID = new List<int>();
			Type typeTag = GetTypeTag();

			for (int i = 1; i < listTagName.Count; i++)
			{
				int tagId = (int) GetFieldId(listTagName[i], typeTag);
				listTagID.Add(tagId);
			}

			var listDuplicateID = listTagID.GroupBy(x => x).Where(x => x.Count() != 1).Select(x => x.Key).ToList();

			if (listDuplicateID.Count != 0)
			{
				var listDuplicateName = new List<string>();
				for (int i = 1; i < listTagName.Count; i++)
				{
					int tagId = (int) GetFieldId(listTagName[i], typeTag);

					if (listDuplicateID.Any(t => t == tagId)) listDuplicateName.Add(listTagName[i]);

				}

				foreach (var v in listDuplicateName)
				{
					Debug.LogError($"TAG duplicate: {v} = {(int) GetFieldId(v, typeTag)}");
				}

			}

		}
	}
}
