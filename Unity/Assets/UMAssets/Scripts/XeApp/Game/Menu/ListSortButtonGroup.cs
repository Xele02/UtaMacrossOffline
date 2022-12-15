using XeSys.Gfx;
using XeApp.Game.Common;
using UnityEngine;
using UnityEngine.Events;
using System.Collections.Generic;

namespace XeApp.Game.Menu
{
	public class ListSortButtonGroup : LayoutUGUIScriptBase
	{
		public enum SortOrder
		{
			Small = 0,
			Big = 1,
		}

		[SerializeField]
		private ActionButton m_sortListButton; // 0x14
		[SerializeField]
		private ActionButton m_sortUpDownChangeButton; // 0x18
		[SerializeField]
		private ActionButton m_limitOverListButton; // 0x1C
		[SerializeField]
		private ToggleButtonGroup m_toggleGroup; // 0x20
		[SerializeField]
		private ToggleButton[] m_bonusToggleButtons; // 0x24
		[SerializeField]
		private RawImageEx m_sortItemText; // 0x28
		[SerializeField]
		private RawImageEx m_updownText; // 0x2C
		[SerializeField]
		private ListSortEvent m_onListSortEvent; // 0x30
		[SerializeField]
		private UnityEvent m_onLimitOverListEvent; // 0x34
		[SerializeField]
		private PopupSortMenu.SortPlace m_sortPlace; // 0x38
		[SerializeField]
		private bool m_useSortFontExtendTexture; // 0x3C
		private ListSortButtonGroup.SortOrder m_sortOrder = SortOrder.Big; // 0x40
		private SortItem m_currentSortItem; // 0x44
		private TexUVList m_texUvList; // 0x48
		private TexUVList m_sortUvList; // 0x4C
		private TexUVList m_personalTexUvList; // 0x50
		private AbsoluteLayout m_animeLayout; // 0x54
		private int m_sortTblIndex; // 0x58
		private bool m_isBonus; // 0x5C
		private PopupFilterSort.Scene m_sceneType = PopupFilterSort.Scene.None; // 0x60
		private static readonly List<SortItem> DivaSortItem = new List<SortItem>() {
			SortItem.Total, SortItem.Soul, SortItem.Voice, SortItem.Charm, SortItem.Level, SortItem.Life, SortItem.Support, SortItem.Fold, SortItem.Luck
		}; // 0x0
		private static readonly List<SortItem> SceneSortItem = new List<SortItem>() {
			SortItem.Total, SortItem.Soul, SortItem.Voice, SortItem.Charm, SortItem.Get, SortItem.Rarity, SortItem.Level, SortItem.Life, SortItem.Support, 
			SortItem.Fold, SortItem.ActiveSkill, SortItem.LiveSkill, SortItem.Luck, SortItem.Episode, SortItem.SecretBoard, SortItem.LuckyLeaf
		}; // 0x4
		private static readonly List<SortItem> SceneGrowthSortItem = new List<SortItem>() {
			SortItem.Total, SortItem.Soul, SortItem.Voice, SortItem.Charm, SortItem.Get, SortItem.Rarity, SortItem.Level, SortItem.Life, SortItem.Support, 
			SortItem.Fold, SortItem.ActiveSkill, SortItem.LiveSkill, SortItem.Luck, SortItem.Episode, SortItem.SecretBoard, SortItem.LuckyLeaf
		}; // 0x8
		private static readonly List<SortItem> CostumeSortItem = new List<SortItem>() {
			SortItem.Total, SortItem.Soul, SortItem.Voice, SortItem.Charm, SortItem.Life, SortItem.Support, SortItem.Fold
		}; // 0xC
		private static readonly List<SortItem> AssistSortItem = new List<SortItem>() {
			SortItem.Total, SortItem.Soul, SortItem.Voice, SortItem.Charm, SortItem.Life, SortItem.Support, SortItem.Fold, SortItem.Luck, 
			SortItem.Level, SortItem.Rarity, SortItem.Episode, SortItem.LuckyLeaf
		}; // 0x10
		private static readonly List<SortItem>[] m_sortItemTbl = new List<SortItem>[6]
		{
			SceneSortItem, CostumeSortItem, DivaSortItem, SceneGrowthSortItem, AssistSortItem, null//??
		}; // 0x14
		private static readonly string[] m_orderTextureUvNameTable = new string[2] { "cmn_btn_orde_fnt_01", "cmn_btn_orde_fnt_02" }; // 0x18
 
		public static SortOrder DefaultSortOrder { get { return SortOrder.Big; } } //0x154163C
		public ListSortEvent OnListSortEvent { get { return m_onListSortEvent; } } //0x1541644
		// public UnityEvent OnLimitOverListEvent { get; } 0x154164C
		// public PopupSortMenu.SortPlace SortPlace { set; } 0x1541688
		public int SelectedDivaId { get; set; } // 0x64
		public int SelectedAttrId { get; set; } // 0x68

		// // RVA: 0x1541654 Offset: 0x1541654 VA: 0x1541654
		public void SetVisibleLimitOverListButton(bool visible)
		{
			m_limitOverListButton.Hidden = !visible;
		}

		// // RVA: 0x15416B0 Offset: 0x15416B0 VA: 0x15416B0 Slot: 5
		public override bool InitializeFromLayout(Layout layout, TexUVListManager uvMan)
		{
			m_sortUvList = uvMan.GetTexUVList(m_sortItemText.TextureName);
			m_texUvList = uvMan.GetTexUVList("cmn_tex_pack");
			m_personalTexUvList = uvMan.GetTexUVList("sel_card_pack");
			ClearLoadedCallback();
			m_sortListButton.AddOnClickCallback(OnShowSortList);
			m_sortUpDownChangeButton.AddOnClickCallback(OnChangeOrder);
			m_limitOverListButton.AddOnClickCallback(OnPopupLimitOverList);
			m_toggleGroup.OnSelectToggleButtonEvent.AddListener(OnSelectedToggleButton);
			SelectedDivaId = 0;
			SelectedAttrId = 0;
			m_animeLayout = layout.FindViewByExId("root_sel_card_btn_sw_sel_card_btn") as AbsoluteLayout;
			UpdateOrderFont();
			Loaded();
			return true;
		}

		// // RVA: 0x1541B70 Offset: 0x1541B70 VA: 0x1541B70
		// public void OnSortButton(PopupFilterSort.Scene sceneType) { }

		// // RVA: 0x1541C58 Offset: 0x1541C58 VA: 0x1541C58
		public void UpdateContent(SortItem item, ListSortButtonGroup.SortOrder order, bool isBonus, bool isBonusFilter)
		{
			m_sortOrder = order;
			m_currentSortItem = item;
			m_isBonus = isBonus;
			UpdateSortFont();
			UpdateOrderFont();
			m_toggleGroup.SelectGroupButton(m_isBonus ? 1 : 0);
			for(int i = 0; i < m_bonusToggleButtons.Length; i++)
			{
				m_bonusToggleButtons[i].Hidden = !isBonusFilter;
			}
		}

		// // RVA: 0x1541EDC Offset: 0x1541EDC VA: 0x1541EDC
		private void OnShowSortList()
		{
			TodoLogger.Log(0, "OnShowSortList");
		}

		// // RVA: 0x154221C Offset: 0x154221C VA: 0x154221C
		// private void OnShowFilterSortPopup() { }

		// // RVA: 0x154236C Offset: 0x154236C VA: 0x154236C
		// private void OnSendSortItem() { }

		// // RVA: 0x15425CC Offset: 0x15425CC VA: 0x15425CC
		private void OnChangeOrder()
		{
			TodoLogger.Log(0, "OnChangeOrder");
		}

		// // RVA: 0x15426CC Offset: 0x15426CC VA: 0x15426CC
		// private void OnBonusFilter(bool isToggle) { }

		// // RVA: 0x15427B8 Offset: 0x15427B8 VA: 0x15427B8
		private void OnSelectedToggleButton(int index)
		{
			TodoLogger.Log(0, "OnSelectedToggleButton");
		}

		// // RVA: 0x15427F0 Offset: 0x15427F0 VA: 0x15427F0
		private void OnPopupLimitOverList()
		{
			TodoLogger.Log(0, "OnPopupLimitOverList");
		}

		// // RVA: 0x154286C Offset: 0x154286C VA: 0x154286C
		public void Show()
		{
			m_animeLayout.StartChildrenAnimGoStop("st_wait", "st_stop");
		}

		// // RVA: 0x15428F8 Offset: 0x15428F8 VA: 0x15428F8
		public void Hide()
		{
			m_animeLayout.StartChildrenAnimGoStop("st_stop", "st_out");
		}

		// // RVA: 0x1542984 Offset: 0x1542984 VA: 0x1542984
		public bool IsPlaying()
		{
			return m_animeLayout.IsPlayingChildren();
		}

		// // RVA: 0x15429B0 Offset: 0x15429B0 VA: 0x15429B0
		// private void SetSortItem() { }

		// // RVA: 0x1541D34 Offset: 0x1541D34 VA: 0x1541D34
		private void UpdateSortFont()
		{
			m_sortItemText.uvRect = LayoutUGUIUtility.MakeUnityUVRect(m_sortUvList.GetUVData(m_sceneType == PopupFilterSort.Scene.SelectHomeBg ? SortMenuWindow.GetSortLabelUv(SortItem.Filter) : SortMenuWindow.GetSortLabelUv(m_currentSortItem)));
		}

		// // RVA: 0x1541A0C Offset: 0x1541A0C VA: 0x1541A0C
		private void UpdateOrderFont()
		{
			m_updownText.uvRect = LayoutUGUIUtility.MakeUnityUVRect(m_texUvList.GetUVData(m_orderTextureUvNameTable[(int)m_sortOrder]));
		}

		// [CompilerGeneratedAttribute] // RVA: 0x6E7CFC Offset: 0x6E7CFC VA: 0x6E7CFC
		// // RVA: 0x15439CC Offset: 0x15439CC VA: 0x15439CC
		// private void <OnShowSortList>b__48_0(PopupFilterSortUGUI content) { }

		// [CompilerGeneratedAttribute] // RVA: 0x6E7D0C Offset: 0x6E7D0C VA: 0x6E7D0C
		// // RVA: 0x1543B20 Offset: 0x1543B20 VA: 0x1543B20
		// private void <OnShowSortList>b__48_1(PopupFilterSortUGUI content) { }

		// [CompilerGeneratedAttribute] // RVA: 0x6E7D1C Offset: 0x6E7D1C VA: 0x6E7D1C
		// // RVA: 0x1543C74 Offset: 0x1543C74 VA: 0x1543C74
		// private void <OnShowSortList>b__48_2(PopupSortMenu content) { }

		// [CompilerGeneratedAttribute] // RVA: 0x6E7D2C Offset: 0x6E7D2C VA: 0x6E7D2C
		// // RVA: 0x1543ED8 Offset: 0x1543ED8 VA: 0x1543ED8
		// private void <OnShowFilterSortPopup>b__49_0(PopupFilterSort content) { }
	}
}