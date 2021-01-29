using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GameOwnerManager : IGameOwnerService
    {
        public void OwnGame(Gamer gamer, Game game)
        {
            Console.WriteLine(gamer.FirstName  +" bought to "+ game.GameName  );
        }
    }
}
