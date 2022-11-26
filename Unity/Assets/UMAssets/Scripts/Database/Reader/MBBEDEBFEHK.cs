using FlatBuffers;
using System.Collections.Generic;

public class LCFLMIGPBLJ
{
	public int PPFNGGCBJKC { get; set; } // 0x8 FDGEMCPHJCB DEMEPMAEJOO HIGKAIDMOKN
	public int IJEKNCDIIAE { get; set; } // 0xC FAHNCMHNFCG KJIMMIBDCIL DMEGNOKIKCD
	public int PLALNIIBLOF { get; set; } // 0x10 DFMNDOMAPAB JPCJNLHHIPE JJFJNEJLBDG
	public int PDBPFJJCADD { get; set; } // 0x14 PMJMBGBCIGO FOACOMBHPAC NBACOBCOJCA
	public int FDBNFFNFOND { get; set; } // 0x18 INOJHLHGKMI BPJOGHJCLDJ NLJKMCHOCBK
	public int[] BMFACNFNCKC { get; set; } // 0x1C CJHLOJHAPDH LEMPPNHNINM DHOGBDDHLIA
	public int[] MFKKADJIHHK { get; set; } // 0x20 HOEKGABMBND PILANLMGNKE HAJEGBDJMHK
}
public class MBBEDEBFEHK
{
	public LCFLMIGPBLJ[] KNCEIKIFAGD { get; set; } // 0x8 IDJNHHNOOCG FNKCCJEKBLM ILOCLDBPPCI
	public static MBBEDEBFEHK HEGEKFMJNCC(byte[] NIODCJLINJN)// 0xA2D1D0
	{
		ByteBuffer buffer = new ByteBuffer(NIODCJLINJN);
		JKIJAPMNHFJ res_readData = JKIJAPMNHFJ.GetRootAsJKIJAPMNHFJ(buffer);
		MBBEDEBFEHK res_data = new MBBEDEBFEHK();

		List<LCFLMIGPBLJ> KNCEIKIFAGD_list = new List<LCFLMIGPBLJ>();
		for(int KNCEIKIFAGD_idx = 0; KNCEIKIFAGD_idx < res_readData.ECIELLPPMPPLength; KNCEIKIFAGD_idx++)
		{
			FDEDPMKCNLB KNCEIKIFAGD_readData = res_readData.GetECIELLPPMPP(KNCEIKIFAGD_idx);
			LCFLMIGPBLJ KNCEIKIFAGD_data = new LCFLMIGPBLJ();

			KNCEIKIFAGD_data.PPFNGGCBJKC = KNCEIKIFAGD_readData.BBPHAPFBFHK;
			KNCEIKIFAGD_data.IJEKNCDIIAE = KNCEIKIFAGD_readData.OFMGALJGDAO;
			KNCEIKIFAGD_data.PLALNIIBLOF = KNCEIKIFAGD_readData.CFLMCGOJJJD;
			KNCEIKIFAGD_data.PDBPFJJCADD = KNCEIKIFAGD_readData.NJLJEKDBPCH;
			KNCEIKIFAGD_data.FDBNFFNFOND = KNCEIKIFAGD_readData.MAOAGDBDBIB;
			List<int> BMFACNFNCKC_list = new List<int>();
			for(int BMFACNFNCKC_idx = 0; BMFACNFNCKC_idx < KNCEIKIFAGD_readData.EOLOEKNHBGKLength; BMFACNFNCKC_idx++)
			{
				BMFACNFNCKC_list.Add(KNCEIKIFAGD_readData.GetEOLOEKNHBGK(BMFACNFNCKC_idx));
			}
			KNCEIKIFAGD_data.BMFACNFNCKC = BMFACNFNCKC_list.ToArray();

			List<int> MFKKADJIHHK_list = new List<int>();
			for(int MFKKADJIHHK_idx = 0; MFKKADJIHHK_idx < KNCEIKIFAGD_readData.DHFIMBLLAMOLength; MFKKADJIHHK_idx++)
			{
				MFKKADJIHHK_list.Add(KNCEIKIFAGD_readData.GetDHFIMBLLAMO(MFKKADJIHHK_idx));
			}
			KNCEIKIFAGD_data.MFKKADJIHHK = MFKKADJIHHK_list.ToArray();

			KNCEIKIFAGD_list.Add(KNCEIKIFAGD_data);
		}
		res_data.KNCEIKIFAGD = KNCEIKIFAGD_list.ToArray();

		return res_data;
	}
}
