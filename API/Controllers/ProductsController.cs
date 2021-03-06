using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;

namespace API.Controllers
{

    [ApiController]
    [Route("[controller]")] 
    public class ProductsController:ControllerBase
    {
    private readonly StoreContext _context;

    public ProductsController(StoreContext context)
    {
      _context = context;
    }
[HttpGet]
public async Task<ActionResult<List<Product>>> getProducts(){
var products=await _context.products.ToListAsync();
return Ok(products);
}


 [HttpGet("{id}")]
public async Task<ActionResult<Product>> getProduct(int id){
return await _context.products.FindAsync(id);

}   



        
        
    }
}