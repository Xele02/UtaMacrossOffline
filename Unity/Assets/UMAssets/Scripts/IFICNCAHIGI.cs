
using System.Collections.Generic;

public class IFICNCAHIGI : IBIGBMDANNM
{
	public int AGDBNNEAIIC { get; set; } // 0x48 KIHAEDNHHAN NDEDOLKIOIE HACPPJDBEOJ
	public bool BBNAEPGAMMA { get; set; } // 0x4C FEPMDHPMCJN JMPMCEFAGBB BJEPEENJLJB

	// RVA: 0x11EEFD0 Offset: 0x11EEFD0 VA: 0x11EEFD0 Slot: 5
	protected override bool NLENMNMCJCJ(int PPFNGGCBJKC, long IFNLEKOILPM, bool MLEHCBKPNGK, List<string> OHNJJIMGKGK, EDOHBJAPLPF_JsonData IDLHJIOMJBK, BBHNACPENDM_ServerSaveData AHEFHIMGIBI)
	{
		bool res = base.NLENMNMCJCJ(PPFNGGCBJKC, IFNLEKOILPM, MLEHCBKPNGK, OHNJJIMGKGK, IDLHJIOMJBK, AHEFHIMGIBI);
		if(res)
		{
			BBNAEPGAMMA = CIOECGOMILE.HHCJCDFCLOB.AHEFHIMGIBI_ServerSave.GAAOPEGIPKA_FavoritePlayer.FFKIDMKHIOE(PPFNGGCBJKC);
		}
		return res;
	}
}
