using System;

namespace System.FishLib.AnimationAlgorithms
{
	/// <summary>
	/// EaseOutCubic �㷨
	/// </summary>
	public class EaseOutCubicTweenPositionAlgorithm : TweenPositionAlgorithm
	{
		#region Overrides of TweenPositionAlgorithm

		/// <summary>
		/// �����ָ����ʱ��̶���Ӧ�ô��ڵ�λ��
		/// </summary>
		/// <param name="pos"></param>
		/// <returns></returns>
		public override double GetPosition(double pos)
		{
			return (Math.Pow((pos - 1), 3) + 1);
		}

		#endregion
	}
}