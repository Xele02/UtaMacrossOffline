
using System;
using System.Collections.Generic;
using XeSys;

public class FJGOKILCBJA
{
	public int OPKDAIMPJBH; // 0x8
	public int AFKAGFOFAHM; // 0xC
	public int FPJBMCDMAMO; // 0x10
	public DateTime JIHKOPIENAC; // 0x18
	public long EAPILIMHDNP; // 0x20 // check AODFBGCCBPE.BGDCMGOPCGE when assigned
	public int EILKGEADKGH; // 0x28
	public int KAPMOPMDHJE; // 0x2C
	//public IGCPCHNCJCF GLHFDCKOJDN; // 0x30
	public JKNGJFOBADP JANMJPOKLFL = new JKNGJFOBADP(); // 0x34
	public int NGGNFHPOMOO; // 0x38
	public int EKAPPBELKDA; // 0x3C
	public int BOELIGECGJD; // 0x40
	public int PIMKKONMBOG; // 0x44
	public int ALJGJMBFKHE; // 0x48
	public int AIDNHPGEHPM; // 0x4C
	public int CKNFCDCKFDE; // 0x50
	public int LDLHJMBGGGJ; // 0x54
	public int PAFAKOPJLEE; // 0x58
	public int KEHENBMEFJN; // 0x5C
	public string DJPBDDBNMLN; // 0x60
	public bool EHJBMHEAADC; // 0x64

	public int JNLPLBJKGDC { get { return PAFAKOPJLEE ^ 0x74841479; } set { PAFAKOPJLEE = value ^ 0x74841479; } } //0x117FBD8 HCDEEJAKFOF 0x117FBEC OCKKBHCFOEM
	public int GJGNOFAPFJD { get { return BOELIGECGJD ^ 0x74841479; } set { BOELIGECGJD = value ^ 0x74841479; } } //0x117FC00 JAGHPMNNEPG 0x117FC14 FACIELLBLMP
	public int KIJAPOFAGPN_ItemFullId { get { return PIMKKONMBOG ^ 0x51478174; } set { PIMKKONMBOG = value ^ 0x51478174; } } //0x117FC28 GCKKKIDNACI 0x117FC3C OGBLMPODGBG
	public int JDLJPNMLFID { get { return ALJGJMBFKHE ^ 0x137418ff; } set { ALJGJMBFKHE = value ^ 0x137418ff; } } //0x117FC50 BGIBDHCFJMN 0x117FC64 NDNEDCNDOGJ
	public int JPJMHLNOIAJ_ItemFullId2 { get { return NGGNFHPOMOO ^ 0x137418ff; } set { NGGNFHPOMOO = value ^ 0x137418ff; } } //0x117FC78 CFPIIDJJCHE 0x117FC8C PFKNCLBDBGH
	public int DKEPCPPCIKA { get { return EKAPPBELKDA ^ 0x374147ee; } set { EKAPPBELKDA = value ^ 0x374147ee; } } //0x117FCA0 HPLCJFNDOKC 0x117FCB4 HNIDHAHIBLF
	public int ELEPHBOKIGK { get { return AIDNHPGEHPM ^ 0x247ef; } set { AIDNHPGEHPM = value ^ 0x247ef; } } //0x117FCC8 IIJFLONJAFL 0x117FCDC LHNFGPIGCNE
	public int JLENMGOCHDG_Count { get { return CKNFCDCKFDE ^ 0x377247ef; } set { CKNFCDCKFDE = value ^ 0x377247ef; } } //0x117FCF0 OLJEIELPFMC 0x117FD04 JMNGGBCNLJN
	public int PBNCFGDPJKG_DecoItemSet { get { return KEHENBMEFJN ^ 0x141871f; } set { KEHENBMEFJN = value ^ 0x141871f; } } //0x117FD18 LCKOMDHNEBF 0x117FD2C LPODAPEMLEA
	public int NFBLLKHBMEK { get { return LDLHJMBGGGJ ^ 0x93a97a; } set { LDLHJMBGGGJ = value ^ 0x93a97a; } } //0x117FD40 NCBIANHKGMG 0x117FD54 OFKJMDODHLO

	//// RVA: 0x117FD68 Offset: 0x117FD68 VA: 0x117FD68
	public void KHEKNNFCAOI(int OPKDAIMPJBH, int AFKAGFOFAHM)
	{
		BKPAPCMJKHE_Shop.BOMCAJJCPME dbItem = IMMAOANGPNK.HHCJCDFCLOB.NKEBMCIMJND_Database.IFLGCDGOLOP_Shop.MHKCPJDNJKI[AFKAGFOFAHM - 1];
		BKPAPCMJKHE_Shop.GPNPMJJKONJ dbItem2 = IMMAOANGPNK.HHCJCDFCLOB.NKEBMCIMJND_Database.IFLGCDGOLOP_Shop.HMKKLPPEOHL[dbItem.GJGNOFAPFJD - 1];
		GBEFGAIGGHA_Shop.DPGGLKKBNBJ saveItem = CIOECGOMILE.HHCJCDFCLOB.AHEFHIMGIBI_ServerSave.IJOHDAJMBAL_Shop.ECMLOMPGMLC[AFKAGFOFAHM - 1];
		BKPAPCMJKHE_Shop.DNOENEKHGMI dbItem3 = IMMAOANGPNK.HHCJCDFCLOB.NKEBMCIMJND_Database.IFLGCDGOLOP_Shop.CDENCMNHNGA[OPKDAIMPJBH - 1];
		this.OPKDAIMPJBH = OPKDAIMPJBH;
		this.AFKAGFOFAHM = AFKAGFOFAHM;
		GJGNOFAPFJD = dbItem.GJGNOFAPFJD;
		KIJAPOFAGPN_ItemFullId = dbItem2.EJHMPCJNHBP;
		JDLJPNMLFID = dbItem2.LBCNKLPIMHL;
		JPJMHLNOIAJ_ItemFullId2 = dbItem2.LMMCMHHAGBJ;
		DKEPCPPCIKA = dbItem2.CMEIMAMOMPI;
		DJPBDDBNMLN = null;
		KAPMOPMDHJE = dbItem.ICKAMKNDAEB;
		NFBLLKHBMEK = 0;
		PBNCFGDPJKG_DecoItemSet = EKLNMHFCAOI.PJMJIKKJAAM_GetDecoItemSet(IMMAOANGPNK.HHCJCDFCLOB.NKEBMCIMJND_Database, EKLNMHFCAOI.BKHFLDMOGBD_GetItemCategory(KIJAPOFAGPN_ItemFullId), EKLNMHFCAOI.DEACAHNLMNI_getItemId(KIJAPOFAGPN_ItemFullId));
		EKLNMHFCAOI.FKGCBLHOOCL_Category cat = EKLNMHFCAOI.BKHFLDMOGBD_GetItemCategory(JPJMHLNOIAJ_ItemFullId2);
		if(cat == EKLNMHFCAOI.FKGCBLHOOCL_Category.IBBDMIFICCN_BonusVC)
		{
			//EKLNMHFCAOI.DEACAHNLMNI_getItemId(JPJMHLNOIAJ_ItemFullId2);
			for(int i = 0; i < IMMAOANGPNK.HHCJCDFCLOB.NKEBMCIMJND_Database.NBKNAAPBFFL_BonusVc.CDENCMNHNGA.Count; i++)
			{
				HHJHIFJIKAC_BonusVc.MNGJPJBCMBH bonusVc = IMMAOANGPNK.HHCJCDFCLOB.NKEBMCIMJND_Database.NBKNAAPBFFL_BonusVc.CDENCMNHNGA[i];
				if(bonusVc.INDDJNMPONH == 1)
				{
					if(bonusVc.JBGEEPFKIGG == dbItem3.JPGALGPNJAI)
					{
						NGGNFHPOMOO = EKLNMHFCAOI.GJEEGMCBGGM_GetItemFullId(EKLNMHFCAOI.FKGCBLHOOCL_Category.IBBDMIFICCN_BonusVC, bonusVc.PPFNGGCBJKC_Id);
						break;
					}
				}
			}
		}
		else if(cat == EKLNMHFCAOI.FKGCBLHOOCL_Category.ADCAAALBAIF_Medal)
		{
			int id = EKLNMHFCAOI.DEACAHNLMNI_getItemId(JPJMHLNOIAJ_ItemFullId2);
			HHFFOACILKG_Medal.HCFJGDFMHOJ dbMedal = IMMAOANGPNK.HHCJCDFCLOB.NKEBMCIMJND_Database.ICICKEBMEFA_Medal.CDENCMNHNGA[id - 1];
			if(dbMedal.GBJFNGCDKPM == 1)
			{
				for(int i = 0; i < IMMAOANGPNK.HHCJCDFCLOB.NKEBMCIMJND_Database.ICICKEBMEFA_Medal.CDENCMNHNGA.Count; i++)
				{
					HHFFOACILKG_Medal.HCFJGDFMHOJ dbMedal2 = IMMAOANGPNK.HHCJCDFCLOB.NKEBMCIMJND_Database.ICICKEBMEFA_Medal.CDENCMNHNGA[i];
					if (dbMedal2.IBAKPKKEDJM_Month == dbItem3.IBAKPKKEDJM_Month)
					{
						NGGNFHPOMOO = EKLNMHFCAOI.GJEEGMCBGGM_GetItemFullId(EKLNMHFCAOI.FKGCBLHOOCL_Category.ADCAAALBAIF_Medal, dbMedal2.PPFNGGCBJKC);
						break;
					}
				}
			}
		}
		ELEPHBOKIGK = dbItem.JLENMGOCHDG;
		JLENMGOCHDG_Count = ELEPHBOKIGK > 0 ? saveItem.KMFLNILNPJD_Cnt : 0;
		FPJBMCDMAMO = dbItem.FPJBMCDMAMO;
		JIHKOPIENAC = Utility.GetLocalDateTime(dbItem.GJFPFFBAKGK);
		EAPILIMHDNP = dbItem.GJFPFFBAKGK;
		JANMJPOKLFL.JCHLONCMPAJ();
		EILKGEADKGH = dbItem.EILKGEADKGH;
		JNLPLBJKGDC = 99;
		if(OPKDAIMPJBH > 0)
		{
			if(dbItem3.HCCEFDMGPEA == 1)
			{
				CEBFFLDKAEC_SecureInt v = new CEBFFLDKAEC_SecureInt();
				if(IMMAOANGPNK.HHCJCDFCLOB.NKEBMCIMJND_Database.IFLGCDGOLOP_Shop.OHJFBLFELNK.TryGetValue("buy_count_once_sphere", out v))
				{
					JNLPLBJKGDC = v.DNJEJEANJGL_Value;
				}
				else
				{
					JNLPLBJKGDC = 10;
				}
			}
		}
	}

	//// RVA: 0x1180998 Offset: 0x1180998 VA: 0x1180998
	//public void CLCJHOIDENO(int DLLJMINACDN, EKLNMHFCAOI.FKGCBLHOOCL HHACNFODNEF, int MHFBCINOJEE, int JBIOKDFOCOJ, int PLBOJBHAPLO) { }

	//// RVA: 0x1180BC4 Offset: 0x1180BC4 VA: 0x1180BC4
	//public int DPFOJKHBBEH() { }

	//// RVA: 0x1180D44 Offset: 0x1180D44 VA: 0x1180D44
	//public int CMOPCCPOEBA() { }

	//// RVA: 0x1181014 Offset: 0x1181014 VA: 0x1181014
	//public int PHBCFNIJLJH() { }

	//// RVA: 0x1181304 Offset: 0x1181304 VA: 0x1181304
	//public bool EMLHKJAPACA(int HMFFHLPNMPH) { }

	//// RVA: 0x1181800 Offset: 0x1181800 VA: 0x1181800
	//public int EAIJAAEKDAB() { }

	//// RVA: 0x1181C34 Offset: 0x1181C34 VA: 0x1181C34
	//public void PFIBEGFOBEG(int JLENMGOCHDG, IMCBBOAFION BHFHGFKBOHH, JFDNPFFOACP NIMPEHIECJH, DJBHIFLHJLK AOCANKOMKFG) { }

	//[IteratorStateMachineAttribute] // RVA: 0x741584 Offset: 0x741584 VA: 0x741584
	//// RVA: 0x1181CA4 Offset: 0x1181CA4 VA: 0x1181CA4
	//private IEnumerator EHDNGPFPOKJ(int JLENMGOCHDG, IMCBBOAFION BHFHGFKBOHH, JFDNPFFOACP NIMPEHIECJH, DJBHIFLHJLK AOCANKOMKFG) { }

	//[IteratorStateMachineAttribute] // RVA: 0x7415FC Offset: 0x7415FC VA: 0x7415FC
	//// RVA: 0x1181DB8 Offset: 0x1181DB8 VA: 0x1181DB8
	//private IEnumerator NLFNKKCPGNJ(DJBHIFLHJLK AOCANKOMKFG) { }

	//// RVA: 0x1181E64 Offset: 0x1181E64 VA: 0x1181E64
	//public void EOJNOOHFOKA(IGCPCHNCJCF GLHFDCKOJDN) { }

	//// RVA: 0x1181F9C Offset: 0x1181F9C VA: 0x1181F9C
	public static List<FJGOKILCBJA> OHDOAMFIBCC(int OPKDAIMPJBH, int EFNMDPKEJIM, long JHNMKKNEENE)
	{
		TodoLogger.Log(0, "OHDOAMFIBCC");
		return new List<FJGOKILCBJA>();
	}

	//// RVA: 0x11833FC Offset: 0x11833FC VA: 0x11833FC
	public static List<FJGOKILCBJA> FKDIMODKKJD(int OPKDAIMPJBH, int EFNMDPKEJIM, long JHNMKKNEENE)
	{
		BKPAPCMJKHE_Shop shop = IMMAOANGPNK.HHCJCDFCLOB.NKEBMCIMJND_Database.IFLGCDGOLOP_Shop;
		BKPAPCMJKHE_Shop.DNOENEKHGMI dbShop = shop.CDENCMNHNGA[OPKDAIMPJBH - 1];
		if(dbShop.HCCEFDMGPEA == 5)
		{
			return OHDOAMFIBCC(OPKDAIMPJBH, EFNMDPKEJIM, JHNMKKNEENE);
		}
		List<FJGOKILCBJA> l = new List<FJGOKILCBJA>();
		for(int i = 0; i < shop.MHKCPJDNJKI.Count; i++)
		{
			if(shop.MHKCPJDNJKI[i].PPEGAKEIEGM_Enabled == 2 && shop.MHKCPJDNJKI[i].EFNMDPKEJIM == EFNMDPKEJIM &&
				JHNMKKNEENE >= shop.MHKCPJDNJKI[i].KJBGCLPMLCG && shop.MHKCPJDNJKI[i].GJFPFFBAKGK >= JHNMKKNEENE)
			{
				FJGOKILCBJA data = new FJGOKILCBJA();
				data.KHEKNNFCAOI(OPKDAIMPJBH, shop.MHKCPJDNJKI[i].AFKAGFOFAHM);
				l.Add(data);
			}
		}
		l.Sort((FJGOKILCBJA HKICMNAACDA, FJGOKILCBJA BNKHBCBJBKI) =>
		{
			//0x11839D0
			return HKICMNAACDA.EILKGEADKGH.CompareTo(BNKHBCBJBKI.EILKGEADKGH);
		});
		return l;
	}
}
