using System.Collections.Generic;

public class LPPGENBEECK {}
public class LPPGENBEECK_musicMaster : DIHHCBACKGG
{
	// private List<HMJHLLPBCLD> OHLOHGGCCMD; // 0x30
	// private List<JPCKBFBCJKD> MGBKDJLEICI; // 0x34
	// private List<HDNKOFNBCEO> MGDLFOAKGGF; // 0x38
	// public List<NONFIGBOJLN> NEIBEDCGDEM; // 0x3C
	// public List<AIPEHINPIHC> HBJDIFMCGAL; // 0x40
	// public List<AOJCMPIBFHD> DBBLKLCCHFC; // 0x44

	public List<EONOEHOKBEB_Music> EPMMNEFADAP_Musics { get; private set; }// 0x20 // EONBIDEIFIA   HPBDACIJFEM DCLKBPALLLD
	// public List<KEODKEGFDLD> GEAANLPDJBP { get; private set; } // 0x24 BJHOBLKDBKK ONBBLMFKDMA IIGCCMELFCO
	// public List<DJNPIGEFPMF> CLHIABAKKJM { get; private set; } // 0x28 LECLIAKPOBM  PNNMFKPPDBI CHBJKIFMECH
	public List<KLBKPANJCPL_Score> CMPPNEFNGMK_Scores { get; private set; } // 0x2C // OLPOIIEPELN MPLAPBEGBOA PFDIMNJEMFF

	// // RVA: 0x10CF794 Offset: 0x10CF794 VA: 0x10CF794
	public EONOEHOKBEB_Music IAJLOELFHKC(int DLAEJOBELBH)
	{
		UnityEngine.Debug.LogError("TODO");
		return null;
	}

	// // RVA: 0x10CF824 Offset: 0x10CF824 VA: 0x10CF824
	// public KEODKEGFDLD NOBCLJIAMLC(int GHBPLHBNMBK) { }

	// // RVA: 0x10CF8B4 Offset: 0x10CF8B4 VA: 0x10CF8B4
	// public DJNPIGEFPMF FLMLJIKBIMJ(int KLCIIHKFPPO) { }

	// // RVA: 0x10CF944 Offset: 0x10CF944 VA: 0x10CF944
	// public HMJHLLPBCLD KCBOGEBCMMJ(int LJNAKDMILMC) { }

	// // RVA: 0x10CFA30 Offset: 0x10CFA30 VA: 0x10CFA30
	// public JPCKBFBCJKD LLJOPJMIGPD(int GHBPLHBNMBK) { }

	// // RVA: 0x10CFB28 Offset: 0x10CFB28 VA: 0x10CFB28
	// public bool IAAMKEJKPPL(JPCKBFBCJKD KBOLNIBLIND, int ADFIHAPELAN) { }

	// // RVA: 0x10CFB94 Offset: 0x10CFB94 VA: 0x10CFB94
	// public HDNKOFNBCEO NEJKJJPIGKD(KEODKEGFDLD AOKGAGHGAEC, int AKNELONELJK, bool GIKLNODJKFK) { }

	// // RVA: 0x10CFC50 Offset: 0x10CFC50 VA: 0x10CFC50
	// public KLBKPANJCPL ALJFMLEJEHH(int KKPAHLMJKIH, int BKJGCEOEPFB, int NOAKHKMLPFK, bool GIKLNODJKFK = False, bool IOOOMNMAGAH = True) { }

	// // RVA: 0x10CFE98 Offset: 0x10CFE98 VA: 0x10CFE98
	// public int CHBLIEKBOLL(int KKPAHLMJKIH, int BKJGCEOEPFB, int NOAKHKMLPFK, bool GIKLNODJKFK = False) { }

	// // RVA: 0x10CFED0 Offset: 0x10CFED0 VA: 0x10CFED0
	// public bool BHJKMPBACAC(int GHBPLHBNMBK) { }

	// // RVA: 0x10CFFA0 Offset: 0x10CFFA0 VA: 0x10CFFA0
	// public EONOEHOKBEB INJDLHAEPEK(int GHBPLHBNMBK, int DLAEJOBELBH) { }

	// // RVA: 0x10CFFC0 Offset: 0x10CFFC0 VA: 0x10CFFC0
	// public int CIKALPJDGMF(int GHBPLHBNMBK, int DLAEJOBELBH) { }

	// // RVA: 0x10D00E8 Offset: 0x10D00E8 VA: 0x10D00E8
	// public AOJCMPIBFHD OOKAOFJBCFD(int DLAEJOBELBH, int OFGIOBGAJPA) { }

	// // RVA: 0x10D0270 Offset: 0x10D0270 VA: 0x10D0270
	// public int DCMGLKDJAKL(int JHNCAFBGOKA, int HKOHGJAIJMA, List<int> JFCDMNPDIGP) { }

	// // RVA: 0x10D050C Offset: 0x10D050C VA: 0x10D050C
	public LPPGENBEECK_musicMaster()
	{
		UnityEngine.Debug.LogError("TODO");
	}

	// // RVA: 0x10D07EC Offset: 0x10D07EC VA: 0x10D07EC Slot: 8
	protected override void KMBPACJNEOF()
	{
		UnityEngine.Debug.LogError("TODO");
	}

	// // RVA: 0x10D0B00 Offset: 0x10D0B00 VA: 0x10D0B00 Slot: 9
	public override bool IIEMACPEEBJ(byte[] DBBGALAPFGC)
	{
		BMHPFEELLNP reader = BMHPFEELLNP.HEGEKFMJNCC(DBBGALAPFGC);
		JJOLLBDMIJP_LoadScore(reader);
		NOGICBBHLNK_LoadFreeReward(reader);
		KANEJCIALLM_LoadStoryTh(reader);
		if(AOPNONMKCLC_LoadMusic(reader) && ANKANPOHJNM(reader))
		{
			AHNNMALAMFF(reader);
			CNCEJAKLNBL(reader);
			FKLPBNIFBNF(reader);
			DNCNGDFMMPI(reader);
			ALLLNNDHGLA(reader);
			return true;
		}
		return false;
	}

	// // RVA: 0x10D52EC Offset: 0x10D52EC VA: 0x10D52EC Slot: 10
	// public override bool IIEMACPEEBJ(EDOHBJAPLPF OILEIIEIBHP, int KAPMOPMDHJE){ }

	// // RVA: 0x10D0BB4 Offset: 0x10D0BB4 VA: 0x10D0BB4
	private bool JJOLLBDMIJP_LoadScore(BMHPFEELLNP FCLGPOPLDFL)
	{
		FMAFIIPNNEO[] array = FCLGPOPLDFL.DGEPOLGDKHA;
		for(int i = 0; i < array.Length; i++)
		{
			KLBKPANJCPL_Score data = new KLBKPANJCPL_Score();
			data.GKNBCINLIJJ_Scid = (int)array[i].GKHGCPODNEG;
			data.ANAJIAENLNB_F_pt = (int)array[i].ANAJIAENLNB;
			data.NLKEBAOBJCM_Cb = (int)array[i].OLKHBHLOKJI;
			data.KNIFCANOHOC_Ss = (int)array[i].EJOECKJNGPD;
			data.CKDPPJAHAIP_Dn = (int)array[i].HDBEJBBPPBK;
			data.NPKMKMBEOAG_Dnc = (int)array[i].HOPIMOECAFA;
			data.NPGCIDONKOP_Sp = (int)array[i].PIPCIMIALOO;
			data.MCMIPODICAN = (int)array[i].MOIECBABHNP;
			data.KIEHDJFCCNM = (int)array[i].AMGHCNHIFFG;
			data.GEIDIHCKDNO = (int)array[i].KKBPKNBLJCK;
			data.JJBOEMOJPEC = (int)array[i].GDHLEEJPNIJ;
			data.OABPNBLPHHP = (int)array[i].AOLENLGEJED;
			data.GIABDDFGHOK = (int)array[i].EPEBHGHKMBE;
			CMPPNEFNGMK_Scores.Add(data);
		}
		return true;
	}

	// // RVA: 0x10D5584 Offset: 0x10D5584 VA: 0x10D5584
	// private bool JJOLLBDMIJP(EDOHBJAPLPF OBHAFLMHAKG, int KAPMOPMDHJE) { }

	// // RVA: 0x10D1584 Offset: 0x10D1584 VA: 0x10D1584
	private bool AOPNONMKCLC_LoadMusic(BMHPFEELLNP FCLGPOPLDFL)
	{
		JPALGGIPGGN[] array = FCLGPOPLDFL.MDFFJJKBDFC;
		for(int i = 0; i < array.Length; i++)
		{
			EONOEHOKBEB_Music data = new EONOEHOKBEB_Music();
			
			EPMMNEFADAP_Musics.Add(data);
		}
		UnityEngine.Debug.LogError("TODO");
		return true;
	}

	// // RVA: 0x10D6180 Offset: 0x10D6180 VA: 0x10D6180
	// private bool AOPNONMKCLC(EDOHBJAPLPF OBHAFLMHAKG, int KAPMOPMDHJE) { }

	// // RVA: 0x10D104C Offset: 0x10D104C VA: 0x10D104C
	private bool NOGICBBHLNK_LoadFreeReward(BMHPFEELLNP FCLGPOPLDFL)
	{
		UnityEngine.Debug.LogError("TODO");
		return true;
	}

	// // RVA: 0x10D5ACC Offset: 0x10D5ACC VA: 0x10D5ACC
	// private bool NOGICBBHLNK(EDOHBJAPLPF OBHAFLMHAKG, int KAPMOPMDHJE) { }

	// // RVA: 0x10D12E8 Offset: 0x10D12E8 VA: 0x10D12E8
	private bool KANEJCIALLM_LoadStoryTh(BMHPFEELLNP FCLGPOPLDFL)
	{
		UnityEngine.Debug.LogError("TODO");
		return true;
	}

	// // RVA: 0x10D5E30 Offset: 0x10D5E30 VA: 0x10D5E30
	// private bool KANEJCIALLM(EDOHBJAPLPF OBHAFLMHAKG, int KAPMOPMDHJE) { }

	// // RVA: 0x10D730C Offset: 0x10D730C VA: 0x10D730C
	// private ADDHLABEFKH FEEODHDKLFH(int EJOECKJNGPD, int OLKHBHLOKJI, int OIPCCBHIKIA, HDNKOFNBCEO IBOGLMCNFBK) { }

	// // RVA: 0x10D7728 Offset: 0x10D7728 VA: 0x10D7728
	// private ADDHLABEFKH FEEODHDKLFH(int EJOECKJNGPD, int OLKHBHLOKJI, int OIPCCBHIKIA, NONFIGBOJLN IBOGLMCNFBK) { }

	// // RVA: 0x10D1FCC Offset: 0x10D1FCC VA: 0x10D1FCC
	private bool ANKANPOHJNM(BMHPFEELLNP FCLGPOPLDFL)
	{
		UnityEngine.Debug.LogError("TODO");
		return true;
	}

	// // RVA: 0x10D6D94 Offset: 0x10D6D94 VA: 0x10D6D94
	// private bool ANKANPOHJNM(EDOHBJAPLPF OBHAFLMHAKG, int KAPMOPMDHJE) { }

	// // RVA: 0x10D3D78 Offset: 0x10D3D78 VA: 0x10D3D78
	private bool AHNNMALAMFF(BMHPFEELLNP FCLGPOPLDFL)
	{
		UnityEngine.Debug.LogError("TODO");
		return true;
	}

	// // RVA: 0x10D6D9C Offset: 0x10D6D9C VA: 0x10D6D9C
	// private bool AHNNMALAMFF(EDOHBJAPLPF OBHAFLMHAKG, int KAPMOPMDHJE) { }

	// // RVA: 0x10D46D8 Offset: 0x10D46D8 VA: 0x10D46D8
	private bool CNCEJAKLNBL(BMHPFEELLNP FCLGPOPLDFL)
	{
		UnityEngine.Debug.LogError("TODO");
		return true;
	}

	// // RVA: 0x10D6DA4 Offset: 0x10D6DA4 VA: 0x10D6DA4
	// private bool CNCEJAKLNBL(EDOHBJAPLPF OBHAFLMHAKG, int KAPMOPMDHJE) { }

	// // RVA: 0x10D4950 Offset: 0x10D4950 VA: 0x10D4950
	private bool FKLPBNIFBNF(BMHPFEELLNP FCLGPOPLDFL)
	{
		UnityEngine.Debug.LogError("TODO");
		return true;
	}

	// // RVA: 0x10D70B0 Offset: 0x10D70B0 VA: 0x10D70B0
	// private bool FKLPBNIFBNF(EDOHBJAPLPF OBHAFLMHAKG, int KAPMOPMDHJE) { }

	// // RVA: 0x10D4B28 Offset: 0x10D4B28 VA: 0x10D4B28
	private bool DNCNGDFMMPI(BMHPFEELLNP FCLGPOPLDFL)
	{
		UnityEngine.Debug.LogError("TODO");
		return true;
	}

	// // RVA: 0x10D4FA0 Offset: 0x10D4FA0 VA: 0x10D4FA0
	private bool ALLLNNDHGLA(BMHPFEELLNP FCLGPOPLDFL)
	{
		UnityEngine.Debug.LogError("TODO");
		return true;
	}

	// // RVA: 0x10D7BD4 Offset: 0x10D7BD4 VA: 0x10D7BD4 Slot: 11
	public override uint CAOGDCBPBAN()
	{
		UnityEngine.Debug.LogError("TODO");
		return 0;
	}
}


public class KLBKPANJCPL{}
public class KLBKPANJCPL_Score
{
	public int OIPCCBHIKIA; // 0x8

	public int GKNBCINLIJJ_Scid { get; set; } // 0xC  // PIEBLLLAAEF ECBOBCJLLOD LFMJPMIHHBF
	public int ANAJIAENLNB_F_pt { get; set; } // 0x10 // IKMILCFHBGA MMOMNMBKHJF FEHNFGPFINK
	public int NLKEBAOBJCM_Cb { get; set; }   // 0x14 // ABLBDMPGEHA AECNKGBNKHH ECHLKFHOJFP
	public int KNIFCANOHOC_Ss { get; set; }   // 0x18 // DKDLLFCBBCE EOJEPLIPOMJ AEEMBPAEAAI
	public int CKDPPJAHAIP_Dn { get; set; }   // 0x1C // MBBGDHGPJDM DBMNFCDGGEC JEFJBPPGBOK
	public int NPKMKMBEOAG_Dnc { get; set; }  // 0x20 // AKAEHHAHFDM GHJDKBCAGLL IIEJNMBABCK
	public int NPGCIDONKOP_Sp { get; set; }   // 0x24 // AHONHAIELEA GKHINHNGCKE LLPNJHACHEB
	public int MCMIPODICAN { get; set; }      // 0x28 // IFGANBEKEAE DAGDLFMEAKG FNGANMMAACC
	public int KIEHDJFCCNM { get; set; }      // 0x2C // EGKCBOHGFBA LNPKNMONEFI CEPCIKJKLLF
	public int GEIDIHCKDNO { get; set; }      // 0x30 // DDIGBBJDNLF JAOFBBKGCHP IBIPFCNGHFF
	public int JJBOEMOJPEC { get; set; }      // 0x34 // BAGPHOPPPPC FGMMNEIIHKM MFKGPCOLFLA
	public int OABPNBLPHHP { get; set; }      // 0x38 // GJJGLNLOGHN BMCLOFLOPLO IABNMIBLHAA
	public int GIABDDFGHOK { get; set; }      // 0x3C // COGAGDDAEFD EHAGPCANMCN FMJMCAEJMPG

	// RVA: 0x1A0B9C0 Offset: 0x1A0B9C0 VA: 0x1A0B9C0
	//public uint CAOGDCBPBAN() { }
}

public class EONOEHOKBEB{}
public class EONOEHOKBEB_Music
{
	public short DLAEJOBELBH { get; set; } // CKJALIDGGOH // 0x8 MPGNHBOBFBD EPEMOAEGPLI
	public short JNCPEGJGHOG { get; set; } // LABOODIMOII // 0xA HHEADMHBBPB GOFFKDDNACG
	public short NNHOBFBCIIJ { get; set; } // GKMKHKHFBEI // 0xC AOBMNDMGGIO NIMNBBDNJMC
	public short KNMGEEFGDNI { get; set; } // JELJHGCOAFJ // 0xE HKEFEIOCKLP OCOGGADKEHD
	public short NODKIFGGMGP { get; set; } // PNBJIFJHCBL // 0x10 APAOBAGKCPC LKDECIOADPO
	public sbyte FKDCCLPGKDK { get; set; } // KLMKEFEMHOC // 0x12 FBADKBMGIBP NCNMMABFHGN
	public sbyte AIHCEGFANAM { get; set; } // FJOGAAMLJMA // 0x13 ANEJPLENMAL HEHDOGFEIOL
	public sbyte EMIKBGHIOMN { get; set; } // CCEIEDMCHLA // 0x14 BJGJCKFOBCA OAKIKBEEACC
	public short KKPAHLMJKIH { get; set; } // EOPNGHAFEMB // 0x16 ENODDPDBIPA HOAKFLEAEOH
	public short BKJGCEOEPFB { get; set; } // PJKCKOJHKEM // 0x18 FNEBPBJBIIP OIDGLNHNGJB
	public short GHICLBNHNGJ { get; set; } // IHIHAAJLBHK // 0x1A OLKANNICFLL MHEEIDDKIJH
	public short AABILPMIOFN { get; set; } // HJBLBCKELMF // 0x1C GACMKBLPOIB LKFFBLEIPIP
	public short DMKCGNMOCCH { get; set; } // LKKNIADKGAE // 0x1E PEBOPIIJCOM NOGOFLKEEMP
	public short EECJONKNHNK { get; set; } // GEOMFEFKOLF // 0x20 KJKNOCBOHFC DONMAGEIEJF
	public short MNEFKDDCEHE { get; set; } // EDBCILCIAEL // 0x22 MCDMIOFGCDF KIECJGPAHGO
	public short NJAOOMHCIHL { get; set; } // GHHLJOCPEAE // 0x24 OJBDKKDLFDD CMMJPNDAJDG
	public short PECMGDOMLAF { get; set; } // ADLPNCIONGK // 0x26 MDIFJJACKBC JKMNGNMPONF
	public short ACPKFNNONMH { get; set; } // LEDNEEKHDPM // 0x28 IOOMEBAFGFK DPMAFCKJJPM

	// RVA: 0xFBDFFC Offset: 0xFBDFFC VA: 0xFBDFFC
	//public uint CAOGDCBPBAN() { }
}

