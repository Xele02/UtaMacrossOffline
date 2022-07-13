using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

namespace XeApp.Game
{
	public class MusicDirectionParam : MusicDirectionParamBase
	{
		[Serializable]
		public class SpecialDirectionDataSolo
		{
			// [TooltipAttribute] // RVA: 0x66131C Offset: 0x66131C VA: 0x66131C
			public int bundleId; // 0x8
			// [TooltipAttribute] // RVA: 0x661350 Offset: 0x661350 VA: 0x661350
			public int divaId; // 0xC
			// [TooltipAttribute] // RVA: 0x661384 Offset: 0x661384 VA: 0x661384
			[FormerlySerializedAsAttribute("costumeId")] // RVA: 0x661384 Offset: 0x661384 VA: 0x661384
			public int costumeModelId; // 0x10
			// [TooltipAttribute] // RVA: 0x6613E4 Offset: 0x6613E4 VA: 0x6613E4
			public int valkyrieId; // 0x14
			// [TooltipAttribute] // RVA: 0x661418 Offset: 0x661418 VA: 0x661418
			public int pilotId; // 0x18
			// [TooltipAttribute] // RVA: 0x66144C Offset: 0x66144C VA: 0x66144C
			public int positionId; // 0x1C
			// [TooltipAttribute] // RVA: 0x661480 Offset: 0x661480 VA: 0x661480
			public int directionGroupId; // 0x20

			// // RVA: 0xC93A90 Offset: 0xC93A90 VA: 0xC93A90
			public bool IsFulfill(MusicDirectionParamBase.ConditionSetting setting)
			{
				bool diva_valid = true;
				if(divaId != 0)
				{
					diva_valid = divaId == setting.divaId;
					if(divaId < 0)
					{
						diva_valid = divaId == setting.divaId || Math.Abs(divaId) != setting.divaId;
					}
				}
				bool costume_valid = true;
				if(costumeModelId > 0)
				{
					costume_valid = false;
					if(costumeModelId == setting.costumeModelId)
						costume_valid = true;
				}
				bool valkyrie_valid = true;
				if(valkyrieId > 0)
				{
					valkyrie_valid = false;
					if(valkyrieId == setting.valkyrieId)
						valkyrie_valid = true;
				}
				bool pilot_valid = true;
				if(pilotId > 0)
				{
					pilot_valid = false;
					if(pilotId == setting.pilotId)
						pilot_valid = true;
				}
				bool position_valid = positionId < 1 || positionId == setting.positionId;
				return diva_valid && costume_valid && valkyrie_valid && pilot_valid && position_valid;
			}

			// // RVA: 0xC9402C Offset: 0xC9402C VA: 0xC9402C
			// public bool IsFulfill(List<MusicDirectionParamBase.ConditionSetting> settingList) { }
		}

		private MusicDirectionBoolParam m_musicDirectionBoolParam; // 0x28
		// [TooltipAttribute] // RVA: 0x661094 Offset: 0x661094 VA: 0x661094
		[SerializeField]
		private List<MusicDirectionParamBase.MikeReplaceTargetData> m_mikeReplaceTargetList = new List<MikeReplaceTargetData>(); // 0x2C
		// [TooltipAttribute] // RVA: 0x6610DC Offset: 0x6610DC VA: 0x6610DC
		[SerializeField]
		private List<MusicDirectionParam.SpecialDirectionDataSolo> m_stageLightingList = new List<SpecialDirectionDataSolo>(); // 0x30
		[SerializeField]
		// [TooltipAttribute] // RVA: 0x661124 Offset: 0x661124 VA: 0x661124
		private List<MusicDirectionParam.SpecialDirectionDataSolo> m_cameraClipList = new List<SpecialDirectionDataSolo>(); // 0x34
		[SerializeField]
		// [TooltipAttribute] // RVA: 0x66116C Offset: 0x66116C VA: 0x66116C
		private List<MusicDirectionParam.SpecialDirectionDataSolo> m_divaClipList = new List<SpecialDirectionDataSolo>(); // 0x38
		[SerializeField]
		// [TooltipAttribute] // RVA: 0x6611B4 Offset: 0x6611B4 VA: 0x6611B4
		private List<MusicDirectionParam.SpecialDirectionDataSolo> m_stagePrefabList = new List<SpecialDirectionDataSolo>(); // 0x3C
		[SerializeField]
		// [TooltipAttribute] // RVA: 0x6611FC Offset: 0x6611FC VA: 0x6611FC
		private List<MusicDirectionParam.SpecialDirectionDataSolo> m_divaPrefabList = new List<SpecialDirectionDataSolo>(); // 0x40
		[SerializeField]
		// [TooltipAttribute] // RVA: 0x661244 Offset: 0x661244 VA: 0x661244
		private List<MusicDirectionParam.SpecialDirectionDataSolo> m_voiceChangerList = new List<SpecialDirectionDataSolo>(); // 0x44
		// [TooltipAttribute] // RVA: 0x66128C Offset: 0x66128C VA: 0x66128C
		[SerializeField]
		private List<MusicDirectionParam.SpecialDirectionDataSolo> m_movieList = new List<SpecialDirectionDataSolo>(); // 0x48
		[SerializeField]
		// [TooltipAttribute] // RVA: 0x6612D4 Offset: 0x6612D4 VA: 0x6612D4
		private List<MusicDirectionParam.SpecialDirectionDataSolo> m_stageChangerList = new List<SpecialDirectionDataSolo>(); // 0x4C

		public override MusicDirectionBoolParam BoolParam { get { return m_musicDirectionBoolParam; } set { m_musicDirectionBoolParam = value; } } //0xC93E50 0xC93E58

		// RVA: 0xC93460 Offset: 0xC93460 VA: 0xC93460
		private List<MusicDirectionParamBase.ResourceData> CheckCondition(List<MusicDirectionParam.SpecialDirectionDataSolo> data, List<MusicDirectionParamBase.ConditionSetting> settingList)
		{
			List<MusicDirectionParamBase.ResourceData> res = new List<ResourceData>();
			List<int> groupIds = new List<int>();
			for(int i = 0; i < data.Count; i++)
			{
				foreach(var s in settingList)
				{
					if(data[i].IsFulfill(s))
					{
						bool isValid = true;
						foreach(var group in groupIds)
						{
							if(group == data[i].directionGroupId)
							{
								isValid = false;
								break;
							}
						}
						if(isValid)
						{
							ResourceData resData = new ResourceData(data[i].bundleId, data[i].divaId);
							res.Add(resData);
							groupIds.Add(data[i].directionGroupId);
						}
					}
				}
			}
			if(res.Count == 0)
			{
				ResourceData resData = new ResourceData(0, 0);
				res.Add(resData);
			}
			return res;
		}

		// RVA: 0xC93C7C Offset: 0xC93C7C VA: 0xC93C7C Slot: 7
		// public override bool IsUseCommonMike(int divaId, int divaModelId) { }

		// RVA: 0xC93DF0 Offset: 0xC93DF0 VA: 0xC93DF0 Slot: 8
		public override List<MusicDirectionParamBase.ResourceData> CheckStageLightingResourceId(List<MusicDirectionParamBase.ConditionSetting> settingList)
		{
			return CheckCondition(m_stageLightingList, settingList);
		}

		// RVA: 0xC93DFC Offset: 0xC93DFC VA: 0xC93DFC Slot: 9
		public override List<MusicDirectionParamBase.ResourceData> CheckStageExtensionResourceId(List<MusicDirectionParamBase.ConditionSetting> settingList)
		{
			return CheckCondition(m_stagePrefabList, settingList);
		}

		// RVA: 0xC93E08 Offset: 0xC93E08 VA: 0xC93E08 Slot: 10
		// public override List<MusicDirectionParamBase.ResourceData> CheckDivaExtensionResourceId(List<MusicDirectionParamBase.ConditionSetting> settingList) { }

		// // RVA: 0xC93E14 Offset: 0xC93E14 VA: 0xC93E14 Slot: 11
		// public override List<MusicDirectionParamBase.ResourceData> CheckDivaCutinResourceId(List<MusicDirectionParamBase.ConditionSetting> settingList) { }

		// // RVA: 0xC93E20 Offset: 0xC93E20 VA: 0xC93E20 Slot: 12
		// public override List<MusicDirectionParamBase.ResourceData> CheckMusicCameraCutinResourceId(List<MusicDirectionParamBase.ConditionSetting> settingList) { }

		// // RVA: 0xC93E2C Offset: 0xC93E2C VA: 0xC93E2C Slot: 13
		// public override List<MusicDirectionParamBase.ResourceData> CheckMusicVoiceChangerResourceId(List<MusicDirectionParamBase.ConditionSetting> settingList) { }

		// // RVA: 0xC93E38 Offset: 0xC93E38 VA: 0xC93E38 Slot: 14
		// public override List<MusicDirectionParamBase.ResourceData> CheckSpecialMovieResourceId(List<MusicDirectionParamBase.ConditionSetting> settingList) { }

		// // RVA: 0xC93E44 Offset: 0xC93E44 VA: 0xC93E44 Slot: 15
		// public override List<MusicDirectionParamBase.ResourceData> CheckStageChangerResourceId(List<MusicDirectionParamBase.ConditionSetting> settingList) { }
	}
}
