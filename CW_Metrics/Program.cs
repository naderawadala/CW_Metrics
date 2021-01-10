using CW_Metrics.Tennis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CW_Metrics
{
	class Program
	{
		static void Main(string[] args)
		{
			// normal score
			TennisGame normalGame = new TennisGame("John", "Doe");
			normalGame.WonPoint("John");
			normalGame.WonPoint("Doe");
			normalGame.WonPoint("John");
			normalGame.WonPoint("Doe");
			normalGame.WonPoint("John");
			Console.WriteLine(normalGame.GetScore());
			Console.WriteLine();
			// tied game
			TennisGame tiedGame = new TennisGame("John", "Doe");
			tiedGame.WonPoint("John");
			tiedGame.WonPoint("Doe");
			tiedGame.WonPoint("John");
			tiedGame.WonPoint("Doe");
			tiedGame.WonPoint("John");
			tiedGame.WonPoint("Doe");
			Console.WriteLine(tiedGame.GetScore());
			Console.WriteLine();
			// advantage
			TennisGame advantageGame = new TennisGame("John","Doe");
			advantageGame.WonPoint("John");
			advantageGame.WonPoint("Doe");
			advantageGame.WonPoint("John");
			advantageGame.WonPoint("Doe");
			advantageGame.WonPoint("John");
			advantageGame.WonPoint("Doe");
			advantageGame.WonPoint("John");
			Console.WriteLine(advantageGame.GetScore());
			Console.WriteLine();
			// wingame
			TennisGame winGame = new TennisGame("John", "Doe");
			winGame.WonPoint("John");
			winGame.WonPoint("Doe");
			winGame.WonPoint("John");
			winGame.WonPoint("Doe");
			winGame.WonPoint("John");
			winGame.WonPoint("John");
			Console.WriteLine(winGame.GetScore());
			Console.WriteLine();



			Console.ReadLine();
		}
	}
}
