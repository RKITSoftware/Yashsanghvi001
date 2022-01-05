using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRUD_Demo.Models
{
            /// <summary>
            /// Class moive contains public attributes .
            /// </summary>

    public class Movie
    {
            /// <summary>
            /// primary key - moiveID
            /// </summary>
       
        public int MovieId { get; set; }

        public string MovieName { get; set; }
    }
}