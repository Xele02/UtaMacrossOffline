using FlatBuffers;
using System.Collections.Generic;

public class FGABLOBFLHC
{
	public uint PPFNGGCBJKC { get; set; } // 0x8 FDGEMCPHJCB DEMEPMAEJOO HIGKAIDMOKN
	public uint OCAMDLMPBGA { get; set; } // 0xC JKDMAFHPKDJ DHOGDENEIOI DBDFNFLGDFN
	public uint LKMHPJKIFDN { get; set; } // 0x10 CJAAANEJOAK LAGBBLNKFFG OBHBLAIPBFO
	public uint DLAIGBEOGNN { get; set; } // 0x14 ADEEDEMALFA KFHHLPALPDI PEPBOMHIJNH
	public uint PLALNIIBLOF { get; set; } // 0x18 DFMNDOMAPAB JPCJNLHHIPE JJFJNEJLBDG
	public int IJEKNCDIIAE { get; set; } // 0x1C FAHNCMHNFCG KJIMMIBDCIL DMEGNOKIKCD
	public int DBHPPMPNCKF { get; set; } // 0x20 PLPJBFEDAOM JHLPDKDGDJB GBKBPCELENK
	public int GMOOKMONMMD { get; set; } // 0x24 POEDEEAABOK LMNLEACGCGF BPCNCBENPAD
	public int DOJAMIPOKBD { get; set; } // 0x28 FACHAGDIPHF OLENMLPLPCM PJPIGHFAABB
	public int MDEBEGADHOH { get; set; } // 0x2C IEAMHLCNGDC GBGKHOKBPFM DKGHKHPDMAE
	public int JILNNPKFKEK { get; set; } // 0x30 BLMIMJFOHLP FONALDEFKFK AAIAHAOEDLA
	public int GOFFPLJKIIB { get; set; } // 0x34 OBAKBGAJPEI BBNJAOOJFGA NEDJCHBKINE
	public int NFEJAAOAFPG { get; set; } // 0x38 PDCBJPFIIBO OGNOBILICJE FGHMAIMKBMJ
	public int[] BFIFIDKOJGD { get; set; } // 0x3C PHJFHDJCLCJ DKPGPLFHGAI DAOGMNDELMD
	public int[] AJNPNDIDJLD { get; set; } // 0x40 KNIHGKCAJHI HMNMPJPLKKD BHJDILEDECA
	public int[] GMKDHMPGLFL { get; set; } // 0x44 NDKGBLDKBFH HHPAKPMAJIH EPAKHJPAPPO
	public int JBPJAGOJMFA { get; set; } // 0x48 MODEJBAGAPB AGJGJBHCMPC KPJHEPNNLDN
}
public class ECFLPFIJGGC
{
	public int MJMPANIBFED { get; set; } // 0x8 GGAJJGLDIII LPHIIIAOHBE POHHJDNBLOD
	public int[] KIONHNAPIOM { get; set; } // 0xC NKBILNEOHPK BPFCMINAGBG MGCJOKCGKLA
}
public class GPBHHNACMOP
{
	public int PGPGPJNBIOH { get; set; } // 0x8 CAIBNHDMKJD CJEDGLPDJBN EKJKPIKJLJJ
	public int[] GNKAPBFMIDE { get; set; } // 0xC GCJBHIOODHI IAGIBIGJINB NFGBFKFKBOP
}
public class OJHOANCOJIK
{
	public int CHOIMHCMAHG { get; set; } // 0x8 ALCEBFJAGJB APOIMEHLPBD HJFDHIEGGBH
	public int[] IKKKOBGCPGN { get; set; } // 0xC HMKFJELDLHP HDKGHOPLJOP MCAGPNNLIJH
	public int[] CHIFFONJIAD { get; set; } // 0x10 HLHDPIMMEPG MOKENIJJDAL AKJPOFAINEK
}
public class JAELFHFCDDH
{
	public int AMCICCBMHJC { get; set; } // 0x8 LLBHIHBEOHD GPEPHKOOOEO CCFMEJMIFLP
	public int HFIFHDCJFPM { get; set; } // 0xC IEABCLEADGN NGGOBDGMNKD NEDLOLPFJII
}
public class IBCDCBLBJKE
{
	public FGABLOBFLHC[] MDFBOCBCGGE { get; set; } // 0x8 HPNCLJOBGMP PGEIBFCKNHN BDLAGBBJIHM
	public ECFLPFIJGGC[] EIDOFLACDGH { get; set; } // 0xC BAHDNECPOIE IMOOMHJJEPF DNKNKOBFBMP
	public GPBHHNACMOP[] HJPKLNPDDHN { get; set; } // 0x10 BPLAGEOJCMG OOMODFJKJLK JKIOMFFHMLK
	public OJHOANCOJIK[] MMCDFGKCEPO { get; set; } // 0x14 DAEDGKFFPIJ BPOPLCMHLLL OJCCGHIJMMC
	public JAELFHFCDDH[] ODKFBJEOCGB { get; set; } // 0x18 FDEEKNONDIP CEPIHAMNKIB AAPFDNEFHKD
	public static IBCDCBLBJKE HEGEKFMJNCC(byte[] NIODCJLINJN)// 0x1211238
	{
		ByteBuffer buffer = new ByteBuffer(NIODCJLINJN);
		OGCAPIHPNLC res_readData = OGCAPIHPNLC.GetRootAsOGCAPIHPNLC(buffer);
		IBCDCBLBJKE res_data = new IBCDCBLBJKE();

		List<FGABLOBFLHC> MDFBOCBCGGE_list = new List<FGABLOBFLHC>();
		for(int MDFBOCBCGGE_idx = 0; MDFBOCBCGGE_idx < res_readData.AMNNIENGDHILength; MDFBOCBCGGE_idx++)
		{
			BPDPIFOLPDM MDFBOCBCGGE_readData = res_readData.GetAMNNIENGDHI(MDFBOCBCGGE_idx);
			FGABLOBFLHC MDFBOCBCGGE_data = new FGABLOBFLHC();

			MDFBOCBCGGE_data.PPFNGGCBJKC = MDFBOCBCGGE_readData.BBPHAPFBFHK;
			MDFBOCBCGGE_data.OCAMDLMPBGA = MDFBOCBCGGE_readData.DDMBKEJNPJK;
			MDFBOCBCGGE_data.LKMHPJKIFDN = MDFBOCBCGGE_readData.JLBMBKHBKBG;
			MDFBOCBCGGE_data.DLAIGBEOGNN = MDFBOCBCGGE_readData.EHIBOEAILLI;
			MDFBOCBCGGE_data.PLALNIIBLOF = MDFBOCBCGGE_readData.CFLMCGOJJJD;
			MDFBOCBCGGE_data.IJEKNCDIIAE = MDFBOCBCGGE_readData.OFMGALJGDAO;
			MDFBOCBCGGE_data.DBHPPMPNCKF = MDFBOCBCGGE_readData.OILFLMOBFJM;
			MDFBOCBCGGE_data.GMOOKMONMMD = MDFBOCBCGGE_readData.KBGHNCHBLHN;
			MDFBOCBCGGE_data.DOJAMIPOKBD = MDFBOCBCGGE_readData.DAEBPADJEOK;
			MDFBOCBCGGE_data.MDEBEGADHOH = MDFBOCBCGGE_readData.JMADKJNCBCO;
			MDFBOCBCGGE_data.JILNNPKFKEK = MDFBOCBCGGE_readData.DIGHIPFGPAP;
			MDFBOCBCGGE_data.GOFFPLJKIIB = MDFBOCBCGGE_readData.GNPNCHPOGNL;
			MDFBOCBCGGE_data.NFEJAAOAFPG = MDFBOCBCGGE_readData.CODDJJEBDNG;
			List<int> BFIFIDKOJGD_list = new List<int>();
			for(int BFIFIDKOJGD_idx = 0; BFIFIDKOJGD_idx < MDFBOCBCGGE_readData.PGEKHEFEBOCLength; BFIFIDKOJGD_idx++)
			{
				BFIFIDKOJGD_list.Add(MDFBOCBCGGE_readData.GetPGEKHEFEBOC(BFIFIDKOJGD_idx));
			}
			MDFBOCBCGGE_data.BFIFIDKOJGD = BFIFIDKOJGD_list.ToArray();

			List<int> AJNPNDIDJLD_list = new List<int>();
			for(int AJNPNDIDJLD_idx = 0; AJNPNDIDJLD_idx < MDFBOCBCGGE_readData.IIFJDHKAMEDLength; AJNPNDIDJLD_idx++)
			{
				AJNPNDIDJLD_list.Add(MDFBOCBCGGE_readData.GetIIFJDHKAMED(AJNPNDIDJLD_idx));
			}
			MDFBOCBCGGE_data.AJNPNDIDJLD = AJNPNDIDJLD_list.ToArray();

			List<int> GMKDHMPGLFL_list = new List<int>();
			for(int GMKDHMPGLFL_idx = 0; GMKDHMPGLFL_idx < MDFBOCBCGGE_readData.FCDHEJINFPHLength; GMKDHMPGLFL_idx++)
			{
				GMKDHMPGLFL_list.Add(MDFBOCBCGGE_readData.GetFCDHEJINFPH(GMKDHMPGLFL_idx));
			}
			MDFBOCBCGGE_data.GMKDHMPGLFL = GMKDHMPGLFL_list.ToArray();

			MDFBOCBCGGE_data.JBPJAGOJMFA = MDFBOCBCGGE_readData.MFKMAPAOPLN;
			MDFBOCBCGGE_list.Add(MDFBOCBCGGE_data);
		}
		res_data.MDFBOCBCGGE = MDFBOCBCGGE_list.ToArray();

		List<ECFLPFIJGGC> EIDOFLACDGH_list = new List<ECFLPFIJGGC>();
		for(int EIDOFLACDGH_idx = 0; EIDOFLACDGH_idx < res_readData.OAHKOBDODPGLength; EIDOFLACDGH_idx++)
		{
			HJIPOJKELHB EIDOFLACDGH_readData = res_readData.GetOAHKOBDODPG(EIDOFLACDGH_idx);
			ECFLPFIJGGC EIDOFLACDGH_data = new ECFLPFIJGGC();

			EIDOFLACDGH_data.MJMPANIBFED = EIDOFLACDGH_readData.COPFAKAHEMN;
			List<int> KIONHNAPIOM_list = new List<int>();
			for(int KIONHNAPIOM_idx = 0; KIONHNAPIOM_idx < EIDOFLACDGH_readData.CEPFOAEFOEALength; KIONHNAPIOM_idx++)
			{
				KIONHNAPIOM_list.Add(EIDOFLACDGH_readData.GetCEPFOAEFOEA(KIONHNAPIOM_idx));
			}
			EIDOFLACDGH_data.KIONHNAPIOM = KIONHNAPIOM_list.ToArray();

			EIDOFLACDGH_list.Add(EIDOFLACDGH_data);
		}
		res_data.EIDOFLACDGH = EIDOFLACDGH_list.ToArray();

		List<GPBHHNACMOP> HJPKLNPDDHN_list = new List<GPBHHNACMOP>();
		for(int HJPKLNPDDHN_idx = 0; HJPKLNPDDHN_idx < res_readData.PMHBCDENHAILength; HJPKLNPDDHN_idx++)
		{
			GJNHKIDNFJO HJPKLNPDDHN_readData = res_readData.GetPMHBCDENHAI(HJPKLNPDDHN_idx);
			GPBHHNACMOP HJPKLNPDDHN_data = new GPBHHNACMOP();

			HJPKLNPDDHN_data.PGPGPJNBIOH = HJPKLNPDDHN_readData.LLJMKBDBIGN;
			List<int> GNKAPBFMIDE_list = new List<int>();
			for(int GNKAPBFMIDE_idx = 0; GNKAPBFMIDE_idx < HJPKLNPDDHN_readData.CLFGGLFAJKHLength; GNKAPBFMIDE_idx++)
			{
				GNKAPBFMIDE_list.Add(HJPKLNPDDHN_readData.GetCLFGGLFAJKH(GNKAPBFMIDE_idx));
			}
			HJPKLNPDDHN_data.GNKAPBFMIDE = GNKAPBFMIDE_list.ToArray();

			HJPKLNPDDHN_list.Add(HJPKLNPDDHN_data);
		}
		res_data.HJPKLNPDDHN = HJPKLNPDDHN_list.ToArray();

		List<OJHOANCOJIK> MMCDFGKCEPO_list = new List<OJHOANCOJIK>();
		for(int MMCDFGKCEPO_idx = 0; MMCDFGKCEPO_idx < res_readData.DABMEKCEBEPLength; MMCDFGKCEPO_idx++)
		{
			POLDFBLCDFN MMCDFGKCEPO_readData = res_readData.GetDABMEKCEBEP(MMCDFGKCEPO_idx);
			OJHOANCOJIK MMCDFGKCEPO_data = new OJHOANCOJIK();

			MMCDFGKCEPO_data.CHOIMHCMAHG = MMCDFGKCEPO_readData.DNIDLBOLLGH;
			List<int> IKKKOBGCPGN_list = new List<int>();
			for(int IKKKOBGCPGN_idx = 0; IKKKOBGCPGN_idx < MMCDFGKCEPO_readData.KMKKKKNNFGBLength; IKKKOBGCPGN_idx++)
			{
				IKKKOBGCPGN_list.Add(MMCDFGKCEPO_readData.GetKMKKKKNNFGB(IKKKOBGCPGN_idx));
			}
			MMCDFGKCEPO_data.IKKKOBGCPGN = IKKKOBGCPGN_list.ToArray();

			List<int> CHIFFONJIAD_list = new List<int>();
			for(int CHIFFONJIAD_idx = 0; CHIFFONJIAD_idx < MMCDFGKCEPO_readData.NDOLMCLBIBFLength; CHIFFONJIAD_idx++)
			{
				CHIFFONJIAD_list.Add(MMCDFGKCEPO_readData.GetNDOLMCLBIBF(CHIFFONJIAD_idx));
			}
			MMCDFGKCEPO_data.CHIFFONJIAD = CHIFFONJIAD_list.ToArray();

			MMCDFGKCEPO_list.Add(MMCDFGKCEPO_data);
		}
		res_data.MMCDFGKCEPO = MMCDFGKCEPO_list.ToArray();

		List<JAELFHFCDDH> ODKFBJEOCGB_list = new List<JAELFHFCDDH>();
		for(int ODKFBJEOCGB_idx = 0; ODKFBJEOCGB_idx < res_readData.EPPNEJBPKMFLength; ODKFBJEOCGB_idx++)
		{
			JMGNAIJPDBF ODKFBJEOCGB_readData = res_readData.GetEPPNEJBPKMF(ODKFBJEOCGB_idx);
			JAELFHFCDDH ODKFBJEOCGB_data = new JAELFHFCDDH();

			ODKFBJEOCGB_data.AMCICCBMHJC = ODKFBJEOCGB_readData.HDAGLLICBAO;
			ODKFBJEOCGB_data.HFIFHDCJFPM = ODKFBJEOCGB_readData.AJAPPNMNKJH;
			ODKFBJEOCGB_list.Add(ODKFBJEOCGB_data);
		}
		res_data.ODKFBJEOCGB = ODKFBJEOCGB_list.ToArray();

		return res_data;
	}
}
