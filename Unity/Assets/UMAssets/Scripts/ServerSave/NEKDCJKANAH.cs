
using System.Collections.Generic;

[System.Obsolete("Use NEKDCJKANAH_StoryRecord", true)]
public class NEKDCJKANAH { }
public class NEKDCJKANAH_StoryRecord : KLFDBFMNLBL_ServerSaveBlock
{
	public class HKDNILFKCFC
	{
		public const int PIHLDCHFFGL = 1;
		public const int CABPJNMPHEJ = 2;
		public const int POBMLOCCLND = 4;
		public const int OIPLHJIPFPD = 8;
		public const int NKBCBKHPLNP = 0;
		public const int BGCLPLAKANE = 1;
		public const int OJPKNLIBPIP = 2;
		public const int AJOHDNLHJBG = 3;
		public const int KOOCNAOFMJC = 4;
		public int BMPFHHHCNJC_Id; // 0x8
		public int EALOBDHOCHP_Stat; // 0xC
		public int NDFOAINJPIN_Pos; // 0x10
		public int OKJMIFELDMD_Opn; // 0x14
		public int EJKHAFIALGK_MClr; // 0x18
		public int PDNJGJNGPNJ; // 0x1C
		public int ODEHJGPDFCL; // 0x20
		public int ABFNAEKEGOB; // 0x24
		public bool ICCJMCCJCBG; // 0x28
		public bool HCENOJKNCMK; // 0x29

		public bool HALOKFOJMLA { get { return EALOBDHOCHP_Stat > 3; } } //0x1AE98B8 LKOICFDJNDD

		// RVA: 0x1AE6C08 Offset: 0x1AE6C08 VA: 0x1AE6C08
		public HKDNILFKCFC()
		{
			EJKHAFIALGK_MClr = 0;
			BMPFHHHCNJC_Id = 0;
			EALOBDHOCHP_Stat = 0;
			NDFOAINJPIN_Pos = 0;
			OKJMIFELDMD_Opn = 0;
		}

		//// RVA: 0x1AE6C34 Offset: 0x1AE6C34 VA: 0x1AE6C34
		//public void LHPDDGIJKNB() { }

		//// RVA: 0x1AE7410 Offset: 0x1AE7410 VA: 0x1AE7410
		//public bool CHFOOMPEABN() { }

		//// RVA: 0x1AE7E38 Offset: 0x1AE7E38 VA: 0x1AE7E38
		//public bool AGBOGBEOFME(NEKDCJKANAH.HKDNILFKCFC OIKJFMGEICL) { }

		//// RVA: 0x1AE7B24 Offset: 0x1AE7B24 VA: 0x1AE7B24
		public void ODDIHGPONFL(HKDNILFKCFC GPBJHKLFCEP)
		{
			BMPFHHHCNJC_Id = GPBJHKLFCEP.BMPFHHHCNJC_Id;
			EALOBDHOCHP_Stat = GPBJHKLFCEP.EALOBDHOCHP_Stat;
			NDFOAINJPIN_Pos = GPBJHKLFCEP.NDFOAINJPIN_Pos;
			OKJMIFELDMD_Opn = GPBJHKLFCEP.OKJMIFELDMD_Opn;
			EJKHAFIALGK_MClr = GPBJHKLFCEP.EJKHAFIALGK_MClr;
		}

		//// RVA: 0x1AE8420 Offset: 0x1AE8420 VA: 0x1AE8420
		//public void AGHKODFKOJI(BHBONAHFKHD JBBHNIACMFJ, string JIKKNHIAEKG, string MJBACHKCIHA, int OIPCCBHIKIA, NEKDCJKANAH.HKDNILFKCFC OHMCIEMIKCE, bool EFOEPDLNLJG) { }
	}

	private const int ECFEMKGFDCE = 2;
	public static string POFDDFCGEGP = "_"; // 0x0
	private const int FLPFFEIKAKM = 200;
	private const int FLGCFMIACIN = 3;
	private const int KOLKCGMGLMN = 99999;
	private const int GCAHAAADBEH = 45684125; // 0x2b9159d
	private const int GKIDNIKODDK = 52143548; // 0x31ba5bc
	private int AKLLPNDJFCN_Complete; // 0x24

	// public bool EOHHFADHHBL { get; set; } FPOHKGALENL 0x1AE66D8  HCFHGHNGPJK 0x1AE66F4
	public List<HKDNILFKCFC> MMKAJBFBKNH { get; private set; } // 0x28 JAKKBNNDGOM BLJEKMOEHCM FJAHCOJOEJO
	// public override bool DMICHEJIAJL { get; }

	// // RVA: 0x1AE6720 Offset: 0x1AE6720 VA: 0x1AE6720
	// public int FKJMJELHGGG() { }

	// // RVA: 0x1AE6804 Offset: 0x1AE6804 VA: 0x1AE6804
	// public int ODOKNPHEIFN(int LFLLLOPAKCO, int EALOBDHOCHP) { }

	// // RVA: 0x1AE68FC Offset: 0x1AE68FC VA: 0x1AE68FC
	// public void NDANPOKGFAN() { }

	// // RVA: 0x1AE6A30 Offset: 0x1AE6A30 VA: 0x1AE6A30
	public NEKDCJKANAH_StoryRecord()
	{
		MMKAJBFBKNH = new List<HKDNILFKCFC>(200);
		KMBPACJNEOF();
	}

	// // RVA: 0x1AE6AD4 Offset: 0x1AE6AD4 VA: 0x1AE6AD4 Slot: 4
	public override void KMBPACJNEOF()
	{
		MMKAJBFBKNH.Clear();
		for(int i = 0; i < 200; i++)
		{
			HKDNILFKCFC data = new HKDNILFKCFC();
			data.BMPFHHHCNJC_Id = i + 1;
			MMKAJBFBKNH.Add(data);
		}
	}

	// // RVA: 0x1AE6C4C Offset: 0x1AE6C4C VA: 0x1AE6C4C Slot: 5
	// public override void OKJPIBHMKMJ(EDOHBJAPLPF_JsonData OILEIIEIBHP, long MCKEOKFMLAH) { }

	// // RVA: 0x1AE7448 Offset: 0x1AE7448 VA: 0x1AE7448 Slot: 6
	public override bool IIEMACPEEBJ_Deserialize(EDOHBJAPLPF_JsonData OILEIIEIBHP)
	{
		bool blockMissing = false;
		bool isInvalid = false;
		EDOHBJAPLPF_JsonData block = LGPBAKLCFHI_FindAndCheckBlock(OILEIIEIBHP, ref blockMissing, ref isInvalid, 2);
		if(!blockMissing)
		{
			if(block == null)
			{
				isInvalid = true;
			}
			else
			{
				LAEGMENIEDB_Story storyDb = IMMAOANGPNK.HHCJCDFCLOB.NKEBMCIMJND_Database.OHCIFMDPAPD_Story;
				for(int i = 0; i < storyDb.CDENCMNHNGA.Count; i++)
				{
					string str = POFDDFCGEGP + (i + 1).ToString();
					if(block.BBAJPINMOEP_Contains(str))
					{
						EDOHBJAPLPF_JsonData b = block[str];
						HKDNILFKCFC data = MMKAJBFBKNH[i];
						data.BMPFHHHCNJC_Id = CJAENOMGPDA_ReadInt(b, AFEHLCGHAEE_Strings.PPFNGGCBJKC_Id, i + 1, ref isInvalid);
						data.EALOBDHOCHP_Stat = CJAENOMGPDA_ReadInt(b, AFEHLCGHAEE_Strings.EALOBDHOCHP_stat, 0, ref isInvalid);
						data.NDFOAINJPIN_Pos = CJAENOMGPDA_ReadInt(b, AFEHLCGHAEE_Strings.NDFOAINJPIN_pos, 0, ref isInvalid);
						data.OKJMIFELDMD_Opn = CJAENOMGPDA_ReadInt(b, AFEHLCGHAEE_Strings.DPOGAFBDEOH_opn, 0, ref isInvalid);
						data.EJKHAFIALGK_MClr = CJAENOMGPDA_ReadInt(b, AFEHLCGHAEE_Strings.EJKHAFIALGK_mclr, 0, ref isInvalid);
					}
				}
				EDOHBJAPLPF_JsonData b2 = OILEIIEIBHP[JIKKNHIAEKG_BlockName];
				AKLLPNDJFCN_Complete = CJAENOMGPDA_ReadInt(b2, "complete", 0, ref isInvalid) != 0 ? GCAHAAADBEH : GKIDNIKODDK;
			}
			KFKDMBPNLJK_BlockInvalid = isInvalid;
			return true;
		}
		return false;
	}

	// // RVA: 0x1AE7928 Offset: 0x1AE7928 VA: 0x1AE7928 Slot: 7
	public override void BMGGKONLFIC(KLFDBFMNLBL_ServerSaveBlock GPBJHKLFCEP)
	{
		NEKDCJKANAH_StoryRecord s = GPBJHKLFCEP as NEKDCJKANAH_StoryRecord;
		for(int i = 0; i < MMKAJBFBKNH.Count; i++)
		{
			MMKAJBFBKNH[i].ODDIHGPONFL(s.MMKAJBFBKNH[i]);
		}
		AKLLPNDJFCN_Complete = s.AKLLPNDJFCN_Complete;
	}

	// // RVA: 0x1AE7BC4 Offset: 0x1AE7BC4 VA: 0x1AE7BC4 Slot: 8
	// public override bool AGBOGBEOFME(KLFDBFMNLBL GPBJHKLFCEP) { }

	// // RVA: 0x1AE7F14 Offset: 0x1AE7F14 VA: 0x1AE7F14 Slot: 10
	// public override void AGHKODFKOJI(BHBONAHFKHD JBBHNIACMFJ, KLFDBFMNLBL GJLFANGDGCL, long MCKEOKFMLAH) { }

	// // RVA: 0x1AE9734 Offset: 0x1AE9734 VA: 0x1AE9734 Slot: 9
	// public override bool NFKFOODCJJB() { }

	// // RVA: g Offset: 0x1AE6928 VA: 0x1AE6928
	public void LOAOLBNFNNP_InitDefault()
	{
		MMKAJBFBKNH[0].EALOBDHOCHP_Stat = 4;
		MMKAJBFBKNH[0].NDFOAINJPIN_Pos = 1;
		MMKAJBFBKNH[0].OKJMIFELDMD_Opn = 15;
		MMKAJBFBKNH[0].ICCJMCCJCBG = false;
		MMKAJBFBKNH[0].HCENOJKNCMK = false;
	}

	// // RVA: 0x1AE973C Offset: 0x1AE973C VA: 0x1AE973C
	// public void GGKLNCHMPFC(int LFLLLOPAKCO) { }
}
