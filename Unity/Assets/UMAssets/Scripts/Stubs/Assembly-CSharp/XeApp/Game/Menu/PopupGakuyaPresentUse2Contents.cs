using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine;
using XeApp.Game.Common;

namespace XeApp.Game.Menu
{
	public class PopupGakuyaPresentUse2Contents : UIBehaviour, IPopupContent
	{
		[SerializeField]
		private RawImage m_imagePresent;
		[SerializeField]
		private Text m_textMessage;
		[SerializeField]
		private Text m_useItemValText;
		[SerializeField]
		private Text m_cautionText;
		[SerializeField]
		private UGUIButton m_subButton;
		[SerializeField]
		private UGUIButton m_addButton;

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
	}
}
