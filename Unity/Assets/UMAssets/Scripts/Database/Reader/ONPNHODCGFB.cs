using FlatBuffers;
using System.Collections.Generic;

public class HMJNEBPFCKE
{
	public uint PPFNGGCBJKC { get; set; } // 0x8 FDGEMCPHJCB DEMEPMAEJOO HIGKAIDMOKN
	public uint GJDNBENICPF { get; set; } // 0xC HPJECMJNMPM AFNFOLBCEAH NAFMLADMAGK
	public int IJEKNCDIIAE { get; set; } // 0x10 FAHNCMHNFCG KJIMMIBDCIL DMEGNOKIKCD
	public uint PLALNIIBLOF { get; set; } // 0x14 DFMNDOMAPAB JPCJNLHHIPE JJFJNEJLBDG
	public uint DOOGFEGEKLG { get; set; } // 0x18 IKKMNBJGBJK AECMFIOFFJN NGOJJDOCIDG
}
public class ONPNHODCGFB
{
	public HMJNEBPFCKE[] IGBEFKKKMKJ { get; set; } // 0x8 PNALEOLKEKE GJFMOFKINKE BOCOJJJHAIK
	public static ONPNHODCGFB HEGEKFMJNCC(byte[] NIODCJLINJN)// 0xCAFF8C
	{
		ByteBuffer buffer = new ByteBuffer(NIODCJLINJN);
		NMOEOEOBDAD res_readData = NMOEOEOBDAD.GetRootAsNMOEOEOBDAD(buffer);
		ONPNHODCGFB res_data = new ONPNHODCGFB();

		List<HMJNEBPFCKE> IGBEFKKKMKJ_list = new List<HMJNEBPFCKE>();
		for(int IGBEFKKKMKJ_idx = 0; IGBEFKKKMKJ_idx < res_readData.LLDMPBONLLMLength; IGBEFKKKMKJ_idx++)
		{
			DHEAKBKIDEA IGBEFKKKMKJ_readData = res_readData.GetLLDMPBONLLM(IGBEFKKKMKJ_idx);
			HMJNEBPFCKE IGBEFKKKMKJ_data = new HMJNEBPFCKE();

			IGBEFKKKMKJ_data.PPFNGGCBJKC = IGBEFKKKMKJ_readData.BBPHAPFBFHK;
			IGBEFKKKMKJ_data.GJDNBENICPF = IGBEFKKKMKJ_readData.HHBHJBIAAAD;
			IGBEFKKKMKJ_data.IJEKNCDIIAE = IGBEFKKKMKJ_readData.OFMGALJGDAO;
			IGBEFKKKMKJ_data.PLALNIIBLOF = IGBEFKKKMKJ_readData.CFLMCGOJJJD;
			IGBEFKKKMKJ_data.DOOGFEGEKLG = IGBEFKKKMKJ_readData.GEJGMBBCFEE;
			IGBEFKKKMKJ_list.Add(IGBEFKKKMKJ_data);
		}
		res_data.IGBEFKKKMKJ = IGBEFKKKMKJ_list.ToArray();

		return res_data;
	}
}