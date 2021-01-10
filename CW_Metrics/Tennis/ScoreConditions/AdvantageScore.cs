using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_Metrics.Tennis.ScoreConditions
{
	public class AdvantageScore : Score
	{
		public AdvantageScore(Player player1, Player player2) : base(player1, player2)
		{
		}
		public override bool isAppliable()
		{
			return playerOne.HasAdvantage(playerTwo) || playerTwo.HasAdvantage(playerOne);
		}
		public override string toString()
		{
			return "Advantage: " + GetAdvantage().GetName();
		}

		private Player GetAdvantage()
		{
			return playerOne.HasAdvantage(playerTwo) ? playerOne : playerTwo;
		}
	}
}
