﻿using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ChangFei.Route.Controllers
{
    [Route("")]
    [ApiController]
    public class GroupController:Controller
    {
        [HttpGet]
        public Task GetGroupsAsync()
        {
            return Task.CompletedTask;
        }

        [HttpPost]
        public Task CreateGroupAsync()
        {
            return Task.CompletedTask;
        }
    }
}
