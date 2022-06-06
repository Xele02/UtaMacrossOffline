using UnityEngine;
using UnityEngine.UI;
using System;

namespace XeSys.uGUI
{
	[RequireComponent(typeof(Image))]
	public class UGUIFader : MonoBehaviour
	{
		public Color startColor; // 0xC
		public Color endColor; // 0x1C
		public Color currentColor; // 0x2C
		public Action onFadeEndAction; // 0x3C
		private float mCurrentTime; // 0x40
		private float mTargetTime; // 0x44
		private Action mUpdate; // 0x48
		private Image mImage; // 0x4C

		// Properties
		public float currentTime { get; }
		public float targetTime { get; }
		public bool isFading { get; }

		// Methods

		// // RVA: 0x274AEB4 Offset: 0x274AEB4 VA: 0x274AEB4
		// public Image GetImage() { }

		// // RVA: 0x274AEBC Offset: 0x274AEBC VA: 0x274AEBC
		// public float get_currentTime() { }

		// // RVA: 0x274AEC4 Offset: 0x274AEC4 VA: 0x274AEC4
		// public float get_targetTime() { }

		// // RVA: 0x274AECC Offset: 0x274AECC VA: 0x274AECC
		// public bool get_isFading() { }

		// // RVA: 0x274AF64 Offset: 0x274AF64 VA: 0x274AF64
		// private void Awake() { }

		// // RVA: 0x274AFEC Offset: 0x274AFEC VA: 0x274AFEC
		// private void Update() { }

		// // RVA: 0x274B018 Offset: 0x274B018 VA: 0x274B018
		// private void UpdateIdle() { }

		// // RVA: 0x274B01C Offset: 0x274B01C VA: 0x274B01C
		// private void UpdateFade() { }

		// // RVA: 0x274B1D0 Offset: 0x274B1D0 VA: 0x274B1D0
		// public void Fade(float time, float targetAlpha) { }

		// // RVA: 0x274B210 Offset: 0x274B210 VA: 0x274B210
		// public void Fade(float time, Color end) { }

		// // RVA: 0x274B254 Offset: 0x274B254 VA: 0x274B254
		// public void Fade(float time, Color start, Color end) { }

		// // RVA: 0x274B4BC Offset: 0x274B4BC VA: 0x274B4BC
		// public void .ctor() { }
	}
}