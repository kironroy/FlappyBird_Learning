
// orginal work by : https://github.com/hao-phan-cs
// game here: https://github.com/hao-phan-cs/cs-flappybird-game

namespace ConsoleUI
{

    public class Program
    {
        static void Main()
        {
            var flyingBird = new MainGameLoop();

            flyingBird.ReadHighScoreFromFile();
            flyingBird.Setup();
            flyingBird.ShowMainMenu();

            while (true)
            {
                flyingBird.LoadScene();
            }
        }

    }

}