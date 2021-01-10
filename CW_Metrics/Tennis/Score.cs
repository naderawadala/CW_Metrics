using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_Metrics.Tennis
{
	public abstract class Score
	{
		protected Player playerOne;
		protected Player playerTwo;

		public Score(Player player1, Player player2)
		{
			this.playerOne = player1;
			this.playerTwo = player2;
		}

		public abstract bool isAppliable();


		public abstract string toString();
	}
}
