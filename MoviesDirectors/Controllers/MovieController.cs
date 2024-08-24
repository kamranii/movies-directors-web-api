using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MoviesDirectors.Data;
using MoviesDirectors.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MoviesDirectors.Controllers;


public class MovieController : BaseController
{
    // GET All
    [HttpGet]
    public IActionResult GetAll()
    {
        if (Database.movies.Count == 0)
            return NotFound("No movies were found");
        return Ok(Database.movies);
    }

    // Get by director id
    [HttpGet]
    public IActionResult FilterByDirectorID(int directorId)
    {
        //find movie
        Movie? movie = Database.movies.FirstOrDefault(m => m.DirectorID == directorId);
        //check
        if (movie == null)
            return NotFound("No movie matched the criteria");
        return Ok(movie);
    }

    // Create
    [HttpPost]
    public IActionResult Create(int id, string name, string genre, int directorID)
    {
        Movie movie = new Movie(id, name, genre, directorID);
        //add date
        
        //add to db
        Database.movies.Add(movie);
        //ok
        return Created($"movie/create/${movie.ID}", movie);
    }

    // Update
    [HttpPut]
    public IActionResult Update(int id, string name, string genre)
    {
        //search
        Movie movie = Database.movies.FirstOrDefault(m => m.ID == id);
        //check
        if (movie == null)
            return NotFound("No movie was found");
        //update
        movie.Name = name;
        movie.Genre = genre;
        return Ok(movie);
    }

    // DELETE api/values/5
    [HttpDelete]
    public IActionResult Delete(int id)
    {
        //search
        Movie movie = Database.movies.FirstOrDefault(m => m.ID == id);
        //check
        if (movie == null)
            return NotFound("No movie was found");
        //delete
        Database.movies.Remove(movie);
        return Ok(movie);
    }
}

