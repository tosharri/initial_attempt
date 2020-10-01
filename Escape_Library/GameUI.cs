using AA_EscapeRoom_Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Escape_Console
{
    public class GameUI
    {
        private GameRepos _gameRepo = new GameRepos();
        //do not need to reference class library because they are referenced in the Methods

        public void Run()      // creating the entry
        {
            GameContent();
        }
      
    }
}





