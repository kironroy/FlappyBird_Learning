using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;


// orginal work by: https://github.com/hao-phan-cs/cs-flappybird-game
// this is for learning purposes 


namespace FlappyBird_Replica_ConsoleVersion
{
    public static class MenuPrompts {

        public static void MenuTitle()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("||========================================================||");
            Console.WriteLine("||--------------------------------------------------------||");

            Console.Write("||---------------------- ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("FLAPPY BIRD");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" ---------------------||");

            Console.Write("||-------------------- ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Console version");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" -------------------||");
            Console.WriteLine("||========================================================||");
        }

        public static void PlayerOptions()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine();
            Console.WriteLine("                     PLAY GAME - press 1                  ");
            Console.WriteLine("                     HIGHSCORE - press 2                  ");
            Console.WriteLine("                     HELP      - press 3                  ");
            Console.WriteLine("                     CREDITS   - press 4                  ");
            Console.WriteLine("                     QUIT GAME - press 5                  ");
            Console.WriteLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("                        Have fun =))");
        }

        public static void PauseGame()
        {
            Console.CursorTop = 10;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            Console.WriteLine("        ============================================        ");
            Console.WriteLine("                         GAME PAUSED                        ");
            Console.WriteLine("              Resume game             - press 1             ");
            Console.WriteLine("              Restart game            - press 2             ");
            Console.WriteLine("              Return to the Main Menu - press 3             ");
            Console.WriteLine("        ============================================        ");
            Console.ForegroundColor = ConsoleColor.Green;
        }

        
        public static void ViewHelpMenu()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine();
            Console.WriteLine("||---------------------- FLAPPY BIRD ---------------------||");
            Console.WriteLine("                    ** Console verion **");
            Console.WriteLine("                        <<< HELPS >>>");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("         Keep the bird flying and avoiding the pipes");
            Console.WriteLine("     Don't let him touch the ground or the top of window");
            Console.WriteLine();
            Console.WriteLine("    Keyboard buttons: - Press Spacebar to raise the bird");
            Console.WriteLine("                      - Press R to restart game");
            Console.WriteLine("                      - Press ESC to pause game");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("           -- Press ESC to return to Main Menu --");
        }


    }
}
