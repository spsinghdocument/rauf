﻿using BAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;




namespace WebApi.Controllers
{
    public class spController : ApiController

    {
        private readonly IProductRepository _repository;
        public spController(IProductRepository repository)
        {
            _repository = repository;

        }
        public string Get()
        {
         var a=   _repository.getdata(18);
            return "Saurabh pratap singh = " + a;
        }
    }
}
