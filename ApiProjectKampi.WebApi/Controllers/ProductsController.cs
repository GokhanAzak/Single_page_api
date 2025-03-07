using ApiProjectKampi.WebApi.Context;
using ApiProjectKampi.WebApi.Controllers.Entities;
using FluentValidation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiProjectKampi.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {


        private readonly IValidator<Product>  _validator;
        private readonly ApiContext _context;

        public ProductsController(IValidator<Product> validator, ApiContext context)
        {
            _validator = validator;
            _context = context;
        }

        [HttpGet]



        public IActionResult ProductList()
        {

            var values =_context.Products.ToList();
            return Ok(values);

        }

        [HttpPost]

        public IActionResult CreateProduct(Product product)
        {

            var validationResult= _validator.Validate(product);
            if (!validationResult.IsValid) { 
            
             return BadRequest(validationResult.Errors.Select(x=>x.ErrorMessage));
            }
        
            else
            {

                _context.Products.Add(product); 
                _context.SaveChanges();
                return Ok("Kayıt işlemi başarılı");
            }

        }



        [HttpDelete]

        public IActionResult DeleteProduct(int id)
        {

            var value = _context.Products.Find(id);
            _context.Products.Remove(value);
            _context.SaveChanges();
            return Ok(value);
        }



        [HttpGet("GetProdcut")]

        public IActionResult GetProduct(int id)
        {
            var value = _context.Products.Find(id);
            return Ok(value);
        }


        [HttpPut]

        public IActionResult UpdateProduct(Product product)
        {

            var validationResult = _validator.Validate(product);
            if (!validationResult.IsValid)
            {
                return BadRequest(validationResult.Errors.Select(_ => _.ErrorMessage));
            }

            else
            {

                _context.Products.Update(product);
                _context.SaveChanges();
                return Ok("gğncelleme başarılı");
            }

               
        }

    }

   
}
