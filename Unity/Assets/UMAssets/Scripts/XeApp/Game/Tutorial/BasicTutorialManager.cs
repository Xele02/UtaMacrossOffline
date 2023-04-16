using XeSys;
using UnityEngine;
using System.Text;
using System;
using XeApp.Game.Adv;
using System.Collections.Generic;
using XeApp.Game.Common;
using UnityEngine.Events;
using System.Collections;
using XeApp.Core;
using XeApp.Game.Menu;

namespace XeApp.Game.Tutorial
{
	public enum BasicTutorialMessageId
	{
		Id_BeginAdjust = 1,
		Id_ConfirmAdjust = 25,
		Id_EndAdjust = 2,
		Id_StartGame = 3,
		Id_ManualEnd = 24,
		Id_FailedGame = 4,
		Id_GachaList = 5,
		Id_GachaMain = 6,
		Id_GachaResult = 7,
		Id_GachaEnd = 8,
		Id_Setting = 9,
		Id_PlateSelect = 10,
		Id_PlateSelected = 11,
		Id_SnsStart = 12,
		Id_RoomSelected = 13,
		Id_Sns1 = 14,
		Id_DivaSelect = 16,
		Id_DecideDiva = 26,
		Id_StartMission1 = 20,
		Id_StartMission2 = 21,
		Id_Mission = 22,
		Id_ClearMission = 23,
		Id_EpisodeMission1 = 27,
		Id_EpisodeMission2 = 28,
		Id_EpisodeMission3 = 29,
		Id_GameResult = 55,
		Id_StartMission3 = 60,
		Id_UnitAutoSetting1 = 65,
		Id_UnitAutoSetting2 = 66,
		Id_LiveClear1 = 70,
		Id_LiveClear2 = 71,
		Id_MusicOpen = 75,
		Id_SceneGrowth = 80,
		Id_DivaSelect1 = 85,
		Id_DivaSelect2 = 86,
		Id_AssistSelect = 90,
		Id_OfferRelease = 91,
		Id_OfferOrder = 92,
		Id_OfferPlatoon = 93,
		Id_OfferTransFrom = 94,
		Id_CostumeUpgradeHome = 95,
		Id_CostumeUpgradeMenu = 96,
		Id_CostumeUpgradeSelect = 97,
		Id_BingoMission = 98,
		Id_ValkyrieUpgradeHome = 99,
		Id_ValkyrieUpgradeMenu = 100,
		Id_McrsLobby = 101,
		Id_Decolture = 102,
		Id_RaidFromMcrsLobby = 103,
		Id_RaidUseFoldRadar1 = 104,
		Id_RaidUseFoldRadar2 = 105,
		Id_Unit5Help1 = 106,
		Id_Unit5Help2 = 107,
	}
	public class BasicTutorialManager : SingletonBehaviour<BasicTutorialManager>
	{
		private GameObject m_blackImageInstance; // 0xC
		private TutorialHighLight m_highLight; // 0x10
		private GameObject m_cursorInstance; // 0x14
		private TutorialPointer m_pointer; // 0x18
		private List<ButtonBase> m_buttonList = new List<ButtonBase>(); // 0x1C
		private StringBuilder m_strBuilder = new StringBuilder(10); // 0x20
		private TutorialMessageWindow m_messageWindow; // 0x24
		private int[,] m_charaTextRowColCountTable = new int[2, 3]
		{
			{8, 17, 11},
			{21, 18, 30}
		}; // 0x28

		// // RVA: 0xE3D1B0 Offset: 0xE3D1B0 VA: 0xE3D1B0
		// public bool IsLoadedLayout() { }

		// // RVA: 0xE3D23C Offset: 0xE3D23C VA: 0xE3D23C
		public static void Initialize()
		{
			BasicTutorialManager bt = GameManager.Instance.gameObject.GetComponent<BasicTutorialManager>();
			if(GameManager.Instance != null && bt == null)
			{
				bt = GameManager.Instance.gameObject.AddComponent<BasicTutorialManager>();
			}
		}

		// // RVA: 0xE3D3E8 Offset: 0xE3D3E8 VA: 0xE3D3E8
		public void PreLoadResource(UnityAction finishCb, bool isAppendLayout = true)
		{
			this.StartCoroutineWatched(PreLoadLayoutCoroutine(finishCb, isAppendLayout));
		}

		// [IteratorStateMachineAttribute] // RVA: 0x6AE360 Offset: 0x6AE360 VA: 0x6AE360
		// // RVA: 0xE3D4CC Offset: 0xE3D4CC VA: 0xE3D4CC
		public IEnumerator PreDownLoadTextureResource(BasicTutorialMessageId id)
		{
			//0xE43BCC
			ILLPGHGGKLL_TutorialMiniAdv.AFBMNDPOALE t = IMMAOANGPNK.HHCJCDFCLOB.NKEBMCIMJND_Database.LINHIDCNAMG_TutorialMiniAdv.LBDOLHGDIEB((int)id);
			if(t == null)
				yield return null;
			for(int i = 0; i < t.KGJHFFNFPOK_CharacterId.Length; i++)
			{
				KDLPEDBKMID.HHCJCDFCLOB.BDOFDNICMLC_StartInstallIfNeeded(DivaIconTextureCache.MakeTutorialIconPath(t.KGJHFFNFPOK_CharacterId[i]));
			}
			while(KDLPEDBKMID.HHCJCDFCLOB.LNHFLJBGGJB_IsRunning)
				yield return null;
		}

		// // RVA: 0xE3D578 Offset: 0xE3D578 VA: 0xE3D578 Slot: 6
		public virtual void Release()
		{
			if(m_messageWindow != null)
			{
				Destroy(m_messageWindow.gameObject);
				m_messageWindow = null;
			}
			if(m_blackImageInstance != null)
			{
				Destroy(m_blackImageInstance.gameObject);
				m_blackImageInstance = null;
				m_highLight = null;
			}
			if(m_cursorInstance != null)
			{
				Destroy(m_cursorInstance.gameObject);
				m_cursorInstance = null;
			}
		}

		// // RVA: 0xE3D7CC Offset: 0xE3D7CC VA: 0xE3D7CC
		// public static void SetupFirstTutorialLog() { }

		// // RVA: 0xE3D9B0 Offset: 0xE3D9B0 VA: 0xE3D9B0
		// public static void Log(OAGBCBBHMPF.OGBCFNIKAFI step) { }

		// // RVA: 0xE3DB08 Offset: 0xE3DB08 VA: 0xE3DB08
		public static void TutorialAfterFirstLoginBonus()
		{
			if((GameManager.Instance.localSave.EPJOACOONAC_GetSave().IAHLNPMFJMH_Tutorial.NJFNCNCJMOO_FirstLogin & 1) == 0)
			{
				if (CIOECGOMILE.HHCJCDFCLOB.AHEFHIMGIBI_ServerSave.KCCLEHLLOFG_Common.KIECDDFNCAN_Level != 1)
					return;
				TodoLogger.Log(0, "TutorialAfterFirstLoginBonus");
			}
		}

		// // RVA: 0xE3DD1C Offset: 0xE3DD1C VA: 0xE3DD1C
		public static void TutorialAfterFirstHome()
		{
			if((GameManager.Instance.localSave.EPJOACOONAC_GetSave().IAHLNPMFJMH_Tutorial.NJFNCNCJMOO_FirstLogin & 2) == 0)
			{
				if(CIOECGOMILE.HHCJCDFCLOB.AHEFHIMGIBI_ServerSave.KCCLEHLLOFG_Common.KIECDDFNCAN_Level != 1)
				{
					return;
				}
				TodoLogger.Log(0, "TutorialAfterFirstHome");
			}
		}

		// // RVA: 0xE3DF30 Offset: 0xE3DF30 VA: 0xE3DF30
		public void ShowMessageWindow(BasicTutorialMessageId id, Action endCallBack, AdvMessageBase.TagConvertFunc func)
		{
			TodoLogger.Log(5, "TutorialAfterFirstLoginBonus");
			endCallBack();
		}

		// [IteratorStateMachineAttribute] // RVA: 0x6AE3D8 Offset: 0x6AE3D8 VA: 0x6AE3D8
		// // RVA: 0xE3E078 Offset: 0xE3E078 VA: 0xE3E078
		// private IEnumerator ProcMessage(ILLPGHGGKLL.AFBMNDPOALE messData, Action endCallBack, AdvMessageBase.TagConvertFunc func) { }

		// // RVA: 0xE3E170 Offset: 0xE3E170 VA: 0xE3E170
		public void SetInputLimit(InputLimitButton button, UnityAction onPush, Func<ButtonBase> findButton, TutorialPointer.Direction dir = TutorialPointer.Direction.Normal)
		{
			TodoLogger.Log(0, "SetInputLimit");
		}

		// // RVA: 0xE409E4 Offset: 0xE409E4 VA: 0xE409E4
		// private bool ObjectFindFunc(Transform ts, string name, string parentName) { }

		// // RVA: 0xE40AD4 Offset: 0xE40AD4 VA: 0xE40AD4
		// public void ShowCursor(CursorPosition positionType) { }

		// // RVA: 0xE413B4 Offset: 0xE413B4 VA: 0xE413B4
		public void HideCursor()
		{
			TodoLogger.Log(0, "TODO");
		}

		// // RVA: 0xE4146C Offset: 0xE4146C VA: 0xE4146C
		// public void ChangeCursorLastSibling() { }

		// // RVA: 0xE3FA90 Offset: 0xE3FA90 VA: 0xE3FA90
		// private void SetCursorPosition(RectTransform target, TutorialPointer.Direction dir) { }

		// // RVA: 0xE40498 Offset: 0xE40498 VA: 0xE40498
		// private void SetRect(LayoutUGUIHitOnly hitOnly, Vector2 offset, Vector2 scale) { }

		// // RVA: 0xE3FF5C Offset: 0xE3FF5C VA: 0xE3FF5C
		// private void SetRect(RectTransform rt, Vector2 offset, Vector2 scale) { }

		// [IteratorStateMachineAttribute] // RVA: 0x6AE450 Offset: 0x6AE450 VA: 0x6AE450
		// // RVA: 0xE3D40C Offset: 0xE3D40C VA: 0xE3D40C
		private IEnumerator PreLoadLayoutCoroutine(UnityAction finishCb, bool isAppendLayout = false)
		{
			//0xE43F00
			yield return this.StartCoroutineWatched(LoadBaseLayoutCoroutine());
			if(isAppendLayout)
			{
				yield return this.StartCoroutineWatched(LoadAppendLayoutCoroutine());
			}
			if(finishCb != null)
				finishCb();
		}

		// [IteratorStateMachineAttribute] // RVA: 0x6AE4C8 Offset: 0x6AE4C8 VA: 0x6AE4C8
		// // RVA: 0xE4172C Offset: 0xE4172C VA: 0xE4172C
		private IEnumerator LoadBaseLayoutCoroutine()
		{
			AssetBundleLoadAssetOperation layOp;

			//0xE43750
			if(m_messageWindow == null)
			{
				layOp = AssetBundleManager.LoadAssetAsync("to.xab", "MessageWindow", typeof(GameObject));
				yield return layOp;
				GameObject g = Instantiate(layOp.GetAsset<GameObject>());
				g.transform.SetParent(GameManager.Instance.PopupCanvas.transform.Find("Root"), false);
				m_messageWindow = g.GetComponent<TutorialMessageWindow>();
				AssetBundleManager.UnloadAssetBundle("to.xab", false);
				m_messageWindow.gameObject.SetActive(false);
			}
		}

		// [IteratorStateMachineAttribute] // RVA: 0x6AE540 Offset: 0x6AE540 VA: 0x6AE540
		// // RVA: 0xE417D8 Offset: 0xE417D8 VA: 0xE417D8
		private IEnumerator LoadAppendLayoutCoroutine()
		{
			int loadCount;
			AssetBundleLoadAssetOperation op;
			AssetBundleLoadLayoutOperationBase layOp;

			//0xE42F6C
			if(m_blackImageInstance != null)
				yield break;
			loadCount = 0;
			op = AssetBundleManager.LoadAssetAsync("ly/080.xab", "BlackBack", typeof(GameObject));
			loadCount++;
			yield return op;
			m_blackImageInstance = Instantiate(op.GetAsset<GameObject>());
			m_highLight = m_blackImageInstance.GetComponent<TutorialHighLight>();
			m_blackImageInstance.gameObject.SetActive(false);
			layOp = AssetBundleManager.LoadLayoutAsync("ly/080.xab", "root_cmn_tuto_finger_layout_root");
			loadCount++;
			yield return layOp;
			yield return layOp.InitializeLayoutCoroutine(GameManager.Instance.GetSystemFont(), (GameObject instance) => {
				//0xE42748
				m_cursorInstance = instance;
			});
			while(m_cursorInstance == null)
				yield return null;
			for(int i = 0; i < loadCount; i++)
			{
				AssetBundleManager.UnloadAssetBundle("ly/080.xab", false);
			}
			m_blackImageInstance.transform.SetParent(GameManager.Instance.PopupCanvas.transform, false);
			m_blackImageInstance.transform.SetAsLastSibling();
			m_blackImageInstance.SetActive(false);
			m_cursorInstance.transform.SetParent(GameManager.Instance.PopupCanvas.transform, false);
			m_cursorInstance.SetActive(false);
			m_cursorInstance.transform.SetAsLastSibling();
			m_pointer = m_cursorInstance.GetComponent<TutorialPointer>();
		}

		// // RVA: 0xE41884 Offset: 0xE41884 VA: 0xE41884
		// public void UpdateLocalPlayerData() { }

		// // RVA: 0xE419D0 Offset: 0xE419D0 VA: 0xE419D0
		// public void UpdateRecoveryPoint(ILDKBCLAFPB.CDIPJNPICCO rPoint) { }

		// // RVA: 0xE41B10 Offset: 0xE41B10 VA: 0xE41B10
		// public void SaveMusicResult() { }

		// // RVA: 0xE41D24 Offset: 0xE41D24 VA: 0xE41D24
		// public ILDKBCLAFPB.CDIPJNPICCO GetRecoveryPoint() { }

		// // RVA: 0xE41E18 Offset: 0xE41E18 VA: 0xE41E18
		// public JGEOBNENMAH.EDHCNKBMLGI SetupTutorialGame(TutorialGameMode.Type type) { }

		// // RVA: 0xE42544 Offset: 0xE42544 VA: 0xE42544
		public static bool IsBeginnerMission()
		{
			return CIOECGOMILE.HHCJCDFCLOB.AHEFHIMGIBI_ServerSave.JHFIPCIHJNL_Base.IJHBIMNKOMC_TutorialEnd < 2;
		}
	}
}
