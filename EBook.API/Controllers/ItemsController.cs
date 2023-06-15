using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EBook.API.Data;
using EBook.API.Data.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using AutoMapper;
using EBook.API.Data.DTOs;
using StoreApp.API.Data.DTOs.UserDTOs;

namespace EBook.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]


    public class ItemsController : ControllerBase
    {
        private readonly UserManager<Item> _manager;

        private readonly StoreDBContext _context;
        private readonly IMapper _mapper;


        public ItemsController(StoreDBContext context, IMapper mapper)
        {

            _context = context;
            _mapper = mapper;
        }

        // GET= api/Items
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Item>>> GetItems()
        {
          if (_context.Items == null)
          {
              return NotFound();
          }
            return await _context.Items.ToListAsync();
        }

        // GET= api/Items/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Item>> GetItem(int id)
        {
          if (_context.Items == null)
          {
              return NotFound();
          }
            var item = await _context.Items.FindAsync(id);

            if (item == null)
            {
                return NotFound();
            }

            return item;
        }

        // PUT= api/Items/5
        // To protect from overposting attacks, see https=//go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        [Authorize(Roles = "Admin")]

        public async Task<IActionResult> PutItem(int id, ItemDTO itemDTO)
        {
            Item itemTOEdit = _mapper.Map<Item>(itemDTO);
            itemTOEdit.Id = id;
            itemTOEdit.Quantity = 1;
            itemTOEdit.LikeToggleStatus = "favorite_border";

            if (id != itemTOEdit.Id)
            {
                return BadRequest();
            }

            _context.Entry(itemTOEdit).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ItemExists(id))
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

        //POST= api/Items
        // To protect from overposting attacks, see https=//go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult<bool>> PostItem(ItemDTO itemDTO)
        {

            Item newItem = _mapper.Map<Item>(itemDTO);
            newItem.Quantity = 1;
            newItem.LikeToggleStatus = "favorite_border";


             _context.Items.Add(newItem);
                await _context.SaveChangesAsync();

                return Ok(true);

            
           
        }




        // DELETE= api/Items/5
        [HttpDelete("{id}")]
        [Authorize(Roles = "Admin")]

        public async Task<IActionResult> DeleteItem(int id)
        {
            if (_context.Items == null)
            {
                return NotFound();
            }
            var item = await _context.Items.FindAsync(id);
            if (item == null)
            {
                return NotFound();
            }

            _context.Items.Remove(item);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ItemExists(int id)
        {
            return (_context.Items?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
