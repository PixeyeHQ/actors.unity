/*===============================================================
Product:    Cryoshock
Developer:  Dimitry Pixeye - pixeye@hbrew.store
Company:    Homebrew - http://hbrew.store
Date:       27/01/2018 10:57
================================================================*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using UnityEngine;

namespace Homebrew
{
	public class ProcessingConsole : ITick, IDisposable, IKernel
	{
		private CommandsConsole commands;
		private ComponentConsole console;

		private bool isConsoleOpen;

		private string cachedHelp = string.Empty;
		private Dictionary<string, MethodInfo> cachedMethods = new Dictionary<string, MethodInfo>();


		public void Setup(CommandsConsole commands)
		{
			if (commands == null || this.commands != null) return;
			this.commands = commands;
			GetMethods(this.commands);
		}


		public void GetMethods(CommandsConsole commands)
		{
			var methods = commands.GetType()
				.GetMethods()
				.Where(m => m.GetCustomAttributes(typeof(BindAttribute), false).Length > 0).ToArray();
			var message = string.Empty;
			for (var i = 0; i < methods.Length; i++)
			{
				var method = methods[i];
				cachedMethods.Add(method.Name, method);
				var _params = method.GetParameters();
				if (method.Name == "Help") continue;
				message += "\n-> <b>" + method.Name + "</b><i>";

				for (var j = 0; j < _params.Length; j++)
				{
					message += " <color=#555555>(" + _params[j].ParameterType.Name + ")</color><color=#858585> " +
					           _params[j].Name + "</color>";
				}

				message += "</i>";
			}

			cachedHelp = message;
		}


		public void Tick()
		{
			//TODO: Add connection to any control libs such as rewired
			if (!Input.GetKeyDown(KeyCode.BackQuote)) return;
			isConsoleOpen = !isConsoleOpen;
			if (isConsoleOpen)
				ConsoleOpen();
			else
				ConsoleClose();
		}

		public string Help()
		{
			return cachedHelp;
		}

		public string ParseCommand(string line)
		{
			if (line == string.Empty) return "";
			if (line == "?") return Help();
			var processings = line.Split(' ');
			var method = GetMethod(processings[0]);
			if (method == null)
			{
				return ReturnLog(processings[0], ConsoleMessage.ERROR);
			}

			var _params = method.GetParameters();

			if (processings.Length - 1 != _params.Length)
			{
				return ReturnLog(processings[0], ConsoleMessage.INVALID);
			}

			var _paramsValues = new object[_params.Length];

			for (var i = 0; i < _params.Length; i++)
			{
				if (_params[i].ParameterType == typeof(Int32))
				{
					int val;
					if (Int32.TryParse(processings[i + 1], out val))
						_paramsValues[i] = val;
					else return ReturnLog(processings[0], ConsoleMessage.INVALID);
				}
				else if (_params[i].ParameterType == typeof(Single))
				{
					float val;
					if (Single.TryParse(processings[i + 1], out val))
						_paramsValues[i] = val;
					else return ReturnLog(processings[0], ConsoleMessage.INVALID);
				}
				else
					_paramsValues[i] = processings[i + 1];
			}

			var callBack = method.Invoke(commands, _paramsValues);
			return callBack != null
				? ReturnLog(processings[0], ConsoleMessage.SUCCESS) + "\n" + callBack
				: ReturnLog(processings[0], ConsoleMessage.SUCCESS);
		}


		public MethodInfo GetMethod(string name)
		{
			MethodInfo m;
			cachedMethods.TryGetValue(name, out m);
			return m;
		}


		string ReturnLog(string message, ConsoleMessage messageType)
		{
			var messageFinal = message;

			switch (messageType)
			{
				case ConsoleMessage.ERROR:
					messageFinal = "<color=red>" + message + "</color> is not recognized as command";
					break;


				case ConsoleMessage.INVALID:
					messageFinal = "<color=orange>" + message + "</color> invalid input values";
					break;

				case ConsoleMessage.SUCCESS:
					messageFinal = "<color=#00cc66>" + message + "</color> executed!";
					break;
			}

			return messageFinal;
		}

		void ConsoleClose()
		{
			console.ActivateConsole(false);
		}

		void ConsoleOpen()
		{
			if (console == null)
			{
				console = this.Populate<ComponentConsole>(Pool.None, "prefab_console", "[UI]/Screen");
				console.name = "ui_console";
				console.gameObject.SetActive(false);
			}

			console.ActivateConsole(true);
		}

		public void Dispose()
		{
			isConsoleOpen = false;
		}
	}


	public enum ConsoleMessage
	{
		ERROR,
		INVALID,
		SUCCESS
	}
}