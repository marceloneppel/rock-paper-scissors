using System;
using System.Collections.Generic;

namespace rock_paper_scissors
{
    public static class Game
    {
        private const string NoSuchStrategyError = "NoSuchStrategyError";
        private const string WrongNumberOfPlayersError = "WrongNumberOfPlayersError";
        private static readonly HashSet<string> AllowedMoves = new HashSet<string>{"R", "P", "S"};

        public static List<string> rps_game_winner(List<List<string>> game)
        {
            // If the number of players is not equal to 2, raise WrongNumberOfPlayersError.
            if (game.Count != 2)
            {
                throw new Exception(WrongNumberOfPlayersError);
            }

            var firstPlayerMove = game[0][1].ToUpper();
            var secondPlayerMove = game[1][1].ToUpper();

            // If either player's strategy is something other than "R", "P" or "S" (case-insensitive), raise NoSuchStrategyError.
            if (!AllowedMoves.Contains(firstPlayerMove) || !AllowedMoves.Contains(secondPlayerMove))
            {
                throw new Exception(NoSuchStrategyError);
            }

            // If both players play the same move, the first player is the winner.
            if (firstPlayerMove == secondPlayerMove)
            {
                return game[0];
            }

            // Otherwise, return the name and move of the winning player.
            List<string> gameWinner = null;
            switch (firstPlayerMove)
            {
                case "R":
                    gameWinner = secondPlayerMove == "P" ? game[1] : game[0];
                    break;
                case "P":
                    gameWinner = secondPlayerMove == "S" ? game[1] : game[0];
                    break;
                case "S":
                    gameWinner = secondPlayerMove == "R" ? game[1] : game[0];
                    break;
            }
            return gameWinner;
        }

        public static List<string> rps_tournament_winner(List<dynamic> tournamentRound)
        {
            if (tournamentRound[0] is List<string>)
            {
                var game = new List<List<string>>{tournamentRound[0] as List<string>, tournamentRound[1] as List<string>};
                return rps_game_winner(game);
            }

            var firstGameWinner = rps_tournament_winner(tournamentRound[0] as List<dynamic>);
            var secondGameWinner = rps_tournament_winner(tournamentRound[1] as List<dynamic>);
            
            return rps_game_winner(new List<List<string>> {firstGameWinner, secondGameWinner});
        }
    }
}