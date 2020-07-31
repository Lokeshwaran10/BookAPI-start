﻿using BookGUI.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookGUI.Controllers
{
    public class CountriesController : Controller
    {
        ICountryRepositoryGUI _countryRepository;

        public CountriesController(ICountryRepositoryGUI countryRepository)
        {
            _countryRepository = countryRepository;
        }

        public IActionResult Index()
        {
            var countries = _countryRepository.GetCountries();

            if(countries.Count() <=0)
            {
                ViewBag.Message = "There was a problem retrieving countries from" +
                     "the database or no country exists";

            }
            return View(countries);
        }
    }
}
