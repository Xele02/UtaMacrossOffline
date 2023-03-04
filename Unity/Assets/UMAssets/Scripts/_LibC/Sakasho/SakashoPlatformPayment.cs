using XeSys;

namespace ExternLib
{
	public static partial class LibSakasho
	{
		public static int SakashoPlatformPaymentRecover(int callbackId, string json)
		{
			EDOHBJAPLPF_JsonData res = new EDOHBJAPLPF_JsonData();
			res.LAJDIPCJCPO_SetJsonType(JFBMDLGBPEN_JsonType.JKMLKAMHJIF_Object);
			res["SAKASHO_CURRENT_ASSET_REVISION"] = "20220602120304";
			res["SAKASHO_CURRENT_DATE_TIME"] = Utility.GetCurrentUnixTime();
			res["SAKASHO_CURRENT_MASTER_REVISION"] = 5;
			string message = res.EJCOJCGIBNG_ToJson();

			UnityEngine.GameObject.Find(UnityCallbackObject).SendMessage("NotifyOnSuccess", "" + callbackId + ":" + message);

			return 0;
		}
	}
}