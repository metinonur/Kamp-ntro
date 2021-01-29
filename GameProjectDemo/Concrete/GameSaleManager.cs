using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GameSaleManager : IGameSaleService
    {
        public void Add(Game game)
        {
            Console.WriteLine("Game successfully added  : " + game.GameName);
        }

        public void Delete(Game game)
        {
            Console.WriteLine("Game successfully deleted : " + game.GameName);
        }
    }
}
