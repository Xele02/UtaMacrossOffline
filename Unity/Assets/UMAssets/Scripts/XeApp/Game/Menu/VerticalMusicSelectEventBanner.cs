using UnityEngine;
using XeApp.Game.Common;
using UnityEngine.UI;
using TMPro;
using System;

namespace XeApp.Game.Menu
{
	public class VerticalMusicSelectEventBanner : MonoBehaviour
	{
		[SerializeField]
		private CanvasGroup m_canvasGroup; // 0xC
		[SerializeField]
		private UGUIButton m_uGUIButton; // 0x10
		[SerializeField]
		private InOutAnime m_inOut; // 0x14
		[SerializeField]
		private RawImage m_eventBunnerImage; // 0x18
		[SerializeField]
		private GameObject m_countingObj; // 0x1C
		[SerializeField]
		private GameObject m_openObj; // 0x20
		[SerializeField]
		private TextMeshProUGUI m_limitTime; // 0x24
		[SerializeField]
		private InOutAnime m_pullDownInOut; // 0x28
		[SerializeField]
		private UGUIButton m_pullDownButton; // 0x2C
		private string m_musicEventRemainPrefix = ""; // 0x30
		private string m_musicEventRemainTime = ""; // 0x34

		public Action OnButtonClickListener { private get; set; } // 0x38

		// // RVA: 0xBDD228 Offset: 0xBDD228 VA: 0xBDD228
		private void Awake()
		{
			m_uGUIButton.ClearOnClickCallback();
			m_uGUIButton.AddOnClickCallback(() =>
			{
				//0xBDDA8C
				if (OnButtonClickListener != null)
					OnButtonClickListener();
			});
			m_pullDownButton.ClearOnClickCallback();
			m_pullDownButton.AddOnClickCallback(() =>
			{
				//0xBDDAA0
				SoundManager.Instance.sePlayerBoot.Play(3);
				if (m_pullDownInOut.IsEnter)
					m_pullDownInOut.Leave(false);
				else
					m_pullDownInOut.Enter(false);
			});
		}

		// // RVA: 0xBDD36C Offset: 0xBDD36C VA: 0xBDD36C
		private void ApplyRemainTime()
		{
			m_limitTime.text = m_musicEventRemainPrefix + m_musicEventRemainTime;
		}

		// // RVA: 0xBDD3B4 Offset: 0xBDD3B4 VA: 0xBDD3B4
		public void ChangeEventBanner(int eventId)
		{
			m_uGUIButton.Hidden = true;
			if (eventId == 0)
				return;
			GameManager.Instance.EventBannerTextureCache.LoadBanner(eventId, (IiconTexture image) =>
			{
				//0xBDDB58
				m_uGUIButton.Hidden = false;
				image.Set(m_eventBunnerImage);
			});
		}

		// // RVA: 0xBDD4F0 Offset: 0xBDD4F0 VA: 0xBDD4F0
		public void SetMusicEventRemainPrefix(string text)
		{
			m_musicEventRemainPrefix = text;
			ApplyRemainTime();
		}

		// // RVA: 0xBDD4F8 Offset: 0xBDD4F8 VA: 0xBDD4F8
		// public void SetLimitTimeLabel(string label) { }

		// // RVA: 0xBDD500 Offset: 0xBDD500 VA: 0xBDD500
		// public void SetType(VerticalMusicSelectEventBanner.ButtonType type) { }

		// // RVA: 0xBDD8A8 Offset: 0xBDD8A8 VA: 0xBDD8A8
		// public void SetTicketCount(int count) { }

		// // RVA: 0xBDD8AC Offset: 0xBDD8AC VA: 0xBDD8AC
		public void Enter()
		{
			m_inOut.ForceEnter(null);
		}

		// // RVA: 0xBDD8DC Offset: 0xBDD8DC VA: 0xBDD8DC
		// public void Leave() { }

		// // RVA: 0xBDD90C Offset: 0xBDD90C VA: 0xBDD90C
		public bool IsPlaying()
		{
			return m_inOut.IsPlaying();
		}

		// // RVA: 0xBDD938 Offset: 0xBDD938 VA: 0xBDD938
		// public void Show() { }

		// // RVA: 0xBDD968 Offset: 0xBDD968 VA: 0xBDD968
		// public void Hide() { }

		// // RVA: 0xBDD998 Offset: 0xBDD998 VA: 0xBDD998
		// public void SetEnable(bool isEneble) { }
	}
}
