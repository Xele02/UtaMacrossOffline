using System.Collections.Generic;

namespace XeApp.Game.Common
{
	public class BonusData
	{
		private List<IKDICBBFBMI_EventBase.GNPOABJANKO> effectiveEpisodeBonus = new List<IKDICBBFBMI_EventBase.GNPOABJANKO>(); // 0x8

		public List<IKDICBBFBMI_EventBase.GNPOABJANKO> EffectiveEpisodeBonus { get { return effectiveEpisodeBonus; } } //0xE636F8

		// // RVA: 0xE63700 Offset: 0xE63700 VA: 0xE63700
		public void ClearEpisodeBonus()
		{
			effectiveEpisodeBonus.Clear();
		}

		// // RVA: 0xE63778 Offset: 0xE63778 VA: 0xE63778
		// public void SetEpisodeBonus(List<IKDICBBFBMI.GNPOABJANKO> bonusEpisodeList) { }
	}
}
