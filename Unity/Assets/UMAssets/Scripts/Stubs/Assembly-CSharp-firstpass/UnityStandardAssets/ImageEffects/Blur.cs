using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	public class Blur : MonoBehaviour
	{
		public int iterations;
		public float blurSpread;
		public Shader blurShader;
		private void Awake()
		{
			UnityEngine.Debug.LogError("Implement Monobehaviour");
		}
	}
}
