
using System.Collections.Generic;
using XeSys;

public class FPGEMAIAMBF
{
	public class LOIJICNJMKA
	{
		public enum KPGOMKPPJEE
		{
			PCNKFALHCDA = 0,
			FJGFAPKLLCL = 1,
			JMAFBDCPBJD = 2,
		}

		public int FCDKJAKLGMB; // 0x8
		public FPGEMAIAMBF.LOIJICNJMKA.KPGOMKPPJEE CMCKNKKCNDK; // 0xC
		public string JDMIKEEIJFP = ""; // 0x10
		public int KIJAPOFAGPN = 0; // 0x14
		public short MHFBCINOJEE_ItemId; // 0x18
		public byte HHACNFODNEF_Category; // 0x1A
		public int JDLJPNMLFID = 0; // 0x1C

		// RVA: 0x13FBB38 Offset: 0x13FBB38 VA: 0x13FBB38
		//public string LDBPEIMINJB() { }

		// RVA: 0x13FAEB0 Offset: 0x13FAEB0 VA: 0x13FAEB0
		public void GONNICAJNLK(int EIBBIJNFMDJ, HDNKOFNBCEO LIFCHFOPHDH)
		{
			KIJAPOFAGPN = LIFCHFOPHDH.FKNBLDPIPMC(EIBBIJNFMDJ);
			MHFBCINOJEE_ItemId = (short)EKLNMHFCAOI.DEACAHNLMNI_getItemId(KIJAPOFAGPN);
			HHACNFODNEF_Category = (byte)EKLNMHFCAOI.BKHFLDMOGBD_GetItemCategory(KIJAPOFAGPN);
			JDLJPNMLFID = LIFCHFOPHDH.KAINPNMMAEK(EIBBIJNFMDJ);
			JDMIKEEIJFP = MessageManager.Instance.GetBank("master").GetMessageByLabel(EKLNMHFCAOI.FKMCHHDOAAB(KIJAPOFAGPN));
		}
	}

	public const int IOEPCKJCLDN = 4;
	public const int IJNFLPDLFII = 4;
	public const int HHNMEMGOECJ = 4;
	public List<LOIJICNJMKA> IOCLNNCJFKA; // 0x8
	public List<LOIJICNJMKA> PDONJHCHBAE; // 0xC
	public List<LOIJICNJMKA> HFPMKBAANFO; // 0x10

	//// RVA: 0x13FA620 Offset: 0x13FA620 VA: 0x13FA620
	public void JMHCEMHPPCM(int GHBPLHBNMBK_MusicId, int AKNELONELJK_Difficulty, bool LFGNLKKFOCD_Is6Line, int MNNHHJBBICA_EventType = 0)
	{
		JDDGGJCGOPA_RecordMusic.EHFMCGGNPIJ_MusicInfo musicInfo;
		if (MNNHHJBBICA_EventType == 4)
		{
			if(JEPBIIJDGEF_EventInfo.HHCJCDFCLOB.AJLEDCKMFLP(KGCNCBOKCBA.GNENJEHKMHD.EMAMLLFAOJI) == null)
			{
				musicInfo = new JDDGGJCGOPA_RecordMusic.EHFMCGGNPIJ_MusicInfo();
			}
			else
			{
				HLEBAINCOME_EventScore eventData = JEPBIIJDGEF_EventInfo.HHCJCDFCLOB.AJLEDCKMFLP(KGCNCBOKCBA.GNENJEHKMHD.EMAMLLFAOJI) as HLEBAINCOME_EventScore;
				musicInfo = eventData.JIPPHOKGLIH(false).KJAFPNIFPGP();
			}
		}
		else
		{
			musicInfo = CIOECGOMILE.HHCJCDFCLOB.AHEFHIMGIBI_Save.LCKMBHDMPIP_RecordMusic.FAMANJGJANN_MusicInfo[GHBPLHBNMBK_MusicId - 1];
		}
		KEODKEGFDLD freemusicData = IMMAOANGPNK.HHCJCDFCLOB.NKEBMCIMJND_Database.IBPAFKKEKNK_Music.NOBCLJIAMLC_GetFreeMusicData(GHBPLHBNMBK_MusicId);
		int musicId = freemusicData.DLAEJOBELBH_Id;
		HDNKOFNBCEO rewardInfo = IMMAOANGPNK.HHCJCDFCLOB.NKEBMCIMJND_Database.IBPAFKKEKNK_Music.NEJKJJPIGKD_GetRewardInfo(freemusicData, AKNELONELJK_Difficulty, LFGNLKKFOCD_Is6Line);
		List<byte> l = LFGNLKKFOCD_Is6Line ? musicInfo.DKIIINIEKHP : musicInfo.JDIDBMEMKBC;
		List<byte> l2 = LFGNLKKFOCD_Is6Line ? musicInfo.JNNIOJIDNKM : musicInfo.AGGFHNMMGMN;
		List<byte> l3 = LFGNLKKFOCD_Is6Line ? musicInfo.LGBKKDOLOFP : musicInfo.HNDPLCDMOJF;
		ADDHLABEFKH otherInfo2 = freemusicData.EMJCHPDJHEI(LFGNLKKFOCD_Is6Line, AKNELONELJK_Difficulty);
		PDONJHCHBAE = new List<LOIJICNJMKA>();
		for(int i = 0; i < 4; i++)
		{
			LOIJICNJMKA lo = new LOIJICNJMKA();
			lo.FCDKJAKLGMB = otherInfo2.KNIFCANOHOC_RankScore[i];
			lo.CMCKNKKCNDK = i < l[AKNELONELJK_Difficulty] ? LOIJICNJMKA.KPGOMKPPJEE.FJGFAPKLLCL : LOIJICNJMKA.KPGOMKPPJEE.PCNKFALHCDA;
			lo.GONNICAJNLK(i+4, rewardInfo);
			PDONJHCHBAE.Add(lo);
		}
		HFPMKBAANFO = new List<LOIJICNJMKA>();
		for(int i = 0; i < 4; i++)
		{
			LOIJICNJMKA lo = new LOIJICNJMKA();
			lo.FCDKJAKLGMB = otherInfo2.NLKEBAOBJCM[i];
			lo.CMCKNKKCNDK = i < l2[AKNELONELJK_Difficulty] ? LOIJICNJMKA.KPGOMKPPJEE.FJGFAPKLLCL : LOIJICNJMKA.KPGOMKPPJEE.PCNKFALHCDA;
			lo.GONNICAJNLK(i + 8, rewardInfo);
			HFPMKBAANFO.Add(lo);
		}
		IOCLNNCJFKA = new List<LOIJICNJMKA>();
		for (int i = 0; i < 4; i++)
		{
			LOIJICNJMKA lo = new LOIJICNJMKA();
			lo.FCDKJAKLGMB = rewardInfo.GPBKAAMLIBF(i);
			lo.CMCKNKKCNDK = i < l3[AKNELONELJK_Difficulty] ? LOIJICNJMKA.KPGOMKPPJEE.FJGFAPKLLCL : LOIJICNJMKA.KPGOMKPPJEE.PCNKFALHCDA;
			lo.GONNICAJNLK(i, rewardInfo);
			IOCLNNCJFKA.Add(lo);
		}
	}

	//// RVA: 0x13FB01C Offset: 0x13FB01C VA: 0x13FB01C
	//public void CHOHLJOJKNJ(int GHBPLHBNMBK, int AKNELONELJK, bool LFGNLKKFOCD, int MNNHHJBBICA = 0) { }

	//// RVA: 0x13FBAD4 Offset: 0x13FBAD4 VA: 0x13FBAD4
	//public string LDBPEIMINJB() { }
}