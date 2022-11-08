using XeApp.Game.Common;
using UnityEngine;
using UnityEngine.UI;
using XeSys.Gfx;

namespace XeApp.Game.Menu
{
	public class LayoutSNSRoomItem : LayoutSNSBase
	{
		private void Awake()
		{
			UnityEngine.Debug.LogError("Implement monobehaviour");
		}
		[SerializeField]
		private ActionButton m_button;
		[SerializeField]
		private Text m_roomName;
		[SerializeField]
		private RawImageEx m_roomImage;
	}
}
