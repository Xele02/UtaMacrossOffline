using UnityEngine.UI;
using XeSys.Gfx;

namespace XeApp.Game.Common
{
	public class FontAlignmentModifier : BaseMeshEffect, ILayoutUGUIPaste
	{
		private void Awake()
		{
			UnityEngine.Debug.LogError("Implement monobehaviour");
		}
		public bool InitializeFromLayout(Layout layout, TexUVListManager uvMan)
		{
			//throw new System.NotImplementedException();
			return true;
		}

		public override void ModifyMesh(VertexHelper vh)
		{
		}

	}
}
