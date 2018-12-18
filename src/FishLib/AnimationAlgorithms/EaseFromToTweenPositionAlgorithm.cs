using System;

namespace System.FishLib.AnimationAlgorithms
{
	/// <summary>
	/// EaseFromTo
	/// </summary>
	public class EaseFromToTweenPositionAlgorithm : TweenPositionAlgorithm
	{
		#region Overrides of TweenPositionAlgorithm

		/// <summary>
		/// �����ָ����ʱ��̶���Ӧ�ô��ڵ�λ��
		/// </summary>
		/// <param name="pos"></param>
		/// <returns></returns>
		public override double GetPosition(double pos)
		{
			if ((pos /= 0.5) < 1)
				return 0.5 * Math.Pow(pos, 4);
			return -0.5 * ((pos -= 2) * Math.Pow(pos, 3) - 2);

		}

		#endregion
	}
}