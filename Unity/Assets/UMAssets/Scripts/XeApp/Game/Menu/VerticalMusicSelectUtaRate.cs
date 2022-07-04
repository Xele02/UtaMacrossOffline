using UnityEngine;
using TMPro;
using XeSys.Gfx;
using XeApp.Game.Common;

namespace XeApp.Game.Menu
{
	public class VerticalMusicSelectUtaRate : MonoBehaviour
	{
		// [HeaderAttribute] // RVA: 0x675BA0 Offset: 0x675BA0 VA: 0x675BA0
		[SerializeField]
		private TextMeshProUGUI m_textUtaRate; // 0xC
		// [HeaderAttribute] // RVA: 0x675BFC Offset: 0x675BFC VA: 0x675BFC
		[SerializeField]
		private RawImageEx m_utaRateIcon; // 0x10
		// [HeaderAttribute] // RVA: 0x675C58 Offset: 0x675C58 VA: 0x675C58
		[SerializeField]
		private UGUIButton m_utaRateButton; // 0x14
		[SerializeField]
		// [HeaderAttribute] // RVA: 0x675CC4 Offset: 0x675CC4 VA: 0x675CC4
		private InOutAnime m_inOut; // 0x18

		// public Action onClickButton { private get; set; } // 0x1C

		// // RVA: 0xADBDD4 Offset: 0xADBDD4 VA: 0xADBDD4
		private void Awake()
		{
			UnityEngine.Debug.LogError("TODO !!!");
		}

		// // RVA: 0xADB430 Offset: 0xADB430 VA: 0xADB430
		// public void SetUtaRateRating(int ratingValue) { }

		// // RVA: 0xADB2A0 Offset: 0xADB2A0 VA: 0xADB2A0
		// public void SetScoreRatingRank(HighScoreRatingRank.Type rank) { }

		// // RVA: 0xADBEA4 Offset: 0xADBEA4 VA: 0xADBEA4
		// public void Enter() { }

		// // RVA: 0xADBED4 Offset: 0xADBED4 VA: 0xADBED4
		// public void Leave() { }

		// // RVA: 0xADBF38 Offset: 0xADBF38 VA: 0xADBF38
		// public bool IsPlaying() { }

		// // RVA: 0xADBF64 Offset: 0xADBF64 VA: 0xADBF64
		// public void SetEnable(bool isEneble) { }

		// [CompilerGeneratedAttribute] // RVA: 0x6F7304 Offset: 0x6F7304 VA: 0x6F7304
		// // RVA: 0xADBFF0 Offset: 0xADBFF0 VA: 0xADBFF0
		// private void <Awake>b__8_0() { }
	}
}
