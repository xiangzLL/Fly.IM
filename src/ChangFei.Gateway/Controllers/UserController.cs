﻿using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ChangFei.Route.Controllers
{
    public class UserController:Controller
    {
        public UserController()
        {

        }

        [HttpPost]
        public Task ChangeAvatar(string userId,string avatarData)
        {
            //Store image to oss
            return Task.CompletedTask;
        }

        [HttpPut]
        public Task CreateGroup()
        {
            return Task.CompletedTask;
        }
    }
}
