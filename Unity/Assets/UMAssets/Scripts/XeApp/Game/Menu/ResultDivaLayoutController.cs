using System;
using System.Collections;
using mcrs;
using UnityEngine;
using XeApp.Game.Common;

namespace XeApp.Game.Menu
{
	public class ResultDivaLayoutController : MonoBehaviour
	{
		public class InitParam
		{
			// public GNIFOHMFDMO viewDivaResultData; // 0x8
			public LayoutResultOkayButton layoutOkayButton; // 0xC
		}

		private LayoutResultDivaMain layoutDiva; // 0xC
		private LayoutResultDivaPoint layoutPoint; // 0x10
		private LayoutResultOkayButton layoutOkayButton; // 0x14
		public Action onClickOkayButton; // 0x18
		private Coroutine countPointWindowCoroutine; // 0x1C
		private bool isStarted; // 0x20
		private bool isSkiped; // 0x21
		private bool isExecSkip; // 0x22
		private int WAIT_ENTER_POINY_FRAME = 8; // 0x24

		// RVA: 0xD00178 Offset: 0xD00178 VA: 0xD00178
		private void Awake()
		{
			layoutDiva = transform.Find("Main").GetComponent<LayoutResultDivaMain>();
			layoutPoint = transform.Find("Point").GetComponent<LayoutResultDivaPoint>();
		}

		// RVA: 0xD0029C Offset: 0xD0029C VA: 0xD0029C
		private void Update()
		{
			if(!IsReady())
				return;
			CheckSkipStep();
		}

		// // RVA: 0xD002C0 Offset: 0xD002C0 VA: 0xD002C0
		public bool IsReady()
		{
			return layoutDiva.IsLoaded();
		}

		// // RVA: 0xD00448 Offset: 0xD00448 VA: 0xD00448
		public void PreloadDivaIcon(ResultDivaLayoutController.InitParam initParam)
		{
			TodoLogger.Log(0, "PreloadDivaIcon");
		}

		// // RVA: 0xD00490 Offset: 0xD00490 VA: 0xD00490
		public bool IsPreloadedDivaIcon()
		{
			TodoLogger.Log(0, "IsPreloadedDivaIcon");
			return true;
		}

		// // RVA: 0xD004BC Offset: 0xD004BC VA: 0xD004BC
		public void Setup(ResultDivaLayoutController.InitParam initParam)
		{
			layoutDiva.onFinished = OnFinishedDivaMainAnim;
			TodoLogger.Log(0, "Setup");

			layoutOkayButton = initParam.layoutOkayButton;
			layoutOkayButton.SetupCallback(OnFinishedOkayButtonLayoutAnim, OnClickOkayButton);
		}

		// // RVA: 0xD0064C Offset: 0xD0064C VA: 0xD0064C
		public void SetGoDivaLayout()
		{
			TodoLogger.Log(0, "SetGoDivaLayout");
		}

		// // RVA: 0xD00678 Offset: 0xD00678 VA: 0xD00678
		public void StartCountPoint()
		{
			countPointWindowCoroutine = StartCoroutine(Co_StartPointCount());
		}

		// // RVA: 0xD0072C Offset: 0xD0072C VA: 0xD0072C
		public void StartBeginAnim()
		{
			isStarted = true;
			layoutDiva.StartBeginAnim();
		}

		// // RVA: 0xD00760 Offset: 0xD00760 VA: 0xD00760
		public void StartEndAnim(Action endAnimCallback)
		{
			TodoLogger.Log(0, "StartEndAnim");
			endAnimCallback();
		}

		// [IteratorStateMachineAttribute] // RVA: 0x721384 Offset: 0x721384 VA: 0x721384
		// // RVA: 0xD006A0 Offset: 0xD006A0 VA: 0xD006A0
		private IEnumerator Co_StartPointCount()
		{
			//0xD00A6C
			StartBeginAnim();
			TodoLogger.Log(0, "Co_StartPointCount");
			yield return null;
		}

		// // RVA: 0xD002EC Offset: 0xD002EC VA: 0xD002EC
		private void CheckSkipStep()
		{
			TodoLogger.Log(0, "CheckSkipStep");
		}

		// // RVA: 0xD007B4 Offset: 0xD007B4 VA: 0xD007B4
		private void OnFinishedDivaMainAnim()
		{
			StartCoroutine(Co_TryShowTutorial(OnShowOkayButton));
			layoutDiva.StartGaugeFinishAnim();
			isSkiped = true;
		}

		// // RVA: 0xD00924 Offset: 0xD00924 VA: 0xD00924
		private void OnShowOkayButton()
		{
			if(isExecSkip)
				layoutOkayButton.SkipAnim();
			else
				layoutOkayButton.StartBeginAnim();
		}

		// // RVA: 0xD0096C Offset: 0xD0096C VA: 0xD0096C
		private void OnFinishedOkayButtonLayoutAnim()
		{
			return;
		}

		// // RVA: 0xD00970 Offset: 0xD00970 VA: 0xD00970
		private void OnClickOkayButton()
		{
			SoundManager.Instance.sePlayerBoot.Play((int)cs_se_boot.SE_BTN_001);
			if(onClickOkayButton != null)
				onClickOkayButton();
			layoutDiva.StopGaugeFinishAnim();
		}

		// [IteratorStateMachineAttribute] // RVA: 0x7213FC Offset: 0x7213FC VA: 0x7213FC
		// // RVA: 0xD0087C Offset: 0xD0087C VA: 0xD0087C
		private IEnumerator Co_TryShowTutorial(Action endFunc)
		{
			TodoLogger.Log(0, "Co_TryShowTutorial");
			yield return null;
			if(endFunc != null)
				endFunc();
		}

		// // RVA: 0xD00A20 Offset: 0xD00A20 VA: 0xD00A20
		// private bool CheckTutorialCondition(TutorialConditionId conditionId) { }
	}
}