using System.Collections.Generic;
using XeApp.Game.Common;

[System.Obsolete("Use EBFLJMOCLNA_Costume", true)]
public class EBFLJMOCLNA { }
public class EBFLJMOCLNA_Costume : KLFDBFMNLBL_ServerSaveBlock
{
	public class ILFJDCICIKN // TypeDefIndex: 9373
	{
		public int FBGGEFFJJHB; // 0x8
		private const sbyte CNECJGKECHK = 31;
		private const sbyte JFOFMKBJBBE = 56;
		public int BJHHOBEMBJG; // 0x10
		public long KLAPHOKNEDG; // 0x18
		public int MBCPMFPKNBA; // 0x20
		public int JJBEDMKNPFF; // 0x24
		public int AADPAJOLEEF; // 0x28
		public int LPNLLCCFHEI_IsNewColorFlags_Crypted; // 0x2C
		public long JMFGGKLPKOM; // 0x30
		public int DKOGOBKOGBM; // 0x38
		public int BFLIINDAAAA; // 0x3C
		public int IOJOBGHPLIE; // 0x40
		public int BHOGOHAILFM; // 0x44
		private int MDFMOFABGKL; // 0x48
		public List<int> LDPGNKBFJOM; // 0x4C

		public int BEEAIAAJOHD_CostumeId { get { return BJHHOBEMBJG ^ FBGGEFFJJHB; } set { BJHHOBEMBJG = FBGGEFFJJHB ^ value; } } //0x14F81D4 DIIBIOEMHAI 0x14F9084 JIHEDMEFKAF
		public bool CADENLBDAEB_IsNew { get; set; } // 0xC HMFLCAALEKM KJGFPPLHLAB ILJHLPMDHPO
		public long BEBJKJKBOGH_Date { get { return KLAPHOKNEDG ^ FBGGEFFJJHB; } set { KLAPHOKNEDG = value ^ FBGGEFFJJHB; JMFGGKLPKOM = value ^ FCEJCHGLFGN; } } //0x14F98EC DIAPHCJBPFD 0x14F9EEC IHAIKPNEEJE
		public int ANAJIAENLNB_Level { get { return MBCPMFPKNBA ^ FBGGEFFJJHB; } set { MBCPMFPKNBA = value ^ FBGGEFFJJHB; DKOGOBKOGBM = value ^ FCEJCHGLFGN; } } //0x14F8710 MMOMNMBKHJF 0x14F9F20 FEHNFGPFINK
		public int KBOLNIBLIND_Unlock { get { return JJBEDMKNPFF ^ FBGGEFFJJHB; } set { JJBEDMKNPFF = value ^ FBGGEFFJJHB; BFLIINDAAAA = value ^ FCEJCHGLFGN; } } //0x14F81E4 HEOJHPJAPJC 0x14F9F40 AGMKOELJHLC
		 public int DNBFMLBNAEE_Point { get { return AADPAJOLEEF ^ FBGGEFFJJHB; } set { AADPAJOLEEF = value ^ FBGGEFFJJHB; IOJOBGHPLIE = value ^ FCEJCHGLFGN; } } //0x14F991C JKHIIAEMMDE 0x14F9F60 PFFKLBLEPKB
		 public int MKEHNGNEFMM_IsNewColorFlags { get { return LPNLLCCFHEI_IsNewColorFlags_Crypted ^ FBGGEFFJJHB; } set { LPNLLCCFHEI_IsNewColorFlags_Crypted = value ^ FBGGEFFJJHB; BHOGOHAILFM = value ^ FCEJCHGLFGN; } } //0x14F992C BLHDBHOBDIM 0x14F9F80 HLBGPACOLCD
		 public int FOENNFDGCIC_TrsNew { get { return MDFMOFABGKL ^ FBGGEFFJJHB; } set { MDFMOFABGKL = value ^ FBGGEFFJJHB; MDFMOFABGKL = value ^ FCEJCHGLFGN; } } //0x14F9904 KFANFPLGMAM 0x14F9FA0 OLIMMBABBFI
		// public bool FJODMPGPDDD { get; }

		// RVA: 0x14FD494 Offset: 0x14FD494 VA: 0x14FD494
		// public bool GPOJCDOEDFD(int HEHKNMCDBJJ) { }

		// // RVA: 0x14FD4B8 Offset: 0x14FD4B8 VA: 0x14FD4B8
		// public void HBNNIHCGEOG(int HEHKNMCDBJJ, bool OAFPGJLCNFM) { }

		// RVA: 0x14F9064 Offset: 0x14F9064 VA: 0x14F9064
		public ILFJDCICIKN()
		{
			LHPDDGIJKNB();
		}

		// // RVA: 0x14FD4F0 Offset: 0x14FD4F0 VA: 0x14FD4F0
		public void LHPDDGIJKNB()
		{
			FBGGEFFJJHB = LPDNKHAIOLH.CEIBAFOCNCA();
			BEEAIAAJOHD_CostumeId = 0;
			CADENLBDAEB_IsNew = false;
			FOENNFDGCIC_TrsNew = 0;
			BEBJKJKBOGH_Date = 0;
			ANAJIAENLNB_Level = 0;
			KBOLNIBLIND_Unlock = -1;
			DNBFMLBNAEE_Point = 0;
			MKEHNGNEFMM_IsNewColorFlags = 0;
		}

		// // RVA: 0x14F7038 Offset: 0x14F7038 VA: 0x14F7038
		public bool CGKAEMGLHNK_Possessed()
		{
			TodoLogger.Log(0, "CGKAEMGLHNK_Possessed");
			if (RuntimeSettings.CurrentSettings.ForceCostumeUnlock)
				return true;
			return false;
		}

		// // RVA: 0x14FA198 Offset: 0x14FA198 VA: 0x14FA198
		// public void ODDIHGPONFL(EBFLJMOCLNA.ILFJDCICIKN GPBJHKLFCEP) { }

		// // RVA: 0x14FA540 Offset: 0x14FA540 VA: 0x14FA540
		// public bool AGBOGBEOFME(EBFLJMOCLNA.ILFJDCICIKN OIKJFMGEICL) { }

		// // RVA: 0x14FAAD0 Offset: 0x14FAAD0 VA: 0x14FAAD0
		// public void AGHKODFKOJI(BHBONAHFKHD JBBHNIACMFJ, string JIKKNHIAEKG, string MJBACHKCIHA, int OIPCCBHIKIA, EBFLJMOCLNA.ILFJDCICIKN OHMCIEMIKCE, bool KFCGIKHEEMB) { }

		// // RVA: 0x14FC9EC Offset: 0x14FC9EC VA: 0x14FC9EC
		// public FENCAJJBLBH PFAKPFKJJKA() { }

		// // RVA: 0x14FD5D0 Offset: 0x14FD5D0 VA: 0x14FD5D0
		// public bool EAMPKNCDCFM(LCLCCHLDNHJ DALAFJJBBFH, int GNDJCANPLDJ, out EBFLJMOCLNA.ILFJDCICIKN.PIHKHAKGNCN HBODCMLFDOB) { }

		// // RVA: 0x14FDA80 Offset: 0x14FDA80 VA: 0x14FDA80
		// public void MOACIBEKLEN(EBFLJMOCLNA.ILFJDCICIKN.PIHKHAKGNCN HBODCMLFDOB) { }

		// // RVA: 0x14F83A0 Offset: 0x14F83A0 VA: 0x14F83A0
		// public void GLHANCMGNDM(int ANAJIAENLNB) { }

		// // RVA: 0x14FDD20 Offset: 0x14FDD20 VA: 0x14FDD20
		public bool EJODLFBKFDK_IsNewColor(int HEHKNMCDBJJ_ColorId)
		{
			return (MKEHNGNEFMM_IsNewColorFlags & (1 << (HEHKNMCDBJJ_ColorId - 1))) != 0;
		}

		// // RVA: 0x14FDD48 Offset: 0x14FDD48 VA: 0x14FDD48
		// public void PDADHMIODCA(int HEHKNMCDBJJ, bool JKDJCFEBDHC) { }
	}
	public const int ECFEMKGFDCE = 2;
	public static string POFDDFCGEGP = "_"; // 0x0
	public const int FCEJCHGLFGN = 0x6871471; //109515889;
	public const int PADPOGKDNDP = 500;
	private int JLFONLABECA_ShowTuto; // 0x28

	public List<ILFJDCICIKN> FABAGMLEKIB_List { get; private set; } = new List<ILFJDCICIKN>(500); // 0x24 PICMGGDAMCD NGJACJFHBKM NEHGIPDDKNG
	// public override bool DMICHEJIAJL { get; }

	// // RVA: 0x14F6B90 Offset: 0x14F6B90 VA: 0x14F6B90
	public EBFLJMOCLNA_Costume.ILFJDCICIKN EEOADCECNOM_GetCostume(int PPFNGGCBJKC)
	{
		return FABAGMLEKIB_List[PPFNGGCBJKC - 1];
	}

	// // RVA: 0x14F6C10 Offset: 0x14F6C10 VA: 0x14F6C10
	// public bool MLBBKNLPBBD(int OIPCCBHIKIA) { }

	// // RVA: 0x14F6C2C Offset: 0x14F6C2C VA: 0x14F6C2C
	// public void ILMPHFPFLJE(int OIPCCBHIKIA, bool OAFPGJLCNFM) { }

	// // RVA: 0x14F6C54 Offset: 0x14F6C54 VA: 0x14F6C54
	// private void JEDBIGLCMBC(LCLCCHLDNHJ MFPNGNMFEAL, DEKKMGAFJCG DGCJCAHIAPP, bool NHMPDLNPBJD, Action<EBFLJMOCLNA.ILFJDCICIKN> KBCBGIGOLHP) { }

	// // RVA: 0x14F1D78 Offset: 0x14F1D78 VA: 0x14F1D78
	// public int EFFKJGEDONM(LCLCCHLDNHJ MFPNGNMFEAL, DEKKMGAFJCG DGCJCAHIAPP, bool NHMPDLNPBJD) { }

	// // RVA: 0x14F7060 Offset: 0x14F7060 VA: 0x14F7060
	// public void BEEJCDHCONE(int JPIDIENBGKH, int ANAJIAENLNB) { }

	// // RVA: 0x14F7440 Offset: 0x14F7440 VA: 0x14F7440
	// public void BJGLMIDBKKB(int JPIDIENBGKH) { }

	// // RVA: 0x14F7E20 Offset: 0x14F7E20 VA: 0x14F7E20
	public void AGEAPKNODHO()
	{
		TodoLogger.Log(0, "TODO");
	}

	// // RVA: 0x14F8070 Offset: 0x14F8070 VA: 0x14F8070
	// public void CGBCFBGJHKC(int AHHJLDLAPAN) { }

	// // RVA: 0x14F74E4 Offset: 0x14F74E4 VA: 0x14F74E4
	// private List<EBFLJMOCLNA.NMAPBJMLMPM> PHMAHDDGICC() { }

	// // RVA: 0x14F7A78 Offset: 0x14F7A78 VA: 0x14F7A78
	// private void HNLMNKFJHLK(EBFLJMOCLNA.ILFJDCICIKN LDEGEHAEALK, List<EBFLJMOCLNA.NMAPBJMLMPM> GJFECKHFKLK) { }

	// // RVA: 0x14F84D4 Offset: 0x14F84D4 VA: 0x14F84D4
	public StatusData NNIKNCGNDHK(int MCDINKAKFGG_DivaId)
	{
		TodoLogger.Log(0, "NNIKNCGNDHK");
		return new StatusData();
	}

	// // RVA: 0x14F8720 Offset: 0x14F8720 VA: 0x14F8720
	public int[,] GODGHFDMAHF()
	{
		int[,] res = new int[LCLCCHLDNHJ_Costume.GFIKOEEBIJP, 3];
		TodoLogger.Log(0, "GODGHFDMAHF");
		return res;
	}

	// // RVA: 0x14F8ADC Offset: 0x14F8ADC VA: 0x14F8ADC
	// public int AAKEPLHPLPL(LCLCCHLDNHJ MFPNGNMFEAL, int NDKJCDGHPLD, int IIELLEPEEFH) { }

	// // RVA: 0x14F8C6C Offset: 0x14F8C6C VA: 0x14F8C6C
	// public int LMLGEDEJCJO(int PPFNGGCBJKC, LCLCCHLDNHJ MFPNGNMFEAL, bool HGIKOKNMMDH = True) { }

	// // RVA: 0x14F8EB0 Offset: 0x14F8EB0 VA: 0x14F8EB0
	public EBFLJMOCLNA_Costume()
	{
		KMBPACJNEOF();
	}

	// // RVA: 0x14F8F54 Offset: 0x14F8F54 VA: 0x14F8F54 Slot: 4
	public override void KMBPACJNEOF()
	{
		FABAGMLEKIB_List.Clear();
		for(int i = 1; i < 501; i++)
		{
			ILFJDCICIKN data = new ILFJDCICIKN();
			data.BJHHOBEMBJG = data.FBGGEFFJJHB ^ i;
			FABAGMLEKIB_List.Add(data);
		}
		JLFONLABECA_ShowTuto = 0;
	}

	// // RVA: 0x14F9094 Offset: 0x14F9094 VA: 0x14F9094 Slot: 5
	// public override void OKJPIBHMKMJ(EDOHBJAPLPF_JsonData OILEIIEIBHP, long MCKEOKFMLAH) { }

	// // RVA: 0x14F993C Offset: 0x14F993C VA: 0x14F993C Slot: 6
	public override bool IIEMACPEEBJ_Deserialize(EDOHBJAPLPF_JsonData OILEIIEIBHP)
	{
		bool blockMissing = false;
		bool isInvalid = false;
		EDOHBJAPLPF_JsonData block = LGPBAKLCFHI_FindAndCheckBlock(OILEIIEIBHP, ref blockMissing, ref isInvalid, 2);
		if (!blockMissing)
		{
			if (block == null)
			{
				isInvalid = true;
			}
			else
			{
				LCLCCHLDNHJ_Costume costumeDb = IMMAOANGPNK.HHCJCDFCLOB.NKEBMCIMJND_Database.MFPNGNMFEAL_Costume;
				for (int i = 0; i < costumeDb.CDENCMNHNGA_Costumes.Count; i++)
				{
					LCLCCHLDNHJ_Costume.ILODJKFJJDO_CostumeInfo item = costumeDb.CDENCMNHNGA_Costumes[i];
					if(item.PPEGAKEIEGM_Enabled == 2)
					{
						string str = POFDDFCGEGP + (i + 1).ToString();
						if(block.BBAJPINMOEP_Contains(str))
						{
							EDOHBJAPLPF_JsonData b = block[str];
							ILFJDCICIKN data = FABAGMLEKIB_List[i];
							data.BEEAIAAJOHD_CostumeId = i + 1;
							data.CADENLBDAEB_IsNew = CJAENOMGPDA_ReadInt(b, AFEHLCGHAEE_Strings.KLJGEHBKMMG_new, 0, ref isInvalid) != 0;
							data.BEBJKJKBOGH_Date = CJAENOMGPDA_ReadInt(b, AFEHLCGHAEE_Strings.BEBJKJKBOGH_Date, 0, ref isInvalid);
							data.ANAJIAENLNB_Level = CJAENOMGPDA_ReadInt(b, "lv", 0, ref isInvalid);
							data.KBOLNIBLIND_Unlock = CJAENOMGPDA_ReadInt(b, "unlock", -1, ref isInvalid);
							data.DNBFMLBNAEE_Point = CJAENOMGPDA_ReadInt(b, "point", 0, ref isInvalid);
							data.MKEHNGNEFMM_IsNewColorFlags = CJAENOMGPDA_ReadInt(b, "col_new", 0, ref isInvalid);
							data.FOENNFDGCIC_TrsNew = CJAENOMGPDA_ReadInt(b, AFEHLCGHAEE_Strings.DLMDINBHGBG_trs_new, 0, ref isInvalid);
						}
					}
				}
				EDOHBJAPLPF_JsonData b2 = OILEIIEIBHP[JIKKNHIAEKG_BlockName];
				JLFONLABECA_ShowTuto = CJAENOMGPDA_ReadInt(b2, "show_tuto", 0, ref isInvalid);
			}
			KFKDMBPNLJK_BlockInvalid = isInvalid;
			return true;
		}
		return false;
	}

	// // RVA: 0x14F9FB0 Offset: 0x14F9FB0 VA: 0x14F9FB0 Slot: 7
	// public override void BMGGKONLFIC(KLFDBFMNLBL GPBJHKLFCEP) { }

	// // RVA: 0x14FA2E8 Offset: 0x14FA2E8 VA: 0x14FA2E8 Slot: 8
	// public override bool AGBOGBEOFME(KLFDBFMNLBL GPBJHKLFCEP) { }

	// // RVA: 0x14FA654 Offset: 0x14FA654 VA: 0x14FA654 Slot: 10
	// public override void AGHKODFKOJI(BHBONAHFKHD JBBHNIACMFJ, KLFDBFMNLBL GJLFANGDGCL, long MCKEOKFMLAH) { }

	// // RVA: 0x14FC8B4 Offset: 0x14FC8B4 VA: 0x14FC8B4 Slot: 11
	public override FENCAJJBLBH PFAKPFKJJKA()
	{
		TodoLogger.Log(0, "TODO");
		return null;
	}

	// // RVA: 0x14FCB14 Offset: 0x14FCB14 VA: 0x14FCB14 Slot: 9
	// public override bool NFKFOODCJJB() { }

	// // RVA: 0x14FCB1C Offset: 0x14FCB1C VA: 0x14FCB1C
	// public List<EBFLJMOCLNA.AEGPJOENNML> POEDIMMMLME(LCLCCHLDNHJ DALAFJJBBFH, ref bool AJFHCEEKPPA) { }

	// // RVA: 0x14FCE60 Offset: 0x14FCE60 VA: 0x14FCE60
	// public void CLADPCMBMMO() { }
}
