﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Server.Data;
using Server.Models;

namespace Server.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationController : ControllerBase
    {
        private RestaurantContext _context;

        public ReservationController(RestaurantContext context)
        {
            _context = context;
        }

        [Route("{id:int}")]
        public ActionResult<OrderTable> GetById(int id)
        {
            var order = _context.ReservationsTables.FirstOrDefault(p => p.Id == id);
            if (order == null)
            {
                return NotFound();
            }

            return order;
        }

        [HttpPost]
        public ActionResult<OrderTable> Create(OrderTable orderTable)
        {
            _context.Add(orderTable);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetById), new { id = orderTable.Id }, orderTable);
        }
    }
}
