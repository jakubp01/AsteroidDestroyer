namespace test
{
    public class GameSetupService
    {

        public GameSetupService()
        {

        }
        public void Setup(float pointsToBeatLevel, int points, int randomOfAsteroidAppear, int gameLevel)
        {
            if (pointsToBeatLevel <= points)
            {
                if (gameLevel < 10)
                {
                    randomOfAsteroidAppear -= 2;
                    pointsToBeatLevel *= 1.5f;
                    gameLevel++;
                }
            }
        }
        public bool isGameOver(Scoreboard scoreboard, Player player, PutNicknameForm putNickname)
        {
            if (player._lifes < 1)
            {
                string points = player._points.ToString();

                scoreboard.AddToScoreboard(putNickname._playerNickname, points);
                return true;
            }
            else return false;
        }
    }
}
