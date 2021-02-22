using System;
using System.Collections.Generic;
using System.Linq;
using DataLayer.TableSets;
using DillyWilly.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Serilog;
using static DillyWilly.Utilities.Utilities;

namespace DillyWilly.Controllers
{
    [ApiController]
    [Route("[controller]/Api/movies")]
    public class MoviesController : ControllerBase
    {
        private readonly ILogger<MoviesController> _logger;
        private Movie _movie;


        public MoviesController(ILogger<MoviesController> logger,Movie movie)
        {
            _movie = movie;
            _logger = logger;
            
            // _logger = logger;
        }
        [HttpGet]
        public IActionResult GetMovies()
        {


            _logger.LogInformation("Getting a movie list");
            var movieList = GetMovieList();
            return Ok(movieList);
        }

        [HttpGet("{id}")]
        public IActionResult GetMovieById(int? id)
        {
            if (id is null)
            {
                _logger.LogError("Id is invalid! Need to enter a valid Id for searching!");

                return BadRequest($"The ID contains now value {id}");
            }

            _logger.LogInformation($"Getting a movie with id of {id}");
            var movie = from s in GetMovieList()
                        where id == s.MovieId
                        select (s);
            return Ok(movie);
        }

        [HttpGet("title")]
        public IActionResult GetMoviesByName(string title)
        {
            try
            {
                if (string.IsNullOrEmpty(title))
                {
                    _logger.LogError("The title cannot be empty");
                    return NoContent();
                }

                _logger.LogInformation("Getting a movie by name");
                var movie = from s in GetMovieList()
                            where title == s.Title
                            

                            select (s);
                return Ok(movie);
            }
            catch (Exception ex)
            {

                _logger.LogError($"{ex.Message}");
                return NotFound("Could not find the title of the movie");
            }

        }
        
    }


}



