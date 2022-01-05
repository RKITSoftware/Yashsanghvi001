using System;
using System.Collections.Generic;
using System.Net;
using System.Web.Http;

namespace Http_Verbs.Controllers
{
    public class PeopleController : ApiController
    {
        //Creating object of class BLPeople
        BLPeople lstperson = new BLPeople();


                /// <summary>
                /// Get()
                /// method return List person
                /// with all it's items
                /// </summary>
                /// <returns>List of type person</returns>
       
        [Route("")]
        [Route("Default")]
        [Route("api/people")]
        [HttpGet]
        public List<Person> Get()
        {
            List<Person> people = listperson.GetCompleteList();
            return people;
        }

                /// <summary>
                /// Get(int id) method 
                /// match id given by user with list item
                /// if id found in the list then it will return that person object
                /// </summary>
                /// <param name="id">id is unique identity number for each person</param>
                /// <returns>return Person object</returns>
       
        [Route("api/people/{id}")]
        [HttpGet]
        public Person Get(int id)
        {
            return listperson.GetListByID(id);
        }

                /// <summary>
                /// Post([FromBody]Person value)
                /// method add item to list person
                /// values is taken from body
                /// </summary>
                /// <param name="value">
                /// val is object type of person 
                /// which contains FirstName, LastName & Id of person
                /// </param>
       
        [Route("api/people")]
        [HttpPost]
        public void Post([FromBody] Person value)
        {
            listperson.AddItem(value);
        }

                /// <summary>
                /// Put(int id, [FromBody] Person value)
                /// method edit FirstName, LastName of person based on it's Id
                /// where, id is taken from uri & value of person object is taken from body
                /// </summary>
                /// <param name="id">id is unique identity number for each person</param>
                /// <param name="value">
                /// val is object type of person 
                /// which contains FirstName, LastName & Id of person
                /// </param>
               
        [Route("api/people/{id}")]
        [HttpPut]
        public void Put(int id, [FromBody] Person value)
        {
            listperson.EditItem(id, value);
        }

                /// <summary>
                /// Delete(int id)
                /// method remove item from the list
                /// whose id matches to the id given by user
                /// where, id is taken from URI
                /// </summary>
                
        [Route("api/people/{id}")]
        [HttpDelete]
        public void Delete(int id)
        {
            listperson.RemoveItem(id);
        }
    }
}
