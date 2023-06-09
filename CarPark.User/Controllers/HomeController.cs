﻿using Amazon.Runtime.SharedInterfaces;
using CarPark.User.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Logging;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CarPark.User.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IStringLocalizer<HomeController> _localizer;
        public HomeController(ILogger<HomeController> logger, IStringLocalizer<HomeController> localizer)
        {
            _logger = logger;
            _localizer = localizer;
        }

        public IActionResult Index()
        {
            var say_Hello_value = _localizer["Say_Hello"];

            var cultureInfo = CultureInfo.GetCultureInfo("en-US");  
            Thread.CurrentThread.CurrentCulture = cultureInfo;  
            Thread.CurrentThread.CurrentUICulture = cultureInfo;


            var customer = new Customer
            {
                Id = 2,
                NameSurname = "Mertens",
                Age = 25,



            };
            
            _logger.LogError("There is a error on the customer object {@customer}",customer);


            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
