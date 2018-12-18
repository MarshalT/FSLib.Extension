using System;

namespace System.FishLib.AnimationAlgorithms
{
	/// <summary>
	/// EaseInQuad�㷨
	/// </summary>
	public class EaseInQuadTweenPositionAlgorithm : TweenPositionAlgorithm
	{
		#region Overrides of TweenPositionAlgorithm

		/// <summary>
		/// �����ָ����ʱ��̶���Ӧ�ô��ڵ�λ��
		/// </summary>
		/// <param name="pos"></param>
		/// <returns></returns>
		public override double GetPosition(double pos)
		{
			return Math.Pow(pos, 2);
		}

		#endregion
	}
}