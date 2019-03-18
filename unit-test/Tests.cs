using System;
using System.Collections.Generic;
using NUnit.Framework;
using rock_paper_scissors;

namespace unit_test
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void AnyStrategyDifferentFromRpsShouldThrowNoSuchStrategyError()
        {
            var exceptionMessage = "";
            try
            {
                var game = new List<List<string>>
                {
                    new List<string> {"Armando", "R"}, new List<string> {"Dave", "X"}
                };
                RockPaperScissors.rps_game_winner(game);
            }
            catch (Exception e)
            {
                exceptionMessage = e.Message;
            }
            finally
            {
                Assert.AreEqual("NoSuchStrategyError", exceptionMessage);   
            }
        }
        
        [Test]
        public void EqualMovesShouldMakeWinnerTheFirstPlayer()
        {
            var game = new List<List<string>> { new List<string>{"Armando", "R"}, new List<string>{"Dave", "R"} };
            var gameWinner = RockPaperScissors.rps_game_winner(game);
            Assert.AreEqual(new List<string>{"Armando", "R"}, gameWinner);
        }
        
        [Test]
        public void LessThanTwoPlayersShouldThrowWrongNumberOfPlayersError()
        {
            var exceptionMessage = "";
            try
            {
                var game = new List<List<string>>
                {
                    new List<string> {"Armando", "R"}
                };
                RockPaperScissors.rps_game_winner(game);
            }
            catch (Exception e)
            {
                exceptionMessage = e.Message;
            }
            finally
            {
                Assert.AreEqual("WrongNumberOfPlayersError", exceptionMessage);   
            }
        }
        
        [Test]
        public void MoreThanTwoPlayersShouldThrowWrongNumberOfPlayersError()
        {
            var exceptionMessage = "";
            try
            {
                var game = new List<List<string>>
                {
                    new List<string> {"Armando", "R"}, new List<string> {"Dave", "R"}, new List<string> {"Marcelo", "R"}
                };
                RockPaperScissors.rps_game_winner(game);
            }
            catch (Exception e)
            {
                exceptionMessage = e.Message;
            }
            finally
            {
                Assert.AreEqual("WrongNumberOfPlayersError", exceptionMessage);   
            }
        }
        
        [Test]
        public void PaperShouldWinRock()
        {
            var game = new List<List<string>> { new List<string>{"Armando", "R"}, new List<string>{"Dave", "P"} };
            var gameWinner = RockPaperScissors.rps_game_winner(game);
            Assert.AreEqual(new List<string>{"Dave", "P"}, gameWinner);
        }
        
        [Test]
        public void RockShouldWinScissors()
        {
            var game = new List<List<string>> { new List<string>{"Armando", "S"}, new List<string>{"Dave", "R"} };
            var gameWinner = RockPaperScissors.rps_game_winner(game);
            Assert.AreEqual(new List<string>{"Dave", "R"}, gameWinner);
        }
        
        [Test]
        public void ScissorsShouldWinPaper()
        {
            var game = new List<List<string>> { new List<string>{"Armando", "S"}, new List<string>{"Dave", "P"} };
            var gameWinner = RockPaperScissors.rps_game_winner(game);
            Assert.AreEqual(new List<string>{"Armando", "S"}, gameWinner);
        }
    }
}