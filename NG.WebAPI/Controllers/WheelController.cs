using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using NG.Core.Extensions;
using NG.Core.Managers;
using NG.Core.Models.Account;
using NG.Data.Models;

namespace NG.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WheelController : ControllerBase
    {

        private AccountManager _accountManager;

        public WheelController(AccountManager accountManager)
        {
            _accountManager = accountManager;
        }



        [HttpPost("AddNewWheel")]
        public async Task<ActionResult<string>> AddNewWheel([FromBody]RegisterViewModel value)
        {

            if (await _accountManager.CheckEmail(value.Email))
                ModelState.AddModelError("Email", $"Email \"{value.Email}\" уже зарегистрирован");
            
            if (ModelState.IsValid)
            {
                return await _accountManager.Register(value);
            }
            
            return BadRequest(ModelState.ToBadRequest());
        }

        
    }
}


