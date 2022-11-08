using UnityEngine;
using UnityEngine.UI;
using XeSys.Gfx;

namespace XeApp.Game.Common
{
	public class HomeSubMenuPassButton : HomeSubMenuButton
	{
		private void Awake()
		{
			UnityEngine.Debug.LogError("Implement monobehaviour");
		}
		[SerializeField]
		private SpriteAnime badgeAnim;
		[SerializeField]
		private Text textMessage;
		[SerializeField]
		private RawImageEx imageRareUpItem;
	}
}
