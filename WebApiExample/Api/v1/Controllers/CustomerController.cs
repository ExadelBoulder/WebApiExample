﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using WebApiExample.Api.v1.Models;

namespace WebApiExample.Api.v1.Controllers
{
    [RoutePrefix("api/v1/customer")]
    public class CustomerController : ApiController
    {
        /// <summary>
        /// Get all customers.
        /// </summary>
        [HttpGet]
        [Route("")]
        [ResponseType(typeof(ICollection<Customer>))]
        public HttpResponseMessage Get()
        {
            return Request.CreateResponse(System.Net.HttpStatusCode.OK, new List<Customer>());
        }

        /// <summary>
        /// Get a customer.
        /// </summary>
        [HttpGet]
        [Route("{id:int}")]
        [ResponseType(typeof(Customer))]
        public HttpResponseMessage Get(int id)
        {
            return Request.CreateResponse(System.Net.HttpStatusCode.OK, new Customer());
        }

        /// <summary>
        /// Create a customer.
        /// </summary>
        [HttpPost]
        [Route("")]
        [ResponseType(typeof(Customer))]
        public HttpResponseMessage Post(Customer value)
        {
            return Request.CreateResponse(System.Net.HttpStatusCode.OK, new Customer());
        }

        /// <summary>
        /// Update a customer.
        /// </summary>
        [HttpPut]
        [Route("{id:int}")]
        [ResponseType(typeof(Customer))]
        public HttpResponseMessage Put(int id, Customer value)
        {
            return Request.CreateResponse(System.Net.HttpStatusCode.OK, new Customer());
        }

        /// <summary>
        /// Partially update a customer.
        /// </summary>
        [HttpPatch]
        [Route("{id:int}")]
        [ResponseType(typeof(Customer))]
        public HttpResponseMessage Patch(int id, Customer value)
        {
            return Request.CreateResponse(System.Net.HttpStatusCode.OK, new Customer());
        }

        /// <summary>
        /// Delete a customer.
        /// </summary>
        [HttpDelete]
        [Route("{id:int}")]
        public HttpResponseMessage Delete(int id)
        {
            // Perhaps the delete customer functionality is currently broken...
            throw new Exception("This is a mysterious exception message generated by .NET");
        }
    }
}