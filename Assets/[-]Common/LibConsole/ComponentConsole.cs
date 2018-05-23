/*===============================================================
Product:    Cryoshock
Developer:  Dimitry Pixeye - pixeye@hbrew.store
Company:    Homebrew - http://hbrew.store
Date:       27/01/2018 13:14
================================================================*/

using System;
using System.Collections;
using System.Text;
 
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Profiling;
using UnityEngine.UI;

                         
namespace Homebrew
{
	public class ComponentConsole : MonoBehaviour, ITick
	{
		public TMP_InputField fieldInput;
		public TMP_Text fieldOutput;
		public Scrollbar scrollbar;
		public TextMeshProUGUI labelDebug;

		private CanvasGroup canvasGroup;
		private float caretTimer;
		private ProcessingConsole processingConsole;
		private Vector2Int size;
		private string commandCached = string.Empty;

		private StringBuilder fStr = new StringBuilder(256);


		public void ActivateConsole(bool activating)
		{
			if (activating)
			{
				gameObject.SetActive(true);
				canvasGroup.alpha = 1;

				return;
			}

			canvasGroup.alpha = 0;
			gameObject.SetActive(false);
		}

		private void Awake()
		{
			processingConsole = Toolbox.Get<ProcessingConsole>();

			canvasGroup = GetComponent<CanvasGroup>();
			canvasGroup.alpha = 0;
		}

		private void Start()
		{
			transform.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, 0);
			AddMessage(
				"Welcome back, commander\nType <color=#00cc66>?</color> or <color=#00cc66>Help</color> to get list of commands");
		}

		private void OnEnable()
		{
			fieldInput.onSubmit.AddListener(AddToConsole);
			fieldInput.onValueChanged.AddListener(ChangeText);
			Toolbox.Get<ProcessingUpdate>().Add(this);

			Timer.Add(UnityEngine.Time.deltaTime, () => EventSystem.current.SetSelectedGameObject(fieldInput.gameObject));
			fieldInput.caretPosition = 1;
			tickDebug = 0.0f;
			RenderDebug();
			StartCoroutine(_ColorLine());
		}


		private void RenderDebug()
		{
			fStr.Length = 0;


			fStr
				.AppendFormat("Time : {0} ms  GPU memory : {1}  Sys Memory : {2}\n", Time.DeltaTime, SystemInfo.graphicsMemorySize,
					SystemInfo.systemMemorySize)
				.AppendFormat("TotalAllocatedMemory : {0}mb	TotalReservedMemory : {1}mb	TotalUnusedReservedMemory : {2}mb\n",
					Profiler.GetTotalAllocatedMemoryLong() / 1048576,
					Profiler.GetTotalReservedMemoryLong() / 1048576,
					Profiler.GetTotalUnusedReservedMemoryLong() / 1048576)
				.AppendFormat("Actors : {0}	Ticks : {1}", Toolbox.Get<ProcessingEntities>().listActors.Count,
					Toolbox.Get<ProcessingUpdate>().GetTicksCount());
			labelDebug.text = fStr.ToString();
		}


		private IEnumerator _ColorLine()
		{
			TMP_TextInfo textInfo = fieldInput.textComponent.textInfo;
			fieldInput.textComponent.ForceMeshUpdate();


			Color32[] newVertexColors;
			Color32 c0 = fieldInput.textComponent.color;
			fieldInput.textComponent.renderMode = TextRenderFlags.DontRender;
			yield return new WaitForSeconds(0.1f);
			while (true)
			{
				int characterCount = textInfo.characterCount;

				// If No Characters then just yield and wait for some text to be added
				if (characterCount == 0)
				{
					yield return new WaitForSeconds(0.25f);
					continue;
				}

				for (var i = 0; i < characterCount; i++)
				{
					if (!textInfo.characterInfo[i].isVisible) continue;
					var materialIndex = textInfo.characterInfo[i].materialReferenceIndex;
					newVertexColors = textInfo.meshInfo[materialIndex].colors32;
					var vertexIndex = textInfo.characterInfo[i].vertexIndex;
					if (i >= size.x && i <= size.y)
					{
						c0 = new Color32((byte) 0, (byte) 205, (byte) 100, 255);
					}
					else c0 = new Color32(255, 255, 255, 255);

					newVertexColors[vertexIndex + 0] = c0;
					newVertexColors[vertexIndex + 1] = c0;
					newVertexColors[vertexIndex + 2] = c0;
					newVertexColors[vertexIndex + 3] = c0;
				}

				fieldInput.textComponent.UpdateVertexData();
				if (Toolbox.isQuittingOrChangingScene()) yield break;
				yield return new WaitForSeconds(Time.DeltaTime);
			}
		}

		private void OnDisable()
		{
			if (Toolbox.isQuittingOrChangingScene()) return;


			Toolbox.Get<ProcessingUpdate>().Remove(this);


			fieldInput.text = string.Empty;
			fieldInput.onSubmit.RemoveListener(AddToConsole);
			fieldInput.onValueChanged.RemoveListener(ChangeText);
			if (EventSystem.current != null)
				EventSystem.current.SetSelectedGameObject(null);
		}


		private void AddMessage(string line)
		{
			if (line == String.Empty) return;
			fieldOutput.text += "-> " + line + "\n";
		}

		private void ChangeText(string line)
		{
			var firstWord = line.Split(' ')[0];
			var method = processingConsole.GetMethod(firstWord);
			if (method == null)
			{
				size = new Vector2Int(-1, -1);
			}
			else
			{
				size = new Vector2Int(0, firstWord.Length);
			}
		}

		private void AddToConsole(string line)
		{
			line = processingConsole.ParseCommand(line);

			fieldInput.ActivateInputField();
			scrollbar.value = 0;


			if (Input.GetKey(KeyCode.BackQuote)) return;

			if (line == string.Empty) return;
			commandCached = fieldInput.text;
			fieldInput.text = string.Empty;

			AddMessage(line);
		}


		private float tickDebug;

		public void Tick()
		{
			tickDebug += Time.DeltaTime;
			if (tickDebug > 1f)
			{
				tickDebug = 0.0f;
				RenderDebug();
			}


			caretTimer += Time.DeltaTime * 10;
			fieldInput.caretColor = Color.white * Mathf.Sin(caretTimer);


			if (!Input.GetKeyDown(KeyCode.UpArrow)) return;
			if (commandCached == string.Empty) return;

			fieldInput.text = commandCached;
			fieldInput.caretPosition = commandCached.Length;
			fieldInput.stringPosition = commandCached.Length;
		}
	}
}