using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_Metrics.Tennis
{
	public class Player
	{
		private int Score { get; set; }
		private string Name { get; }

		private const int gameWinNumber = 4;
		private const int differencePointsNumber = 2;
		private const int advantageNumber = 1;
		public Player(string name)
		{
			this.Name = name;
			this.Score = 0;
		}
		public int GetScore()
		{
			return this.Score;
		}
		public string GetName()
		{
			return this.Name;
		}
		public void WonPoint()
		{
			Score++;
		}
		public bool IsPlayer(string name)
		{
			return this.Name == name;
		}
		public bool HasWon(Player otherPlayer)
		{
			int advantageOverOtherPlayer = Score - otherPlayer.Score;
			return Score >= gameWinNumber && advantageOverOtherPlayer >= differencePointsNumber;
		}
		public bool HasAdvantage(Player otherPlayer)
		{
			int advantageOverOtherPlayer = Score - otherPlayer.Score;
			return Score >= gameWinNumber && advantageOverOtherPlayer.Equals(advantageNumber);
		}
		public bool IsTied(Player otherPlayer)
		{
			return Score.Equals(otherPlayer.Score);
		}
	}
}
