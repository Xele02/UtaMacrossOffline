using UnityEngine;
using XeApp.Game.Common;

namespace XeApp.Game.Menu
{
	public class PopupDetailCostume : MonoBehaviour, IPopupContent
	{
		public Transform Parent => throw new System.NotImplementedException();

		public void CallOpenEnd()
		{
			throw new System.NotImplementedException();
		}

		public void Hide()
		{
			throw new System.NotImplementedException();
		}

		public void Initialize(PopupSetting setting, Vector2 size, PopupWindowControl control)
		{
			throw new System.NotImplementedException();
		}

		public bool IsReady()
		{
			throw new System.NotImplementedException();
		}

		public bool IsScrollable()
		{
			throw new System.NotImplementedException();
		}

		public void Show()
		{
			throw new System.NotImplementedException();
		}

		private void Awake()
		{
			UnityEngine.Debug.LogError("Implement Monobehaviour");
		}
	}
}
