using UnityEngine;
using UnityEngine.UI;
using System.Text;

namespace XeSys
{
	public class DebugFPS : MonoBehaviour
	{
		public static bool isDisable; // 0x0
		private const float UPDATE_INTERVAL = 0.5f;
		private float mLastInterval; // 0xC
		private int mFrames; // 0x10
		private float mFps; // 0x14
		private StringBuilder stringBuilder; // 0x18
		private static DebugFPS mInstance; // 0x4
		[SerializeField]
		private Text m_Label; // 0x1C
		[SerializeField]
		private RectTransform m_baseRect; // 0x20
		private bool isMeasureingAvg; // 0x24
		private double mTotalFps; // 0x28
		private int mAvgFpsCount; // 0x30
		public double avgFPS; // 0x38
		public double minFPS; // 0x40

		public static DebugFPS Instance { get { return mInstance; } } // 0x19316DC
		// public float fps { get; }

		// // RVA: 0x1931768 Offset: 0x1931768 VA: 0x1931768
		// public float get_fps() { }

		// // RVA: 0x1931770 Offset: 0x1931770 VA: 0x1931770
		public static GameObject Create(DebugFPS prefab)
		{
			UnityEngine.Debug.LogWarning("TODO DebugFPS.Create");
			return null;
		}

		// // RVA: 0x1931994 Offset: 0x1931994 VA: 0x1931994
		public DebugFPS()
		{
			UnityEngine.Debug.LogWarning("TODO DebugFPS");
		}

		// // RVA: 0x1931A48 Offset: 0x1931A48 VA: 0x1931A48
		private void Awake()
		{
			UnityEngine.Debug.LogError("TODO");
		}

		// // RVA: 0x1931ACC Offset: 0x1931ACC VA: 0x1931ACC
		private void Start()
		{
			UnityEngine.Debug.LogError("TODO");
		}

		// // RVA: 0x1931B64 Offset: 0x1931B64 VA: 0x1931B64
		private void Update()
		{
			UnityEngine.Debug.LogError("TODO");
		}

		// // RVA: 0x1931C18 Offset: 0x1931C18 VA: 0x1931C18
		// public void StartMeasureAvg() { }

		// // RVA: 0x1931C34 Offset: 0x1931C34 VA: 0x1931C34
		public void StopMeasureAvg()
		{
			UnityEngine.Debug.LogError("TODO");
		}

		// [ConditionalAttribute] // RVA: 0x690690 Offset: 0x690690 VA: 0x690690
		// // RVA: 0x1931C4C Offset: 0x1931C4C VA: 0x1931C4C
		// private void SetFontSize(int size) { }

		// [ConditionalAttribute] // RVA: 0x6906C4 Offset: 0x6906C4 VA: 0x6906C4
		// // RVA: 0x1931C80 Offset: 0x1931C80 VA: 0x1931C80
		// public void SetAnchorLL() { }

		// [ConditionalAttribute] // RVA: 0x6906F8 Offset: 0x6906F8 VA: 0x6906F8
		// // RVA: 0x1931C84 Offset: 0x1931C84 VA: 0x1931C84
		// public void SetAnchorLR() { }

		// [ConditionalAttribute] // RVA: 0x69072C Offset: 0x69072C VA: 0x69072C
		// // RVA: 0x1931C88 Offset: 0x1931C88 VA: 0x1931C88
		// public void SetAnchorUL() { }

		// [ConditionalAttribute] // RVA: 0x690760 Offset: 0x690760 VA: 0x690760
		// // RVA: 0x1931C8C Offset: 0x1931C8C VA: 0x1931C8C
		// public void SetAnchorUR() { }

		// [ConditionalAttribute] // RVA: 0x690794 Offset: 0x690794 VA: 0x690794
		// // RVA: 0x1931C90 Offset: 0x1931C90 VA: 0x1931C90
		// private void SetAnchor(float x, float y) { }
	}
}
