using System.Collections.Generic;
using System.Text;
using XeApp.Game.Common;
using XeSys;

public class FFHPBEPOMAK
{
	public class CLKBDNBMJCO
	{
		private const int FBGGEFFJJHB = 1561969535;
		private int IJNIDKLFABD; // 0x8
		private int JHKNDAGGOMG; // 0xC
		private int KLDFJGOKIKC; // 0x10
		private int CNKBEJHMHCP; // 0x14
		private int LMFEACDAOBG; // 0x18
		private int KCHNHFLJIDD; // 0x1C

		// public int KAMIJDBFGDB { get; set; } 0x14E4A68 0x14E4A7C
		// public int BPEFIIEPJBM { get; set; } 0x14E4A90 0x14E4AA4
		// public int DNFEEOODOBF { get; set; } 0x14E4AB8 0x14E4ACC
		// public int EMGLOGKKGKJ { get; set; } 0x14E4AE0 0x14E4AF4
		// public int FKHKMNEHBOJ { get; set; } 0x14E4B08 0x14E4B1C
		// public int PHOFGCKGIIA { get; set; } 0x14E4B30 0x14E4B44

		// // RVA: 0x14DF200 Offset: 0x14DF200 VA: 0x14DF200
		public void KHEKNNFCAOI(int AHHJLDLAPAN)
		{
			DEKKMGAFJCG_Diva.MNNLOBDPCCH_DivaInfo a = CIOECGOMILE.HHCJCDFCLOB.AHEFHIMGIBI_ServerSave.DGCJCAHIAPP_Diva.NBIGLBMHEDC_DivaList[AHHJLDLAPAN - 1];
			IJNIDKLFABD = a.MMCEMJILMJI_EvSoLevel ^ FBGGEFFJJHB;
			JHKNDAGGOMG = a.HDPANGMKKCP_EvVoLevel ^ FBGGEFFJJHB;
			KLDFJGOKIKC = a.FFMLBEEBHDD_EvChLevel ^ FBGGEFFJJHB;
		}

		// // RVA: 0x14E02F0 Offset: 0x14E02F0 VA: 0x14E02F0
		public int PNOKIEEILJN()
		{
			return IMMAOANGPNK.HHCJCDFCLOB.NKEBMCIMJND_Database.OAINIGNLJKC_Diva2.LENIIENHJJK[IJNIDKLFABD ^ FBGGEFFJJHB].MKMIEGPOKGG;
		}

		// // RVA: 0x14E045C Offset: 0x14E045C VA: 0x14E045C
		public int LCDIGPJJJGI()
		{
			return IMMAOANGPNK.HHCJCDFCLOB.NKEBMCIMJND_Database.OAINIGNLJKC_Diva2.LENIIENHJJK[JHKNDAGGOMG ^ FBGGEFFJJHB].MELGGCAIONF;
		}

		// // RVA: 0x14E05C8 Offset: 0x14E05C8 VA: 0x14E05C8
		public int KDKCMCBLEMG()
		{
			return IMMAOANGPNK.HHCJCDFCLOB.NKEBMCIMJND_Database.OAINIGNLJKC_Diva2.LENIIENHJJK[KLDFJGOKIKC ^ FBGGEFFJJHB].LDLHPACIIAB;
		}

		// // RVA: 0x14E4B58 Offset: 0x14E4B58 VA: 0x14E4B58
		// public int PJCKMKEJCEL() { }
	}

	private bool BNFDBPPOAOE; // 0x8
	private bool EEBBAGGJOGH; // 0x9
	public int AHHJLDLAPAN_DivaId; // 0xC
	public int CIEOBFIIPLD; // 0x10
	public int AIHCEGFANAM; // 0x14
	public string OPFGFINHFCE_DivaName; // 0x18
	public bool FJODMPGPDDD; // 0x28
	public bool IPJMPBANBPP; // 0x29
	public byte[] FFKMEFKOBHO; // 0x2C
	public List<byte[]> FGBKIPNGGJM = new List<byte[]>(); // 0x30
	public byte[] PFCJIKGENEH; // 0x34
	public List<byte[]> GDJPNDKMKPG = new List<byte[]>(); // 0x38
	public int AICGALGPFMO; // 0x3C
	public List<int> HHKFOOFPOJL = new List<int>(); // 0x40
	public bool JLKPGDEKPEO; // 0x58
	public bool CPGDEPMPMFK; // 0x59
	public bool MBFADDHOEOK; // 0x5A
	public CKFGMNAIBNG FFKMJNHFFFL = new CKFGMNAIBNG(); // 0x5C
	public CKFGMNAIBNG EGAFMGDFFCH = new CKFGMNAIBNG(); // 0x60
	private BBHNACPENDM_ServerSaveData LDEGEHAEALK; // 0x78
	// public static DisplayType[] HBBPOMBJJNG = new DisplayType[8] { 0, 1, 2, 3, 7, 8, 9, 10 }; // 0x0

	public StatusData JLJGCBOHJID_Status { get; private set; } = new StatusData(); // 0x1C MHGEJIKLJOP CKAOBJJCOFO MKFJBBFNFPD
	public StatusData CMCKNKKCNDK_EquippedStatus { get; private set; } = new StatusData(); // 0x20 CLCJNFNMNBH CNKGOPKANGF CHJGGLFGALP
	public List<int> DJICAKGOGFO { get; private set; } // 0x24 GIOHLILFNGF HFNMIBKHCPA OOEOBODDEBH
	public int FGFIBOBAPIA { get; private set; } // 0x44 HIFDNPNIAAH DEDCNFGKGEH JINCEPHFFBN
	public int JPIDIENBGKH { get; private set; } // 0x48 CPCGNLOMIJL PHLLMIGCPCB BLBNMENMCIF
	public int EKFONBFDAAP_ColorId { get; private set; } // 0x4C GDOPIDINPAJ EIIGMAIDCAG BLGOCKHBMIG
	public int KIIMFCFMMDN { get; private set; } // 0x50 NBEBILCKAIH GBBCNBOMGIH GAAGDLPJGKN
	public int JFFLFIMIMOI { get; private set; } // 0x54 BENJFMIAAIP EPDJMLMLHIG FJBIDEJJHOD
	public int KELFCMEOPPM { get; private set; } // 0x64 LOEOGJLMNME AHJNJHDELBE PJLFKEOLFMK
	public List<int> PKLPGBKKFOL { get; private set; } // 0x68 IOKGPGPGGPL ODHMENNBBML JLIFOJJIDIG
	public List<int> HMBECPGHPOE { get; private set; } // 0x6C BAMGHOCFIIG HDJMNMAPPAJ GBMDLJBJILK
	public List<int> FOHEIOLPAOG { get; private set; } // 0x70 IEPHLHPLBGB BEFACAKCODI HMAHEFFHNIO
	public FFHPBEPOMAK.CLKBDNBMJCO IHANGGCHPAL { get; private set; } = new FFHPBEPOMAK.CLKBDNBMJCO(); // 0x74 DCLILLHDINA NIBJBLCDIHD MBAKEDKIJDG

	// RVA: 0x14DE1BC Offset: 0x14DE1BC VA: 0x14DE1BC
	// public void LEHDLBJJBNC() { }

	// RVA: 0x14DE4E0 Offset: 0x14DE4E0 VA: 0x14DE4E0
	public void KHEKNNFCAOI(int AHHJLDLAPAN_DivaId, BBHNACPENDM_ServerSaveData NIMOGBDCMLJ, bool OJEBNBLHPNP = false)
	{
		BNFDBPPOAOE = true;
		EEBBAGGJOGH = false;
		if(NIMOGBDCMLJ == null)
		{
			LDEGEHAEALK = CIOECGOMILE.HHCJCDFCLOB.AHEFHIMGIBI_ServerSave;
			this.AHHJLDLAPAN_DivaId = AHHJLDLAPAN_DivaId;
		}
		else
		{
			LDEGEHAEALK = NIMOGBDCMLJ;
			this.AHHJLDLAPAN_DivaId = AHHJLDLAPAN_DivaId;
		}
		PKLPGBKKFOL = LDEGEHAEALK.DGCJCAHIAPP_Diva.NBIGLBMHEDC_DivaList[AHHJLDLAPAN_DivaId - 1].ANAJIAENLNB_Levels;
		HMBECPGHPOE = LDEGEHAEALK.DGCJCAHIAPP_Diva.NBIGLBMHEDC_DivaList[AHHJLDLAPAN_DivaId - 1].LKIFDCEKDCK_Exps;
		FOHEIOLPAOG = LDEGEHAEALK.DGCJCAHIAPP_Diva.NBIGLBMHEDC_DivaList[AHHJLDLAPAN_DivaId - 1].KBOLNIBLIND_Unlocks;
		FJODMPGPDDD = LDEGEHAEALK.DGCJCAHIAPP_Diva.NBIGLBMHEDC_DivaList[AHHJLDLAPAN_DivaId - 1].CPGFPEDMDEH != 0;
		IPJMPBANBPP = IMMAOANGPNK.HHCJCDFCLOB.NKEBMCIMJND_Database.MGFMPKLLGHE_Diva.CDENCMNHNGA[AHHJLDLAPAN_DivaId - 1].PPEGAKEIEGM == 2;
		CIEOBFIIPLD = LDEGEHAEALK.DGCJCAHIAPP_Diva.NBIGLBMHEDC_DivaList[AHHJLDLAPAN_DivaId - 1].OKMELNIIMMO();
		AIHCEGFANAM = IMMAOANGPNK.HHCJCDFCLOB.NKEBMCIMJND_Database.MGFMPKLLGHE_Diva.CDENCMNHNGA[AHHJLDLAPAN_DivaId - 1].AIHCEGFANAM;
		OPFGFINHFCE_DivaName = EJOJNFDHDHN_GetName(AHHJLDLAPAN_DivaId);
		DJICAKGOGFO = new List<int>();
		for(int i = 0; i < LDEGEHAEALK.DGCJCAHIAPP_Diva.NBIGLBMHEDC_DivaList[AHHJLDLAPAN_DivaId - 1].JCHHIPOPNIN; i++)
		{
			int val = LDEGEHAEALK.DGCJCAHIAPP_Diva.NBIGLBMHEDC_DivaList[AHHJLDLAPAN_DivaId - 1].EBDNICPAFLB_SSlot[i];
			DJICAKGOGFO.Add(val);
			if(val == 0)
			{
				FGBKIPNGGJM.Add(null);
				GDJPNDKMKPG.Add(null);
				HHKFOOFPOJL.Add(0);
			}
			else
			{
				FGBKIPNGGJM.Add(LDEGEHAEALK.PNLOINMCCKH_Scene.OPIBAPEGCLA[val].PDNIFBEGMHC_Mb);
				GDJPNDKMKPG.Add(LDEGEHAEALK.PNLOINMCCKH_Scene.OPIBAPEGCLA[val].EMOJHJGHJLN);
				HHKFOOFPOJL.Add(LDEGEHAEALK.PNLOINMCCKH_Scene.OPIBAPEGCLA[val].JPIPENJGGDD_Mlt);
			}
		}
		FGFIBOBAPIA = LDEGEHAEALK.DGCJCAHIAPP_Diva.NBIGLBMHEDC_DivaList[AHHJLDLAPAN_DivaId - 1].PIGLAEFPNEK_MSlot;
		if(FGFIBOBAPIA != 0)
		{
			FFKMEFKOBHO = LDEGEHAEALK.PNLOINMCCKH_Scene.OPIBAPEGCLA[FGFIBOBAPIA].PDNIFBEGMHC_Mb;
			PFCJIKGENEH = LDEGEHAEALK.PNLOINMCCKH_Scene.OPIBAPEGCLA[FGFIBOBAPIA].EMOJHJGHJLN;
			AICGALGPFMO = LDEGEHAEALK.PNLOINMCCKH_Scene.OPIBAPEGCLA[FGFIBOBAPIA].JPIPENJGGDD_Mlt;
		}
		JPIDIENBGKH = LDEGEHAEALK.DGCJCAHIAPP_Diva.NBIGLBMHEDC_DivaList[AHHJLDLAPAN_DivaId - 1].BEEAIAAJOHD_CostumeId;
		EKFONBFDAAP_ColorId = LDEGEHAEALK.DGCJCAHIAPP_Diva.NBIGLBMHEDC_DivaList[AHHJLDLAPAN_DivaId - 1].AFNIOJHODAG_CostumeColorId;
		FFKMJNHFFFL.KHEKNNFCAOI(AHHJLDLAPAN_DivaId, JPIDIENBGKH, LDEGEHAEALK, OJEBNBLHPNP);
		KIIMFCFMMDN = LDEGEHAEALK.DGCJCAHIAPP_Diva.NBIGLBMHEDC_DivaList[AHHJLDLAPAN_DivaId - 1].HPJMPINPKEP_HomeCostumeId;
		JFFLFIMIMOI = LDEGEHAEALK.DGCJCAHIAPP_Diva.NBIGLBMHEDC_DivaList[AHHJLDLAPAN_DivaId - 1].KKEPMONFGEI_HomeCostumeColorId;
		EGAFMGDFFCH.KHEKNNFCAOI(AHHJLDLAPAN_DivaId, LDEGEHAEALK.DGCJCAHIAPP_Diva.NBIGLBMHEDC_DivaList[AHHJLDLAPAN_DivaId - 1].HPJMPINPKEP_HomeCostumeId, 
			LDEGEHAEALK, OJEBNBLHPNP);
		if(true/*JPIDIENBGKH == 0*/)
		{
			KELFCMEOPPM = 0;
			MBFADDHOEOK = false;
			JLKPGDEKPEO = false;
			CPGDEPMPMFK = false;
		}
		else
		{
			TodoLogger.Log(0, "episode info");
			//KELFCMEOPPM = IMMAOANGPNK.HHCJCDFCLOB.NKEBMCIMJND_Database.MOLEPBNJAGE_Episode
			//L.280
		}
		IHANGGCHPAL.KHEKNNFCAOI(AHHJLDLAPAN_DivaId);
		HCDGELDHFHB();

	}

	// RVA: 0x14DFA1C Offset: 0x14DFA1C VA: 0x14DFA1C
	public void KHEKNNFCAOI(int AHHJLDLAPAN_DivaId, int PAOGPLDOMMI, int PDEEMMEHDPK, int KOHAAFNNBOE, GCIJNCFDNON AFBMEMCHJCL, List<GCIJNCFDNON> HDJOHAJPGBA, bool LGNOCBFCAAK = false)
	{
		EEBBAGGJOGH = LGNOCBFCAAK;
		BNFDBPPOAOE = false;
		this.AHHJLDLAPAN_DivaId = AHHJLDLAPAN_DivaId;
		CIEOBFIIPLD = PAOGPLDOMMI;
		BJPLLEBHAGO d = IMMAOANGPNK.HHCJCDFCLOB.NKEBMCIMJND_Database.MGFMPKLLGHE_Diva.CDENCMNHNGA[AHHJLDLAPAN_DivaId-1];
		AIHCEGFANAM = d.AIHCEGFANAM;
		JPIDIENBGKH = PDEEMMEHDPK;
		EKFONBFDAAP_ColorId = KOHAAFNNBOE;
		if(!LGNOCBFCAAK)
		{
			FFKMJNHFFFL.KHEKNNFCAOI(AHHJLDLAPAN_DivaId,PDEEMMEHDPK,0,false);
		}
		else
		{
			FFKMJNHFFFL.KHEKNNFCAOI(AHHJLDLAPAN_DivaId,PDEEMMEHDPK,CIOECGOMILE.HHCJCDFCLOB.AHEFHIMGIBI_ServerSave,false);
		}
		FJODMPGPDDD = false;
		IPJMPBANBPP = d.PPEGAKEIEGM == 2;
		OPFGFINHFCE_DivaName = EJOJNFDHDHN_GetName(AHHJLDLAPAN_DivaId);
		if(HDJOHAJPGBA != null)
		{
			DJICAKGOGFO = new List<int>();
			for(int i = 0; i < HDJOHAJPGBA.Count; i++)
			{
				if(HDJOHAJPGBA[i] == null)
				{
					DJICAKGOGFO.Add(0);
					FGBKIPNGGJM.Add(null);
					GDJPNDKMKPG.Add(null);
					HHKFOOFPOJL.Add(0);
				}
				else
				{
					if(HDJOHAJPGBA[i].BCCHOBPJJKE == 0)
					{
						DJICAKGOGFO.Add(0);
						FGBKIPNGGJM.Add(null);
						GDJPNDKMKPG.Add(null);
						HHKFOOFPOJL.Add(0);
					}
					else
					{
						DJICAKGOGFO.Add(HDJOHAJPGBA[i].BCCHOBPJJKE);
						FGBKIPNGGJM.Add(HDJOHAJPGBA[i].KBOLNIBLIND);
						GDJPNDKMKPG.Add(HDJOHAJPGBA[i].ODKMKEHJOCK);
						HHKFOOFPOJL.Add(HDJOHAJPGBA[i].JPIPENJGGDD);
					}
				}
			}
		}
		if(AFBMEMCHJCL == null || AFBMEMCHJCL.BCCHOBPJJKE == 0)
		{
			AICGALGPFMO = 0;
			FFKMEFKOBHO = null;
			FGFIBOBAPIA = 0;
			PFCJIKGENEH = null;
		}
		else
		{
			AICGALGPFMO = AFBMEMCHJCL.JPIPENJGGDD;
			FGFIBOBAPIA = AFBMEMCHJCL.BCCHOBPJJKE;
			FFKMEFKOBHO = AFBMEMCHJCL.KBOLNIBLIND;
			PFCJIKGENEH = AFBMEMCHJCL.ODKMKEHJOCK;
		}
		IHANGGCHPAL.KHEKNNFCAOI(AHHJLDLAPAN_DivaId);
		HCDGELDHFHB();
	}

	// // RVA: 0x14DF0BC Offset: 0x14DF0BC VA: 0x14DF0BC
	public static string EJOJNFDHDHN_GetName(int MCDINKAKFGG)
	{
		StringBuilder str = new StringBuilder(32);
		MessageBank bank = MessageManager.Instance.GetBank("master");
		str.SetFormat("diva_{0:D2}", MCDINKAKFGG);
		return bank.GetMessageByLabel(str.ToString());
	}

	// // RVA: 0x14E01A4 Offset: 0x14E01A4 VA: 0x14E01A4
	// public StatusData FDFPMGHGBNN() { }

	// // RVA: 0x14DF39C Offset: 0x14DF39C VA: 0x14DF39C
	public void HCDGELDHFHB()
	{
		BJPLLEBHAGO a = IMMAOANGPNK.HHCJCDFCLOB.NKEBMCIMJND_Database.MGFMPKLLGHE_Diva.CDENCMNHNGA[AHHJLDLAPAN_DivaId - 1];
		JLJGCBOHJID_Status.soul = a.CMCKNKKCNDK[CIEOBFIIPLD].PFJCOCPKABN_Soul;
		JLJGCBOHJID_Status.vocal = a.CMCKNKKCNDK[CIEOBFIIPLD].JFJDLEMNKFE_Vocal;
		JLJGCBOHJID_Status.charm = a.CMCKNKKCNDK[CIEOBFIIPLD].GDOLPGBLMEA_Charm;
		JLJGCBOHJID_Status.life = a.CMCKNKKCNDK[CIEOBFIIPLD].HFIDCMNFBJG_Life;
		JLJGCBOHJID_Status.fold = a.CMCKNKKCNDK[CIEOBFIIPLD].ONDFNOOICLE_Fold;
		JLJGCBOHJID_Status.support = a.CMCKNKKCNDK[CIEOBFIIPLD].HCFOMFDPGEC_Support;
		JLJGCBOHJID_Status.soul += IHANGGCHPAL.PNOKIEEILJN();
		JLJGCBOHJID_Status.vocal += IHANGGCHPAL.LCDIGPJJJGI();
		JLJGCBOHJID_Status.charm += IHANGGCHPAL.KDKCMCBLEMG();
		if(EEBBAGGJOGH || BNFDBPPOAOE)
		{
			JLJGCBOHJID_Status.Add(CIOECGOMILE.HHCJCDFCLOB.AHEFHIMGIBI_ServerSave.BEKHNNCGIEL_Costume.NNIKNCGNDHK(AHHJLDLAPAN_DivaId));
		}
		CMCKNKKCNDK_EquippedStatus.Copy(JLJGCBOHJID_Status);
		if(FGFIBOBAPIA != 0)
		{
			CMCKNKKCNDK_EquippedStatus.Add(GCIJNCFDNON.JPCAIAAOOLN(FGFIBOBAPIA, FFKMEFKOBHO, PFCJIKGENEH, AICGALGPFMO, 0));
		}
		if(DJICAKGOGFO != null)
		{
			for(int i = 0; i < DJICAKGOGFO.Count; i++)
			{
				if(DJICAKGOGFO[i] != 0)
				{
					CMCKNKKCNDK_EquippedStatus.Add(GCIJNCFDNON.JPCAIAAOOLN(DJICAKGOGFO[i], FGBKIPNGGJM[i], GDJPNDKMKPG[i], HHKFOOFPOJL[i], 0));
				}
			}
		}
	}

	// // RVA: 0x14E0734 Offset: 0x14E0734 VA: 0x14E0734
	public void ELHBGKLLOIO()
	{
		JLJGCBOHJID_Status.Clear();
		CMCKNKKCNDK_EquippedStatus.Copy(JLJGCBOHJID_Status);
		if(FGFIBOBAPIA != 0)
		{
			CMCKNKKCNDK_EquippedStatus.Add(GCIJNCFDNON.JPCAIAAOOLN(FGFIBOBAPIA, FFKMEFKOBHO, PFCJIKGENEH, AICGALGPFMO, 0));
		}
		if(DJICAKGOGFO != null)
		{
			for(int i = 0; i < DJICAKGOGFO.Count; i++)
			{
				if(DJICAKGOGFO[i] != 0)
				{
					CMCKNKKCNDK_EquippedStatus.Add(GCIJNCFDNON.JPCAIAAOOLN(DJICAKGOGFO[i], FGBKIPNGGJM[i], GDJPNDKMKPG[i], HHKFOOFPOJL[i], 0));
				}
			}
		}
	}

	// // RVA: 0x14E09E8 Offset: 0x14E09E8 VA: 0x14E09E8
	// public bool OKDIEDCGODF(int BCCHOBPJJKE, bool ILBBPPMLLFM, KDMCFCBMAOI BBEBHGEHMMI, BLHOMPPGBMI NGMPDMCBNJB) { }

	// // RVA: 0x14E0D08 Offset: 0x14E0D08 VA: 0x14E0D08
	// public bool MNBNLONEDPF(bool ILBBPPMLLFM) { }

	// // RVA: 0x14E0E34 Offset: 0x14E0E34 VA: 0x14E0E34
	// public bool IFFMDJHENHB(int IMJIADPJJMM, int BCCHOBPJJKE, bool ILBBPPMLLFM, KDMCFCBMAOI BBEBHGEHMMI, BLHOMPPGBMI NGMPDMCBNJB) { }

	// // RVA: 0x14E13AC Offset: 0x14E13AC VA: 0x14E13AC
	// public bool BCEJOOCGBFG(int IMJIADPJJMM, bool ILBBPPMLLFM) { }

	// // RVA: 0x14E168C Offset: 0x14E168C VA: 0x14E168C
	// public void GFHOGBPOJDN(int PIHCLIPPNPB, int GFBJMMNGHAA, int FKCLAAAECLO, KDMCFCBMAOI BBEBHGEHMMI) { }

	// // RVA: 0x14E1758 Offset: 0x14E1758 VA: 0x14E1758
	// public void HOOJOFACOEK(int PDEEMMEHDPK, int HEHKNMCDBJJ, bool MNGIDJDFBFD = False, bool OJEBNBLHPNP = False) { }

	// // RVA: 0x14E1C7C Offset: 0x14E1C7C VA: 0x14E1C7C
	// public void JEIGPGNJJCP(int HEHKNMCDBJJ) { }

	// // RVA: 0x14E1C84 Offset: 0x14E1C84 VA: 0x14E1C84
	// public void JFIPEKCDKLG(int PDEEMMEHDPK, int HEHKNMCDBJJ, bool OJEBNBLHPNP = False) { }

	// // RVA: 0x14E1D28 Offset: 0x14E1D28 VA: 0x14E1D28
	// public void OPDBFHFKKJN(int PDEEMMEHDPK, int HEHKNMCDBJJ, bool OJEBNBLHPNP = False) { }

	// // RVA: 0x14E1F38 Offset: 0x14E1F38 VA: 0x14E1F38
	// public void HFMDICFNFNO(int HEHKNMCDBJJ) { }

	// // RVA: 0x14E1F40 Offset: 0x14E1F40 VA: 0x14E1F40
	// public int EOJIGHEFIAA() { }

	// // RVA: 0x14E2058 Offset: 0x14E2058 VA: 0x14E2058
	// public int LHGJHJLGPBE() { }

	// // RVA: 0x14E2154 Offset: 0x14E2154 VA: 0x14E2154
	// public void ODFBCANBLIJ(GCIJNCFDNON PNLOINMCCKH) { }

	// // RVA: 0x14E2194 Offset: 0x14E2194 VA: 0x14E2194
	// public void GOEDGNGDMCN(GCIJNCFDNON PNLOINMCCKH, int IMJIADPJJMM) { }

	// // RVA: 0x14E239C Offset: 0x14E239C VA: 0x14E239C
	// public void CJBBDBGDFKJ(GCIJNCFDNON PNLOINMCCKH, bool FBBNPFFEJBN = False) { }

	// // RVA: 0x14E23DC Offset: 0x14E23DC VA: 0x14E23DC
	// public void GIGDKIHBDHB(GCIJNCFDNON PNLOINMCCKH, int IMJIADPJJMM, bool FBBNPFFEJBN = False) { }

	// // RVA: 0x14E2564 Offset: 0x14E2564 VA: 0x14E2564
	// public static int PFAGNJEPBCB(int AHHJLDLAPAN, int JPIDIENBGKH) { }

	// // RVA: 0x14E2810 Offset: 0x14E2810 VA: 0x14E2810
	// public static List<FFHPBEPOMAK> DNAIGDHCILM(int AHHJLDLAPAN, bool OJEBNBLHPNP = False) { }

	// // RVA: 0x14E2F68 Offset: 0x14E2F68 VA: 0x14E2F68
	// public static List<FFHPBEPOMAK> OOJFGDKBOHK(int AHHJLDLAPAN, bool OJEBNBLHPNP = False) { }
}
