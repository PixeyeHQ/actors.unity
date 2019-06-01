//  Project : ecs.unity.structs
// Contacts : Pix - ask@pixeye.games

using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Pixeye.Framework
{
	sealed unsafe class ProcessorDebug : Processor, ITick, IReceive<SignalDebug>
	{

		static GameObject prefabEntityLabel = Box.Get<GameObject>("UI Debug Entity ID");

		public List<GameObject> objs = new List<GameObject>();
		public RectTransform rectTransform;

		public void Tick(float delta)
		{
		}

		public void HandleSignal(in SignalDebug arg)
		{
			if (SettingsEngine.DebugMode)
			{
				if (rectTransform == null)
				{
					var go     = new GameObject("Canvas Debug");
					var canvas = go.AddComponent<Canvas>();
					var scaler = go.AddComponent<CanvasScaler>();
					scaler.uiScaleMode = CanvasScaler.ScaleMode.ScaleWithScreenSize;
					scaler.screenMatchMode = CanvasScaler.ScreenMatchMode.MatchWidthOrHeight;

					scaler.matchWidthOrHeight = 0.6118785f;
					scaler.referenceResolution = new Vector2(12, 12);
					canvas.worldCamera = Camera.main;
					canvas.renderMode = RenderMode.ScreenSpaceCamera;
					canvas.planeDistance = 60;
					canvas.transform.SetParent(Camera.main.transform);

					rectTransform = go.GetComponent<RectTransform>();
				}
				rectTransform.gameObject.SetActive(true);

				for (int i = 0; i < Entity.Count; i++)
				{
					var tr = Entity.transforms[i];
					var t  = Obj.Spawn<TextMesh>(prefabEntityLabel, rectTransform.transform, tr.position, Quaternion.identity);
					t.text = $"Entity ID: {Entity.cache[i].id}";
					Vector2 screenP = RectTransformUtility.WorldToScreenPoint(null, tr.position + new Vector3(0, 0.6f, 0));
					var     source  = t.GetComponent<RectTransform>();
					source.anchorMin = new Vector2(0.5f, 0.5f);
					source.anchorMax = new Vector2(0.5f, 0.5f);
					source.anchoredPosition = screenP;
					source.sizeDelta = new Vector2(2.25f, 0.3f);
					objs.Add(t.gameObject);
				}
			}
			else
			{
				for (int i = 0; i < objs.Count; i++)
				{
					GameObject.Destroy(objs[i]);
				}
				objs.Clear();
				rectTransform.gameObject.SetActive(false);
			}

			Time.Default.timeScale = SettingsEngine.DebugMode ? 0 : 1f;
		}

		protected override void OnDispose()
		{
			if (Toolbox.applicationIsQuitting) return;

			for (int i = 0; i < objs.Count; i++)
			{
				GameObject.Destroy(objs[i]);
			}
			objs.Clear();

			rectTransform.Destroy();
			rectTransform = null;
		}

	}
}