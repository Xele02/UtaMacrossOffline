using XeSys.Gfx;
using System.Collections;
using System;
using UnityEngine;

namespace XeApp.Game.Title
{
	public class LayoutTitleLogo : LayoutUGUIScriptBase
	{
		private const float FADE_TIME = 0.3f;
		private AbsoluteLayout m_logoTbl; // 0x14
		private AbsoluteLayout m_root; // 0x18
		private int[] m_logoIndexArray; // 0x1C
		private float[] m_skipWaitArray; // 0x20
		private float[] m_waitArray; // 0x24
		private int m_visibleIndex; // 0x28
		private Coroutine m_logoCoroutine; // 0x2C

		public bool IsOpen { get; private set; } // 0x30
		public bool IsClose { get; private set; } // 0x31
		public bool IsSkip { get; private set; } // 0x32

		// // RVA: 0xE39A60 Offset: 0xE39A60 VA: 0xE39A60
		public void SetStatus()
		{
			UnityEngine.Debug.LogError("TODO");
		}

		// // RVA: 0xE39B60 Offset: 0xE39B60 VA: 0xE39B60
		// public void Reset() { }

		// // RVA: 0xE39B64 Offset: 0xE39B64 VA: 0xE39B64
		public void Update()
		{
			UnityEngine.Debug.LogError("TODO");
		}

		// // RVA: 0xE39AB4 Offset: 0xE39AB4 VA: 0xE39AB4
		// public void SwitchLogo(int index) { }

		// // RVA: 0xE39C3C Offset: 0xE39C3C VA: 0xE39C3C
		public void Show()
		{
			UnityEngine.Debug.LogError("TODO");
		}

		// // RVA: 0xE39DDC Offset: 0xE39DDC VA: 0xE39DDC
		public void Hide()
		{
			UnityEngine.Debug.LogError("TODO");
		}

		// [IteratorStateMachineAttribute] // RVA: 0x6B39F0 Offset: 0x6B39F0 VA: 0x6B39F0
		// // RVA: 0xE39D50 Offset: 0xE39D50 VA: 0xE39D50
		// private IEnumerator UpdateLogo() { }

		// // RVA: 0xE39B68 Offset: 0xE39B68 VA: 0xE39B68
		// private void Skip() { }

		// // RVA: 0xE39EA0 Offset: 0xE39EA0 VA: 0xE39EA0 Slot: 5
		// public override bool InitializeFromLayout(Layout layout, TexUVListManager uvMan) { }

		// // RVA: 0xE3A004 Offset: 0xE3A004 VA: 0xE3A004
		public LayoutTitleLogo()
		{
			UnityEngine.Debug.LogError("TODO");
		}
	}
}