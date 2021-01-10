using CW_Metrics.Tennis.ScoreConditions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_Metrics.Tennis
{
	class TennisGame : ITennisGame
	{
		private Player playerOne;
		private Player playerTwo;


		public TennisGame(string player1Name, string player2Name)
		{
			this.playerOne = new Player(player1Name);
			this.playerTwo = new Player(player2Name);
		}

		public void WonPoint(string playerName)
		{
			FindPlayerByName(playerName).WonPoint();
		}

		public string GetScore()
		{
			foreach (Score score in possibleScores())
			{
				if (score.isAppliable())
				{
					return score.toString();
				}
			}
			return "";

		}

		private List<Score> possibleScores()
		{
			return new List<Score>()
			{
				new TieScore(playerOne, playerTwo),
				new WinScore(playerOne, playerTwo),
				new AdvantageScore(playerOne, playerTwo),
				new NormalScore(playerOne, playerTwo)
				
			};
		}

		private Player FindPlayerByName(string playername)
		{
			return playerOne.IsPlayer(playername) ? playerOne : playerTwo;
		}
	}
}
