using UnityEngine.UI;
using UnityEngine;

public class InnerBevel : BaseMeshEffect, IMaterialModifier
{
	public enum ColorMode
	{
		Override = 0,
		Additive = 1,
		Multiply = 2,
	}

	public override void ModifyMesh(VertexHelper vh)
	{
	}

	public Material GetModifiedMaterial(Material baseMaterial)
	{
		throw new System.NotImplementedException();
	}

	[SerializeField]
	private ColorMode m_HighlightColorMode;
	[SerializeField]
	public Color m_HighlightColor;
	[SerializeField]
	private ColorMode m_ShadowColorMode;
	[SerializeField]
	public Color m_ShadowColor;
	[SerializeField]
	private Vector2 m_BevelDirectionAndDepth;
}
