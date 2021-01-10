using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_Metrics.Tennis.ScoreConditions
{
	class TieScore : Score
	{
		private const int maxScore = 2;
		private Dictionary<int, string> scoreNames;
		public TieScore(Player player1, Player player2) : base(player1, player2)
		{
			this.scoreNames = new Dictionary<int, string>();
			scoreNames.Add(0, "Love");
			scoreNames.Add(1, "Fifteen");
			scoreNames.Add(2, "Thirty");
			scoreNames.Add(3, "Forty");
		}
		public override bool isAppliable()
		{
			return playerOne.IsTied(playerTwo);
		}
		public override string toString()
		{
			return playerOne.GetScore() > maxScore ? "Deuce" : ScoreName(playerOne.GetScore()) + "-All";
		}

		private string ScoreName(int score)
		{
			return scoreNames[score];
		}
	}
}
