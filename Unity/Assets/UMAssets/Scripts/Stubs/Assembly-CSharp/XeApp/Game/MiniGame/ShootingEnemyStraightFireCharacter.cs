using UnityEngine;

namespace XeApp.Game.MiniGame
{
	public class ShootingEnemyStraightFireCharacter : ShootingEnemyCharacter
	{
		[SerializeField]
		private float m_readyPos;
		[SerializeField]
		private int m_fireCountMax;
		[SerializeField]
		private float m_fireTimeMax;
	}
}
