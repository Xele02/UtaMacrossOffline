using XeApp.Game.Common;
using UnityEngine;
using XeSys.Gfx;
using UnityEngine.UI;

namespace XeApp.Game.Menu
{
	public class PopupFilterSortParts_FilterRarity : PopupFilterSortPartsBase
	{
		private void Awake()
		{
			UnityEngine.Debug.LogError("Implement monobehaviour");
		}
		[SerializeField]
		private ToggleButton[] m_btn;
		[SerializeField]
		private RawImageEx[] m_btn_image;
		[SerializeField]
		private Text[] m_btn_text;
	}
}
