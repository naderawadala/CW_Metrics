using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_Metrics.Tennis.ScoreConditions
{
	public class WinScore : Score
	{

		public WinScore(Player player1, Player player2) : base(player1, player2)
		{
		}
		public override bool isAppliable()
		{
			return playerOne.HasWon(playerTwo) || playerTwo.HasWon(playerOne);
		}
		public override string toString()
		{
			return "Winner is: " + GetWinner().GetName();
		}

		private Player GetWinner()
		{
			return playerOne.HasWon(playerTwo) ? playerOne : playerTwo;
		}
	}
}
