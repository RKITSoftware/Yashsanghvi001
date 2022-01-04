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

        [Route("api/Getall")]
        public List<Movie> GetAll()
        {
            return (objdatabase.selectAll());
        }

        [Route("api/Get/{id}")]
        public Movie Get(int id)
        {
            return (objdatabase.getMovieById(id));
        }

        [HttpPost]
        [Route("api/Add")]
        public void Add([FromBody] Movie WatchMovie)
        {
            objdatabase.addMovie(WatchMovie);
        }

        [HttpPost]
        [Route("api/Update")]
        public void Update([FromBody] Movie WatchMovie)
        {
            objdatabase.update(WatchMovie);
        }

        [Route("api/Delete/{id}")]
        public void Delete(int id)
        {
            objdatabase.deleteMovie(id);
        }

    }
}


