using System.Collections.Generic;
using NUnit.Framework;
using rock_paper_scissors;

namespace unit_test
{
    [TestFixture]
    public class TournamentTests
    {
        [Test]
        public void OneRoundTournamentShouldWork()
        {
            var tournament = new List<dynamic>
            {
                new List<string>{"Armando", "P"}, new List<string>{"Dave", "S"}
            };
            var tournamentWinner = RockPaperScissors.rps_tournament_winner(tournament);
            Assert.AreEqual(new List<string>{"Dave", "S"}, tournamentWinner);
        }
        
        [Test]
        public void RichardShouldWinTheExampleTournament()
        {
            var tournament = new List<dynamic>
            {
                new List<dynamic>
                {
                    new List<dynamic>
                    {
                        new List<string>{"Armando", "P"}, new List<string>{"Dave", "S"}
                    },
                    new List<dynamic>
                    {
                        new List<string>{"Richard", "R"}, new List<string>{"Michael", "S"}
                    }
                },
                new List<dynamic>
                {
                    new List<dynamic>
                    {
                        new List<string>{"Allen", "S"}, new List<string>{"Omer", "P"}
                    },
                    new List<dynamic>
                    {
                        new List<string>{"David E.", "R"}, new List<string>{"Richard X.", "P"}
                    }
                }
            };
            var tournamentWinner = RockPaperScissors.rps_tournament_winner(tournament);
            Assert.AreEqual(new List<string>{"Richard", "R"}, tournamentWinner);
        }
        
        [Test]
        public void TwoRoundsTournamentShouldWork()
        {
            var tournament = new List<dynamic>
            {
                new List<dynamic>
                {
                    new List<string>{"Armando", "P"}, new List<string>{"Dave", "S"}
                },
                new List<dynamic>
                {
                    new List<string>{"Richard", "R"}, new List<string>{"Michael", "S"}
                }
            };
            var tournamentWinner = RockPaperScissors.rps_tournament_winner(tournament);
            Assert.AreEqual(new List<string>{"Richard", "R"}, tournamentWinner);
        }
    }
}