using XeApp.Game.Common;
using UnityEngine;
using XeSys.Gfx;
using UnityEngine.UI;

namespace XeApp.Game.Menu
{
	public class PopupFilterSortUGUIParts_FilterSeries : PopupFilterSortUGUIPartsBase
	{
		private void Awake()
		{
			UnityEngine.Debug.LogError("Implement monobehaviour");
		}
		[SerializeField]
		private UGUIToggleButton[] m_btn;
		[SerializeField]
		private RawImageEx[] m_btn_image;
		[SerializeField]
		private Text[] m_btn_text;
	}
}
