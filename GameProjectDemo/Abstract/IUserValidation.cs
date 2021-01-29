using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    //Kullanıcı doğrulama
    interface IUserValidation
    {
        bool Validate(Gamer gamer);
    }
}
