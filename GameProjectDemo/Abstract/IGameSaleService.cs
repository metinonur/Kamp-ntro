using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    interface IGameSaleService
    {
        void Add(Game game);
        void Delete(Game game);
    }
}
