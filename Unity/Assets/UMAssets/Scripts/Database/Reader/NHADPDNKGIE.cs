using FlatBuffers;
using System.Collections.Generic;

public class JNHHIHOCMHN
{
	public uint PPFNGGCBJKC { get; set; } // 0x8 FDGEMCPHJCB DEMEPMAEJOO HIGKAIDMOKN
	public uint HANMDEBPBHG { get; set; } // 0xC IMDBPCNAOOE EFGGIMOPNMG PNGGKPFDKMA
	public uint HDEBAGHEIKD { get; set; } // 0x10 LEOIDFOJDEB ILEIGMALLGJ EEAKPBHBMOL
	public uint DFOIEJOKDKJ { get; set; } // 0x14 NELIGKOCNOK FKLAHJBFJCO APCNKLOJCNJ
	public uint AKOJJJLPCKA { get; set; } // 0x18 HAHLJMLFIKD NIKDJFBDBOO IDCBHPEIAFE
	public uint LNKKMBCDPHH { get; set; } // 0x1C GPEMGLLCJIF PAPMCJONAGI MODJBBMBLCD
}
public class NHADPDNKGIE
{
	public JNHHIHOCMHN[] EAHFNHMNPIB { get; set; } // 0x8 MEMBLECFIJD FCMCIMGKNLP CGGPLGMEJHC
	public static NHADPDNKGIE HEGEKFMJNCC(byte[] NIODCJLINJN)// 0x1890084
	{
		ByteBuffer buffer = new ByteBuffer(NIODCJLINJN);
		PCIEJLEICFK res_readData = PCIEJLEICFK.GetRootAsPCIEJLEICFK(buffer);
		NHADPDNKGIE res_data = new NHADPDNKGIE();

		List<JNHHIHOCMHN> EAHFNHMNPIB_list = new List<JNHHIHOCMHN>();
		for(int EAHFNHMNPIB_idx = 0; EAHFNHMNPIB_idx < res_readData.AHBLKAMALAMLength; EAHFNHMNPIB_idx++)
		{
			PJOFNFPMOLG EAHFNHMNPIB_readData = res_readData.GetAHBLKAMALAM(EAHFNHMNPIB_idx);
			JNHHIHOCMHN EAHFNHMNPIB_data = new JNHHIHOCMHN();

			EAHFNHMNPIB_data.PPFNGGCBJKC = EAHFNHMNPIB_readData.BBPHAPFBFHK;
			EAHFNHMNPIB_data.HANMDEBPBHG = EAHFNHMNPIB_readData.BLJLFEDLAME;
			EAHFNHMNPIB_data.HDEBAGHEIKD = EAHFNHMNPIB_readData.DALJDMJEJGE;
			EAHFNHMNPIB_data.DFOIEJOKDKJ = EAHFNHMNPIB_readData.IDJCFCJMBCF;
			EAHFNHMNPIB_data.AKOJJJLPCKA = EAHFNHMNPIB_readData.NAGPKLGDNDA;
			EAHFNHMNPIB_data.LNKKMBCDPHH = EAHFNHMNPIB_readData.BNDEBMLCMNB;
			EAHFNHMNPIB_list.Add(EAHFNHMNPIB_data);
		}
		res_data.EAHFNHMNPIB = EAHFNHMNPIB_list.ToArray();

		return res_data;
	}
}
