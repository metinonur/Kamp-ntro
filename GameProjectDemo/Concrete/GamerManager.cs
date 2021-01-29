using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    //MicroService
    class GamerManager : IGamerService
    {
        IUserValidation _userValidationService;

        public GamerManager(IUserValidation userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer)==true)
            {
                Console.WriteLine("Kayıt oldu : " + gamer.FirstName);
            }
            else
            {
                Console.WriteLine("Doğrulama başarısız.Kayıt başarısız.");
            }

           
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kayıt güncellendi ");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kayıt silindi ");
        }
    }
}
