using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CrudOperationsInNetCore.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CrudOperationsInNetCore.Controllers
{
   // [Route("api/[controller]")]
    [Route("api/Brand")]
    [ApiController]
    public class BrandController : ControllerBase
    {
        private readonly BrandContext _dbContext;

        // Constructor accepts BrandContext, not BrandController
        public BrandController(BrandContext dbContext)
        {
            _dbContext = dbContext;
        }

        // GET: api/Brand
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Brand>>> GetBrands()
        {
            if (_dbContext.Brands == null)
            {
                return NotFound();
            }
            return await _dbContext.Brands.ToListAsync();
        }

        // GET: api/Brand/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Brand>> GetBrand(int id)
        {
            if (_dbContext.Brands == null)
            {
                return NotFound();
            }
            var brand = await _dbContext.Brands.FindAsync(id);
            if (brand == null)
            {
                return NotFound();
            }
            return brand;
        }
        [HttpPost]
        public async Task<ActionResult<Brand>> PostBrand(Brand brand)
        {
           
            _dbContext.Brands.Add(brand);
            await _dbContext.SaveChangesAsync();
            return CreatedAtAction(nameof(GetBrand), new { id = brand.id}, brand);
           // return Ok(brand.Price);
        }
        [HttpPut]
        public async Task<ActionResult> PutBrand(int id, Brand brand)
        {
            if(id != brand.id)
            {
                return BadRequest();
            }
            _dbContext.Entry(brand).State = EntityState.Modified;
            try
            {
                await _dbContext.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BrandAvalible(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return Ok();
        }
        private bool BrandAvalible(int id)
        {
            return (_dbContext.Brands?.Any(x => x.id == id)).GetValueOrDefault();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult>DeleteBrand(int id)
        {
            if(_dbContext.Brands == null)
            {
                return NotFound();
            }
            var brand = await _dbContext.Brands.FindAsync(id);
            if(brand == null)
            {
                return NotFound();
            }
            _dbContext.Brands.Remove(brand);
            await _dbContext.SaveChangesAsync();
            return Ok();
        }
    }
}




/*
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CrudOperationsInNetCore.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CrudOperationsInNetCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandController : ControllerBase
    {
        private readonly BrandController _dbContext;
        public BrandController(BrandContext dbContext)
        {
            _dbContext = dbContext;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Brand>>> GetBrands()
        {
            if(_dbContext.Brands ==  null)
            {
                return NotFound();
            }
            return await _dbContext.Brands.ToListAsync();
        }



        [HttpGet]
        public async Task<ActionResult<Brand>> GetBrand(int id)
        {
            if (_dbContext.Brands == null)
            {
                return NotFound();
            }
            var brand = await _dbContext.Brands.FindAsync(id);
            if (brand == null)
            {
                return NotFound();
            }
            return brand;
        }
    }
}
*/