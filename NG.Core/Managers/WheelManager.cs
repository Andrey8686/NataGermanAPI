using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Internal;
using Newtonsoft.Json;
using NG.Core.Models.Account;
using NG.Data;
using NG.Data.Models;

namespace NG.Core.Managers
{
    public class WheelManager
    {
        private NataGermanContext _db;

        public WheelManager(NataGermanContext db)
        {
            _db = db;
        }




        public async Task<string> AddNewWheel(WheelViewModel model)
        {
            try
            {
                var user = new NataGermanUser
                {
                    UserName = model.Email,
                    Email = model.Email,
                    LastName = model.LastName,
                    FirstName = model.FirstName,
                    Patronymic = model.Patronymic,
                };

                var result = await _userManager.CreateAsync(user, model.Password);

                return result.Succeeded ? "OK" : "Что то пошло не так...";
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            
        }

        public async Task<bool> CheckEmail(string email)
        {
            try
            {
                return _db.Users.Any(x => x.Email.ToLower() == email.ToLower());
            }
            catch
            {
                // ignore
            }
            
            return false;
        }

    }
}
