using System.Diagnostics;
using XeSys;
using XeApp.Core;
using XeApp.Game;
using System.Threading;

public class IIDJLAEDMPI
{
	private const long OMCDGIKLEDM = 20;
	private long NNBNNPOEJLK; // 0x8
	private long FLMCOGBDCCF; // 0x10
	private long KBHHALOMJCI; // 0x18
	private Stopwatch KOIMMJDGHHI; // 0x20
	private object CBHDHHIHLLG; // 0x24
	private uint HFFJFEMMIGF; // 0x28
	private long OAJDFDHDMEN; // 0x30
	private string NILMMFMIBMF; // 0x38
	private static string[] ECLAOLBGCDD = new string[8] {"yyyy/MM/dd HH:mm:ss", "(+", "(-", "day", "h", "m", ")", "serverTime="}; // 0x0

	// public bool BIOFMLDLNKD { get; } // ??

	// // RVA: 0x12038BC Offset: 0x12038BC VA: 0x12038BC
	// public bool LEAPLHLPGDB() { }

	// // RVA: 0x12038CC Offset: 0x12038CC VA: 0x12038CC
	public IIDJLAEDMPI()
	{
		CBHDHHIHLLG = new object();
		OAJDFDHDMEN = -1;
		NILMMFMIBMF = "";
		FLMCOGBDCCF = Utility.GetCurrentUnixTime();
		GameManager.Instance.appBootTime.UpdateElapsedTime();
		KBHHALOMJCI = GameManager.Instance.appBootTime.ElapsedMilliseconds;
	}

	// // RVA: 0x11EDDAC Offset: 0x11EDDAC VA: 0x11EDDAC
	public long KMEFBNBFJHI()
	{
		if(NNBNNPOEJLK == 0)
			return 0;

		bool isLocked = false;
		Monitor.Enter(CBHDHHIHLLG, ref isLocked);

		long res = NNBNNPOEJLK + BMIKAALKIJC();
		if(isLocked)
			Monitor.Exit(CBHDHHIHLLG);

		return res;
	}

	// // RVA: 0x1203BE8 Offset: 0x1203BE8 VA: 0x1203BE8
	// private int AHFNOPDCBIA(int OHDPMGMGJBI) { }

	// // RVA: 0x1203BF8 Offset: 0x1203BF8 VA: 0x1203BF8
	// public string MAFDCGIIMOE() { }

	// // RVA: 0x1203D5C Offset: 0x1203D5C VA: 0x1203D5C
	public void EAJMLOKKOOK(long NCNFAEKLJGA)
	{
		NNBNNPOEJLK = NCNFAEKLJGA;
		FLMCOGBDCCF = Utility.GetCurrentUnixTime();
		bool isLocked = false;
		Monitor.Enter(CBHDHHIHLLG, ref isLocked);

		KBHHALOMJCI = GameManager.Instance.appBootTime.ElapsedMilliseconds;

		if(isLocked)
			Monitor.Exit(CBHDHHIHLLG);
	}

	// // RVA: 0x1203F04 Offset: 0x1203F04 VA: 0x1203F04
	// private long OPALLHDEOAL() { }

	// // RVA: 0x1203A60 Offset: 0x1203A60 VA: 0x1203A60
	private long BMIKAALKIJC()
	{
		bool isLocked = false;
		Monitor.Enter(CBHDHHIHLLG, ref isLocked);

		long res = GameManager.Instance.appBootTime.ElapsedMilliseconds - KBHHALOMJCI;

		if(isLocked)
			Monitor.Exit(CBHDHHIHLLG);

		return res;
	}
}