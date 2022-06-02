using UnityEngine.UI;
using UnityEngine;

namespace XeSys.Gfx
{
	public class RawImageEx : RawImage
	{
		[SerializeField]
		private Texture m_AlphaTexture;
		[SerializeField]
		private Material m_MaterialMul;
		[SerializeField]
		private Material m_MaterialAdd;
		[SerializeField]
		private string m_TextureName;
	}
}
