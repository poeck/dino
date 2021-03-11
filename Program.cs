using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinoGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"

                   ___  _         
                  / _ \(_)__  ___ 
                 / // / / _ \/ _ \
                /____/_/_//_/\___/

                - Simon Koeck -
          (https://github.com/simonkoeck)


    --------------- CONTROLS ---------------
       [ESC] To exit game [Space] To jump
    ----------------------------------------

       Press any key to start the Dino...");

            /** Wait for Key-Press */
            Console.ReadKey();

            Game game = new Game();
            game.Init();

            /** Stop Game */
            Console.ReadKey();
        }
    }
}
