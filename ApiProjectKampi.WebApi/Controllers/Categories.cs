﻿using ApiProjectKampi.WebApi.Context;
using ApiProjectKampi.WebApi.Controllers.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiProjectKampi.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Categories : ControllerBase
    {
        private readonly ApiContext _context;


        public Categories(ApiContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult CategoryList()
        {


            var values = _context.Categories.ToList();
            return Ok(values);
        }

        [HttpPost]

        public IActionResult CreateCategory(Category category)
        {

            _context.Categories.Add(category);
            _context.SaveChanges();
            return Ok("Kategory ekleme başarılı");

        }


        [HttpDelete]
        public IActionResult DeleteCategory(int id)
        {




            var value = _context.Categories.Find(id);
            _context.Categories.Remove(value);
            _context.SaveChanges();
            return Ok("silindi");

        }


        [HttpGet("GetCategory")]


        public IActionResult GetCategory(int id)
        {

            var value = _context.Categories.Find(id);
            return Ok(value);


        }


        [HttpPut]


        public IActionResult UpdateCategory(Category category)
        {
            _context.Categories.Update(category);
            _context.SaveChanges();
            return Ok("güncellendi");

        }

    }


}
