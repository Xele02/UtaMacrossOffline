using System.Collections.Generic;

public class EPPOHFLMDBC
{
	public int FBGGEFFJJHB = 0x1a915b; // 0x8
	public int MBCPMFPKNBA; // 0xC
	public int DBJFLJIMONP_Life; // 0x10
	public int NDKJOJLCJBI_Soul; // 0x14
	public int GLMAGOANCLM_Vocal; // 0x18
	public int CHINMGJCEDH_Charm; // 0x1C
	public int EAJBBFLFDHI_Fold; // 0x20
	public int EHDLPKCCJIA_Support; // 0x24

	public int ANAJIAENLNB { get { return FBGGEFFJJHB ^ MBCPMFPKNBA; } set { MBCPMFPKNBA = FBGGEFFJJHB ^ value; } } //0xFC14D4 MMOMNMBKHJF 0xFC14E4 FEHNFGPFINK
	public int HFIDCMNFBJG_Life { get { return FBGGEFFJJHB ^ DBJFLJIMONP_Life; } set { DBJFLJIMONP_Life = FBGGEFFJJHB ^ value; } } //0xFC14F4 CMDOHPBAFCO 0xFC1504 BJBDGCMJNEO
	public int PFJCOCPKABN_Soul { get { return FBGGEFFJJHB ^ NDKJOJLCJBI_Soul; } set { NDKJOJLCJBI_Soul = FBGGEFFJJHB ^ value; } } //0xFC1514 EJPPLFNLAAO 0xFC1524 NEMMJEJENFD
	public int JFJDLEMNKFE_Vocal { get { return FBGGEFFJJHB ^ GLMAGOANCLM_Vocal; } set { GLMAGOANCLM_Vocal = FBGGEFFJJHB ^ value; } }// 0xFC1534 GCMPLDKECFM 0xFC1544 CEHKELOHIBD
	public int GDOLPGBLMEA_Charm { get { return FBGGEFFJJHB ^ CHINMGJCEDH_Charm; } set { CHINMGJCEDH_Charm = FBGGEFFJJHB ^ value; } } //0xFC1554 LEHDODJMICA 0xFC1564 IKPOCJDOOGA
	public int ONDFNOOICLE_Fold { get { return FBGGEFFJJHB ^ EAJBBFLFDHI_Fold; } set { EAJBBFLFDHI_Fold = FBGGEFFJJHB ^ value; } } //0xFC1574 OGGOHKCANFG 0xFC1584 BKMHMPEBNPE
	public int HCFOMFDPGEC_Support { get { return FBGGEFFJJHB ^ EHDLPKCCJIA_Support; } set { EHDLPKCCJIA_Support = FBGGEFFJJHB ^ value; } } //0xFC1594 GGIDKCOMCJL 0xFC15A4 LAIHOHGICJD

	// // RVA: 0xFC15B4 Offset: 0xFC15B4 VA: 0xFC15B4
	public void DOMFHDPMCCO(int ANAJIAENLNB, int FBGGEFFJJHB, short JKPPKAHPPKH, short MKMIEGPOKGG, short MELGGCAIONF, short LDLHPACIIAB, short JNNDFGPMEDA, short IDOIMLGLPAB)
	{
		this.MBCPMFPKNBA = FBGGEFFJJHB ^ ANAJIAENLNB;
		this.FBGGEFFJJHB = FBGGEFFJJHB;
		this.DBJFLJIMONP_Life = JKPPKAHPPKH ^ FBGGEFFJJHB;
		this.NDKJOJLCJBI_Soul = MKMIEGPOKGG ^ FBGGEFFJJHB;
		this.GLMAGOANCLM_Vocal = MELGGCAIONF ^ FBGGEFFJJHB;
		this.CHINMGJCEDH_Charm = LDLHPACIIAB ^ FBGGEFFJJHB;
		this.EAJBBFLFDHI_Fold = JNNDFGPMEDA ^ FBGGEFFJJHB;
		this.EHDLPKCCJIA_Support = IDOIMLGLPAB ^ FBGGEFFJJHB;
	}

	// // RVA: 0xFC160C Offset: 0xFC160C VA: 0xFC160C
	public void ANIJHEBLMGB(int INDDJNMPONH, short JBGEEPFKIGG)
	{
		switch(INDDJNMPONH)
		{
			case 1:
			DBJFLJIMONP_Life = FBGGEFFJJHB ^ (( FBGGEFFJJHB ^ DBJFLJIMONP_Life ) + JBGEEPFKIGG);
			break;
			case 2:
			NDKJOJLCJBI_Soul = FBGGEFFJJHB ^ (( FBGGEFFJJHB ^ NDKJOJLCJBI_Soul ) + JBGEEPFKIGG);
			break;
			case 3:
			GLMAGOANCLM_Vocal = FBGGEFFJJHB ^ (( FBGGEFFJJHB ^ GLMAGOANCLM_Vocal ) + JBGEEPFKIGG);
			break;
			case 4:
			CHINMGJCEDH_Charm = FBGGEFFJJHB ^ (( FBGGEFFJJHB ^ CHINMGJCEDH_Charm ) + JBGEEPFKIGG);
			break;
			case 5:
			EAJBBFLFDHI_Fold = FBGGEFFJJHB ^ (( FBGGEFFJJHB ^ EAJBBFLFDHI_Fold ) + JBGEEPFKIGG);
			break;
			case 6:
			EHDLPKCCJIA_Support = FBGGEFFJJHB ^ (( FBGGEFFJJHB ^ EHDLPKCCJIA_Support ) + JBGEEPFKIGG);
			break;
			default:
			break;
		}
	}

	// // RVA: 0xFC1698 Offset: 0xFC1698 VA: 0xFC1698
	public void ODDIHGPONFL(EPPOHFLMDBC GPBJHKLFCEP)
	{
		MBCPMFPKNBA = GPBJHKLFCEP.FBGGEFFJJHB ^ GPBJHKLFCEP.MBCPMFPKNBA ^ FBGGEFFJJHB;
		DBJFLJIMONP_Life = GPBJHKLFCEP.FBGGEFFJJHB ^ GPBJHKLFCEP.DBJFLJIMONP_Life ^ FBGGEFFJJHB;
		NDKJOJLCJBI_Soul = GPBJHKLFCEP.FBGGEFFJJHB ^ GPBJHKLFCEP.NDKJOJLCJBI_Soul ^ FBGGEFFJJHB;
		GLMAGOANCLM_Vocal = GPBJHKLFCEP.FBGGEFFJJHB ^ GPBJHKLFCEP.GLMAGOANCLM_Vocal ^ FBGGEFFJJHB;
		CHINMGJCEDH_Charm = GPBJHKLFCEP.FBGGEFFJJHB ^ GPBJHKLFCEP.CHINMGJCEDH_Charm ^ FBGGEFFJJHB;
		EAJBBFLFDHI_Fold = GPBJHKLFCEP.FBGGEFFJJHB ^ GPBJHKLFCEP.EAJBBFLFDHI_Fold ^ FBGGEFFJJHB;
		EHDLPKCCJIA_Support = GPBJHKLFCEP.FBGGEFFJJHB ^ GPBJHKLFCEP.EHDLPKCCJIA_Support ^ FBGGEFFJJHB;
	}

	// // RVA: 0xFC1800 Offset: 0xFC1800 VA: 0xFC1800
	// public uint CAOGDCBPBAN() { }
}

[WikiPage(title : "Database/Diva/Diva_{ID:D3}", filename : "diva/dv_{ID:D3}", templateName : "Database/Diva/DivaInfo")]
public class BJPLLEBHAGO
{
	public sbyte DOAJJALOKLI; // 0xD
	public sbyte PKNONBBKCCP; // 0xE
	public List<EPPOHFLMDBC> CMCKNKKCNDK = new List<EPPOHFLMDBC>(); // 0x14

	[WikiProperty("Attr")]
	public sbyte AIHCEGFANAM_Attr { get; set; } // 0x8 FJOGAAMLJMA ANEJPLENMAL HEHDOGFEIOL
	[WikiProperty("ID")]
	public sbyte AHHJLDLAPAN { get; set; } // 0x9 AMALMGIALDF IPKDLMIDMHH IENNENMKEFO
	[WikiProperty("BodyId")]
	public sbyte IDDHKOEFJFB_BodyId { get; set; }  // 0xA KEOMNKLLNFJ // ADCMNNJMGKO KOFCMDMLAHC 
	[WikiProperty("PersonalityId")]
	public sbyte FPMGHDKACOF_PersonalityId { get; set; } // 0xB AJHJBOKOPAJ // ALJDJOFDKDJ FPFJHHIANFD
	[WikiProperty("Enabled")]
	public sbyte PPEGAKEIEGM { get; set; } // 0xC NEKLJCCBECB KPOEEPIMMJP NCIEAFEDPBH
	[WikiProperty("LIOGKHIGJKN")]
	public ushort LIOGKHIGJKN { get; set; } // 0x10 DGLBKOGGKHO JNBPCHKDNMD MLPEHHGEEIB
	[WikiProperty("HomeBgId")]
	public ushort CMBCBNEODPD { get; set; } // 0x12 CLHDIBCIJBB EIMFDHBOECI OJMIHHIIBPI

	// // RVA: 0xC85E00 Offset: 0xC85E00 VA: 0xC85E00
	// public uint CAOGDCBPBAN() { }
}
