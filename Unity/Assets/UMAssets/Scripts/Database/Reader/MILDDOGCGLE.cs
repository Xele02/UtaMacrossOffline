using FlatBuffers;
using System.Collections.Generic;

public class APLNHNOKJFK
{
	public uint OKECOPNBAGP { get; set; } // 0x8 GJMOEJLFGBN ACABAJEMECC CELOOGFFIKN
	public string OPFGFINHFCE { get; set; } // 0xC LGIIAPHCLPN DKJOHDGOIJE MJAMIGECMMF
	public int GBJFNGCDKPM { get; set; } // 0x10 GHLFADHILNN CEJJMKODOGK HOHCEBMMACI
	public int JMMEGKGCIIL { get; set; } // 0x14 ILCNHAFCAGN JDPKCAGDCLJ DNFIBINDNJO
	public int HANMDEBPBHG { get; set; } // 0x18 IMDBPCNAOOE EFGGIMOPNMG PNGGKPFDKMA
	public int PLALNIIBLOF { get; set; } // 0x1C DFMNDOMAPAB JPCJNLHHIPE JJFJNEJLBDG
	public int IJEKNCDIIAE { get; set; } // 0x20 FAHNCMHNFCG KJIMMIBDCIL DMEGNOKIKCD
	public uint PFJJFCPPNIN { get; set; } // 0x24 JDMOEHEIMKJ DPIIPBMNHOI LAKMHLJFOAL
}
public class COJBCBGIGHJ
{
	public uint ODMJFHDIGLP { get; set; } // 0x8 DKHKAJOLLPE IEACLNIEABJ KEOPEEKGMDO
	public uint PLALNIIBLOF { get; set; } // 0xC DFMNDOMAPAB JPCJNLHHIPE JJFJNEJLBDG
	public uint PPFNGGCBJKC { get; set; } // 0x10 FDGEMCPHJCB DEMEPMAEJOO HIGKAIDMOKN
	public uint OKECOPNBAGP { get; set; } // 0x14 GJMOEJLFGBN ACABAJEMECC CELOOGFFIKN
	public uint EPKOHDLIKAN { get; set; } // 0x18 HEFLNIKDCGO EPBFDHHAOMO BJFENLPFMDK
	public int KFCIJBLDHOK { get; set; } // 0x1C JPBPAFOAPIO EPEKNNHHPIF LFGKAMKBDGA
	public int JLEIHOEGMOP { get; set; } // 0x20 JLNAMGLBPME JJGFFGDDFPA LIIFHDMHLHP
	public int IJEKNCDIIAE { get; set; } // 0x24 FAHNCMHNFCG KJIMMIBDCIL DMEGNOKIKCD
}
public class EIDBDFGNCFB
{
	public int JBFLEDKDFCO { get; set; } // 0x8 JOECCKJHICK LIJMKJLDHGP NFNCLFPPADP
	public string OPFGFINHFCE { get; set; } // 0xC LGIIAPHCLPN DKJOHDGOIJE MJAMIGECMMF
	public string ONOPACPKFPK { get; set; } // 0x10 OHJDEFNDKDA DJMMMALFDDG PGMNJMHJHOG
	public uint HANMDEBPBHG { get; set; } // 0x14 IMDBPCNAOOE EFGGIMOPNMG PNGGKPFDKMA
	public uint PLALNIIBLOF { get; set; } // 0x18 DFMNDOMAPAB JPCJNLHHIPE JJFJNEJLBDG
	public int DJJNOCDIIAE { get; set; } // 0x1C KIEEONFHJJB APHILLHCKDM MBPPAEHAOAM
	public int CPKMLLNADLJ { get; set; } // 0x20 COPJCMLLIMO BJPJMGHCDNO BPKIOJBKNBP
}
public class CBGIPNJOPAH
{
	public int PPFNGGCBJKC { get; set; } // 0x8 FDGEMCPHJCB DEMEPMAEJOO HIGKAIDMOKN
	public int DOKKMMFKLJI { get; set; } // 0xC HHLLKENPACJ FGEACNKHOEB KNMBKMIELEO
}
public class MILDDOGCGLE
{
	public APLNHNOKJFK[] BHFAMKAPFNJ { get; set; } // 0x8 LAKHCMHJMAH IIMMELPMKAK JMAMGDOEKLP
	public COJBCBGIGHJ[] IPCJPOGBHGP { get; set; } // 0xC IOFJJIHICGF BLCLBJJAPNM KELNPDBEIBA
	public EIDBDFGNCFB[] CEPBAOMAHNH { get; set; } // 0x10 EALHHHABHEI KJBLMCHIKFD OEBMOJPBAEF
	public CBGIPNJOPAH[] ABIKKECOBIJ { get; set; } // 0x14 GKCCAOHFLPA NOAODGOPFJC NGBFPOINDKG
	public static MILDDOGCGLE HEGEKFMJNCC(byte[] NIODCJLINJN)// 0x1956DE4
	{
		ByteBuffer buffer = new ByteBuffer(NIODCJLINJN);
		DEMFEEEPCCO res_readData = DEMFEEEPCCO.GetRootAsDEMFEEEPCCO(buffer);
		MILDDOGCGLE res_data = new MILDDOGCGLE();

		List<APLNHNOKJFK> BHFAMKAPFNJ_list = new List<APLNHNOKJFK>();
		for(int BHFAMKAPFNJ_idx = 0; BHFAMKAPFNJ_idx < res_readData.ADNNNAFIBLDLength; BHFAMKAPFNJ_idx++)
		{
			OCJCBHOBGJJ BHFAMKAPFNJ_readData = res_readData.GetADNNNAFIBLD(BHFAMKAPFNJ_idx);
			APLNHNOKJFK BHFAMKAPFNJ_data = new APLNHNOKJFK();

			BHFAMKAPFNJ_data.OKECOPNBAGP = BHFAMKAPFNJ_readData.OCCGFNHHECN;
			BHFAMKAPFNJ_data.OPFGFINHFCE = BHFAMKAPFNJ_readData.IIDCFMHCPLJ;
			BHFAMKAPFNJ_data.GBJFNGCDKPM = BHFAMKAPFNJ_readData.LPJPOOHJKAE;
			BHFAMKAPFNJ_data.JMMEGKGCIIL = BHFAMKAPFNJ_readData.FKLNFLAFBDH;
			BHFAMKAPFNJ_data.HANMDEBPBHG = BHFAMKAPFNJ_readData.BLJLFEDLAME;
			BHFAMKAPFNJ_data.PLALNIIBLOF = BHFAMKAPFNJ_readData.CFLMCGOJJJD;
			BHFAMKAPFNJ_data.IJEKNCDIIAE = BHFAMKAPFNJ_readData.OFMGALJGDAO;
			BHFAMKAPFNJ_data.PFJJFCPPNIN = BHFAMKAPFNJ_readData.KKJFKKJHCAI;
			BHFAMKAPFNJ_list.Add(BHFAMKAPFNJ_data);
		}
		res_data.BHFAMKAPFNJ = BHFAMKAPFNJ_list.ToArray();

		List<COJBCBGIGHJ> IPCJPOGBHGP_list = new List<COJBCBGIGHJ>();
		for(int IPCJPOGBHGP_idx = 0; IPCJPOGBHGP_idx < res_readData.NEPBOHLLOGMLength; IPCJPOGBHGP_idx++)
		{
			JCPFGFKDDJP IPCJPOGBHGP_readData = res_readData.GetNEPBOHLLOGM(IPCJPOGBHGP_idx);
			COJBCBGIGHJ IPCJPOGBHGP_data = new COJBCBGIGHJ();

			IPCJPOGBHGP_data.ODMJFHDIGLP = IPCJPOGBHGP_readData.NCIKNCJLFBI;
			IPCJPOGBHGP_data.PLALNIIBLOF = IPCJPOGBHGP_readData.CFLMCGOJJJD;
			IPCJPOGBHGP_data.PPFNGGCBJKC = IPCJPOGBHGP_readData.BBPHAPFBFHK;
			IPCJPOGBHGP_data.OKECOPNBAGP = IPCJPOGBHGP_readData.OCCGFNHHECN;
			IPCJPOGBHGP_data.EPKOHDLIKAN = IPCJPOGBHGP_readData.JKAAFPNGHGN;
			IPCJPOGBHGP_data.KFCIJBLDHOK = IPCJPOGBHGP_readData.MCJNHPMBPIJ;
			IPCJPOGBHGP_data.JLEIHOEGMOP = IPCJPOGBHGP_readData.MGJKFKDICGC;
			IPCJPOGBHGP_data.IJEKNCDIIAE = IPCJPOGBHGP_readData.OFMGALJGDAO;
			IPCJPOGBHGP_list.Add(IPCJPOGBHGP_data);
		}
		res_data.IPCJPOGBHGP = IPCJPOGBHGP_list.ToArray();

		List<EIDBDFGNCFB> CEPBAOMAHNH_list = new List<EIDBDFGNCFB>();
		for(int CEPBAOMAHNH_idx = 0; CEPBAOMAHNH_idx < res_readData.MMKDCMGIEKMLength; CEPBAOMAHNH_idx++)
		{
			AHKFABMCFNG CEPBAOMAHNH_readData = res_readData.GetMMKDCMGIEKM(CEPBAOMAHNH_idx);
			EIDBDFGNCFB CEPBAOMAHNH_data = new EIDBDFGNCFB();

			CEPBAOMAHNH_data.JBFLEDKDFCO = CEPBAOMAHNH_readData.HOENDPOGFIO;
			CEPBAOMAHNH_data.OPFGFINHFCE = CEPBAOMAHNH_readData.IIDCFMHCPLJ;
			CEPBAOMAHNH_data.ONOPACPKFPK = CEPBAOMAHNH_readData.JFJLBDICHHJ;
			CEPBAOMAHNH_data.HANMDEBPBHG = CEPBAOMAHNH_readData.BLJLFEDLAME;
			CEPBAOMAHNH_data.PLALNIIBLOF = CEPBAOMAHNH_readData.CFLMCGOJJJD;
			CEPBAOMAHNH_data.DJJNOCDIIAE = CEPBAOMAHNH_readData.BPOKEPDFBCO;
			CEPBAOMAHNH_data.CPKMLLNADLJ = CEPBAOMAHNH_readData.LMLNKHMPOIG;
			CEPBAOMAHNH_list.Add(CEPBAOMAHNH_data);
		}
		res_data.CEPBAOMAHNH = CEPBAOMAHNH_list.ToArray();

		List<CBGIPNJOPAH> ABIKKECOBIJ_list = new List<CBGIPNJOPAH>();
		for(int ABIKKECOBIJ_idx = 0; ABIKKECOBIJ_idx < res_readData.OANLFAKIJOFLength; ABIKKECOBIJ_idx++)
		{
			NCHJODAGBPK ABIKKECOBIJ_readData = res_readData.GetOANLFAKIJOF(ABIKKECOBIJ_idx);
			CBGIPNJOPAH ABIKKECOBIJ_data = new CBGIPNJOPAH();

			ABIKKECOBIJ_data.PPFNGGCBJKC = ABIKKECOBIJ_readData.BBPHAPFBFHK;
			ABIKKECOBIJ_data.DOKKMMFKLJI = ABIKKECOBIJ_readData.DMJIIMKLBAL;
			ABIKKECOBIJ_list.Add(ABIKKECOBIJ_data);
		}
		res_data.ABIKKECOBIJ = ABIKKECOBIJ_list.ToArray();

		return res_data;
	}
}
