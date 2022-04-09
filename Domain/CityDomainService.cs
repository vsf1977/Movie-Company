﻿using Microsoft.AspNetCore.Mvc;
using PruebaPNG.DataAccess;
using PruebaPNG.Models;
using System;
using System.Linq;

namespace PruebaPNG.Domain
{
    public class CityDomainService
    {
        private MovieDbContext _context;
        public CityDomainService(MovieDbContext movieDbContext)
        {
            _context = movieDbContext;
        }

        public ActionResult<dynamic> GetAll()
        {            
            return _context.City.ToList();
        }

    }
}
