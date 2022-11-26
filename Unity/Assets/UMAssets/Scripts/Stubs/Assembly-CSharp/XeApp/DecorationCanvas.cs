using UnityEngine;
using UnityEngine.UI;

namespace XeApp
{
	public class DecorationCanvas : MonoBehaviour
	{
		[SerializeField]
		private RawImage m_bgImage;
		[SerializeField]
		private Material m_posterKiraMaterial;
		[SerializeField]
		private Material m_posterKiraMaterialFlip;
		private void Awake()
		{
			UnityEngine.Debug.LogError("Implement Monobehaviour");
		}
	}
}
