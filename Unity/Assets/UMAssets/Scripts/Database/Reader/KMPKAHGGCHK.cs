using FlatBuffers;
using System.Collections.Generic;

public class ALNDGBMAILD
{
	public int PNDNJDMIKAN { get; set; } // 0x8 PECAMELOBCB PMOHAHMFELP CIMIIFHBEGB
	public int ELHALBFPLJK { get; set; } // 0xC CHHGKBMJGDB MJCLNHJCMPL GFIEFLHIOPI
}
public class DGILHAMKBKK
{
	public int AADJGKGCMCP { get; set; } // 0x8 CMDMAEGLNAO NDOOCOLGFEF FGAIBKOLMLO
	public int FDAPNFDOHEJ { get; set; } // 0xC FJCBLAIPOLH CDEKDJJDAGP IEOHBLJGKCF
	public int EDFJKODHCAN { get; set; } // 0x10 OHDOLICNMNM HAOKBLMBKND EEEPKLDGMAH
}
public class IMMJLLOOKCF
{
	public int PNDNJDMIKAN { get; set; } // 0x8 PECAMELOBCB PMOHAHMFELP CIMIIFHBEGB
	public int[] CBDOEDKIOJK { get; set; } // 0xC CENBLPHOLKK COMDLMJJFFN MJNJNAHIJCO
}
public class CPNJPEHHNOO
{
	public int GNFJOONKCFH { get; set; } // 0x8 JGLANLMLCNL LOFPOONPOMC KEGADDBFANM
	public int[] CBDOEDKIOJK { get; set; } // 0xC CENBLPHOLKK COMDLMJJFFN MJNJNAHIJCO
}
public class AMEBNIIIHNG
{
	public int GNFJOONKCFH { get; set; } // 0x8 JGLANLMLCNL LOFPOONPOMC KEGADDBFANM
	public int GLCLFMGPMAN { get; set; } // 0xC KCELNMGLKHH LNJAENEGDEL JHIDBGCHOKL
	public int ADPPAIPFHML { get; set; } // 0x10 LONDDHLNFBL LJMLHOOPGEM PHNIOCPOBGO
	public int ACGLMKEBMDL { get; set; } // 0x14 EPENFLDKGJE ALOLFIJOOHG JDPCOMJIMHG
	public int FBFLDFMFFOH { get; set; } // 0x18 LMKEDCAPLEE HNLMNIOMOLI CHHJKABBIBL
}
public class GGKLHGBDPDD
{
	public string LJNAKDMILMC { get; set; } // 0x8 KNJIHALCKLN LIIHHICIBKM OACJGKPBHIK
	public int JBGEEPFKIGG { get; set; } // 0xC AHPLCJAKAOP OLOCMINKGON ABAFHIBFKCE
}
public class KMPKAHGGCHK
{
	public ALNDGBMAILD[] PJFGGPOEBAH { get; set; } // 0x8 LKDEHKKHCOC FNIFPLHBGCH BINBHHADDAA
	public DGILHAMKBKK[] KIEKMCKCMGD { get; set; } // 0xC AHOFIJDMDAO EEMBMMJIHPE CDHPBECJGGO
	public IMMJLLOOKCF[] GOKCDMKKCMD { get; set; } // 0x10 MLELALGNENI EEFEAKJIAJD MJKJKEDHCGG
	public CPNJPEHHNOO[] PFGDBAIFLGL { get; set; } // 0x14 PLIJMECLDCI CFPBPHBLKID JKJNNOFLDLF
	public AMEBNIIIHNG[] PPMOLKLDNLB { get; set; } // 0x18 LOCEEBBABGD BLNAFPDHDLI HHAFJOBIANI
	public GGKLHGBDPDD[] BHGDNGHDDAC { get; set; } // 0x1C JHDNDHBDFFI CEHHJMMMCID EDOEOHENKDG
	public static KMPKAHGGCHK HEGEKFMJNCC(byte[] NIODCJLINJN)// 0x1120554
	{
		ByteBuffer buffer = new ByteBuffer(NIODCJLINJN);
		GPDPAKFCMMO res_readData = GPDPAKFCMMO.GetRootAsGPDPAKFCMMO(buffer);
		KMPKAHGGCHK res_data = new KMPKAHGGCHK();

		List<ALNDGBMAILD> PJFGGPOEBAH_list = new List<ALNDGBMAILD>();
		for(int PJFGGPOEBAH_idx = 0; PJFGGPOEBAH_idx < res_readData.FBFKOOCONJDLength; PJFGGPOEBAH_idx++)
		{
			HHHCEGPGJII PJFGGPOEBAH_readData = res_readData.GetFBFKOOCONJD(PJFGGPOEBAH_idx);
			ALNDGBMAILD PJFGGPOEBAH_data = new ALNDGBMAILD();

			PJFGGPOEBAH_data.PNDNJDMIKAN = PJFGGPOEBAH_readData.NMOFFGFGFKA;
			PJFGGPOEBAH_data.ELHALBFPLJK = PJFGGPOEBAH_readData.NOEFOIOOICD;
			PJFGGPOEBAH_list.Add(PJFGGPOEBAH_data);
		}
		res_data.PJFGGPOEBAH = PJFGGPOEBAH_list.ToArray();

		List<DGILHAMKBKK> KIEKMCKCMGD_list = new List<DGILHAMKBKK>();
		for(int KIEKMCKCMGD_idx = 0; KIEKMCKCMGD_idx < res_readData.FBAHAFKCMMHLength; KIEKMCKCMGD_idx++)
		{
			DBDMELPOPMH KIEKMCKCMGD_readData = res_readData.GetFBAHAFKCMMH(KIEKMCKCMGD_idx);
			DGILHAMKBKK KIEKMCKCMGD_data = new DGILHAMKBKK();

			KIEKMCKCMGD_data.AADJGKGCMCP = KIEKMCKCMGD_readData.AINFENANAKL;
			KIEKMCKCMGD_data.FDAPNFDOHEJ = KIEKMCKCMGD_readData.IHODOLMEGIL;
			KIEKMCKCMGD_data.EDFJKODHCAN = KIEKMCKCMGD_readData.MDGINMBLOHO;
			KIEKMCKCMGD_list.Add(KIEKMCKCMGD_data);
		}
		res_data.KIEKMCKCMGD = KIEKMCKCMGD_list.ToArray();

		List<IMMJLLOOKCF> GOKCDMKKCMD_list = new List<IMMJLLOOKCF>();
		for(int GOKCDMKKCMD_idx = 0; GOKCDMKKCMD_idx < res_readData.LDCIJBPBLPPLength; GOKCDMKKCMD_idx++)
		{
			KBKAEPDDIME GOKCDMKKCMD_readData = res_readData.GetLDCIJBPBLPP(GOKCDMKKCMD_idx);
			IMMJLLOOKCF GOKCDMKKCMD_data = new IMMJLLOOKCF();

			GOKCDMKKCMD_data.PNDNJDMIKAN = GOKCDMKKCMD_readData.NMOFFGFGFKA;
			List<int> CBDOEDKIOJK_list = new List<int>();
			for(int CBDOEDKIOJK_idx = 0; CBDOEDKIOJK_idx < GOKCDMKKCMD_readData.BMICKLAGCCDLength; CBDOEDKIOJK_idx++)
			{
				CBDOEDKIOJK_list.Add(GOKCDMKKCMD_readData.GetBMICKLAGCCD(CBDOEDKIOJK_idx));
			}
			GOKCDMKKCMD_data.CBDOEDKIOJK = CBDOEDKIOJK_list.ToArray();

			GOKCDMKKCMD_list.Add(GOKCDMKKCMD_data);
		}
		res_data.GOKCDMKKCMD = GOKCDMKKCMD_list.ToArray();

		List<CPNJPEHHNOO> PFGDBAIFLGL_list = new List<CPNJPEHHNOO>();
		for(int PFGDBAIFLGL_idx = 0; PFGDBAIFLGL_idx < res_readData.FHDMFCBDPHALength; PFGDBAIFLGL_idx++)
		{
			KPCLMCOLBNC PFGDBAIFLGL_readData = res_readData.GetFHDMFCBDPHA(PFGDBAIFLGL_idx);
			CPNJPEHHNOO PFGDBAIFLGL_data = new CPNJPEHHNOO();

			PFGDBAIFLGL_data.GNFJOONKCFH = PFGDBAIFLGL_readData.PAAOHNKLBAC;
			List<int> CBDOEDKIOJK_list = new List<int>();
			for(int CBDOEDKIOJK_idx = 0; CBDOEDKIOJK_idx < PFGDBAIFLGL_readData.BMICKLAGCCDLength; CBDOEDKIOJK_idx++)
			{
				CBDOEDKIOJK_list.Add(PFGDBAIFLGL_readData.GetBMICKLAGCCD(CBDOEDKIOJK_idx));
			}
			PFGDBAIFLGL_data.CBDOEDKIOJK = CBDOEDKIOJK_list.ToArray();

			PFGDBAIFLGL_list.Add(PFGDBAIFLGL_data);
		}
		res_data.PFGDBAIFLGL = PFGDBAIFLGL_list.ToArray();

		List<AMEBNIIIHNG> PPMOLKLDNLB_list = new List<AMEBNIIIHNG>();
		for(int PPMOLKLDNLB_idx = 0; PPMOLKLDNLB_idx < res_readData.LCCFMDJBNABLength; PPMOLKLDNLB_idx++)
		{
			INOFLJPLFAN PPMOLKLDNLB_readData = res_readData.GetLCCFMDJBNAB(PPMOLKLDNLB_idx);
			AMEBNIIIHNG PPMOLKLDNLB_data = new AMEBNIIIHNG();

			PPMOLKLDNLB_data.GNFJOONKCFH = PPMOLKLDNLB_readData.PAAOHNKLBAC;
			PPMOLKLDNLB_data.GLCLFMGPMAN = PPMOLKLDNLB_readData.MBBJMJAAODG;
			PPMOLKLDNLB_data.ADPPAIPFHML = PPMOLKLDNLB_readData.LFFMNLEJJMH;
			PPMOLKLDNLB_data.ACGLMKEBMDL = PPMOLKLDNLB_readData.PAEGHLMNPNO;
			PPMOLKLDNLB_data.FBFLDFMFFOH = PPMOLKLDNLB_readData.ODBPKGJPLMD;
			PPMOLKLDNLB_list.Add(PPMOLKLDNLB_data);
		}
		res_data.PPMOLKLDNLB = PPMOLKLDNLB_list.ToArray();

		List<GGKLHGBDPDD> BHGDNGHDDAC_list = new List<GGKLHGBDPDD>();
		for(int BHGDNGHDDAC_idx = 0; BHGDNGHDDAC_idx < res_readData.NJJINHMIOHNLength; BHGDNGHDDAC_idx++)
		{
			OAIMGJACOFK BHGDNGHDDAC_readData = res_readData.GetNJJINHMIOHN(BHGDNGHDDAC_idx);
			GGKLHGBDPDD BHGDNGHDDAC_data = new GGKLHGBDPDD();

			BHGDNGHDDAC_data.LJNAKDMILMC = BHGDNGHDDAC_readData.AGOIMGHMGOH;
			BHGDNGHDDAC_data.JBGEEPFKIGG = BHGDNGHDDAC_readData.KJFEBMBHKOC;
			BHGDNGHDDAC_list.Add(BHGDNGHDDAC_data);
		}
		res_data.BHGDNGHDDAC = BHGDNGHDDAC_list.ToArray();

		return res_data;
	}
}
