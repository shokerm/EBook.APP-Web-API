using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EBook.API.Data;
using EBook.API.Data.Entities;
using EBook.API.Data.DTOs;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;

namespace EBook.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalesController : ControllerBase
    {
        private readonly StoreDBContext _context;
        private readonly IMapper _mapper;


        public SalesController(StoreDBContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
            
        }

        // GET= api/Sales
        [HttpGet]
        [Authorize]
        public async Task<ActionResult<IEnumerable<SaleItemDTO>>> GetSales()
        {
            if (_context.Sales == null)
            {
                return NotFound();
            }

            var p = (from s in _context.Sales
                     join i in _context.Items
                     on s.ItemId equals i.Id
                     select new SaleItemDTO
                     {
                         Id = s.Id,
                         UserId = s.UserId,
                         Product = i.Name,
                         ItemId = i.Id,
                         Quantity = s.Quantity,
                         SaleDate = s.SaleDate
                         
                     }
                   ).ToList();
            return p;

        }

        // GET= api/Sales/5
        [HttpGet("{id}")]
        [Authorize]

        public async Task<ActionResult<Sale>> GetSale(int id)
        {
          if (_context.Sales == null)
          {
              return NotFound();
          }
            var sale = await _context.Sales.FindAsync(id);

            if (sale == null)
            {
                return NotFound();
            }

            return sale;
        }

        // PUT= api/Sales/5
        // To protect from overposting attacks, see https=//go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        [Authorize]

        public async Task<IActionResult> PutSale(int id, Sale sale)
        {
            if (id != sale.Id)
            {
                return BadRequest();
            }

            _context.Entry(sale).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SaleExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST= api/Sales
        // To protect from overposting attacks, see https=//go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        [Authorize]

        public async Task<ActionResult<Sale>> PostSale(Sale sale)
        {
          if (_context.Sales == null)
          { 
              return Problem("Entity set 'StoreDBContext.Sales'  is null.");
          }
            sale.SaleDate = DateTime.Now;
            _context.Sales.Add(sale);
            await _context.SaveChangesAsync();
            
            return CreatedAtAction("GetSale", new { id = sale.Id }, sale);
        }

        // DELETE= api/Sales/5
        [HttpDelete("{id}")]
        [Authorize]

        public async Task<IActionResult> DeleteSale(int id)
        {
            if (_context.Sales == null)
            {
                return NotFound();
            }
            var sale = await _context.Sales.FindAsync(id);
            if (sale == null)
            {
                return NotFound();
            }

            _context.Sales.Remove(sale);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SaleExists(int id)
        {
            return (_context.Sales?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
