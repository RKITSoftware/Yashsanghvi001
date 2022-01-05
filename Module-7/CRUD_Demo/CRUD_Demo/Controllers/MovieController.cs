using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CRUD_Demo.Models;

namespace CRUD_Demo.Controllers
{
    public class MovieController : Controller
    {

        database_DB objdatabase = new database_DB();

                /// <summary>
                /// Get all movie data
                /// </summary>
                /// <returns>
                /// returns a movie data
                /// </returns>

        [Route("api/Getall")]
        public List<Movie> GetAll()
        {
            return (objdatabase.selectAll());
        }

                /// <summary>
                /// Get movie data of particular parameter 'id'
                /// </summary>
                /// <param name="id">id is an unique identifier</param>
                /// <returns>
                /// returns movie data according to the ID
                /// </returns>

        [Route("api/Get/{id}")]
        public Movie Get(int id)
        {
            return (objdatabase.getMovieById(id));
        }

                /// <summary>
                /// Add new movie data
                /// </summary>
                /// watching is the moive object.

        [HttpPost]
        [Route("api/Add")]
        public void Add([FromBody] Movie WatchMovie)
        {
            objdatabase.addMovie(WatchMovie);
        }
     
                 /// <summary>
                /// Update movie data
                /// </summary>
                /// <param name="watchmovie">
                /// watching is the moive object.
                /// </param>
        
        [HttpPost]
        [Route("api/Update")]
        public void Update([FromBody] Movie WatchMovie)
        {
            objdatabase.update(WatchMovie);
        }

                /// <summary>
                /// Delete moive data with parameter 'id', where id is an unique identifier
                /// </summary>

        [Route("api/Delete/{id}")]
        public void Delete(int id)
        {
            objdatabase.deleteMovie(id);
        }

    }
}


