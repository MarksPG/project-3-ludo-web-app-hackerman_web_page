﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RestSharp;

namespace Hackerman_WebbApp.Controllers
{

    [Route("Ludo")]
    public class LudoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> NewGame()
        {
            var client = new RestClient("http://localhost:57659/");

            var request = new RestRequest("/newgame", Method.POST);
            
            IRestResponse<int> createGameResponse = client.Execute<int>(request);

            var output = createGameResponse.Content;

            return View();



        }

        public IActionResult Gameboard()
        {
            return View();
        }
    }
}