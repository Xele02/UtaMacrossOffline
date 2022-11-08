using UnityEngine;
using UnityEngine.UI;
using XeSys.Gfx;

namespace XeApp.Game.Menu
{
	public class SceneIconDecorationBehaviour : MonoBehaviour, ILayoutUGUIPaste
	{
		[SerializeField]
		private Text[] m_texts;
		[SerializeField]
		private RawImageEx[] m_skillImages;
		[SerializeField]
		private AnimeCurveScriptableObject m_animeCurve;
		[SerializeField]
		private EpisodeNameParts m_episodeNamePrefab;

		public bool InitializeFromLayout(Layout layout, TexUVListManager uvMan)
		{
			throw new System.NotImplementedException();
		}

		private void Awake()
		{
			UnityEngine.Debug.LogError("Implement Monobehaviour");
		}
	}
}
