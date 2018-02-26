﻿//-----------------------------------------------------------------------
// <copyright file= "HomeController.cs">
//     Copyright (c) Danvic712. All rights reserved.
// </copyright>
// Author: Danvic712
// Date Created: 2018-02-08 19:35:43
// Modified by:
// Description: Administrator-Home控制器
//-----------------------------------------------------------------------
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;

namespace Controllers.PSU.Areas.Administrator
{
    [Area("Administrator")]
    //[Authorize(Roles = "Administrator")]
    public class HomeController : Controller
    {
        #region Initialize
        #endregion

        #region View

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Bulletin()
        {
            return View();
        }

        public IActionResult Detail()
        {
            return View();
        }

        public IActionResult Edit()
        {
            return View();
        }

        #endregion

        #region Service
        #endregion
    }
}
