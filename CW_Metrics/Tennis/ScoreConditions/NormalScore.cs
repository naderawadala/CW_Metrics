using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_Metrics.Tennis.ScoreConditions
{
	class NormalScore : Score
	{
		private const int maxScore = 3;
		private Dictionary<int, string> scoreNames;
		public NormalScore(Player player1, Player player2) : base(player1, player2)
		{
			scoreNames = new Dictionary<int, string>();
			scoreNames.Add(0, "Love");
			scoreNames.Add(1, "Fifteen");
			scoreNames.Add(2, "Thirty");
			scoreNames.Add(3, "Forty");
		}
		public override bool isAppliable()
		{
			return playerOne.GetScore() <= maxScore && playerTwo.GetScore() <= maxScore;
		}
		public override string toString()
		{
			return ScoreName(playerOne.GetScore()) + " - " + ScoreName(playerTwo.GetScore());
		}

		private string ScoreName(int score)
		{
			return scoreNames[score];
			
		}
	}
}
