
using System.Collections.Generic;
using XeApp.Game.Common;
using XeApp.Game.Menu;

public class CGJKNOCAPII
{
	public string JOPOPMLFINI; // 0x8
	public string DGCOMDILAKM; // 0xC
	public int PGIIDPEGGPI; // 0x10
	public int JHAOHBNPMNA; // 0x14
	public int LFCOJABLOEN; // 0x18
	public long KINJOEIAHFK_Start; // 0x20
	public long PCCFAKEOBIC_End; // 0x28
	public int BCOKKAALGHC; // 0x30
	public bool PNFDMBHDPAJ; // 0x34
	public BadgeConstant.ID BEEIIJJKDBH; // 0x38
	public string BHANMJKCCBC; // 0x3C
	public int PKNLMLDKCLM; // 0x40
	public IKDICBBFBMI_EventBase COAMJFMEIBF; // 0x44
	public BKANGIKIEML.NODKLJHEAJB NNHHNFFLCFO; // 0x48
	public long BALFPCLMOGJ; // 0x50

	//// RVA: 0x12BC47C Offset: 0x12BC47C VA: 0x12BC47C
	//public int KJILFMNCDLC() { }

	//// RVA: 0x12BC584 Offset: 0x12BC584 VA: 0x12BC584
	//public CGJKNOCAPII BJKJLDPDEFA(IKDICBBFBMI FBFNJMKPBBA, bool PNGKOHDEPFE = True) { }

	//// RVA: 0x12BC978 Offset: 0x12BC978 VA: 0x12BC978
	public static List<CGJKNOCAPII> JHCHAOJFHFG(bool PNGKOHDEPFE = true)
	{
		List<CGJKNOCAPII> res = new List<CGJKNOCAPII>();
		List<CGJKNOCAPII> l2 = new List<CGJKNOCAPII>();
		long time = NKGJPJPHLIF.HHCJCDFCLOB.IBLPICFDGOF_ServerRequester.FJDBNGEPKHL.KMEFBNBFJHI_GetServerTime();
		for(int i = 0; i < JEPBIIJDGEF_EventInfo.HHCJCDFCLOB.MPEOOINCGEN.Count; i++)
		{
			TodoLogger.Log(0, "JHCHAOJFHFG");
		}
		res.Sort((CGJKNOCAPII HKICMNAACDA, CGJKNOCAPII BNKHBCBJBKI) =>
		{
			//0x12BD938
			if (HKICMNAACDA.PCCFAKEOBIC_End == BNKHBCBJBKI.PCCFAKEOBIC_End)
				return HKICMNAACDA.JHAOHBNPMNA.CompareTo(BNKHBCBJBKI.JHAOHBNPMNA);
			return HKICMNAACDA.PCCFAKEOBIC_End.CompareTo(BNKHBCBJBKI.PCCFAKEOBIC_End);
		});
		l2.Sort((CGJKNOCAPII HKICMNAACDA, CGJKNOCAPII BNKHBCBJBKI) =>
		{
			//0x12BD9C4
			if (HKICMNAACDA.PCCFAKEOBIC_End == BNKHBCBJBKI.PCCFAKEOBIC_End)
				return HKICMNAACDA.JHAOHBNPMNA.CompareTo(BNKHBCBJBKI.JHAOHBNPMNA);
			return HKICMNAACDA.PCCFAKEOBIC_End.CompareTo(BNKHBCBJBKI.PCCFAKEOBIC_End);
		});
		res.AddRange(l2);
		return res;
	}

	//// RVA: 0x12BD220 Offset: 0x12BD220 VA: 0x12BD220
	public CGJKNOCAPII NLCNDMLOCBC(int APFDNBGMMMM, bool PNGKOHDEPFE = true)
	{
		CGJKNOCAPII res = new CGJKNOCAPII();
		res.JOPOPMLFINI = "";
		res.DGCOMDILAKM = "";
		res.PGIIDPEGGPI = APFDNBGMMMM;
		res.JHAOHBNPMNA = GNGMCIAIKMA.HHCJCDFCLOB.CBMJAPJKBNL(APFDNBGMMMM);
		res.LFCOJABLOEN = GNGMCIAIKMA.HHCJCDFCLOB.CBMJAPJKBNL(APFDNBGMMMM);
		res.COAMJFMEIBF = null;
		JKICPBIIHNE_Bingo.HNOGDJFJGPM bingo = GNGMCIAIKMA.HHCJCDFCLOB.EBEDAPJFHCE_GetBingo(APFDNBGMMMM);
		res.KINJOEIAHFK_Start = bingo.PDBPFJJCADD_StartTime;
		res.NNHHNFFLCFO = BKANGIKIEML.NODKLJHEAJB.BPNDHDHHKGE/*38*/;
		res.BEEIIJJKDBH = 0;
		res.PCCFAKEOBIC_End = bingo.FDBNFFNFOND_EndTime;
		res.PNFDMBHDPAJ = false;
		res.BHANMJKCCBC = "";
		if(PNGKOHDEPFE)
		{
			res.PKNLMLDKCLM = GNGMCIAIKMA.HHCJCDFCLOB.OBOGIOGEBPK(APFDNBGMMMM, FKMOKDCJFEN.ADCPCCNCOMD_Status.FJGFAPKLLCL_Achieved);
			if(res.PKNLMLDKCLM > 0)
			{
				res.BHANMJKCCBC = QuestUtility.GetAchievedCountText(res.PKNLMLDKCLM);
			}
		}
		res.BALFPCLMOGJ = 0;
		if(!GNGMCIAIKMA.HHCJCDFCLOB.DOEGBMNNFKH(APFDNBGMMMM))
		{
			if(!GNGMCIAIKMA.HHCJCDFCLOB.DHPLHALIDHH(APFDNBGMMMM))
			{
				res.BALFPCLMOGJ = GNGMCIAIKMA.HHCJCDFCLOB.GKDBBGIEPLC(APFDNBGMMMM);
			}
		}
		return res;
	}

	//// RVA: 0x12BD520 Offset: 0x12BD520 VA: 0x12BD520
	public static List<CGJKNOCAPII> GOGBAODOOAO(bool PNGKOHDEPFE = true)
	{
		List<CGJKNOCAPII> res = new List<CGJKNOCAPII>();
		if(GNGMCIAIKMA.HHCJCDFCLOB != null)
		{
			long time = NKGJPJPHLIF.HHCJCDFCLOB.IBLPICFDGOF_ServerRequester.FJDBNGEPKHL.KMEFBNBFJHI_GetServerTime();
			GNGMCIAIKMA.HHCJCDFCLOB.KIAAOBFJCHP(time);
			List<int> bingos = GNGMCIAIKMA.HHCJCDFCLOB.CNADOFDDNLO_GetActiveBingos(time);
			for(int i = 0; i < bingos.Count; i++)
			{
				CGJKNOCAPII data = new CGJKNOCAPII();
				CGJKNOCAPII data2 = data.NLCNDMLOCBC(bingos[i], PNGKOHDEPFE);
				res.Add(data2);
			}
			res.Sort((CGJKNOCAPII HKICMNAACDA, CGJKNOCAPII BNKHBCBJBKI) =>
			{
				//0x12BDA50
				if (HKICMNAACDA.PCCFAKEOBIC_End == BNKHBCBJBKI.PCCFAKEOBIC_End)
					return HKICMNAACDA.JHAOHBNPMNA.CompareTo(BNKHBCBJBKI.JHAOHBNPMNA);
				return HKICMNAACDA.PCCFAKEOBIC_End.CompareTo(BNKHBCBJBKI.PCCFAKEOBIC_End);
			});
		}
		return res;
	}
}
