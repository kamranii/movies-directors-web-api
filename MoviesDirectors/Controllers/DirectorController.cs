using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MoviesDirectors.Data;
using MoviesDirectors.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MoviesDirectors.Controllers
{
    
    public class DirectorController : BaseController
    {
        
        [HttpGet]
        //[ActionName("GetAllDirectors")]
        public IActionResult GetAll()
        {
            if (Database.directors.Count == 0)
                return NotFound("No directors were found");
            return Ok(Database.directors);
        }

       
        [HttpPost]
        public IActionResult Create(int id, string name, string surname, int age)
        {
            Director director = new Director(id, name, surname, age);
            Database.directors.Add(director);
            return Created($"director/create/{director.ID}",director);
        }

        //Update
        [HttpPut("{id}")]
        public IActionResult Update(int id, string name, string surname)
        {
            //find director
            Director director = Database.directors.FirstOrDefault(d => d.ID == id);
            //check
            if (director == null)
                return NotFound("Director was not found");
            //ok
            director.Name = name;
            director.Surname = surname;
            return Ok(director);
        }

        // DELETE api/values/5

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            //find director
            Director director = Database.directors.FirstOrDefault(d => d.ID == id);
            //check
            if (director == null)
                return NotFound("Director was not found");
            //ok
            Database.directors.Remove(director);
            return Ok(director);
        }
    }
}

