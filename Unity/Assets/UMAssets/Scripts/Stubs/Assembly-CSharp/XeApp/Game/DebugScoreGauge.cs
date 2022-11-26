using UnityEngine.UI;
using UnityEngine;

namespace XeApp.Game
{
	public class DebugScoreGauge : DebugCheatUIBase
	{
		private void Awake()
		{
			UnityEngine.Debug.LogError("Implement monobehaviour");
		}
		[SerializeField]
		private Text _textArea;
		[SerializeField]
		private Button _resetButton;
	}
}
