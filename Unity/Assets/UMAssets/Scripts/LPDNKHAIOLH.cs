
public class LPDNKHAIOLH
{
	private static int KNEFBLHBDBG; // 0x0
	private static uint PMBEODGMMBB = 0x15ab17a1; // 0x4

	// // RVA: 0x10CE2AC Offset: 0x10CE2AC VA: 0x10CE2AC
	private static uint FBGGEFFJJHB()
	{
		uint a = PMBEODGMMBB ^ (PMBEODGMMBB << 0xd);
		a = a ^ a >> 0x11;
		a = a ^ a << 5;
		PMBEODGMMBB = a;
		return PMBEODGMMBB;
	}

	// // RVA: 0x10CE360 Offset: 0x10CE360 VA: 0x10CE360
	public static void KHEKNNFCAOI_Init(int KNEFBLHBDBG)
    {
        PMBEODGMMBB = (uint)(KNEFBLHBDBG & 0x7fffffff);
    }

	// // RVA: 0x10CE3F4 Offset: 0x10CE3F4 VA: 0x10CE3F4
	public static int CEIBAFOCNCA()
	{
		return (int)(FBGGEFFJJHB() ^ 0x7fffffff);
	}

	// // RVA: 0x10CE470 Offset: 0x10CE470 VA: 0x10CE470
	// public static long HJBKGEBNJMP() { }
}
